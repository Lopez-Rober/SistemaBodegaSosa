Imports System.Configuration
Imports System.Data.SqlClient
Public Class ClsUsuario
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnTiendaSosa").ConnectionString)

    Public Function CD_listarUsuario() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Usuario", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_BuscarUsuario(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarUsuario", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_InsertarUsuario(idrol As Integer, nombre As String, tipo_documento As String, num_documento As String, direccion As String, telefono As String, email As String, password As String, estado As String)

        Dim da As New SqlCommand("SP_Set_AgregarUsuario", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@idrol", idrol)
        da.Parameters.AddWithValue("@nombre", nombre)
        da.Parameters.AddWithValue("@tipo_documento", tipo_documento)
        da.Parameters.AddWithValue("@num_documento", num_documento)
        da.Parameters.AddWithValue("@direccion", direccion)
        da.Parameters.AddWithValue("@telefono", telefono)
        da.Parameters.AddWithValue("@email", email)
        da.Parameters.AddWithValue("@password", password)
        da.Parameters.AddWithValue("@estado", estado)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado correctamente el Usuario")
        Catch ex As Exception
            MsgBox("Error al registrar Usuario")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarUsuario(idusu As Integer)
        Dim dcat As New SqlCommand("SP_Set_EliminarUsuario", cn)
        dcat.CommandType = CommandType.StoredProcedure
        dcat.Parameters.AddWithValue("@idusuario", idusu)
        cn.Open()
        Dim dcate As Integer = dcat.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado el usuario")
        Catch ex As Exception
            MsgBox("Error al eliminar el usuario")
        End Try
        Return dcate
    End Function

    Public Function CD_ActualizarUsuario(idusuario As Integer, idrol As Integer, nombre As String, tipo_documento As String, num_documento As String, direccion As String, telefono As String, email As String, password As String, estado As String)
        Dim actUsu As New SqlCommand("SP_Set_ActualizarUsuario", cn)
        actUsu.CommandType = CommandType.StoredProcedure
        actUsu.Parameters.AddWithValue("@idusuario", idusuario)
        actUsu.Parameters.AddWithValue("@idrol", idrol)
        actUsu.Parameters.AddWithValue("@nombre", nombre)
        actUsu.Parameters.AddWithValue("@tipo_documento", tipo_documento)
        actUsu.Parameters.AddWithValue("@num_documento", num_documento)
        actUsu.Parameters.AddWithValue("@direccion", direccion)
        actUsu.Parameters.AddWithValue("@telefono", telefono)
        actUsu.Parameters.AddWithValue("@email", email)
        actUsu.Parameters.AddWithValue("@password", password)
        actUsu.Parameters.AddWithValue("@estado", estado)
        cn.Open()
        Dim actUsua As String = actUsu.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado el usuario")
        Catch ex As Exception
            MsgBox("Error al actualizar el usuario")
        End Try
        Return actUsua
    End Function
End Class
