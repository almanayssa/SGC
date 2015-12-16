Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IEncuestaActividad

#Region "Select"

        Function ObtenerEncuesta(ByVal id_actividad As Integer) As EncuestaActividadBE

#End Region

#Region "Insert"

        Function InsertarEncuesta(ByRef oEncuestaActividad As EncuestaActividadBE) As Integer

#End Region

    End Interface

End Namespace

