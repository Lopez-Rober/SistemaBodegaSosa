Imports Microsoft.Reporting.WinForms

Public Class FormSetUsuarios
    Private Sub FormSetUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnParametro_Click(sender As Object, e As EventArgs) Handles btnParametro.Click
        Me.SP_Get_BuscarUsuariosTableAdapter.Fill(Me.DataSetUsuarios.SP_Get_BuscarUsuarios, txtParametro.Text)

        Dim parameters(0) As ReportParameter
        parameters(0) = New ReportParameter("Rol", Me.txtParametro.Text)

        ReportViewer1.LocalReport.SetParameters(parameters)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class