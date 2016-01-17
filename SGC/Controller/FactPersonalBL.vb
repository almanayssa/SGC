Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarPersonalMasSolicitado() As List(Of FactPersonalBE)
            Try
                Dim iFact As IFactPersonal
                Dim oListadoFact As List(Of FactPersonalBE) = Nothing

                iFact = New FactPersonalDL
                oListadoFact = iFact.ListarPersonalMasSolicitado()

                Return oListadoFact

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

