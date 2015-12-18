Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroUsuario

    Dim bc As New BusinessController
    Private Usuario As UsuarioBE
    Private _id_usuario As String

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboPerfil.ValueMember = "id_Perfil_Usuario"
        cboPerfil.DisplayMember = "Nombre"

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub FormularioEnModoEdicion()
        tsbLimpiar.Visible = False
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = True

        txtUsuario.Enabled = True
        txtContrasenia.Enabled = True
        txtEmail.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        cboPerfil.Enabled = True
    End Sub

    Private Sub FormularioEnModoVista()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = False
        tsbEditar.Visible = True
        tsbEliminar.Visible = True
        tsbCancelar.Visible = False

        txtUsuario.Enabled = False
        txtContrasenia.Enabled = False
        txtEmail.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        cboPerfil.Enabled = False
    End Sub

    Private Sub ListarPerfiles()
        Dim oPerfil As New PerfilUsuarioBE
        oPerfil.id_perfil_usuario = 0
        oPerfil.nombre = "- Seleccione -"

        Dim ListadoPerfil As List(Of PerfilUsuarioBE) = bc.ListarPerfiles()
        ListadoPerfil.Insert(0, oPerfil)
        cboPerfil.DataSource = Nothing
        cboPerfil.DataSource = ListadoPerfil
    End Sub

    Private Sub CargarUsuario(ByVal id_usuario As String)
        Dim oUsuario As UsuarioBE = bc.ObtenerUsuarioPorId(id_usuario)
        Usuario = oUsuario
        txtCodigo.Text = oUsuario.id_usuario
        txtUsuario.Text = oUsuario.username
        txtContrasenia.Text = oUsuario.password
        txtEmail.Text = oUsuario.email
        txtNombre.Text = oUsuario.nombres
        txtApellido.Text = oUsuario.ape_pat
        cboPerfil.SelectedValue = oUsuario.id_perfil_usuario
    End Sub

    Private Sub LimpiarFormulario()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = False

        txtCodigo.Text = String.Empty
        txtUsuario.Text = String.Empty
        txtContrasenia.Text = String.Empty
        txtEmail.Text = String.Empty
        txtNombre.Text = String.Empty
        txtApellido.Text = String.Empty
        cboPerfil.SelectedIndex = 0

        txtUsuario.Enabled = True
        txtContrasenia.Enabled = True
        txtEmail.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        cboPerfil.Enabled = True
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If txtUsuario.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese un usuario"
        End If

        If txtContrasenia.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese una contraseña"
        End If

        If txtEmail.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese un email"
        End If

        If txtNombre.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese un nombre"
        End If

        If txtApellido.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese un apellido"
        End If

        If cboPerfil.SelectedValue = 0 Then
            msg &= vbCrLf & "- Seleccione un perfil"
        End If

        Return msg
    End Function

    Private Function ValidarUsuarioCorreo() As String
        Dim msg As String = String.Empty
        Dim username As UsuarioBE = bc.ObtenerUsuarioPorUser(txtUsuario.Text.Trim)
        Dim email As UsuarioBE = bc.ObtenerUsuarioPorEmail(txtEmail.Text.Trim)

        If username IsNot Nothing Then
            If username.id_usuario IsNot Nothing Then
                msg &= vbCrLf & "- El usuario ingresado ya se encuentra registrado"
            End If
        End If

        If email IsNot Nothing Then
            If email.id_usuario IsNot Nothing Then
                msg &= vbCrLf & "- El email ingresado ya se encuentra registrado"
            End If
        End If

        Return msg
    End Function

    Private Function GuardarUsuario() As Boolean
        Dim flag As Boolean = True

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        If txtCodigo.Text = String.Empty Then
            If ValidarUsuarioCorreo() <> String.Empty Then
                MessageBox.Show(ValidarUsuarioCorreo, "Información")
                flag = False
                Return flag
                Exit Function
            End If
        End If

        Dim affectedRows As String = String.Empty
        Dim oUsuario As New UsuarioBE
        oUsuario.username = txtUsuario.Text.Trim
        oUsuario.password = txtContrasenia.Text.Trim
        oUsuario.email = txtEmail.Text.Trim
        oUsuario.nombres = txtNombre.Text.Trim
        oUsuario.ape_pat = txtApellido.Text.Trim
        oUsuario.id_perfil_usuario = cboPerfil.SelectedValue

        If txtCodigo.Text = String.Empty Then
            oUsuario.id_est_usu = "01" 'Activo
            affectedRows = bc.InsertarUsuario(oUsuario)
        Else
            oUsuario.id_usuario = txtCodigo.Text
            affectedRows = bc.ActualizarUsuario(oUsuario).ToString()
        End If

        If affectedRows = String.Empty Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            If txtCodigo.Text = String.Empty Then
                txtCodigo.Text = affectedRows
                _id_usuario = affectedRows
                MessageBox.Show("El usuario se registró satisfactoriamente", "Información")
            Else
                _id_usuario = oUsuario.id_usuario
                MessageBox.Show("El usuario se actualizó satisfactoriamente", "Información")
            End If
        End If

        Return flag

    End Function

#End Region

#Region "Cargar"

    Private Sub frmRegistroUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarPerfiles()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarUsuario() Then
            LimpiarFormulario()
            CargarUsuario(_id_usuario)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub tsbEditar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEditar.Click
        FormularioEnModoEdicion()
    End Sub

    Private Sub tsbEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEliminar.Click
        If txtCodigo.Text.Trim <> String.Empty Then
            If MsgBox("Seguro que desea anular el usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.BorrarUsuario(CInt(txtCodigo.Text.Trim))

                If affectedRows = 0 Then
                    MessageBox.Show("Error al borrar", "Información")
                Else
                    MessageBox.Show("El usuario se anuló satisfactoriamente", "Información")
                End If

                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tsbCancelar.Click
        If MsgBox("Seguro que desea cancelar la operación?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CargarUsuario(_id_usuario)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim frmBuscarUsuario As New frmBuscarUsuario
        frmBuscarUsuario.ShowDialog()

        If frmBuscarUsuario.UsuarioSeleccionado IsNot Nothing Then
            tsbEditar.Visible = True
            tsbEliminar.Visible = True
            _id_usuario = frmBuscarUsuario.UsuarioSeleccionado.id_usuario
            CargarUsuario(frmBuscarUsuario.UsuarioSeleccionado.id_usuario)
            FormularioEnModoVista()
        End If
    End Sub

#End Region

End Class