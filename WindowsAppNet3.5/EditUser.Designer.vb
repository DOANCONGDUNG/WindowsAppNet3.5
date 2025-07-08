<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
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
        Me.Lbl_UserNM = New System.Windows.Forms.Label()
        Me.Lbl_Email = New System.Windows.Forms.Label()
        Me.Lbl_Role = New System.Windows.Forms.Label()
        Me.Cb_Role = New System.Windows.Forms.ComboBox()
        Me.Tb_Email = New System.Windows.Forms.TextBox()
        Me.Lbl_UserNM_Value = New System.Windows.Forms.Label()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.Lbl_Id_Value = New System.Windows.Forms.Label()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_UserNM
        '
        Me.Lbl_UserNM.AutoSize = True
        Me.Lbl_UserNM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_UserNM.Location = New System.Drawing.Point(107, 71)
        Me.Lbl_UserNM.Name = "Lbl_UserNM"
        Me.Lbl_UserNM.Size = New System.Drawing.Size(64, 13)
        Me.Lbl_UserNM.TabIndex = 0
        Me.Lbl_UserNM.Text = "ユーザー名"
        '
        'Lbl_Email
        '
        Me.Lbl_Email.AutoSize = True
        Me.Lbl_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Email.Location = New System.Drawing.Point(108, 107)
        Me.Lbl_Email.Name = "Lbl_Email"
        Me.Lbl_Email.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Email.TabIndex = 1
        Me.Lbl_Email.Text = "メール"
        '
        'Lbl_Role
        '
        Me.Lbl_Role.AutoSize = True
        Me.Lbl_Role.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Role.Location = New System.Drawing.Point(107, 146)
        Me.Lbl_Role.Name = "Lbl_Role"
        Me.Lbl_Role.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Role.TabIndex = 2
        Me.Lbl_Role.Text = "ロール"
        '
        'Cb_Role
        '
        Me.Cb_Role.FormattingEnabled = True
        Me.Cb_Role.Location = New System.Drawing.Point(181, 138)
        Me.Cb_Role.Name = "Cb_Role"
        Me.Cb_Role.Size = New System.Drawing.Size(121, 21)
        Me.Cb_Role.TabIndex = 3
        '
        'Tb_Email
        '
        Me.Tb_Email.Location = New System.Drawing.Point(181, 100)
        Me.Tb_Email.Name = "Tb_Email"
        Me.Tb_Email.Size = New System.Drawing.Size(100, 20)
        Me.Tb_Email.TabIndex = 4
        '
        'Lbl_UserNM_Value
        '
        Me.Lbl_UserNM_Value.AutoSize = True
        Me.Lbl_UserNM_Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_UserNM_Value.Location = New System.Drawing.Point(178, 71)
        Me.Lbl_UserNM_Value.Name = "Lbl_UserNM_Value"
        Me.Lbl_UserNM_Value.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_UserNM_Value.TabIndex = 5
        Me.Lbl_UserNM_Value.Text = "Label1"
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBL_ID.Location = New System.Drawing.Point(110, 40)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(20, 13)
        Me.LBL_ID.TabIndex = 6
        Me.LBL_ID.Text = "ID"
        '
        'Lbl_Id_Value
        '
        Me.Lbl_Id_Value.AutoSize = True
        Me.Lbl_Id_Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Id_Value.Location = New System.Drawing.Point(178, 40)
        Me.Lbl_Id_Value.Name = "Lbl_Id_Value"
        Me.Lbl_Id_Value.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_Id_Value.TabIndex = 7
        Me.Lbl_Id_Value.Text = "Label1"
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.Location = New System.Drawing.Point(135, 193)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Edit.TabIndex = 8
        Me.Btn_Edit.Text = "更新"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Back
        '
        Me.Btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Back.Location = New System.Drawing.Point(234, 193)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Back.TabIndex = 9
        Me.Btn_Back.Text = "戻る"
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Lbl_Id_Value)
        Me.Controls.Add(Me.LBL_ID)
        Me.Controls.Add(Me.Lbl_UserNM_Value)
        Me.Controls.Add(Me.Tb_Email)
        Me.Controls.Add(Me.Cb_Role)
        Me.Controls.Add(Me.Lbl_Role)
        Me.Controls.Add(Me.Lbl_Email)
        Me.Controls.Add(Me.Lbl_UserNM)
        Me.Name = "EditUser"
        Me.Text = "ユーザー変更"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_UserNM As Label
    Friend WithEvents Lbl_Email As Label
    Friend WithEvents Lbl_Role As Label
    Friend WithEvents Cb_Role As ComboBox
    Friend WithEvents Tb_Email As TextBox
    Friend WithEvents Lbl_UserNM_Value As Label
    Friend WithEvents LBL_ID As Label
    Friend WithEvents Lbl_Id_Value As Label
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Back As Button
End Class
