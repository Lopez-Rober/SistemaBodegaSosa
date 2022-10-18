Imports System.Data.SqlClient
Imports System.Configuration
Public Class ClsReportes

    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnTiendaSosa").ConnectionString)

    Public Function listarReportes() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Reportes", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function

End Class
