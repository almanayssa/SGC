Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmPresupuestoPlanAnual
    Dim bc As New BusinessController


#Region "Propiedades"

    Private _id_Plan As Integer?
    Public Property id_Plan() As Integer?
        Get
            Return _id_Plan
        End Get
        Set(ByVal value As Integer?)
            _id_Plan = value
        End Set
    End Property

    Private _id_Comite As String
    Public Property id_Comite() As String
        Get
            Return _id_Comite
        End Get
        Set(ByVal value As String)
            _id_Comite = value
        End Set
    End Property

    Private _id_Presupuesto As Integer?
    Public Property id_Presupuesto() As Integer?
        Get
            Return _id_Presupuesto
        End Get
        Set(ByVal value As Integer?)
            _id_Presupuesto = value
        End Set
    End Property

#End Region

    Private Sub frmPresupuestoPlanAnual_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If id_Plan IsNot Nothing Then
            CargarPlan(id_Plan)
        End If

    End Sub

    Private Sub CargarPlan(ByVal id_plan As String)
        Dim oPlan As PlanAnualBE = bc.ObtenerPlan(id_plan)

        lblPlan.Text = oPlan.id_plan
        lblComite.Text = oPlan.id_comite
        lblAnio.Text = oPlan.anio
        lblFecIni.Text = oPlan.fec_ini
        lblFecFin.Text = oPlan.fec_fin
        lblEstado.Text = oPlan.estado

        _id_Comite = oPlan.id_comite


        ListarPresupuesto(oPlan.id_plan)

        'If oPlan.id_estado = "EPA001" Then
        '    ts()
        'End If

    End Sub

    Private Sub ListarPresupuesto(ByVal idPlan As Integer)

        Dim presupuesto As PresupuestoAnualBE = bc.ObtenerPresupuestoAnual(idPlan, Nothing)

        Dim detallePresupuesto As New List(Of DetallePresupuestoAnualBE)

        If presupuesto Is Nothing Then

            detallePresupuesto = bc.ObtenerRecursosPersonalAnual(idPlan)

            CargarDetalleRecursos(detallePresupuesto)

            dgvListado.Enabled = True

        Else
            _id_Presupuesto = presupuesto.id_presupuesto_anual
            detallePresupuesto = bc.ListarDetallePresupuestoAnual(presupuesto.id_presupuesto_anual)

            CargarDetallePresupuesto(detallePresupuesto)

            dgvListado.Enabled = False
        End If
    End Sub

    Private Sub CargarDetalleRecursos(ByRef ListaDetalle As List(Of DetallePresupuestoAnualBE))

        dgvListado.Columns.Clear()
        dgvListado.DataSource = Nothing

        Dim montoTotal As Decimal = 0

        If ListaDetalle IsNot Nothing Then

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "idDetalle"
            Col_Text.HeaderText = "Codigo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "codItem"
            Col_Text.HeaderText = "codItem"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "descripcion"
            Col_Text.HeaderText = "Item"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "tipo_item"
            Col_Text.HeaderText = "Tipo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "cant"
            Col_Text.HeaderText = "Cantidad"
            Col_Text.ReadOnly = False
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "monto"
            Col_Text.HeaderText = "Monto"
            Col_Text.ReadOnly = False
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            For Each a As DetallePresupuestoAnualBE In ListaDetalle
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = ""
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.idItem
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.descripcion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.tipo_item
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.cantidad
                Cell.Style.ForeColor = Color.Black
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.monto
                Cell.Style.ForeColor = Color.Black
                Row.Cells.Add(Cell)
                
                dgvListado.Rows.Add(Row)
                montoTotal += a.monto
            Next

        End If

        txtMontoTotal.Text = montoTotal

    End Sub

    Private Sub CargarDetallePresupuesto(ByRef ListaDetalle As List(Of DetallePresupuestoAnualBE))

        dgvListado.Columns.Clear()
        dgvListado.DataSource = Nothing

        Dim montoTotal As Decimal = 0

        If ListaDetalle IsNot Nothing Then

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "idDetalle"
            Col_Text.HeaderText = "Codigo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "codItem"
            Col_Text.HeaderText = "codItem"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "descripcion"
            Col_Text.HeaderText = "Item"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "tipo_item"
            Col_Text.HeaderText = "Tipo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "cant"
            Col_Text.HeaderText = "Cantidad"
            Col_Text.ReadOnly = False
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "monto"
            Col_Text.HeaderText = "Monto"
            Col_Text.ReadOnly = False
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            For Each a As DetallePresupuestoAnualBE In ListaDetalle
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_detalle
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.idItem
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.descripcion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.tipo_item
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.cantidad
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.monto
                Row.Cells.Add(Cell)

                dgvListado.Rows.Add(Row)
                montoTotal += a.monto
            Next

        End If

        txtMontoTotal.Text = montoTotal

    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim frmBuscarRecurso As New frmBuscarRecurso
        frmBuscarRecurso.ShowDialog()

        If frmBuscarRecurso.RecursoSeleccionado IsNot Nothing Then

            If dgvListado.RowCount = 0 Then

                Dim Col_Text As DataGridViewTextBoxColumn
                
                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "idDetalle"
                Col_Text.HeaderText = "Codigo"
                Col_Text.ReadOnly = True
                Col_Text.Visible = False
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "codItem"
                Col_Text.HeaderText = "codItem"
                Col_Text.ReadOnly = True
                Col_Text.Visible = False
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "descripcion"
                Col_Text.HeaderText = "Item"
                Col_Text.ReadOnly = True
                Col_Text.Visible = True
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "tipo_item"
                Col_Text.HeaderText = "Tipo"
                Col_Text.ReadOnly = True
                Col_Text.Visible = False
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "cant"
                Col_Text.HeaderText = "Cantidad"
                Col_Text.ReadOnly = False
                Col_Text.Visible = True
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

                Col_Text = New DataGridViewTextBoxColumn
                Col_Text.Name = "monto"
                Col_Text.HeaderText = "Monto"
                Col_Text.ReadOnly = False
                Col_Text.Visible = True
                Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvListado.Columns.Add(Col_Text)

            Else
                'validacion
                For Each documento As DataGridViewRow In dgvListado.Rows
                    If documento.Cells("codItem").Value = frmBuscarRecurso.RecursoSeleccionado.id_recurso AndAlso documento.Cells("tipo_item").Value = "R" Then
                        MsgBox("No puede agregar un item que ya existe en la lista")
                        Exit Sub
                    End If
                Next

            End If

            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Row = New DataGridViewRow

            Cell = New DataGridViewTextBoxCell
            Cell.Value = ""
            Row.Cells.Add(Cell)
            Cell = New DataGridViewTextBoxCell
            Cell.Value = frmBuscarRecurso.RecursoSeleccionado.id_recurso
            Row.Cells.Add(Cell)
            Cell = New DataGridViewTextBoxCell
            Cell.Value = frmBuscarRecurso.RecursoSeleccionado.descripcion
            Row.Cells.Add(Cell)
            Cell = New DataGridViewTextBoxCell
            Cell.Value = "R"
            Row.Cells.Add(Cell)
            Cell = New DataGridViewTextBoxCell
            Cell.Value = 0
            Cell.Style.ForeColor = Color.Black
            Row.Cells.Add(Cell)
            Cell = New DataGridViewTextBoxCell
            Cell.Value = 0
            Cell.Style.ForeColor = Color.Black
            Row.Cells.Add(Cell)

            dgvListado.Rows.Add(Row)


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

    Private Sub dgvListado_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellEndEdit
        If dgvListado.CurrentCell.ColumnIndex = dgvListado.Columns.Item("monto").Index Then

            Dim montoTotal As Decimal = 0.0

            For Each fila As DataGridViewRow In dgvListado.Rows
                     montoTotal += CDec(fila.Cells("monto").Value)
            Next



            txtMontoTotal.Text = montoTotal

        End If
    End Sub

    Private Sub sbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles sbGuardar.Click
        'Generar presupuesto

        If GuardarPresupuesto(_id_Plan) Then
            LimpiarPresupuesto()
            CargarPlan(_id_Plan)
        End If

        'Guardar detalle
    End Sub

    Private Function GuardarPresupuesto(ByVal id_plan As Integer) As Boolean
        Dim flag As Boolean = True

        Dim affectedRows As Integer = 0
        Dim oPresupuesto As New PresupuestoAnualBE
        oPresupuesto.id_plan = _id_Plan
        oPresupuesto.id_comite = _id_Comite
        oPresupuesto.monto = CDec(txtMontoTotal.Text)
        Dim oListadoDetalle As New List(Of DetallePresupuestoAnualBE)
        Dim newDetalle As DetallePresupuestoAnualBE

        For Each documento As DataGridViewRow In dgvListado.Rows
            newDetalle = New DetallePresupuestoAnualBE
            newDetalle.idItem = documento.Cells("CodItem").Value
            newDetalle.tipo_item = documento.Cells("tipo_item").Value
            newDetalle.cantidad = CInt(documento.Cells("cant").Value)
            newDetalle.monto = CDec(documento.Cells("monto").Value)

            oListadoDetalle.Add(newDetalle)
        Next

        oPresupuesto.ListadoDetallePresupuesto = oListadoDetalle

        affectedRows = bc.InsertarPresupuestoAnual(oPresupuesto)

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            _id_Presupuesto = affectedRows
            MessageBox.Show("El Presupuesto se registro satisfactoriamente", "Información")
            _id_Plan = id_plan
        End If


        Return flag
    End Function

    Private Sub sbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles sbLimpiar.Click
        _id_Plan = 0
        LimpiarPresupuesto()

    End Sub

    Private Sub LimpiarPresupuesto()

        lblPlan.Text = "-"
        lblComite.Text = "-"
        lblAnio.Text = "-"
        lblFecIni.Text = "-"
        lblFecFin.Text = "-"
        lblEstado.Text = "-"

        dgvListado.DataSource = Nothing

        dgvListado.Enabled = True

        txtMontoTotal.Text = "0.0"

    End Sub

    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click

        Dim listadoDetalle As New List(Of DetallePresupuestoAnualBE)
        Dim detalle As DetallePresupuestoAnualBE

        For Each dgvr As DataGridViewRow In dgvListado.Rows

            If dgvr.Cells("codItem").Value = CStr(dgvListado.Item("codItem", dgvListado.CurrentRow.Index).Value) And
                dgvr.Cells("tipo_item").Value = CStr(dgvListado.Item("tipo_item", dgvListado.CurrentRow.Index).Value) Then

            Else

                detalle = New DetallePresupuestoAnualBE
                If dgvr.Cells("idDetalle").Value <> "" Then detalle.id_detalle = dgvr.Cells("idDetalle").Value
                detalle.idItem = dgvr.Cells("codItem").Value
                detalle.descripcion = dgvr.Cells("descripcion").Value
                detalle.tipo_item = dgvr.Cells("tipo_item").Value
                detalle.cantidad = dgvr.Cells("cant").Value
                detalle.monto = dgvr.Cells("monto").Value
                listadoDetalle.Add(detalle)

            End If

        Next


        dgvListado.Columns.Clear()
        dgvListado.DataSource = Nothing

        Dim montoTotal As Decimal = 0

        If listadoDetalle IsNot Nothing Then

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "idDetalle"
            Col_Text.HeaderText = "Codigo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "codItem"
            Col_Text.HeaderText = "codItem"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "descripcion"
            Col_Text.HeaderText = "Item"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "tipo_item"
            Col_Text.HeaderText = "Tipo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "cant"
            Col_Text.HeaderText = "Cantidad"
            Col_Text.ReadOnly = False
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "monto"
            Col_Text.HeaderText = "Monto"
            Col_Text.ReadOnly = False
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvListado.Columns.Add(Col_Text)

            For Each a As DetallePresupuestoAnualBE In listadoDetalle
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = ""
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.idItem
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.descripcion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.tipo_item
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.cantidad
                Cell.Style.ForeColor = Color.Black
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.monto
                Cell.Style.ForeColor = Color.Black
                Row.Cells.Add(Cell)

                dgvListado.Rows.Add(Row)
                montoTotal += a.monto
            Next

        End If

        txtMontoTotal.Text = montoTotal

    End Sub
End Class
