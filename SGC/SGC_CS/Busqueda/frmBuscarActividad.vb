Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarActividad

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvListado.AutoGenerateColumns = False
        colComite.DataPropertyName = "nombreComite"
        colNombre.DataPropertyName = "nombre"
        colFechaInicio.DataPropertyName = "fec_ini"
        colHoraInicio.DataPropertyName = "hora_ini"
        colFechaFin.DataPropertyName = "fec_fin"
        colHoraFin.DataPropertyName = "hora_fin"

        colFechaInicio.ValueType = GetType(DateTime)
        colFechaInicio.DefaultCellStyle.Format = "MM/dd/yyyy"

        'colHoraInicio.ValueType = GetType(TimeSpan)
        'colHoraInicio.DefaultCellStyle.Format = "HH:mm"

        colFechaFin.ValueType = GetType(DateTime)
        colFechaFin.DefaultCellStyle.Format = "MM/dd/yyyy"

        'colHoraFin.ValueType = GetType(TimeSpan)
        'colHoraFin.DefaultCellStyle.Format = "HH:mm"

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

    End Sub

#End Region

#Region "Propiedades"

    Private _ActividadSeleccionada As ActividadBE
    Public Property ActividadSeleccionada() As ActividadBE
        Get
            Return _ActividadSeleccionada
        End Get
        Set(ByVal value As ActividadBE)
            _ActividadSeleccionada = value
        End Set
    End Property

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
        'Dim ListadoActividades As List(Of ActividadBE) = bc.ListarActividades(cboComite.SelectedValue, txtNombre.Text.Trim)
        'dgvListado.DataSource = Nothing
        'dgvListado.DataSource = ListadoActividades
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarActividad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarActividades()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarActividades()
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        ActividadSeleccionada = DirectCast(dgvListado.CurrentRow.DataBoundItem, ActividadBE)
        Me.Close()
    End Sub

#End Region

End Class
