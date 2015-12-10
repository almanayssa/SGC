Namespace SGC.Model.Entidades
    Public Class CatTipoActividadBE

        Private _id_cattipo_act As Integer
        Public Property id_cattipo_act() As Integer
            Get
                Return _id_cattipo_act
            End Get
            Set(ByVal value As Integer)
                _id_cattipo_act = value
            End Set
        End Property

        Private _descripcion As String
        Public Property descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property

        Private _id_tipo_cat As String
        Public Property id_tipo_cat() As String
            Get
                Return _id_tipo_cat
            End Get
            Set(ByVal value As String)
                _id_tipo_cat = value
            End Set
        End Property

    End Class

End Namespace
