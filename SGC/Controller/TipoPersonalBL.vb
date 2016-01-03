Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarTipoPersonal(ByVal descripcion As String) As List(Of TipoPersonalBE)
            Try
                Dim iTipoPersonal As ITipoPersonal
                Dim oListadoTipos As List(Of TipoPersonalBE) = Nothing

                iTipoPersonal = New TipoPersonalDL
                oListadoTipos = iTipoPersonal.ListarTipoPersonal(descripcion)

                Return oListadoTipos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarTipoPersonalXActividad(ByVal id_actividad As Integer) As List(Of TipoPersonalBE)
            Try
                Dim iTipoPersonal As ITipoPersonal
                Dim oListadoTipoPersonal As List(Of TipoPersonalBE) = Nothing

                iTipoPersonal = New TipoPersonalDL
                oListadoTipoPersonal = iTipoPersonal.ListarTipoPersonalXActividad(id_actividad)

                Return oListadoTipoPersonal

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerTipoPersonalDemanda(ByVal id_comite As String, ByVal id_tipo As String) As List(Of TipoPersonalBE)
            Try
                Dim iTipo As ITipoPersonal
                Dim oListadoTipo As List(Of TipoPersonalBE) = Nothing

                iTipo = New TipoPersonalDL
                oListadoTipo = iTipo.ObtenerTipoPersonalDemanda(id_comite, id_tipo)

                Return oListadoTipo

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarDemandaTipoPersonal(ByVal fecIni As Date, ByVal fecFin As Date, ByVal id_comite As String, ByVal id_tipo As String) As List(Of TipoPersonalBE)
            Try
                Dim iTipo As ITipoPersonal
                Dim oListadoTipo As List(Of TipoPersonalBE) = Nothing

                iTipo = New TipoPersonalDL
                oListadoTipo = iTipo.ListarDemandaTipoPersonal(fecIni, fecFin, id_comite, id_tipo)

                Return oListadoTipo

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
