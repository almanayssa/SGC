Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarSedes() As List(Of SedeBE)
            Try
                Dim iSede As ISede
                Dim oListadoSedes As List(Of SedeBE) = Nothing

                iSede = New SedeDL
                oListadoSedes = iSede.ListarSedes()

                Return oListadoSedes

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
