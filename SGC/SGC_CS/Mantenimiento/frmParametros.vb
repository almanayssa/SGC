Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmParametros

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvListado.AutoGenerateColumns = False

        colId.DataPropertyName = "id_parametro"
        colParametro.DataPropertyName = "des_param"
        colValor.DataPropertyName = "val_param"
        colObservacion.DataPropertyName = "observacion"

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        For Each row As DataGridViewRow In dgvListado.Rows
            
            If row.Cells(colValor.Index).Value = Nothing Then
                msg &= vbCrLf & "- Ingrese valor de los parámetros"
                Exit For
            End If
        Next

        Return msg
    End Function

    Private Sub ListarParametros()
        Dim ListadoParametros As List(Of ParametrosBE) = bc.ListarParametros()
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoParametros
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmParametros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarParametros()

    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            Exit Sub
        End If


        Dim affectedRows As Integer = 0
        Dim ListaParametros As New List(Of ParametrosBE)

        For Each row As DataGridViewRow In dgvListado.Rows

            Dim oParametro As ParametrosBE = row.DataBoundItem

            oParametro.id_parametro = row.Cells(colId.Index).Value
            oParametro.val_param = row.Cells(colValor.Index).Value
            oParametro.observacion = row.Cells(colObservacion.Index).Value
            ListaParametros.Add(oParametro)
        Next

        affectedRows = bc.ActualizarParametros(ListaParametros)


        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
        Else
            MessageBox.Show("Los parámetros se actualizaron satisfactoriamente", "Información")

        End If


    End Sub

#End Region

    Private Sub dgvListado_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles dgvListado.CurrentCellDirtyStateChanged
        If dgvListado.IsCurrentCellDirty Then
            dgvListado.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class
