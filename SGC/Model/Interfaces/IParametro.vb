Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IParametro

#Region "Select"

        Function ListarParametros() As List(Of ParametroBE)

#End Region

#Region "Update"

        Function ActualizarParametro(ByVal oParametro As ParametroBE) As Integer

#End Region

    End Interface

End Namespace

