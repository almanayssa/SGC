Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IPersonal

#Region "Select"

        Function ListarPersonal(ByVal id_tipo As Integer, ByVal nombre As String) As List(Of PersonalBE)
        Function ListarPersonalXActividad(ByVal id_actividad As Integer) As List(Of PersonalBE)

#End Region

    End Interface

End Namespace

