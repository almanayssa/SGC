Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmHabilitarActividad

    Dim bc As New BusinessController
    Private Actividad As ActividadBE
    Private ListadoActividadDetalles As List(Of ActividadDetalleBE)
    Private ListadoTipoPersonal As List(Of TipoPersonalBE)
    Private ListadoRecursos As List(Of RecursoBE)
    Private ListadoRestricciones As List(Of RestriccionesBE)
    Private ListadoPersonal As List(Of PersonalBE)
    Private oPersonalPendiente As PersonalBE
    Private _id_actividad As Integer

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvProgramacion.AutoGenerateColumns = False
        dgvRestricciones.AutoGenerateColumns = False
        dgvTipoPersonal.AutoGenerateColumns = False
        dgvPersonal.AutoGenerateColumns = False
        dgvRecursos.AutoGenerateColumns = False

        colSede.DataPropertyName = "des_sede"
        colEspacio.DataPropertyName = "nombre_espacio"
        colFecInicio.DataPropertyName = "fecha_ini"
        colHoraInicio.DataPropertyName = "hora_ini"
        colFecFin.DataPropertyName = "fecha_fin"
        colHoraFin.DataPropertyName = "hora_fin"

        colRestriccionID.DataPropertyName = "id_restriccion"
        colDescripcionRestriccion.DataPropertyName = "descripcion"
        colCondicionRestriccion.DataPropertyName = "des_signo"
        colCantidadRestriccion.DataPropertyName = "valor"

        colTipoPersonalID.DataPropertyName = "id_tipo_personal"
        colDescripcionTipoPersonal.DataPropertyName = "descripcion"
        colCantidadTipoPersonal.DataPropertyName = "cantidad"
        colCantidadReal.DataPropertyName = "cantidad_real"

        colDescripcionRecurso.DataPropertyName = "descripcion"
        colCantidadRecurso.DataPropertyName = "cantidad"

        colNombre.DataPropertyName = "nombre_completo"
    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub CargarActividad(ByVal id_actividad As Integer)
        Dim oActividad As ActividadBE = bc.CargarActividadCabecera(id_actividad)
        Actividad = oActividad
        lblCodigo.Text = oActividad.id_actividad
        lblComite.Text = oActividad.nombrecomite
        lblTipo.Text = oActividad.desc_tipo
        If oActividad.id_cattipo_act IsNot Nothing Then
            lblCategoria.Text = oActividad.desc_cat
        End If
        lblNombre.Text = oActividad.nombre
        lblDescripcion.Text = oActividad.descripcion
        lblPago.Text = oActividad.monto_pago
        lblVacantes.Text = oActividad.vacantes

        ListarDetallesXActividad()
        ListarTipoPersonalXActividad()
        ListarRecursosXActividad()
        ListarRestriccionesXActividad()
    End Sub

    Private Sub ListarDetallesXActividad()
        ListadoActividadDetalles = bc.ListarDetallesXActividad(CInt(lblCodigo.Text.Trim))
        dgvProgramacion.DataSource = Nothing
        dgvProgramacion.DataSource = ListadoActividadDetalles
    End Sub

    Private Sub ListarTipoPersonalXActividad()
        ListadoTipoPersonal = bc.ListarTipoPersonalXActividad(CInt(lblCodigo.Text.Trim))
        dgvTipoPersonal.DataSource = Nothing
        dgvTipoPersonal.DataSource = ListadoTipoPersonal
    End Sub

    Private Sub ListarRecursosXActividad()
        ListadoRecursos = bc.ListarRecursosXActividad(CInt(lblCodigo.Text.Trim))
        dgvRecursos.DataSource = Nothing
        dgvRecursos.DataSource = ListadoRecursos
    End Sub

    Private Sub ListarRestriccionesXActividad()
        ListadoRestricciones = bc.ListarRestriccionesXActividad(CInt(lblCodigo.Text.Trim))
        dgvRestricciones.DataSource = Nothing
        dgvRestricciones.DataSource = ListadoRestricciones
    End Sub

    Private Sub AgregarPersonal(ByRef oPersonal As PersonalBE)
        If ListadoPersonal Is Nothing Then
            ListadoPersonal = New List(Of PersonalBE)
        End If
        ListadoPersonal.Add(oPersonal)
        dgvPersonal.DataSource = Nothing
        dgvPersonal.DataSource = ListadoPersonal
    End Sub

    Private Sub QuitarPersonal(ByRef oPersonal As PersonalBE)
        If ListadoPersonal IsNot Nothing Then
            ListadoPersonal.Remove(oPersonal)
        End If
        dgvPersonal.DataSource = Nothing
        dgvPersonal.DataSource = ListadoPersonal
    End Sub

    Private Sub LimpiarFormulario()
        tsbHabilitar.Visible = False

        lblCodigo.Text = "-"
        lblComite.Text = "-"
        lblTipo.Text = "-"
        lblCategoria.Text = "-"
        lblNombre.Text = "-"
        lblDescripcion.Text = "-"
        lblPago.Text = "-"
        lblVacantes.Text = "-"

        dgvProgramacion.DataSource = Nothing
        dgvRestricciones.DataSource = Nothing
        dgvTipoPersonal.DataSource = Nothing
        dgvRecursos.DataSource = Nothing
        dgvPersonal.DataSource = Nothing

        ListadoActividadDetalles = Nothing
        ListadoPersonal = Nothing
        ListadoRecursos = Nothing
        ListadoRestricciones = Nothing
        ListadoTipoPersonal = Nothing
        oPersonalPendiente = Nothing

    End Sub

    Private Function ValidarRecursos() As String
        Dim msg As String = String.Empty

        For Each row As DataGridViewRow In dgvRecursos.Rows
            If msg <> String.Empty Then
                Exit For
            End If

            If row.Cells(colCantidadReal.Index).Value = Nothing Then
                msg &= vbCrLf & "- Ingrese cantidad real en todos los recursos"
            End If
        Next

        Return msg
    End Function

    Private Function HabilitarActividad() As Boolean
        Dim flag As Boolean = True

        If ValidarRecursos() <> String.Empty Then
            MessageBox.Show(ValidarRecursos, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        Dim affectedRows As Integer = 0
        Dim oActividad As New ActividadBE

        oActividad.ListaRecursos = dgvRecursos.DataSource
        oActividad.ListaPersonal = dgvPersonal.DataSource

        oActividad.id_actividad = lblCodigo.Text
        affectedRows = bc.HabilitarActividad(oActividad)

        If affectedRows = 0 Then
            MessageBox.Show("Error al habilitar", "Información")
            flag = False
        Else
            _id_actividad = oActividad.id_actividad
            MessageBox.Show("La actividad se habilitó satisfactoriamente", "Información")
        End If

        Return flag

    End Function

#End Region

#Region "Cargar"

    Private Sub frmHabilitarActividad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LimpiarFormulario()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbHabilitar_Click(sender As System.Object, e As System.EventArgs) Handles tsbHabilitar.Click
        If HabilitarActividad() Then
            LimpiarFormulario()
        End If
    End Sub

    Private Sub btnBuscarActividad_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarActividad.Click
        Dim frmBuscarActividad As New frmBuscarActividad
        frmBuscarActividad.id_estado = "EST004"
        frmBuscarActividad.ShowDialog()

        If frmBuscarActividad.ActividadSeleccionada IsNot Nothing Then
            _id_actividad = frmBuscarActividad.ActividadSeleccionada.id_actividad
            CargarActividad(frmBuscarActividad.ActividadSeleccionada.id_actividad)
            tsbHabilitar.Visible = True
        End If
    End Sub

    Private Sub btnAgregarPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarPersonal.Click
        Dim frmBuscarPersonal As New frmBuscarPersonal
        frmBuscarPersonal.ShowDialog()

        If frmBuscarPersonal.PersonalSeleccionado IsNot Nothing Then
            oPersonalPendiente = frmBuscarPersonal.PersonalSeleccionado
        End If

        AgregarPersonal(oPersonalPendiente)
        oPersonalPendiente = Nothing
    End Sub

    Private Sub btnQuitarPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarPersonal.Click
        If dgvTipoPersonal.CurrentRow IsNot Nothing Then
            QuitarPersonal(DirectCast(dgvPersonal.CurrentRow.DataBoundItem, PersonalBE))
        End If
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvRecursos_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvRecursos.EditingControlShowing
        Dim columnIndex As Integer = dgvRecursos.CurrentCell.ColumnIndex
        Dim rowIndex As Integer = dgvRecursos.CurrentCell.RowIndex

        If dgvRecursos.Columns(columnIndex).Name = colCantidadReal.Name Then
            Dim txtCantidad As DataGridViewTextBoxEditingControl = DirectCast(e.Control, DataGridViewTextBoxEditingControl)

            RemoveHandler txtCantidad.KeyPress, AddressOf txtNumeric_KeyPress
            AddHandler txtCantidad.KeyPress, AddressOf txtNumeric_KeyPress
        End If

    End Sub

    Private Sub txtNumeric_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

#End Region

End Class
