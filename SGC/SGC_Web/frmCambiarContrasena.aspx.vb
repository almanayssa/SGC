Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmCambiarContrasena
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ibtnEnviar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ibtnEnviar.Click
        Dim oUsuario As UsuarioBE = bc.ObtenerUsuarioPorEmail(txtCorreo.Text.Trim)

        If oUsuario.id_usuario > 0 Then

        Else

        End If
    End Sub
End Class