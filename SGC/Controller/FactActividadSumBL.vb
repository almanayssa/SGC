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

        Public Function ListarTotalesFactActividadSum() As List(Of FactActividadSumBE)
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ListarTotalesFactActividadSum()

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerMaxInscritosXTipoActividad(ByVal id_comite As String) As String
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing
                Dim msj As String = ""

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ObtenerMaxInscritosXTipoActividad(id_comite)

                If oListadoFact IsNot Nothing AndAlso oListadoFact.Count > 0 Then
                    msj = "Sugerencia de Tipo de actividad: " & vbCrLf
                    For Each oFact As FactActividadSumBE In oListadoFact
                        msj &= oFact.tipo_actividad & "" & vbCrLf
                    Next
                Else
                    msj = "No hay sugerencias"
                End If

                Return msj

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

        Public Function ObtenerSexoParticipantesXTipoActividad(id_comite As String, id_tipo As String) As List(Of FactActividadSumBE)
            Try
                Dim iFact As IFactActividadSum
                Dim oListadoFact As List(Of FactActividadSumBE) = Nothing

                iFact = New FactActividadSumDL
                oListadoFact = iFact.ObtenerSexoParticipantesXTipoActividad(id_comite, id_tipo)

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


