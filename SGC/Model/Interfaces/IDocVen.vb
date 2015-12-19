Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IDocVen

#Region "Select"

        Function ObtenerCorrelativo() As DocVenBE
        Function ListarDocumentos(ByVal id_socio As String) As List(Of DocVenBE)
#End Region

#Region "Insert"

        Function InsertarDocVen(ByRef oDocumento As DocVenBE) As Integer

#End Region

    End Interface

End Namespace

