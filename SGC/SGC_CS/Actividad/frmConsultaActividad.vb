Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmConsultaActividad

    Dim bc As New BusinessController
    Private ListadoActividad As List(Of ActividadBE)

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        dgvTodas.AutoGenerateColumns = False
        dgvRegistradas.AutoGenerateColumns = False
        dgvEnEvaluacion.AutoGenerateColumns = False
        dgvAnuladas.AutoGenerateColumns = False
        dgvAprobadas.AutoGenerateColumns = False
        dgvHabilitadas.AutoGenerateColumns = False
        dgvRechazadas.AutoGenerateColumns = False

        ctoNombre.DataPropertyName = "nombre"
        ctoTipo.DataPropertyName = "desc_tipo"
        ctoCategoria.DataPropertyName = "desc_cat"
        ctoFecInicio.DataPropertyName = "fec_ini"
        ctoFecFin.DataPropertyName = "fec_fin"
        ctoPago.DataPropertyName = "monto_pago"
        ctoVacantes.DataPropertyName = "vacantes"
        ctoEstado.DataPropertyName = "desc_estado"

        ctoFecInicio.ValueType = GetType(DateTime)
        ctoFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"

        ctoFecFin.ValueType = GetType(DateTime)
        ctoFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        creNombre.DataPropertyName = "nombre"
        creTipo.DataPropertyName = "desc_tipo"
        creCategoria.DataPropertyName = "desc_cat"
        creFecInicio.DataPropertyName = "fec_ini"
        creFecFin.DataPropertyName = "fec_fin"
        crePago.DataPropertyName = "monto_pago"
        creVacantes.DataPropertyName = "vacantes"

        creFecInicio.ValueType = GetType(DateTime)
        creFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"

        creFecFin.ValueType = GetType(DateTime)
        creFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        ceeNombre.DataPropertyName = "nombre"
        ceeTipo.DataPropertyName = "desc_tipo"
        ceeCategoria.DataPropertyName = "desc_cat"
        ceeFecInicio.DataPropertyName = "fec_ini"
        ceeFecFin.DataPropertyName = "fec_fin"
        ceePago.DataPropertyName = "monto_pago"
        ceeVacantes.DataPropertyName = "vacantes"

        ceeFecInicio.ValueType = GetType(DateTime)
        ceeFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"

        ceeFecFin.ValueType = GetType(DateTime)
        ceeFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        canNombre.DataPropertyName = "nombre"
        canTipo.DataPropertyName = "desc_tipo"
        canCategoria.DataPropertyName = "desc_cat"
        canFecInicio.DataPropertyName = "fec_ini"
        canFecFin.DataPropertyName = "fec_fin"
        canPago.DataPropertyName = "monto_pago"
        canVacantes.DataPropertyName = "vacantes"

        canFecInicio.ValueType = GetType(DateTime)
        canFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"

        canFecFin.ValueType = GetType(DateTime)
        canFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        capNombre.DataPropertyName = "nombre"
        capTipo.DataPropertyName = "desc_tipo"
        capCategoria.DataPropertyName = "desc_cat"
        capFecInicio.DataPropertyName = "fec_ini"
        capFecFin.DataPropertyName = "fec_fin"
        capPago.DataPropertyName = "monto_pago"
        capVacantes.DataPropertyName = "vacantes"

        capFecInicio.ValueType = GetType(DateTime)
        capFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"

        capFecFin.ValueType = GetType(DateTime)
        capFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        chaNombre.DataPropertyName = "nombre"
        chaTipo.DataPropertyName = "desc_tipo"
        chaCategoria.DataPropertyName = "desc_cat"
        chaFecInicio.DataPropertyName = "fec_ini"
        chaFecFin.DataPropertyName = "fec_fin"
        chaPago.DataPropertyName = "monto_pago"
        chaVacantes.DataPropertyName = "vacantes"

        chaFecInicio.ValueType = GetType(DateTime)
        chaFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"

        chaFecFin.ValueType = GetType(DateTime)
        chaFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        crcNombre.DataPropertyName = "nombre"
        crcTipo.DataPropertyName = "desc_tipo"
        crcCategoria.DataPropertyName = "desc_cat"
        crcFecInicio.DataPropertyName = "fec_ini"
        crcFecFin.DataPropertyName = "fec_fin"
        crcPago.DataPropertyName = "monto_pago"
        crcVacantes.DataPropertyName = "vacantes"

        crcFecInicio.ValueType = GetType(DateTime)
        crcFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"

        crcFecFin.ValueType = GetType(DateTime)
        crcFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

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

    Private Sub ListarActividades()
        ListadoActividad = bc.ListarActividades(cboComite.SelectedValue, dtpFecInicio.Value, dtpFecFin.Value)
        dgvTodas.DataSource = Nothing
        dgvTodas.DataSource = ListadoActividad

        Dim ListadoActividadRegistrada As New List(Of ActividadBE)
        Dim ListadoActividadEnEvaluacion As New List(Of ActividadBE)
        Dim ListadoActividadAnulada As New List(Of ActividadBE)
        Dim ListadoActividadAprobada As New List(Of ActividadBE)
        Dim ListadoActividadHabilitada As New List(Of ActividadBE)
        Dim ListadoActividadRechazada As New List(Of ActividadBE)

        If ListadoActividad IsNot Nothing Then
            If ListadoActividad.Count > 0 Then
                For Each oActividad In ListadoActividad
                    Select Case oActividad.desc_estado
                        Case "Registrada"
                            ListadoActividadRegistrada.Add(oActividad)
                        Case "En evaluación"
                            ListadoActividadEnEvaluacion.Add(oActividad)
                        Case "Anulada"
                            ListadoActividadAnulada.Add(oActividad)
                        Case "Aprobada"
                            ListadoActividadAprobada.Add(oActividad)
                        Case "Habilitada"
                            ListadoActividadHabilitada.Add(oActividad)
                        Case "Rechazada"
                            ListadoActividadRechazada.Add(oActividad)
                    End Select
                Next
            End If
        End If

        dgvRegistradas.DataSource = Nothing
        dgvRegistradas.DataSource = ListadoActividadRegistrada

        dgvEnEvaluacion.DataSource = Nothing
        dgvEnEvaluacion.DataSource = ListadoActividadEnEvaluacion

        dgvAnuladas.DataSource = Nothing
        dgvAnuladas.DataSource = ListadoActividadAnulada

        dgvAprobadas.DataSource = Nothing
        dgvAprobadas.DataSource = ListadoActividadAprobada

        dgvHabilitadas.DataSource = Nothing
        dgvHabilitadas.DataSource = ListadoActividadHabilitada

        dgvRechazadas.DataSource = Nothing
        dgvRechazadas.DataSource = ListadoActividadRechazada
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmConsultaActividad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If cboComite.SelectedValue = "000" Then
            MessageBox.Show("Seleccione un comité", "Información")
            Exit Sub
        Else
            ListarActividades()
        End If
    End Sub

#End Region

End Class
