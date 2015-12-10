Namespace SGC.Model.Entidades
    Public Class TipoPagoBE

        Private _id_tipo_pago As Integer
        Public Property id_tipo_pago() As Integer
            Get
                Return _id_tipo_pago
            End Get
            Set(ByVal value As Integer)
                _id_tipo_pago = value
            End Set
        End Property

        Private _des_tip As String
        Public Property des_tip() As String
            Get
                Return _des_tip
            End Get
            Set(ByVal value As String)
                _des_tip = value
            End Set
        End Property

    End Class
End Namespace

