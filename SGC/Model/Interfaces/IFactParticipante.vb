Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IFactParticipante

#Region "Select"

        Function ListarPersonasMasParticipativas() As List(Of FactParticipanteBE)
        Function ListarParticipantesPorMes() As List(Of FactParticipanteBE)

#End Region

    End Interface

End Namespace

