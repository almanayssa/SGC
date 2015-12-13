Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroActividad

    Dim bc As New BusinessController
    Private Actividad As ActividadBE
    Private ListadoTipoPersonal As List(Of TipoPersonalBE)
    Private ListadoRecursos As List(Of RecursoBE)
    Private ListadoRestricciones As List(Of RestriccionesBE)
    Private oPersonalPendiente As TipoPersonalBE
    Private oRecursoPendiente As RecursoBE
    Private _id_actividad As Integer


#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        cboTipo.ValueMember = "id_tipo_act"
        cboTipo.DisplayMember = "desc_tipo"

        dgvTipoPersonal.AutoGenerateColumns = False
        dgvRecursos.AutoGenerateColumns = False
        dgvRestricciones.AutoGenerateColumns = False

        colDescripcionPersonal.DataPropertyName = "descripcion"
        colCantidadPersonal.DataPropertyName = "cantidad"

        colDescripcionRecurso.DataPropertyName = "descripcion"
        colCantidadRecurso.DataPropertyName = "cantidad"

        colDescripcionRestriccion.DataPropertyName = "descripcion"
        colCondicionRestriccion.DataPropertyName = "signo"
        colCantidadRestriccion.DataPropertyName = "valor"

        colRestriccionID.DataPropertyName = "id_restriccion"
        colDescripcionRestriccion.DataPropertyName = "descripcion"
        colFlgCondicion.DataPropertyName = "flg_condicion"
    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub FormularioEnModoEdicion()
        tsbLimpiar.Visible = False
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = True
        tsbReprogramacion.Visible = False

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

        btnBuscarPersonal.Enabled = True
        btnAgregarTipoPersonal.Enabled = True
        btnQuitarTipoPersonal.Enabled = True
        txtCantidadPersonal.Enabled = True
        btnBuscarRecurso.Enabled = True
        btnAgregarRecurso.Enabled = True
        btnQuitarRecurso.Enabled = True
        txtCantidadRecurso.Enabled = True

        dgvRestricciones.ReadOnly = False
    End Sub

    Private Sub FormularioEnModoVista()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = False
        tsbEditar.Visible = True
        tsbEliminar.Visible = True
        tsbCancelar.Visible = False
        tsbReprogramacion.Visible = True

        cboComite.Enabled = False
        cboTipo.Enabled = False
        cboCategoria.Enabled = False
        txtNombre.Enabled = False
        txtDescripcion.Enabled = False
        nudPago.Enabled = False
        nudVacantes.Enabled = False

        btnBuscarPersonal.Enabled = False
        btnAgregarTipoPersonal.Enabled = False
        btnQuitarTipoPersonal.Enabled = False
        txtCantidadPersonal.Enabled = False
        btnBuscarRecurso.Enabled = False
        btnAgregarRecurso.Enabled = False
        btnQuitarRecurso.Enabled = False
        txtCantidadRecurso.Enabled = False
        dgvRestricciones.ReadOnly = True
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

    Private Sub ListarRestricciones()
        Dim ListadoRestricciones As List(Of RestriccionesBE) = bc.ListarRestricciones()
        dgvRestricciones.DataSource = Nothing
        dgvRestricciones.DataSource = ListadoRestricciones
    End Sub

    Private Sub ListarSignos()
        Dim ListadoSignos As List(Of SignosBE) = bc.ListarSignos()
        Dim colCondicionRestriccion As DataGridViewComboBoxColumn
        colCondicionRestriccion = dgvRestricciones.Columns("colCondicionRestriccion")
        colCondicionRestriccion.DataSource = ListadoSignos
        colCondicionRestriccion.ValueMember = "id_signo"
        colCondicionRestriccion.DisplayMember = "signo"
    End Sub

    Private Sub CargarActividad(ByVal id_actividad As Integer)
        Dim oActividad As ActividadBE = bc.CargarActividadCabecera(id_actividad)
        Actividad = oActividad
        txtCodigo.Text = oActividad.id_actividad
        cboComite.SelectedValue = oActividad.id_comite
        cboTipo.SelectedValue = oActividad.id_tipo_act
        If oActividad.id_cattipo_act IsNot Nothing Then
            cboCategoria.SelectedValue = oActividad.id_cattipo_act
        End If
        txtNombre.Text = oActividad.nombre
        txtDescripcion.Text = oActividad.descripcion
        nudPago.Value = oActividad.monto_pago

        ListarTipoPersonalXActividad()
        ListarRecursosXActividad()
        ListarRestriccionesXActividad()
    End Sub

    Private Sub CargarTipoPersonal(ByRef oTipoPersonal As TipoPersonalBE)
        txtDescripcionPersonal.Text = oTipoPersonal.descripcion
    End Sub

    Private Sub CargarRecurso(ByRef oRecurso As RecursoBE)
        txtDescripcionRecurso.Text = oRecurso.descripcion
    End Sub

    Private Function ValidarAgregarTipoPersonal() As String
        Dim msg As String = String.Empty

        If txtDescripcionPersonal.Text = String.Empty Then
            msg &= vbCrLf & "- Seleccione un tipo de personal"
        End If

        If txtCantidadPersonal.Text = String.Empty Then
            msg &= vbCrLf & "- Ingrese una cantidad para el tipo de personal"
        Else
            If CInt(txtCantidadPersonal.Text) = 0 Then
                msg &= vbCrLf & "- La cantidad debe ser mayor a cero (0)"
            End If
        End If

        Return msg
    End Function

    Private Function ValidarAgregarRecurso() As String
        Dim msg As String = String.Empty

        If txtDescripcionRecurso.Text = String.Empty Then
            msg &= vbCrLf & "- Seleccione un recurso"
        End If

        If txtCantidadRecurso.Text = String.Empty Then
            msg &= vbCrLf & "- Ingrese una cantidad para el recurso"
        Else
            If CInt(txtCantidadRecurso.Text) = 0 Then
                msg &= vbCrLf & "- La cantidad debe ser mayor a cero (0)"
            End If
        End If

        Return msg
    End Function

    Private Sub ListarTipoPersonalXActividad()
        ListadoTipoPersonal = bc.ListarTipoPersonalXActividad(CInt(txtCodigo.Text.Trim))
        dgvTipoPersonal.DataSource = Nothing
        dgvTipoPersonal.DataSource = ListadoTipoPersonal
    End Sub

    Private Sub ListarRecursosXActividad()
        ListadoRecursos = bc.ListarRecursosXActividad(CInt(txtCodigo.Text.Trim))
        dgvRecursos.DataSource = Nothing
        dgvRecursos.DataSource = ListadoRecursos
    End Sub

    Private Sub ListarRestriccionesXActividad()
        ListarRestricciones()
        ListadoRestricciones = bc.ListarRestriccionesXActividad(CInt(txtCodigo.Text.Trim))

        If ListadoRestricciones IsNot Nothing AndAlso ListadoRestricciones.Count > 0 Then
            For Each row As DataGridViewRow In dgvRestricciones.Rows
                Dim chk = DirectCast(row.Cells(colSeleccionar.Index), DataGridViewCheckBoxCell)
                Dim id As Integer = CInt(row.Cells(colRestriccionID.Index).Value)

                For Each oRestriccion As RestriccionesBE In ListadoRestricciones
                    If oRestriccion.id_restriccion = id Then
                        chk.Value = True
                        row.Cells(colCondicionRestriccion.Index).Value = oRestriccion.id_signo
                        row.Cells(colCantidadRestriccion.Index).Value = oRestriccion.valor
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub AgregarTipoPersonal(ByRef oTipoPersonal As TipoPersonalBE)
        If ValidarAgregarTipoPersonal() <> String.Empty Then
            MessageBox.Show(ValidarAgregarTipoPersonal, "Información")
            Exit Sub
        End If

        If ListadoTipoPersonal Is Nothing Then
            ListadoTipoPersonal = New List(Of TipoPersonalBE)
        End If
        oTipoPersonal.cantidad = txtCantidadPersonal.Text.Trim
        ListadoTipoPersonal.Add(oTipoPersonal)
        txtDescripcionPersonal.Text = String.Empty
        txtCantidadPersonal.Text = String.Empty
        dgvTipoPersonal.DataSource = Nothing
        dgvTipoPersonal.DataSource = ListadoTipoPersonal
    End Sub

    Private Sub AgregarRecurso(ByRef oRecurso As RecursoBE)
        If ValidarAgregarRecurso() <> String.Empty Then
            MessageBox.Show(ValidarAgregarRecurso, "Información")
            Exit Sub
        End If

        If ListadoRecursos Is Nothing Then
            ListadoRecursos = New List(Of RecursoBE)
        End If
        oRecurso.cantidad = txtCantidadRecurso.Text.Trim
        ListadoRecursos.Add(oRecurso)
        txtDescripcionRecurso.Text = String.Empty
        txtCantidadRecurso.Text = String.Empty
        dgvRecursos.DataSource = Nothing
        dgvRecursos.DataSource = ListadoRecursos
    End Sub

    Private Sub QuitarTipoPersonal(ByRef oTipoPersonal As TipoPersonalBE)
        If ListadoTipoPersonal IsNot Nothing Then
            ListadoTipoPersonal.Remove(oTipoPersonal)
        End If
        dgvTipoPersonal.DataSource = Nothing
        dgvTipoPersonal.DataSource = ListadoTipoPersonal
    End Sub

    Private Sub QuitarRecurso(ByRef oRecurso As RecursoBE)
        If ListadoRecursos IsNot Nothing Then
            ListadoRecursos.Remove(oRecurso)
        End If
        dgvRecursos.DataSource = Nothing
        dgvRecursos.DataSource = ListadoRecursos
    End Sub

    Private Sub LimpiarFormulario()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = False
        tsbReprogramacion.Visible = False

        txtCodigo.Text = String.Empty
        cboComite.SelectedIndex = 0
        cboTipo.SelectedIndex = 0
        cboCategoria.SelectedIndex = -1
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        nudPago.Value = 0.0
        nudVacantes.Value = 0

        txtDescripcionPersonal.Text = String.Empty
        txtCantidadPersonal.Text = String.Empty
        txtDescripcionRecurso.Text = String.Empty
        txtCantidadRecurso.Text = String.Empty

        dgvTipoPersonal.DataSource = Nothing
        dgvRecursos.DataSource = Nothing

        oPersonalPendiente = Nothing
        oRecursoPendiente = Nothing

        ListarRestricciones()
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

        msg &= ValidarRestricciones()

        Return msg
    End Function

    Private Function ValidarRestricciones() As String
        Dim msg As String = String.Empty

        For Each row As DataGridViewRow In dgvRestricciones.Rows
            Dim value As Boolean = CType(dgvRestricciones.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)

            If value Then
                If row.Cells(colCondicionRestriccion.Index).Value = Nothing Then
                    msg &= vbCrLf & "- Seleccione condición en todas las restricciones"
                End If

                If row.Cells(colCantidadRestriccion.Index).Value = Nothing Then
                    msg &= vbCrLf & "- Ingrese cantidad en todas las restricciones"
                Else
                    If row.Cells(colCantidadRestriccion.Index).Value = 0 Then
                        msg &= vbCrLf & "- La cantidad debe ser mayor a 0 en todos los detalles"
                    End If
                End If
            End If
        Next

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
        Dim oActividad As New ActividadBE
        oActividad.fec_ini = Today
        oActividad.fec_fin = Today
        oActividad.hora_ini = Now.TimeOfDay
        oActividad.hora_fin = Now.TimeOfDay
        oActividad.monto_pago = nudPago.Value
        oActividad.id_cattipo_act = cboCategoria.SelectedValue
        oActividad.id_comite = cboComite.SelectedValue
        oActividad.id_tipo_act = cboTipo.SelectedValue
        oActividad.descripcion = txtDescripcion.Text.Trim
        oActividad.nombre = txtNombre.Text.Trim
        oActividad.flg_plan_anual = False
        oActividad.flg_web = True
        oActividad.tipo_inscripcion = "A"
        oActividad.vacantes = nudVacantes.Value
        oActividad.ListaTipoPersonal = dgvTipoPersonal.DataSource
        oActividad.ListaRecursos = dgvRecursos.DataSource

        'Dim startDateTime As DateTime = Nothing
        'Dim endDateTime As DateTime = Nothing

        'oActividad.fec_ini = startDateTime.Date
        'oActividad.hora_ini = startDateTime.TimeOfDay
        'oActividad.fec_fin = endDateTime.Date
        'oActividad.hora_fin = endDateTime.TimeOfDay

        For Each row As DataGridViewRow In dgvRestricciones.Rows
            Dim value As Boolean = CType(dgvRestricciones.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oRestriccion As RestriccionesBE = row.DataBoundItem

            If value Then

                If oActividad.ListaRestricciones Is Nothing Then
                    oActividad.ListaRestricciones = New List(Of RestriccionesBE)
                End If

                oRestriccion.id_signo = row.Cells(colCondicionRestriccion.Index).Value
                oRestriccion.valor = row.Cells(colCantidadRestriccion.Index).Value
                oActividad.ListaRestricciones.Add(oRestriccion)
            End If
        Next

        If txtCodigo.Text = String.Empty Then
            oActividad.id_estado = "EST001" 'Registrada
            affectedRows = bc.InsertarActividad(oActividad)
        Else
            oActividad.id_actividad = txtCodigo.Text
            affectedRows = bc.ActualizarActividad(oActividad)
        End If

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            If txtCodigo.Text = String.Empty Then
                txtCodigo.Text = affectedRows
                _id_actividad = affectedRows
                MessageBox.Show("La actividad se registró satisfactoriamente", "Información")
            Else
                _id_actividad = oActividad.id_actividad
                MessageBox.Show("La actividad se actualizó satisfactoriamente", "Información")
            End If
        End If

        Return flag

    End Function

    Private Sub AgregarProgramacion()

    End Sub

#End Region

#Region "Cargar"

    Private Sub frmRegistroActividad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarTipoActividad()
        ListarRestricciones()
        ListarSignos()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarActividad() Then
            LimpiarFormulario()
            CargarActividad(_id_actividad)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub tsbEditar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEditar.Click
        FormularioEnModoEdicion()
    End Sub

    Private Sub tsbEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEliminar.Click
        If txtCodigo.Text.Trim <> String.Empty Then
            If MsgBox("Seguro que desea anular la actividad?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.BorrarActividad(CInt(txtCodigo.Text.Trim))

                If affectedRows = 0 Then
                    MessageBox.Show("Error al borrar", "Información")
                Else
                    MessageBox.Show("La actividad se anuló satisfactoriamente", "Información")
                End If

                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tsbCancelar.Click
        If MsgBox("Seguro que desea cancelar la operación?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub tsbPresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles tsbPresupuesto.Click

    End Sub

    Private Sub tsbReprogramacion_Click(sender As System.Object, e As System.EventArgs) Handles tsbReprogramacion.Click

    End Sub

    Private Sub btnBuscarActividad_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarActividad.Click
        Dim frmBuscarActividad As New frmBuscarActividad
        frmBuscarActividad.ShowDialog()

        If frmBuscarActividad.ActividadSeleccionada IsNot Nothing Then
            tsbEditar.Visible = True
            tsbEliminar.Visible = True
            _id_actividad = frmBuscarActividad.ActividadSeleccionada.id_actividad
            CargarActividad(frmBuscarActividad.ActividadSeleccionada.id_actividad)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub btnBuscarPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarPersonal.Click
        Dim frmBuscarTipoPersonal As New frmBuscarTipoPersonal
        frmBuscarTipoPersonal.ShowDialog()

        If frmBuscarTipoPersonal.TipoPersonalSeleccionado IsNot Nothing Then
            CargarTipoPersonal(frmBuscarTipoPersonal.TipoPersonalSeleccionado)
            oPersonalPendiente = frmBuscarTipoPersonal.TipoPersonalSeleccionado
        End If
    End Sub

    Private Sub btnAgregarTipoPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTipoPersonal.Click
        AgregarTipoPersonal(oPersonalPendiente)
        oPersonalPendiente = Nothing
    End Sub

    Private Sub btnQuitarTipoPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarTipoPersonal.Click
        If dgvTipoPersonal.CurrentRow IsNot Nothing Then
            QuitarTipoPersonal(DirectCast(dgvTipoPersonal.CurrentRow.DataBoundItem, TipoPersonalBE))
        End If
    End Sub

    Private Sub txtCantidadPersonal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadPersonal.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub btnBuscarRecurso_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarRecurso.Click
        Dim frmBuscarRecurso As New frmBuscarRecurso
        frmBuscarRecurso.ShowDialog()

        If frmBuscarRecurso.RecursoSeleccionado IsNot Nothing Then
            CargarRecurso(frmBuscarRecurso.RecursoSeleccionado)
            oRecursoPendiente = frmBuscarRecurso.RecursoSeleccionado
        End If
    End Sub

    Private Sub btnAgregarRecurso_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarRecurso.Click
        AgregarRecurso(oRecursoPendiente)
        oRecursoPendiente = Nothing
    End Sub

    Private Sub btnQuitarRecurso_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarRecurso.Click
        If dgvRecursos.CurrentRow IsNot Nothing Then
            QuitarRecurso(DirectCast(dgvRecursos.CurrentRow.DataBoundItem, RecursoBE))
        End If
    End Sub

    Private Sub txtCantidadRecurso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadRecurso.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
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

    Private Sub btnEscoger_Click(sender As System.Object, e As System.EventArgs) Handles btnEscoger.Click
        Dim frmBuscarEspacio As New frmBuscarEspacio
        frmBuscarEspacio.ShowDialog()

        If frmBuscarEspacio.EspacioSeleccionado IsNot Nothing Then
            '_id_actividad = frmBuscarActividad.ActividadSeleccionada.id_actividad
            'CargarActividad(frmBuscarActividad.ActividadSeleccionada.id_actividad)
            'FormularioEnModoVista()
        End If
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvRestricciones_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvRestricciones.EditingControlShowing
        Dim columnIndex As Integer = dgvRestricciones.CurrentCell.ColumnIndex
        Dim rowIndex As Integer = dgvRestricciones.CurrentCell.RowIndex
        Dim flgCondicion As Boolean = dgvRestricciones.Item(colFlgCondicion.Index, rowIndex).Value

        If dgvRestricciones.Columns(columnIndex).Name = colCantidadRestriccion.Name Then
            Dim txtCantidad As DataGridViewTextBoxEditingControl = DirectCast(e.Control, DataGridViewTextBoxEditingControl)

            RemoveHandler txtCantidad.KeyPress, AddressOf txtNumeric_KeyPress
            AddHandler txtCantidad.KeyPress, AddressOf txtNumeric_KeyPress

            If flgCondicion = False Then
                txtCantidad.ReadOnly = True
            Else
                txtCantidad.ReadOnly = False
            End If

        ElseIf dgvRestricciones.Columns(columnIndex).Name = colCondicionRestriccion.Name Then
            Dim cboCondicion As ComboBox = DirectCast(e.Control, ComboBox)

            If flgCondicion = False Then
                cboCondicion.Enabled = False
            Else
                cboCondicion.Enabled = True
            End If
        End If

    End Sub

    Private Sub txtNumeric_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

#End Region

End Class

