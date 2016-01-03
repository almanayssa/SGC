Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmParametrosSugerencia

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

    End Sub

#End Region

    Private Sub frmParametrosSugerencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarParametro()
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        Dim oParametro As New ParametrosBE
        oParametro.id_parametro = 1
        oParametro.val_param = nupMeses.Value

        Dim affectedRows As Integer = 0

        affectedRows = bc.ActualizarParametro(oParametro)

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
        Else
            MessageBox.Show("El parámetro se actualizó satisfactoriamente", "Información")
        End If

    End Sub

    Public Sub CargarParametro()

        Dim oParametro As ParametrosBE = bc.ObtenerParametro(1)

        nupMeses.Value = oParametro.val_param

    End Sub

End Class
