Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CapaNegocio

Public Class Categorias


    Dim conexion As clsConexion = New clsConexion()
    Dim ObjNegocio As New cls_CapaNegocio
    Dim ObjRegisCat As New cls_CapaNegocio
    Dim objElim As New cls_CapaNegocio
    Dim objAct As New cls_CapaNegocio
    Dim objList As New cls_CapaNegocio

    Private Sub FormUSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion.conectar()
        Me.DGCategoria.DataSource = objList.CN_ListarCategoria()

    End Sub

    Private Sub DGCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCategoria.CellContentClick
        lblCodigo.Text = DGCategoria.Item(0, e.RowIndex).Value
        txtNombre.Text = DGCategoria.Item(1, e.RowIndex).Value
        txtDescripcion.Text = DGCategoria.Item(2, e.RowIndex).Value
        txtEstado.Text = DGCategoria.Item(3, e.RowIndex).Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Buscar = txtBuscar.Text
        DGCategoria.DataSource = ObjNegocio.N_BuscarCategoria(txtBuscar.Text)
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        ObjRegisCat.N_InsertarCategoria(txtNombre.Text, txtDescripcion.Text, txtEstado.Text)
        DGCategoria.DataSource = ObjRegisCat.CN_ListarCategoria
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtEstado.Text = ""


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtEstado.Text = ""
        lblCodigo.Text = "0000"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        objElim.N_EliminarCategoria(lblCodigo.Text)
        DGCategoria.DataSource = objElim.CN_ListarCategoria
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtEstado.Text = ""
        lblCodigo.Text = "0000"
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        objAct.N_ActualizarCategoria(lblCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtEstado.Text)
        DGCategoria.DataSource = objAct.CN_ListarCategoria
        txtEstado.Text = ""
        txtDescripcion.Text = ""
        txtEstado.Text = ""
        lblCodigo.Text = "0000"
    End Sub
End Class