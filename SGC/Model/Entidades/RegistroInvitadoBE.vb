Namespace SGC.Model.Entidades
    Public Class RegistroInvitadoBE

        Private _id_reg_inv As Integer
        Public Property id_reg_inv() As Integer
            Get
                Return _id_reg_inv
            End Get
            Set(ByVal value As Integer)
                _id_reg_inv = value
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

        Private _fec_inv As DateTime
        Public Property fec_inv() As DateTime
            Get
                Return _fec_inv
            End Get
            Set(ByVal value As DateTime)
                _fec_inv = value
            End Set
        End Property

        Private _flg_inv As Boolean
        Public Property flg_inv() As Boolean
            Get
                Return _flg_inv
            End Get
            Set(ByVal value As Boolean)
                _flg_inv = value
            End Set
        End Property

        Private _flg_ing As Boolean
        Public Property flg_ing() As Boolean
            Get
                Return _flg_ing
            End Get
            Set(ByVal value As Boolean)
                _flg_ing = value
            End Set
        End Property

        Private _id_tipo_reg_inv As String
        Public Property id_tipo_reg_inv() As String
            Get
                Return _id_tipo_reg_inv
            End Get
            Set(ByVal value As String)
                _id_tipo_reg_inv = value
            End Set
        End Property

        Private _id_lugar_reg As String
        Public Property id_lugar_reg() As String
            Get
                Return _id_lugar_reg
            End Get
            Set(ByVal value As String)
                _id_lugar_reg = value
            End Set
        End Property

        Private _id_estado_invitado As String
        Public Property id_estado_invitado() As String
            Get
                Return _id_estado_invitado
            End Get
            Set(ByVal value As String)
                _id_estado_invitado = value
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

        Private _id_socio As String
        Public Property id_socio() As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Private _id_accion As String
        Public Property id_accion() As String
            Get
                Return _id_accion
            End Get
            Set(ByVal value As String)
                _id_accion = value
            End Set
        End Property

        Private _adulto As Boolean
        Public Property adulto() As Boolean
            Get
                Return _adulto
            End Get
            Set(ByVal value As Boolean)
                _adulto = value
            End Set
        End Property

        Private _id_tipo_ingreso_club As String
        Public Property id_tipo_ingreso_club() As String
            Get
                Return _id_tipo_ingreso_club
            End Get
            Set(ByVal value As String)
                _id_tipo_ingreso_club = value
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

        Private _id_registro_invitacion As Integer
        Public Property id_registro_invitacion() As Integer
            Get
                Return _id_registro_invitacion
            End Get
            Set(ByVal value As Integer)
                _id_registro_invitacion = value
            End Set
        End Property

        Private _id_servicio As Integer
        Public Property id_servicio() As Integer
            Get
                Return _id_servicio
            End Get
            Set(ByVal value As Integer)
                _id_servicio = value
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

        Private _fec_hora_ing As DateTime
        Public Property fec_hora_ing() As DateTime
            Get
                Return _fec_hora_ing
            End Get
            Set(ByVal value As DateTime)
                _fec_hora_ing = value
            End Set
        End Property

        Private _flg_alojamiento As Boolean
        Public Property flg_alojamiento() As Boolean
            Get
                Return _flg_alojamiento
            End Get
            Set(ByVal value As Boolean)
                _flg_alojamiento = value
            End Set
        End Property

        Private _id_invitado As String
        Public Property id_invitado() As String
            Get
                Return _id_invitado
            End Get
            Set(ByVal value As String)
                _id_invitado = value
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

        Private _id_reserva As Integer
        Public Property id_reserva() As Integer
            Get
                Return _id_reserva
            End Get
            Set(ByVal value As Integer)
                _id_reserva = value
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

        Private _precio As Decimal
        Public Property precio() As Decimal
            Get
                Return _precio
            End Get
            Set(ByVal value As Decimal)
                _precio = value
            End Set
        End Property

    End Class
End Namespace

