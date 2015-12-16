Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IEncuestaDetalle

#Region "Select"

        Function ListarEncuestaDetalle(ByVal id_encuesta As Integer) As List(Of EncuestaDetalleBE)

#End Region

#Region "Insert"

        Function InsertarEncuestaDetalle(ByRef oEncuestaDetalle As EncuestaDetalleBE) As Integer

#End Region

    End Interface

End Namespace

