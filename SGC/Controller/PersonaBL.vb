Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarPersonasFamilia(ByVal password As String, ByVal nombre As String) As List(Of PersonaBE)
            Try
                Dim iPersona As IPersona
                Dim oListarPersonas As List(Of PersonaBE) = Nothing

                iPersona = New PersonaDL
                oListarPersonas = iPersona.ListarPersonasFamilia(password, nombre)

                Return oListarPersonas

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarPersonaXActividad(ByVal id_actividad As Integer) As List(Of PersonaBE)
            Try
                Dim iPersona As IPersona
                Dim oListadoPersona As List(Of PersonaBE) = Nothing

                iPersona = New PersonaDL
                oListadoPersona = iPersona.ListarPersonaXActividad(id_actividad)

                Return oListadoPersona

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

