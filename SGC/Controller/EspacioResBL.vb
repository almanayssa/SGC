Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarCronogramaEspacios(ByVal id_espacio As Integer, ByVal fecha As DateTime) As List(Of EspacioResBE)
            Try
                Dim iEspacioRes As IEspacioRes
                Dim oListadoEspacioRes As List(Of EspacioResBE) = Nothing

                iEspacioRes = New EspacioResDL
                oListadoEspacioRes = iEspacioRes.ListarCronogramaEspacios(id_espacio, fecha)

                Return oListadoEspacioRes

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

