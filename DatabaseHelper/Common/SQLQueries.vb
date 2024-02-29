Public Module SQLQueries

    Public Const DBNamesQuery As String = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"

    Public Const DbCountQuery As String = "SELECT COUNT(name) FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"

    Public Const TablesCountQuery As String = "USE [{0}]; SELECT COUNT(*) AS TableCount FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"

    Public Const StoredProceduresCountQuery As String = "USE [{0}];SELECT COUNT(*) AS StoredProcedureCount FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'"

    Public Const ViewsCountQuery As String = "USE [{0}]; SELECT COUNT(*) AS ViewCount FROM INFORMATION_SCHEMA.VIEWS"

    Public Const TablesNamesQuery As String = "USE [{0}]; SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"

    Public Const StoredProceduresNamesQuery As String = "USE [{0}]; SELECT ROUTINE_NAME AS StoredProcedureName FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'"

    Public Const ViewsNamesQuery As String = "USE [{0}]; SELECT TABLE_NAME AS ViewName FROM INFORMATION_SCHEMA.VIEWS;"

    Public Const ViewDetailQuery As String = "SELECT OBJECT_DEFINITION(OBJECT_ID('{0}')) AS ViewDefinition;"

    Public Const ProcedureDetailQuery As String = "SELECT OBJECT_DEFINITION(OBJECT_ID('{0}')) AS ProcedureDefinition;"

End Module

