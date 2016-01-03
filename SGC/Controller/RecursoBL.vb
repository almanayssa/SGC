Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarRecursos(ByVal descripcion As String) As List(Of RecursoBE)
            Try
                Dim iRecurso As IRecurso
                Dim oListadoRecursos As List(Of RecursoBE) = Nothing

                iRecurso = New RecursoDL
                oListadoRecursos = iRecurso.ListarRecursos(descripcion)

                Return oListadoRecursos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarRecursosXActividad(ByVal id_actividad As Integer) As List(Of RecursoBE)
            Try
                Dim iRecurso As IRecurso
                Dim oListadoRecursos As List(Of RecursoBE) = Nothing

                iRecurso = New RecursoDL
                oListadoRecursos = iRecurso.ListarRecursosXActividad(id_actividad)

                Return oListadoRecursos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerRecursosDemanda(ByVal id_comite As String, ByVal id_tipo As String) As List(Of RecursoBE)
            Try
                Dim iRecurso As IRecurso
                Dim oListadoRecursos As List(Of RecursoBE) = Nothing

                iRecurso = New RecursoDL
                oListadoRecursos = iRecurso.ObtenerRecursosDemanda(id_comite, id_tipo)

                Return oListadoRecursos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarDemandaRecursos(ByVal fecIni As Date, ByVal fecFin As Date, ByVal id_comite As String, ByVal id_tipo As String) As List(Of RecursoBE)
            Try
                Dim iRecurso As IRecurso
                Dim oListadoRecursos As List(Of RecursoBE) = Nothing

                iRecurso = New RecursoDL
                oListadoRecursos = iRecurso.ListarDemandaRecursos(fecIni, fecFin, id_comite, id_tipo)

                Return oListadoRecursos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
