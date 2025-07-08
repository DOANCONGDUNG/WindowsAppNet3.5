Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text

Public Class ResetPassword
    Private Sub BTN_RESET_Click(sender As Object, e As EventArgs) Handles BTN_RESET.Click
        Dim username As String = TXT_USER.Text.Trim()
        Dim newPassword As String = TXT_NEW_PASS.Text
        Dim confirmPassword As String = TXT_CONFIRM_PASS.Text
        If username = "" Or newPassword = "" Or confirmPassword = "" Then
            MessageBox.Show("すべての情報を入力してください。")
            Return
        End If
        If newPassword <> confirmPassword Then
            MessageBox.Show("パスワード確認が一致しません。")
            Return
        End If
        Using conn As New OdbcConnection(connStr)
            Try
                conn.Open()
                Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE username=?"
                Dim checkCmd As New OdbcCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@username", username)
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If exists = 0 Then
                    MessageBox.Show("ユーザーIDが存在しません。")
                    Return
                End If
                Dim updateQuery As String = "UPDATE users SET password=? WHERE username=?"
                Dim updateCmd As New OdbcCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@password", HashSHA256(newPassword))
                updateCmd.Parameters.AddWithValue("@username", username)
                updateCmd.ExecuteNonQuery()
                MessageBox.Show("パスワードのリセットに成功しました！")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("エラー: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Function HashSHA256(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function
End Class
