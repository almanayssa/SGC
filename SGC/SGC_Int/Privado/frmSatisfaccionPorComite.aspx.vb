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

Public Class frmSatisfaccionPorComite
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Session("menu") = "reportes"

            CargarSatisfaccionPorComite()
        End If
    End Sub

    Private Sub CargarSatisfaccionPorComite()
        Dim oListadoSatisfaccion As List(Of FactActividadSumBE) = bc.ListarComitesSatisfaccion()
        Dim str As New StringBuilder

        Dim satisfaccion As New Chart()

        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart1")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(0).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(0).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite1.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart2")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(1).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(1).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite2.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart3")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(2).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(2).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite3.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart4")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(3).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(3).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite4.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart5")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(4).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(4).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite5.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart6")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(5).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(5).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite6.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart7")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(6).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(6).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite7.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart8")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(7).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(7).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite8.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart9")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(8).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(8).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite9.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart10")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(9).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(9).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite10.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart11")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(10).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(10).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite11.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart12")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(11).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(11).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite12.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart13")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(12).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(12).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite13.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart14")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(13).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(13).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite14.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart15")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(14).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(14).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite15.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart16")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(15).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(15).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite16.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart17")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(16).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(16).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite17.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart18")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(17).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(17).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite18.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart19")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(18).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(18).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite19.Text = satisfaccion.Render()

        str.Clear()
        satisfaccion = New Chart()
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartId, "myChart20")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartType, "angulargauge")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartWidth, "300")
        satisfaccion.SetChartParameter(Chart.ChartParameter.chartHeight, "150")

        str.Append("<chart caption='").Append(oListadoSatisfaccion.Item(19).nombre_comite).Append("' subCaption='Nivel de Satisfacción' lowerlimit='0' upperlimit='100' numberSuffix='%' lowerLimitDisplay='Insatisfecho' upperLimitDisplay='Satisfecho' palette='1' tickvaluedistance='10' showValue='1' gaugeinnerradius='0' bgcolor='FFFFFF' pivotfillcolor='333333' pivotradius='8' pivotfillmix='333333,333333' pivotfilltype='radial' pivotfillratio='0,100' showtickvalues='1' showborder='0' theme='fint'>")
        str.Append("<colorrange>")
        str.Append("<color minvalue='0' maxvalue='33' code='e44a00' />")
        str.Append("<color minvalue='33' maxvalue='66' code='f8bd19' />")
        str.Append("<color minvalue='66' maxvalue='100' code='6baa01' />")
        str.Append("</colorrange>")
        str.Append("<dials>")
        str.Append("<dial value='").Append(oListadoSatisfaccion.Item(19).cant_satisfaccion).Append("' rearextension='15' radius='60' bgcolor='333333' bordercolor='333333' basewidth='8' />")
        str.Append("</dials>")
        str.Append("</chart>")
        satisfaccion.SetData(str.ToString, Chart.DataFormat.xml)
        ltrComite20.Text = satisfaccion.Render()

    End Sub
End Class