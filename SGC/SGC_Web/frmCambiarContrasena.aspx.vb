Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmCambiarContrasena
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("ubosque") = "" Then
            Response.Redirect("index.aspx", True)
        End If
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

    Protected Sub ibtnModificar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ibtnModificar.Click
        If IsGroupValid(ibtnModificar.ValidationGroup) = False Then
            Exit Sub
        End If

        Dim oUsuario As UsuarioBE = Sesiones.UsuarioLogueado

        If lblMensaje.Text <> String.Empty Then
            Exit Sub
        Else
            Dim affectedRows As Integer = 0
            oUsuario.password = txtNuevaContrasena.Text.Trim

            affectedRows = bc.ActualizarUsuario(oUsuario)

            If affectedRows = 0 Then
                lblMensaje.Text = "Error al actualizar"
                lblMensaje.Visible = True
            Else
                lblMensaje.Text = "Se actualizó la contraseña correctamente"
                lblMensaje.Visible = True
            End If
        End If
    End Sub

    Protected Sub ValidarContrasenaActual(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvContrasenaActual.ServerValidate
        Dim oUsuario As UsuarioBE = Sesiones.UsuarioLogueado

        If txtContrasenaActual.Text.Trim <> oUsuario.password Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    Protected Sub ValidarNuevaContrasena(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvContrasenaActual.ServerValidate
        If txtNuevaContrasena.Text.Trim <> txtNuevaContrasena2.Text.Trim Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub
End Class