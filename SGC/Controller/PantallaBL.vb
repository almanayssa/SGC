Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarOpciones() As List(Of PantallaBE)
            Try
                Dim iPantalla As IPantalla
                Dim oListadoOpciones As List(Of PantallaBE) = Nothing

                iPantalla = New PantallaDL
                oListadoOpciones = iPantalla.ListarOpciones()

                Return oListadoOpciones

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarOpcionesXPerfil(ByVal id_perfil_usuario As Integer) As List(Of PantallaBE)
            Try
                Dim iPantalla As IPantalla
                Dim oListadoOpciones As List(Of PantallaBE) = Nothing

                iPantalla = New PantallaDL
                oListadoOpciones = iPantalla.ListarOpcionesXPerfil(id_perfil_usuario)

                Return oListadoOpciones

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

