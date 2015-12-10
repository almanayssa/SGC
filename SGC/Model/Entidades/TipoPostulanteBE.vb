Namespace SGC.Model.Entidades
    Public Class MaestroTipoPostulanteBE

        Private _id_tipo As String
        Public Property id_tipo() As String
            Get
                Return _id_tipo
            End Get
            Set(ByVal value As String)
                _id_tipo = value
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

