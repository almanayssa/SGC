Namespace SGC.Model.Entidades
    Public Class TipoTransaccionBE

        Private _id_tipo_trans As Integer
        Public Property id_tipo_trans() As Integer
            Get
                Return _id_tipo_trans
            End Get
            Set(ByVal value As Integer)
                _id_tipo_trans = value
            End Set
        End Property

        Private _des_tip_trans As String
        Public Property des_tip_trans() As String
            Get
                Return _des_tip_trans
            End Get
            Set(ByVal value As String)
                _des_tip_trans = value
            End Set
        End Property

    End Class
End Namespace

