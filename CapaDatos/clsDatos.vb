Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad

Public Class clsDatos

    Private conn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnTiendaSosa").ConnectionString)
    'Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("miConexion").ConnectionStatement)

    'Public Function CD_ListarCategoria() As DataTable
    'Listado con consulta sql
    'Dim cmd As New SqlCommand("SELECT    nombres, apellidos,dni FROM    [dbo].[Cliente] WHERE    ruc <> ''", conn)
    'conn.Open()
    'cmd.CommandType = CommandType.Text
    'Dim da As New SqlDataAdapter(cmd)
    'Dim dt As New DataTable
    'da.Fill(dt)
    'conn.Close()
    'Return dt

    'Listado con StoreProcedure
    'Dim dt As New DataTable
    'Dim da As New SqlDataAdapter("[dbo].[SP_Get_Listar_Categoria]", conn)
    'da.SelectCommand.CommandType = CommandType.StoredProcedure
    'da.Fill(dt)
    'Return dt

    'End Function

    'Public Sub CD_InsertarCategoria(CEDatos As clsEntidad)
    'Dim cmd As New SqlCommand("Insert into categoria Values (@nombre,@descripcion,@estado)", conn)
    '   conn.Open()
    '    cmd.CommandType = CommandType.Text
    'With cmd.Parameters
    'End With
    '   cmd.ExecuteNonQuery()
    '   conn.Close()
    '   cmd.Parameters.Clear()

    '  End Sub

End Class
