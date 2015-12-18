Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IPantalla

#Region "Select"

        Function ListarOpciones() As List(Of PantallaBE)
        Function ListarOpcionesXPerfil(ByVal id_perfil_usuario As Integer) As List(Of PantallaBE)

#End Region

    End Interface

End Namespace

