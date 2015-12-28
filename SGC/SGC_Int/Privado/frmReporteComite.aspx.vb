Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmReporteComite
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarComites()
            txtFechaInicio.Text = "01/12/2015"
            txtFechaFin.Text = Now.ToString("dd/MM/yyyy")
            CargarReporte()
        End If
    End Sub

    Private Sub ListarComites()
        Dim oComite As New ComiteBE
        oComite.id_comite = "000"
        oComite.nombre = "- Seleccione -"

        Dim ListadoComites As List(Of ComiteBE) = bc.ListarComites()
        ListadoComites.Insert(0, oComite)
        ddlComite.DataSource = ListadoComites
        ddlComite.DataValueField = "id_comite"
        ddlComite.DataTextField = "nombre"
        ddlComite.DataBind()
    End Sub

    Private Sub CargarReporte()
        rvwComite.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote
        'rvwComite.ServerReport.ReportServerCredentials = New ReportServerNetworkCredentials()
        rvwComite.ServerReport.ReportServerUrl = New Uri("http://localhost/ReportServer")
        rvwComite.ServerReport.ReportPath = "/Reports/rptComite"
        rvwComite.ShowParameterPrompts = False
        rvwComite.ShowPrintButton = True

        Dim reportParameterCollection As Microsoft.Reporting.WebForms.ReportParameter() = New Microsoft.Reporting.WebForms.ReportParameter(2) {}
        reportParameterCollection(0) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(0).Name = "ComiteID"
        reportParameterCollection(0).Values.Add(ddlComite.SelectedValue)

        reportParameterCollection(1) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(1).Name = "FechaFrom"
        reportParameterCollection(1).Values.Add(Convert.ToDateTime(txtFechaInicio.Text).ToString("yyyyMMdd"))

        reportParameterCollection(2) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(2).Name = "FechaTo"
        reportParameterCollection(2).Values.Add(Convert.ToDateTime(txtFechaFin.Text).ToString("yyyyMMdd"))

        rvwComite.ServerReport.SetParameters(reportParameterCollection)
        rvwComite.ServerReport.Refresh()
    End Sub

    Protected Sub lbtnBuscar_Click(sender As Object, e As EventArgs) Handles lbtnBuscar.Click
        CargarReporte()
    End Sub
End Class