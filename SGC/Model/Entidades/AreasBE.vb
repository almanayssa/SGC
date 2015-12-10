Namespace SGC.Model.Entidades
    Public Class AreasBE

        Private _id_area As Integer
        Public Property id_area() As Integer
            Get
                Return _id_area
            End Get
            Set(ByVal value As Integer)
                _id_area = value
            End Set
        End Property

        Private _nombre_area As String
        Public Property nombre_area() As String
            Get
                Return _nombre_area
            End Get
            Set(ByVal value As String)
                _nombre_area = value
            End Set
        End Property

    End Class

End Namespace

