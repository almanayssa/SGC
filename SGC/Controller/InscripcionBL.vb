Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarInscripciones(ByVal id_socio As String) As List(Of InscripcionBE)
            Try
                Dim iInscripcion As IInscripcion
                Dim oListadoInscripcion As List(Of InscripcionBE) = Nothing

                iInscripcion = New InscripcionDL

                oListadoInscripcion = iInscripcion.ListarInscripciones(id_socio)

                Return oListadoInscripcion

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarInscripcion(ByRef oInscripcion As InscripcionBE) As Integer
            Try
                Dim iInscripcion As IInscripcion
                iInscripcion = New InscripcionDL

                Dim key As Integer
                key = iInscripcion.InsertarInscripcion(oInscripcion)

                If oInscripcion.ListaPersona IsNot Nothing Then
                    For Each oPersona As PersonaBE In oInscripcion.ListaPersona
                        oPersona.id_inscripcion = key
                        iInscripcion.InsertarInscrito(oPersona, "P")
                    Next
                End If

                If oInscripcion.ListaInvitado IsNot Nothing Then
                    For Each oInvitado As InvitadoBE In oInscripcion.ListaInvitado
                        Dim oPersona As New PersonaBE
                        oPersona.id_inscripcion = key
                        oPersona.id_persona = oInvitado.id_invitado
                        oPersona.tipo_familiar = "Invitado"

                        iInscripcion.InsertarInscrito(oPersona, "I")
                    Next
                End If

                oInscripcion.id_inscripcion = key

                Return oInscripcion.id_inscripcion

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


