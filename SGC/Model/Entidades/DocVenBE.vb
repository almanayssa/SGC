Namespace SGC.Model.Entidades
    Public Class DocVenBE

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

        Private _id_entidad As String
        Public Property id_entidad() As String
            Get
                Return _id_entidad
            End Get
            Set(ByVal value As String)
                _id_entidad = value
            End Set
        End Property

        Private _id_est_doc As String
        Public Property id_est_doc() As String
            Get
                Return _id_est_doc
            End Get
            Set(ByVal value As String)
                _id_est_doc = value
            End Set
        End Property

        Private _fec_reg As DateTime
        Public Property fec_reg() As DateTime
            Get
                Return _fec_reg
            End Get
            Set(ByVal value As DateTime)
                _fec_reg = value
            End Set
        End Property

        Private _fec_ven As DateTime?
        Public Property fec_ven() As DateTime?
            Get
                Return _fec_ven
            End Get
            Set(ByVal value As DateTime?)
                _fec_ven = value
            End Set
        End Property

        Private _mon_bru As Decimal?
        Public Property mon_bru() As Decimal?
            Get
                Return _mon_bru
            End Get
            Set(ByVal value As Decimal?)
                _mon_bru = value
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

        Private _tot_mon As Decimal?
        Public Property tot_mon() As Decimal?
            Get
                Return _tot_mon
            End Get
            Set(ByVal value As Decimal?)
                _tot_mon = value
            End Set
        End Property

        Private _flg_prv As Boolean?
        Public Property flg_prv() As Boolean?
            Get
                Return _flg_prv
            End Get
            Set(ByVal value As Boolean?)
                _flg_prv = value
            End Set
        End Property

        Private _flg_art As Boolean?
        Public Property flg_art() As Boolean?
            Get
                Return _flg_art
            End Get
            Set(ByVal value As Boolean?)
                _flg_art = value
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

        Private _sal_doc As Decimal?
        Public Property sal_doc() As Decimal?
            Get
                Return _sal_doc
            End Get
            Set(ByVal value As Decimal?)
                _sal_doc = value
            End Set
        End Property

        Private _obs_doc As String
        Public Property obs_doc() As String
            Get
                Return _obs_doc
            End Get
            Set(ByVal value As String)
                _obs_doc = value
            End Set
        End Property

        Private _mon_det As Decimal
        Public Property mon_det() As Decimal
            Get
                Return _mon_det
            End Get
            Set(ByVal value As Decimal)
                _mon_det = value
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

        Private _mon_uti As Decimal
        Public Property mon_uti() As Decimal
            Get
                Return _mon_uti
            End Get
            Set(ByVal value As Decimal)
                _mon_uti = value
            End Set
        End Property

        Private _flg_SAP As Boolean
        Public Property flg_SAP() As Boolean
            Get
                Return _flg_SAP
            End Get
            Set(ByVal value As Boolean)
                _flg_SAP = value
            End Set
        End Property

        Private _flg_pago_SAP As Boolean
        Public Property flg_pago_SAP() As Boolean
            Get
                Return _flg_pago_SAP
            End Get
            Set(ByVal value As Boolean)
                _flg_pago_SAP = value
            End Set
        End Property

        Private _id_tipo_doc2 As String
        Public Property id_tipo_doc2() As String
            Get
                Return _id_tipo_doc2
            End Get
            Set(ByVal value As String)
                _id_tipo_doc2 = value
            End Set
        End Property

        Private _id_serie2 As String
        Public Property id_serie2() As String
            Get
                Return _id_serie2
            End Get
            Set(ByVal value As String)
                _id_serie2 = value
            End Set
        End Property

        Private _id_correlativo2 As String
        Public Property id_correlativo2() As String
            Get
                Return _id_correlativo2
            End Get
            Set(ByVal value As String)
                _id_correlativo2 = value
            End Set
        End Property

    End Class
End Namespace

