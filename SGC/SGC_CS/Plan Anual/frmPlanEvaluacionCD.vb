Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmPlanEvaluacionCD

    Dim bc As New BusinessController
    Private ListadoPlanes As List(Of PlanAnualBE)

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

    End Sub

#End Region

#Region "Cargar"

    Private Sub frmPlanEvaluacionCD_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarAnio()
    End Sub

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

        Dim id_comite As String = ""

        If cboComite.SelectedIndex <> 0 Then
            id_comite = cboComite.SelectedValue
        End If

        ListadoPlanes = bc.ListarPlanesCD(id_comite, cboAnio.SelectedValue)

        dgvListado.Columns.Clear()
        dgvListado.DataSource = Nothing


        If ListadoPlanes IsNot Nothing Then

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Col_Chk As DataGridViewCheckBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_plan"
            Col_Text.HeaderText = "Id"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "descripcion"
            Col_Text.HeaderText = "descripcion"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
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
            Col_Text.Name = "anio"
            Col_Text.HeaderText = "Año"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fec_ini"
            Col_Text.HeaderText = "Fecha Inicio"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fec_fin"
            Col_Text.HeaderText = "Fecha Fin"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "estado"
            Col_Text.HeaderText = "Estado"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Chk = New DataGridViewCheckBoxColumn
            Col_Chk.Name = "flg_seleccionar"
            Col_Chk.HeaderText = "Seleccionar"
            Col_Chk.ReadOnly = False
            Col_Chk.Visible = True
            Col_Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Chk)

            For Each a As PlanAnualBE In ListadoPlanes
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_plan
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.descripcion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.comite
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.anio
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.fec_ini
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.fec_fin
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.estado
                Row.Cells.Add(Cell)
                Cell = New DataGridViewCheckBoxCell
                Cell.Value = False
                Row.Cells.Add(Cell)

                dgvListado.Rows.Add(Row)
            Next

        End If

    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        'If cboComite.SelectedValue = "000" Then
        '    MessageBox.Show("Seleccione un comité", "Información")
        '    Exit Sub
        'Else
        ListarPlanes()
        'End If
    End Sub

    Private Sub btnAprobar_Click(sender As System.Object, e As System.EventArgs) Handles btnAprobar.Click
        Dim oNewListadoPlanes As New List(Of PlanAnualBE)
        Dim oNewPlan As New PlanAnualBE


        For Each dgvr As DataGridViewRow In dgvListado.Rows

            If dgvr.Cells("flg_seleccionar").GetType.ToString = "System.Windows.Forms.DataGridViewCheckBoxCell" Then
                If dgvr.Cells("flg_seleccionar").Value = True Then

                    oNewPlan = New PlanAnualBE
                    oNewPlan.id_plan = dgvr.Cells("id_plan").Value
                    oNewListadoPlanes.Add(oNewPlan)

                End If

            End If
        Next

        If oNewListadoPlanes.Count = 0 Then
            MessageBox.Show("Seleccione un Plan Anual al menos", "Información")
            Exit Sub
        Else
            If MsgBox("Seguro que desea aprobar el(los) plan(es)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.InsertarSeguimientoPlanes(oNewListadoPlanes, 3, 3)

                If affectedRows = 0 Then
                    MessageBox.Show("Error al aprobar", "Información")
                    Exit Sub
                Else
                    MessageBox.Show("La(s) actividad(es) fue(fueron) aprobada(s) satisfactoriamente", "Información")
                    ListarPlanes()
                End If
            End If
        End If
    End Sub

    Private Sub btnRechazar_Click(sender As System.Object, e As System.EventArgs) Handles btnRechazar.Click
        Dim oNewListadoPlanes As New List(Of PlanAnualBE)
        Dim oNewPlan As New PlanAnualBE


        For Each dgvr As DataGridViewRow In dgvListado.Rows

            If dgvr.Cells("flg_seleccionar").GetType.ToString = "System.Windows.Forms.DataGridViewCheckBoxCell" Then
                If dgvr.Cells("flg_seleccionar").Value = True Then

                    oNewPlan = New PlanAnualBE
                    oNewPlan.id_plan = dgvr.Cells("id_plan").Value
                    oNewListadoPlanes.Add(oNewPlan)

                End If

            End If
        Next


        If oNewListadoPlanes.Count = 0 Then
            MessageBox.Show("Seleccione un Plan Anual al menos", "Información")
            Exit Sub
        Else
            If MsgBox("Seguro que desea rechazar la(s) actividad(es)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.InsertarSeguimientoPlanes(oNewListadoPlanes, 3, 5)

                If affectedRows = 0 Then
                    MessageBox.Show("Error al rechazar", "Información")
                    Exit Sub
                Else
                    MessageBox.Show("El(Los) plan(es) fue(fueron) rechazado(s) satisfactoriamente", "Información")
                    ListarPlanes()
                End If
            End If
        End If
    End Sub

#End Region

End Class
