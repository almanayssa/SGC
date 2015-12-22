Imports SGC.Controller
Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades

Public Class frmBuscarPlan

    Dim bc As New BusinessController


#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvListado.AutoGenerateColumns = False

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

    End Sub

#End Region

#Region "Propiedades"

    Private _PlanSeleccionado As PlanAnualBE
    Public Property PlanSeleccionado() As PlanAnualBE
        Get
            Return _PlanSeleccionado
        End Get
        Set(ByVal value As PlanAnualBE)
            _PlanSeleccionado = value
        End Set
    End Property

    Private _PlanFiltro As PlanAnualBE
    Public Property PlanFiltro() As PlanAnualBE
        Get
            Return _PlanFiltro
        End Get
        Set(ByVal value As PlanAnualBE)
            _PlanFiltro = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarComites()
        Dim oComite As New ComiteBE
        oComite.id_comite = "000"
        oComite.nombre = "- Todos -"

        Dim ListadoComites As List(Of ComiteBE) = bc.ListarComites()
        ListadoComites.Insert(0, oComite)
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

        If PlanFiltro IsNot Nothing Then

            Dim ListadoPlanes As List(Of PlanAnualBE) = bc.ListarPlanes(PlanFiltro)

            dgvListado.Columns.Clear()
            dgvListado.DataSource = Nothing


            If ListadoPlanes IsNot Nothing Then

                Dim Col_Text As DataGridViewTextBoxColumn
                Dim Row As DataGridViewRow
                Dim Cell As DataGridViewCell

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "idPlan"
                Col_Text.HeaderText = "Código"
                Col_Text.ReadOnly = True
                Col_Text.Visible = True
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "id_comite"
                Col_Text.HeaderText = "idComite"
                Col_Text.ReadOnly = True
                Col_Text.Visible = False
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "comite"
                Col_Text.HeaderText = "Comite"
                Col_Text.ReadOnly = True
                Col_Text.Visible = True
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "descripcion"
                Col_Text.HeaderText = "Descripción"
                Col_Text.ReadOnly = True
                Col_Text.Visible = True
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "anio"
                Col_Text.HeaderText = "Año"
                Col_Text.ReadOnly = True
                Col_Text.Visible = True
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)
                For Each a As PlanAnualBE In ListadoPlanes
                    Row = New DataGridViewRow

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = a.id_plan
                    Row.Cells.Add(Cell)
                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = a.id_comite
                    Row.Cells.Add(Cell)
                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = a.comite
                    Row.Cells.Add(Cell)
                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = a.descripcion
                    Row.Cells.Add(Cell)
                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = a.anio
                    Row.Cells.Add(Cell)

                    dgvListado.Rows.Add(Row)
                Next

            End If
        End If
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarPlan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarAnio()


        If PlanFiltro IsNot Nothing Then
            cboComite.SelectedValue = PlanFiltro.id_plan
            cboAnio.SelectedValue = PlanFiltro.anio

            ListarPlanes()
        
        End If

    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        PlanFiltro = New PlanAnualBE
        PlanFiltro.anio = cboAnio.SelectedValue
        If cboComite.SelectedIndex <> 0 Then
            PlanFiltro.id_comite = cboComite.SelectedValue
        End If

        ListarPlanes()
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick

        PlanSeleccionado = New PlanAnualBE
        PlanSeleccionado.id_plan = CStr(dgvListado.Item("idPlan", dgvListado.CurrentRow.Index).Value)

        Me.Close()

    End Sub

#End Region


End Class
