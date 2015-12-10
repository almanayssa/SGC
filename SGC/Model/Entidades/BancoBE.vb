Namespace SGC.Model.Entidades
    Public Class BancoBE

        Private _id_banco As Integer
        Public Property id_banco() As Integer
            Get
                Return _id_banco
            End Get
            Set(ByVal value As Integer)
                _id_banco = value
            End Set
        End Property

        Private _des_ban As String
        Public Property des_ban() As String
            Get
                Return _des_ban
            End Get
            Set(ByVal value As String)
                _des_ban = value
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

