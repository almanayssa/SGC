Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRecuperarContrasena
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Function IsGroupValid(sValidationGroup As String) As Boolean
        For Each validator As BaseValidator In Page.Validators
            If validator.ValidationGroup = sValidationGroup Then
                Dim fValid As Boolean = validator.IsValid
                If fValid Then
                    validator.Validate()
                    fValid = validator.IsValid
                    validator.IsValid = True
                End If
                If Not fValid Then
                    Return False
                End If

            End If
        Next
        Return True
    End Function

    Protected Sub ibtnEnviar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ibtnEnviar.Click
        If IsGroupValid(ibtnEnviar.ValidationGroup) = False Then
            Exit Sub
        End If

        Dim oUsuario As UsuarioBE = bc.ObtenerUsuarioPorEmail(txtCorreo.Text.Trim)

        If oUsuario IsNot Nothing AndAlso oUsuario.id_usuario <> String.Empty Then
            Dim affectedRows As Integer = 0

            affectedRows = bc.ActualizarUsuario(oUsuario)

            If affectedRows = 0 Then
                lblMensaje.Text = "Error al enviar correo"
                lblMensaje.Visible = True
            Else
                lblMensaje.Text = "Se envió contraseña al correo ingresado"
                lblMensaje.Visible = True
            End If
        Else
            lblMensaje.Text = "El correo ingresado no se encuentra registrado en el sistema"
            lblMensaje.Visible = True
        End If
    End Sub
End Class