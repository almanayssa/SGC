﻿Namespace SGC.Model.Entidades
    Public Class TipoPersonalBE

        Private _id_tipo_personal As Integer
        Public Property id_tipo_personal() As Integer
            Get
                Return _id_tipo_personal
            End Get
            Set(ByVal value As Integer)
                _id_tipo_personal = value
            End Set
        End Property

        Private _descripcion As String
        Public Property descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property

    End Class
End Namespace

