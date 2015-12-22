Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IEspacioRes

#Region "Select"

        Function ListarCronogramaEspacios(ByVal id_espacio As Integer, ByVal fecha As DateTime) As List(Of EspacioResBE)

#End Region

    End Interface

End Namespace

