Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmLogin

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If txtUsuario.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese su usuario"
        End If

        If txtContrasena.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese su contraseña"
        End If

        Return msg
    End Function


    Private Sub IniciarSesion()

        'If ValidarCamposRequeridos() <> String.Empty Then
        '    MessageBox.Show(ValidarCamposRequeridos, "Información")
        '    Exit Sub
        'End If

        'Dim oUsuarioLogueado As New UsuarioBE
        'oUsuarioLogueado = bc.ObtenerUsuario(txtUsuario.Text.Trim, txtContrasena.Text.Trim)

        'If oUsuarioLogueado.id_usuario = Nothing Then
        '    MessageBox.Show("Usuario o contraseña incorrectos", "Información")
        'Else
        Me.Hide()
        MDI.Show()
        'End If
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnEntrar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEntrar.Click
        IniciarSesion()
    End Sub

#End Region

End Class
