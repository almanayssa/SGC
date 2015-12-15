Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmPlanEvaluacionPGC

    Dim bc As New BusinessController
    Private ListadoPlanPendiente As List(Of PlanAnualBE)
    Private ListadoPlanAprobado As List(Of PlanAnualBE)
    Private ListadoPlanRechazado As List(Of PlanAnualBE)

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

    End Sub

#End Region

#Region "Cargar"

    Private Sub frmPlanEvaluacionPGC_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarAnio()
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
        ListadoPlanPendiente = bc.ListarPlanesPendientesPGC(cboComite.SelectedValue, cboAnio.SelectedValue)
        CargarPlanesPendientes(ListadoPlanPendiente)

        ListadoPlanAprobado = bc.ListarPlanesAprobadosPGC(cboComite.SelectedValue, cboAnio.SelectedValue)
        CargarPlanesAprobados(ListadoPlanAprobado)

        ListadoPlanRechazado = bc.ListarPlanesRechazadosPGC(cboComite.SelectedValue, cboAnio.SelectedValue)
        CargarPlanesRechazados(ListadoPlanRechazado)
    End Sub


    Private Sub CargarPlanesPendientes(ByRef ListaPlan As List(Of PlanAnualBE))

        dgvRegistrados.Columns.Clear()
        dgvRegistrados.DataSource = Nothing

        If ListaPlan IsNot Nothing Then

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Col_Chk As DataGridViewCheckBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_plan"
            Col_Text.HeaderText = "Codigo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            dgvRegistrados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "descripcion"
            Col_Text.HeaderText = "Plan Anual"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRegistrados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_comite"
            Col_Text.HeaderText = "id_comite"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRegistrados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "comite"
            Col_Text.HeaderText = "Comite"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRegistrados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "anio"
            Col_Text.HeaderText = "Año"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRegistrados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fec_ini"
            Col_Text.HeaderText = "Fecha Inicio"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRegistrados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fec_fin"
            Col_Text.HeaderText = "Fecha Fin"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRegistrados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_estado"
            Col_Text.HeaderText = "id_estado"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRegistrados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "estado"
            Col_Text.HeaderText = "Estado"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRegistrados.Columns.Add(Col_Text)

            Col_Chk = New DataGridViewCheckBoxColumn
            Col_Chk.Name = "flg_seleccionar"
            Col_Chk.HeaderText = "Seleccionar"
            Col_Chk.ReadOnly = False
            Col_Chk.Visible = True
            Col_Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRegistrados.Columns.Add(Col_Chk)

            For Each a As PlanAnualBE In ListaPlan
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_plan
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.descripcion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_comite
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
                Cell.Value = a.id_estado
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.estado
                Row.Cells.Add(Cell)
                Cell = New DataGridViewCheckBoxCell
                Cell.Value = False
                Row.Cells.Add(Cell)

                dgvRegistrados.Rows.Add(Row)
            Next

        End If

    End Sub

    Private Sub CargarPlanesAprobados(ByRef ListaPlan As List(Of PlanAnualBE))

        dgvAprobados.Columns.Clear()
        dgvAprobados.DataSource = Nothing

        If ListaPlan IsNot Nothing Then

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Col_Chk As DataGridViewCheckBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_plan"
            Col_Text.HeaderText = "Codigo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            dgvAprobados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "descripcion"
            Col_Text.HeaderText = "Plan Anual"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAprobados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_comite"
            Col_Text.HeaderText = "id_comite"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAprobados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "comite"
            Col_Text.HeaderText = "Comite"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAprobados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "anio"
            Col_Text.HeaderText = "Año"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAprobados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fec_ini"
            Col_Text.HeaderText = "Fecha Inicio"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAprobados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fec_fin"
            Col_Text.HeaderText = "Fecha Fin"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAprobados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_estado"
            Col_Text.HeaderText = "id_estado"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAprobados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "estado"
            Col_Text.HeaderText = "Estado"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAprobados.Columns.Add(Col_Text)

            Col_Chk = New DataGridViewCheckBoxColumn
            Col_Chk.Name = "flg_seleccionar"
            Col_Chk.HeaderText = "Seleccionar"
            Col_Chk.ReadOnly = False
            Col_Chk.Visible = True
            Col_Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAprobados.Columns.Add(Col_Chk)

            For Each a As PlanAnualBE In ListaPlan
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_plan
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.descripcion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_comite
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
                Cell.Value = a.id_estado
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.estado
                Row.Cells.Add(Cell)
                Cell = New DataGridViewCheckBoxCell
                Cell.Value = False
                Row.Cells.Add(Cell)

                dgvAprobados.Rows.Add(Row)
            Next

        End If

    End Sub

    Private Sub CargarPlanesRechazados(ByRef ListaPlan As List(Of PlanAnualBE))

        dgvRechazados.Columns.Clear()
        dgvRechazados.DataSource = Nothing

        If ListaPlan IsNot Nothing Then

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Col_Chk As DataGridViewCheckBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_plan"
            Col_Text.HeaderText = "Codigo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            dgvRechazados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "descripcion"
            Col_Text.HeaderText = "Plan Anual"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRechazados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_comite"
            Col_Text.HeaderText = "id_comite"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRechazados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "comite"
            Col_Text.HeaderText = "Comite"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRechazados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "anio"
            Col_Text.HeaderText = "Año"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRechazados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fec_ini"
            Col_Text.HeaderText = "Fecha Inicio"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRechazados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fec_fin"
            Col_Text.HeaderText = "Fecha Fin"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRechazados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_estado"
            Col_Text.HeaderText = "id_estado"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRechazados.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "estado"
            Col_Text.HeaderText = "Estado"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRechazados.Columns.Add(Col_Text)

            Col_Chk = New DataGridViewCheckBoxColumn
            Col_Chk.Name = "flg_seleccionar"
            Col_Chk.HeaderText = "Seleccionar"
            Col_Chk.ReadOnly = False
            Col_Chk.Visible = True
            Col_Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRechazados.Columns.Add(Col_Chk)

            For Each a As PlanAnualBE In ListaPlan
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_plan
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.descripcion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_comite
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
                Cell.Value = a.id_estado
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.estado
                Row.Cells.Add(Cell)
                Cell = New DataGridViewCheckBoxCell
                Cell.Value = False
                Row.Cells.Add(Cell)

                dgvRechazados.Rows.Add(Row)
            Next

        End If

    End Sub

