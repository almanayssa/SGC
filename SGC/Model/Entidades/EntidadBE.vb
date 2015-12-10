Namespace SGC.Model.Entidades
    Public Class EntidadBE

        Private _id_entidad As String
        Public Property id_entidad() As String
            Get
                Return _id_entidad
            End Get
            Set(ByVal value As String)
                _id_entidad = value
            End Set
        End Property

        Private _tipo_ent As String
        Public Property tipo_ent() As String
            Get
                Return _tipo_ent
            End Get
            Set(ByVal value As String)
                _tipo_ent = value
            End Set
        End Property

        Private _flg_cau As Boolean
        Public Property flg_cau() As Boolean
            Get
                Return _flg_cau
            End Get
            Set(ByVal value As Boolean)
                _flg_cau = value
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

    End Class
End Namespace

