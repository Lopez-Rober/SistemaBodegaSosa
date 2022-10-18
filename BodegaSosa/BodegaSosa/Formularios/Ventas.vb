
Imports CapaNegocio
Public Class Ventas
    Dim conexion As clsConexion = New clsConexion()
    Dim ObjListVent As New ClsNegocioVentas
    Dim ObjRegisVent As New ClsNegocioVentas
    Dim ObjActuaVent As New ClsNegocioVentas
    Dim ObjElimVent As New ClsNegocioVentas
    Dim ObjBuscarVent As New ClsNegocioVentas
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVenta.CellContentClick
        lblCodigo.Text = DGVenta.Item(0, e.RowIndex).Value
        txtCliente.Text = DGVenta.Item(1, e.RowIndex).Value
        txtTipoComp.Text = DGVenta.Item(2, e.RowIndex).Value
        txtSerieComp.Text = DGVenta.Item(3, e.RowIndex).Value
        txtNumComp.Text = DGVenta.Item(4, e.RowIndex).Value
        DateTimePicker1.Text = DGVenta.Item(5, e.RowIndex).Value
        txtImp.Text = DGVenta.Item(6, e.RowIndex).Value
        txtTotal.Text = DGVenta.Item(7, e.RowIndex).Value
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGVenta.DataSource = ObjListVent.CN_ListarVenta()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjRegisVent.N_InsertarVenta(txtCliente.Text, txtTipoComp.Text, txtSerieComp.Text, txtNumComp.Text, (CDate(DateTimePicker1.Text)), txtImp.Text, txtTotal.Text)
        DGVenta.DataSource = ObjRegisVent.CN_ListarVenta

        lblCodigo.Text = "0000"
        txtCliente.Text = ""
        txtTipoComp.Text = ""
        txtSerieComp.Text = ""
        txtNumComp.Text = ""
        DateTimePicker1.Value = DateTime.Now
        txtImp.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ObjActuaVent.N_ActualizarVenta(lblCodigo.Text, txtCliente.Text, txtTipoComp.Text, txtSerieComp.Text, txtNumComp.Text, (CDate(DateTimePicker1.Text)), txtImp.Text, txtTotal.Text)
        DGVenta.DataSource = ObjActuaVent.CN_ListarVenta
        lblCodigo.Text = "0000"
        txtCliente.Text = ""
        txtTipoComp.Text = ""
        txtSerieComp.Text = ""
        txtNumComp.Text = ""
        DateTimePicker1.Value = DateTime.Now
        txtImp.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjElimVent.N_EliminarVenta(lblCodigo.Text)
        DGVenta.DataSource = ObjElimVent.CN_ListarVenta
        lblCodigo.Text = "0000"
        txtCliente.Text = ""
        txtTipoComp.Text = ""
        txtSerieComp.Text = ""
        txtNumComp.Text = ""
        DateTimePicker1.Value = DateTime.Now
        txtImp.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Buscar = txtBuscar.Text
        DGVenta.DataSource = ObjBuscarVent.N_BuscarVenta(txtBuscar.Text)
    End Sub
End Class