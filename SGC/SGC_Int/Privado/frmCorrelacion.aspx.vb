Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmCorrelacion
    Inherits System.Web.UI.Page

    Private bc As New BusinessController
    Dim texto1 As String
    Dim texto2 As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarComites()
            ListarTipoActividad()
            LitarTipo2(ddlTipoActividad.SelectedValue)
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
        ListadoTipoActividad.RemoveAt(0)
        ddlTipoActividad.DataSource = ListadoTipoActividad
        ddlTipoActividad.DataValueField = "id_tipo_act"
        ddlTipoActividad.DataTextField = "desc_tipo"
        ddlTipoActividad.DataBind()

    End Sub

    Private Sub LitarTipo2(id1)
        Dim ListadoTipoActividad As List(Of TipoActividadBE) = bc.ListarTipoActividadVal(id1)
        ListadoTipoActividad.RemoveAt(0)
        ddlTipoActividad2.DataSource = ListadoTipoActividad
        ddlTipoActividad2.DataValueField = "id_tipo_act"
        ddlTipoActividad2.DataTextField = "desc_tipo"
        ddlTipoActividad2.DataBind()
    End Sub

    Protected Sub lbtnGenerar_Click(sender As Object, e As EventArgs) Handles lbtnGenerar.Click
        If ValidarCamposRequeridos().Trim <> String.Empty Then
            lblMensaje.Visible = True
            lblMensaje.Text = ValidarCamposRequeridos()
            divLeyenda.Visible = False
            Exit Sub
        End If

        GenerarCuadro()
        'GenerarSemaforo()
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If ddlComite.SelectedValue = "000" Then
            msg &= "<br/>- Seleccione un comité"
        End If

        Return msg
    End Function


    Protected Sub ddlTipoActividad_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlTipoActividad.SelectedIndexChanged
        Dim ListadoTipoActividad As List(Of TipoActividadBE) = bc.ListarTipoActividadVal(ddlTipoActividad.SelectedValue)
        LitarTipo2(ddlTipoActividad.SelectedValue)
    End Sub

    Private Sub GenerarCuadro()
        Dim id_tipo_1 As String = ddlTipoActividad.SelectedValue
        Dim id_tipo_2 As String = ddlTipoActividad2.SelectedValue
        texto1 = ddlTipoActividad.SelectedItem.Text
        texto2 = ddlTipoActividad2.SelectedItem.Text

        Dim Listado As List(Of SemaforoBE) = bc.ListarCorrelacionMensual(ddlComite.SelectedValue, id_tipo_1, id_tipo_2, Now.Year)
        gvwSemaforo.DataSource = Listado
        gvwSemaforo.DataBind()

        If chkCoeficiente.Checked Then
            gvwSemaforo.Columns.Item(8).Visible = True
        Else
            gvwSemaforo.Columns.Item(8).Visible = False
        End If

        If chkTasas.Checked Then
            gvwSemaforo.Columns.Item(3).Visible = True
            gvwSemaforo.Columns.Item(6).Visible = True
        Else
            gvwSemaforo.Columns.Item(3).Visible = False
            gvwSemaforo.Columns.Item(6).Visible = False
        End If
    End Sub


    'Private Sub GenerarSemaforo()
    '    Dim id_tipo_1 As String = String.Empty
    '    Dim id_tipo_2 As String = String.Empty

    '    For Each chkTipo As ListItem In cblTipos.Items
    '        If chkTipo.Selected Then
    '            If id_tipo_1 <> String.Empty Then
    '                id_tipo_2 = chkTipo.Value
    '                texto1 = chkTipo.Text
    '                Exit For
    '            Else
    '                id_tipo_1 = chkTipo.Value
    '                texto2 = chkTipo.Text
    '            End If
    '        End If
    '    Next

    '    Dim ListadoSemaforo As List(Of SemaforoBE) = bc.ListarSemaforoPorFechas(ddlComite.SelectedValue, id_tipo_1, id_tipo_2, "", "")
    '    gvwSemaforo.DataSource = ListadoSemaforo
    '    gvwSemaforo.DataBind()

    '    If ListadoSemaforo IsNot Nothing AndAlso ListadoSemaforo.Count > 0 Then
    '        lblMensaje.Visible = False
    '        divLeyenda.Visible = True
    '    Else
    '        lblMensaje.Text = "No se encontraron resultados"
    '        lblMensaje.Visible = True
    '        divLeyenda.Visible = False
    '    End If
    'End Sub

    Private Sub gvwSemaforo_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvwSemaforo.RowDataBound
        If e.Row.RowType = DataControlRowType.Header Then
            e.Row.Cells(2).Text = texto1 & "<br/>(Participantes %)"
            e.Row.Cells(5).Text = texto2 & "<br/>(Participantes %)"
        End If

        'Mes - Año - part1 - tasa1 - prom1 - part2 - tasa2 - prom2 - coef - conclusion - sugerencias


        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.RowIndex Mod 4 = 0 Then
                e.Row.Cells(0).Attributes.Add("rowspan", "4")
                e.Row.Cells(4).Attributes.Add("rowspan", "4")
                e.Row.Cells(7).Attributes.Add("rowspan", "4")
                e.Row.Cells(8).Attributes.Add("rowspan", "4")
                e.Row.Cells(9).Attributes.Add("rowspan", "4")
                e.Row.Cells(10).Attributes.Add("rowspan", "4")
            Else
                e.Row.Cells(0).Visible = False
                e.Row.Cells(4).Visible = False
                e.Row.Cells(7).Visible = False
                e.Row.Cells(8).Visible = False
                e.Row.Cells(9).Visible = False
                e.Row.Cells(10).Visible = False
            End If
        End If
    End Sub

End Class