Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IPresupuestoActividad

#Region "Select"

        Function ObtenerPresupuestoActividad(ByVal id_actividad As Integer?) As PresupuestoActividadBE

#End Region

#Region "Insert"

        Function InsertarPresupuestoActividad(ByRef oPresupuesto As PresupuestoActividadBE) As Integer

#End Region

    End Interface

End Namespace

