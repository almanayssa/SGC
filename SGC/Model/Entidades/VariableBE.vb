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

        Private _nom_sp As String
        Public Property nom_sp() As String
            Get
                Return _nom_sp
            End Get
            Set(ByVal value As String)
                _nom_sp = value
            End Set
        End Property

        Private _flg_anulado As Boolean
        Public Property flg_anulado() As Boolean
            Get
                Return _flg_anulado
            End Get
            Set(ByVal value As Boolean)
                _flg_anulado = value
            End Set
        End Property

    End Class

End Namespace

