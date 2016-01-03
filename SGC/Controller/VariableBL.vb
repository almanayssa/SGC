Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarVariables() As List(Of VariableBE)
            Try
                Dim iVariable As IVariable
                Dim oListadoVariables As List(Of VariableBE) = Nothing

                iVariable = New VariableDL
                oListadoVariables = iVariable.ListarVariables()

                Return oListadoVariables

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

