Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IRestricciones

#Region "Select"

        Function ListarRestricciones() As List(Of RestriccionesBE)
        Function ListarRestriccionesXActividad(ByVal id_actividad As Integer) As List(Of RestriccionesBE)
        Function ObtenerCantidadXRestriccion(ByVal id_actividad As Integer, ByVal id_restriccion As Integer, ByVal id_socio As String, ByVal id_persona As String, ByVal id_invitado As String) As String

#End Region

    End Interface

End Namespace
