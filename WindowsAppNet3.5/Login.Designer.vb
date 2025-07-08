<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TXT_USER = New System.Windows.Forms.TextBox()
        Me.LBL_PASS = New System.Windows.Forms.Label()
        Me.TXT_PASS = New System.Windows.Forms.TextBox()
        Me.BTN_LOGIN = New System.Windows.Forms.Button()
        Me.BTN_TOROKU = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_FORGOT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_USERID
        '
        Me.LBL_USERID.AutoSize = True
        Me.LBL_USERID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_USERID.Location = New System.Drawing.Point(57, 84)
        Me.LBL_USERID.Name = "LBL_USERID"
        Me.LBL_USERID.Size = New System.Drawing.Size(64, 13)
        Me.LBL_USERID.TabIndex = 0
        Me.LBL_USERID.Text = "ユーザーID"
        '
        'TXT_USER
        '
        Me.TXT_USER.Location = New System.Drawing.Point(127, 81)
        Me.TXT_USER.Name = "TXT_USER"
        Me.TXT_USER.Size = New System.Drawing.Size(100, 20)
        Me.TXT_USER.TabIndex = 1
        '
        'LBL_PASS
        '
        Me.LBL_PASS.AutoSize = True
        Me.LBL_PASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PASS.Location = New System.Drawing.Point(62, 111)
        Me.LBL_PASS.Name = "LBL_PASS"
        Me.LBL_PASS.Size = New System.Drawing.Size(59, 13)
        Me.LBL_PASS.TabIndex = 2
        Me.LBL_PASS.Text = "パスワード"
        '
        'TXT_PASS
        '
        Me.TXT_PASS.Location = New System.Drawing.Point(127, 108)
        Me.TXT_PASS.Name = "TXT_PASS"
        Me.TXT_PASS.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PASS.TabIndex = 3
        Me.TXT_PASS.UseSystemPasswordChar = True
        '
        'BTN_LOGIN
        '
        Me.BTN_LOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LOGIN.Location = New System.Drawing.Point(92, 157)
        Me.BTN_LOGIN.Name = "BTN_LOGIN"
        Me.BTN_LOGIN.Size = New System.Drawing.Size(75, 23)
        Me.BTN_LOGIN.TabIndex = 4
        Me.BTN_LOGIN.Text = "ログイン"
        Me.BTN_LOGIN.UseVisualStyleBackColor = True
        '
        'BTN_TOROKU
        '
        Me.BTN_TOROKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_TOROKU.Location = New System.Drawing.Point(173, 157)
        Me.BTN_TOROKU.Name = "BTN_TOROKU"
        Me.BTN_TOROKU.Size = New System.Drawing.Size(123, 23)
        Me.BTN_TOROKU.TabIndex = 5
        Me.BTN_TOROKU.Text = "新規社員登録"
        Me.BTN_TOROKU.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ログイン"
        '
        'BTN_FORGOT
        '
        Me.BTN_FORGOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FORGOT.Location = New System.Drawing.Point(92, 186)
        Me.BTN_FORGOT.Name = "BTN_FORGOT"
        Me.BTN_FORGOT.Size = New System.Drawing.Size(204, 23)
        Me.BTN_FORGOT.TabIndex = 7
        Me.BTN_FORGOT.Text = "パスワードを忘れた場合"
        Me.BTN_FORGOT.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 248)
        Me.Controls.Add(Me.BTN_FORGOT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_TOROKU)
        Me.Controls.Add(Me.BTN_LOGIN)
        Me.Controls.Add(Me.TXT_PASS)
        Me.Controls.Add(Me.LBL_PASS)
        Me.Controls.Add(Me.TXT_USER)
        Me.Controls.Add(Me.LBL_USERID)
        Me.Name = "Login"
        Me.Text = "ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_USERID As Label
    Friend WithEvents TXT_USER As TextBox
    Friend WithEvents LBL_PASS As Label
    Friend WithEvents TXT_PASS As TextBox
    Friend WithEvents BTN_LOGIN As Button
    Friend WithEvents BTN_TOROKU As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_FORGOT As Button
End Class
