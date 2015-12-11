Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarLugares() As List(Of LugarBE)
            Try
                Dim iLugar As ILugar
                Dim oListadoLugares As List(Of LugarBE) = Nothing

                iLugar = New LugarDL
                oListadoLugares = iLugar.ListarLugares()

                Return oListadoLugares

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
