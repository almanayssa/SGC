Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IIncidencia

#Region "Select"

        Function ObtenerIncidencia(ByVal id_actividad As Integer) As IncidenciaBE

#End Region

#Region "Insert"

        Function InsertarIncidencia(ByRef oIncidencia As IncidenciaBE) As Integer

#End Region

    End Interface

End Namespace

