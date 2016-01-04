Namespace SGC.Model.Entidades

    Public Class ParametroBE

        Private _id_parametro As Integer
        Public Property id_parametro() As Integer
            Get
                Return _id_parametro
            End Get
            Set(ByVal value As Integer)
                _id_parametro = value
            End Set
        End Property

        Private _nombre As String
        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Private _valor As Integer
        Public Property valor() As Integer
            Get
                Return _valor
            End Get
            Set(ByVal value As Integer)
                _valor = value
            End Set
        End Property

    End Class

End Namespace

