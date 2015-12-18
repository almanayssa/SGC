Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class UsuarioDL
        Implements IUsuario

#Region "Select"

        Public Function ListarUsuarios(ByVal id_perfil As Integer) As List(Of Entidades.UsuarioBE) Implements Interfaces.IUsuario.ListarUsuarios
            Dim oListadoUsuario As New List(Of UsuarioBE)
            Dim oUsuario As UsuarioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_USUARIOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_perfil", SqlDbType.Int).Value = id_perfil

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oUsuario = New UsuarioBE
                    oUsuario.id_usuario = dr("id_usuario")
                    oUsuario.username = dr("username")
                    oUsuario.password = dr("password")
                    oUsuario.email = dr("email")
                    oUsuario.nombres = dr("nombres")
                    oUsuario.ape_pat = dr("ape_pat")
                    oUsuario.id_perfil_usuario = dr("id_Perfil_Usuario")
                    oListadoUsuario.Add(oUsuario)
                End While
                dr.Close()
                Return oListadoUsuario
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerUsuario(ByVal username As String, ByVal password As String) As UsuarioBE Implements Interfaces.IUsuario.ObtenerUsuario
            Dim oUsuario As New UsuarioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_USUARIO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
            sqlCmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oUsuario = New UsuarioBE
                    oUsuario.id_usuario = dr("id_usuario")
                    oUsuario.username = dr("username")
                    oUsuario.password = dr("password")
                    oUsuario.email = dr("email")
                    oUsuario.nombres = dr("nombres")
                    oUsuario.ape_pat = dr("ape_pat")
                    oUsuario.id_perfil_usuario = dr("id_Perfil_Usuario")
                End If
                dr.Close()
                Return oUsuario
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerUsuarioPorUser(ByVal username As String) As UsuarioBE Implements Interfaces.IUsuario.ObtenerUsuarioPorUser
            Dim oUsuario As New UsuarioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_USUARIO_POR_USER", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oUsuario = New UsuarioBE
                    oUsuario.id_usuario = dr("id_usuario")
                    oUsuario.username = dr("username")
                    oUsuario.password = dr("password")
                    oUsuario.email = dr("email")
                    oUsuario.nombres = dr("nombres")
                    oUsuario.ape_pat = dr("ape_pat")
                    oUsuario.id_perfil_usuario = dr("id_Perfil_Usuario")
                End If
                dr.Close()
                Return oUsuario
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerUsuarioPorId(ByVal id_usuario As String) As UsuarioBE Implements Interfaces.IUsuario.ObtenerUsuarioPorId
            Dim oUsuario As New UsuarioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_USUARIO_POR_ID", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = id_usuario

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oUsuario = New UsuarioBE
                    oUsuario.id_usuario = dr("id_usuario")
                    oUsuario.username = dr("username")
                    oUsuario.password = dr("password")
                    oUsuario.email = dr("email")
                    oUsuario.nombres = dr("nombres")
                    oUsuario.ape_pat = dr("ape_pat")
                    oUsuario.id_perfil_usuario = dr("id_Perfil_Usuario")
                End If
                dr.Close()
                Return oUsuario
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerUsuarioPorEmail(ByVal email As String) As UsuarioBE Implements Interfaces.IUsuario.ObtenerUsuarioPorEmail
            Dim oUsuario As New UsuarioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_USUARIO_POR_EMAIL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oUsuario = New UsuarioBE
                    oUsuario.id_usuario = dr("id_usuario")
                    oUsuario.username = dr("username")
                    oUsuario.password = dr("password")
                    oUsuario.email = dr("email")
                    oUsuario.nombres = dr("nombres")
                    oUsuario.ape_pat = dr("ape_pat")
                    oUsuario.id_perfil_usuario = dr("id_Perfil_Usuario")
                End If
                dr.Close()
                Return oUsuario
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarUsuario(ByRef oUsuario As Entidades.UsuarioBE) As String Implements Interfaces.IUsuario.InsertarUsuario
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_USUARIO", sqlConn)

            Dim recordId As String = String.Empty
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = oUsuario.username
            sqlCmd.Parameters.Add("@password", SqlDbType.VarChar).Value = oUsuario.password
            sqlCmd.Parameters.Add("@email", SqlDbType.VarChar).Value = oUsuario.email
            sqlCmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = oUsuario.nombres
            sqlCmd.Parameters.Add("@ape_pat", SqlDbType.VarChar).Value = oUsuario.ape_pat
            sqlCmd.Parameters.Add("@id_Perfil_Usuario", SqlDbType.Int).Value = oUsuario.id_perfil_usuario
            sqlCmd.Parameters.Add("@id_est_usu", SqlDbType.VarChar).Value = oUsuario.id_est_usu

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

#End Region

#Region "Update"

        Public Function ActualizarUsuario(ByRef oUsuario As Entidades.UsuarioBE) As Integer Implements Interfaces.IUsuario.ActualizarUsuario
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_USUARIO", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = oUsuario.id_usuario
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = oUsuario.username
            sqlCmd.Parameters.Add("@password", SqlDbType.VarChar).Value = oUsuario.password
            sqlCmd.Parameters.Add("@email", SqlDbType.VarChar).Value = oUsuario.email
            sqlCmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = oUsuario.nombres
            sqlCmd.Parameters.Add("@ape_pat", SqlDbType.VarChar).Value = oUsuario.ape_pat
            sqlCmd.Parameters.Add("@id_Perfil_Usuario", SqlDbType.Int).Value = oUsuario.id_perfil_usuario

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

        Public Function BorrarUsuario(ByVal id_usuario As String) As Integer Implements Interfaces.IUsuario.BorrarUsuario
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_USUARIO", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = id_usuario

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

