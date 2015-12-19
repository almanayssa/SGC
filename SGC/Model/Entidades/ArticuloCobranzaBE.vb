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

        Private _mon_art_pro As Decimal?
        Public Property mon_art_pro() As Decimal?
            Get
                Return _mon_art_pro
            End Get
            Set(ByVal value As Decimal?)
                _mon_art_pro = value
            End Set
        End Property

        Private _mora As Decimal?
        Public Property mora() As Decimal?
            Get
                Return _mora
            End Get
            Set(ByVal value As Decimal?)
                _mora = value
            End Set
        End Property

        Private _gasto As Decimal?
        Public Property gasto() As Decimal?
            Get
                Return _gasto
            End Get
            Set(ByVal value As Decimal?)
                _gasto = value
            End Set
        End Property

        Private _igv As Decimal?
        Public Property igv() As Decimal?
            Get
                Return _igv
            End Get
            Set(ByVal value As Decimal?)
                _igv = value
            End Set
        End Property

        Private _detraccion As Decimal?
        Public Property detraccion() As Decimal?
            Get
                Return _detraccion
            End Get
            Set(ByVal value As Decimal?)
                _detraccion = value
            End Set
        End Property

        Private _utilidad As Decimal?
        Public Property utilidad() As Decimal?
            Get
                Return _utilidad
            End Get
            Set(ByVal value As Decimal?)
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

        Private _id_correlativo As String
        Public Property id_correlativo() As String
            Get
                Return _id_correlativo
            End Get
            Set(ByVal value As String)
                _id_correlativo = value
            End Set
        End Property

        Private _id_tipo_doc As String
        Public Property id_tipo_doc() As String
            Get
                Return _id_tipo_doc
            End Get
            Set(ByVal value As String)
                _id_tipo_doc = value
            End Set
        End Property

        Private _id_articulo As Integer?
        Public Property id_articulo() As Integer?
            Get
                Return _id_articulo
            End Get
            Set(ByVal value As Integer?)
                _id_articulo = value
            End Set
        End Property

        Private _id_subconcepto As Integer?
        Public Property id_subconcepto() As Integer?
            Get
                Return _id_subconcepto
            End Get
            Set(ByVal value As Integer?)
                _id_subconcepto = value
            End Set
        End Property

        Private _id_concepto As Integer?
        Public Property id_concepto() As Integer?
            Get
                Return _id_concepto
            End Get
            Set(ByVal value As Integer?)
                _id_concepto = value
            End Set
        End Property

        Private _id_moneda As String
        Public Property id_moneda() As String
            Get
                Return _id_moneda
            End Get
            Set(ByVal value As String)
                _id_moneda = value
            End Set
        End Property

        Private _precio_art_pro As Decimal?
        Public Property precio_art_pro() As Decimal?
            Get
                Return _precio_art_pro
            End Get
            Set(ByVal value As Decimal?)
                _precio_art_pro = value
            End Set
        End Property

        Private _cant_art_pro As Integer?
        Public Property cant_art_pro() As Integer?
            Get
                Return _cant_art_pro
            End Get
            Set(ByVal value As Integer?)
                _cant_art_pro = value
            End Set
        End Property

        Private _obs_art_pro As String
        Public Property obs_art_pro() As String
            Get
                Return _obs_art_pro
            End Get
            Set(ByVal value As String)
                _obs_art_pro = value
            End Set
        End Property

        Private _id_provision As String
        Public Property id_provision() As String
            Get
                Return _id_provision
            End Get
            Set(ByVal value As String)
                _id_provision = value
            End Set
        End Property

        Private _fec_ven_pro As DateTime
        Public Property fec_ven_pro() As DateTime
            Get
                Return _fec_ven_pro
            End Get
            Set(ByVal value As DateTime)
                _fec_ven_pro = value
            End Set
        End Property

        Public Property articulo As String
        Public Property abr_mon As String
        Public Property concepto As String

    End Class
End Namespace

