Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface ITipoPersonal

#Region "Select"

        Function ListarTipoPersonal(ByVal descripcion As String) As List(Of TipoPersonalBE)
        Function ListarTipoPersonalXActividad(ByVal id_actividad As Integer) As List(Of TipoPersonalBE)

#End Region

    End Interface

End Namespace

