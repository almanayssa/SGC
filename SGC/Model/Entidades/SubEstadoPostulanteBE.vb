Namespace SGC.Model.Entidades
    Public Class SubEstadoPostulanteBE

        Private _id_subestado As String
        Public Property id_subestado() As String
            Get
                Return _id_subestado
            End Get
            Set(ByVal value As String)
                _id_subestado = value
            End Set
        End Property

        Private _des_sub As String
        Public Property des_sub() As String
            Get
                Return _des_sub
            End Get
            Set(ByVal value As String)
                _des_sub = value
            End Set
        End Property

        Private _flg_subestado As Boolean
        Public Property flg_subestado() As Boolean
            Get
                Return _flg_subestado
            End Get
            Set(ByVal value As Boolean)
                _flg_subestado = value
            End Set
        End Property

    End Class
End Namespace

