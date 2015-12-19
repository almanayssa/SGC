Namespace SGC.Model.Entidades
    Public Class CanjeAdelantosBE

        Private _id_tipo_doc1 As String
        Public Property id_tipo_doc1() As String
            Get
                Return _id_tipo_doc1
            End Get
            Set(ByVal value As String)
                _id_tipo_doc1 = value
            End Set
        End Property

        Private _id_serie1 As String
        Public Property id_serie1() As String
            Get
                Return _id_serie1
            End Get
            Set(ByVal value As String)
                _id_serie1 = value
            End Set
        End Property

        Private _id_correlativo1 As String
        Public Property id_correlativo1() As String
            Get
                Return _id_correlativo1
            End Get
            Set(ByVal value As String)
                _id_correlativo1 = value
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

        Private _id_canje_adelantos As Integer
        Public Property id_canje_adelantos() As Integer
            Get
                Return _id_canje_adelantos
            End Get
            Set(ByVal value As Integer)
                _id_canje_adelantos = value
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

        Private _pago_SAP As Boolean
        Public Property pago_SAP() As Boolean
            Get
                Return _pago_SAP
            End Get
            Set(ByVal value As Boolean)
                _pago_SAP = value
            End Set
        End Property

        Private _tot_doc As Decimal?
        Public Property tot_doc() As Decimal?
            Get
                Return _tot_doc
            End Get
            Set(ByVal value As Decimal?)
                _tot_doc = value
            End Set
        End Property

        Private _pago As Decimal?
        Public Property pago() As Decimal?
            Get
                Return _pago
            End Get
            Set(ByVal value As Decimal?)
                _pago = value
            End Set
        End Property

        Private _id_tipo_plan As Integer
        Public Property id_tipo_plan() As Integer
            Get
                Return _id_tipo_plan
            End Get
            Set(ByVal value As Integer)
                _id_tipo_plan = value
            End Set
        End Property

        Private _fec_canc As DateTime?
        Public Property fec_canc() As DateTime?
            Get
                Return _fec_canc
            End Get
            Set(ByVal value As DateTime?)
                _fec_canc = value
            End Set
        End Property

        Private _id_tipo_pago As Integer?
        Public Property id_tipo_pago() As Integer?
            Get
                Return _id_tipo_pago
            End Get
            Set(ByVal value As Integer?)
                _id_tipo_pago = value
            End Set
        End Property

        Private _id_banco As Integer
        Public Property id_banco() As Integer
            Get
                Return _id_banco
            End Get
            Set(ByVal value As Integer)
                _id_banco = value
            End Set
        End Property

        Private _id_sede As String
        Public Property id_sede() As String
            Get
                Return _id_sede
            End Get
            Set(ByVal value As String)
                _id_sede = value
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

        Private _pago_dolares As Decimal?
        Public Property pago_dolares() As Decimal?
            Get
                Return _pago_dolares
            End Get
            Set(ByVal value As Decimal?)
                _pago_dolares = value
            End Set
        End Property

        Private _nro_tarjeta As String
        Public Property nro_tarjeta() As String
            Get
                Return _nro_tarjeta
            End Get
            Set(ByVal value As String)
                _nro_tarjeta = value
            End Set
        End Property

        Private _nro_boucher As String
        Public Property nro_boucher() As String
            Get
                Return _nro_boucher
            End Get
            Set(ByVal value As String)
                _nro_boucher = value
            End Set
        End Property

        Private _id_tipo_trans As Integer
        Public Property id_tipo_trans() As Integer
            Get
                Return _id_tipo_trans
            End Get
            Set(ByVal value As Integer)
                _id_tipo_trans = value
            End Set
        End Property

        Private _nro_oper As String
        Public Property nro_oper() As String
            Get
                Return _nro_oper
            End Get
            Set(ByVal value As String)
                _nro_oper = value
            End Set
        End Property

        Private _fec_trans As DateTime
        Public Property fec_trans() As DateTime
            Get
                Return _fec_trans
            End Get
            Set(ByVal value As DateTime)
                _fec_trans = value
            End Set
        End Property

    End Class
End Namespace

