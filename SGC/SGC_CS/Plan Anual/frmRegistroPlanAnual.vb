Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmRegistroPlanAnual
    Dim bc As New BusinessController
    Private _id_Plan As Integer


#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

    End Sub

#End Region

#Region "Cargar"

    Private Sub frmRegistroPlanAnual_Load(sender As Object, e As System.EventArgs) Handles Me.Load
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
        Dim id As String() = New String(1) {CStr(Now.Year - 1), CStr(Now.Year)}
        Dim desc As String() = New String(1) {CStr(Now.Year - 1), CStr(Now.Year)}

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


        cboAnio.SelectedValue = Now.Year
    End Sub

    Private Function GuardarPlan() As Boolean


        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            Exit Function
        End If


        Dim flag As Boolean = True

        Dim affectedRows As Integer = 0
        Dim oPlan As New PlanAnualBE
        oPlan.id_comite = cboComite.SelectedValue
        oPlan.descripcion = "Plan Anual de " & DirectCast(cboComite.SelectedItem, ComiteBE).nombre & " del " & cboAnio.SelectedValue
        oPlan.anio = cboAnio.SelectedValue
        oPlan.fec_ini = dtpFecIni.Value
        oPlan.fec_fin = dtpFecFin.Value
        oPlan.id_estado = "EPA001"

        If txtCodigo.Text = String.Empty Then
            affectedRows = bc.InsertarPlanAnual(oPlan)
        Else
            oPlan.id_plan = txtCodigo.Text

            affectedRows = bc.ActualizarPlanAnual(oPlan)
        End If

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            If txtCodigo.Text = String.Empty Then
                'txtCodigo.Text = affectedRows
                _id_Plan = affectedRows
                MessageBox.Show("El Plan se registro satisfactoriamente", "Información")
                CargarPlan(_id_Plan)
            Else
                _id_Plan = oPlan.id_plan
                MessageBox.Show("El plan se actualizó satisfactoriamente", "Información")
            End If
        End If


        Return flag
    End Function

    Private Sub LimpiarFormulario()
        txtCodigo.Text = String.Empty
        cboComite.SelectedIndex = 0
        cboAnio.SelectedIndex = 0
        dtpFecIni.Value = Today
        dtpFecFin.Value = DateAdd(DateInterval.Year, 1, Now)
        dgvActividades.DataSource = Nothing

        btnGrabarPlan.Enabled = True
        btnEditarPlan.Enabled = False
        btnPresupuesto.Enabled = False
        gbDetalle.Enabled = False
    End Sub

    Private Sub CargarPlan(ByVal id_plan As String)
        Dim oPlan As PlanAnualBE = bc.ObtenerPlan(id_plan)

        txtCodigo.Text = oPlan.id_plan
        cboComite.SelectedValue = oPlan.id_comite
        cboAnio.SelectedValue = oPlan.anio
        dtpFecIni.Value = oPlan.fec_ini
        dtpFecFin.Value = oPlan.fec_fin
        lblEstado.Text = oPlan.estado

        ListarActividades(oPlan.id_comite, oPlan.id_plan)


        If oPlan.id_estado <> "EPA001" Then
            gbDetalle.Enabled = False
        Else
            gbDetalle.Enabled = True
        End If

        btnEditarPlan.Enabled = True
        btnPresupuesto.Enabled = True
        btnGrabarPlan.Enabled = False
        btnGrabarDetalle.Enabled = True

        ModoEdicionPlan(False)
    End Sub

    Private Sub ListarActividades(ByVal id_comite As String, ByVal id_plan As Integer?)
        Dim oListado As List(Of ActividadBE) = bc.ListarActividadesPlan(id_comite, id_plan)

        dgvActividades.Columns.Clear()
        dgvActividades.DataSource = Nothing

        If oListado IsNot Nothing Then

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Col_Chk As DataGridViewCheckBoxColumn
            Dim Col_Btn As DataGridViewButtonColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_actividad"
            Col_Text.HeaderText = "Id"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            dgvActividades.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_comite"
            Col_Text.HeaderText = "idComite"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvActividades.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "nombrecomite"
            Col_Text.HeaderText = "Comite"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvActividades.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "nombre"
            Col_Text.HeaderText = "Actividad"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvActividades.Columns.Add(Col_Text)

            Col_Chk = New DataGridViewCheckBoxColumn
            Col_Chk.Name = "flg_plan_anual"
            Col_Chk.HeaderText = "Plan Anual"
            Col_Chk.ReadOnly = False
            Col_Chk.Visible = True
            Col_Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvActividades.Columns.Add(Col_Chk)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_plan"
            Col_Text.HeaderText = "idPlan"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvActividades.Columns.Add(Col_Text)

            Col_Btn = New DataGridViewButtonColumn
            Col_Btn.Name = "btn"
            Col_Btn.HeaderText = ""
            Col_Btn.ReadOnly = True
            Col_Btn.Visible = True
            Col_Btn.FlatStyle = FlatStyle.Flat

            Col_Btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Col_Btn.UseColumnTextForButtonValue = True
            dgvActividades.Columns.Add(Col_Btn)

            For Each a As ActividadBE In oListado
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_actividad
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_comite
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.nombrecomite
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.nombre
                Row.Cells.Add(Cell)
                Cell = New DataGridViewCheckBoxCell
                Cell.Value = a.flg_plan_anual
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_plan
                Row.Cells.Add(Cell)
                Cell = New DataGridViewButtonCell
                Cell.Value = "Ver"
                Cell.Style.ForeColor = Color.SteelBlue

                Row.Cells.Add(Cell)

                dgvActividades.Rows.Add(Row)
            Next

        End If

        gbDetalle.Enabled = True
        btnGrabarDetalle.Enabled = True
    End Sub

    Private Sub ModoEdicionPlan(ByVal op As Boolean)
        cboComite.Enabled = op
        cboAnio.Enabled = op
        dtpFecFin.Enabled = op
        dtpFecIni.Enabled = op
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If dtpFecIni.Value > dtpFecFin.Value Then
            msg &= vbCrLf & "- Registrar rango de fechas válidas"
        End If

        Return msg
    End Function


