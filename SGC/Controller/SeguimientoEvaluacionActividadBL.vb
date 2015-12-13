Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Insert"

        Public Function InsertarSeguimientoActividades(ByRef oListadoActividad As List(Of ActividadBE), ByVal id_area As Integer, ByVal id_estado As Integer) As Integer
            Try
                Dim iActividad As ISeguimientoEvaluacionActividad
                iActividad = New SeguimientoEvaluacionActividadDL

                Dim id_seguimiento As Integer

                Dim oSeguimientoEvaluacion As SeguimientoEvaluacionActividadBE

                If oListadoActividad IsNot Nothing Then
                    For Each oActividad As ActividadBE In oListadoActividad
                        oSeguimientoEvaluacion = New SeguimientoEvaluacionActividadBE
                        oSeguimientoEvaluacion.fecha = Now
                        oSeguimientoEvaluacion.id_actividad = oActividad.id_actividad
                        oSeguimientoEvaluacion.id_area = id_area
                        oSeguimientoEvaluacion.id_estado = id_estado
                        id_seguimiento = iActividad.InsertarSeguimientoEvaluacionActividad(oSeguimientoEvaluacion)
                    Next
                End If

                Return id_seguimiento

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
