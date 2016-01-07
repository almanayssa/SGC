Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarSemaforoPorFechas(ByVal id_comite As String, ByVal id_tipo_1 As String, ByVal id_tipo_2 As String, ByVal fec_ini As DateTime, ByVal fec_fin As DateTime) As List(Of SemaforoBE)
            Try
                Dim iSemaforo As ISemaforo
                Dim oListadoSemaforo As List(Of SemaforoBE) = Nothing

                iSemaforo = New SemaforoDL
                oListadoSemaforo = iSemaforo.ListarSemaforoPorFechas(id_comite, id_tipo_1, id_tipo_2, fec_ini, fec_fin)

                Return oListadoSemaforo

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarSemaforoPorMes(ByVal id_comite As String, ByVal id_tipo_1 As String, ByVal id_tipo_2 As String, ByVal anio_mes As String) As List(Of SemaforoBE)
            Try
                Dim iSemaforo As ISemaforo
                Dim oListadoSemaforo As List(Of SemaforoBE) = Nothing

                iSemaforo = New SemaforoDL
                oListadoSemaforo = iSemaforo.ListarSemaforoPorMes(id_comite, id_tipo_1, id_tipo_2, anio_mes)

                Return oListadoSemaforo

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarSemaforoVariables(ByVal id_comite As String, ByVal id_tipo_1 As String, ByVal id_tipo_2 As String, ByVal anio_mes As String) As String
            Try
                Dim iSemaforo As ISemaforo
                Dim variables As String = String.Empty

                iSemaforo = New SemaforoDL
                variables = iSemaforo.ListarSemaforoVariables(id_comite, id_tipo_1, id_tipo_2, anio_mes)

                Return variables

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

