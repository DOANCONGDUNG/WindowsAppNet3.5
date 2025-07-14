Imports System.Text.RegularExpressions

Module Globals
    Public CurrentLoginUsername As String
    Public CurrentLoginRole As String
    Public CurrentLoginRoleName As String
    Public connStr As String = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=db_test;User=root;Password=1234;"
    Public Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(email, pattern)
    End Function
End Module
