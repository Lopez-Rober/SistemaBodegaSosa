Imports CapaNegocio

Public Class Reportes
    Dim conexion As clsConexion = New clsConexion()
    Dim objList As New ClsNegocioReportes

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGReportes.DataSource = objList.CN_ListarReportes
    End Sub

End Class