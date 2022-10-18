Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Imports System.Security.Policy

Public Class ClsCategoria

    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnTiendaSosa").ConnectionString)

    Public Function listarCategoria() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Categoria", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_BuscarCategoria(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarCategoria", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_InsertarCategoria(nom As String, desc As String, est As String)

        Dim da As New SqlCommand("SP_Set_AgregarCategoria", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@nombre", nom)
        da.Parameters.AddWithValue("@descripcion", desc)
        da.Parameters.AddWithValue("@estado", est)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado correctamente")
        Catch ex As Exception
            MsgBox("Error al registrar categoria")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarCategoria(idcat As Integer)
        Dim dcat As New SqlCommand("SP_Set_EliminarCategoria", cn)
        dcat.CommandType = CommandType.StoredProcedure
        dcat.Parameters.AddWithValue("@idcategoria", idcat)
        cn.Open()
        Dim dcate As Integer = dcat.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado la categoria")
        Catch ex As Exception
            MsgBox("Error al eliminar la categoria")
        End Try
        Return dcate
    End Function

    Public Function CD_ActualizarCategoria(idcat As Integer, nom As String, desc As String, est As String)
        Dim actCat As New SqlCommand("SP_Set_ActualizarCategoria", cn)
        actCat.CommandType = CommandType.StoredProcedure
        actCat.Parameters.AddWithValue("@idcategoria", idcat)
        actCat.Parameters.AddWithValue("@nombre", nom)
        actCat.Parameters.AddWithValue("@descripcion", desc)
        actCat.Parameters.AddWithValue("@estado", est)
        cn.Open()
        Dim actCat1 As String = actCat.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado la categoria")
        Catch ex As Exception
            MsgBox("Error al actualizar la categoria")
        End Try
        Return actCat1
    End Function
End Class
