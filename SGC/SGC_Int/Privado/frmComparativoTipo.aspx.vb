Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmComparativoTipo
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarComites()
            ListarTipoActividad()
            txtFechaInicio.Text = "01/01/2015"
            txtFechaFin.Text = Now.ToString("dd/MM/yyyy")

            'For Each chkTipo As ListItem In cblTipos.Items
            '    chkTipo.Selected = True
            'Next

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
        ddlTipoActividad.DataSource = ListadoTipoActividad
        ddlTipoActividad.DataValueField = "id_tipo_act"
        ddlTipoActividad.DataTextField = "desc_tipo"
        ddlTipoActividad.DataBind()
    End Sub

    Protected Sub lbtnGenerar_Click(sender As Object, e As EventArgs) Handles lbtnGenerar.Click
        If ValidarCamposRequeridos().Trim <> String.Empty Then
            lblMensaje.Visible = True
            lblMensaje.Text = ValidarCamposRequeridos()
            divLeyenda.Visible = False
            Exit Sub
        End If

        lblMensaje.Visible = False
        divLeyenda.Visible = True
        GenerarSemaforo()
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If ddlComite.SelectedValue = "000" Then
            msg &= "<br/>- Seleccione un comité"
        End If

        If ddlTipoActividad.SelectedValue = "00" Then
            msg &= "<br/>- Seleccione un tipo"
        End If

        Return msg
    End Function

    Private Sub GenerarSemaforo()
        Dim ListadoSemaforo As List(Of SemaforoBE) = bc.ListarComparativoTipo(ddlComite.SelectedValue, ddlTipoActividad.SelectedValue, txtFechaInicio.Text.Trim, txtFechaFin.Text.Trim)
        gvwSemaforo.DataSource = ListadoSemaforo
        gvwSemaforo.DataBind()
    End Sub

    Private Sub gvwSemaforo_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvwSemaforo.RowDataBound
        If e.Row.RowType = DataControlRowType.Header Then
            Dim ListadoTipoActividad As List(Of TipoActividadBE) = bc.ListarTipoActividad()
            ListadoTipoActividad.RemoveAt(0)

            Dim texto1 As String = String.Empty
            Dim texto2 As String = String.Empty

            For Each oTipo As TipoActividadBE In ListadoTipoActividad
                If oTipo.id_tipo_act <> ddlTipoActividad.SelectedValue Then
                    If texto1 <> String.Empty Then
                        texto2 = oTipo.desc_tipo
                        Exit For
                    Else
                        texto1 = oTipo.desc_tipo
                    End If
                End If
            Next

            e.Row.Cells(1).Text = "Part. " & ddlTipoActividad.SelectedItem.Text
            e.Row.Cells(2).Text = "Part. " & texto1
            e.Row.Cells(3).Text = "Part. " & texto2
            e.Row.Cells(4).Text = "Relación " & ddlTipoActividad.SelectedItem.Text & " - " & texto1
            e.Row.Cells(5).Text = "Relación " & ddlTipoActividad.SelectedItem.Text & " - " & texto2
        End If
    End Sub
End Class