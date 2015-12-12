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
        'colDescripcion.DataPropertyName = "Descripcion"
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
        Dim ListadoLugar As List(Of LugarBE) = bc.ListarLugares()
        cboLugar.DataSource = Nothing
        cboLugar.DataSource = ListadoLugar
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarRecurso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarSedes()
        ListarLugares()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub cboSede_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboSede.SelectedValueChanged, cboLugar.SelectedValueChanged
        If cboSede.SelectedValue IsNot Nothing And cboLugar.SelectedValue IsNot Nothing Then
            If cboSede.SelectedValue = "000" Or cboLugar.SelectedValue = 0 Then
                cboEspacio.Enabled = False
                cboEspacio.DataSource = Nothing
            Else
                Dim ListadoEspacios As List(Of EspacioBE) = bc.ListarEspacios(cboSede.SelectedValue, cboLugar.SelectedValue)

                If ListadoEspacios.Count = 0 Then
                    cboEspacio.Enabled = False
                    cboEspacio.DataSource = Nothing
                Else
                    cboEspacio.Enabled = True
                    Dim oEspacio As New EspacioBE
                    oEspacio.id_espacio = 0
                    oEspacio.nombre = "- Seleccione -"

                    ListadoEspacios.Insert(0, oEspacio)
                    cboEspacio.DataSource = Nothing
                    cboEspacio.DataSource = ListadoEspacios
                    cboEspacio.ValueMember = "id_espacio"
                    cboEspacio.DisplayMember = "nombre"
                End If
            End If
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
