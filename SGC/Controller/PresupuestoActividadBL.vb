Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Class BusinessController

#Region "Select"

        Public Function ObtenerPresupuestoActividad(ByVal id_actividad As Integer?) As PresupuestoActividadBE
            Try
                Dim iPresupuestoActividad As IPresupuestoActividad
                Dim oPresupuestoActividad As PresupuestoActividadBE = Nothing

                iPresupuestoActividad = New PresupuestoActividadDL
                oPresupuestoActividad = iPresupuestoActividad.ObtenerPresupuestoActividad(id_actividad)

                Return oPresupuestoActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarPresupuestoActividad(ByRef oPresupuesto As PresupuestoActividadBE) As Integer
            Try
                Dim id_Presupuesto As Integer

                Dim iPresupuesto As IPresupuestoActividad
                iPresupuesto = New PresupuestoActividadDL

                id_Presupuesto = iPresupuesto.InsertarPresupuestoActividad(oPresupuesto)


                oPresupuesto.id_presupuesto_actividad = id_Presupuesto

                Dim iDetalle As IDetallePresupuestoAct
                iDetalle = New DetallePresupuestoActDL

                If oPresupuesto.ListadoDetallePresupuesto IsNot Nothing Then
                    For Each oDetalle As DetallePresupuestoActBE In oPresupuesto.ListadoDetallePresupuesto
                        oDetalle.id_presupuesto_actividad = id_Presupuesto
                        iDetalle.InsertarDetallePresupuestoAct(oDetalle)
                    Next
                End If

                Return oPresupuesto.id_presupuesto_actividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

