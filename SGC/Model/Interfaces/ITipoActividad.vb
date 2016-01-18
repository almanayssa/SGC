Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface ITipoActividad

#Region "Select"

        Function ListarTipoActividad() As List(Of TipoActividadBE)

        Function ListarTipoActividadVal(ByVal idTipo As String) As List(Of TipoActividadBE)

#End Region

    End Interface

End Namespace

