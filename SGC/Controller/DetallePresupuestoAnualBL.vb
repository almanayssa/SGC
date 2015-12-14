Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Class BusinessController

#Region "Select"

        Public Function ObtenerRecursosPersonalAnual(ByVal id_plan As Integer?) As List(Of DetallePresupuestoAnualBE)
            Try
                Dim idetalle As IDetallePresupuestoAnual
                Dim oListadoDetalle As List(Of DetallePresupuestoAnualBE) = Nothing

                idetalle = New DetallePresupuestoAnualDL
                oListadoDetalle = idetalle.ObtenerRecursosPersonalAnual(id_plan)

                Return oListadoDetalle

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarDetallePresupuestoAnual(ByVal id_presupuesto As Integer?) As List(Of DetallePresupuestoAnualBE)
            Try
                Dim idetalle As IDetallePresupuestoAnual
                Dim oListadoDetalle As List(Of DetallePresupuestoAnualBE) = Nothing

                idetalle = New DetallePresupuestoAnualDL
                oListadoDetalle = idetalle.ListarDetallePresupuestoAnual(id_presupuesto)

                Return oListadoDetalle

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarDetallePresupuestoAnual(ByRef oPresupuesto As PresupuestoAnualBE) As Integer
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