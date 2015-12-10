Namespace SGC.Model.Entidades
    Public Class PersonaBE

        Private _id_persona As String
        Public Property id_persona() As String
            Get
                Return _id_persona
            End Get
            Set(ByVal value As String)
                _id_persona = value
            End Set
        End Property

        Private _ape_pat As String
        Public Property ape_pat() As String
            Get
                Return _ape_pat
            End Get
            Set(ByVal value As String)
                _ape_pat = value
            End Set
        End Property

        Private _ape_mat As String
        Public Property ape_mat() As String
            Get
                Return _ape_mat
            End Get
            Set(ByVal value As String)
                _ape_mat = value
            End Set
        End Property

        Private _nom_per As String
        Public Property nom_per() As String
            Get
                Return _nom_per
            End Get
            Set(ByVal value As String)
                _nom_per = value
            End Set
        End Property

        Private _sexo As String
        Public Property sexo As String
            Get
                Return _sexo
            End Get
            Set(ByVal value As String)
                _sexo = value
            End Set
        End Property

        Private _dni_per As String
        Public Property dni_per As String
            Get
                Return _dni_per
            End Get
            Set(ByVal value As String)
                _dni_per = value
            End Set
        End Property

        Private _pas_per As String
        Public Property pas_per As String
            Get
                Return _pas_per
            End Get
            Set(ByVal value As String)
                _pas_per = value
            End Set
        End Property

        Private _car_ext_per As String
        Public Property car_ext_per As String
            Get
                Return _car_ext_per
            End Get
            Set(ByVal value As String)
                _car_ext_per = value
            End Set
        End Property

        Private _bre_per As String
        Public Property bre_per As String
            Get
                Return _bre_per
            End Get
            Set(ByVal value As String)
                _bre_per = value
            End Set
        End Property

        Private _mil_per As String
        Public Property mil_per As String
            Get
                Return _mil_per
            End Get
            Set(ByVal value As String)
                _mil_per = value
            End Set
        End Property

        Private _fec_nac_per As DateTime
        Public Property fec_nac_per() As DateTime
            Get
                Return _fec_nac_per
            End Get
            Set(ByVal value As DateTime)
                _fec_nac_per = value
            End Set
        End Property

        Private _id_pais As String
        Public Property id_pais As String
            Get
                Return _id_pais
            End Get
            Set(ByVal value As String)
                _id_pais = value
            End Set
        End Property

        Private _id_region As String
        Public Property id_region As String
            Get
                Return _id_region
            End Get
            Set(ByVal value As String)
                _id_region = value
            End Set
        End Property

        Private _id_estadoCivil As String
        Public Property id_estadoCivil As String
            Get
                Return _id_estadoCivil
            End Get
            Set(ByVal value As String)
                _id_estadoCivil = value
            End Set
        End Property

        Private _ruc_per As String
        Public Property ruc_per As String
            Get
                Return _ruc_per
            End Get
            Set(ByVal value As String)
                _ruc_per = value
            End Set
        End Property

        Private _id_profesion As Integer
        Public Property id_profesion As Integer
            Get
                Return _id_profesion
            End Get
            Set(ByVal value As Integer)
                _id_profesion = value
            End Set
        End Property

        Private _vive_per As Boolean
        Public Property vive_per As Boolean
            Get
                Return _vive_per
            End Get
            Set(ByVal value As Boolean)
                _vive_per = value
            End Set
        End Property

        Private _flg_eliminado As Boolean
        Public Property flg_eliminado As Boolean
            Get
                Return _flg_eliminado
            End Get
            Set(ByVal value As Boolean)
                _flg_eliminado = value
            End Set
        End Property

        Private _sugerencia As String
        Public Property sugerencia As String
            Get
                Return _sugerencia
            End Get
            Set(ByVal value As String)
                _sugerencia = value
            End Set
        End Property

        Private _foto As String
        Public Property foto As String
            Get
                Return _foto
            End Get
            Set(ByVal value As String)
                _foto = value
            End Set
        End Property

        'Private _cantHijosRef As Integer?
        'Public Property cantHijosRef As Integer?
        '    Get
        '        Return _cantHijosRef
        '    End Get
        '    Set(ByVal value As Integer?)
        '        _cantHijosRef = value
        '    End Set
        'End Property

        Public Property nombre_completo As String
        Public Property telefonoPrincipal As String
        Public Property correoPrincipal As String
        Public Property celularPrincipal As String
        Public Property direccionPrincipal As String
        Public Property id_cliente As String
        Public Property id_accion As String

    End Class

End Namespace