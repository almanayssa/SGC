Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IFactActividadSum

#Region "Select"

        Function ListarFactActividadSum() As List(Of FactActividadSumBE)

        Function ListarTotalesFactActividadSum(ByVal fecIni As Date, ByVal fecFin As Date, ByVal id_comite As String, ByVal id_tipo As String) As List(Of FactActividadSumBE)

        Function ObtenerMaxInscritosXTipoActividad(ByVal id_comite As String, ByVal id_tipo As String) As List(Of FactActividadSumBE)

        Function ObtenerMaxSatisfaccionXTipoActividad(ByVal id_comite As String, ByVal id_tipo As String) As List(Of FactActividadSumBE)

        Function ObtenerSexoParticipantesXTipoActividad(ByVal id_comite As String, ByVal id_tipo As String) As FactActividadSumBE

        Function ObtenerMesInscripcionXTipoActividad(ByVal id_comite As String, ByVal id_tipo As String) As List(Of FactActividadSumBE)

        Function ObtenerMesesParticipacion(ByVal fecIni As Date, ByVal fecFin As Date, ByVal id_comite As String, ByVal id_tipo As String) As List(Of FactActividadSumBE)

        Function ListarMesesParticipacion(ByVal fecIni As Date, ByVal fecFin As Date, ByVal id_comite As String, ByVal id_tipo As String) As List(Of FactActividadSumBE)

        Function ListarComitesParticipacion() As List(Of FactActividadSumBE)

        Function ListarTiposParticipacion() As List(Of FactActividadSumBE)

        Function ListarComitesActividades() As List(Of FactActividadSumBE)

        Function ListarTiposActividades() As List(Of FactActividadSumBE)

        Function ListarComitesSatisfaccion() As List(Of FactActividadSumBE)

        Function ObtenerSatisfaccionTotal() As Decimal

        Function ObtenerTotalActividades() As Integer

        Function ListarParticipantesPorAnio() As List(Of FactActividadSumBE)

        Function ListarCorrelacionMensual(ByVal id_comite As Integer, ByVal tipo_1 As String, ByVal tipo_2 As String, ByVal anio_fin As Integer) As List(Of FactActividadSumBE)

#End Region

    End Interface

End Namespace

