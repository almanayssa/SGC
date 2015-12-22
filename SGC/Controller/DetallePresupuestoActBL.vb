Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Class BusinessController

#Region "Select"

        Public Function ObtenerRecursosPersonalAct(ByVal id_actividad As Integer?) As List(Of DetallePresupuestoActBE)
            Try
                Dim iDetalle As IDetallePresupuestoAct
                Dim oListadoDetalle As List(Of DetallePresupuestoActBE) = Nothing

                iDetalle = New DetallePresupuestoActDL
                oListadoDetalle = iDetalle.ObtenerRecursosPersonalAct(id_actividad)

                Return oListadoDetalle

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarDetallePresupuestoAct(ByVal id_presupuesto As Integer?) As List(Of DetallePresupuestoActBE)
            Try
                Dim iDetalle As IDetallePresupuestoAct
                Dim oListadoDetalle As List(Of DetallePresupuestoActBE) = Nothing

                iDetalle = New DetallePresupuestoActDL
                oListadoDetalle = iDetalle.ListarDetallePresupuestoAct(id_presupuesto)

                Return oListadoDetalle

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

