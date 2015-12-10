Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IActividad

#Region "Select"

        Function ListarActividades(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
        'Function ListarActividadesAInscribir(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
        'Function CargarActividadCabecera(ByVal id_actividad As Integer) As ActividadBE
        'Function ListarActividadesPorComite_TipoActividad(ByVal comiteID As String, ByVal tipoActividadID As String) As List(Of ActividadBE)

        'Function ListarActividadesNoRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
        'Function ListarActividadesRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
        'Function ObtenerActividad(ByVal id_actividad As Integer) As ActividadBE

        'Function ListarActividadesPlan(ByVal id_plananual_comite As Integer) As List(Of ActividadBE)
        'Function ListarActividadesEstado(ByVal id_comite As String, ByVal nombre As String, ByVal estado As String) As List(Of ActividadBE)


#End Region

    End Interface

End Namespace

