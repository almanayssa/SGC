Imports SGC.Controller
Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades

Public Class frmBuscarSocio

    Dim bc As New BusinessController


#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvListado.AutoGenerateColumns = False

    End Sub

#End Region

#Region "Propiedades"

    Private _SocioSeleccionado As SocioBE
    Public Property SocioSeleccionado() As SocioBE
        Get
            Return _SocioSeleccionado
        End Get
        Set(ByVal value As SocioBE)
            _SocioSeleccionado = value
        End Set
    End Property

    Private _SocioFiltro As SocioBE
    Public Property SocioFiltro() As SocioBE
        Get
            Return _SocioFiltro
        End Get
        Set(ByVal value As SocioBE)
            _SocioFiltro = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarSocios()

        If SocioFiltro IsNot Nothing Then

            Dim ListadoSocios As List(Of SocioBE) = bc.ListarSocios(SocioFiltro)

            dgvListado.Columns.Clear()
            dgvListado.DataSource = Nothing


            If ListadoSocios IsNot Nothing Then

                Dim Col_Text As DataGridViewTextBoxColumn
                Dim Row As DataGridViewRow
                Dim Cell As DataGridViewCell

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "id_socio"
                Col_Text.HeaderText = "Código"
                Col_Text.ReadOnly = True
                Col_Text.Visible = False
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "id_accion"
                Col_Text.HeaderText = "Clave"
                Col_Text.ReadOnly = True
                Col_Text.Visible = True
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "nombrecompleto"
                Col_Text.HeaderText = "Nombres"
                Col_Text.ReadOnly = True
                Col_Text.Visible = True
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

                For Each a As SocioBE In ListadoSocios
                    Row = New DataGridViewRow

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = a.id_socio
                    Row.Cells.Add(Cell)
                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = a.id_accion
                    Row.Cells.Add(Cell)
                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = a.nombre_completo
                    Row.Cells.Add(Cell)

                    dgvListado.Rows.Add(Row)
                Next

            End If
        End If
    End Sub


#End Region

#Region "Cargar"

    Private Sub frmBuscarPlan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
        If SocioFiltro IsNot Nothing Then
            txtClave.Text = SocioFiltro.id_accion
            txtNombres.Text = SocioFiltro.nombre_completo

            ListarSocios()

        End If


    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        SocioFiltro = New SocioBE
        If txtClave.Text <> "" Then SocioFiltro.id_accion = txtClave.Text
        If txtNombres.Text <> "" Then SocioFiltro.nombre_completo = txtNombres.Text

        ListarSocios()
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick

        SocioSeleccionado = New SocioBE
        SocioSeleccionado.id_socio = CStr(dgvListado.Item("id_socio", dgvListado.CurrentRow.Index).Value)
        SocioSeleccionado.id_accion = CStr(dgvListado.Item("id_accion", dgvListado.CurrentRow.Index).Value)
        SocioSeleccionado.nombre_completo = CStr(dgvListado.Item("nombrecompleto", dgvListado.CurrentRow.Index).Value)

        Me.Close()

    End Sub

#End Region


End Class
