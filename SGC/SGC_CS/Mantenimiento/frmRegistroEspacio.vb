Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroEspacio

    Dim bc As New BusinessController
    Private Espacio As EspacioBE
    Private _id_espacio As Integer

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboSede.ValueMember = "id_sede"
        cboSede.DisplayMember = "des_sede"

        cboLugar.ValueMember = "id_lugar"
        cboLugar.DisplayMember = "desc_lugar"

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub FormularioEnModoEdicion()
        tsbLimpiar.Visible = False
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = True

        cboSede.Enabled = True
        cboLugar.Enabled = True
        txtEspacio.Enabled = True
    End Sub

    Private Sub FormularioEnModoVista()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = False
        tsbEditar.Visible = True
        tsbEliminar.Visible = True
        tsbCancelar.Visible = False

        cboSede.Enabled = False
        cboLugar.Enabled = False
        txtEspacio.Enabled = False
    End Sub

    Private Sub ListarSedes()
        Dim ListadoSede As List(Of SedeBE) = bc.ListarSedes()
        cboSede.DataSource = Nothing
        cboSede.DataSource = ListadoSede
    End Sub

    Private Sub ListarLugares()
        Dim oLugar As New LugarBE
        oLugar.id_lugar = 0
        oLugar.desc_lugar = "- Seleccione -"

        Dim ListadoLugar As List(Of LugarBE) = bc.ListarLugares()
        ListadoLugar.Insert(0, oLugar)
        cboLugar.DataSource = Nothing
        cboLugar.DataSource = ListadoLugar
    End Sub

    Private Sub CargarEspacio(ByVal id_espacio As Integer)
        Dim oEspacio As EspacioBE = bc.ObtenerEspacio(id_espacio)
        Espacio = oEspacio
        txtCodigo.Text = oEspacio.id_espacio
        cboSede.SelectedValue = oEspacio.id_sede
        cboLugar.SelectedValue = oEspacio.id_lugar
        txtEspacio.Text = oEspacio.nombre
    End Sub

    Private Sub LimpiarFormulario()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = False

        txtCodigo.Text = String.Empty
        cboSede.SelectedIndex = 0
        cboLugar.SelectedIndex = 0
        txtEspacio.Text = String.Empty

        cboSede.Enabled = True
        cboLugar.Enabled = True
        txtEspacio.Enabled = True
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If cboSede.SelectedValue = "000" Then
            msg &= vbCrLf & "- Seleccione una sede"
        End If

        If cboLugar.SelectedValue = 0 Then
            msg &= vbCrLf & "- Seleccione un lugar"
        End If

        If txtEspacio.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese un nombre"
        End If

        Return msg
    End Function

    Private Function GuardarEspacio() As Boolean
        Dim flag As Boolean = True

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        Dim affectedRows As Integer = 0
        Dim oEspacio As New EspacioBE
        oEspacio.id_sede = cboSede.SelectedValue
        oEspacio.id_lugar = cboLugar.SelectedValue
        oEspacio.nombre = txtEspacio.Text.Trim

        If txtCodigo.Text = String.Empty Then
            oEspacio.id_estado_espacio = "EE0001" 'Disponible
            affectedRows = bc.InsertarEspacio(oEspacio)
        Else
            oEspacio.id_espacio = txtCodigo.Text
            affectedRows = bc.ActualizarEspacio(oEspacio)
        End If

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            If txtCodigo.Text = String.Empty Then
                txtCodigo.Text = affectedRows
                _id_espacio = affectedRows
                MessageBox.Show("El espacio se registró satisfactoriamente", "Información")
            Else
                _id_espacio = oEspacio.id_espacio
                MessageBox.Show("El espacio se actualizó satisfactoriamente", "Información")
            End If
        End If

        Return flag

    End Function

#End Region

#Region "Cargar"

    Private Sub frmRegistroEspacio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarSedes()
        ListarLugares()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarEspacio() Then
            LimpiarFormulario()
            CargarEspacio(_id_espacio)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub tsbEditar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEditar.Click
        FormularioEnModoEdicion()
    End Sub

    Private Sub tsbEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEliminar.Click
        If txtCodigo.Text.Trim <> String.Empty Then
            If MsgBox("Seguro que desea anular el espacio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.BorrarEspacio(CInt(txtCodigo.Text.Trim))

                If affectedRows = 0 Then
                    MessageBox.Show("Error al borrar", "Información")
                Else
                    MessageBox.Show("El espacio se anuló satisfactoriamente", "Información")
                End If

                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tsbCancelar.Click
        If MsgBox("Seguro que desea cancelar la operación?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CargarEspacio(_id_espacio)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim frmBuscarEspacio As New frmBuscarEspacio
        frmBuscarEspacio.ShowDialog()

        If frmBuscarEspacio.EspacioSeleccionado IsNot Nothing Then
            tsbEditar.Visible = True
            tsbEliminar.Visible = True
            _id_espacio = frmBuscarEspacio.EspacioSeleccionado.id_espacio
            CargarEspacio(frmBuscarEspacio.EspacioSeleccionado.id_espacio)
            FormularioEnModoVista()
        End If
    End Sub

#End Region

End Class
