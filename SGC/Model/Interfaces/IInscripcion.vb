Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IInscripcion

#Region "Insert"

        Function InsertarInscripcion(ByRef oInscripcion As InscripcionBE) As Integer
        Function InsertarInscrito(ByRef oPersona As PersonaBE, ByVal entidad As String) As Integer

#End Region

    End Interface

End Namespace

