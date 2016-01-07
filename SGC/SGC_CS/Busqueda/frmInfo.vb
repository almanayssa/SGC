Public Class frmInfo


#Region "Propiedades"

    Private _info As String
    Public Property info() As String
        Get
            Return _info
        End Get
        Set(ByVal value As String)
            _info = value
        End Set
    End Property

#End Region


    Private Sub frmInfo_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtInfo.Text = info
    End Sub
End Class
