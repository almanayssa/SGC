Namespace SGC.Model.Entidades
    Public Class EstadoSocioBE

        Private _id_estado As String
        Public Property id_estado() As String
            Get
                Return _id_estado
            End Get
            Set(ByVal value As String)
                _id_estado = value
            End Set
        End Property

        Private _abr_est As String
        Public Property abr_est() As String
            Get
                Return _abr_est
            End Get
            Set(ByVal value As String)
                _abr_est = value
            End Set
        End Property

        Private _des_est As String
        Public Property des_est() As String
            Get
                Return _des_est
            End Get
            Set(ByVal value As String)
                _des_est = value
            End Set
        End Property

    End Class
End Namespace

