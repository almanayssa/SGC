Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarTiposPago() As List(Of TipoPagoBE)
            Try
                Dim iTipo As ITipoPago
                Dim oListadoTipos As List(Of TipoPagoBE) = Nothing

                iTipo = New TipoPagoDL
                oListadoTipos = iTipo.ListarTiposPago()

                Return oListadoTipos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


