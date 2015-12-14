Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarActividadesRecurrentes(ByVal id_comite As String, ByVal fec_inicio As DateTime, ByVal fec_fin As DateTime) As List(Of ActividadRecurrenteBE)
            Try
                Dim iActividadRecurrente As IActividadRecurrente
                Dim oListadoActividadesRecurrentes As List(Of ActividadRecurrenteBE) = Nothing

                iActividadRecurrente = New ActividadRecurrenteDL
                oListadoActividadesRecurrentes = iActividadRecurrente.ListarActividadesRecurrentes(id_comite, fec_inicio, fec_fin)

                Return oListadoActividadesRecurrentes

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarActividadRecurrente(ByRef oActividadRecurrente As ActividadRecurrenteBE) As Integer
            Try
                Dim iActividadRecurrente As IActividadRecurrente
                iActividadRecurrente = New ActividadRecurrenteDL

                Dim iActividad As IActividad
                iActividad = New ActividadDL

                Dim id_actividad_recurrente As Integer
                id_actividad_recurrente = iActividadRecurrente.InsertarActividadRecurrente(oActividadRecurrente)
                oActividadRecurrente.id_actividad_recurrente = id_actividad_recurrente

                oActividadRecurrente.ListadoActividades = New List(Of ActividadBE)

                Select Case oActividadRecurrente.tipo
                    Case "D"
                        oActividadRecurrente.ListadoActividades = ObtenerActividadesFrecuenciaDiaria(oActividadRecurrente)
                    Case "S"
                        oActividadRecurrente.ListadoActividades = ObtenerActividadesFrecuenciaSemanal(oActividadRecurrente)
                    Case "M"
                        oActividadRecurrente.ListadoActividades = ObtenerActividadesFrecuenciaMensual(oActividadRecurrente)
                End Select

                For Each oActividad As ActividadBE In oActividadRecurrente.ListadoActividades
                    oActividad.id_actividad_recurrente = oActividadRecurrente.id_actividad_recurrente
                    oActividad.id_actividad = iActividad.InsertarActividad(oActividad)
                Next

                Return oActividadRecurrente.id_actividad_recurrente

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Private Function ObtenerActividadesFrecuenciaDiaria(ByRef oActividadRecurrente As ActividadRecurrenteBE) As List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim tempFecha As DateTime

            tempFecha = oActividadRecurrente.fecha_ini

            While DateDiff(DateInterval.Day, tempFecha, Convert.ToDateTime(oActividadRecurrente.fecha_fin)) >= 0
                oActividad = New ActividadBE

                oActividad.fec_ini = tempFecha
                oActividad.fec_fin = tempFecha
                oActividad.hora_ini = oActividadRecurrente.hora_ini
                oActividad.hora_fin = oActividadRecurrente.hora_fin
                oActividad.monto_pago = oActividadRecurrente.monto_pago
                oActividad.id_estado = "EST001"
                oActividad.id_cattipo_act = oActividadRecurrente.id_cattipo_act
                oActividad.id_comite = oActividadRecurrente.id_comite
                oActividad.id_tipo_act = oActividadRecurrente.id_tipo_act
                oActividad.descripcion = oActividadRecurrente.descripcion
                oActividad.nombre = oActividadRecurrente.nombre
                oActividad.id_actividad_recurrente = oActividadRecurrente.id_actividad_recurrente
                oActividad.flg_plan_anual = False
                oActividad.flg_web = True
                oActividad.tipo_inscripcion = "A"
                oActividad.vacantes = oActividadRecurrente.vacantes

                oActividadRecurrente.ListadoActividades.Add(oActividad)

                tempFecha = tempFecha.AddDays(oActividadRecurrente.num_rep)

            End While

            Return oActividadRecurrente.ListadoActividades

        End Function

        Public Function ObtenerActividadesFrecuenciaSemanal(ByRef oActividadRecurrente As ActividadRecurrenteBE) As List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim tempFecha As DateTime

            tempFecha = oActividadRecurrente.fecha_ini

            While DateDiff(DateInterval.Day, tempFecha, Convert.ToDateTime(oActividadRecurrente.fecha_fin)) >= 0
                oActividad = New ActividadBE
                oActividad.hora_ini = oActividadRecurrente.hora_ini
                oActividad.hora_fin = oActividadRecurrente.hora_fin
                oActividad.monto_pago = oActividadRecurrente.monto_pago
                oActividad.id_estado = "EST001"
                oActividad.id_cattipo_act = oActividadRecurrente.id_cattipo_act
                oActividad.id_comite = oActividadRecurrente.id_comite
                oActividad.id_tipo_act = oActividadRecurrente.id_tipo_act
                oActividad.descripcion = oActividadRecurrente.descripcion
                oActividad.nombre = oActividadRecurrente.nombre
                oActividad.id_actividad_recurrente = oActividadRecurrente.id_actividad_recurrente
                oActividad.flg_plan_anual = False
                oActividad.flg_web = True
                oActividad.tipo_inscripcion = "A"
                oActividad.vacantes = oActividadRecurrente.vacantes

                Select Case tempFecha.DayOfWeek
                    Case DayOfWeek.Sunday
                        If oActividadRecurrente.chk_dom = True Then
                            oActividad.fec_ini = tempFecha
                            oActividad.fec_fin = tempFecha
                            oActividadRecurrente.ListadoActividades.Add(oActividad)
                        End If
                    Case DayOfWeek.Monday
                        If oActividadRecurrente.chk_lun = True Then
                            oActividad.fec_ini = tempFecha
                            oActividad.fec_fin = tempFecha
                            oActividadRecurrente.ListadoActividades.Add(oActividad)
                        End If
                    Case DayOfWeek.Tuesday
                        If oActividadRecurrente.chk_mar = True Then
                            oActividad.fec_ini = tempFecha
                            oActividad.fec_fin = tempFecha
                            oActividadRecurrente.ListadoActividades.Add(oActividad)
                        End If
                    Case DayOfWeek.Wednesday
                        If oActividadRecurrente.chk_mie = True Then
                            oActividad.fec_ini = tempFecha
                            oActividad.fec_fin = tempFecha
                            oActividadRecurrente.ListadoActividades.Add(oActividad)
                        End If
                    Case DayOfWeek.Thursday
                        If oActividadRecurrente.chk_jue = True Then
                            oActividad.fec_ini = tempFecha
                            oActividad.fec_fin = tempFecha
                            oActividadRecurrente.ListadoActividades.Add(oActividad)
                        End If
                    Case DayOfWeek.Friday
                        If oActividadRecurrente.chk_vie = True Then
                            oActividad.fec_ini = tempFecha
                            oActividad.fec_fin = tempFecha
                            oActividadRecurrente.ListadoActividades.Add(oActividad)
                        End If
                    Case DayOfWeek.Saturday
                        If oActividadRecurrente.chk_sab = True Then
                            oActividad.fec_ini = tempFecha
                            oActividad.fec_fin = tempFecha
                            oActividadRecurrente.ListadoActividades.Add(oActividad)
                        End If
                End Select

                If tempFecha.DayOfWeek = DayOfWeek.Sunday Then
                    If oActividadRecurrente.num_rep = 1 Then
                        tempFecha = tempFecha.AddDays(1)
                    Else
                        tempFecha = tempFecha.AddDays((7 * (oActividadRecurrente.num_rep - 1)) + 1)
                    End If
                Else
                    tempFecha = tempFecha.AddDays(1)
                End If

            End While

            Return oActividadRecurrente.ListadoActividades

        End Function

        Public Function ObtenerActividadesFrecuenciaMensual(ByRef oActividadRecurrente As ActividadRecurrenteBE) As List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim fec_ini, tempFecha As DateTime
            Dim diasDelMes As Integer

            fec_ini = oActividadRecurrente.fecha_ini
            tempFecha = New DateTime(fec_ini.Year, fec_ini.Month, oActividadRecurrente.dia_mes)

            While DateDiff(DateInterval.Day, tempFecha, Convert.ToDateTime(oActividadRecurrente.fecha_fin)) >= 0
                oActividad = New ActividadBE
                oActividad.hora_ini = oActividadRecurrente.hora_ini
                oActividad.hora_fin = oActividadRecurrente.hora_fin
                oActividad.monto_pago = oActividadRecurrente.monto_pago
                oActividad.id_estado = "EST001"
                oActividad.id_cattipo_act = oActividadRecurrente.id_cattipo_act
                oActividad.id_comite = oActividadRecurrente.id_comite
                oActividad.id_tipo_act = oActividadRecurrente.id_tipo_act
                oActividad.descripcion = oActividadRecurrente.descripcion
                oActividad.nombre = oActividadRecurrente.nombre
                oActividad.id_actividad_recurrente = oActividadRecurrente.id_actividad_recurrente
                oActividad.flg_plan_anual = False
                oActividad.flg_web = True
                oActividad.tipo_inscripcion = "A"
                oActividad.vacantes = oActividadRecurrente.vacantes

                If DateDiff(DateInterval.Day, fec_ini, tempFecha) >= 0 Then
                    oActividad.fec_ini = tempFecha
                    oActividad.fec_fin = tempFecha
                    oActividadRecurrente.ListadoActividades.Add(oActividad)
                End If

                tempFecha = tempFecha.AddMonths(oActividadRecurrente.num_rep)

                diasDelMes = DateTime.DaysInMonth(tempFecha.Year, tempFecha.Month)

            End While

            Return oActividadRecurrente.ListadoActividades

        End Function

#End Region

    End Class

End Namespace

