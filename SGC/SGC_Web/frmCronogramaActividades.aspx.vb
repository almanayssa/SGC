Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmCronogramaActividades
    Inherits System.Web.UI.Page

    'Dim bc As New BusinessController

    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    If Not Page.IsPostBack Then
    '        methodToday()
    '        lblTitleTabCalendar.Text = "Actividades de Hoy"
    '        'lbtnThisMonth.Text = "-" & DateTime.Now.ToString("MMMMMMMM")
    '        'lbtnThisMonth.ToolTip = "Filtrado por" & " " & DateTime.Now.ToString("MMMMMMMM")
    '    End If
    'End Sub

    'Private Sub calActividades_SelectionChanged(sender As Object, e As System.EventArgs) Handles calActividades.SelectionChanged
    '    lblTitleTabCalendar.Text = "Actividades en " & calActividades.SelectedDate.ToString("dd/MM/yyyy")
    '    methodAnyday()
    'End Sub


    'Private Function ListarActividades(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
    '    Dim oListadoActividadesNoRecurrentes As List(Of ActividadBE)
    '    Dim oListadoActividades As New List(Of ActividadBE)

    '    'Variables para actividades recurrentes
    '    Dim oActividadRecurrente As New ActividadRecurrenteBE
    '    Dim oListadoActividadesRecurrentes As List(Of ActividadBE)

    '    'Actividades No Recurrentes
    '    oListadoActividadesNoRecurrentes = bc.ListarActividadesNoRecurrentes(diaCalendario, diaInicio, diaFin)

    '    'Actividades Recurrentes
    '    oListadoActividadesRecurrentes = bc.ListarActividadesRecurrentes(diaCalendario, diaInicio, diaFin)

    '    For Each oActividad As ActividadBE In oListadoActividadesNoRecurrentes
    '        oListadoActividades.Add(oActividad)
    '    Next

    '    For Each oActividadConRecurrencia As ActividadBE In oListadoActividadesRecurrentes
    '        oActividadRecurrente = bc.ObtenerActividadRecurrente(oActividadConRecurrencia.id_actividad_recurrente)
    '        oActividadConRecurrencia.ActividadRecurrente = oActividadRecurrente
    '    Next

    '    checkListadoActividadesRecurrentes(oListadoActividadesRecurrentes)

    '    Dim newListadoActividadesRecurrentes As List(Of ActividadBE) = Sesiones.TempListadoActividades

    '    For Each newActividadRecurrente As ActividadBE In newListadoActividadesRecurrentes
    '        oListadoActividades.Add(newActividadRecurrente)
    '    Next

    '    If oListadoActividades.Count = 0 Then
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
    '        lblNoActividades.Text = "Muy pronto, con más actividades. Muchas gracias!"
    '    End If

    '    Return oListadoActividades

    '    'Sesiones.ListadoActividadesRemover()
    '    'Sesiones.ListadoActividades = oListadoActividades

    '    'rptCalendarioActividades.DataSource = oListadoActividades
    '    'rptCalendarioActividades.DataBind()

    'End Function

    'Private Sub checkListadoActividadesRecurrentes(ByVal oListadoActividad As List(Of ActividadBE))
    '    Dim tempEventCollection As New List(Of ActividadBE)
    '    Dim dias As Integer = 0

    '    For Each oActividad As ActividadBE In oListadoActividad
    '        Dim oListadoActividadRecurrente As New List(Of ActividadBE)

    '        If DateDiff(DateInterval.Day, CDate(oActividad.fec_ini), CDate(oActividad.fec_fin)) > 0 Then
    '            dias = DateDiff(DateInterval.Day, CDate(oActividad.fec_ini), CDate(oActividad.fec_fin))
    '        End If

    '        Select Case oActividad.ActividadRecurrente.tipo
    '            'Recurrencia Diaria
    '            Case "D"
    '                oListadoActividadRecurrente = Helper.ObtenerFrecuenciaDiaria(oActividad.ActividadRecurrente.num_rep, Today, oActividad.fec_ini, oActividad.ActividadRecurrente.fecha_fin, oListadoActividadRecurrente)

    '                If oListadoActividadRecurrente.Count > 0 Then
    '                    Exit Select
    '                Else
    '                    'Rango máximo de 2 años
    '                    For i As Integer = 1 To 23
    '                        oListadoActividadRecurrente = Helper.ObtenerFrecuenciaDiaria(oActividad.ActividadRecurrente.num_rep, Today.AddMonths(i), oActividad.fec_ini, oActividad.ActividadRecurrente.fecha_fin, oListadoActividadRecurrente)

    '                        If oListadoActividadRecurrente.Count > 0 Then
    '                            Exit For
    '                        End If
    '                    Next
    '                End If
    '            Case "S" 'Recurrencia Semanal
    '                oListadoActividadRecurrente = Helper.ObtenerFrecuenciaSemanal(oActividad.ActividadRecurrente.num_rep, oActividad.ActividadRecurrente.chk_dom, oActividad.ActividadRecurrente.chk_lun, oActividad.ActividadRecurrente.chk_mar, oActividad.ActividadRecurrente.chk_mie, oActividad.ActividadRecurrente.chk_jue, oActividad.ActividadRecurrente.chk_vie, oActividad.ActividadRecurrente.chk_sab, Today, oActividad.fec_ini, oActividad.ActividadRecurrente.fecha_fin, oListadoActividadRecurrente)

    '                If oListadoActividadRecurrente.Count > 0 Then
    '                    Exit Select
    '                Else
    '                    'Rango máximo de 2 años
    '                    For i As Integer = 1 To 23
    '                        oListadoActividadRecurrente = Helper.ObtenerFrecuenciaSemanal(oActividad.ActividadRecurrente.num_rep, oActividad.ActividadRecurrente.chk_dom, oActividad.ActividadRecurrente.chk_lun, oActividad.ActividadRecurrente.chk_mar, oActividad.ActividadRecurrente.chk_mie, oActividad.ActividadRecurrente.chk_jue, oActividad.ActividadRecurrente.chk_vie, oActividad.ActividadRecurrente.chk_sab, Today.AddMonths(i), oActividad.fec_ini, oActividad.ActividadRecurrente.fecha_fin, oListadoActividadRecurrente)

    '                        If oListadoActividadRecurrente.Count > 0 Then
    '                            Exit For
    '                        End If
    '                    Next
    '                End If
    '            Case "M" 'Recurrencia Mensual

    '                'Si el dia del mes es nulo busca por dia especifico
    '                If oActividad.ActividadRecurrente.dia_mes Is Nothing Then
    '                    oListadoActividadRecurrente = Helper.ObtenerFrecuenciaMensual(oActividad.ActividadRecurrente.num_rep, oActividad.ActividadRecurrente.ordinal, oActividad.ActividadRecurrente.dia_semana, Today, oActividad.fec_ini, oActividad.ActividadRecurrente.fecha_fin, oListadoActividadRecurrente)
    '                Else
    '                    oListadoActividadRecurrente = Helper.ObtenerFrecuenciaMensual(oActividad.ActividadRecurrente.num_rep, oActividad.ActividadRecurrente.dia_mes, Today, oActividad.fec_ini, oActividad.ActividadRecurrente.fecha_fin, oListadoActividadRecurrente)
    '                End If

    '                If oListadoActividadRecurrente.Count > 0 Then
    '                    Exit Select
    '                Else
    '                    'Rango máximo de 2 años
    '                    For i As Integer = 1 To 23

    '                        'Si el dia del mes es nulo busca por dia especifico
    '                        If oActividad.ActividadRecurrente.dia_mes Is Nothing Then
    '                            oListadoActividadRecurrente = Helper.ObtenerFrecuenciaMensual(oActividad.ActividadRecurrente.num_rep, oActividad.ActividadRecurrente.ordinal, oActividad.ActividadRecurrente.dia_semana, Today.AddMonths(i), oActividad.fec_ini, oActividad.ActividadRecurrente.fecha_fin, oListadoActividadRecurrente)
    '                        Else
    '                            oListadoActividadRecurrente = Helper.ObtenerFrecuenciaMensual(oActividad.ActividadRecurrente.num_rep, oActividad.ActividadRecurrente.dia_mes, Today.AddMonths(i), oActividad.fec_ini, oActividad.ActividadRecurrente.fecha_fin, oListadoActividadRecurrente)
    '                        End If

    '                        If oListadoActividadRecurrente.Count > 0 Then
    '                            Exit For
    '                        End If
    '                    Next
    '                End If
    '        End Select

    '        If oListadoActividadRecurrente.Count > 0 Then
    '            Dim startDate As Date = Nothing

    '            'Iterates the collection and add the first ocurrence to a temp collection
    '            For Each oRecurrentEvent As ActividadBE In oListadoActividadRecurrente
    '                startDate = CDate(oRecurrentEvent.fec_ini)
    '                oRecurrentEvent = oActividad
    '                oRecurrentEvent.fec_ini = startDate.Add(oActividad.hora_ini)
    '                If dias > 0 Then
    '                    oRecurrentEvent.fec_fin = startDate.AddDays(dias).Add(oActividad.hora_fin)
    '                Else
    '                    oRecurrentEvent.fec_fin = startDate.Add(oActividad.hora_fin)
    '                End If
    '                tempEventCollection.Add(oRecurrentEvent)
    '                Exit For
    '            Next
    '        End If
    '    Next

    '    'oEventCollection = New ChamberEventEntityCollection

    '    'If tempEventCollection.Count > 0 Then
    '    '    For Each tempEvent As ChamberEventEntity In tempEventCollection
    '    '        oEventCollection.Add(tempEvent)
    '    '    Next
    '    'End If

    '    Sesiones.TempListadoActividadesRemover()
    '    Sesiones.TempListadoActividades = tempEventCollection
    'End Sub

    'Private Sub rptCalendarioActividades_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptCalendarioActividades.ItemCommand
    '    If e.CommandName = "DetalleActividad" Then
    '        Dim id As Integer = CInt(e.CommandArgument)
    '        Response.Redirect("~\frmDetalleActividad.aspx?" & id, True)
    '    End If
    'End Sub

    'Private Sub lbtnToday_Click(sender As Object, e As System.EventArgs) Handles lbtnToday.Click
    '    lblTitleTabCalendar.Text = "Actividades de Hoy"
    '    calActividades.VisibleDate = calActividades.TodaysDate
    '    methodToday()
    'End Sub

    'Private Sub lbtnThisWeek_Click(sender As Object, e As System.EventArgs) Handles lbtnThisWeek.Click
    '    lblTitleTabCalendar.Text = "Actividades de Esta Semana"
    '    calActividades.VisibleDate = calActividades.TodaysDate
    '    methodThisWeek()
    'End Sub

    'Private Sub lbtnThisMonth_Click(sender As Object, e As System.EventArgs) Handles lbtnThisMonth.Click
    '    lblTitleTabCalendar.Text = "Actividades de Este Mes"
    '    calActividades.VisibleDate = calActividades.TodaysDate
    '    methodThisMonth()
    'End Sub

    'Protected Sub methodToday()
    '    calActividades.SelectedDate = Today
    '    hdnStartDate.Value = calActividades.SelectedDate
    '    hdnEndDate.Value = calActividades.SelectedDate

    '    Dim oEventCollection As List(Of ActividadBE) = ListarActividades(calActividades.SelectedDate, Nothing, Nothing)

    '    If oEventCollection.Count = 0 Then
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
    '        lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
    '    Else
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
    '    End If

    '    Sesiones.ListadoActividadesRemover()
    '    Sesiones.ListadoActividades = oEventCollection

    '    rptCalendarioActividades.DataSource = oEventCollection
    '    rptCalendarioActividades.DataBind()

    'End Sub

    'Protected Sub methodThisWeek()
    '    Dim weekStartDate, weekEndDate As Date

    '    weekStartDate = DateAdd("d", 0 - Now.DayOfWeek, Now)
    '    weekEndDate = DateAdd("d", 7 - Now.DayOfWeek, Now)

    '    hdnStartDate.Value = weekStartDate
    '    hdnEndDate.Value = weekEndDate

    '    Dim oEventCollection As List(Of ActividadBE) = ListarActividades(Nothing, weekStartDate, weekEndDate)

    '    If oEventCollection.Count = 0 Then
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
    '        lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
    '    Else
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
    '    End If

    '    Sesiones.ListadoActividadesRemover()
    '    Sesiones.ListadoActividades = oEventCollection

    '    rptCalendarioActividades.DataSource = oEventCollection
    '    rptCalendarioActividades.DataBind()
    'End Sub

    'Protected Sub methodThisMonth()

    '    Dim nMonth As String = Now.Month.ToString
    '    Dim nDay As String = Now.Day.ToString
    '    Dim nYear As String = Now.Year.ToString
    '    Dim nStartDay As String = 1

    '    Dim oStartDayMonth As Date = CDate(nYear & "/" & nMonth & "/" & nStartDay)

    '    Dim nEndDay As Integer = oStartDayMonth.AddMonths(1).AddDays(-1).Day
    '    Dim oEndDayMonth As Date = CDate(nYear & "/" & nMonth & "/" & nEndDay)

    '    hdnStartDate.Value = oStartDayMonth
    '    hdnEndDate.Value = oEndDayMonth

    '    Dim oEventCollection As List(Of ActividadBE) = ListarActividades(Nothing, oStartDayMonth, oEndDayMonth)

    '    If oEventCollection.Count = 0 Then
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
    '        lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
    '    Else
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
    '    End If

    '    Sesiones.ListadoActividadesRemover()
    '    Sesiones.ListadoActividades = oEventCollection

    '    rptCalendarioActividades.DataSource = oEventCollection
    '    rptCalendarioActividades.DataBind()
    'End Sub

    'Protected Sub methodAnyday()
    '    Dim calendarAnyday As String = calActividades.SelectedDate.ToString("MM/dd/yyyy")
    '    hdnStartDate.Value = calActividades.SelectedDate
    '    hdnEndDate.Value = calActividades.SelectedDate

    '    Dim oEventCollection As List(Of ActividadBE) = ListarActividades(calActividades.SelectedDate, Nothing, Nothing)

    '    If oEventCollection.Count = 0 Then
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
    '        lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
    '    Else
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
    '    End If

    '    Sesiones.ListadoActividadesRemover()
    '    Sesiones.ListadoActividades = oEventCollection

    '    rptCalendarioActividades.DataSource = oEventCollection
    '    rptCalendarioActividades.DataBind()
    'End Sub

    'Public Function pfun_OrdinalDate(ByVal dte_toformat As Date) As String
    '    Dim str As String = ""

    '    Select Case Day(dte_toformat)
    '        Case 1, 21, 31
    '            str = Day(dte_toformat) & "ero "
    '        Case 2, 22
    '            str = Day(dte_toformat) & "do "
    '        Case 3, 23
    '            str = Day(dte_toformat) & "ero "
    '        Case Else
    '            str = Day(dte_toformat) & "to "
    '    End Select

    '    Return str

    'End Function

    'Protected Sub calendarOtherYearMonth()
    '    Dim oStartDayMonth As Date
    '    Dim firstDate As Date

    '    calActividades.SelectedDate = calActividades.VisibleDate
    '    oStartDayMonth = calActividades.SelectedDate

    '    firstDate = calActividades.SelectedDate
    '    Dim oEndDayMonth As Date = firstDate.AddMonths(1).AddDays(-1)

    '    Dim oEventCollection As List(Of ActividadBE) = ListarActividades(Nothing, oStartDayMonth, oEndDayMonth)

    '    lblTitleTabCalendar.Text = "Todos los eventos en " & firstDate.ToString("MMMMMMMM") & " " & firstDate.Year

    '    If oEventCollection.Count = 0 Then
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
    '        lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
    '    Else
    '        tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
    '    End If

    '    Sesiones.ListadoActividadesRemover()
    '    Sesiones.ListadoActividades = oEventCollection

    '    rptCalendarioActividades.DataSource = oEventCollection
    '    rptCalendarioActividades.DataBind()
    'End Sub
End Class