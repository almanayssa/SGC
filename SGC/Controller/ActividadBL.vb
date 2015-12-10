Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

        '#Region "Select"

        '        Public Function ObtenerActividad(ByVal id_actividad As Integer) As ActividadBE
        '            Try
        '                Dim iActividad As IActividad
        '                Dim oActividad As ActividadBE = Nothing

        '                iActividad = New ActividadDL
        '                oActividad = iActividad.ObtenerActividad(id_actividad)

        '                Return oActividad

        '            Catch ex As Exception
        '                Return Nothing
        '            End Try
        '        End Function

        '        Public Function CargarActividadCabecera(ByVal id_actividad As Integer) As ActividadBE
        '            Try
        '                Dim iActividad As IActividad
        '                Dim oActividad As ActividadBE = Nothing

        '                iActividad = New ActividadDL
        '                oActividad = iActividad.CargarActividadCabecera(id_actividad)

        '                Return oActividad

        '            Catch ex As Exception
        '                Return Nothing
        '            End Try
        '        End Function

        Public Function ListarActividades(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividades(id_comite, nombre)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        '        Public Function ListarActividadesAInscribir(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
        '            Try
        '                Dim iActividad As IActividad
        '                Dim oListadoActividades As List(Of ActividadBE) = Nothing

        '                iActividad = New ActividadDL
        '                oListadoActividades = iActividad.ListarActividadesAInscribir(id_comite, nombre)

        '                Return oListadoActividades

        '            Catch ex As Exception
        '                Return Nothing
        '            End Try
        '        End Function

        '        'RegistroPlanAnualActividad

        '        Public Function ListarActividadesPorComite_TipoActividad(ByVal comiteID As String, ByVal tipoActividadID As String) As List(Of ActividadBE)
        '            Try
        '                Dim iActividad As IActividad
        '                Dim oListadoActividades As List(Of ActividadBE) = Nothing

        '                iActividad = New ActividadDL
        '                oListadoActividades = iActividad.ListarActividadesPorComite_TipoActividad(comiteID, tipoActividadID)


        '                Return oListadoActividades

        '            Catch ex As Exception
        '                Return Nothing
        '            End Try
        '        End Function

        '        Public Function ListarActividadesNoRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
        '            Try
        '                Dim iActividad As IActividad
        '                Dim oListadoActividades As List(Of ActividadBE) = Nothing

        '                iActividad = New ActividadDL
        '                oListadoActividades = iActividad.ListarActividadesNoRecurrentes(diaCalendario, diaInicio, diaFin)

        '                Return oListadoActividades

        '            Catch ex As Exception
        '                Return Nothing
        '            End Try
        '        End Function

        '        Public Function ListarActividadesRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
        '            Try
        '                Dim iActividad As IActividad
        '                Dim oListadoActividades As List(Of ActividadBE) = Nothing

        '                iActividad = New ActividadDL
        '                oListadoActividades = iActividad.ListarActividadesRecurrentes(diaCalendario, diaInicio, diaFin)


        '                Return oListadoActividades

        '            Catch ex As Exception
        '                Return Nothing
        '            End Try
        '        End Function

        '        Public Function ListarActividadesPlan(ByVal id_plananual_comite As Integer) As List(Of ActividadBE)
        '            Try
        '                Dim iActividad As IActividad
        '                Dim oListadoActividades As List(Of ActividadBE) = Nothing

        '                iActividad = New ActividadDL
        '                oListadoActividades = iActividad.ListarActividadesPlan(id_plananual_comite)


        '                Return oListadoActividades

        '            Catch ex As Exception
        '                Return Nothing
        '            End Try
        '        End Function

        '        Public Function ListarActividadesEstado(ByVal id_comite As String, ByVal nombre As String, ByVal estado As String) As List(Of ActividadBE)
        '            Try
        '                Dim iActividad As IActividad
        '                Dim oListadoActividades As List(Of ActividadBE) = Nothing

        '                iActividad = New ActividadDL
        '                oListadoActividades = iActividad.ListarActividadesEstado(id_comite, nombre, estado)

        '                Return oListadoActividades

        '            Catch ex As Exception
        '                Return Nothing
        '            End Try
        '        End Function

        '#End Region

    End Class

End Namespace


