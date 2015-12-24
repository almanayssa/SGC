Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmCronogramaActividades
    Inherits System.Web.UI.Page

    Dim bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            CargarActividadesHoy()
            lblTituloCalendario.Text = "Actividades de Hoy"
            'lbtnEsteMes.Text = "-" & DateTime.Now.ToString("MMMMMMMM")
            'lbtnEsteMes.ToolTip = "Filtrado por" & " " & DateTime.Now.ToString("MMMMMMMM")
        End If
    End Sub

    Private Sub calActividades_SelectionChanged(sender As Object, e As System.EventArgs) Handles calActividades.SelectionChanged
        lblTituloCalendario.Text = "Actividades en " & calActividades.SelectedDate.ToString("dd/MM/yyyy")
        CargarActividadesCualquierDia()
    End Sub


    Private Function ListarActividades(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
        Dim oListadoActividades As List(Of ActividadBE) = bc.ListarActividadesCalendario(diaCalendario, diaInicio, diaFin)

        If oListadoActividades.Count = 0 Then
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
            lblNoActividades.Text = "Muy pronto, con más actividades. Muchas gracias!"
        End If

        Return oListadoActividades

    End Function

    Private Sub rptCalendarioActividades_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles rptCalendarioActividades.ItemCommand
        If e.CommandName = "DetalleActividad" Then
            Dim oActividad As ActividadBE = bc.CargarActividadCabecera(CInt(e.CommandArgument))
            Sesiones.ActividadSeleccionadaRemover()
            Sesiones.ActividadSeleccionada = oActividad
            Response.Redirect("~\frmDetalleActividad.aspx", True)
        End If
    End Sub

    Private Sub lbtnHoy_Click(sender As Object, e As System.EventArgs) Handles lbtnHoy.Click
        lblTituloCalendario.Text = "Actividades de Hoy"
        calActividades.VisibleDate = calActividades.TodaysDate
        CargarActividadesHoy()
    End Sub

    Private Sub lbtnEstaSemana_Click(sender As Object, e As System.EventArgs) Handles lbtnEstaSemana.Click
        lblTituloCalendario.Text = "Actividades de Esta Semana"
        calActividades.VisibleDate = calActividades.TodaysDate
        CargarActividadesEstaSemana()
    End Sub

    Private Sub lbtnEsteMes_Click(sender As Object, e As System.EventArgs) Handles lbtnEsteMes.Click
        lblTituloCalendario.Text = "Actividades de Este Mes"
        calActividades.VisibleDate = calActividades.TodaysDate
        CargarActividadesEsteMes()
    End Sub

    Protected Sub CargarActividadesHoy()
        calActividades.SelectedDate = Today
        hdnFechaInicio.Value = calActividades.SelectedDate
        hdnFechaFin.Value = calActividades.SelectedDate

        Dim oListadoActividades As List(Of ActividadBE) = ListarActividades(calActividades.SelectedDate, Nothing, Nothing)

        If oListadoActividades.Count = 0 Then
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
            lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
        Else
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
        End If

        Sesiones.ListadoActividadesRemover()
        Sesiones.ListadoActividades = oListadoActividades

        rptCalendarioActividades.DataSource = oListadoActividades
        rptCalendarioActividades.DataBind()

    End Sub

    Protected Sub CargarActividadesEstaSemana()
        Dim fechaInicio, fechaFin As Date

        fechaInicio = DateAdd("d", 0 - Now.DayOfWeek, Now)
        fechaFin = DateAdd("d", 7 - Now.DayOfWeek, Now)

        hdnFechaInicio.Value = fechaInicio
        hdnFechaFin.Value = fechaFin

        Dim oListadoActividades As List(Of ActividadBE) = ListarActividades(Nothing, fechaInicio, fechaFin)

        If oListadoActividades.Count = 0 Then
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
            lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
        Else
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
        End If

        Sesiones.ListadoActividadesRemover()
        Sesiones.ListadoActividades = oListadoActividades

        rptCalendarioActividades.DataSource = oListadoActividades
        rptCalendarioActividades.DataBind()
    End Sub

    Protected Sub CargarActividadesEsteMes()

        Dim nMes As String = Now.Month.ToString
        Dim nDia As String = Now.Day.ToString
        Dim nAnio As String = Now.Year.ToString
        Dim nDiaInicio As String = 1

        Dim oDiaInicioMes As Date = CDate(nAnio & "/" & nMes & "/" & nDiaInicio)

        Dim nDiaFin As Integer = oDiaInicioMes.AddMonths(1).AddDays(-1).Day
        Dim oDiaFinMes As Date = CDate(nAnio & "/" & nMes & "/" & nDiaFin)

        hdnFechaInicio.Value = oDiaInicioMes
        hdnFechaFin.Value = oDiaFinMes

        Dim oListadoActividades As List(Of ActividadBE) = ListarActividades(Nothing, oDiaInicioMes, oDiaFinMes)

        If oListadoActividades.Count = 0 Then
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
            lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
        Else
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
        End If

        Sesiones.ListadoActividadesRemover()
        Sesiones.ListadoActividades = oListadoActividades

        rptCalendarioActividades.DataSource = oListadoActividades
        rptCalendarioActividades.DataBind()
    End Sub

    Protected Sub CargarActividadesCualquierDia()
        Dim dia As String = calActividades.SelectedDate.ToString("MM/dd/yyyy")
        hdnFechaInicio.Value = calActividades.SelectedDate
        hdnFechaFin.Value = calActividades.SelectedDate

        Dim oListadoActividades As List(Of ActividadBE) = ListarActividades(calActividades.SelectedDate, Nothing, Nothing)

        If oListadoActividades.Count = 0 Then
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
            lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
        Else
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
        End If

        Sesiones.ListadoActividadesRemover()
        Sesiones.ListadoActividades = oListadoActividades

        rptCalendarioActividades.DataSource = oListadoActividades
        rptCalendarioActividades.DataBind()
    End Sub

    Protected Sub CalendarioOtroAnioMes()
        Dim oDiaInicioMes As Date
        Dim primeraFecha As Date

        calActividades.SelectedDate = calActividades.VisibleDate
        oDiaInicioMes = calActividades.SelectedDate

        primeraFecha = calActividades.SelectedDate
        Dim oDiaFinMes As Date = primeraFecha.AddMonths(1).AddDays(-1)

        Dim oListadoActividades As List(Of ActividadBE) = ListarActividades(Nothing, oDiaInicioMes, oDiaFinMes)

        lblTituloCalendario.Text = "Todos los eventos en " & primeraFecha.ToString("MMMMMMMM") & " " & primeraFecha.Year

        If oListadoActividades.Count = 0 Then
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "block"
            lblNoActividades.Text = "No se encontraron actividades para este filtro. Muchas gracias!"
        Else
            tblMsgNoActividades.Style(HtmlTextWriterStyle.Display) = "none"
        End If

        Sesiones.ListadoActividadesRemover()
        Sesiones.ListadoActividades = oListadoActividades

        rptCalendarioActividades.DataSource = oListadoActividades
        rptCalendarioActividades.DataBind()
    End Sub

End Class