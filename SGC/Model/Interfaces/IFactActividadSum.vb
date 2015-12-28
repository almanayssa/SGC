Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IFactActividadSum

#Region "Select"

        Function ListarFactActividadSum() As List(Of FactActividadSumBE)

        Function ListarTotalesFactActividadSum() As List(Of FactActividadSumBE)

        Function ObtenerMaxInscritosXTipoActividad(ByVal id_comite As String) As List(Of FactActividadSumBE)

        Function ObtenerMaxSatisfaccionXTipoActividad(ByVal id_comite As String, ByVal id_tipo As String) As List(Of FactActividadSumBE)

        Function ObtenerSexoParticipantesXTipoActividad(ByVal id_comite As String, ByVal id_tipo As String) As List(Of FactActividadSumBE)

#End Region

    End Interface

End Namespace

