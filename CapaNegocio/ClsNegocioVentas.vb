Imports CapaDatos

Public Class ClsNegocioVentas

    Private objBuscarVenta As New ClsVentas
    Private objInsertarVenta As New ClsVentas
    Private objListarVenta As New ClsVentas
    Private objEliminarVenta As New ClsVentas
    Private objActualizarVenta As New ClsVentas
    Public Function N_BuscarVenta(Busqueda As String) As DataTable
        Return objBuscarVenta.CD_BuscarVenta(Busqueda)
    End Function
    Public Function N_InsertarVenta(idpersona As Integer, t_comprob As String, serie_comprob As String, num_comprob As String, fecha As Date, imp As Decimal, total As Decimal)
        Return objInsertarVenta.CD_InsertarVenta(idpersona, t_comprob, serie_comprob, num_comprob, fecha, imp, total)
    End Function
    Public Function CN_ListarVenta() As DataTable
        Return objListarVenta.CD_listarVenta
    End Function
    Public Function N_EliminarVenta(Eliminar As String)
        Return objEliminarVenta.CD_EliminarVenta(Eliminar)
    End Function
    Public Function N_ActualizarVenta(idventa As Integer, idpersona As Integer, t_comprob As String, serie_comprob As String, num_comprob As String, fecha As Date, imp As Decimal, total As Decimal)
        Return objActualizarVenta.CD_ActualizarVenta(idventa, idpersona, t_comprob, serie_comprob, num_comprob, fecha, imp, total)
    End Function

End Class
