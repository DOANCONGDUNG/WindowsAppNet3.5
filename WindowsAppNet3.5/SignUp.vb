Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text
Public Class SignUp

    Dim conn As New OdbcConnection(connStr)

    Public Function EncryptSHA256(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim sb As New StringBuilder()
            For Each b In hashBytes
                sb.Append(b.ToString("x2")) ' chuyển sang hex
            Next
            Return sb.ToString()
        End Using
    End Function
    Private Sub BTN_SIGNUP_Click(sender As Object, e As EventArgs) Handles BTN_SIGNUP.Click
        Dim username = TXT_USERID.Text.Trim()
        Dim email = TXT_EMAIL.Text.Trim()
        Dim password = TXT_PASS.Text
        Dim confirm = TXT_PASS_CONFIRM.Text
        Dim hashedPassword As String = EncryptSHA256(TXT_PASS.Text)
        If username = "" Then
            MessageBox.Show("ユーザーIDが必要です。")
            Return
        End If
        If password = "" Then
            MessageBox.Show("パスワードが必要です。")
            Return
        End If
        If confirm = "" Then
            MessageBox.Show("パスワード 認証が必要です。")
            Return
        End If
        If email = "" Then
            MessageBox.Show("メールアドレスが必要です。")
            Return
        ElseIf Not IsValidEmail(email) Then
            MessageBox.Show("無効なメールアドレス (例: abc@gmail.com)", "警告")
            TXT_EMAIL.Focus()
            Return
        End If
        If password <> confirm Then
            MessageBox.Show("パスワード 認証がパスワードと合わせない")
            Return
        End If
        conn.Open()
        Dim checkCmd As New OdbcCommand($"SELECT COUNT(*) FROM users WHERE username = '{TXT_USERID.Text.Trim()}'", conn)
        Dim check As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

        If check > 0 Then
            MessageBox.Show("ユーザーidが存在します。")
            conn.Close()
            Return
        End If
        Dim insertCmd As New OdbcCommand("INSERT INTO users (username,email, password, roleid) VALUES (?, ?, ?, ?)", conn)
        insertCmd.Parameters.AddWithValue("@username", username)
        insertCmd.Parameters.AddWithValue("@email", email)
        insertCmd.Parameters.AddWithValue("@password", hashedPassword) ' Bạn có thể mã hóa nếu cần
        insertCmd.Parameters.AddWithValue("@roleid", 1)
        insertCmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("正常に登録が完了しました。")
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        ' Mở lại FormLogin
        Dim frmLogin As New Login()
        frmLogin.Show()
        Me.Close()
    End Sub
End Class