#End Region

#Region "Metodos Controles"

    Private Sub btnGrabarPlan_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabarPlan.Click
        If MsgBox("Desea registrar el Plan Anual?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If GuardarPlan() Then
                LimpiarFormulario()
                CargarPlan(_id_Plan)
            End If
        End If


    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim frmBuscarPlan As New frmBuscarPlan
        frmBuscarPlan.ShowDialog()

        If frmBuscarPlan.PlanSeleccionado IsNot Nothing Then
            _id_Plan = frmBuscarPlan.PlanSeleccionado.id_plan
            CargarPlan(frmBuscarPlan.PlanSeleccionado.id_plan)


        End If
    End Sub

    Private Sub btnEditarPlan_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarPlan.Click
        ModoEdicionPlan(True)
    End Sub

    Private Sub btnGrabarDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabarDetalle.Click

        If MsgBox("Desea registrar las actividades del Plan Anual?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim newListadoActividades As New List(Of ActividadBE)
        Dim oNewActividad As New ActividadBE

        For Each dgvr As DataGridViewRow In dgvActividades.Rows

            If dgvr.Cells("flg_plan_anual").GetType.ToString = "System.Windows.Forms.DataGridViewCheckBoxCell" Then
                If dgvr.Cells("flg_plan_anual").Value = True Then

                    oNewActividad = New ActividadBE
                    oNewActividad.id_actividad = dgvr.Cells("id_actividad").Value
                    oNewActividad.id_plan = _id_Plan
                    newListadoActividades.Add(oNewActividad)

                End If

            End If
        Next


        If newListadoActividades IsNot Nothing Then

            Dim newPlan As New PlanAnualBE
            newPlan.id_plan = _id_Plan
            newPlan.ListadoActividades = newListadoActividades
            Dim affectedRows As Integer

            If bc.InsertarActividadesPlanXML(newPlan) Then
                MessageBox.Show("Se registró satisfactoriamente las actividades en el plan.", "Información")
            Else
                MessageBox.Show("Error al grabar", "Información")
            End If

        End If


    End Sub

    Private Sub btnPresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles btnPresupuesto.Click

        frmPresupuestoPlan.Close()
        frmPresupuestoPlan.MdiParent = MDI
        frmPresupuestoPlan.id_Plan = _id_Plan
        frmPresupuestoPlan.Show()

    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvActividades_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvActividades.CellClick
        If e.ColumnIndex = dgvActividades.Columns("btn").Index Then
            frmRegistroActividad.Close()
            frmRegistroActividad.MdiParent = MDI
            frmRegistroActividad.id_act = CStr(dgvActividades.Item("id_actividad", dgvActividades.CurrentRow.Index).Value)
            frmRegistroActividad.Show()
        End If
    End Sub

#End Region

End Class
