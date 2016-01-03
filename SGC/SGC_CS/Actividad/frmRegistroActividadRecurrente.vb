Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroActividadRecurrente

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        cboTipo.ValueMember = "id_tipo_act"
        cboTipo.DisplayMember = "desc_tipo"

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarComites()
        Dim oComite As New ComiteBE
        oComite.id_comite = "000"
        oComite.nombre = "- Seleccione -"

        Dim ListadoComites As List(Of ComiteBE) = bc.ListarComites()
        ListadoComites.Insert(0, oComite)
        cboComite.DataSource = Nothing
        cboComite.DataSource = ListadoComites
    End Sub

    Private Sub ListarTipoActividad()
        Dim ListadoTipoActividad As List(Of TipoActividadBE) = bc.ListarTipoActividad()
        cboTipo.DataSource = Nothing
        cboTipo.DataSource = ListadoTipoActividad
    End Sub

    Private Sub LimpiarFormulario()
        cboComite.SelectedIndex = 0
        cboTipo.SelectedIndex = 0
        cboCategoria.SelectedIndex = -1
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        cboTipoRecurrencia.SelectedIndex = 0
        nudDiasSemanas.Value = 1
        nudVacantes.Value = 1
        nudDiasSemanas.Value = 1
        chkLunes.Checked = False
        chkMartes.Checked = False
        chkMiercoles.Checked = False
        chkJueves.Checked = False
        chkViernes.Checked = False
        chkSabado.Checked = False
        chkDomingo.Checked = False
        dtpHoraInicio.Value = Now
        dtpHoraFin.Value = Now
        nudNumeroDia.Value = 1
        nudNumeroMes.Value = 1
        dtpFechaInicio.Value = Now
        dtpFechaFin.Value = Now

    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If cboComite.SelectedValue = "000" Then
            msg &= vbCrLf & "- Seleccione un comité"
        End If

        If cboTipo.SelectedValue = "00" Then
            msg &= vbCrLf & "- Seleccione un tipo"
        End If

        If cboCategoria.Enabled Then
            If cboCategoria.SelectedValue = 0 Then
                msg &= vbCrLf & "- Seleccione una categoría"
            End If
        End If

        If txtNombre.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese un nombre"
        End If

        If txtDescripcion.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese una descripción"
        End If

        If cboTipoRecurrencia.SelectedIndex >= 0 Then
            If cboTipoRecurrencia.SelectedItem = "Semanal" Then
                Dim flg As Boolean = False

                If chkLunes.Checked Then
                    flg = True
                End If

                If chkMartes.Checked Then
                    flg = True
                End If

                If chkMiercoles.Checked Then
                    flg = True
                End If

                If chkJueves.Checked Then
                    flg = True
                End If

                If chkViernes.Checked Then
                    flg = True
                End If

                If chkSabado.Checked Then
                    flg = True
                End If

                If chkDomingo.Checked Then
                    flg = True
                End If

                If flg = False Then
                    msg &= vbCrLf & "- Seleccione un día al menos"
                End If
            End If
        Else
            msg &= vbCrLf & "- Seleccione el tipo de recurrencia"
        End If

        Return msg
    End Function

    Private Function GuardarActividad() As Boolean
        Dim flag As Boolean = True

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        Dim affectedRows As Integer = 0
        Dim oActividadRecurrente As New ActividadRecurrenteBE
        If cboTipoRecurrencia.SelectedItem = "Diaria" Then
            oActividadRecurrente.tipo = "D"
            oActividadRecurrente.num_rep = nudDiasSemanas.Value
        ElseIf cboTipoRecurrencia.SelectedItem = "Semanal" Then
            oActividadRecurrente.tipo = "S"
            oActividadRecurrente.num_rep = nudDiasSemanas.Value
            oActividadRecurrente.chk_dom = chkDomingo.Checked
            oActividadRecurrente.chk_lun = chkLunes.Checked
            oActividadRecurrente.chk_mar = chkMartes.Checked
            oActividadRecurrente.chk_mie = chkMiercoles.Checked
            oActividadRecurrente.chk_jue = chkJueves.Checked
            oActividadRecurrente.chk_vie = chkViernes.Checked
            oActividadRecurrente.chk_sab = chkSabado.Checked
        Else
            oActividadRecurrente.tipo = "M"
            oActividadRecurrente.num_rep = nudNumeroMes.Value
            oActividadRecurrente.dia_mes = nudNumeroDia.Value
        End If
        oActividadRecurrente.fecha_ini = dtpFechaInicio.Value
        oActividadRecurrente.fecha_fin = dtpFechaFin.Value
        oActividadRecurrente.hora_ini = dtpHoraInicio.Value.TimeOfDay
        oActividadRecurrente.hora_fin = dtpHoraFin.Value.TimeOfDay
        oActividadRecurrente.monto_pago = nudPago.Value
        oActividadRecurrente.id_cattipo_act = cboCategoria.SelectedValue
        oActividadRecurrente.id_comite = cboComite.SelectedValue
        oActividadRecurrente.id_tipo_act = cboTipo.SelectedValue
        oActividadRecurrente.descripcion = txtDescripcion.Text.Trim
        oActividadRecurrente.nombre = txtNombre.Text.Trim
        oActividadRecurrente.vacantes = nudVacantes.Value

        affectedRows = bc.InsertarActividadRecurrente(oActividadRecurrente)

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            MessageBox.Show("La actividad se registró satisfactoriamente", "Información")
        End If

        Return flag

    End Function

