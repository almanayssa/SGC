Public Class Mensaje
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            lblMessagePage.Text = Sesiones.MsgTitulo
            lblMessageDescription.Text = Sesiones.MsgDescripcion
        End If
    End Sub

    Protected Sub ibtContinue_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ibtContinue.Click
        Response.Redirect(Sesiones.MsgContinuar, True)
    End Sub
End Class