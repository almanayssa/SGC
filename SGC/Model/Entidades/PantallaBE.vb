﻿Namespace SGC.Model.Entidades

    Public Class PantallaBE

        Private _id_pantalla As String
        Public Property id_pantalla() As String
            Get
                Return _id_pantalla
            End Get
            Set(ByVal value As String)
                _id_pantalla = value
            End Set
        End Property

        Private _nom_pantalla As String
        Public Property nom_pantalla() As String
            Get
                Return _nom_pantalla
            End Get
            Set(ByVal value As String)
                _nom_pantalla = value
            End Set
        End Property

    End Class

End Namespace

