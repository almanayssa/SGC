Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface ISemaforo

#Region "Select"

        Function ListarSemaforoPorFechas(ByVal id_comite As String, ByVal id_tipo_1 As String, ByVal id_tipo_2 As String, ByVal fec_ini As DateTime, ByVal fec_fin As DateTime) As List(Of SemaforoBE)
        Function ListarSemaforoPorMes(ByVal id_comite As String, ByVal id_tipo_1 As String, ByVal id_tipo_2 As String, ByVal anio_mes As String) As List(Of SemaforoBE)
        Function ListarSemaforoVariables(ByVal id_comite As String, ByVal id_tipo_1 As String, ByVal id_tipo_2 As String, ByVal anio_mes As String) As String
        Function ListarComparativoTipo(ByVal id_comite As String, ByVal id_tipo As String, ByVal fec_ini As DateTime, ByVal fec_fin As DateTime) As List(Of SemaforoBE)

#End Region

    End Interface

End Namespace

