Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarPersonasMasParticipativas() As List(Of FactParticipanteBE)
            Try
                Dim iFact As IFactParticipante
                Dim oListadoFact As List(Of FactParticipanteBE) = Nothing

                iFact = New FactParticipanteDL
                oListadoFact = iFact.ListarPersonasMasParticipativas()

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

