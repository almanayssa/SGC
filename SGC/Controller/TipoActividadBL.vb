Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarTipoActividad() As List(Of TipoActividadBE)
            Try
                Dim iTipoActividad As ITipoActividad
                Dim oListadoTipoActividad As List(Of TipoActividadBE) = Nothing

                iTipoActividad = New TipoActividadDL
                oListadoTipoActividad = iTipoActividad.ListarTipoActividad()

                Return oListadoTipoActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarTipoActividadVal(ByVal idTipo As String) As List(Of TipoActividadBE)
            Try
                Dim iTipoActividad As ITipoActividad
                Dim oListadoTipoActividad As List(Of TipoActividadBE) = Nothing

                iTipoActividad = New TipoActividadDL
                oListadoTipoActividad = iTipoActividad.ListarTipoActividadVal(idTipo)

                Return oListadoTipoActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
