Namespace SGC.Model.Entidades
    Public Class EstadoInvitadoBE

        Private _id_estado_invitado As String
        Public Property id_estado_invitado() As String
            Get
                Return _id_estado_invitado
            End Get
            Set(ByVal value As String)
                _id_estado_invitado = value
            End Set
        End Property

        Private _des_est_inv As String
        Public Property des_est_inv() As String
            Get
                Return _des_est_inv
            End Get
            Set(ByVal value As String)
                _des_est_inv = value
            End Set
        End Property

    End Class
End Namespace

