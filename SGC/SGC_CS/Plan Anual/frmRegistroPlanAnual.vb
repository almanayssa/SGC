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

    Private Sub frmRegistroPlanAnual_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarAnio()
    End Sub


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

    Private Function GuardarPlan() As Boolean
        
        Dim affectedRows As Integer = 0
        Dim oPlan As New PlanAnualBE
        oPlan.id_comite = cboComite.SelectedValue
        oPlan.descripcion = "Plan Anual de " & DirectCast(cboComite.SelectedItem, ComiteBE).nombre & " del " & cboAnio.SelectedValue
        oPlan.anio = cboAnio.SelectedValue
        oPlan.fec_ini = dtpFecIni.Value
        oPlan.fec_fin = dtpFecFin.Value
        
        If txtCodigo.Text = String.Empty Then
            affectedRows = bc.InsertarPlanAnual(oPlan)
        Else
            oPlan.id_plan = txtCodigo.Text
            
            affectedRows = bc.ActualizarPlanAnual(oPlan)
        End If

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")

        Else
            If txtCodigo.Text = String.Empty Then
                'txtCodigo.Text = affectedRows
                _id_Plan = affectedRows
                MessageBox.Show("El Plan se registro satisfactoriamente", "Información")
            Else
                _id_Plan = oPlan.id_plan
                MessageBox.Show("El plan se actualizó satisfactoriamente", "Información")
            End If
        End If

    End Function

#End Region

    Private Sub btnGrabarPlan_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabarPlan.Click
        GuardarPlan()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim frmBuscarPlan As New frmBuscarPlan
        frmBuscarPlan.ShowDialog()

        If frmBuscarPlan.PlanSeleccionado IsNot Nothing Then
            _id_Plan = frmBuscarPlan.PlanSeleccionado.id_plan
            'CargarPlan(frmBuscarPlan.PlanSeleccionado.id_plan)

        End If
    End Sub
End Class
