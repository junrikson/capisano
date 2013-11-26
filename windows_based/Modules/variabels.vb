Public Class variabels
    'Operator aktif
    Public Shared oper As String = "blank"

    'Periode Aktif
    Public Shared periode As Date

    'Periode
    Public Shared periodeAktif As Date

    'Business Code Name
    Public Shared codename As String

    'Config Server Lokal
    Public Shared localCfg As String = My.Computer.FileSystem.ReadAllText("config.cfg")
    Public Shared localConfig As String() = localCfg.Split(New Char() {vbCrLf})
    Public Shared localServerAdress As String = localConfig(1).Substring(1, localConfig(1).Length - 1)
    Public Shared localServerUsername As String = localConfig(2).Substring(1, localConfig(2).Length - 1)
    Public Shared localServerPassword As String = localConfig(3).Substring(1, localConfig(3).Length - 1)
    Public Shared localDatabaseName As String = localConfig(4).Substring(1, localConfig(4).Length - 1)

    'Config Server Web
    Public Shared webCfg As String = My.Computer.FileSystem.ReadAllText("config\webserver.cfg")
    Public Shared webConfig As String() = webCfg.Split(New Char() {vbCrLf})
    Public Shared webServerAdress As String = webConfig(1).Substring(1, webConfig(1).Length - 1)
    Public Shared webServerUsername As String = webConfig(2).Substring(1, webConfig(2).Length - 1)
    Public Shared webServerPassword As String = webConfig(3).Substring(1, webConfig(3).Length - 1)
    Public Shared webDatabaseName As String = webConfig(4).Substring(1, webConfig(4).Length - 1)
End Class
