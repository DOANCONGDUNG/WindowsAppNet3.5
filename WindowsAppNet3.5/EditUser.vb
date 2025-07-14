Imports System.Data
Imports System.Data.Odbc
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class EditUser

    Public UserId As Integer
    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRolesToComboBox()
        LoadUserData(UserId)
    End Sub
    Private Sub LoadRolesToComboBox()
        Using conn As New OdbcConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT roleid, rolename FROM role"
                Dim adapter As New OdbcDataAdapter(query, conn)
                Dim dtRole As New DataTable()
                adapter.Fill(dtRole)
                Cb_Role.DataSource = dtRole
                Cb_Role.DisplayMember = "rolename"
                Cb_Role.ValueMember = "roleid"
            Catch ex As Exception
                MessageBox.Show("エラー: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub LoadUserData(userId As Integer)
        Using conn As New OdbcConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT id, username, email, roleid FROM users WHERE id = ?"
                Dim cmd As New OdbcCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", userId)
                Using reader As Odbc.OdbcDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Lbl_Id_Value.Text = reader("id").ToString()
                        Lbl_UserNM_Value.Text = reader("username")
                        Tb_Email.Text = reader("email").ToString()
                        Cb_Role.SelectedValue = reader("roleid").ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("エラー: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Close()
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Dim email As String = Tb_Email.Text.Trim()
        Dim role As String = Cb_Role.SelectedValue.ToString()
        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("メールアドレスを入力してください。", "警告")
            Tb_Email.Focus()
            Return
        ElseIf Not IsValidEmail(email) Then
            MessageBox.Show("無効なメールアドレス (例: abc@gmail.com)", "警告")
            Tb_Email.Focus()
            Return
        End If
        UpdateUser(email, role)
        MessageBox.Show("正常に更新が完了しました。")
        Me.Close()
    End Sub

    Public Sub UpdateUser(email As String, role As String)
        Dim query As String = "UPDATE users SET email = ?, roleid = ? WHERE id = ?"

        Using conn As New OdbcConnection(connStr)
            conn.Open()
            Using cmd As New OdbcCommand(query, conn)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@roleid", role)
                cmd.Parameters.AddWithValue("@id", UserId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class