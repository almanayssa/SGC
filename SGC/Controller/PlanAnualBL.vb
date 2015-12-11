Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Class BusinessController

#Region "Select"

        Public Function ListarPlanes(ByRef oPlanFiltro As PlanAnualBE) As List(Of PlanAnualBE)
            Try
                Dim iPlan As IPlanAnual
                Dim oListadoPlan As List(Of PlanAnualBE) = Nothing

                iPlan = New PlanAnualDL
                oListadoPlan = iPlan.ListarPlanes(oPlanFiltro)

                Return oListadoPlan

            Catch ex As Exception
                Return Nothing
            End Try
        End Function


        Public Function ObtenerPlan(ByVal id_plan As String) As PlanAnualBE
            Try
                Dim iPlan As IPlanAnual
                Dim oPlanAnual As PlanAnualBE = Nothing

                iPlan = New PlanAnualDL
                oPlanAnual = iPlan.ObtenerPlan(id_plan)

                Return oPlanAnual

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarPlanAnual(ByRef oPlan As PlanAnualBE) As Integer
            Try
                Dim id_plan As Integer

                Dim iPlan As IPlanAnual
                iPlan = New PlanAnualDL

                id_plan = iPlan.InsertarPlanAnual(oPlan)

                oPlan.id_plan = id_plan

                Return oPlan.id_plan

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Update"

        Public Function ActualizarPlanAnual(ByRef oPlan As PlanAnualBE) As Integer
            Try
                Dim affectedRows As Integer

                Dim iPlan As IPlanAnual
                iPlan = New PlanAnualDL


                affectedRows = iPlan.ActualizarPlanAnual(oPlan)


                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace