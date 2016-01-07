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
            ListarMes()
            ListarAnio()

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

        Dim ListadoSemaforo As List(Of SemaforoBE) = bc.ListarSemaforoPorMes(ddlComite.SelectedValue, id_tipo_1, id_tipo_2, String.Concat(ddlAnio.SelectedValue, ddlMes.SelectedValue))
        gvwSemaforo.DataSource = ListadoSemaforo
        gvwSemaforo.DataBind()

        Dim x As String = bc.ListarSemaforoVariables(ddlComite.SelectedValue, id_tipo_1, id_tipo_2, String.Concat(ddlAnio.SelectedValue, ddlMes.SelectedValue))
        Dim v As String()

        If x IsNot Nothing Then
            v = New String(5) {}
            v = x.Split(",")

            lblResultado.Text = "La media aritmetica de " & texto1 & "es: " & v(0) & "<br/>"
            lblResultado.Text &= "La media aritmetica de " & texto2 & "es: " & v(1) & "<br/>"
            lblResultado.Text &= "La covarianza de ambos es: " & v(2) & "<br/>"
            lblResultado.Text &= "La covarianza de " & texto1 & "es: " & v(3) & "<br/>"
            lblResultado.Text &= "La covarianza de " & texto2 & "es: " & v(4) & "<br/>"
            lblResultado.Text &= "El coeficiente de correlacion de ambos tipos es:" & v(5) & "<br/>"
            lblResultado.Text &= IIf(CDec(v(5)) > 0.5, "Se recomienda que se realicen en paralelo", IIf(CDec(v(5)) < 0.5, "No se recomienda que se realicen en paralelo", "Pueden realizarse en paralelo"))

        Else
            lblResultado.Text = ""
        End If

    End Sub

    Private Sub gvwSemaforo_RowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvwSemaforo.RowDataBound
        If e.Row.RowType = DataControlRowType.Header Then
            e.Row.Cells(1).Text = texto1
            e.Row.Cells(2).Text = texto2
        End If
    End Sub

    Private Sub ListarAnio()
        Dim id As String() = New String(1) {"2015", "2016"}
        Dim desc As String() = New String(1) {"2015", "2016"}

        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("desc")

        Dim dr As DataRow

        For i As Integer = 0 To 1
            dr = dt.NewRow()
            dr("id") = id(i)
            dr("desc") = desc(i)
            dt.Rows.Add(dr)
        Next

        dt.AcceptChanges()

        ddlAnio.DataSource = dt
        ddlAnio.DataTextField = "desc"
        ddlAnio.DataValueField = "id"
        ddlAnio.DataBind()

        ddlAnio.SelectedIndex = 0
    End Sub

    Private Sub ListarMes()
        Dim id As String() = New String(11) {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"}
        Dim desc As String() = New String(11) {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"}

        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("desc")

        Dim dr As DataRow

        For i As Integer = 0 To 11
            dr = dt.NewRow()
            dr("id") = id(i)
            dr("desc") = desc(i)
            dt.Rows.Add(dr)
        Next

        dt.AcceptChanges()

        ddlMes.DataSource = dt
        ddlMes.DataTextField = "desc"
        ddlMes.DataValueField = "id"
        ddlMes.DataBind()

        ddlMes.SelectedIndex = 0
    End Sub
End Class