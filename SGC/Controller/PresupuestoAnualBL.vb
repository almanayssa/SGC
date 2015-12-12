Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Class BusinessController

#Region "Select"

        Public Function ObtenerPresupuestoAnual(ByVal id_plan As Integer?) As PresupuestoAnualBE
            Try
                Dim ipresupuestoAnual As IPresupuestoAnual
                Dim oPresupuestoAnual As PresupuestoAnualBE = Nothing

                ipresupuestoAnual = New PresupuestoAnualDL
                oPresupuestoAnual = ipresupuestoAnual.ObtenerPresupuestoAnual(id_plan)

                Return oPresupuestoAnual

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarPresupuestoAnual(ByRef oPresupuesto As PresupuestoAnualBE) As Integer
            Try
                Dim id_Presupuesto As Integer

                Dim iPresupuesto As IPresupuestoAnual
                iPresupuesto = New PresupuestoAnualDL

                id_Presupuesto = iPresupuesto.InsertarPresupuestoAnual(oPresupuesto)

                oPresupuesto.id_presupuesto_anual = id_Presupuesto

                Return oPresupuesto.id_presupuesto_anual

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace