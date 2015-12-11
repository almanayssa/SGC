Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarSignos() As List(Of SignosBE)
            Try
                Dim iSigno As ISignos
                Dim oListadoSignos As List(Of SignosBE) = Nothing

                iSigno = New SignosDL
                oListadoSignos = iSigno.ListarSignos()

                Return oListadoSignos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
