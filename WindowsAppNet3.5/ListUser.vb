Imports System.Data
Imports System.Data.Odbc
Imports System.IO
Imports OfficeOpenXml
Public Class ListUser

    Dim pageSize As Integer = 10
    Dim currentPage As Integer = 1
    Dim totalRows As Integer = 0
    Dim fullUserTable As DataTable
    Private Sub ListUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRolesToComboBox()
        LoadUserData()
    End Sub
    Private Sub LoadUserData()
        Txt_UserLoginInfor.Text = $" {CurrentLoginUsername} ({CurrentLoginRoleName})"
        Using conn As New OdbcConnection(connStr)
            Try
                conn.Open()

                Dim dtRole As New DataTable()
                Dim roleAdapter As New OdbcDataAdapter("SELECT roleid, rolename FROM role", conn)
                roleAdapter.Fill(dtRole)

                Dim SqlSearch As String = ""
                Dim parameters As New List(Of OdbcParameter)
                Dim parameterforload As New List(Of OdbcParameter)
                Dim parameterforexport As New List(Of OdbcParameter)
                If TXT_USERID.Text.Trim <> "" Then
                    SqlSearch &= "u.username LIKE ?"
                    parameters.Add(New OdbcParameter("", "%" & TXT_USERID.Text.Trim & "%"))
                    parameterforload.Add(New OdbcParameter("", "%" & TXT_USERID.Text.Trim & "%"))
                    parameterforexport.Add(New OdbcParameter("", "%" & TXT_USERID.Text.Trim & "%"))
                End If
                If TXT_MAIL.Text.Trim <> "" Then
                    If SqlSearch <> "" Then SqlSearch &= " AND "
                    SqlSearch &= "u.email LIKE ?"
                    parameters.Add(New OdbcParameter("", "%" & TXT_MAIL.Text.Trim & "%"))
                    parameterforload.Add(New OdbcParameter("", "%" & TXT_MAIL.Text.Trim & "%"))
                    parameterforexport.Add(New OdbcParameter("", "%" & TXT_MAIL.Text.Trim & "%"))
                End If
                If CB_ROLE.SelectedValue.ToString() <> "" OrElse CB_ROLE.SelectedValue IsNot DBNull.Value Then
                    If SqlSearch <> "" Then SqlSearch &= " AND "
                    SqlSearch &= "u.roleid = ?"
                    parameters.Add(New OdbcParameter("", CB_ROLE.SelectedValue))
                    parameterforload.Add(New OdbcParameter("", CB_ROLE.SelectedValue))
                    parameterforexport.Add(New OdbcParameter("", CB_ROLE.SelectedValue))
                End If
                If SqlSearch <> "" Then
                    SqlSearch = "WHERE " & SqlSearch
                End If
                ' Đếm tổng số dòng
                Dim countCmd As New OdbcCommand($"SELECT COUNT(*) FROM users u {SqlSearch}", conn)
                countCmd.Parameters.AddRange(parameters.ToArray())
                totalRows = Convert.ToInt32(countCmd.ExecuteScalar())

                Dim offset As Integer = (currentPage - 1) * pageSize
                Dim query As String = $"SELECT 
                                            u.id,
                                            u.username,
                                            u.email,
                                            r.rolename
                                        FROM 
                                            users u
                                        INNER JOIN 
                                            role r ON u.roleid = r.roleid
                                        {SqlSearch}
                                        ORDER BY u.id DESC LIMIT {pageSize} OFFSET {offset}
                                        "
                Dim cmd As New OdbcCommand(query, conn)
                cmd.Parameters.AddRange(parameterforload.ToArray())
                Dim adapter As New OdbcDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                Dim queryexport As String = $"SELECT 
                                                u.id,
                                                u.username,
                                                u.email,
                                                r.rolename
                                            FROM 
                                                users u
                                            INNER JOIN 
                                                role r ON u.roleid = r.roleid
                                            {SqlSearch}
                                            ORDER BY u.id DESC
                                            "
                Dim cmdexport As New OdbcCommand(queryexport, conn)
                cmdexport.Parameters.AddRange(parameterforexport.ToArray())
                Dim adapterexport As New OdbcDataAdapter(cmdexport)
                Dim tableexport As New DataTable()
                adapterexport.Fill(tableexport)
                fullUserTable = tableexport

                ' Thêm cột nút nếu chưa có
                If DataGridView1.Columns.Count = 0 Then
                    DataGridView1.Columns.Clear()
                    DataGridView1.DataSource = table

                    ' Nút Edit
                    Dim editBtn As New DataGridViewButtonColumn()
                    editBtn.HeaderText = ""
                    editBtn.DataPropertyName = "btnedit"
                    editBtn.Text = "更新"
                    editBtn.Name = "更新"
                    editBtn.ReadOnly = False
                    editBtn.UseColumnTextForButtonValue = True
                    DataGridView1.Columns.Add(editBtn)
                    ' Nút Delete
                    Dim deleteBtn As New DataGridViewButtonColumn()
                    deleteBtn.HeaderText = ""
                    deleteBtn.DataPropertyName = "btndel"
                    deleteBtn.Text = "削除"
                    deleteBtn.Name = "削除"
                    deleteBtn.ReadOnly = False
                    deleteBtn.UseColumnTextForButtonValue = True
                    DataGridView1.Columns.Add(deleteBtn)
                Else
                    DataGridView1.DataSource = table
                End If
                If CurrentLoginRole <> "5" Then
                    DataGridView1.Columns("削除").Visible = False
                    DataGridView1.Columns("更新").Visible = False
                End If
                DataGridView1.Columns("username").HeaderText = "ユーザーID"
                DataGridView1.Columns("email").HeaderText = "メール"
                DataGridView1.Columns("rolename").HeaderText = "ロール名"
                LBL_CURRENT_PAGE.Text = $"Page {currentPage} / {Math.Ceiling(totalRows / pageSize)}"

                DataGridView1.ReadOnly = True
            Catch ex As Exception
                MessageBox.Show("Lỗi tải dữ liệu: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim userId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("id").Value)

            ' Cột Edit
            If DataGridView1.Columns(e.ColumnIndex).HeaderText = "" AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "更新" Then
                Dim editForm As New EditUser()
                editForm.UserId = userId
                editForm.ShowDialog()
                LoadUserData()
                ' TODO: Mở form sửa thông tin

            ElseIf DataGridView1.Columns(e.ColumnIndex).HeaderText = "" AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "削除" Then
                If MessageBox.Show("削除してよろしいですか？", "確認", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    DeleteUser(userId)
                End If
            End If
        End If
    End Sub
    Private Sub DeleteUser(userId As Integer)
        Using conn As New OdbcConnection(connStr)
            Try
                conn.Open()
                Dim cmd As New OdbcCommand("DELETE FROM users WHERE id = ?", conn)
                cmd.Parameters.AddWithValue("@id", userId)
                cmd.ExecuteNonQuery()
                MessageBox.Show("正常に削除が完了しました。")
                LoadUserData()
            Catch ex As Exception
                MessageBox.Show("Lỗi xoá: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub BTN_NEXT_Click(sender As Object, e As EventArgs) Handles BTN_NEXT.Click
        Dim maxPage As Integer = Math.Ceiling(totalRows / pageSize)
        If currentPage < maxPage AndAlso totalRows > 0 Then
            currentPage += 1
            LoadUserData()
        End If
    End Sub

    Public Sub BTN_PRE_Click(sender As Object, e As EventArgs) Handles BTN_PRE.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadUserData()
        End If
    End Sub

    Private Sub BTN_SEARCH_Click(sender As Object, e As EventArgs) Handles BTN_SEARCH.Click
        currentPage = 1
        LoadUserData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TXT_USERID.Text = ""
        TXT_MAIL.Text = ""
        CB_ROLE.SelectedIndex = 0 ' Chọn dòng trống đầu tiên
        LoadUserData()
    End Sub
    Private Sub LoadRolesToComboBox()
        Using conn As New Odbc.OdbcConnection(connStr)
            Try
                conn.Open()
                Dim roleAdapter As New OdbcDataAdapter("SELECT roleid, rolename FROM role", conn)
                Dim dt As New DataTable()
                roleAdapter.Fill(dt)
                Dim blankRow As DataRow = dt.NewRow() ' Thêm dòng trống để có thể chọn không có vai trò
                blankRow("roleid") = DBNull.Value  ' hoặc 0, tùy hệ thống xử lý
                blankRow("rolename") = ""
                dt.Rows.InsertAt(blankRow, 0)

                CB_ROLE.DataSource = dt
                CB_ROLE.DisplayMember = "rolename"
                CB_ROLE.ValueMember = "roleid"
            Catch ex As Exception
                MessageBox.Show("Lỗi tải dữ liệu: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ExportToExcel(fullUserTable As DataTable, filePath As String)
        Try
            Using package As New ExcelPackage()
                Dim ws = package.Workbook.Worksheets.Add("Users")

                ' Header
                For i = 0 To fullUserTable.Columns.Count - 1
                    ws.Cells(1, i + 1).Value = fullUserTable.Columns(i).ColumnName
                Next

                ' Dữ liệu
                For r = 0 To fullUserTable.Rows.Count - 1
                    For c = 0 To fullUserTable.Columns.Count - 1
                        ws.Cells(r + 2, c + 1).Value = fullUserTable.Rows(r)(c)
                    Next
                Next

                ' Lưu
                Dim fi As New FileInfo(filePath)
                package.SaveAs(fi)

                MessageBox.Show("正常に出力が完了しました。", "")
            End Using
        Catch ex As Exception
            MessageBox.Show("エラー: " & ex.Message)
        End Try
    End Sub

    Private Function GetExportFileName(userLogin As String, ext As String) As String
        Dim now As DateTime = DateTime.Now
        Dim fileName As String = $"ListUser_{now:yyyy-MM-dd_HH-mm}_{userLogin}.{ext}"
        Return fileName
    End Function
    Private Sub BTN_EXCEL_Click(sender As Object, e As EventArgs) Handles BTN_EXCEL.Click
        Dim username As String = CurrentLoginUsername
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel files (*.xlsx)|*.xlsx"
        sfd.FileName = GetExportFileName(username, "xlsx")

        If sfd.ShowDialog() = DialogResult.OK Then
            ExportToExcel(fullUserTable, sfd.FileName)
        End If
    End Sub

    Private Sub Btn_SignOut_Click(sender As Object, e As EventArgs) Handles Btn_SignOut.Click
        Dim result = MessageBox.Show("サインアウトしてよろしいですか？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Exit Sub

        ' Xóa thông tin người dùng hiện tại (nếu cần)
        CurrentLoginUsername = ""
        CurrentLoginRole = ""

        ' Mở lại FormLogin
        Dim frmLogin As New Login()
        frmLogin.Show()

        ' Đóng form hiện tại
        Me.Close()
    End Sub
End Class