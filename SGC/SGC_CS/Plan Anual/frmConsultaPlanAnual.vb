Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmConsultaPlanAnual

    Dim bc As New BusinessController
    Private ListadoPlan As List(Of PlanAnualBE)

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        dgvTodos.AutoGenerateColumns = False
        dgvRegistrados.AutoGenerateColumns = False
        dgvEnEvaluacion.AutoGenerateColumns = False
        dgvAnulados.AutoGenerateColumns = False
        dgvAprobados.AutoGenerateColumns = False
        dgvRechazados.AutoGenerateColumns = False

        ctoDescripcion.DataPropertyName = "descripcion"
        ctoComite.DataPropertyName = "comite"
        ctoAnio.DataPropertyName = "anio"
        ctoFecInicio.DataPropertyName = "fec_ini"
        ctoFecFin.DataPropertyName = "fec_fin"
        ctoEstado.DataPropertyName = "estado"
        ctoFecInicio.ValueType = GetType(DateTime)
        ctoFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"
        ctoFecFin.ValueType = GetType(DateTime)
        ctoFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        creDescripcion.DataPropertyName = "descripcion"
        creComite.DataPropertyName = "comite"
        creAnio.DataPropertyName = "anio"
        creFecInicio.DataPropertyName = "fec_ini"
        creFecFin.DataPropertyName = "fec_fin"
        creFecInicio.ValueType = GetType(DateTime)
        creFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"
        creFecFin.ValueType = GetType(DateTime)
        creFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        ceeDescripcion.DataPropertyName = "descripcion"
        ceeComite.DataPropertyName = "comite"
        ceeAnio.DataPropertyName = "anio"
        ceeFecInicio.DataPropertyName = "fec_ini"
        ceeFecFin.DataPropertyName = "fec_fin"
        ceeFecInicio.ValueType = GetType(DateTime)
        ceeFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"
        ceeFecFin.ValueType = GetType(DateTime)
        ceeFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        canDescripcion.DataPropertyName = "descripcion"
        canComite.DataPropertyName = "comite"
        canAnio.DataPropertyName = "anio"
        canFecInicio.DataPropertyName = "fec_ini"
        canFecFin.DataPropertyName = "fec_fin"
        canFecInicio.ValueType = GetType(DateTime)
        canFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"
        canFecFin.ValueType = GetType(DateTime)
        canFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        capDescripcion.DataPropertyName = "descripcion"
        capComite.DataPropertyName = "comite"
        capAnio.DataPropertyName = "anio"
        capFecInicio.DataPropertyName = "fec_ini"
        capFecFin.DataPropertyName = "fec_fin"
        capFecInicio.ValueType = GetType(DateTime)
        capFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"
        capFecFin.ValueType = GetType(DateTime)
        capFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

        crcDescripcion.DataPropertyName = "descripcion"
        crcComite.DataPropertyName = "comite"
        crcAnio.DataPropertyName = "anio"
        crcFecInicio.DataPropertyName = "fec_ini"
        crcFecFin.DataPropertyName = "fec_fin"
        crcFecInicio.ValueType = GetType(DateTime)
        crcFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"
        crcFecFin.ValueType = GetType(DateTime)
        crcFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarComites()

        Dim ListadoComites As List(Of ComiteBE) = bc.ListarComites()
        cboComite.DataSource = Nothing
        cboComite.DataSource = ListadoComites
    End Sub

    Private Sub ListarAnio()
        Dim id As String() = New String(1) {"2015", "2016"}
        Dim desc As String() = New String(1) {"2015", "2016"}

        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("desc")

        Dim dr As DataRow

        For i As Integer = 0 To 1
            dr = dt.NewRow()
            dr("id") = id(i)
            dr("desc") = desc(i)
            dt.Rows.Add(dr)
        Next

        dt.AcceptChanges()

        cboAnio.DataSource = dt
        cboAnio.DisplayMember = "desc"
        cboAnio.ValueMember = "id"


        cboAnio.SelectedValue = Now.Year + 1
    End Sub

    Private Sub ListarPlanes()
        Dim oPlanFiltro As New PlanAnualBE
        oPlanFiltro.id_comite = cboComite.SelectedValue
        oPlanFiltro.anio = cboAnio.SelectedValue
        ListadoPlan = bc.ListarPlanes(oPlanFiltro)

        dgvTodos.DataSource = Nothing
        dgvTodos.DataSource = ListadoPlan

        Dim ListadoActividadRegistrado As New List(Of PlanAnualBE)
        Dim ListadoActividadEnEvaluacion As New List(Of PlanAnualBE)
        Dim ListadoActividadAnulado As New List(Of PlanAnualBE)
        Dim ListadoActividadAprobado As New List(Of PlanAnualBE)
        Dim ListadoActividadRechazado As New List(Of PlanAnualBE)

        If ListadoPlan IsNot Nothing Then
            If ListadoPlan.Count > 0 Then
                For Each oPlan In ListadoPlan
                    Select Case oPlan.estado
                        Case "Registrado"
                            ListadoActividadRegistrado.Add(oPlan)
                        Case "En evaluación"
                            ListadoActividadEnEvaluacion.Add(oPlan)
                        Case "Anulado"
                            ListadoActividadAnulado.Add(oPlan)
                        Case "Aprobado"
                            ListadoActividadAprobado.Add(oPlan)
                        Case "Rechazado"
                            ListadoActividadRechazado.Add(oPlan)
                    End Select
                Next
            End If
        End If

        dgvRegistrados.DataSource = Nothing
        dgvRegistrados.DataSource = ListadoActividadRegistrado

        dgvEnEvaluacion.DataSource = Nothing
        dgvEnEvaluacion.DataSource = ListadoActividadEnEvaluacion

        dgvAnulados.DataSource = Nothing
        dgvAnulados.DataSource = ListadoActividadAnulado

        dgvAprobados.DataSource = Nothing
        dgvAprobados.DataSource = ListadoActividadAprobado

        dgvRechazados.DataSource = Nothing
        dgvRechazados.DataSource = ListadoActividadRechazado
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmConsultaPlanAnual_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarAnio()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        frmRegistroPlanAnual.Close()
        frmRegistroPlanAnual.MdiParent = MDI
        frmRegistroPlanAnual.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        ListarPlanes()
    End Sub

#End Region

End Class
