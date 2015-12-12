Namespace SGC.Model.Entidades
    Public Class DetallePresupuestoAnualBE

        Private _id_detalle As Integer
        Public Property id_detalle() As Integer
            Get
                Return _id_detalle
            End Get
            Set(ByVal value As Integer)
                _id_detalle = value
            End Set
        End Property

        Private _id_presupuesto_anual As Integer
        Public Property id_presupuesto_anual() As Integer
            Get
                Return _id_presupuesto_anual
            End Get
            Set(ByVal value As Integer)
                _id_presupuesto_anual = value
            End Set
        End Property



        Private _idItem As Integer
        Public Property idItem() As Integer
            Get
                Return _idItem
            End Get
            Set(value As Integer)
                _idItem = value
            End Set
        End Property

        Private _tipo_item As String
        Public Property tipo_item As String
            Get
                Return _tipo_item
            End Get
            Set(value As String)
                _tipo_item = value
            End Set
        End Property


        Private _cantidad As Integer
        Public Property cantidad() As Integer
            Get
                Return _cantidad
            End Get
            Set(ByVal value As Integer)
                _cantidad = value
            End Set
        End Property

        Private _monto As Decimal
        Public Property monto() As Decimal
            Get
                Return _monto
            End Get
            Set(ByVal value As Decimal)
                _monto = value
            End Set
        End Property

    End Class
End Namespace

