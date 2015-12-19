Namespace SGC.Model.Entidades
    Public Class SuscripcionComiteBE

        Private _id_comite As String
        Public Property id_comite() As String
            Get
                Return _id_comite
            End Get
            Set(ByVal value As String)
                _id_comite = value
            End Set
        End Property

        Private _id_socio As String
        Public Property id_socio() As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Public Property comite As String
        Public Property flg As Boolean
    End Class

End Namespace

