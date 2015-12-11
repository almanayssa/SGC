Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarEspacios(ByVal id_sede As String, ByVal id_lugar As Integer) As List(Of EspacioBE)
            Try
                Dim iEspacio As IEspacio
                Dim oListadoEspacios As List(Of EspacioBE) = Nothing

                iEspacio = New EspacioDL
                oListadoEspacios = iEspacio.ListarEspacios(id_sede, id_lugar)

                Return oListadoEspacios

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
