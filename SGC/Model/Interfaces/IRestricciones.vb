Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IRestricciones

#Region "Select"

        Function ListarRestricciones() As List(Of RestriccionesBE)
        Function ListarRestriccionesXActividad(ByVal id_actividad As Integer) As List(Of RestriccionesBE)

#End Region

    End Interface

End Namespace
