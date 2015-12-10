Namespace SGC.Model.Entidades
    Public Class LugarBE

        Private _id_lugar As Integer
        Public Property id_lugar() As Integer
            Get
                Return _id_lugar
            End Get
            Set(ByVal value As Integer)
                _id_lugar = value
            End Set
        End Property

        Private _desc_lugar As String
        Public Property desc_lugar() As String
            Get
                Return _desc_lugar
            End Get
            Set(ByVal value As String)
                _desc_lugar = value
            End Set
        End Property

        Private _flg_anulado As Boolean
        Public Property flg_anulado() As Boolean
            Get
                Return _flg_anulado
            End Get
            Set(ByVal value As Boolean)
                _flg_anulado = value
            End Set
        End Property

    End Class
End Namespace

