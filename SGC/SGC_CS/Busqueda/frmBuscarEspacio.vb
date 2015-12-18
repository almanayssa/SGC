Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarEspacio

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboSede.ValueMember = "id_sede"
        cboSede.DisplayMember = "des_sede"

        cboLugar.ValueMember = "id_lugar"
        cboLugar.DisplayMember = "desc_lugar"

        dgvListado.AutoGenerateColumns = False
        colNombre.DataPropertyName = "nombre"
    End Sub

#End Region

#Region "Propiedades"

    Private _EspacioSeleccionado As EspacioBE
    Public Property EspacioSeleccionado() As EspacioBE
        Get
            Return _EspacioSeleccionado
        End Get
        Set(ByVal value As EspacioBE)
            _EspacioSeleccionado = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

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
        cboLugar.DataSource = Nothing
        cboLugar.DataSource = ListadoLugar
    End Sub

    Private Sub ListarEspacios()
        Dim ListadoEspacios As List(Of EspacioBE) = bc.ListarEspacios(cboSede.SelectedValue, cboLugar.SelectedValue)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoEspacios
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarEspacio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarSedes()
        ListarLugares()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If cboSede.SelectedValue = "000" Or cboLugar.SelectedValue = 0 Then
            MessageBox.Show("Seleccione una sede o lugar", "Información")
            Exit Sub
        Else
            ListarEspacios()
        End If
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        EspacioSeleccionado = DirectCast(dgvListado.CurrentRow.DataBoundItem, EspacioBE)
        Me.Close()
    End Sub

#End Region

End Class
