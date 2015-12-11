Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IActividad

#Region "Select"

        Function ListarActividades(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
        Function CargarActividadCabecera(ByVal id_actividad As Integer) As ActividadBE
        Function ObtenerActividad(ByVal id_actividad As Integer) As ActividadBE
        Function ListarActividadesPlan(ByVal id_comite As String, ByVal id_plan As Integer?) As List(Of ActividadBE)

#End Region

#Region "Insert"

        Function InsertarActividad(ByRef oActividad As ActividadBE) As Integer
        Function InsertarTipoPersonalXActividad(ByRef oTipoPersonal As TipoPersonalBE) As Integer
        Function InsertarRecursoXActividad(ByRef oRecurso As RecursoBE) As Integer
        Function InsertarRestriccionXActividad(ByRef oRestriccion As RestriccionesBE) As Integer
        Function InsertarActividadesPlanXML(ByRef oPlan As PlanAnualBE) As Integer
#End Region

#Region "Update"

        Function ActualizarActividad(ByRef oActividad As ActividadBE) As Integer
        Function ActualizarRecursosXActividad(ByRef oRecurso As RecursoBE) As Integer

#End Region

#Region "Delete"

        Function BorrarActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarTipoPersonalXActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarRecursosXActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarRestriccionesXActividad(ByVal id_actividad As Integer) As Integer

#End Region

    End Interface

End Namespace

