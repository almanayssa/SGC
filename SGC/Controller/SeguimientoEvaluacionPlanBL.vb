Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Insert"

        Public Function InsertarSeguimientoPlanes(ByRef oListadoPlanes As List(Of PlanAnualBE), ByVal id_area As Integer, ByVal id_estado As Integer) As Integer
            Try
                Dim iPlanAnual As ISeguimientoEvaluacionPlan
                iPlanAnual = New SeguimientoEvaluacionPlanDL

                Dim id_seguimiento As Integer

                Dim oSeguimientoEvaluacion As SeguimientoEvaluacionPlanBE

                If oListadoPlanes IsNot Nothing Then
                    For Each oPlan As PlanAnualBE In oListadoPlanes
                        oSeguimientoEvaluacion = New SeguimientoEvaluacionPlanBE
                        oSeguimientoEvaluacion.fecha = Now
                        oSeguimientoEvaluacion.id_plan = oPlan.id_plan
                        oSeguimientoEvaluacion.id_area = id_area
                        oSeguimientoEvaluacion.id_estado = id_estado
                        id_seguimiento = iPlanAnual.InsertarSeguimientoEvaluacionPlan(oSeguimientoEvaluacion)
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
