Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Insert"

        Public Function InsertarActividadRecurrente(ByRef oActividadRecurrente As ActividadRecurrenteBE) As Integer
            Try
                Dim iActividadRecurrente As IActividadRecurrente
                iActividadRecurrente = New ActividadRecurrenteDL

                Dim id_actividad_recurrente As Integer
                id_actividad_recurrente = iActividadRecurrente.InsertarActividadRecurrente(oActividadRecurrente)
                oActividadRecurrente.id_actividad_recurrente = id_actividad_recurrente

                Return oActividadRecurrente.id_actividad_recurrente

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

