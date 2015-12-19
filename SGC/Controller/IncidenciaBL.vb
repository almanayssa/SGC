Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ObtenerIncidencia(ByVal id_actividad As Integer) As IncidenciaBE
            Try
                Dim iIncidencia As IIncidencia
                Dim oIncidencia As IncidenciaBE = Nothing

                iIncidencia = New IncidenciaDL

                oIncidencia = iIncidencia.ObtenerIncidencia(id_actividad)

                Return oIncidencia

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarIncidencia(ByRef oIncidencia As IncidenciaBE) As Integer
            Try

                Dim iIncidencia As IIncidencia
                iIncidencia = New IncidenciaDL

                Dim id_incidencia As Integer
                id_incidencia = iIncidencia.InsertarIncidencia(oIncidencia)

                oIncidencia.id_incidencia = id_incidencia

                Return oIncidencia.id_incidencia

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class

End Namespace
