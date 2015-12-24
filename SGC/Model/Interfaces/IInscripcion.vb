Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IInscripcion

#Region "Select"

        Function ListarInscripciones(ByVal id_socio As String) As List(Of InscripcionBE)

#End Region

#Region "Insert"

        Function InsertarInscripcion(ByRef oInscripcion As InscripcionBE) As Integer
        Function InsertarInscrito(ByRef oPersona As PersonaBE, ByVal entidad As String) As Integer

#End Region

    End Interface

End Namespace

