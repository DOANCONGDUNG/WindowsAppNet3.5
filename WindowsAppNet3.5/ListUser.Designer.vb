<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TXT_USERID = New System.Windows.Forms.TextBox()
        Me.TXT_MAIL = New System.Windows.Forms.TextBox()
        Me.LBL_USERID = New System.Windows.Forms.Label()
        Me.LBL_MAIL = New System.Windows.Forms.Label()
        Me.CB_ROLE = New System.Windows.Forms.ComboBox()
        Me.LBL_ROLE = New System.Windows.Forms.Label()
        Me.BTN_SEARCH = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_PRE = New System.Windows.Forms.Button()
        Me.BTN_NEXT = New System.Windows.Forms.Button()
        Me.LBL_CURRENT_PAGE = New System.Windows.Forms.Label()
        Me.BTN_EXCEL = New System.Windows.Forms.Button()
        Me.Txt_UserLoginInfor = New System.Windows.Forms.Label()
        Me.Btn_SignOut = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 279)
        Me.DataGridView1.TabIndex = 0
        '
        'TXT_USERID
        '
        Me.TXT_USERID.Location = New System.Drawing.Point(105, 21)
        Me.TXT_USERID.Name = "TXT_USERID"
        Me.TXT_USERID.Size = New System.Drawing.Size(96, 20)
        Me.TXT_USERID.TabIndex = 1
        '
        'TXT_MAIL
        '
        Me.TXT_MAIL.Location = New System.Drawing.Point(292, 21)
        Me.TXT_MAIL.Name = "TXT_MAIL"
        Me.TXT_MAIL.Size = New System.Drawing.Size(100, 20)
        Me.TXT_MAIL.TabIndex = 2
        '
        'LBL_USERID
        '
        Me.LBL_USERID.AutoSize = True
        Me.LBL_USERID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_USERID.Location = New System.Drawing.Point(47, 27)
        Me.LBL_USERID.Name = "LBL_USERID"
        Me.LBL_USERID.Size = New System.Drawing.Size(51, 13)
        Me.LBL_USERID.TabIndex = 3
        Me.LBL_USERID.Text = "ユーザー"
        '
        'LBL_MAIL
        '
        Me.LBL_MAIL.AutoSize = True
        Me.LBL_MAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_MAIL.Location = New System.Drawing.Point(251, 27)
        Me.LBL_MAIL.Name = "LBL_MAIL"
        Me.LBL_MAIL.Size = New System.Drawing.Size(38, 13)
        Me.LBL_MAIL.TabIndex = 4
        Me.LBL_MAIL.Text = "メール"
        '
        'CB_ROLE
        '
        Me.CB_ROLE.FormattingEnabled = True
        Me.CB_ROLE.Location = New System.Drawing.Point(105, 48)
        Me.CB_ROLE.Name = "CB_ROLE"
        Me.CB_ROLE.Size = New System.Drawing.Size(121, 21)
        Me.CB_ROLE.TabIndex = 5
        '
        'LBL_ROLE
        '
        Me.LBL_ROLE.AutoSize = True
        Me.LBL_ROLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_ROLE.Location = New System.Drawing.Point(50, 55)
        Me.LBL_ROLE.Name = "LBL_ROLE"
        Me.LBL_ROLE.Size = New System.Drawing.Size(39, 13)
        Me.LBL_ROLE.TabIndex = 6
        Me.LBL_ROLE.Text = "ロール"
        '
        'BTN_SEARCH
        '
        Me.BTN_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_SEARCH.Location = New System.Drawing.Point(151, 75)
        Me.BTN_SEARCH.Name = "BTN_SEARCH"
        Me.BTN_SEARCH.Size = New System.Drawing.Size(75, 23)
        Me.BTN_SEARCH.TabIndex = 7
        Me.BTN_SEARCH.Text = "検索"
        Me.BTN_SEARCH.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(244, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "クリア"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_PRE
        '
        Me.BTN_PRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_PRE.Location = New System.Drawing.Point(12, 399)
        Me.BTN_PRE.Name = "BTN_PRE"
        Me.BTN_PRE.Size = New System.Drawing.Size(75, 23)
        Me.BTN_PRE.TabIndex = 9
        Me.BTN_PRE.Text = "前へ"
        Me.BTN_PRE.UseVisualStyleBackColor = True
        '
        'BTN_NEXT
        '
        Me.BTN_NEXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NEXT.Location = New System.Drawing.Point(162, 399)
        Me.BTN_NEXT.Name = "BTN_NEXT"
        Me.BTN_NEXT.Size = New System.Drawing.Size(75, 23)
        Me.BTN_NEXT.TabIndex = 10
        Me.BTN_NEXT.Text = "次へ"
        Me.BTN_NEXT.UseVisualStyleBackColor = True
        '
        'LBL_CURRENT_PAGE
        '
        Me.LBL_CURRENT_PAGE.AutoSize = True
        Me.LBL_CURRENT_PAGE.Location = New System.Drawing.Point(102, 404)
        Me.LBL_CURRENT_PAGE.Name = "LBL_CURRENT_PAGE"
        Me.LBL_CURRENT_PAGE.Size = New System.Drawing.Size(39, 13)
        Me.LBL_CURRENT_PAGE.TabIndex = 11
        Me.LBL_CURRENT_PAGE.Text = "Label1"
        '
        'BTN_EXCEL
        '
        Me.BTN_EXCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_EXCEL.Location = New System.Drawing.Point(338, 74)
        Me.BTN_EXCEL.Name = "BTN_EXCEL"
        Me.BTN_EXCEL.Size = New System.Drawing.Size(90, 23)
        Me.BTN_EXCEL.TabIndex = 12
        Me.BTN_EXCEL.Text = "エクセル出力"
        Me.BTN_EXCEL.UseVisualStyleBackColor = True
        '
        'Txt_UserLoginInfor
        '
        Me.Txt_UserLoginInfor.AutoSize = True
        Me.Txt_UserLoginInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Txt_UserLoginInfor.Location = New System.Drawing.Point(603, 9)
        Me.Txt_UserLoginInfor.Name = "Txt_UserLoginInfor"
        Me.Txt_UserLoginInfor.Size = New System.Drawing.Size(45, 13)
        Me.Txt_UserLoginInfor.TabIndex = 13
        Me.Txt_UserLoginInfor.Text = "Label1"
        '
        'Btn_SignOut
        '
        Me.Btn_SignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_SignOut.Location = New System.Drawing.Point(713, 4)
        Me.Btn_SignOut.Name = "Btn_SignOut"
        Me.Btn_SignOut.Size = New System.Drawing.Size(75, 23)
        Me.Btn_SignOut.TabIndex = 14
        Me.Btn_SignOut.Text = "サインアウト"
        Me.Btn_SignOut.UseVisualStyleBackColor = True
        '
        'ListUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_SignOut)
        Me.Controls.Add(Me.Txt_UserLoginInfor)
        Me.Controls.Add(Me.BTN_EXCEL)
        Me.Controls.Add(Me.LBL_CURRENT_PAGE)
        Me.Controls.Add(Me.BTN_NEXT)
        Me.Controls.Add(Me.BTN_PRE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_SEARCH)
        Me.Controls.Add(Me.LBL_ROLE)
        Me.Controls.Add(Me.CB_ROLE)
        Me.Controls.Add(Me.LBL_MAIL)
        Me.Controls.Add(Me.LBL_USERID)
        Me.Controls.Add(Me.TXT_MAIL)
        Me.Controls.Add(Me.TXT_USERID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ListUser"
        Me.Text = "ユーザーの一覧"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXT_USERID As TextBox
    Friend WithEvents TXT_MAIL As TextBox
    Friend WithEvents LBL_USERID As Label
    Friend WithEvents LBL_MAIL As Label
    Friend WithEvents CB_ROLE As ComboBox
    Friend WithEvents LBL_ROLE As Label
    Friend WithEvents BTN_SEARCH As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_PRE As Button
    Friend WithEvents BTN_NEXT As Button
    Friend WithEvents LBL_CURRENT_PAGE As Label
    Friend WithEvents BTN_EXCEL As Button
    Friend WithEvents Txt_UserLoginInfor As Label
    Friend WithEvents Btn_SignOut As Button
End Class
