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

    Private Sub FormularioEnModoEdicion()
        cboComite.Enabled = True
        cboTipo.Enabled = True
        If cboCategoria.DataSource IsNot Nothing Then
            cboCategoria.Enabled = True
        Else
            cboCategoria.Enabled = False
        End If
        txtNombre.Enabled = True
        txtDescripcion.Enabled = True
        nudPago.Enabled = True
    End Sub

    Private Sub FormularioEnModoVista()
        cboComite.Enabled = False
        cboTipo.Enabled = False
        cboCategoria.Enabled = False
        txtNombre.Enabled = False
        txtDescripcion.Enabled = False
        nudPago.Enabled = False
        nudVacantes.Enabled = False
    End Sub

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

    Private Sub ListarOrdinal()
        Dim id As Integer() = New Integer(4) {1, 2, 3, 4, 0}
        Dim desc As String() = New String(4) {"primer", "segundo", "tercer", "cuarto", "último"}

        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("desc")

        Dim dr As DataRow

        For i As Integer = 0 To 4
            dr = dt.NewRow()
            dr("id") = id(i)
            dr("desc") = desc(i)
            dt.Rows.Add(dr)
        Next

        dt.AcceptChanges()

        cboOrdinal.DataSource = dt
        cboOrdinal.DisplayMember = "desc"
        cboOrdinal.ValueMember = "id"
    End Sub

    Private Sub ListarDiasSemana()
        Dim id As Integer() = New Integer(6) {DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday}
        Dim desc As String() = New String(6) {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"}

        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("desc")

        Dim dr As DataRow

        For i As Integer = 0 To 6
            dr = dt.NewRow()
            dr("id") = id(i)
            dr("desc") = desc(i)
            dt.Rows.Add(dr)
        Next

        dt.AcceptChanges()

        cboNombreDia.DataSource = dt
        cboNombreDia.DisplayMember = "desc"
        cboNombreDia.ValueMember = "id"
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
        rbtnDia.Checked = True
        dtpHoraInicio.Value = Now
        dtpHoraFin.Value = Now
        nudNumeroDia.Value = 1
        nudNumeroMes.Value = 1
        nudNumeroMes2.Value = 1
        cboOrdinal.SelectedIndex = 0
        cboNombreDia.SelectedIndex = 0
        rbtnDia.Checked = True
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

        Return msg
    End Function

    'Private Function GuardarActividad() As Boolean
    '    Dim flag As Boolean = True

    '    If ValidarCamposRequeridos() <> String.Empty Then
    '        MessageBox.Show(ValidarCamposRequeridos, "Información")
    '        flag = False
    '        Return flag
    '        Exit Function
    '    End If

    '    Dim affectedRows As Integer = 0
    '    Dim oActividadRecurrente As New ActividadRecurrenteBE
    '    oActividad.fec_ini = Today
    '    oActividad.fec_fin = Today
    '    oActividad.hora_ini = Now.TimeOfDay
    '    oActividad.hora_fin = Now.TimeOfDay
    '    oActividad.monto_pago = nudPago.Value
    '    oActividad.id_cattipo_act = cboCategoria.SelectedValue
    '    oActividad.id_comite = cboComite.SelectedValue
    '    oActividad.id_tipo_act = cboTipo.SelectedValue
    '    oActividad.descripcion = txtDescripcion.Text.Trim
    '    oActividad.nombre = txtNombre.Text.Trim
    '    'oActividad.flg_plan_anual = chkPlanAnual.Checked
    '    'oActividad.flg_web = chkWeb.Checked
    '    oActividad.tipo_inscripcion = "A"
    '    oActividad.vacantes = nudVacantes.Value

    '    'If Actividad IsNot Nothing Then
    '    '    oActividad.id_actividad_recurrente = Actividad.id_actividad_recurrente
    '    '    oActividad.ActividadRecurrente = Actividad.ActividadRecurrente
    '    'End If

    '    'Dim startDateTime As DateTime = Nothing
    '    'Dim endDateTime As DateTime = Nothing

    '    'oActividad.fec_ini = startDateTime.Date
    '    'oActividad.hora_ini = startDateTime.TimeOfDay
    '    'oActividad.fec_fin = endDateTime.Date
    '    'oActividad.hora_fin = endDateTime.TimeOfDay

    '    If txtCodigo.Text = String.Empty Then
    '        oActividad.id_estado = "EST001" 'Registrada
    '        affectedRows = bc.InsertarActividad(oActividad)
    '    Else
    '        oActividad.id_actividad = txtCodigo.Text
    '        affectedRows = bc.ActualizarActividad(oActividad)
    '    End If

    '    If affectedRows = 0 Then
    '        MessageBox.Show("Error al grabar", "Información")
    '        flag = False
    '    Else
    '        If txtCodigo.Text = String.Empty Then
    '            txtCodigo.Text = affectedRows
    '            _id_actividad = affectedRows
    '            MessageBox.Show("La actividad se registró satisfactoriamente", "Información")
    '        Else
    '            _id_actividad = oActividad.id_actividad
    '            MessageBox.Show("La actividad se actualizó satisfactoriamente", "Información")
    '        End If
    '    End If

    '    Return flag

    'End Function

#End Region

#Region "Cargar"

    Private Sub frmRegistroActividadRecurrente_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarTipoActividad()
        ListarOrdinal()
        ListarDiasSemana()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
        FormularioEnModoEdicion()
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        'If GuardarActividad() Then
        '    LimpiarFormulario()
        '    FormularioEnModoVista()
        'End If
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

    Private Sub rbtnDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDia.CheckedChanged
        If rbtnDia.Checked Then
            nudNumeroDia.Enabled = True
            nudNumeroMes.Enabled = True
            cboOrdinal.Enabled = False
            cboNombreDia.Enabled = False
            nudNumeroMes2.Enabled = False
        Else
            nudNumeroDia.Enabled = False
            nudNumeroMes.Enabled = False
            cboOrdinal.Enabled = True
            cboNombreDia.Enabled = True
            nudNumeroMes2.Enabled = True
        End If
    End Sub

    Private Sub rbntEl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbntEl.CheckedChanged
        If rbntEl.Checked Then
            nudNumeroDia.Enabled = False
            nudNumeroMes.Enabled = False
            cboOrdinal.Enabled = True
            cboNombreDia.Enabled = True
            nudNumeroMes2.Enabled = True
        Else
            nudNumeroDia.Enabled = True
            nudNumeroMes.Enabled = True
            cboOrdinal.Enabled = False
            cboNombreDia.Enabled = False
            nudNumeroMes2.Enabled = False
        End If
    End Sub

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
