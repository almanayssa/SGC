Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IDetallePresupuestoAct

#Region "Select"

        Function ListarDetallePresupuestoAct(ByVal id_presupuesto As Integer?) As List(Of DetallePresupuestoActBE)

        Function ObtenerRecursosPersonalAct(ByVal id_actividad As Integer?) As List(Of DetallePresupuestoActBE)

#End Region

#Region "Insert"

        Function InsertarDetallePresupuestoAct(ByRef oDetallePresupuesto As DetallePresupuestoActBE) As Integer

#End Region

    End Interface

End Namespace

