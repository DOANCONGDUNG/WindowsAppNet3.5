<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LBL_USERID = New System.Windows.Forms.Label()
        Me.LBL_EMAIL = New System.Windows.Forms.Label()
        Me.LBL_PASS1 = New System.Windows.Forms.Label()
        Me.LBL_PASS_CONFIRM = New System.Windows.Forms.Label()
        Me.TXT_USERID = New System.Windows.Forms.TextBox()
        Me.TXT_EMAIL = New System.Windows.Forms.TextBox()
        Me.TXT_PASS = New System.Windows.Forms.TextBox()
        Me.TXT_PASS_CONFIRM = New System.Windows.Forms.TextBox()
        Me.BTN_SIGNUP = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_USERID
        '
        Me.LBL_USERID.AutoSize = True
        Me.LBL_USERID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_USERID.Location = New System.Drawing.Point(82, 48)
        Me.LBL_USERID.Name = "LBL_USERID"
        Me.LBL_USERID.Size = New System.Drawing.Size(64, 13)
        Me.LBL_USERID.TabIndex = 0
        Me.LBL_USERID.Text = "ユーザーID"
        '
        'LBL_EMAIL
        '
        Me.LBL_EMAIL.AutoSize = True
        Me.LBL_EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_EMAIL.Location = New System.Drawing.Point(82, 79)
        Me.LBL_EMAIL.Name = "LBL_EMAIL"
        Me.LBL_EMAIL.Size = New System.Drawing.Size(38, 13)
        Me.LBL_EMAIL.TabIndex = 1
        Me.LBL_EMAIL.Text = "メール"
        '
        'LBL_PASS1
        '
        Me.LBL_PASS1.AutoSize = True
        Me.LBL_PASS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_PASS1.Location = New System.Drawing.Point(82, 112)
        Me.LBL_PASS1.Name = "LBL_PASS1"
        Me.LBL_PASS1.Size = New System.Drawing.Size(59, 13)
        Me.LBL_PASS1.TabIndex = 2
        Me.LBL_PASS1.Text = "パスワード"
        '
        'LBL_PASS_CONFIRM
        '
        Me.LBL_PASS_CONFIRM.AutoSize = True
        Me.LBL_PASS_CONFIRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_PASS_CONFIRM.Location = New System.Drawing.Point(82, 148)
        Me.LBL_PASS_CONFIRM.Name = "LBL_PASS_CONFIRM"
        Me.LBL_PASS_CONFIRM.Size = New System.Drawing.Size(89, 13)
        Me.LBL_PASS_CONFIRM.TabIndex = 3
        Me.LBL_PASS_CONFIRM.Text = "パスワード 認証"
        '
        'TXT_USERID
        '
        Me.TXT_USERID.Location = New System.Drawing.Point(180, 41)
        Me.TXT_USERID.Name = "TXT_USERID"
        Me.TXT_USERID.Size = New System.Drawing.Size(100, 20)
        Me.TXT_USERID.TabIndex = 4
        '
        'TXT_EMAIL
        '
        Me.TXT_EMAIL.Location = New System.Drawing.Point(180, 72)
        Me.TXT_EMAIL.Name = "TXT_EMAIL"
        Me.TXT_EMAIL.Size = New System.Drawing.Size(100, 20)
        Me.TXT_EMAIL.TabIndex = 5
        '
        'TXT_PASS
        '
        Me.TXT_PASS.Location = New System.Drawing.Point(180, 109)
        Me.TXT_PASS.Name = "TXT_PASS"
        Me.TXT_PASS.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PASS.TabIndex = 6
        Me.TXT_PASS.UseSystemPasswordChar = True
        '
        'TXT_PASS_CONFIRM
        '
        Me.TXT_PASS_CONFIRM.Location = New System.Drawing.Point(180, 145)
        Me.TXT_PASS_CONFIRM.Name = "TXT_PASS_CONFIRM"
        Me.TXT_PASS_CONFIRM.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PASS_CONFIRM.TabIndex = 7
        Me.TXT_PASS_CONFIRM.UseSystemPasswordChar = True
        '
        'BTN_SIGNUP
        '
        Me.BTN_SIGNUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_SIGNUP.Location = New System.Drawing.Point(106, 186)
        Me.BTN_SIGNUP.Name = "BTN_SIGNUP"
        Me.BTN_SIGNUP.Size = New System.Drawing.Size(75, 23)
        Me.BTN_SIGNUP.TabIndex = 8
        Me.BTN_SIGNUP.Text = "登録"
        Me.BTN_SIGNUP.UseVisualStyleBackColor = True
        '
        'Btn_Back
        '
        Me.Btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Back.Location = New System.Drawing.Point(216, 186)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Back.TabIndex = 9
        Me.Btn_Back.Text = "戻る"
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.BTN_SIGNUP)
        Me.Controls.Add(Me.TXT_PASS_CONFIRM)
        Me.Controls.Add(Me.TXT_PASS)
        Me.Controls.Add(Me.TXT_EMAIL)
        Me.Controls.Add(Me.TXT_USERID)
        Me.Controls.Add(Me.LBL_PASS_CONFIRM)
        Me.Controls.Add(Me.LBL_PASS1)
        Me.Controls.Add(Me.LBL_EMAIL)
        Me.Controls.Add(Me.LBL_USERID)
        Me.Name = "SignUp"
        Me.Text = "登録"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_USERID As Label
    Friend WithEvents LBL_EMAIL As Label
    Friend WithEvents LBL_PASS1 As Label
    Friend WithEvents LBL_PASS_CONFIRM As Label
    Friend WithEvents TXT_USERID As TextBox
    Friend WithEvents TXT_EMAIL As TextBox
    Friend WithEvents TXT_PASS As TextBox
    Friend WithEvents TXT_PASS_CONFIRM As TextBox
    Friend WithEvents BTN_SIGNUP As Button
    Friend WithEvents Btn_Back As Button
End Class
