Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmPresupuestoActividad
    Dim bc As New BusinessController
    Dim msjInfo As String

#Region "Propiedades"

    Private _id_actividad As Integer?
    Public Property id_actividad() As Integer?
        Get
            Return _id_actividad
        End Get
        Set(ByVal value As Integer?)
            _id_actividad = value
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

#Region "Cargar"

    Private Sub frmPresupuestoActividad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If id_actividad IsNot Nothing Then
            CargarActividad(id_actividad)
        End If
    End Sub

#End Region

#Region "Métodos Personalizados"

    Private Sub CargarActividad(ByVal id_actividad As Integer)
        Dim oActividad As ActividadBE = bc.CargarActividadCabecera(id_actividad)

        lblNombre.Text = oActividad.nombre
        lblComite.Text = oActividad.nombrecomite
        lblTipo.Text = oActividad.desc_tipo
        lblFecha.Text = oActividad.fecha
        lblEstado.Text = oActividad.desc_estado

        ListarPresupuesto(oActividad.id_actividad)

        Sugerencias(oActividad.id_comite, oActividad.id_tipo_act)
    End Sub

    Private Sub ListarPresupuesto(ByVal id_actividad As Integer)

        Dim presupuesto As PresupuestoActividadBE = bc.ObtenerPresupuestoActividad(id_actividad)

        Dim detallePresupuesto As New List(Of DetallePresupuestoActBE)

        If presupuesto Is Nothing OrElse presupuesto.id_actividad <> id_actividad Then
            detallePresupuesto = bc.ObtenerRecursosPersonalAct(id_actividad)
            CargarDetalleRecursos(detallePresupuesto)
            gbItems.Enabled = True
            sbGuardar.Visible = True

        Else
            _id_Presupuesto = presupuesto.id_presupuesto_actividad
            detallePresupuesto = bc.ListarDetallePresupuestoAct(presupuesto.id_presupuesto_actividad)

            CargarDetallePresupuesto(detallePresupuesto)

            gbItems.Enabled = False
            sbGuardar.Visible = False
        End If
    End Sub

    Private Sub Sugerencias(ByVal id_comite As String, ByVal id_tipo As String)

        ' ''''RECURSOS

        'Dim msj As String = ""

        'Dim oListadoRecursos As List(Of RecursoBE) = bc.ObtenerRecursosDemanda(id_comite, id_tipo)

        'If oListadoRecursos IsNot Nothing AndAlso oListadoRecursos.Count > 0 Then
        '    msj = "Recursos con mayor demanda: " & vbCrLf
        '    For Each oRecurso As RecursoBE In oListadoRecursos
        '        msj &= "- " & oRecurso.descripcion & vbCrLf
        '    Next
        '    msj &= vbCrLf
        'End If

        ' ''''TIPO PERSONAL

        'Dim oListadoTipo As List(Of TipoPersonalBE) = bc.ObtenerTipoPersonalDemanda(id_comite, id_tipo)

        'If oListadoTipo IsNot Nothing AndAlso oListadoTipo.Count > 0 Then
        '    msj &= "Tipo de Personal con mayor demanda: " & vbCrLf
        '    For Each oTipo As TipoPersonalBE In oListadoTipo
        '        msj &= "- " & oTipo.descripcion & vbCrLf
        '    Next
        'End If

        'If msj = "" Then
        '    pbPresupuesto.Visible = False
        'Else
        '    pbPresupuesto.Visible = True
        '    SugerenciasToolTip.SetToolTip(pbPresupuesto, msj)
        'End If




        Dim msj As String = ""
        msjInfo = ""
        Dim oParam As ParametrosBE = bc.ObtenerParametro(1)
        Dim fecIni As Date = DateAdd(DateInterval.Month, CInt(oParam.val_param) * -1, Now)

        msjInfo = "Demanda de Recursos y Tipo de Personal" & vbCrLf & "(Cantidad de Recursos y Tipo de Personal):" & vbCrLf & vbCrLf
        msjInfo &= "Fechas: " & fecIni.Date & " - " & Now.Date & vbCrLf & vbCrLf

        Dim oListado As List(Of RecursoBE) = bc.ListarDemandaRecursos(fecIni, Now, id_comite, id_tipo)
        Dim maxCant As Integer = 0
        Dim resultado As String = ""

        If oListado IsNot Nothing AndAlso oListado.Count > 0 Then
            msjInfo &= "Recursos" & vbCrLf
            For Each oFact As RecursoBE In oListado

                msjInfo &= "- " & oFact.descripcion & " : " & oFact.cantidad & vbCrLf & vbCrLf

                If oFact.cantidad > maxCant Then
                    maxCant = oFact.cantidad
                    resultado = "Recurso: " & oFact.descripcion & " - " & oFact.cantidad
                ElseIf oFact.cantidad = maxCant Then
                    resultado &= vbCrLf & oFact.descripcion & " - " & oFact.cantidad
                End If
            Next

            'msjInfo &= vbCrLf & "Resultados:" & vbCrLf & resultado

        End If

        Dim oListadoTP As List(Of TipoPersonalBE) = bc.ListarDemandaTipoPersonal(fecIni, Now, id_comite, id_tipo)
        Dim maxCantTP As Integer = 0
        Dim resultadoTP As String = ""

        If oListadoTP IsNot Nothing AndAlso oListadoTP.Count > 0 Then
            msjInfo &= "Tipo de Personal" & vbCrLf
            For Each oFact As TipoPersonalBE In oListadoTP

                msjInfo &= "- " & oFact.descripcion & " : " & oFact.cantidad & vbCrLf

                If oFact.cantidad > maxCantTP Then
                    maxCantTP = oFact.cantidad
                    resultadoTP = "Tipo de Personal: " & oFact.descripcion & " - " & oFact.cantidad
                ElseIf oFact.cantidad = maxCantTP Then
                    resultadoTP &= vbCrLf & oFact.descripcion & " - " & oFact.cantidad
                End If
            Next

            'msjInfo &= vbCrLf & "Resultados:" & vbCrLf & resultadoTP

        End If



        If resultado = "" And resultadoTP = "" Then
            btnPresupuesto.Visible = False
        Else
            btnPresupuesto.Visible = True
            msjInfo &= vbCrLf & "Resultados:" & vbCrLf & resultado & vbCrLf & resultadoTP
            SugerenciasToolTip.SetToolTip(btnPresupuesto, resultado & vbCrLf & resultadoTP)
        End If



    End Sub

    Private Sub CargarDetalleRecursos(ByRef ListaDetalle As List(Of DetallePresupuestoActBE))

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

            For Each a As DetallePresupuestoActBE In ListaDetalle
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

    Private Sub CargarDetallePresupuesto(ByRef ListaDetalle As List(Of DetallePresupuestoActBE))

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

            For Each a As DetallePresupuestoActBE In ListaDetalle
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

    Private Function GuardarPresupuesto(ByVal id_actividad As Integer) As Boolean
        Dim flag As Boolean = True

        Dim affectedRows As Integer = 0
        Dim oPresupuesto As New PresupuestoActividadBE
        oPresupuesto.id_actividad = _id_actividad
        oPresupuesto.monto = CDec(txtMontoTotal.Text)
        Dim oListadoDetalle As New List(Of DetallePresupuestoActBE)
        Dim newDetalle As DetallePresupuestoActBE

        For Each documento As DataGridViewRow In dgvListado.Rows
            newDetalle = New DetallePresupuestoActBE
            newDetalle.idItem = documento.Cells("CodItem").Value
            newDetalle.tipo_item = documento.Cells("tipo_item").Value
            newDetalle.cantidad = CInt(documento.Cells("cant").Value)
            newDetalle.monto = CDec(documento.Cells("monto").Value)

            oListadoDetalle.Add(newDetalle)
        Next

        oPresupuesto.ListadoDetallePresupuesto = oListadoDetalle

        affectedRows = bc.InsertarPresupuestoActividad(oPresupuesto)

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            _id_Presupuesto = affectedRows
            MessageBox.Show("El Presupuesto se registro satisfactoriamente", "Información")
            _id_actividad = id_actividad
        End If


        Return flag
    End Function

    Private Sub LimpiarPresupuesto()

        lblNombre.Text = "-"
        lblComite.Text = "-"
        lblTipo.Text = "-"
        lblFecha.Text = "-"
        lblFecFin.Text = "-"
        lblEstado.Text = "-"

        dgvListado.DataSource = Nothing

        dgvListado.Enabled = True

        txtMontoTotal.Text = "0.0"

        sbGuardar.Visible = False

    End Sub

