Imports SGC.Model.Entidades


Namespace SGC.Model.Interfaces

    Public Interface ISocio

#Region "Select"

        Function ListarSocios(ByRef oSocioFiltro As SocioBE) As List(Of SocioBE)

#End Region

    End Interface

End Namespace