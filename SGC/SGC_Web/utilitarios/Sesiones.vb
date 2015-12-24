Imports SGC.Model.Entidades

Public Class Sesiones

    Private Const sActividadSeleccionada As String = "sActividadSeleccionada"

    Public Shared Property ActividadSeleccionada() As ActividadBE
        Get
            Return HttpContext.Current.Session(sActividadSeleccionada)
        End Get
        Set(ByVal value As ActividadBE)
            HttpContext.Current.Session(sActividadSeleccionada) = value
        End Set
    End Property

    Public Shared Function ActividadSeleccionadaEsNulo() As Boolean
        Return HttpContext.Current.Session(sActividadSeleccionada) Is Nothing
    End Function

    Public Shared Sub ActividadSeleccionadaRemover()
        HttpContext.Current.Session.Remove(sActividadSeleccionada)
    End Sub

    Private Const sListadoActividades As String = "sListadoActividades"

    Public Shared Property ListadoActividades() As List(Of ActividadBE)
        Get
            Return HttpContext.Current.Session(sListadoActividades)
        End Get
        Set(ByVal value As List(Of ActividadBE))
            HttpContext.Current.Session(sListadoActividades) = value
        End Set
    End Property

    Public Shared Function ListadoActividadesEsNulo() As Boolean
        Return HttpContext.Current.Session(sListadoActividades) Is Nothing
    End Function

    Public Shared Sub ListadoActividadesRemover()
        HttpContext.Current.Session.Remove(sListadoActividades)
    End Sub

    Private Const sListadoFamiliares As String = "sTempListadoActividades"

    Public Shared Property ListadoFamiliares() As List(Of PersonaBE)
        Get
            Return HttpContext.Current.Session(sListadoFamiliares)
        End Get
        Set(ByVal value As List(Of PersonaBE))
            HttpContext.Current.Session(sListadoFamiliares) = value
        End Set
    End Property

    Public Shared Function ListadoFamiliaresEsNulo() As Boolean
        Return HttpContext.Current.Session(sListadoFamiliares) Is Nothing
    End Function

    Public Shared Sub ListadoFamiliaresRemover()
        HttpContext.Current.Session.Remove(sListadoFamiliares)
    End Sub

    Private Const sUsuarioLogueado As String = "sUsuarioLogueado"

    Public Shared Property UsuarioLogueado() As UsuarioBE
        Get
            Return HttpContext.Current.Session(sUsuarioLogueado)
        End Get
        Set(ByVal value As UsuarioBE)
            HttpContext.Current.Session(sUsuarioLogueado) = value
        End Set
    End Property

    Public Shared Function UsuarioLogueadoEsNulo() As Boolean
        Return HttpContext.Current.Session(sUsuarioLogueado) Is Nothing
    End Function

    Public Shared Sub UsuarioLogueadoRemover()
        HttpContext.Current.Session.Remove(sUsuarioLogueado)
    End Sub

#Region "Msg Descripcion"

    Public Shared Property MsgDescripcion() As String
        Get
            Return HttpContext.Current.Session(sMsgDescripcion)
        End Get
        Set(ByVal value As String)
            HttpContext.Current.Session(sMsgDescripcion) = value
        End Set
    End Property

    Public Shared Function MsgDescripcionEsNulo() As Boolean
        Return HttpContext.Current.Session(sMsgDescripcion) Is Nothing
    End Function

    Public Shared Sub MsgDescripcionRemover()
        HttpContext.Current.Session.Remove(sMsgDescripcion)
    End Sub

#End Region

#Region "Msg Titulo"

    Public Shared Property MsgTitulo() As String
        Get
            Return HttpContext.Current.Session(sMsgTitulo)
        End Get
        Set(ByVal value As String)
            HttpContext.Current.Session(sMsgTitulo) = value
        End Set
    End Property

    Public Shared Function MsgTituloEsNulo() As Boolean
        Return HttpContext.Current.Session(sMsgTitulo) Is Nothing
    End Function

    Public Shared Sub MsgTituloRemover()
        HttpContext.Current.Session.Remove(sMsgTitulo)
    End Sub

#End Region

#Region "Msg Continuar"

    ' This session indicate the Message page
    Private Const sMsgDescripcion As String = "sMsgDescripcion"
    Private Const sMsgTitulo As String = "sMsgTitulo"
    Private Const sMsgContinuar As String = "sMsgContinuar"

    Public Shared Property MsgContinuar() As String
        Get
            Return HttpContext.Current.Session(sMsgContinuar)
        End Get
        Set(ByVal value As String)
            HttpContext.Current.Session(sMsgContinuar) = value
        End Set
    End Property

    Public Shared Function MsgContinuarEsNulo() As Boolean
        Return HttpContext.Current.Session(sMsgContinuar) Is Nothing
    End Function

    Public Shared Sub MsgContinuarRemover()
        HttpContext.Current.Session.Remove(sMsgContinuar)
    End Sub

#End Region

End Class
