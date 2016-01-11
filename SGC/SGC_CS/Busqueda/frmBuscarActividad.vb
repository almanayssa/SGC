Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarActividad

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvListado.AutoGenerateColumns = False
        colNombre.DataPropertyName = "nombre"
        colFecInicio.DataPropertyName = "fecha"
        colHoraInicio.DataPropertyName = "hora_ini"
        'colFecFin.DataPropertyName = "fec_fin"
        colHoraFin.DataPropertyName = "hora_fin"

        colFecInicio.ValueType = GetType(DateTime)
        colFecInicio.DefaultCellStyle.Format = "dd/MM/yyyy"

        'colHoraInicio.ValueType = GetType(TimeSpan)
        'colHoraInicio.DefaultCellStyle.Format = "HH:mm"

        colFecFin.ValueType = GetType(DateTime)
        colFecFin.DefaultCellStyle.Format = "dd/MM/yyyy"

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

    Private _id_estado As String
    Public Property id_estado() As String
        Get
            Return _id_estado
        End Get
        Set(ByVal value As String)
            _id_estado = value
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
        Dim ListadoActividades As List(Of ActividadBE) = bc.ListarActividadesBusqueda(cboComite.SelectedValue, txtNombre.Text.Trim, id_estado)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoActividades
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarActividad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarComites()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If cboComite.SelectedValue = "000" Then
            MessageBox.Show("Seleccione un comité", "Información")
            Exit Sub
        Else
            ListarActividades()
        End If
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        ActividadSeleccionada = DirectCast(dgvListado.CurrentRow.DataBoundItem, ActividadBE)
        Me.Close()
    End Sub

#End Region

End Class
