Imports SGC.Model.Entidades


Namespace SGC.Model.Interfaces

    Public Interface IPlanAnual

#Region "Select"

        Function ListarPlanes(ByRef oPlanFiltro As PlanAnualBE) As List(Of PlanAnualBE)

        Function ObtenerPlan(ByVal id_plan As String) As PlanAnualBE

        Function ListarPlanesPendientesPGC(ByVal id_comite As String, ByVal anio As String) As List(Of PlanAnualBE)

        Function ListarPlanesAprobadosPGC(ByVal id_comite As String, ByVal anio As String) As List(Of PlanAnualBE)

        Function ListarPlanesRechazadosPGC(ByVal id_comite As String, ByVal anio As String) As List(Of PlanAnualBE)

        Function ListarPlanesCD(ByVal id_comite As String, ByVal anio As String) As List(Of PlanAnualBE)

#End Region

#Region "Insert"

        Function InsertarPlanAnual(ByRef oPlan As PlanAnualBE) As Integer

#End Region

#Region "Actualizar"

        Function ActualizarPlanAnual(ByRef oPlan As PlanAnualBE) As Integer

        Function ActualizarPlanEstado(ByRef oPlan As PlanAnualBE) As Integer
#End Region

    End Interface

End Namespace