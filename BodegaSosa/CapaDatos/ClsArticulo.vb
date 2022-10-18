Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Imports System.Security.Policy
Public Class ClsArticulo

    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnTiendaSosa").ConnectionString)
    Public Function CD_BuscarArticulo(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarArticulo", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_listarArticulo() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Articulo", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_InsertarArticulo(idcat As Integer, cod As Integer, nom As String, pre_ven As String, stock As Integer, desc As String, est As String)

        Dim da As New SqlCommand("SP_Set_AgregarArticulo", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@idcategoria", idcat)
        da.Parameters.AddWithValue("@codigo", cod)
        da.Parameters.AddWithValue("@artnombre", nom)
        da.Parameters.AddWithValue("@precio_venta", pre_ven)
        da.Parameters.AddWithValue("@stock", stock)
        da.Parameters.AddWithValue("@descripcion", desc)
        da.Parameters.AddWithValue("@estado", est)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado Articulo correctamente")
        Catch ex As Exception
            MsgBox("Error al registrar el Articulo")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarArticulo(idart As Integer)
        Dim dart As New SqlCommand("SP_Set_EliminarArticulo", cn)
        dart.CommandType = CommandType.StoredProcedure
        dart.Parameters.AddWithValue("@idarticulo", idart)
        cn.Open()
        Dim dcate As Integer = dart.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado el articulo")
        Catch ex As Exception
            MsgBox("Error al eliminar el articulo")
        End Try
        Return dcate
    End Function

    Public Function CD_ActualizarArticulo(idart As Integer, idcat As Integer, cod As Integer, nom As String, pre_ven As String, stock As Integer, desc As String, est As String)
        Dim actCat As New SqlCommand("SP_Set_ActualizarArticulo", cn)
        actCat.CommandType = CommandType.StoredProcedure
        actCat.Parameters.AddWithValue("@idarticulo", idart)
        actCat.Parameters.AddWithValue("@idcategoria", idcat)
        actCat.Parameters.AddWithValue("@codigo", cod)
        actCat.Parameters.AddWithValue("@nombre", nom)
        actCat.Parameters.AddWithValue("@precio_venta", pre_ven)
        actCat.Parameters.AddWithValue("@stock", stock)
        actCat.Parameters.AddWithValue("@descripcion", desc)
        actCat.Parameters.AddWithValue("@estado", est)
        cn.Open()
        Dim actCat1 As String = actCat.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado el Articulo")
        Catch ex As Exception
            MsgBox("Error al actualizar el Articulo")
        End Try
        Return actCat1
    End Function

End Class
