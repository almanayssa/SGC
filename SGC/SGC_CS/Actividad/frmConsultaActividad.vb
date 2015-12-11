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
        dgvAprobadas.AutoGenerateColumns = False
        dgvRechazadas.AutoGenerateColumns = False
        dgvHabilitadas.AutoGenerateColumns = False
        dgvFinalizadas.AutoGenerateColumns = False

        ctoNombre.DataPropertyName = "nombre"
        ctoTipo.DataPropertyName = "desc_tipo"
        ctoCategoria.DataPropertyName = "descripcion"
        ctoFecInicio.DataPropertyName = "fec_ini"
        ctoFecFin.DataPropertyName = "fec_fin"
        ctoPago.DataPropertyName = "monto_pago"
        ctoVacantes.DataPropertyName = "vacantes"
        ctoEstado.DataPropertyName = "desc_estado"

        creNombre.DataPropertyName = "nombre"
        creTipo.DataPropertyName = "desc_tipo"
        creCategoria.DataPropertyName = "descripcion"
        creFecInicio.DataPropertyName = "fec_ini"
        creFecFin.DataPropertyName = "fec_fin"
        crePago.DataPropertyName = "monto_pago"
        creVacantes.DataPropertyName = "vacantes"

        ceeNombre.DataPropertyName = "nombre"
        ceeTipo.DataPropertyName = "desc_tipo"
        ceeCategoria.DataPropertyName = "descripcion"
        ceeFecInicio.DataPropertyName = "fec_ini"
        ceeFecFin.DataPropertyName = "fec_fin"
        ceePago.DataPropertyName = "monto_pago"
        ceeVacantes.DataPropertyName = "vacantes"

        capNombre.DataPropertyName = "nombre"
        capTipo.DataPropertyName = "desc_tipo"
        capCategoria.DataPropertyName = "descripcion"
        capFecInicio.DataPropertyName = "fec_ini"
        capFecFin.DataPropertyName = "fec_fin"
        capPago.DataPropertyName = "monto_pago"
        capVacantes.DataPropertyName = "vacantes"

        crcNombre.DataPropertyName = "nombre"
        crcTipo.DataPropertyName = "desc_tipo"
        crcCategoria.DataPropertyName = "descripcion"
        crcFecInicio.DataPropertyName = "fec_ini"
        crcFecFin.DataPropertyName = "fec_fin"
        crcPago.DataPropertyName = "monto_pago"
        crcVacantes.DataPropertyName = "vacantes"

        chaNombre.DataPropertyName = "nombre"
        chaTipo.DataPropertyName = "desc_tipo"
        chaCategoria.DataPropertyName = "descripcion"
        chaFecInicio.DataPropertyName = "fec_ini"
        chaFecFin.DataPropertyName = "fec_fin"
        chaPago.DataPropertyName = "monto_pago"
        chaVacantes.DataPropertyName = "vacantes"

        cfiNombre.DataPropertyName = "nombre"
        cfiTipo.DataPropertyName = "desc_tipo"
        cfiCategoria.DataPropertyName = "descripcion"
        cfiFecInicio.DataPropertyName = "fec_ini"
        cfiFecFin.DataPropertyName = "fec_fin"
        cfiPago.DataPropertyName = "monto_pago"
        cfiVacantes.DataPropertyName = "vacantes"

    End Sub

#End Region

    Private Sub ListarComites()
        Dim oComite As New ComiteBE
        oComite.id_comite = "000"
        oComite.nombre = "- Seleccione -"

        Dim ListadoComites As List(Of ComiteBE) = bc.ListarComites()
        ListadoComites.Insert(0, oComite)
        cboComite.DataSource = Nothing
        cboComite.DataSource = ListadoComites
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If cboComite.SelectedValue = "000" Then
            MessageBox.Show("Seleccione un comité", "Información")
            Exit Sub
        Else
            ListarActividades()
        End If
    End Sub

    Private Sub ListarActividades()
        ListadoActividad = bc.ListarActividades(cboComite.SelectedValue, dtpFecInicio.Value, dtpFecFin.Value)
        dgvTodas.DataSource = Nothing
        dgvTodas.DataSource = ListadoActividad

        If ListadoActividad IsNot Nothing Then
            If ListadoActividad.Count > 0 Then

            End If
        End If
    End Sub

    Private Sub frmConsultaActividad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
    End Sub
End Class
