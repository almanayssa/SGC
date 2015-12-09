Namespace SGC.Model.Entidades
    Public Class ArticuloCobranzaBE

        Private _id_articulo_cobranza As Integer
        Public Property id_articulo_cobranza() As Integer
            Get
                Return _id_articulo_cobranza
            End Get
            Set(ByVal value As Integer)
                _id_articulo_cobranza = value
            End Set
        End Property

        Private _mon_art_pro As Decimal
        Public Property mon_art_pro() As Decimal
            Get
                Return _mon_art_pro
            End Get
            Set(ByVal value As Decimal)
                _mon_art_pro = value
            End Set
        End Property

        Private _mora As Decimal
        Public Property mora() As Decimal
            Get
                Return _mora
            End Get
            Set(ByVal value As Decimal)
                _mora = value
            End Set
        End Property

        Private _gasto As Decimal
        Public Property gasto() As Decimal
            Get
                Return _gasto
            End Get
            Set(ByVal value As Decimal)
                _gasto = value
            End Set
        End Property

        Private _igv As Decimal
        Public Property igv() As Decimal
            Get
                Return _igv
            End Get
            Set(ByVal value As Decimal)
                _igv = value
            End Set
        End Property

        Private _detraccion As Decimal
        Public Property detraccion() As Decimal
            Get
                Return _detraccion
            End Get
            Set(ByVal value As Decimal)
                _detraccion = value
            End Set
        End Property

        Private _utilidad As Decimal
        Public Property utilidad() As Decimal
            Get
                Return _utilidad
            End Get
            Set(ByVal value As Decimal)
                _utilidad = value
            End Set
        End Property

        Private _id_serie As String
        Public Property id_serie() As String
            Get
                Return _id_serie
            End Get
            Set(ByVal value As String)
                _id_serie = value
            End Set
        End Property

        Private newPropertyValue As String
        Public Property NewProperty() As String
            Get
                Return newPropertyValue
            End Get
            Set(ByVal value As String)
                newPropertyValue = value
            End Set
        End Property

    End Class
End Namespace

