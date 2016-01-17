﻿Imports System.Collections
Imports System.Configuration
Imports System.Data
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports FusionCharts.Charts
Imports SGC.Controller
Imports SGC.Model.Entidades

Partial Class frmDashboard
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Page.IsPostBack Then
            CargarParticipantesComite()
            CargarParticipantesTipo()
            CargarActividadesComite()
            CargarActividadesTipo()
            CargarComiteSatisfaccionTotal()
            CargarPersonalMasSolicitado()
            CargarPersonasMasParticipativas()
            CargarTasaCrecimientoAnual()
        End If
    End Sub

    Private Sub CargarParticipantesComite()
        Dim participacion As New Chart()
        participacion.SetChartParameter(Chart.ChartParameter.chartId, "myChart")
        participacion.SetChartParameter(Chart.ChartParameter.chartType, "pie3d")
        participacion.SetChartParameter(Chart.ChartParameter.chartWidth, "460")
        participacion.SetChartParameter(Chart.ChartParameter.chartHeight, "212")

        Dim oComites As List(Of FactActividadSumBE)
        Dim str As New StringBuilder

        oComites = bc.ListarComitesParticipacion()

        str.Append("<chart caption='Cantidad de Participantes por Comité' showvalues='1' showLegend='1' animation='0' theme='fint'>")

        For Each oComite As FactActividadSumBE In oComites
            str.Append("<set label='").Append(oComite.nombre_comite).Append("' value='").Append(oComite.total_participantes).Append("' />")
        Next

        str.Append("</chart>")
        participacion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrParticipantesComite.Text = participacion.Render()
    End Sub

    Private Sub CargarParticipantesTipo()
        Dim participacion As New Chart()
        participacion.SetChartParameter(Chart.ChartParameter.chartId, "myChart2")
        participacion.SetChartParameter(Chart.ChartParameter.chartType, "pie3d")
        participacion.SetChartParameter(Chart.ChartParameter.chartWidth, "460")
        participacion.SetChartParameter(Chart.ChartParameter.chartHeight, "212")

        Dim oComites As List(Of FactActividadSumBE)
        Dim str As New StringBuilder

        oComites = bc.ListarTiposParticipacion()

        str.Append("<chart caption='Cantidad de Participantes por Tipo' showvalues='1' showLegend='1' animation='0' theme='fint'>")

        For Each oComite As FactActividadSumBE In oComites
            str.Append("<set label='").Append(oComite.nombre_tipo).Append("' value='").Append(oComite.total_participantes).Append("' />")
        Next

        str.Append("</chart>")
        participacion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrParticipantesTipo.Text = participacion.Render()
    End Sub

    Private Sub CargarComiteSatisfaccionTotal()

        Dim nivel_satisfaccion As Decimal
        Dim str As New StringBuilder

        nivel_satisfaccion = bc.ObtenerSatisfaccionTotal()

        Dim satisfaccion As New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart3")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='Satisfacción General' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='0' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(nivel_satisfaccion).Append("' rearextension='15' radius='40' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComiteSatisfaccion.Text = satisfaccion.Render()

    End Sub

    Private Sub CargarActividadesComite()
        Dim actividades As New Chart()
        actividades.SetChartParameter(Chart.ChartParameter.chartId, "myChart4")
        actividades.SetChartParameter(Chart.ChartParameter.chartType, "column2d")
        actividades.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        actividades.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        Dim oListadoActividad As List(Of FactActividadSumBE)
        Dim str As New StringBuilder

        oListadoActividad = bc.ListarComitesActividades()

        str.Append("<chart caption='Actividades por Comité' xaxisname='Comité' yaxisname='Cantidad de Actividades' theme='fint'>")

        For Each oActividad As FactActividadSumBE In oListadoActividad
            str.Append("<set label='").Append(oActividad.nombre_comite).Append("' value='").Append(oActividad.total_actividades).Append("' />")
        Next

        str.Append("</chart>")

        actividades.SetData(str.ToString, Chart.DataFormat.xml)
        ltrActividadesPorComite.Text = actividades.Render()
    End Sub

    Private Sub CargarActividadesTipo()
        Dim actividades As New Chart()
        actividades.SetChartParameter(Chart.ChartParameter.chartId, "myChart5")
        actividades.SetChartParameter(Chart.ChartParameter.chartType, "column2d")
        actividades.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        actividades.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        Dim oListadoActividad As List(Of FactActividadSumBE)
        Dim str As New StringBuilder

        oListadoActividad = bc.ListarTiposActividades()

        str.Append("<chart caption='Actividades por Tipo' xaxisname='Tipo de Actividad' yaxisname='Cantidad de Actividades' theme='fint'>")

        For Each oActividad As FactActividadSumBE In oListadoActividad
            str.Append("<set label='").Append(oActividad.nombre_tipo).Append("' value='").Append(oActividad.total_actividades).Append("' />")
        Next

        str.Append("</chart>")

        actividades.SetData(str.ToString, Chart.DataFormat.xml)
        ltrActividadesPorTipo.Text = actividades.Render()
    End Sub

    Private Sub CargarPersonasMasParticipativas()
        Dim participantes As New Chart()
        participantes.SetChartParameter(Chart.ChartParameter.chartId, "myChart6")
        participantes.SetChartParameter(Chart.ChartParameter.chartType, "bar2d")
        participantes.SetChartParameter(Chart.ChartParameter.chartWidth, "460")
        participantes.SetChartParameter(Chart.ChartParameter.chartHeight, "152")

        Dim oListadoPersona As List(Of FactParticipanteBE)
        Dim str As New StringBuilder

        oListadoPersona = bc.ListarPersonasMasParticipativas()

        str.Append("<chart caption='Top 5' xaxisname='Persona' yaxisname='Cantidad de Actividades' plotgradientcolor='' bgcolor='FFFFFF' showplotborder='0' divlinecolor='CCCCCC' showvalues='1' showcanvasborder='0' canvasbordercolor='CCCCCC' canvasborderthickness='1' showyaxisvalues='0' showlegend='1' showshadow='0' labelsepchar=': ' basefontcolor='000000' labeldisplay='AUTO' numberscalevalue='1000,1000,1000' numberscaleunit='K,M,B' palettecolors='#008ee4,#9b59b6,#6baa01,#e44a00,#f8bd19,#d35400,#bdc3c7,#95a5a6,#34495e,#1abc9c' showborder='0'>")

        If oListadoPersona IsNot Nothing AndAlso oListadoPersona.Count > 0 Then
            If oListadoPersona.Count <= 5 Then
                For Each oPersona As FactParticipanteBE In oListadoPersona
                    str.Append("<set label='").Append(oPersona.nombre_persona).Append("' value='").Append(oPersona.cant_actividades).Append("' tooltext='Número de actividades en las que participó la persona' />")
                Next
            Else
                For i As Integer = 0 To 4
                    str.Append("<set label='").Append(oListadoPersona.Item(i).nombre_persona).Append("' value='").Append(oListadoPersona.Item(i).cant_actividades).Append("' tooltext='Número de actividades en las que participó la persona' />")
                Next
            End If
        End If

        Dim total As Integer = bc.ObtenerTotalActividades()

        str.Append("<trendlines>")
        str.Append("<line startvalue='").Append(total).Append("' endvalue='' istrendzone='' valueonright='1' color='fda813' displayvalue='Total Actividades' showontop='1' thickness='2' />")
        str.Append("</trendlines>")
        str.Append("</chart>")

        participantes.SetData(str.ToString, Chart.DataFormat.xml)
        ltrParticipantes.Text = participantes.Render()
    End Sub

    Private Sub CargarPersonalMasSolicitado()
        Dim personal As New Chart()
        personal.SetChartParameter(Chart.ChartParameter.chartId, "myChart7")
        personal.SetChartParameter(Chart.ChartParameter.chartType, "bar2d")
        personal.SetChartParameter(Chart.ChartParameter.chartWidth, "460")
        personal.SetChartParameter(Chart.ChartParameter.chartHeight, "152")

        Dim oListadoPersonal As List(Of FactPersonalBE)
        Dim str As New StringBuilder

        oListadoPersonal = bc.ListarPersonalMasSolicitado()

        str.Append("<chart caption='Top 5' xaxisname='Personal' yaxisname='Cantidad de Actividades' plotgradientcolor='' bgcolor='FFFFFF' showplotborder='0' divlinecolor='CCCCCC' showvalues='1' showcanvasborder='0' canvasbordercolor='CCCCCC' canvasborderthickness='1' showyaxisvalues='0' showlegend='1' showshadow='0' labelsepchar=': ' basefontcolor='000000' labeldisplay='AUTO' numberscalevalue='1000,1000,1000' numberscaleunit='K,M,B' palettecolors='#008ee4,#9b59b6,#6baa01,#e44a00,#f8bd19,#d35400,#bdc3c7,#95a5a6,#34495e,#1abc9c' showborder='0'>")

        If oListadoPersonal IsNot Nothing AndAlso oListadoPersonal.Count > 0 Then
            If oListadoPersonal.Count <= 5 Then
                For Each oPersonal As FactPersonalBE In oListadoPersonal
                    str.Append("<set label='").Append(oPersonal.nombre_personal).Append("' value='").Append(oPersonal.cant_actividades).Append("' tooltext='Número de actividades en las que participó el personal' />")
                Next
            Else
                For i As Integer = 0 To 4
                    str.Append("<set label='").Append(oListadoPersonal.Item(i).nombre_personal).Append("' value='").Append(oListadoPersonal.Item(i).cant_actividades).Append("' tooltext='Número de actividades en las que participó el personal' />")
                Next
            End If
        End If
        

        str.Append("</chart>")

        personal.SetData(str.ToString, Chart.DataFormat.xml)
        ltrPersonal.Text = personal.Render()
    End Sub

    Private Sub CargarTasaCrecimientoAnual()
        Dim personal As New Chart()
        personal.SetChartParameter(Chart.ChartParameter.chartId, "myChart8")
        personal.SetChartParameter(Chart.ChartParameter.chartType, "mscombidy2d")
        personal.SetChartParameter(Chart.ChartParameter.chartWidth, "940")
        personal.SetChartParameter(Chart.ChartParameter.chartHeight, "232")

        Dim oListadoActividad As List(Of FactActividadSumBE)
        Dim str As New StringBuilder

        oListadoActividad = bc.ListarParticipantesPorAnio()

        str.Append("<chart caption='Tasa de Crecimiento Anual' subcaption='En relación al año inmediato anterior' showvalues='1' snumbersuffix='%' decimals='2' setadaptiveymin='1' setadaptivesymin='1' linethickness='2' pyaxisname='Cantidad de Participantes' syaxisname='Tasa de Crecimiento' theme='fint'>")
        str.Append("<categories>")

        For Each oActividad As FactActividadSumBE In oListadoActividad
            str.Append("<category name='").Append(oActividad.anio).Append("' />")
        Next

        str.Append("</categories>")

        str.Append("<dataset seriesname='Cantidad de Participantes'>")

        For Each oActividad As FactActividadSumBE In oListadoActividad
            str.Append("<set value='").Append(oActividad.total_participantes).Append("' />")
        Next

        str.Append("</dataset>")

        str.Append("<dataset parentyaxis='S' seriesname='Tasa de Crecimiento' renderas='Line'>")

        Dim part_ant As Integer = 0
        Dim oFact As FactActividadSumBE

        For i As Integer = 0 To oListadoActividad.Count - 1
            oFact = oListadoActividad.Item(i)

            If i = 0 Then
                str.Append("<set value='0' />")
            Else
                str.Append("<set value='").Append(((oFact.total_participantes - part_ant) * 1.0 / part_ant * 1.0) * 100.0).Append("' />")
            End If

            part_ant = oFact.total_participantes
        Next

        str.Append("</dataset>")
        str.Append("</chart>")

        personal.SetData(str.ToString, Chart.DataFormat.xml)
        ltrTasaCrecimiento.Text = personal.Render()

    End Sub
End Class
