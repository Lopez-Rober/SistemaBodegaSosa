Imports CapaDatos
Public Class ClsNegocioUsuario

    Private objBuscarUsuario As New ClsUsuario
    Private objInsertarUsuario As New ClsUsuario
    Private objListarUsuario As New ClsUsuario
    Private objEliminarUsuario As New ClsUsuario
    Private objActualizarUsuario As New ClsUsuario
    Public Function N_BuscarUsuario(Busqueda As String) As DataTable
        Return objBuscarUsuario.CD_BuscarUsuario(Busqueda)
    End Function
    Public Function N_InsertarUsuario(idrol As Integer, nombre As String, tipo_documento As String, num_documento As String, direccion As String, telefono As String, email As String, password As String, estado As String)
        Return objInsertarUsuario.CD_InsertarUsuario(idrol, nombre, tipo_documento, num_documento, direccion, telefono, email, password, estado)
    End Function
    Public Function CN_ListarUsuario() As DataTable
        Return objListarUsuario.CD_listarUsuario
    End Function
    Public Function N_EliminarUsuario(Eliminar As String)
        Return objEliminarUsuario.CD_EliminarUsuario(Eliminar)
    End Function
    Public Function N_ActualizarUsuario(idusuario As Integer, idrol As Integer, nombre As String, tipo_documento As String, num_documento As String, direccion As String, telefono As String, email As String, password As String, estado As String)
        Return objActualizarUsuario.CD_ActualizarUsuario(idusuario, idrol, nombre, tipo_documento, num_documento, direccion, telefono, email, password, estado)
    End Function

End Class
