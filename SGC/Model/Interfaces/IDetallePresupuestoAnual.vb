﻿Imports SGC.Model.Entidades


Namespace SGC.Model.Interfaces

    Public Interface IDetallePresupuestoAnual

#Region "Select"

        Function ListarDetallePresupuestoAnual(ByVal id_presupuesto As Integer?) As PresupuestoAnualBE

#End Region

#Region "Insert"

        Function InsertarDetallePresupuestoAnual(ByRef oDetallePresupuesto As DetallePresupuestoAnualBE) As Integer

#End Region

    End Interface

End Namespace