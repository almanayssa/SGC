Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmSemaforoPorMes
    Inherits System.Web.UI.Page

    Private bc As New BusinessController
    Dim texto1 As String
    Dim texto2 As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarComites()
            ListarTipoActividad()

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
        ListadoTipoActividad.RemoveAt(0)
        cblTipos.DataSource = ListadoTipoActividad
        cblTipos.DataValueField = "id_tipo_act"
        cblTipos.DataTextField = "desc_tipo"
        cblTipos.DataBind()
    End Sub

    Protected Sub lbtnGenerar_Click(sender As Object, e As EventArgs) Handles lbtnGenerar.Click
        If ValidarCamposRequeridos().Trim <> String.Empty Then
            lblMensaje.Visible = True
            lblMensaje.Text = ValidarCamposRequeridos()
            Exit Sub
        End If

        lblMensaje.Visible = False
        GenerarSemaforo()
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If ddlComite.SelectedValue = "000" Then
            msg &= "<br/>- Seleccione un comité"
        End If

        msg &= ValidarTipos()

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
        Else
            If count > 2 Then
                msg &= "<br/>- Seleccione máximo dos tipos"
            End If
        End If

        Return msg
    End Function

    Private Sub GenerarSemaforo()
        Dim id_tipo_1 As String = String.Empty
        Dim id_tipo_2 As String = String.Empty

        For Each chkTipo As ListItem In cblTipos.Items
            If chkTipo.Selected Then
                If id_tipo_1 <> String.Empty Then
                    id_tipo_2 = chkTipo.Value
                    texto1 = chkTipo.Text
                    Exit For
                Else
                    id_tipo_1 = chkTipo.Value
                    texto2 = chkTipo.Text
                End If
            End If
        Next

        Dim ListadoSemaforo As List(Of SemaforoBE) = bc.ListarSemaforoPorMes(ddlComite.SelectedValue, id_tipo_1, id_tipo_2, "201501")
        gvwSemaforo.DataSource = ListadoSemaforo
        gvwSemaforo.DataBind()

        Dim x As String = bc.ListarSemaforoVariables(ddlComite.SelectedValue, id_tipo_1, id_tipo_2, "201501")
        Dim v As String() = New String(5) {}
        v = x.Split(",")

        lblResultado.Text = "La media aritmetica de " & texto1 & "es:" & v(0) & "<br/>"
        lblResultado.Text &= "La media aritmetica de " & texto2 & "es:" & v(1) & "<br/>"
        lblResultado.Text &= "La covarianza de ambos es:" & v(2) & "<br/>"
        lblResultado.Text &= "La covarianza de " & texto1 & "es:" & v(3) & "<br/>"
        lblResultado.Text &= "La covarianza de " & texto2 & "es:" & v(4) & "<br/>"
        lblResultado.Text &= "El coeficiente de correlacion de ambos es:" & v(4) & "<br/>"
        lblResultado.Text &= IIf(CDec(v(4)) > 0.5, "Recomendado", IIf(CDec(v(4)) < 0.5, "No recomendado", "Indiferente"))

    End Sub

    Private Sub gvwSemaforo_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvwSemaforo.RowDataBound
        If e.Row.RowType = DataControlRowType.Header Then
            e.Row.Cells(1).Text = texto1
            e.Row.Cells(2).Text = texto2
        End If
    End Sub
End Class