Public Class FormUsuarios
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataUsuarios.SP_Get_Listar_Usuarios' Puede moverla o quitarla según sea necesario.
        Me.SP_Get_Listar_UsuariosTableAdapter.Fill(Me.DataUsuarios.SP_Get_Listar_Usuarios)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class