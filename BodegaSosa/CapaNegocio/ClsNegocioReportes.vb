Imports CapaDatos
Public Class ClsNegocioReportes
    Private objListarReporte As New ClsReportes
    Public Function CN_ListarReportes() As DataTable
        Return objListarReporte.listarReportes
    End Function

End Class
