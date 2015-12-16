Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarRestricciones() As List(Of RestriccionesBE)
            Try
                Dim iRestriccion As IRestricciones
                Dim oListadoRestricciones As List(Of RestriccionesBE) = Nothing

                iRestriccion = New RestriccionesDL
                oListadoRestricciones = iRestriccion.ListarRestricciones()

                Return oListadoRestricciones

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarRestriccionesXActividad(ByVal id_actividad As Integer) As List(Of RestriccionesBE)
            Try
                Dim iRestriccion As IRestricciones
                Dim oListadoRestricciones As List(Of RestriccionesBE) = Nothing

                iRestriccion = New RestriccionesDL
                oListadoRestricciones = iRestriccion.ListarRestriccionesXActividad(id_actividad)

                Return oListadoRestricciones

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerCantidadXRestriccion(ByVal id_actividad As Integer, ByVal id_restriccion As Integer, ByVal id_socio As String, ByVal id_persona As String, ByVal id_invitado As String) As String
            Try
                Dim iRestriccion As IRestricciones
                Dim result As String

                iRestriccion = New RestriccionesDL
                result = iRestriccion.ObtenerCantidadXRestriccion(id_actividad, id_restriccion, id_socio, id_persona, id_invitado)

                Return result

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
