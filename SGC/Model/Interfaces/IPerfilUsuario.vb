Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IPerfilUsuario

#Region "Select"

        Function ListarPerfiles() As List(Of PerfilUsuarioBE)
        Function ListarPerfilesBusqueda(ByVal nombre As String) As List(Of PerfilUsuarioBE)
        Function ObtenerPerfil(ByVal id_perfil As Integer) As PerfilUsuarioBE

#End Region

#Region "Insert"

        Function InsertarPerfil(ByRef oPerfil As PerfilUsuarioBE) As Integer
        Function InsertarOpcionXPerfil(ByRef oOpcion As PantallaBE) As Integer

#End Region

#Region "Update"

        Function ActualizarPerfil(ByRef oPerfil As PerfilUsuarioBE) As Integer

#End Region

#Region "Delete"

        Function BorrarPerfil(ByVal id_Perfil_Usuario As Integer) As Integer
        Function BorrarOpcionesXPerfil(ByVal id_Perfil_Usuario As Integer) As Integer

#End Region

    End Interface

End Namespace

