Namespace SGC.Model.Entidades
    Public Class SocioBE

        Private _id_socio As String
        Public Property id_socio As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Private _id_persona As String
        Public Property id_persona As String
            Get
                Return _id_persona
            End Get
            Set(ByVal value As String)
                _id_persona = value
            End Set
        End Property

        Private _id_tipo As String
        Public Property id_tipo As String
            Get
                Return _id_tipo
            End Get
            Set(ByVal value As String)
                _id_tipo = value
            End Set
        End Property

        Private _id_condicion As String
        Public Property id_condicion As String
            Get
                Return _id_condicion
            End Get
            Set(ByVal value As String)
                _id_condicion = value
            End Set
        End Property

        Private _id_estado As String
        Public Property id_estado As String
            Get
                Return _id_estado
            End Get
            Set(ByVal value As String)
                _id_estado = value
            End Set
        End Property

        Private _fec_reg As DateTime
        Public Property fec_reg As DateTime
            Get
                Return _fec_reg
            End Get
            Set(ByVal value As DateTime)
                _fec_reg = value
            End Set
        End Property

        Private _id_subestado As String
        Public Property id_subestado As String
            Get
                Return _id_subestado
            End Get
            Set(ByVal value As String)
                _id_subestado = value
            End Set
        End Property

        Private _id_accion As String
        Public Property id_accion As String
            Get
                Return _id_accion
            End Get
            Set(ByVal value As String)
                _id_accion = value
            End Set
        End Property

        Private _flg_carnet As Boolean
        Public Property flg_carnet As Boolean
            Get
                Return _flg_carnet
            End Get
            Set(ByVal value As Boolean)
                _flg_carnet = value
            End Set
        End Property

        Private _cant_inv_lib As Integer
        Public Property cant_inv_lib As Integer
            Get
                Return _cant_inv_lib
            End Get
            Set(ByVal value As Integer)
                _cant_inv_lib = value
            End Set
        End Property

        Private _contrasena As String
        Public Property contrasena As String
            Get
                Return _contrasena
            End Get
            Set(ByVal value As String)
                _contrasena = value
            End Set
        End Property

        Private _id_carnet As String
        Public Property id_carnet As String
            Get
                Return _id_carnet
            End Get
            Set(ByVal value As String)
                _id_carnet = value
            End Set
        End Property

        Public Property nombre_completo As String
        Public Property nombre As String
        Public Property apePat As String
        Public Property apeMat As String
        Public Property condicion As String
        Public Property tipo As String
        Public Property estado As String
        Public Property idParentesco As String
        Public Property parentesco As String

    End Class

End Namespace

