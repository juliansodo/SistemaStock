Imports System.Xml
Imports System.Data.SqlClient
Module cnBD
    Public Function cnDB(ByVal sRutaEjecucion As String) As String
        Dim xcnBolsa As New Xml.XmlDocument
        Dim xConnectionString As XmlElement

        cnDB = ""
        xcnBolsa.Load(sRutaEjecucion + "/cnDB.config")
        xConnectionString = xcnBolsa.SelectSingleNode("connectionStrings/add[@name='cnSistema']")
        If Not (xConnectionString Is Nothing) Then
            cnDB = xConnectionString.Attributes("connectionString").Value
        End If

    End Function


    Public Function ConsultaDB(ByVal Consulta As String) As DataTable
        Using cnSistema As New SqlClient.SqlConnection(cnDB(My.Application.Info.DirectoryPath))
            cnSistema.Open()
            Using cmdConsulta As New SqlClient.SqlCommand(Consulta, cnSistema)
                Dim dtConsulta As New DataTable
                Dim drConsulta As SqlClient.SqlDataReader
                drConsulta = cmdConsulta.ExecuteReader
                dtConsulta.Load(drConsulta)
                ConsultaDB = dtConsulta
            End Using
        End Using
    End Function
End Module
