Imports SGC.Model.Entidades
Imports SGC.Controller
Imports System.Net
Imports System.Net.Mail

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
            EnviarEmail(oUsuario)
        Else
            lblMensaje.Text = "El correo ingresado no se encuentra registrado en el sistema"
            lblMensaje.Visible = True
        End If

    End Sub

    Private Sub EnviarEmail(ByRef oUsuario As UsuarioBE)
        Dim remitente = New MailAddress("accelbosque@gmail.com", "Asociación Country Club El Bosque")
        Dim destinatario = New MailAddress(oUsuario.email, oUsuario.nombres & " " & oUsuario.ape_pat)
        Const fromPassword As String = "elbosque"
        Const asunto As String = "Solicitud de envío de contraseña"
        Dim descripcion As String = "Estimado(a) socio(a)<br/><br/>La presente es para indicarle que su contraseña actual es: <b>" & _
            oUsuario.password & "</b>.<br/>En caso desee modificarla, ingresar al sistema y seleccionar la opción <b>" & _
            "Cambiar Contraseña</b>.<br/><br/>Atentamente,<br/><b>ACC El Bosque</b>"

        Dim smtp As New SmtpClient

        With smtp
            .Host = "smtp.gmail.com"
            .Port = 587
            .EnableSsl = True
            .DeliveryMethod = SmtpDeliveryMethod.Network
            .UseDefaultCredentials = False
            .Credentials = New NetworkCredential(remitente.Address, fromPassword)
        End With

        Using mensaje As New MailMessage(remitente, destinatario)
            With mensaje
                .Subject = asunto
                .Body = descripcion
                .IsBodyHtml = True
            End With

            Try
                smtp.Send(mensaje)
                lblMensaje.Text = "Se envió contraseña al correo ingresado"
                lblMensaje.Visible = True
            Catch ex As Exception
                lblMensaje.Text = "Error al enviar correo"
                lblMensaje.Visible = True
            End Try

        End Using

    End Sub

End Class