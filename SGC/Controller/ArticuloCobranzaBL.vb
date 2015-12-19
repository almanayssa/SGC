Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarArticulosCobranza(ByVal id_Serie As String, ByVal id_correlativo As String, ByVal id_tipo_doc As String) As List(Of ArticuloCobranzaBE)
            Try
                Dim iArticuloCob As IArticuloCobranza
                Dim oListadoArticulosCob As List(Of ArticuloCobranzaBE) = Nothing

                iArticuloCob = New ArticuloCobranzaDL
                oListadoArticulosCob = iArticuloCob.ListarArticulosCobranza(id_Serie, id_correlativo, id_tipo_doc)

                Return oListadoArticulosCob

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