#End Region

#Region "Cargar"

    Private Sub frmRegistroActividadRecurrente_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarTipoActividad()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarActividad() Then
            LimpiarFormulario()
        End If
    End Sub

    Private Sub cboTipo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedValueChanged
        If cboTipo.SelectedValue IsNot Nothing Then
            If cboTipo.SelectedValue = "00" Then
                cboCategoria.Enabled = False
                cboCategoria.DataSource = Nothing
            Else
                Dim ListadoCategorias As List(Of CatTipoActividadBE) = bc.ListarCatTipoActividad(cboTipo.SelectedValue)

                If ListadoCategorias.Count = 0 Then
                    cboCategoria.Enabled = False
                    cboCategoria.DataSource = Nothing
                Else
                    cboCategoria.Enabled = True
                    Dim oCategoriaActividad As New CatTipoActividadBE
                    oCategoriaActividad.id_cattipo_act = 0
                    oCategoriaActividad.descripcion = "- Seleccione -"

                    ListadoCategorias.Insert(0, oCategoriaActividad)
                    cboCategoria.DataSource = Nothing
                    cboCategoria.DataSource = ListadoCategorias
                    cboCategoria.ValueMember = "id_cattipo_act"
                    cboCategoria.DisplayMember = "descripcion"
                End If
            End If
        End If
    End Sub

#End Region

#Region "Recurrencia"

    Private Sub cboTipoRecurrencia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoRecurrencia.SelectedValueChanged
        If cboTipoRecurrencia.SelectedItem = "Diaria" Then
            pnlRepeticiones.Visible = True
            lblDiasSemanas.Text = "día(s)"
            pnlSemanal.Visible = False
            pnlMensual.Visible = False
            pnlHoras.Left = 103
            pnlHoras.Top = 82
            pnlDuracionRecurrencia.Top = 124
        ElseIf cboTipoRecurrencia.SelectedItem = "Semanal" Then
            pnlRepeticiones.Visible = True
            lblDiasSemanas.Text = "semanas(s), los días"
            pnlSemanal.Visible = True
            pnlMensual.Visible = False
            pnlHoras.Left = 103
            pnlHoras.Top = 149
            pnlDuracionRecurrencia.Top = 179
        Else
            pnlRepeticiones.Visible = False
            pnlSemanal.Visible = False
            pnlMensual.Visible = True
            pnlHoras.Left = 9
            pnlHoras.Top = 121
            pnlDuracionRecurrencia.Top = 151
        End If
    End Sub

#End Region

End Class
