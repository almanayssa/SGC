Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IPersona

#Region "Select"

        Function ListarPersonasFamilia(ByVal clave As String, ByVal nombre As String) As List(Of PersonaBE)
        Function ListarPersonaXActividad(ByVal id_actividad As Integer) As List(Of PersonaBE)

#End Region

    End Interface

End Namespace

