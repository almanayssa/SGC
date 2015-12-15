Imports SGC.Model.Entidades
Imports SGC.Controller


Public Class frmRegistroInscripcion

    Dim bc As New BusinessController
    Private Actividad As ActividadBE

#Region "Métodos Controles"

    Private Sub btnBuscarActividad_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarActividad.Click
        Dim frmBuscarActividad As New frmBuscarActividad
        frmBuscarActividad.id_estado = "EST005"
        frmBuscarActividad.ShowDialog()

        If frmBuscarActividad.ActividadSeleccionada IsNot Nothing Then
            CargarActividad(frmBuscarActividad.ActividadSeleccionada.id_actividad)

        End If
    End Sub

    Private Sub btnBuscarSocio_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarSocio.Click
        Dim frmBuscarSocio As New frmBuscarSocio
        frmBuscarSocio.ShowDialog()

        If frmBuscarSocio.SocioSeleccionado IsNot Nothing Then
            'CargarSocio(frmBuscarSocio.SocioSeleccionado.id_socio)

        End If
    End Sub

#End Region

#Region "Métodos Personalizados"

    Private Sub CargarActividad(ByVal id_actividad As String)
        Dim oActividad As ActividadBE = bc.CargarActividadCabecera(id_actividad)
        Actividad = oActividad
        txtCodigo.Text = oActividad.id_actividad
        txtActividad.Text = "Actividad: " & oActividad.nombre & vbCrLf & _
                            "Tipo de Actividad: " & oActividad.desc_tipo & vbCrLf & _
                            "Comite: " & oActividad.nombrecomite & vbCrLf & _
                            "Pago: " & oActividad.monto_pago & vbCrLf & _
                            "Vacantes: " & oActividad.vacantes

        ListarRestriccionesXActividad()
        VerProgramacionxActividad()


    End Sub

    Private Sub ListarRestriccionesXActividad()


        dgvRestricciones.Columns.Clear()
        dgvRestricciones.DataSource = Nothing


        Dim ListadoRestricciones As List(Of RestriccionesBE) = bc.ListarRestriccionesXActividad(CInt(txtCodigo.Text.Trim))

        If ListadoRestricciones IsNot Nothing AndAlso ListadoRestricciones.Count > 0 Then


            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Col_Chk As DataGridViewCheckBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_restriccion"
            Col_Text.HeaderText = "Id"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            dgvRestricciones.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "descripcion"
            Col_Text.HeaderText = "Descripción"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRestricciones.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_signo"
            Col_Text.HeaderText = "idSigno"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRestricciones.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "signo"
            Col_Text.HeaderText = "Signo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRestricciones.Columns.Add(Col_Text)

            Col_Chk = New DataGridViewCheckBoxColumn
            Col_Chk.Name = "valor"
            Col_Chk.HeaderText = "Valor"
            Col_Chk.ReadOnly = False
            Col_Chk.Visible = True
            Col_Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRestricciones.Columns.Add(Col_Chk)

            For Each a As RestriccionesBE In ListadoRestricciones
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_restriccion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.descripcion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_signo
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.des_signo
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.valor
                Row.Cells.Add(Cell)

                dgvRestricciones.Rows.Add(Row)
            Next

        End If
    End Sub

    Private Sub VerProgramacionxActividad()

        dgvProgramacion.Columns.Clear()
        dgvProgramacion.DataSource = Nothing

        Dim ListadoProgramacion As List(Of ActividadDetalleBE) = bc.ListarDetallesXActividad(CInt(txtCodigo.Text.Trim))

        If ListadoProgramacion IsNot Nothing AndAlso ListadoProgramacion.Count > 0 Then



            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Col_Chk As DataGridViewCheckBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fecha_ini"
            Col_Text.HeaderText = "Fecha"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            dgvProgramacion.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "hora_ini"
            Col_Text.HeaderText = "Inicio"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProgramacion.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "hora_fin"
            Col_Text.HeaderText = "Fin"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProgramacion.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "sede"
            Col_Text.HeaderText = "Sede"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProgramacion.Columns.Add(Col_Text)

            Col_Chk = New DataGridViewCheckBoxColumn
            Col_Chk.Name = "espacio"
            Col_Chk.HeaderText = "Ubicacion"
            Col_Chk.ReadOnly = True
            Col_Chk.Visible = True
            Col_Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProgramacion.Columns.Add(Col_Chk)

            For Each a As ActividadDetalleBE In ListadoProgramacion
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.fecha_ini
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.hora_ini
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.hora_fin
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.des_sede
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.nombre_espacio
                Row.Cells.Add(Cell)

                dgvProgramacion.Rows.Add(Row)
            Next

        End If
    End Sub

#End Region

End Class
