Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class PerfilUsuarioDL
        Implements IPerfilUsuario

#Region "Select"

        Public Function ListarPerfiles() As List(Of Entidades.PerfilUsuarioBE) Implements Interfaces.IPerfilUsuario.ListarPerfiles
            Dim oListadoPerfil As New List(Of PerfilUsuarioBE)
            Dim oPerfil As PerfilUsuarioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PERFILES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPerfil = New PerfilUsuarioBE
                    oPerfil.id_perfil_usuario = dr("id_Perfil_Usuario")
                    oPerfil.nombre = dr("Nombre")
                    oListadoPerfil.Add(oPerfil)
                End While
                dr.Close()
                Return oListadoPerfil
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarPerfilesBusqueda(ByVal nombre As String) As List(Of Entidades.PerfilUsuarioBE) Implements Interfaces.IPerfilUsuario.ListarPerfilesBusqueda
            Dim oListadoPerfil As New List(Of PerfilUsuarioBE)
            Dim oPerfil As PerfilUsuarioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PERFILES_BUSQUEDA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPerfil = New PerfilUsuarioBE
                    oPerfil.id_perfil_usuario = dr("id_Perfil_Usuario")
                    oPerfil.nombre = dr("Nombre")
                    oListadoPerfil.Add(oPerfil)
                End While
                dr.Close()
                Return oListadoPerfil
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerPerfil(ByVal id_perfil As Integer) As PerfilUsuarioBE Implements Interfaces.IPerfilUsuario.ObtenerPerfil
            Dim oPerfil As New PerfilUsuarioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_PERFIL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_perfil", SqlDbType.Int).Value = id_perfil

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oPerfil = New PerfilUsuarioBE
                    oPerfil.id_perfil_usuario = dr("id_Perfil_Usuario")
                    oPerfil.nombre = dr("Nombre")
                End If
                dr.Close()
                Return oPerfil
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarPerfil(ByRef oPerfil As Entidades.PerfilUsuarioBE) As Integer Implements Interfaces.IPerfilUsuario.InsertarPerfil
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_PERFIL", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = oPerfil.nombre

            Try
                sqlConn.Open()
                recordId = sqlCmd.ExecuteScalar()

                Return recordId
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function InsertarOpcionXPerfil(ByRef oOpcion As PantallaBE) As Integer Implements IPerfilUsuario.InsertarOpcionXPerfil
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_OPCIONES_X_PERFIL", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_Perfil_Usuario", SqlDbType.Int).Value = oOpcion.id_perfil_usuario
            sqlCmd.Parameters.Add("@id_pantalla", SqlDbType.Int).Value = oOpcion.id_pantalla

            Try
                sqlConn.Open()
                recordId = sqlCmd.ExecuteScalar()

                Return recordId
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try

        End Function

        Public Function BorrarOpcionesXPerfil(ByVal id_perfil_usuario As Integer) As Integer Implements Interfaces.IPerfilUsuario.BorrarOpcionesXPerfil
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_OPCIONES_X_PERFIL", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_Perfil_Usuario", SqlDbType.Int).Value = id_perfil_usuario

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Update"

        Public Function ActualizarPerfil(ByRef oPerfil As Entidades.PerfilUsuarioBE) As Integer Implements Interfaces.IPerfilUsuario.ActualizarPerfil
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_PERFIL", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_perfil", SqlDbType.Int).Value = oPerfil.id_perfil_usuario
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = oPerfil.nombre

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarPerfil(ByVal id_perfil As Integer) As Integer Implements Interfaces.IPerfilUsuario.BorrarPerfil
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_PERFIL", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_perfil", SqlDbType.Int).Value = id_perfil

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

