Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IAsistenciaPersonal

#Region "Select"

        Function ListarAsistenciaPersonal(ByVal id_actividad As Integer) As List(Of AsistenciaPersonalBE)

#End Region

#Region "Insert"

        Function InsertarAsistenciaPersonal(ByRef oAsistenciaPersonal As AsistenciaPersonalBE) As Integer

#End Region

    End Interface

End Namespace

