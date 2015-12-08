Namespace SGS.Model.Entidades
    Public Class MaestroCargoComiteBE

        Private _id_cargo As Integer
        Public Property id_cargo() As Integer
            Get
                Return _id_cargo
            End Get
            Set(ByVal value As Integer)
                _id_cargo = value
            End Set
        End Property

        Private _descripcion_cargo As String
        Public Property descripcion_cargo() As String
            Get
                Return _descripcion_cargo
            End Get
            Set(ByVal value As String)
                _descripcion_cargo = value
            End Set
        End Property

    End Class
End Namespace

