Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IRecurso

#Region "Select"

        Function ListarRecursos(ByVal descripcion As String) As List(Of RecursoBE)
        Function ListarRecursosXActividad(ByVal id_actividad As Integer) As List(Of RecursoBE)
        Function ObtenerRecursosDemanda(ByVal id_comite As String, ByVal id_tipo As String) As List(Of RecursoBE)
        Function ListarDemandaRecursos(ByVal fecIni As Date, ByVal fecFin As Date, ByVal id_comite As String, ByVal id_tipo As String) As List(Of RecursoBE)

#End Region

    End Interface

End Namespace

