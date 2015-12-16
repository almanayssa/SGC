Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IOpcionXPerfil

#Region "Select"

        Function ListarOpcionesXPerfil(ByVal id_Perfil_Usuario As Integer) As List(Of OpcionXPerfilBE)

#End Region

#Region "Insert"

        Function InsertarOpcionXPerfil(ByRef oOpcionXPerfil As OpcionXPerfilBE) As Integer

#End Region

#Region "Delete"

        Function BorrarOpcionesXPerfil(ByVal id_Perfil_Usuario As Integer) As Integer

#End Region

    End Interface

End Namespace

