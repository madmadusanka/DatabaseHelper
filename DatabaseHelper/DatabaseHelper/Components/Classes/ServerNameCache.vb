Imports System.IO

'Class for caching server name
Public Class ServerNameCache
    Private Const CacheFileName As String = "ServerNameCache.txt"

    Public Shared Function GetCachedServerName() As String
        Dim cachedData As String = ReadCacheFromFile()
        Return cachedData
    End Function

    Public Shared Sub CacheServerName(serverName As String)
        WriteCacheToFile(serverName)
    End Sub

    Private Shared Function ReadCacheFromFile() As String
        Dim cachedData As String = ""
        If File.Exists(CacheFileName) Then
            cachedData = File.ReadAllText(CacheFileName)
        End If
        Return cachedData
    End Function

    Private Shared Sub WriteCacheToFile(serverName As String)
        File.WriteAllText(CacheFileName, serverName)
    End Sub
End Class
