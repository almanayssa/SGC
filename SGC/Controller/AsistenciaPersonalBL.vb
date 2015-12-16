Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarActividades(ByVal id_actividad As Integer) As List(Of AsistenciaPersonalBE)
            Try
                Dim iAsistenciaPersonal As IAsistenciaPersonal
                Dim oListadoAsistenciaPersonal As List(Of AsistenciaPersonalBE) = Nothing

                iAsistenciaPersonal = New AsistenciaPersonalDL
                oListadoAsistenciaPersonal = iAsistenciaPersonal.ListarAsistenciaPersonal(id_actividad)

                Return oListadoAsistenciaPersonal

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarAsistenciaPersonal(ByRef oAsistenciaPersonal As AsistenciaPersonalBE) As Integer
            Try

                Dim iAsistenciaPersonal As IAsistenciaPersonal
                iAsistenciaPersonal = New AsistenciaPersonalDL

                Dim id_asistencia As Integer
                id_asistencia = iAsistenciaPersonal.InsertarAsistenciaPersonal(oAsistenciaPersonal)

                oAsistenciaPersonal.id_asistencia = id_asistencia

                Return oAsistenciaPersonal.id_asistencia

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class

End Namespace

