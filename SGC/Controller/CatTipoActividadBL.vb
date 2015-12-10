Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarCatTipoActividad(ByVal id_tipo_act As String) As List(Of CatTipoActividadBE)
            Try
                Dim iCatTipoActividad As ICatTipoActividad
                Dim oListadoCatTipoActividad As List(Of CatTipoActividadBE) = Nothing

                iCatTipoActividad = New CatTipoActividadDL
                oListadoCatTipoActividad = iCatTipoActividad.ListarCatTipoActividad(id_tipo_act)

                Return oListadoCatTipoActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
