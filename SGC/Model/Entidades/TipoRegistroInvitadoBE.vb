Namespace SGC.Model.Entidades
    Public Class TipoRegistroInvitadoBE

        Private _id_tipo_reg_inv As String
        Public Property id_tipo_reg_inv() As String
            Get
                Return _id_tipo_reg_inv
            End Get
            Set(ByVal value As String)
                _id_tipo_reg_inv = value
            End Set
        End Property

        Private _des_tipo_reg_inv As String
        Public Property des_tipo_reg_inv() As String
            Get
                Return _des_tipo_reg_inv
            End Get
            Set(ByVal value As String)
                _des_tipo_reg_inv = value
            End Set
        End Property

    End Class
End Namespace