#End Region

    Private Sub cboBuscar_Click(sender As System.Object, e As System.EventArgs) Handles cboBuscar.Click
        If cboComite.SelectedValue = "000" Then
            MessageBox.Show("Seleccione un comité", "Información")
            Exit Sub
        Else
            ListarPlanes()
        End If
    End Sub

    Private Sub btnEnviarCD_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviarCD.Click
        Dim oNewListadoPlanes As New List(Of PlanAnualBE)
        Dim oNewPlan As New PlanAnualBE


        For Each dgvr As DataGridViewRow In dgvRegistrados.Rows

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
            If MsgBox("Seguro que desea enviar el(los) plan(es) a Consejo Directivo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.InsertarSeguimientoPlanes(oNewListadoPlanes, 1, 1)

                If affectedRows = 0 Then
                    MessageBox.Show("Error al enviar", "Información")
                    Exit Sub
                Else
                    MessageBox.Show("La(s) actividad(es) fue(fueron) enviada(s) satisfactoriamente", "Información")
                    listarPlanes()
                End If
            End If
        End If
    End Sub

    Private Sub btnAprobar_Click(sender As System.Object, e As System.EventArgs) Handles btnAprobar.Click
        Dim oNewListadoPlanes As New List(Of PlanAnualBE)
        Dim oNewPlan As New PlanAnualBE

        For Each dgvr As DataGridViewRow In dgvAprobados.Rows

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
                affectedRows = bc.ActualizarPlanEstado(oNewListadoPlanes, "EPA004")

                If affectedRows = 0 Then
                    MessageBox.Show("Error al aprobar", "Información")
                    Exit Sub
                Else
                    MessageBox.Show("El(los) plan(es) fue(fueron) aprobado(s) satisfactoriamente", "Información")
                    ListarPlanes()
                End If
            End If
        End If
    End Sub

    Private Sub btnRechazar_Click(sender As System.Object, e As System.EventArgs) Handles btnRechazar.Click
        Dim oNewListadoPlanes As New List(Of PlanAnualBE)
        Dim oNewPlan As New PlanAnualBE

        For Each dgvr As DataGridViewRow In dgvAprobados.Rows

            If dgvr.Cells("flg_seleccionar").GetType.ToString = "System.Windows.Forms.DataGridViewCheckBoxCell" Then
                If dgvr.Cells("flg_seleccionar").Value = True Then

                    oNewPlan = New PlanAnualBE
                    oNewPlan.id_plan = dgvr.Cells("id_plan").Value
                    oNewListadoPlanes.Add(oNewPlan)

                End If

            End If
        Next

        If oNewListadoPlanes.Count = 0 Then
            MessageBox.Show("Seleccione un Plan Anual al rechazar", "Información")
            Exit Sub
        Else
            If MsgBox("Seguro que desea rechazar el(los) plan(es)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.ActualizarPlanEstado(oNewListadoPlanes, "EPA005")

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
End Class
