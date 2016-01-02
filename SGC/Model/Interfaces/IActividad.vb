Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IActividad

#Region "Select"

        Function ListarActividades(ByVal id_comite As String, ByVal id_tipo_act As String, ByVal fec_inicio As DateTime, ByVal fec_fin As DateTime) As List(Of ActividadBE)
        Function ListarActividadesBusqueda(ByVal id_comite As String, ByVal nombre As String, ByVal id_estado As String) As List(Of ActividadBE)
        Function CargarActividadCabecera(ByVal id_actividad As Integer) As ActividadBE
        Function ListarActividadesPlan(ByVal id_comite As String, ByVal id_plan As Integer?) As List(Of ActividadBE)
        Function ListarActividadesPendientesPGC(ByVal id_comite As String) As List(Of ActividadBE)
        Function ListarActividadesAprobadasPGC(ByVal id_comite As String) As List(Of ActividadBE)
        Function ListarActividadesRechazadasPGC(ByVal id_comite As String) As List(Of ActividadBE)
        Function ListarActividadesCD(ByVal id_comite As String) As List(Of ActividadBE)
        Function ListarActividadesGG(ByVal id_comite As String) As List(Of ActividadBE)
        Function ListarActividadesCalendario(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)

#End Region

#Region "Insert"

        Function InsertarActividad(ByRef oActividad As ActividadBE) As Integer
        Function InsertarActividadDetalle(ByRef oActividadDetalle As ActividadDetalleBE) As Integer
        Function InsertarTipoPersonalXActividad(ByRef oTipoPersonal As TipoPersonalBE) As Integer
        Function InsertarRecursoXActividad(ByRef oRecurso As RecursoBE) As Integer
        Function InsertarRestriccionXActividad(ByRef oRestriccion As RestriccionesBE) As Integer
        Function InsertarActividadesPlanXML(ByRef oPlan As PlanAnualBE) As Boolean
        Function InsertarPersonalXActividad(ByRef oPersonal As PersonalBE) As Integer

#End Region

#Region "Update"

        Function ActualizarActividad(ByRef oActividad As ActividadBE) As Integer
        Function ActualizarActividadEstado(ByRef oActividad As ActividadBE) As Integer

        Function ActualizarActividadEstadoPlan(ByVal id_plan As Integer, ByVal id_estado As String) As Integer

#End Region

#Region "Delete"

        Function BorrarActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarActividadDetalle(ByVal id_actividad As Integer) As Integer
        Function BorrarTipoPersonalXActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarRecursosXActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarRestriccionesXActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarPersonalXActividad(ByVal id_actividad As Integer) As Integer

#End Region

    End Interface

End Namespace

