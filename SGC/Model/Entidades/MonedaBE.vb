Namespace SGC.Model.Entidades
    Public Class MonedaBE
        Private _id_moneda As String
        Public Property id_moneda() As String
            Get
                Return _id_moneda
            End Get
            Set(ByVal value As String)
                _id_moneda = value
            End Set
        End Property

        Private _des_mon As String
        Public Property des_mon() As String
            Get
                Return _des_mon
            End Get
            Set(ByVal value As String)
                _des_mon = value
            End Set
        End Property

        Private _abr_mon As String
        Public Property abr_mon() As String
            Get
                Return _abr_mon
            End Get
            Set(ByVal value As String)
                _abr_mon = value
            End Set
        End Property

    End Class
End Namespace

