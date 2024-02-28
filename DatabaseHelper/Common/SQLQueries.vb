Public Module SQLQueries

    Public Const FetchDbNames As String = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"

    Public Const CountDb As String = "SELECT COUNT(name) FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"

    Public Const CountTables As String = "SELECT COUNT(*) AS TableCount FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"

    Public Const CountStoredProcedures As String = "SELECT COUNT(*) AS StoredProcedureCount FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'"

    Public Const CountViews As String = "SELECT COUNT(*) AS ViewCount FROM INFORMATION_SCHEMA.VIEWS"

End Module

