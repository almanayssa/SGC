Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmReporteComite
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
        rvwComite.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote
        'rvwComite.ServerReport.ReportServerCredentials = New ReportServerNetworkCredentials()
        rvwComite.ServerReport.ReportServerUrl = New Uri("http://localhost/ReportServer")
        rvwComite.ServerReport.ReportPath = "/Reports/rptComite"
        rvwComite.ShowParameterPrompts = False
        rvwComite.ShowPrintButton = True

        Dim reportParameterCollection As Microsoft.Reporting.WebForms.ReportParameter() = New Microsoft.Reporting.WebForms.ReportParameter(1) {}
        reportParameterCollection(0) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(0).Name = "FechaFrom"
        reportParameterCollection(0).Values.Add(Convert.ToDateTime(txtFechaInicio.Text).ToString("yyyyMMdd"))

        reportParameterCollection(1) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(1).Name = "FechaTo"
        reportParameterCollection(1).Values.Add(Convert.ToDateTime(txtFechaFin.Text).ToString("yyyyMMdd"))

        rvwComite.ServerReport.SetParameters(reportParameterCollection)
        rvwComite.ServerReport.Refresh()
    End Sub

    Protected Sub lbtnBuscar_Click(sender As Object, e As EventArgs) Handles lbtnBuscar.Click
        CargarReporte()
    End Sub
End Class