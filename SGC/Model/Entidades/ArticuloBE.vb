Namespace SGC.Model.Entidades
    Public Class ArticuloBE

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

        Private _id_moneda As String
        Public Property id_moneda() As String
            Get
                Return _id_moneda
            End Get
            Set(ByVal value As String)
                _id_moneda = value
            End Set
        End Property

        Private _des_art As String
        Public Property des_art() As String
            Get
                Return _des_art
            End Get
            Set(ByVal value As String)
                _des_art = value
            End Set
        End Property

        Private _pre_art As Decimal
        Public Property pre_art() As Decimal
            Get
                Return _pre_art
            End Get
            Set(ByVal value As Decimal)
                _pre_art = value
            End Set
        End Property

        Private _flg_igv As Boolean
        Public Property flg_igv() As Boolean
            Get
                Return _flg_igv
            End Get
            Set(ByVal value As Boolean)
                _flg_igv = value
            End Set
        End Property

        Private _por_uti As Decimal
        Public Property por_uti() As Decimal
            Get
                Return _por_uti
            End Get
            Set(ByVal value As Decimal)
                _por_uti = value
            End Set
        End Property

        Private _por_det As Decimal
        Public Property por_det() As Decimal
            Get
                Return _por_det
            End Get
            Set(ByVal value As Decimal)
                _por_det = value
            End Set
        End Property

        Private _item As Integer
        Public Property item() As Integer
            Get
                Return _item
            End Get
            Set(ByVal value As Integer)
                _item = value
            End Set
        End Property

        Private _flg_activo As Boolean
        Public Property flg_activo() As Boolean
            Get
                Return _flg_activo
            End Get
            Set(ByVal value As Boolean)
                _flg_activo = value
            End Set
        End Property

        Private _id_rubro As String
        Public Property id_rubro() As String
            Get
                Return _id_rubro
            End Get
            Set(ByVal value As String)
                _id_rubro = value
            End Set
        End Property

        Private _cta_contable As String
        Public Property cta_contable() As String
            Get
                Return _cta_contable
            End Get
            Set(ByVal value As String)
                _cta_contable = value
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

        Private _flg_g_docs As Boolean
        Public Property flg_g_docs() As Boolean
            Get
                Return _flg_g_docs
            End Get
            Set(ByVal value As Boolean)
                _flg_g_docs = value
            End Set
        End Property

    End Class
End Namespace

