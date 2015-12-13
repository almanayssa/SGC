Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IEspacio

#Region "Select"

        Function ListarEspacios(ByVal id_sede As String, ByVal id_lugar As Integer) As List(Of EspacioBE)
        Function ObtenerEspacio(ByVal id_espacio As Integer) As EspacioBE

#End Region

#Region "Insert"

        Function InsertarEspacio(ByRef oEspacio As EspacioBE) As Integer

#End Region

#Region "Update"

        Function ActualizarEspacio(ByRef oEspacio As EspacioBE) As Integer

#End Region

#Region "Delete"

        Function BorrarEspacio(ByVal id_espacio As Integer) As Integer

#End Region

    End Interface

End Namespace

