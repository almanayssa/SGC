Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarParametro() As List(Of ParametroBE)
            Try
                Dim iParametro As IParametro
                Dim oListado As List(Of ParametroBE) = Nothing

                iParametro = New ParametroDL
                oListado = iParametro.ListarParametros()

                Return oListado

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Update"

        Public Function ActualizarParametros(ByRef oParametros As List(Of ParametroBE))
            Try
                Dim affectedRows As Integer

                Dim iParametro As IParametro
                iParametro = New ParametroDL

                For Each oParametro As ParametroBE In oParametros
                    affectedRows += iParametro.ActualizarParametro(oParametro)
                Next

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

