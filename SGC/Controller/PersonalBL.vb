Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarPersonal(ByVal id_tipo As Integer, ByVal nombre As String) As List(Of PersonalBE)
            Try
                Dim iPersonal As IPersonal
                Dim oListadoPersonal As List(Of PersonalBE) = Nothing

                iPersonal = New PersonalDL
                oListadoPersonal = iPersonal.ListarPersonal(id_tipo, nombre)

                Return oListadoPersonal

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarPersonalXActividad(ByVal id_actividad As Integer) As List(Of PersonalBE)
            Try
                Dim iPersonal As IPersonal
                Dim oListadoPersonal As List(Of PersonalBE) = Nothing

                iPersonal = New PersonalDL
                oListadoPersonal = iPersonal.ListarPersonalXActividad(id_actividad)

                Return oListadoPersonal

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

