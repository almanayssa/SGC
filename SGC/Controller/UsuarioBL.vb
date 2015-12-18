Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarUsuarios(ByVal id_perfil As Integer) As List(Of UsuarioBE)
            Try
                Dim iUsuario As IUsuario
                Dim oListadoUsuarios As List(Of UsuarioBE) = Nothing

                iUsuario = New UsuarioDL
                oListadoUsuarios = iUsuario.ListarUsuarios(id_perfil)

                Return oListadoUsuarios

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerUsuario(ByVal username As String, ByVal password As String) As UsuarioBE
            Try
                Dim iUsuario As IUsuario
                Dim oUsuario As UsuarioBE = Nothing

                iUsuario = New UsuarioDL
                oUsuario = iUsuario.ObtenerUsuario(username, password)

                Return oUsuario

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerUsuarioPorUser(ByVal username As String) As UsuarioBE
            Try
                Dim iUsuario As IUsuario
                Dim oUsuario As UsuarioBE = Nothing

                iUsuario = New UsuarioDL
                oUsuario = iUsuario.ObtenerUsuarioPorUser(username)

                Return oUsuario

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerUsuarioPorId(ByVal id_usuario As String) As UsuarioBE
            Try
                Dim iUsuario As IUsuario
                Dim oUsuario As UsuarioBE = Nothing

                iUsuario = New UsuarioDL
                oUsuario = iUsuario.ObtenerUsuarioPorId(id_usuario)

                Return oUsuario

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerUsuarioPorEmail(ByVal email As String) As UsuarioBE
            Try
                Dim iUsuario As IUsuario
                Dim oUsuario As UsuarioBE = Nothing

                iUsuario = New UsuarioDL
                oUsuario = iUsuario.ObtenerUsuarioPorEmail(email)

                Return oUsuario

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarUsuario(ByRef oUsuario As UsuarioBE) As String
            Try
                Dim iUsuario As IUsuario
                iUsuario = New UsuarioDL

                Dim id_usuario As String
                id_usuario = iUsuario.InsertarUsuario(oUsuario)

                oUsuario.id_usuario = id_usuario

                Return oUsuario.id_usuario

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Update"

        Public Function ActualizarUsuario(ByRef oUsuario As UsuarioBE) As Integer
            Try
                Dim affectedRows As Integer

                Dim iUsuario As IUsuario
                iUsuario = New UsuarioDL

                affectedRows += iUsuario.ActualizarUsuario(oUsuario)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarUsuario(ByRef id_usuario As String) As Integer
            Try
                Dim iUsuario As IUsuario
                iUsuario = New UsuarioDL

                Dim affectedRows As Integer
                affectedRows = iUsuario.BorrarUsuario(id_usuario)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

