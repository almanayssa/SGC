Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IActividadRecurrente

#Region "Select"

        Function ListarActividadesRecurrentes(ByVal id_comite As String, ByVal fec_inicio As DateTime, ByVal fec_fin As DateTime) As List(Of ActividadRecurrenteBE)

#End Region

#Region "Insert"

        Function InsertarActividadRecurrente(ByRef oActividadRecurrente As ActividadRecurrenteBE) As Integer

#End Region

    End Interface

End Namespace

