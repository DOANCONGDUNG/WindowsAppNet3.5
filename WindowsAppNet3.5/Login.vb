Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Login

    Public Function HashSHA256(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2")) ' chuyển byte thành hex
            Next
            Return sb.ToString()
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_LOGIN.Click

        Using conn As New OdbcConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM users WHERE username=? AND password=?"
                Dim cmd As New OdbcCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", TXT_USER.Text)
                cmd.Parameters.AddWithValue("@password", HashSHA256(TXT_PASS.Text))
                Using reader As OdbcDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        CurrentLoginUsername = reader("username")
                        CurrentLoginRole = reader("roleid")
                        GetRoleName(CurrentLoginRole)
                        Dim frm As New ListUser()
                        frm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("ユーザーidまたはパスワードが正しくありません。")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("エラー: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BTN_TOROKU_Click(sender As Object, e As EventArgs) Handles BTN_TOROKU.Click
        SignUp.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_FORGOT_Click(sender As Object, e As EventArgs) Handles BTN_FORGOT.Click
        Dim resetForm As New ResetPassword()
        resetForm.ShowDialog()
    End Sub

    Private Sub GetRoleName(roleId As String)
        Using conn As New OdbcConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT rolename FROM role WHERE roleid = ?"
                Dim cmd As New OdbcCommand(query, conn)
                cmd.Parameters.AddWithValue("@roleid", roleId)
                Dim roleName As String = cmd.ExecuteScalar()?.ToString()
                If Not String.IsNullOrEmpty(roleName) Then
                    CurrentLoginRoleName = roleName
                End If
            Catch ex As Exception
                MessageBox.Show("エラー: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
