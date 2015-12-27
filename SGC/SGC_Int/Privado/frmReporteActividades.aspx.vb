Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmReporteActividades
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarTipoActividad()
            txtFechaInicio.Text = Now.ToString("dd/MM/yyyy")
            txtFechaFin.Text = Now.ToString("dd/MM/yyyy")
        End If
    End Sub

    Private Sub ListarTipoActividad()
        Dim ListadoTipoActividad As List(Of TipoActividadBE) = bc.ListarTipoActividad()
        ddlTipo.DataSource = ListadoTipoActividad
        ddlTipo.DataValueField = "id_tipo_act"
        ddlTipo.DataTextField = "desc_tipo"
        ddlTipo.DataBind()
    End Sub

    Private Sub CargarReporte()
        rvwActividad.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote
        'rvwActividad.ServerReport.ReportServerCredentials = New ReportServerNetworkCredentials()
        rvwActividad.ServerReport.ReportServerUrl = New Uri("http://localhost/ReportServer")
        rvwActividad.ServerReport.ReportPath = "/Reports/rptActividades"
        rvwActividad.ShowParameterPrompts = False
        rvwActividad.ShowPrintButton = True

        Dim reportParameterCollection As Microsoft.Reporting.WebForms.ReportParameter() = New Microsoft.Reporting.WebForms.ReportParameter(2) {}
        reportParameterCollection(0) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(0).Name = "Id Tipo"
        reportParameterCollection(0).Values.Add(ddlTipo.SelectedValue)

        reportParameterCollection(1) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(1).Name = "From Id Fecha"
        reportParameterCollection(1).Values.Add(Convert.ToDateTime(txtFechaInicio.Text).ToString("yyyyMMdd"))

        reportParameterCollection(2) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(2).Name = "To Id Fecha"
        reportParameterCollection(2).Values.Add(Convert.ToDateTime(txtFechaFin.Text).ToString("yyyyMMdd"))

        rvwActividad.ServerReport.SetParameters(reportParameterCollection)
        rvwActividad.ServerReport.Refresh()
    End Sub

    Protected Sub lbtnBuscar_Click(sender As Object, e As EventArgs) Handles lbtnBuscar.Click
        CargarReporte()
    End Sub
End Class