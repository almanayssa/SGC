Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IEspacio

#Region "Select"

        Function ListarEspacios(ByVal id_sede As String, ByVal id_lugar As Integer) As List(Of EspacioBE)

#End Region

    End Interface

End Namespace

