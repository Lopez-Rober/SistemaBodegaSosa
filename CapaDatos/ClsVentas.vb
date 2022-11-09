Imports System.Configuration
Imports System.Data.SqlClient

Public Class ClsVentas
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnTiendaSosa").ConnectionString)
    Public Function CD_BuscarVenta(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarVenta", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_listarVenta() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Venta", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_InsertarVenta(idpersona As Integer, t_comprob As String, serie_comprob As String, num_comprob As String, fecha As Date, imp As Decimal, total As Decimal)

        Dim da As New SqlCommand("SP_Set_AgregarVenta", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@idpersona", idpersona)
        da.Parameters.AddWithValue("@tipo_comprobante", t_comprob)
        da.Parameters.AddWithValue("@serie_comprobante", serie_comprob)
        da.Parameters.AddWithValue("@num_comprobante", num_comprob)
        da.Parameters.AddWithValue("@fecha_hora", fecha)
        da.Parameters.AddWithValue("@impuesto", imp)
        da.Parameters.AddWithValue("@total", total)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado la venta correctamente")
        Catch ex As Exception
            MsgBox("Error al registrar la venta")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarVenta(idvent As Integer)
        Dim dven As New SqlCommand("SP_Set_EliminarVenta", cn)
        dven.CommandType = CommandType.StoredProcedure
        dven.Parameters.AddWithValue("@idventa", idvent)
        cn.Open()
        Dim dvent As Integer = dven.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado el articulo")
        Catch ex As Exception
            MsgBox("Error al eliminar el articulo")
        End Try
        Return dvent
    End Function

    Public Function CD_ActualizarVenta(idventa As Integer, idpersona As Integer, t_comprob As String, serie_comprob As String, num_comprob As String, fecha As Date, imp As Decimal, total As Decimal)
        Dim actVen As New SqlCommand("SP_Set_ActualizarVenta", cn)
        actVen.CommandType = CommandType.StoredProcedure
        actVen.Parameters.AddWithValue("@idventa", idventa)
        actVen.Parameters.AddWithValue("@idpersona", idpersona)
        actVen.Parameters.AddWithValue("@tipo_comprobante", t_comprob)
        actVen.Parameters.AddWithValue("@serie_comprobante", serie_comprob)
        actVen.Parameters.AddWithValue("@num_comprobante", num_comprob)
        actVen.Parameters.AddWithValue("@fecha_hora", fecha)
        actVen.Parameters.AddWithValue("@impuesto", imp)
        actVen.Parameters.AddWithValue("@total", total)
        cn.Open()
        Dim actVent1 As String = actVen.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha actualizado la Venta")
        Catch ex As Exception
            MsgBox("Error al actualizar la Venta")
        End Try
        Return actVent1
    End Function
End Class
