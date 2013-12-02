Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Imports System.Management
Module modRegistry

#Region "Declares"
    Dim RegistryObject As RegistryKey
#End Region

    Private Sub Hive(ByVal Address As String)
        Select Case Address
            Case "ClassesRoot"
                RegistryObject = Microsoft.Win32.Registry.ClassesRoot
            Case "CurrentConfig"
                RegistryObject = Microsoft.Win32.Registry.CurrentConfig
            Case "CurrentUser"
                RegistryObject = Microsoft.Win32.Registry.CurrentUser
            Case "DynData"
                RegistryObject = Microsoft.Win32.Registry.DynData
            Case "LocalMachine"
                RegistryObject = Microsoft.Win32.Registry.LocalMachine
            Case "PerformanceData"
                RegistryObject = Microsoft.Win32.Registry.PerformanceData
            Case "Users"
                RegistryObject = Microsoft.Win32.Registry.Users
        End Select
    End Sub

    Public Function ReadString(ByVal hiva As String, ByVal Address As String, ByVal value As String) As String
        'to read string value
        Call Hive(hiva)
        Dim baca As RegistryKey = RegistryObject
        Try
            baca = baca.OpenSubKey(Address)
            Dim data As Object = baca.GetValue(value)
            baca.Close()
            ReadString = data
        Catch ex As Exception       'if error then

        End Try
        Return True
    End Function

    Public Function WriteString(ByVal hiva As String, ByVal Address As String, ByVal value As String, ByVal data As String) As Boolean
        'to write string value in registry

        Call Hive(hiva)
        Try
            Dim tulis As RegistryKey = RegistryObject.OpenSubKey(Address, True)
            tulis.SetValue(value, data)
            tulis.Close()
            WriteString = True
        Catch ex As Exception   'if error then

            WriteString = False
        End Try
    End Function

    Public Function DelString(ByVal hiva As String, ByVal Address As String, ByVal value As String) As Boolean
        'to delete string value

        Call Hive(hiva)
        Try
            Dim hapus As RegistryKey = RegistryObject.OpenSubKey(Address, True)
            hapus.DeleteValue(value)
            hapus.Close()
            DelString = True
        Catch ex As Exception

            DelString = False
        End Try
    End Function

    Public Function ReadDword(ByVal hiva As String, ByVal Address As String, ByVal value As String) As String
        'to read dword value

        Call Hive(hiva)
        Dim baca As RegistryKey = RegistryObject
        Try
            baca = baca.OpenSubKey(Address)
            Dim data As Object = baca.GetValue(value)
            baca.Close()
            ReadDword = data
        Catch ex As Exception

        End Try
        Return True
    End Function

    Public Function WriteDword(ByVal hiva As String, ByVal Address As String, ByVal value As String, ByVal data As Integer) As Boolean
        'to write dword value

        Call Hive(hiva)
        Try
            Dim tulis As RegistryKey = RegistryObject.OpenSubKey(Address, True)
            tulis.SetValue(value, data)
            tulis.Close()
            WriteDword = True
        Catch ex As Exception

            WriteDword = False
        End Try
    End Function

    Public Function DelDword(ByVal hiva As String, ByVal Address As String, ByVal value As String) As Boolean
        'to delete dword value

        Call Hive(hiva)
        Try
            Dim hapus As RegistryKey = RegistryObject.OpenSubKey(Address, True)
            hapus.DeleteValue(value)
            hapus.Close()
            DelDword = True
        Catch ex As Exception

            DelDword = False
        End Try
    End Function

    Public Sub RemoteRegistry(ByVal machineName As String, ByVal hiva As String, ByVal Address As String, ByVal value As String, ByVal data As String)
        Dim options As New ConnectionOptions
        options.Impersonation = ImpersonationLevel.Impersonate
        options.EnablePrivileges = True
        options.Username = "admin"
        options.Password = "rsdk2011"

        Dim myScope As New ManagementScope("\\" & machineName & "\root\default", options)
        Dim mypath As New ManagementPath("StdRegProv")
        Dim mc As New ManagementClass(myScope, mypath, Nothing)
        Hive(hiva)
        Dim inParams As ManagementBaseObject = mc.GetMethodParameters("GetStringValue")
        inParams("hDefKey") = RegistryObject
        inParams("sSubKeyName") = Address
        inParams("sValueName") = value

        Dim outParams As ManagementBaseObject = mc.InvokeMethod("GetStringValue", inParams, Nothing)

        If (outParams("ReturnValue").ToString() = "0") Then
            MessageBox.Show(outParams("sValue").ToString())
        Else
            MessageBox.Show("Error retrieving value : " + outParams("ReturnValue").ToString())
        End If
    End Sub
End Module
