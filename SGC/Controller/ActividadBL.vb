Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function CargarActividadCabecera(ByVal id_actividad As Integer) As ActividadBE
            Try
                Dim iActividad As IActividad
                Dim oActividad As ActividadBE = Nothing

                iActividad = New ActividadDL
                oActividad = iActividad.CargarActividadCabecera(id_actividad)

                Return oActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividades(ByVal id_comite As String, ByVal fec_inicio As DateTime, ByVal fec_fin As DateTime) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividades(id_comite, fec_inicio, fec_fin)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesBusqueda(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesBusqueda(id_comite, nombre)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesPlan(ByVal id_comite As String, ByVal id_plan As Integer?) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesPlan(id_comite, id_plan)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesPendientesPGC(ByVal id_comite As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesPendientesPGC(id_comite)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesAprobadasPGC(ByVal id_comite As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesAprobadasPGC(id_comite)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesRechazadasPGC(ByVal id_comite As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesRechazadasPGC(id_comite)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesCD(ByVal id_comite As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesCD(id_comite)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesGG(ByVal id_comite As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesGG(id_comite)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function
#End Region

#Region "Insert"

        Public Function InsertarActividad(ByRef oActividad As ActividadBE) As Integer
            Try
                Dim iActividad As IActividad
                iActividad = New ActividadDL

                Dim id_actividad As Integer
                id_actividad = iActividad.InsertarActividad(oActividad)

                If oActividad.ListaTipoPersonal IsNot Nothing Then
                    For Each oTipoPersonal As TipoPersonalBE In oActividad.ListaTipoPersonal
                        oTipoPersonal.id_actividad = id_actividad
                        iActividad.InsertarTipoPersonalXActividad(oTipoPersonal)
                    Next
                End If

                If oActividad.ListaRecursos IsNot Nothing Then
                    For Each oRecurso As RecursoBE In oActividad.ListaRecursos
                        oRecurso.id_actividad = id_actividad
                        iActividad.InsertarRecursoXActividad(oRecurso)
                    Next
                End If

                If oActividad.ListaRestricciones IsNot Nothing Then
                    For Each oRestriccion As RestriccionesBE In oActividad.ListaRestricciones
                        oRestriccion.id_actividad = id_actividad
                        iActividad.InsertarRestriccionXActividad(oRestriccion)
                    Next
                End If

                oActividad.id_actividad = id_actividad

                Return oActividad.id_actividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function InsertarActividadesPlanXML(ByRef oPlan As PlanAnualBE) As Boolean
            Try

                Dim iActividad As IActividad
                iActividad = New ActividadDL

                Return iActividad.InsertarActividadesPlanXML(oPlan)

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "Update"

        Public Function ActualizarActividad(ByRef oActividad As ActividadBE) As Integer
            Try
                Dim affectedRows As Integer

                Dim iActividad As IActividad
                iActividad = New ActividadDL

                affectedRows += iActividad.ActualizarActividad(oActividad)
                affectedRows += iActividad.BorrarTipoPersonalXActividad(oActividad.id_actividad)
                affectedRows += iActividad.BorrarRecursosXActividad(oActividad.id_actividad)
                affectedRows += iActividad.BorrarRestriccionesXActividad(oActividad.id_actividad)

                If oActividad.ListaTipoPersonal IsNot Nothing Then
                    For Each oTipoPersonal As TipoPersonalBE In oActividad.ListaTipoPersonal
                        oTipoPersonal.id_actividad = oActividad.id_actividad
                        affectedRows += iActividad.InsertarTipoPersonalXActividad(oTipoPersonal)
                    Next
                End If

                If oActividad.ListaRecursos IsNot Nothing Then
                    For Each oRecurso As RecursoBE In oActividad.ListaRecursos
                        oRecurso.id_actividad = oActividad.id_actividad
                        affectedRows += iActividad.InsertarRecursoXActividad(oRecurso)
                    Next
                End If

                If oActividad.ListaRestricciones IsNot Nothing Then
                    For Each oRestriccion As RestriccionesBE In oActividad.ListaRestricciones
                        oRestriccion.id_actividad = oActividad.id_actividad
                        affectedRows += iActividad.InsertarRestriccionXActividad(oRestriccion)
                    Next
                End If

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ActualizarActividadEstado(ByRef ListadoActividad As List(Of ActividadBE), ByVal id_estado As String) As Integer
            Try
                Dim affectedRows As Integer

                Dim iActividad As IActividad
                iActividad = New ActividadDL

                If ListadoActividad IsNot Nothing Then
                    For Each oActividad As ActividadBE In ListadoActividad
                        oActividad.id_estado = id_estado
                        affectedRows += iActividad.ActualizarActividadEstado(oActividad)
                    Next
                End If

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarActividad(ByRef id_actividad As Integer) As Integer
            Try
                Dim iActividad As IActividad
                iActividad = New ActividadDL

                Dim affectedRows As Integer
                affectedRows = iActividad.BorrarActividad(id_actividad)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


