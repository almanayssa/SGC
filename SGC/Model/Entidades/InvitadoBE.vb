Namespace SGC.Model.Entidades
    Public Class InvitadoBE

        Private _id_invitado As String
        Public Property id_invitado() As String
            Get
                Return _id_invitado
            End Get
            Set(ByVal value As String)
                _id_invitado = value
            End Set
        End Property

        Private _dni_inv As String
        Public Property dni_inv() As String
            Get
                Return _dni_inv
            End Get
            Set(ByVal value As String)
                _dni_inv = value
            End Set
        End Property

        Private _nom_inv As String
        Public Property nom_inv() As String
            Get
                Return _nom_inv
            End Get
            Set(ByVal value As String)
                _nom_inv = value
            End Set
        End Property

        Private _ape_pat_inv As String
        Public Property ape_pat_inv() As String
            Get
                Return _ape_pat_inv
            End Get
            Set(ByVal value As String)
                _ape_pat_inv = value
            End Set
        End Property

        Private _ape_mat_inv As String
        Public Property ape_mat_inv() As String
            Get
                Return _ape_mat_inv
            End Get
            Set(ByVal value As String)
                _ape_mat_inv = value
            End Set
        End Property

        Private _sexo_inv As String
        Public Property sexo_inv() As String
            Get
                Return _sexo_inv
            End Get
            Set(ByVal value As String)
                _sexo_inv = value
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

        Private _id_socio As String
        Public Property id_socio() As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Private _sede_reg As String
        Public Property sede_reg() As String
            Get
                Return _sede_reg
            End Get
            Set(ByVal value As String)
                _sede_reg = value
            End Set
        End Property

        Private _fec_nac As DateTime
        Public Property fec_nac() As DateTime
            Get
                Return _fec_nac
            End Get
            Set(ByVal value As DateTime)
                _fec_nac = value
            End Set
        End Property

        Private _flg_modificado As Boolean
        Public Property flg_modificado() As Boolean
            Get
                Return _flg_modificado
            End Get
            Set(ByVal value As Boolean)
                _flg_modificado = value
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

