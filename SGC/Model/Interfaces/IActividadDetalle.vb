Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IActividadDetalle

#Region "Select"

        Function ListarDetallesXActividad(ByVal id_actividad As Integer) As List(Of ActividadDetalleBE)

#End Region

    End Interface

End Namespace

