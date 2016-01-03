Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IParametros

#Region "Select"

        Function ListarParametros() As List(Of ParametrosBE)

        Function ObtenerParametro(ByVal id As String) As ParametrosBE

#End Region


#Region "Update"

        Function ActualizarParametro(ByVal oParametro As ParametrosBE) As Integer

#End Region
    End Interface

End Namespace

