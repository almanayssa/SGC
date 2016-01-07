Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmReporteGeneral
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarComites()
            ListarTipoActividad()
            ListarVariables()
            txtFechaInicio.Text = "01/01/2015"
            txtFechaFin.Text = Now.ToString("dd/MM/yyyy")

            For Each chkTipo As ListItem In cblTipos.Items
                chkTipo.Selected = True
            Next

            For Each chkVariable As ListItem In cblVariables.Items
                chkVariable.Selected = True
            Next
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

    Private Sub ListarTipoActividad()
        Dim ListadoTipoActividad As List(Of TipoActividadBE) = bc.ListarTipoActividad()
        ddlTipo.DataSource = ListadoTipoActividad
        ddlTipo.DataValueField = "id_tipo_act"
        ddlTipo.DataTextField = "desc_tipo"
        ddlTipo.DataBind()

        ListadoTipoActividad.RemoveAt(0)
        cblTipos.DataSource = ListadoTipoActividad
        cblTipos.DataValueField = "id_tipo_act"
        cblTipos.DataTextField = "desc_tipo"
        cblTipos.DataBind()
    End Sub

    Private Sub ListarActividades()
        Dim ListadoActividades As List(Of ActividadBE) = bc.ListarActividades(ddlComite.SelectedValue, ddlTipo.SelectedValue, txtFechaInicio.Text.Trim, txtFechaFin.Text.Trim)
        cblActividades.DataSource = ListadoActividades
        cblActividades.DataValueField = "id_actividad"
        cblActividades.DataTextField = "nombre"
        cblActividades.DataBind()
    End Sub

    Protected Sub ddlComite_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlComite.SelectedIndexChanged
        If rbtnActividad.Checked Then
            If ddlComite.SelectedValue = "000" Then
                lblMensaje.Text = "Seleccione un comité"
                Exit Sub
            Else
                ListarActividades()
            End If
        End If
    End Sub

    Protected Sub chkTipos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTipos.CheckedChanged
        For Each chkTipo As ListItem In cblTipos.Items
            chkTipo.Selected = chkTipos.Checked
        Next
    End Sub

    Protected Sub chkActividades_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkActividades.CheckedChanged
        For Each chkActividad As ListItem In cblActividades.Items
            chkActividad.Selected = chkActividades.Checked
        Next
    End Sub

    Private Sub ListarVariables()
        Dim ListadoVariables As List(Of VariableBE) = bc.ListarVariables()
        cblVariables.DataSource = ListadoVariables
        cblVariables.DataValueField = "id_variable"
        cblVariables.DataTextField = "nombre"
        cblVariables.DataBind()
    End Sub

    Protected Sub ddlTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTipo.SelectedIndexChanged
        If rbtnActividad.Checked Then
            If ddlTipo.SelectedValue = "00" Then
                lblMensaje.Text = "Seleccione un tipo"
                Exit Sub
            Else
                ListarActividades()
            End If
        End If
    End Sub

    Protected Sub chkVariables_CheckedChanged(sender As Object, e As EventArgs) Handles chkVariables.CheckedChanged
        For Each chkVariable As ListItem In cblVariables.Items
            chkVariable.Selected = chkVariables.Checked
        Next
    End Sub

    Protected Sub lbtnGenerarReporte_Click(sender As Object, e As EventArgs) Handles lbtnGenerarReporte.Click
        If ValidarCamposRequeridos().Trim <> String.Empty Then
            lblMensaje.Visible = True
            lblMensaje.Text = ValidarCamposRequeridos()
            Exit Sub
        End If

        lblMensaje.Visible = False
        GenerarReporte()
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If ddlComite.SelectedValue = "000" Then
            msg &= "<br/>- Seleccione un comité"
        End If

        If rbtnActividad.Checked Then
            If ddlTipo.SelectedValue = "00" Then
                msg &= "<br/>- Seleccione un tipo"
            End If
            msg &= ValidarActividades()
        Else
            msg &= ValidarTipos()
        End If

        msg &= ValidarVariables()

        Return msg
    End Function

    Private Function ValidarTipos() As String
        Dim msg As String = String.Empty
        Dim count As Integer = 0

        For Each chkTipo As ListItem In cblTipos.Items
            If chkTipo.Selected Then
                count += 1
            End If
        Next

        If count = 0 Then
            msg &= "<br/>- Seleccione un tipo al menos"
        End If

        Return msg
    End Function

    Private Function ValidarActividades() As String
        Dim msg As String = String.Empty
        Dim count As Integer = 0

        For Each chkActividad As ListItem In cblActividades.Items
            If chkActividad.Selected Then
                count += 1
            End If
        Next

        If count = 0 Then
            msg &= "<br/>- Seleccione una actividad al menos"
        End If

        Return msg
    End Function

    Private Function ValidarVariables() As String
        Dim msg As String = String.Empty
        Dim count As Integer = 0

        For Each chkVariable As ListItem In cblVariables.Items
            If chkVariable.Selected Then
                count += 1
            End If
        Next

        If count = 0 Then
            msg &= "<br/>- Seleccione una variable al menos"
        End If

        Return msg
    End Function

    Private Sub GenerarReporte()
        Dim reportPath As String = String.Empty
        Dim nomPar As String = String.Empty
        Dim id As String = String.Empty
        Dim cantParametros As Integer = 0
        Dim oListadoParametros As List(Of ParametroBE) = bc.ListarParametro()

        rvwReporteGeneral.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote
        rvwReporteGeneral.ServerReport.ReportServerUrl = New Uri("http://localhost/ReportServer")

        If rbtnTipo.Checked Then
            'If rbtnDescriptivo.Checked Then
            cantParametros = 5
            reportPath = "/Reports/rptGeneralPorTipo"
            'End If

            'If rbtnComparativo.Checked Then
            '    cantParametros = 11
            '    reportPath = "/Reports/rptComparativoPorTipo"
            'End If
        End If

        If rbtnActividad.Checked Then
            'If rbtnDescriptivo.Checked Then
            cantParametros = 5
            reportPath = "/Reports/rptGeneralPorActividad"
            'End If

            'If rbtnComparativo.Checked Then
            '    cantParametros = 11
            '    reportPath = "/Reports/rptComparativoPorActividad"
            'End If
        End If

        rvwReporteGeneral.ServerReport.ReportPath = reportPath
        rvwReporteGeneral.ShowParameterPrompts = False
        rvwReporteGeneral.ShowPrintButton = False

        If rbtnTipo.Checked Then
            nomPar = "id_tipo"

            For Each chkTipo As ListItem In cblTipos.Items
                If chkTipo.Selected Then
                    id = id & "" & chkTipo.Value & ","
                End If
            Next
        End If

        If rbtnActividad.Checked Then
            nomPar = "id_actividad"

            For Each chkActividad As ListItem In cblActividades.Items
                If chkActividad.Selected Then
                    id = id & "" & chkActividad.Value & ","
                End If
            Next
        End If

        Dim reportParameterCollection As Microsoft.Reporting.WebForms.ReportParameter() = New Microsoft.Reporting.WebForms.ReportParameter(cantParametros) {}

        reportParameterCollection(0) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(0).Name = "fec_ini"
        reportParameterCollection(0).Values.Add(Convert.ToDateTime(txtFechaInicio.Text))

        reportParameterCollection(1) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(1).Name = "fec_fin"
        reportParameterCollection(1).Values.Add(Convert.ToDateTime(txtFechaFin.Text))

        reportParameterCollection(2) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(2).Name = nomPar
        reportParameterCollection(2).Values.Add(id.Substring(0, id.Length - 1))

        reportParameterCollection(3) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(3).Name = "flg_inscritos"
        reportParameterCollection(3).Values.Add(cblVariables.Items(0).Selected)

        reportParameterCollection(4) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(4).Name = "flg_participantes"
        reportParameterCollection(4).Values.Add(cblVariables.Items(1).Selected)

        reportParameterCollection(5) = New Microsoft.Reporting.WebForms.ReportParameter()
        reportParameterCollection(5).Name = "flg_satisfaccion"
        reportParameterCollection(5).Values.Add(cblVariables.Items(2).Selected)

        'If rbtnComparativo.Checked Then
        '    reportParameterCollection(6) = New Microsoft.Reporting.WebForms.ReportParameter()
        '    reportParameterCollection(6).Name = "min_rojo"
        '    reportParameterCollection(6).Values.Add(oListadoParametros.Item(0).valor)

        '    reportParameterCollection(7) = New Microsoft.Reporting.WebForms.ReportParameter()
        '    reportParameterCollection(7).Name = "max_rojo"
        '    reportParameterCollection(7).Values.Add(oListadoParametros.Item(1).valor)

        '    reportParameterCollection(8) = New Microsoft.Reporting.WebForms.ReportParameter()
        '    reportParameterCollection(8).Name = "min_amarillo"
        '    reportParameterCollection(8).Values.Add(oListadoParametros.Item(2).valor)

        '    reportParameterCollection(9) = New Microsoft.Reporting.WebForms.ReportParameter()
        '    reportParameterCollection(9).Name = "max_amarillo"
        '    reportParameterCollection(9).Values.Add(oListadoParametros.Item(3).valor)

        '    reportParameterCollection(10) = New Microsoft.Reporting.WebForms.ReportParameter()
        '    reportParameterCollection(10).Name = "min_verde"
        '    reportParameterCollection(10).Values.Add(oListadoParametros.Item(4).valor)

        '    reportParameterCollection(11) = New Microsoft.Reporting.WebForms.ReportParameter()
        '    reportParameterCollection(11).Name = "max_verde"
        '    reportParameterCollection(11).Values.Add(oListadoParametros.Item(5).valor)

        'End If

        rvwReporteGeneral.ServerReport.SetParameters(reportParameterCollection)
        rvwReporteGeneral.ServerReport.Refresh()
    End Sub

    Protected Sub rbtnTipo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTipo.CheckedChanged
        If rbtnTipo.Checked Then
            tblTipos.Visible = True
            tblActividades.Visible = False
        Else
            tblTipos.Visible = False
            tblActividades.Visible = True
        End If
        ListarVariables()
    End Sub

    Protected Sub rbtnActividad_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnActividad.CheckedChanged
        If rbtnActividad.Checked Then
            tblTipos.Visible = False
            tblActividades.Visible = True
        Else
            tblTipos.Visible = True
            tblActividades.Visible = False
        End If
        ListarVariables()
    End Sub

    Protected Sub cblTipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblTipos.SelectedIndexChanged
        Dim count As Integer = 0

        For Each chkTipo As ListItem In cblTipos.Items
            If chkTipo.Selected Then
                count += 1
            End If
        Next

        If count = cblTipos.Items.Count Then
            chkTipos.Checked = True
        Else
            chkTipos.Checked = False
        End If
    End Sub

    Protected Sub cblActividades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblActividades.SelectedIndexChanged
        Dim count As Integer = 0

        For Each chkActividad As ListItem In cblActividades.Items
            If chkActividad.Selected Then
                count += 1
            End If
        Next

        If count = cblActividades.Items.Count Then
            chkActividades.Checked = True
        Else
            chkActividades.Checked = False
        End If
    End Sub

    Protected Sub cblVariables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblVariables.SelectedIndexChanged
        Dim count As Integer = 0

        For Each chkVariable As ListItem In cblVariables.Items
            If chkVariable.Selected Then
                count += 1
            End If
        Next

        If count = cblVariables.Items.Count Then
            chkVariables.Checked = True
        Else
            chkVariables.Checked = False
        End If
    End Sub
End Class