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

        ListarPresupuesto(oPlan.id_plan)

        'If oPlan.id_estado = "EPA001" Then
        '    ts()
        'End If

    End Sub

    Private Sub ListarPresupuesto(ByVal idPlan As Integer)

        Dim presupuesto As PresupuestoAnualBE = bc.ObtenerPresupuestoAnual(idPlan)

        If presupuesto IsNot Nothing Then

        End If
    End Sub


End Class
