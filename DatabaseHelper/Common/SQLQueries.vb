Public Module SQLQueries

    Public Const DBNamesQuery As String = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"

    Public Const DbCountQuery As String = "SELECT COUNT(name) FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"

    Public Const TablesCountQuery As String = "SELECT COUNT(*) AS TableCount FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"

    Public Const StoredProceduresCountQuery As String = "SELECT COUNT(*) AS StoredProcedureCount FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'"

    Public Const ViewsCountQuery As String = "SELECT COUNT(*) AS ViewCount FROM INFORMATION_SCHEMA.VIEWS"

End Module

