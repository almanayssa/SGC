Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IInvitado

#Region "Select"

        Function ListarInvitados(ByVal clave As String, ByVal nombre As String) As List(Of InvitadoBE)

#End Region

    End Interface

End Namespace

