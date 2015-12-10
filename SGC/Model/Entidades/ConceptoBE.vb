Namespace SGC.Model.Entidades
    Public Class ConceptoBE

        Private _id_concepto As Integer
        Public Property id_concepto() As Integer
            Get
                Return _id_concepto
            End Get
            Set(ByVal value As Integer)
                _id_concepto = value
            End Set
        End Property

        Private _des_con As String
        Public Property des_con() As String
            Get
                Return _des_con
            End Get
            Set(ByVal value As String)
                _des_con = value
            End Set
        End Property

        Private _flg_ventas As Boolean
        Public Property flg_ventas() As Boolean
            Get
                Return _flg_ventas
            End Get
            Set(ByVal value As Boolean)
                _flg_ventas = value
            End Set
        End Property

    End Class
End Namespace

