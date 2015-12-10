Namespace SGC.Model.Entidades
    Public Class FamiliaBE

        Private _id_familia As Integer
        Public Property id_familia() As Integer
            Get
                Return _id_familia
            End Get
            Set(ByVal value As Integer)
                _id_familia = value
            End Set
        End Property

        Private _id_persona As String
        Public Property id_persona() As String
            Get
                Return _id_persona
            End Get
            Set(ByVal value As String)
                _id_persona = value
            End Set
        End Property

        Private _id_parentesco As Integer
        Public Property id_parentesco() As Integer
            Get
                Return _id_parentesco
            End Get
            Set(ByVal value As Integer)
                _id_parentesco = value
            End Set
        End Property

        Private _id_socio As String
        Public Property id_socio() As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Private _fec_cad As DateTime
        Public Property fec_cad() As DateTime
            Get
                Return _fec_cad
            End Get
            Set(ByVal value As DateTime)
                _fec_cad = value
            End Set
        End Property

        Private _num_carnet As String
        Public Property num_carnet() As String
            Get
                Return _num_carnet
            End Get
            Set(ByVal value As String)
                _num_carnet = value
            End Set
        End Property

        Private _PM As Boolean
        Public Property PM() As Boolean
            Get
                Return _PM
            End Get
            Set(ByVal value As Boolean)
                _PM = value
            End Set
        End Property

        Private _DJ As Boolean
        Public Property DJ() As Boolean
            Get
                Return _DJ
            End Get
            Set(ByVal value As Boolean)
                _DJ = value
            End Set
        End Property

        Private _PN As Boolean
        Public Property PN() As Boolean
            Get
                Return _PN
            End Get
            Set(ByVal value As Boolean)
                _PN = value
            End Set
        End Property

        Private _CE As Boolean
        Public Property CE() As Boolean
            Get
                Return _CE
            End Get
            Set(ByVal value As Boolean)
                _CE = value
            End Set
        End Property

        Private _LE As Boolean
        Public Property LE() As Boolean
            Get
                Return _LE
            End Get
            Set(ByVal value As Boolean)
                _LE = value
            End Set
        End Property

        Private _flg_carnet As Boolean
        Public Property flg_carnet() As Boolean
            Get
                Return _flg_carnet
            End Get
            Set(ByVal value As Boolean)
                _flg_carnet = value
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

    End Class
End Namespace

