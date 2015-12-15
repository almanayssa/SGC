Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Class BusinessController

#Region "Select"

        Public Function ListarSocios(ByRef oSocioFiltro As SocioBE) As List(Of SocioBE)
            Try
                Dim iSocio As ISocio
                Dim oListadoSocios As List(Of SocioBE) = Nothing

                iSocio = New SocioDL
                oListadoSocios = iSocio.ListarSocios(oSocioFiltro)

                Return oListadoSocios

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace