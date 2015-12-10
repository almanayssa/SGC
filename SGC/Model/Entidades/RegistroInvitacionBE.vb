Namespace SGC.Model.Entidades
    Public Class RegistroInvitacionBE

        Private _id_registro_invitacion As Integer
        Public Property id_registro_invitacion() As Integer
            Get
                Return _id_registro_invitacion
            End Get
            Set(ByVal value As Integer)
                _id_registro_invitacion = value
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

        Private _id_persona As String
        Public Property id_persona() As String
            Get
                Return _id_persona
            End Get
            Set(ByVal value As String)
                _id_persona = value
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

        Private _tipo_registrante As String
        Public Property tipo_registrante() As String
            Get
                Return _tipo_registrante
            End Get
            Set(ByVal value As String)
                _tipo_registrante = value
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

        Private _cant_inv_gratis As Integer
        Public Property cant_inv_gratis() As Integer
            Get
                Return _cant_inv_gratis
            End Get
            Set(ByVal value As Integer)
                _cant_inv_gratis = value
            End Set
        End Property

        Private _cant_inv_pag As Integer
        Public Property cant_inv_pag() As Integer
            Get
                Return _cant_inv_pag
            End Get
            Set(ByVal value As Integer)
                _cant_inv_pag = value
            End Set
        End Property

        Private _monto_soles As Decimal
        Public Property monto_soles() As Decimal
            Get
                Return _monto_soles
            End Get
            Set(ByVal value As Decimal)
                _monto_soles = value
            End Set
        End Property

        Private _cant_adul_inv As Integer
        Public Property cant_adul_inv() As Integer
            Get
                Return _cant_adul_inv
            End Get
            Set(ByVal value As Integer)
                _cant_adul_inv = value
            End Set
        End Property

        Private _cant_adul_nino As Integer
        Public Property cant_adul_nino() As Integer
            Get
                Return _cant_adul_nino
            End Get
            Set(ByVal value As Integer)
                _cant_adul_nino = value
            End Set
        End Property

        Private _id_observacion As String
        Public Property id_observacion() As String
            Get
                Return _id_observacion
            End Get
            Set(ByVal value As String)
                _id_observacion = value
            End Set
        End Property

        Private _id_usuario As String
        Public Property id_usuario() As String
            Get
                Return _id_usuario
            End Get
            Set(ByVal value As String)
                _id_usuario = value
            End Set
        End Property

    End Class
End Namespace

