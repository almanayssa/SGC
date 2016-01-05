Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarFactActividadSum() As List(Of FactActividadSumBE)
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ListarFactActividadSum()

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarTotalesFactActividadSum(ByVal fecIni As Date, ByVal fecFin As Date, ByVal idComite As String, ByVal idTipo As String) As List(Of FactActividadSumBE)
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ListarTotalesFactActividadSum(fecIni, fecFin, idComite, idTipo)

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerMaxInscritosXTipoActividad(ByVal id_comite As String, ByVal id_tipo As String) As List(Of FactActividadSumBE)
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ObtenerMaxInscritosXTipoActividad(id_comite, id_tipo)

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerMaxSatisfaccionXTipoActividad(id_comite As String, id_tipo As String) As List(Of FactActividadSumBE)
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ObtenerMaxSatisfaccionXTipoActividad(id_comite, id_tipo)

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerSexoParticipantesXTipoActividad(id_comite As String, id_tipo As String) As FactActividadSumBE
            Try
                Dim iFact As IFactActividadSum
                Dim oFact As FactActividadSumBE = Nothing

                iFact = New FactActividadSumDL
                oFact = iFact.ObtenerSexoParticipantesXTipoActividad(id_comite, id_tipo)

                Return oFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerMesInscripcionXTipoActividad(id_comite As String, id_tipo As String) As List(Of FactActividadSumBE)
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ObtenerMesInscripcionXTipoActividad(id_comite, id_tipo)

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerMesesParticipacion(ByVal fecIni As Date, ByVal fecFin As Date, id_comite As String, id_tipo As String) As List(Of FactActividadSumBE)
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ObtenerMesesParticipacion(fecIni, fecFin, id_comite, id_tipo)

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarMesesParticipacion(ByVal fecIni As Date, ByVal fecFin As Date, id_comite As String, id_tipo As String) As List(Of FactActividadSumBE)
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ListarMesesParticipacion(fecIni, fecFin, id_comite, id_tipo)

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


