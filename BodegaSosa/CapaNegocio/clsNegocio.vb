Imports CapaDatos
Imports CapaEntidad
Public Class cls_CapaNegocio
	Private objDatos As New ClsCategoria
	Private objDatosBuscarCategoria As New ClsCategoria
	Private dCat As New ClsCategoria
	Private Delim As New ClsCategoria
	Private CAct As New ClsCategoria

	Public Function N_InsertarCategoria(nom As String, desc As String, est As String)
		Return dCat.CD_InsertarCategoria(nom, desc, est)
	End Function

	Public Function CN_ListarCategoria() As DataTable
		Return objDatos.listarCategoria()
	End Function

	Public Function N_BuscarCategoria(Busqueda As String) As DataTable
		Return objDatosBuscarCategoria.CD_BuscarCategoria(Busqueda)
	End Function
	Public Function N_EliminarCategoria(Eliminar As String)
		Return Delim.CD_EliminarCategoria(Eliminar)
	End Function
	Public Function N_ActualizarCategoria(idcat As Integer, nom As String, desc As String, est As String)
		Return CAct.CD_ActualizarCategoria(idcat, nom, desc, est)
	End Function

End Class

