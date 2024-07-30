Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module ModuleVT

    Public Function SqlBaglantiCumlesi() As String
        Dim SqlBaglantiCumlesiOlusturucu As New SqlConnectionStringBuilder
        SqlBaglantiCumlesiOlusturucu.DataSource = "DESKTOP-TTT8CS4\SQLEXPRESS"
        SqlBaglantiCumlesiOlusturucu.InitialCatalog = "RetroStore"
        SqlBaglantiCumlesiOlusturucu.IntegratedSecurity = False
        SqlBaglantiCumlesiOlusturucu.PersistSecurityInfo = False
        SqlBaglantiCumlesiOlusturucu.UserID = "sa"
        SqlBaglantiCumlesiOlusturucu.Password = "1234"
        Return SqlBaglantiCumlesiOlusturucu.ConnectionString
    End Function


End Module
