Imports CapaNegocio

Public Class Articulos

    Dim conexion As clsConexion = New clsConexion()
    Dim ObjBuscar As New ClsNegocioArticulo
    Dim ObjInsertar As New ClsNegocioArticulo
    Dim ObjListar As New ClsNegocioArticulo
    Dim ObjEliminar As New ClsNegocioArticulo
    Dim ObjActualizar As New ClsNegocioArticulo

    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGArticulo.DataSource = ObjListar.CN_ListarArticulo
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGArticulo.CellContentClick
        lblCodigo.Text = DGArticulo.Item(0, e.RowIndex).Value
        txtCategoria.Text = DGArticulo.Item(1, e.RowIndex).Value
        txtCodArt.Text = DGArticulo.Item(2, e.RowIndex).Value
        txtNombre.Text = DGArticulo.Item(3, e.RowIndex).Value
        txtPrecio.Text = DGArticulo.Item(4, e.RowIndex).Value
        txtStock.Text = DGArticulo.Item(5, e.RowIndex).Value
        txtDescripcion.Text = DGArticulo.Item(6, e.RowIndex).Value
        txtEstado.Text = DGArticulo.Item(7, e.RowIndex).Value
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Buscar = txtBuscarArticulo.Text
        DGArticulo.DataSource = ObjBuscar.N_BuscarArticulo(txtBuscarArticulo.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjInsertar.N_InsertarArticulo(txtCategoria.Text, txtCodArt.Text, txtNombre.Text, txtPrecio.Text, txtStock.Text, txtDescripcion.Text, txtEstado.Text)
        DGArticulo.DataSource = ObjInsertar.CN_ListarArticulo
        txtCategoria.Text = ""
        txtCodArt.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtStock.Text = ""
        txtDescripcion.Text = ""
        txtEstado.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjEliminar.N_EliminarArticulo(lblCodigo.Text)
        DGArticulo.DataSource = ObjEliminar.CN_ListarArticulo
        txtCategoria.Text = ""
        txtCodArt.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtStock.Text = ""
        txtDescripcion.Text = ""
        txtEstado.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ObjActualizar.N_ActualizarArticulo(lblCodigo.Text, txtCategoria.Text, txtCodArt.Text, txtNombre.Text, txtPrecio.Text, txtStock.Text, txtDescripcion.Text, txtEstado.Text)
        DGArticulo.DataSource = ObjActualizar.CN_ListarArticulo
        lblCodigo.Text = "0000"
        txtCategoria.Text = ""
        txtCodArt.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtStock.Text = ""
        txtDescripcion.Text = ""
        txtEstado.Text = ""
    End Sub
End Class