#End Region

#Region "Métodos Controles"

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim frmBuscarRecurso As New frmBuscarRecurso
        frmBuscarRecurso.ShowDialog()

        If frmBuscarRecurso.RecursoSeleccionado IsNot Nothing Then

            If dgvListado.RowCount = 0 Then

                'Dim Col_Text As DataGridViewTextBoxColumn

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "idDetalle"
                'Col_Text.HeaderText = "Codigo"
                'Col_Text.ReadOnly = True
                'Col_Text.Visible = False
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "codItem"
                'Col_Text.HeaderText = "codItem"
                'Col_Text.ReadOnly = True
                'Col_Text.Visible = False
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "descripcion"
                'Col_Text.HeaderText = "Item"
                'Col_Text.ReadOnly = True
                'Col_Text.Visible = True
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "tipo_item"
                'Col_Text.HeaderText = "Tipo"
                'Col_Text.ReadOnly = True
                'Col_Text.Visible = False
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "cant"
                'Col_Text.HeaderText = "Cantidad"
                'Col_Text.ReadOnly = False
                'Col_Text.Visible = True
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "monto"
                'Col_Text.HeaderText = "Monto"
                'Col_Text.ReadOnly = False
                'Col_Text.Visible = True
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

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
        Dim frmBuscarActividad As New frmBuscarActividad
        frmBuscarActividad.ShowDialog()

        If frmBuscarActividad.ActividadSeleccionada IsNot Nothing Then
            _id_actividad = frmBuscarActividad.ActividadSeleccionada.id_actividad
            CargarActividad(frmBuscarActividad.ActividadSeleccionada.id_actividad)

        End If
    End Sub

    Private Sub sbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles sbGuardar.Click
        'Generar presupuesto

        If GuardarPresupuesto(_id_actividad) Then
            LimpiarPresupuesto()
            CargarActividad(_id_actividad)
        End If

        'Guardar detalle
    End Sub

    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click

        Dim listadoDetalle As New List(Of DetallePresupuestoActBE)
        Dim detalle As DetallePresupuestoActBE

        For Each dgvr As DataGridViewRow In dgvListado.Rows

            If dgvr.Cells("codItem").Value = CStr(dgvListado.Item("codItem", dgvListado.CurrentRow.Index).Value) And
                dgvr.Cells("tipo_item").Value = CStr(dgvListado.Item("tipo_item", dgvListado.CurrentRow.Index).Value) Then

            Else

                detalle = New DetallePresupuestoActBE
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

            For Each a As DetallePresupuestoActBE In listadoDetalle
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

    Private Sub btnPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnPersonal.Click
        Dim frmBuscarTP As New frmBuscarTipoPersonal
        frmBuscarTP.ShowDialog()

        If frmBuscarTP.TipoPersonalSeleccionado IsNot Nothing Then

            If dgvListado.RowCount = 0 Then

                'Dim Col_Text As DataGridViewTextBoxColumn

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "idDetalle"
                'Col_Text.HeaderText = "Codigo"
                'Col_Text.ReadOnly = True
                'Col_Text.Visible = False
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "codItem"
                'Col_Text.HeaderText = "codItem"
                'Col_Text.ReadOnly = True
                'Col_Text.Visible = False
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "descripcion"
                'Col_Text.HeaderText = "Item"
                'Col_Text.ReadOnly = True
                'Col_Text.Visible = True
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "tipo_item"
                'Col_Text.HeaderText = "Tipo"
                'Col_Text.ReadOnly = True
                'Col_Text.Visible = False
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "cant"
                'Col_Text.HeaderText = "Cantidad"
                'Col_Text.ReadOnly = False
                'Col_Text.Visible = True
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

                'Col_Text = New DataGridViewTextBoxColumn
                'Col_Text.Name = "monto"
                'Col_Text.HeaderText = "Monto"
                'Col_Text.ReadOnly = False
                'Col_Text.Visible = True
                'Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'dgvListado.Columns.Add(Col_Text)

            Else
                'validacion
                For Each documento As DataGridViewRow In dgvListado.Rows
                    If documento.Cells("codItem").Value = frmBuscarTP.TipoPersonalSeleccionado.id_tipo_personal AndAlso documento.Cells("tipo_item").Value = "T" Then
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
            Cell.Value = frmBuscarTP.TipoPersonalSeleccionado.id_tipo_personal
            Row.Cells.Add(Cell)
            Cell = New DataGridViewTextBoxCell
            Cell.Value = frmBuscarTP.TipoPersonalSeleccionado.descripcion
            Row.Cells.Add(Cell)
            Cell = New DataGridViewTextBoxCell
            Cell.Value = "T"
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

    Private Sub sbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles sbLimpiar.Click
        _id_actividad = 0
        LimpiarPresupuesto()
    End Sub

#End Region

#Region "Métodos Grilla"

    Private Sub dgvListado_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellEndEdit
        If dgvListado.CurrentCell.ColumnIndex = dgvListado.Columns.Item("monto").Index Then

            Dim montoTotal As Decimal = 0.0

            For Each fila As DataGridViewRow In dgvListado.Rows
                montoTotal += CDec(fila.Cells("monto").Value)
            Next

            txtMontoTotal.Text = montoTotal

        End If
    End Sub

#End Region

    Private Sub btnPresupuesto_Click(sender As System.Object, e As System.EventArgs) Handles btnPresupuesto.Click
        MsgBox(msjInfo, MsgBoxStyle.Information)
    End Sub
End Class
