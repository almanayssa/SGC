Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IArticuloCobranza

#Region "Select"

        Function ListarArticulosCobranza(ByVal id_Serie As String, ByVal id_correlativo As String, ByVal id_tipo_doc As String) As List(Of ArticuloCobranzaBE)

#End Region

#Region "Insert"

        Function InsertarArticuloCobranza(ByRef oDocumento As ArticuloCobranzaBE) As Integer

#End Region

    End Interface

End Namespace

