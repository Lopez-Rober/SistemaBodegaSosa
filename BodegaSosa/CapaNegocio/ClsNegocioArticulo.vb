Imports CapaDatos
Imports CapaEntidad
Public Class ClsNegocioArticulo
    Private objDatosBuscarArticulo As New ClsArticulo
    Private objInsertarArticulo As New ClsArticulo
    Private objListarArticulo As New ClsArticulo
    Private objEliminarArticulo As New ClsArticulo
    Private objActualizarArticulo As New ClsArticulo
    Public Function N_BuscarArticulo(Busqueda As String) As DataTable
        Return objDatosBuscarArticulo.CD_BuscarArticulo(Busqueda)
    End Function
    Public Function N_InsertarArticulo(idcat As Integer, cod As String, nom As String, pre_ven As String, stock As Integer, desc As String, estado As String)
        Return objInsertarArticulo.CD_InsertarArticulo(idcat, cod, nom, pre_ven, stock, desc, estado)
    End Function
    Public Function CN_ListarArticulo() As DataTable
        Return objListarArticulo.CD_listarArticulo
    End Function
    Public Function N_EliminarArticulo(Eliminar As String)
        Return objEliminarArticulo.CD_EliminarArticulo(Eliminar)
    End Function
    Public Function N_ActualizarArticulo(idart As Integer, idcat As Integer, cod As String, nom As String, pre_ven As String, stock As Integer, desc As String, estado As String)
        Return objActualizarArticulo.CD_ActualizarArticulo(idart, idcat, cod, nom, pre_ven, stock, desc, estado)
    End Function
End Class
