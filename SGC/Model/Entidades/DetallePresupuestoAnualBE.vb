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

        Private _id_articulo As Integer
        Public Property id_articulo() As Integer
            Get
                Return _id_articulo
            End Get
            Set(ByVal value As Integer)
                _id_articulo = value
            End Set
        End Property

        Private _id_subconcepto As Integer
        Public Property id_subconcepto() As Integer
            Get
                Return _id_subconcepto
            End Get
            Set(ByVal value As Integer)
                _id_subconcepto = value
            End Set
        End Property

        Private _id_concepto As Integer
        Public Property id_concepto() As Integer
            Get
                Return _id_concepto
            End Get
            Set(ByVal value As Integer)
                _id_concepto = value
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

