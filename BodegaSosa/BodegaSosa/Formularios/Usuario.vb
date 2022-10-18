Imports CapaNegocio

Public Class Usuario
    Dim conexion As clsConexion = New clsConexion()
    Dim ObjListUsu As New ClsNegocioUsuario
    Dim ObjRegisUsu As New ClsNegocioUsuario
    Dim ObjModiUsu As New ClsNegocioUsuario
    Dim ObjElimUsu As New ClsNegocioUsuario
    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGUsuario.DataSource = ObjListUsu.CN_ListarUsuario
    End Sub

    Private Sub DGUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuario.CellContentClick
        lblCodigo.Text = DGUsuario.Item(0, e.RowIndex).Value
        txtRol.Text = DGUsuario.Item(1, e.RowIndex).Value
        txtNombre.Text = DGUsuario.Item(2, e.RowIndex).Value
        txtTipoDoc.Text = DGUsuario.Item(3, e.RowIndex).Value
        txtNumDoc.Text = DGUsuario.Item(4, e.RowIndex).Value
        txtDireccion.Text = DGUsuario.Item(5, e.RowIndex).Value
        txtTelefono.Text = DGUsuario.Item(6, e.RowIndex).Value
        txtEmail.Text = DGUsuario.Item(7, e.RowIndex).Value
        txtPassword.Text = DGUsuario.Item(8, e.RowIndex).Value
        txtEstado.Text = DGUsuario.Item(9, e.RowIndex).Value
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjRegisUsu.N_InsertarUsuario(txtRol.Text, txtNombre.Text, txtTipoDoc.Text, txtNumDoc.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtPassword.Text, txtEstado.Text)
        DGUsuario.DataSource = ObjRegisUsu.CN_ListarUsuario

        lblCodigo.Text = "0000"
        txtRol.Text = ""
        txtNombre.Text = ""
        txtTipoDoc.Text = ""
        txtNumDoc.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtEstado.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ObjRegisUsu.N_ActualizarUsuario(lblCodigo.Text, txtRol.Text, txtNombre.Text, txtTipoDoc.Text, txtNumDoc.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtPassword.Text, txtEstado.Text)
        DGUsuario.DataSource = ObjRegisUsu.CN_ListarUsuario
        lblCodigo.Text = "0000"
        txtRol.Text = ""
        txtNombre.Text = ""
        txtTipoDoc.Text = ""
        txtNumDoc.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtEstado.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjElimUsu.N_EliminarUsuario(lblCodigo.Text)
        DGUsuario.DataSource = ObjElimUsu.CN_ListarUsuario
        lblCodigo.Text = "0000"
        txtRol.Text = ""
        txtNombre.Text = ""
        txtTipoDoc.Text = ""
        txtNumDoc.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtEstado.Text = ""
    End Sub
End Class