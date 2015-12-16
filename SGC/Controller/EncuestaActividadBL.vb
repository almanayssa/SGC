Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ObtenerEncuesta(ByVal id_actividad As Integer) As EncuestaActividadBE
            Try
                Dim iEncuestaActividad As IEncuestaActividad
                Dim iEncuestaDetalle As IEncuestaDetalle
                Dim oEncuestaActividad As EncuestaActividadBE = Nothing

                iEncuestaActividad = New EncuestaActividadDL
                iEncuestaDetalle = New EncuestaDetalleDL

                oEncuestaActividad = iEncuestaActividad.ObtenerEncuesta(id_actividad)
                oEncuestaActividad.ListadoEncuestaDetalle = iEncuestaDetalle.ListarEncuestaDetalle(oEncuestaActividad.id_encuesta)

                Return oEncuestaActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarEncuesta(ByRef oEncuestaActividad As EncuestaActividadBE) As Integer
            Try

                Dim iEncuestaActividad As IEncuestaActividad
                iEncuestaActividad = New EncuestaActividadDL

                Dim id_encuesta As Integer
                id_encuesta = iEncuestaActividad.InsertarEncuesta(oEncuestaActividad)

                oEncuestaActividad.id_encuesta = id_encuesta

                Return oEncuestaActividad.id_encuesta

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class

End Namespace

