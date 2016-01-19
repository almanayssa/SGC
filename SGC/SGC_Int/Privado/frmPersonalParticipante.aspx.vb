Imports System.Collections
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

Public Class frmPersonalParticipante
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Session("menu") = "reportes"

            CargarPersonalMasSolicitado()
            CargarPersonasMasParticipativas()
        End If
    End Sub

    Private Sub CargarPersonasMasParticipativas()
        Dim participantes As New Chart()
        participantes.SetChartParameter(Chart.ChartParameter.chartId, "myChart6")
        participantes.SetChartParameter(Chart.ChartParameter.chartType, "bar2d")
        participantes.SetChartParameter(Chart.ChartParameter.chartWidth, "450")
        participantes.SetChartParameter(Chart.ChartParameter.chartHeight, "1350")

        Dim oListadoPersona As List(Of FactParticipanteBE)
        Dim str As New StringBuilder

        oListadoPersona = bc.ListarPersonasMasParticipativas()

        str.Append("<chart caption='Personas más participativas' subCaption='Respecto a la cantidad de actividades en que se involucró' xaxisname='Persona' yaxisname='Cantidad de Actividades' plotgradientcolor='' bgcolor='FFFFFF' showplotborder='0' divlinecolor='CCCCCC' showvalues='1' showcanvasborder='0' canvasbordercolor='CCCCCC' canvasborderthickness='1' showyaxisvalues='0' showlegend='1' showshadow='0' labelsepchar=': ' basefontcolor='000000' labeldisplay='AUTO' numberscalevalue='1000,1000,1000' numberscaleunit='K,M,B' palettecolors='#008ee4,#9b59b6,#6baa01,#e44a00,#f8bd19,#d35400,#bdc3c7,#95a5a6,#34495e,#1abc9c' showborder='0' formatnumberscale='0'>")

        For Each oPersona As FactParticipanteBE In oListadoPersona
            str.Append("<set label='").Append(oPersona.nombre_persona).Append("' value='").Append(oPersona.cant_actividades).Append("' tooltext='Número de actividades en las que participó la persona' />")
        Next

        Dim total As Integer = bc.ObtenerTotalActividades()

        str.Append("<trendlines>")
        str.Append("<line startvalue='").Append(total).Append("' endvalue='' istrendzone='' valueonright='1' color='fda813' displayvalue='Total Actividades' showontop='1' thickness='2' />")
        str.Append("</trendlines>")
        str.Append("</chart>")

        participantes.SetData(str.ToString, Chart.DataFormat.xml)
        ltrParticipante.Text = participantes.Render()
    End Sub

    Private Sub CargarPersonalMasSolicitado()
        Dim personal As New Chart()
        personal.SetChartParameter(Chart.ChartParameter.chartId, "myChart7")
        personal.SetChartParameter(Chart.ChartParameter.chartType, "bar2d")
        personal.SetChartParameter(Chart.ChartParameter.chartWidth, "430")
        personal.SetChartParameter(Chart.ChartParameter.chartHeight, "450")

        Dim oListadoPersonal As List(Of FactPersonalBE)
        Dim str As New StringBuilder

        oListadoPersonal = bc.ListarPersonalMasSolicitado()

        str.Append("<chart caption='Personal más solicitado' subCaption='Respecto a la cantidad de actividades en que se involucró' xaxisname='Personal' yaxisname='Cantidad de Actividades' plotgradientcolor='' bgcolor='FFFFFF' showplotborder='0' divlinecolor='CCCCCC' showvalues='1' showcanvasborder='0' canvasbordercolor='CCCCCC' canvasborderthickness='1' showyaxisvalues='0' showlegend='1' showshadow='0' labelsepchar=': ' basefontcolor='000000' labeldisplay='AUTO' numberscalevalue='1000,1000,1000' numberscaleunit='K,M,B' palettecolors='#008ee4,#9b59b6,#6baa01,#e44a00,#f8bd19,#d35400,#bdc3c7,#95a5a6,#34495e,#1abc9c' showborder='0' formatnumberscale='0'>")

        For Each oPersonal As FactPersonalBE In oListadoPersonal
            str.Append("<set label='").Append(oPersonal.nombre_personal).Append("' value='").Append(oPersonal.cant_actividades).Append("' tooltext='Número de actividades en las que participó el personal' />")
        Next

        str.Append("</chart>")

        personal.SetData(str.ToString, Chart.DataFormat.xml)
        ltrPersonal.Text = personal.Render()
    End Sub

End Class