Imports SGC.Model.Entidades


Namespace SGC.Model.Interfaces

    Public Interface IPlanAnual

#Region "Select"

        Function ListarPlanes(ByRef oPlanFiltro As PlanAnualBE) As List(Of PlanAnualBE)

        Function ObtenerPlan(ByVal id_plan As String) As PlanAnualBE

#End Region

#Region "Insert"

        Function InsertarPlanAnual(ByRef oPlan As PlanAnualBE) As Integer

#End Region

#Region "Actualizar"

        Function ActualizarPlanAnual(ByRef oPlan As PlanAnualBE) As Integer

#End Region

    End Interface

End Namespace