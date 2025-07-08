<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResetPassword
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LBL_USER = New System.Windows.Forms.Label()
        Me.TXT_USER = New System.Windows.Forms.TextBox()
        Me.LBL_NEW_PASS = New System.Windows.Forms.Label()
        Me.TXT_NEW_PASS = New System.Windows.Forms.TextBox()
        Me.LBL_CONFIRM_PASS = New System.Windows.Forms.Label()
        Me.TXT_CONFIRM_PASS = New System.Windows.Forms.TextBox()
        Me.BTN_RESET = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_USER
        '
        Me.LBL_USER.AutoSize = True
        Me.LBL_USER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_USER.Location = New System.Drawing.Point(30, 30)
        Me.LBL_USER.Name = "LBL_USER"
        Me.LBL_USER.Size = New System.Drawing.Size(68, 13)
        Me.LBL_USER.TabIndex = 0
        Me.LBL_USER.Text = "ユーザーID:"
        '
        'TXT_USER
        '
        Me.TXT_USER.Location = New System.Drawing.Point(130, 27)
        Me.TXT_USER.Name = "TXT_USER"
        Me.TXT_USER.Size = New System.Drawing.Size(150, 20)
        Me.TXT_USER.TabIndex = 1
        '
        'LBL_NEW_PASS
        '
        Me.LBL_NEW_PASS.AutoSize = True
        Me.LBL_NEW_PASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_NEW_PASS.Location = New System.Drawing.Point(30, 65)
        Me.LBL_NEW_PASS.Name = "LBL_NEW_PASS"
        Me.LBL_NEW_PASS.Size = New System.Drawing.Size(97, 13)
        Me.LBL_NEW_PASS.TabIndex = 2
        Me.LBL_NEW_PASS.Text = "新しいパスワード:"
        '
        'TXT_NEW_PASS
        '
        Me.TXT_NEW_PASS.Location = New System.Drawing.Point(130, 62)
        Me.TXT_NEW_PASS.Name = "TXT_NEW_PASS"
        Me.TXT_NEW_PASS.Size = New System.Drawing.Size(150, 20)
        Me.TXT_NEW_PASS.TabIndex = 3
        Me.TXT_NEW_PASS.UseSystemPasswordChar = True
        '
        'LBL_CONFIRM_PASS
        '
        Me.LBL_CONFIRM_PASS.AutoSize = True
        Me.LBL_CONFIRM_PASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_CONFIRM_PASS.Location = New System.Drawing.Point(30, 100)
        Me.LBL_CONFIRM_PASS.Name = "LBL_CONFIRM_PASS"
        Me.LBL_CONFIRM_PASS.Size = New System.Drawing.Size(89, 13)
        Me.LBL_CONFIRM_PASS.TabIndex = 4
        Me.LBL_CONFIRM_PASS.Text = "パスワード確認:"
        '
        'TXT_CONFIRM_PASS
        '
        Me.TXT_CONFIRM_PASS.Location = New System.Drawing.Point(130, 97)
        Me.TXT_CONFIRM_PASS.Name = "TXT_CONFIRM_PASS"
        Me.TXT_CONFIRM_PASS.Size = New System.Drawing.Size(150, 20)
        Me.TXT_CONFIRM_PASS.TabIndex = 5
        Me.TXT_CONFIRM_PASS.UseSystemPasswordChar = True
        '
        'BTN_RESET
        '
        Me.BTN_RESET.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RESET.Location = New System.Drawing.Point(130, 135)
        Me.BTN_RESET.Name = "BTN_RESET"
        Me.BTN_RESET.Size = New System.Drawing.Size(150, 23)
        Me.BTN_RESET.TabIndex = 6
        Me.BTN_RESET.Text = "パスワードをリセット"
        Me.BTN_RESET.UseVisualStyleBackColor = True
        '
        'ResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 180)
        Me.Controls.Add(Me.BTN_RESET)
        Me.Controls.Add(Me.TXT_CONFIRM_PASS)
        Me.Controls.Add(Me.LBL_CONFIRM_PASS)
        Me.Controls.Add(Me.TXT_NEW_PASS)
        Me.Controls.Add(Me.LBL_NEW_PASS)
        Me.Controls.Add(Me.TXT_USER)
        Me.Controls.Add(Me.LBL_USER)
        Me.Name = "ResetPassword"
        Me.Text = "パスワードを忘れた場合"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_USER As Label
    Friend WithEvents TXT_USER As TextBox
    Friend WithEvents LBL_NEW_PASS As Label
    Friend WithEvents TXT_NEW_PASS As TextBox
    Friend WithEvents LBL_CONFIRM_PASS As Label
    Friend WithEvents TXT_CONFIRM_PASS As TextBox
    Friend WithEvents BTN_RESET As Button
End Class
