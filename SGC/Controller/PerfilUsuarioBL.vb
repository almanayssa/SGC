Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarPerfiles() As List(Of PerfilUsuarioBE)
            Try
                Dim iPerfilUsuario As IPerfilUsuario
                Dim oListadoPerfiles As List(Of PerfilUsuarioBE) = Nothing

                iPerfilUsuario = New PerfilUsuarioDL
                oListadoPerfiles = iPerfilUsuario.ListarPerfiles()

                Return oListadoPerfiles

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarPerfilesBusqueda(ByVal nombre As String) As List(Of PerfilUsuarioBE)
            Try
                Dim iPerfilUsuario As IPerfilUsuario
                Dim oListadoPerfiles As List(Of PerfilUsuarioBE) = Nothing

                iPerfilUsuario = New PerfilUsuarioDL
                oListadoPerfiles = iPerfilUsuario.ListarPerfilesBusqueda(nombre)

                Return oListadoPerfiles

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerPerfil(ByVal id_perfil As Integer) As PerfilUsuarioBE
            Try
                Dim iPerfilUsuario As IPerfilUsuario
                Dim oPerfil As PerfilUsuarioBE = Nothing

                iPerfilUsuario = New PerfilUsuarioDL
                oPerfil = iPerfilUsuario.ObtenerPerfil(id_perfil)

                Return oPerfil

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarPerfil(ByRef oPerfil As PerfilUsuarioBE) As Integer
            Try
                Dim iPerfilUsuario As IPerfilUsuario
                iPerfilUsuario = New PerfilUsuarioDL

                Dim id_perfil_usuario As Integer
                id_perfil_usuario = iPerfilUsuario.InsertarPerfil(oPerfil)

                oPerfil.id_perfil_usuario = id_perfil_usuario

                Return oPerfil.id_perfil_usuario

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function GuardarOpcionesPerfil(ByRef oPerfil As PerfilUsuarioBE) As Integer
            Try
                Dim affectedRows As Integer

                Dim iPerfil As IPerfilUsuario
                iPerfil = New PerfilUsuarioDL

                affectedRows += iPerfil.BorrarOpcionesXPerfil(oPerfil.id_perfil_usuario)

                If oPerfil.ListaOpciones IsNot Nothing Then
                    For Each oOpcion As PantallaBE In oPerfil.ListaOpciones
                        oOpcion.id_perfil_usuario = oPerfil.id_perfil_usuario
                        affectedRows += iPerfil.InsertarOpcionXPerfil(oOpcion)
                    Next
                End If

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function


#End Region

#Region "Update"

        Public Function ActualizarPerfil(ByRef oPerfil As PerfilUsuarioBE) As Integer
            Try
                Dim affectedRows As Integer

                Dim iPerfilUsuario As IPerfilUsuario
                iPerfilUsuario = New PerfilUsuarioDL

                affectedRows += iPerfilUsuario.ActualizarPerfil(oPerfil)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarPerfil(ByRef id_perfil As Integer) As Integer
            Try
                Dim iPerfilUsuario As IPerfilUsuario
                iPerfilUsuario = New PerfilUsuarioDL

                Dim affectedRows As Integer
                affectedRows = iPerfilUsuario.BorrarPerfil(id_perfil)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

