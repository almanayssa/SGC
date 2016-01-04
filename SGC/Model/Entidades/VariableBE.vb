Namespace SGC.Model.Entidades

    Public Class VariableBE

        Private _id_variable As Integer
        Public Property id_variable() As Integer
            Get
                Return _id_variable
            End Get
            Set(ByVal value As Integer)
                _id_variable = value
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

    End Class

End Namespace

