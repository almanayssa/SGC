Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IAsistencia

#Region "Select"

        Function ListarAsistencia(ByVal id_actividad As Integer) As List(Of AsistenciaBE)

#End Region

#Region "Insert"

        Function InsertarAsistencia(ByRef oAsistencia As AsistenciaBE) As Integer

#End Region

    End Interface

End Namespace

