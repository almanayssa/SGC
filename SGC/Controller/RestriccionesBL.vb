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

#End Region

    End Class

End Namespace
