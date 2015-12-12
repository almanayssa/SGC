Imports SGC.Model.Entidades


Namespace SGC.Model.Interfaces

    Public Interface IPresupuestoAnual

#Region "Select"

        Function ObtenerPresupuestoAnual(ByVal id_plan As Integer?) As PresupuestoAnualBE

#End Region

#Region "Insert"

        Function InsertarPresupuestoAnual(ByRef oPresupuesto As PresupuestoAnualBE) As Integer

#End Region

    End Interface

End Namespace