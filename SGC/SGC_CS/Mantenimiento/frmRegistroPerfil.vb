Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroPerfil

    Dim bc As New BusinessController
    Private Perfil As PerfilUsuarioBE
    Private _id_perfil As Integer

#Region "Metodos Personalizados"

    Private Sub FormularioEnModoEdicion()
        tsbLimpiar.Visible = False
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = True

        txtNombre.Enabled = True
    End Sub

    Private Sub FormularioEnModoVista()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = False
        tsbEditar.Visible = True
        tsbEliminar.Visible = True
        tsbCancelar.Visible = False

        txtNombre.Enabled = False
    End Sub

    Private Sub CargarPerfil(ByVal id_perfil As Integer)
        Dim oPerfil As PerfilUsuarioBE = bc.ObtenerPerfil(id_perfil)
        Perfil = oPerfil
        txtCodigo.Text = oPerfil.id_perfil_usuario
        txtNombre.Text = oPerfil.nombre
    End Sub

    Private Sub LimpiarFormulario()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = False

        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty

        txtNombre.Enabled = True
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If txtNombre.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese un nombre"
        End If

        Return msg
    End Function

    Private Function GuardarPerfil() As Boolean
        Dim flag As Boolean = True

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        Dim affectedRows As Integer = 0
        Dim oPerfil As New PerfilUsuarioBE
        oPerfil.nombre = txtNombre.Text.Trim

        If txtCodigo.Text = String.Empty Then
            affectedRows = bc.InsertarPerfil(oPerfil)
        Else
            oPerfil.id_perfil_usuario = txtCodigo.Text
            affectedRows = bc.ActualizarPerfil(oPerfil)
        End If

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            If txtCodigo.Text = String.Empty Then
                txtCodigo.Text = affectedRows
                _id_perfil = affectedRows
                MessageBox.Show("El perfil se registró satisfactoriamente", "Información")
            Else
                _id_perfil = oPerfil.id_perfil_usuario
                MessageBox.Show("El perfil se actualizó satisfactoriamente", "Información")
            End If
        End If

        Return flag

    End Function

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarPerfil() Then
            LimpiarFormulario()
            CargarPerfil(_id_perfil)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub tsbEditar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEditar.Click
        FormularioEnModoEdicion()
    End Sub

    Private Sub tsbEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEliminar.Click
        If txtCodigo.Text.Trim <> String.Empty Then
            If MsgBox("Seguro que desea eliminar el perfil?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim ListadoUsuario As List(Of UsuarioBE) = bc.ListarUsuarios(CInt(txtCodigo.Text.Trim))

                If ListadoUsuario IsNot Nothing Then
                    If ListadoUsuario.Count > 0 Then
                        MessageBox.Show("El perfil no puede ser eliminado porque existen usuarios asignados al mismo", "Información")
                        Exit Sub
                    End If
                End If

                Dim affectedRows As Integer = 0
                affectedRows = bc.BorrarPerfil(CInt(txtCodigo.Text.Trim))

                If affectedRows = 0 Then
                    MessageBox.Show("Error al borrar", "Información")
                Else
                    MessageBox.Show("El perfil se eliminó satisfactoriamente", "Información")
                End If

                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tsbCancelar.Click
        If MsgBox("Seguro que desea cancelar la operación?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CargarPerfil(_id_perfil)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim frmBuscarPerfil As New frmBuscarPerfil
        frmBuscarPerfil.ShowDialog()

        If frmBuscarPerfil.PerfilSeleccionado IsNot Nothing Then
            tsbEditar.Visible = True
            tsbEliminar.Visible = True
            _id_perfil = frmBuscarPerfil.PerfilSeleccionado.id_perfil_usuario
            CargarPerfil(frmBuscarPerfil.PerfilSeleccionado.id_perfil_usuario)
            FormularioEnModoVista()
        End If
    End Sub

#End Region

End Class