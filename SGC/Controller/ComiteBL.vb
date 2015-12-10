﻿Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarComites() As List(Of ComiteBE)
            Try
                Dim iComite As IComite
                Dim oListadoComites As List(Of ComiteBE) = Nothing

                iComite = New ComiteDL
                oListadoComites = iComite.ListarComites()

                Return oListadoComites

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


