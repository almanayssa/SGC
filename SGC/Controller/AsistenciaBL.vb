Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarAsistencia(ByVal id_actividad As Integer) As List(Of AsistenciaBE)
            Try
                Dim iAsistencia As IAsistencia
                Dim oListadoAsistencia As List(Of AsistenciaBE) = Nothing

                iAsistencia = New AsistenciaDL
                oListadoAsistencia = iAsistencia.ListarAsistencia(id_actividad)

                Return oListadoAsistencia

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarAsistencia(ByRef oAsistencia As AsistenciaBE) As Integer
            Try

                Dim iAsistencia As IAsistencia
                iAsistencia = New AsistenciaDL

                Dim id_asistencia As Integer
                id_asistencia = iAsistencia.InsertarAsistencia(oAsistencia)

                oAsistencia.id_asistencia = id_asistencia

                Return oAsistencia.id_asistencia

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class

End Namespace

