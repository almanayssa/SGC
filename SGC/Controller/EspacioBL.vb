Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarEspacios(ByVal id_sede As String, ByVal id_lugar As Integer) As List(Of EspacioBE)
            Try
                Dim iEspacio As IEspacio
                Dim oListadoEspacios As List(Of EspacioBE) = Nothing

                iEspacio = New EspacioDL
                oListadoEspacios = iEspacio.ListarEspacios(id_sede, id_lugar)

                Return oListadoEspacios

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerEspacio(ByVal id_espacio As Integer) As EspacioBE
            Try
                Dim iEspacio As IEspacio
                Dim oEspacio As EspacioBE = Nothing

                iEspacio = New EspacioDL
                oEspacio = iEspacio.ObtenerEspacio(id_espacio)

                Return oEspacio

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarEspacio(ByRef oEspacio As EspacioBE) As Integer
            Try
                Dim iEspacio As IEspacio
                iEspacio = New EspacioDL

                Dim id_espacio As Integer
                id_espacio = iEspacio.InsertarEspacio(oEspacio)

                oEspacio.id_espacio = id_espacio

                Return oEspacio.id_espacio

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Update"

        Public Function ActualizarEspacio(ByRef oEspacio As EspacioBE) As Integer
            Try
                Dim affectedRows As Integer

                Dim iEspacio As IEspacio
                iEspacio = New EspacioDL

                affectedRows += iEspacio.ActualizarEspacio(oEspacio)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarEspacio(ByRef id_espacio As Integer) As Integer
            Try
                Dim iEspacio As IEspacio
                iEspacio = New EspacioDL

                Dim affectedRows As Integer
                affectedRows = iEspacio.BorrarEspacio(id_espacio)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
