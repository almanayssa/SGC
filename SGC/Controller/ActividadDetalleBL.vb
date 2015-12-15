Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarDetallesXActividad(ByVal id_actividad As Integer) As List(Of ActividadDetalleBE)
            Try
                Dim iActividadDetalle As IActividadDetalle
                Dim oListadoActividadDetalle As List(Of ActividadDetalleBE) = Nothing

                iActividadDetalle = New ActividadDetalleDL
                oListadoActividadDetalle = iActividadDetalle.ListarDetallesXActividad(id_actividad)

                Return oListadoActividadDetalle

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

