Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface ICatTipoActividad

#Region "Select"

        Function ListarCatTipoActividad(ByVal id_tipo_act As String) As List(Of CatTipoActividadBE)

#End Region

    End Interface

End Namespace

