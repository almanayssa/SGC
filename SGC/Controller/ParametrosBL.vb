Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarParametros() As List(Of ParametrosBE)
            Try
                Dim iParametro As IParametros
                Dim oListado As List(Of ParametrosBE) = Nothing

                iParametro = New ParametrosDL
                oListado = iParametro.ListarParametros()

                Return oListado

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerParametro(ByVal id As String) As ParametrosBE
            Try
                Dim iParametro As IParametros
                Dim oParametro As ParametrosBE = Nothing

                iParametro = New ParametrosDL
                oParametro = iParametro.ObtenerParametro(id)

                Return oParametro

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Update"

        Public Function ActualizarParametros(ByRef oParametros As List(Of ParametrosBE))
            Try
                Dim affectedRows As Integer

                Dim iParametro As IParametros
                iParametro = New ParametrosDL

                For Each oParametro As ParametrosBE In oParametros

                    affectedRows += iParametro.ActualizarParametro(oParametro)

                Next

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ActualizarParametro(ByRef oParametro As ParametrosBE)
            Try
                Dim affectedRows As Integer

                Dim iParametro As IParametros
                iParametro = New ParametrosDL

                affectedRows += iParametro.ActualizarParametro(oParametro)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

