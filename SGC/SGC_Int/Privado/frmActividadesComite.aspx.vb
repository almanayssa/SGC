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

Public Class frmActividadesComite
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Session("menu") = "reportes"

            CargarActividadesComite()
        End If
    End Sub

    Private Sub CargarActividadesComite()
        Dim actividades As New Chart()
        actividades.SetChartParameter(Chart.ChartParameter.chartId, "myChart")
        actividades.SetChartParameter(Chart.ChartParameter.chartType, "column2d")
        actividades.SetChartParameter(Chart.ChartParameter.chartWidth, "940")
        actividades.SetChartParameter(Chart.ChartParameter.chartHeight, "470")

        Dim oListadoActividad As List(Of FactActividadSumBE)
        Dim str As New StringBuilder

        oListadoActividad = bc.ListarComitesActividades()

        str.Append("<chart caption='Cantidad de Actividades por Comité' formatnumberscale='0' xaxisname='Comité' yaxisname='Cantidad de Actividades' theme='fint'>")

        For Each oActividad As FactActividadSumBE In oListadoActividad
            str.Append("<set label='").Append(oActividad.nombre_comite).Append("' value='").Append(oActividad.total_actividades).Append("' />")
        Next

        str.Append("</chart>")

        actividades.SetData(str.ToString, Chart.DataFormat.xml)
        ltrActividades.Text = actividades.Render()
    End Sub

End Class