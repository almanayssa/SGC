Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmReporteActividades
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Session("menu") = "reportes"

            txtFechaInicio.Text = "01/01/2015"
            txtFechaFin.Text = Now.ToString("dd/MM/yyyy")
            CargarReporte()
        End If
    End Sub

    Private Sub CargarReporte()
        rvwActividad.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote
        'rvwActividad.ServerReport.ReportServerCredentials = New ReportServerNetworkCredentials()
        rvwActividad.ServerReport.ReportServerUrl = New Uri("http://localhost/ReportServer")
        rvwActividad.ServerReport.ReportPath = "/Reports/rptActividad"
        rvwActividad.ShowParameterPrompts = False
        rvwActividad.ShowPrintButton = True

        Dim reportParameterCollection As Microsoft.Reporting.WebForms.ReportParameter() = New Microsoft.Reporting.WebForms.ReportParameter(1) {}
        reportParameterCollection(0) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(0).Name = "FechaFrom"
        reportParameterCollection(0).Values.Add(Convert.ToDateTime(txtFechaInicio.Text).ToString("yyyyMMdd"))

        reportParameterCollection(1) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(1).Name = "FechaTo"
        reportParameterCollection(1).Values.Add(Convert.ToDateTime(txtFechaFin.Text).ToString("yyyyMMdd"))

        rvwActividad.ServerReport.SetParameters(reportParameterCollection)
        rvwActividad.ServerReport.Refresh()
    End Sub

    Protected Sub lbtnBuscar_Click(sender As Object, e As EventArgs) Handles lbtnBuscar.Click
        CargarReporte()
    End Sub
End Class