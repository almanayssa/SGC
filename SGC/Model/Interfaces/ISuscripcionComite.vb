Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface ISuscripcionComite

#Region "Select"

        Function ListarSuscripcionComites(ByVal id_socio As String) As List(Of SuscripcionComiteBE)

#End Region

#Region "Insert"

        Function InsertarSuscripcionComite(ByRef oSusComite As SuscripcionComiteBE) As Integer

#End Region

#Region "Delete"

        Function BorrarSuscripcionComite(ByVal id_socio As String) As Integer

#End Region

    End Interface

End Namespace

