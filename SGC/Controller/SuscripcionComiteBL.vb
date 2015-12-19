Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarSuscripcionComites(ByVal id_socio As String) As List(Of SuscripcionComiteBE)
            Try
                Dim iSuscripcionComite As ISuscripcionComite
                Dim oListadoSusComites As List(Of SuscripcionComiteBE) = Nothing

                iSuscripcionComite = New SuscripcionComiteDL
                oListadoSusComites = iSuscripcionComite.ListarSuscripcionComites(id_socio)

                Return oListadoSusComites

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarSuscripcionComite(ByRef oListado As List(Of SuscripcionComiteBE), ByRef oSocio As SocioBE) As Boolean
            Try

                Dim iSuscripcionComite As ISuscripcionComite
                iSuscripcionComite = New SuscripcionComiteDL

                Dim affectedRows As Integer

                affectedRows = iSuscripcionComite.BorrarSuscripcionComite(oSocio.id_socio)

                For Each oSuscripcion As SuscripcionComiteBE In oListado
                    oSuscripcion.id_socio = oSocio.id_socio
                    iSuscripcionComite.InsertarSuscripcionComite(oSuscripcion)
                Next

                Return True

            Catch ex As Exception
                Return False
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarSuscripcion(ByVal id_socio As String) As Integer
            Try
                Dim iSus As ISuscripcionComite
                iSus = New SuscripcionComiteDL

                Dim affectedRows As Integer
                affectedRows = iSus.BorrarSuscripcionComite(id_socio)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


