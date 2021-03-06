﻿Namespace SGC.Model.Entidades
    Public Class ActividadDetalleBE

        Private _id_actividad_detalle As Integer
        Public Property id_actividad_detalle() As Integer
            Get
                Return _id_actividad_detalle
            End Get
            Set(ByVal value As Integer)
                _id_actividad_detalle = value
            End Set
        End Property


        Private _id_actividad As Integer
        Public Property id_actividad() As Integer
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As Integer)
                _id_actividad = value
            End Set
        End Property

        Private _fecha As DateTime
        Public Property fecha() As DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As DateTime)
                _fecha = value
            End Set
        End Property

        Private _hora_ini As TimeSpan
        Public Property hora_ini() As TimeSpan
            Get
                Return _hora_ini
            End Get
            Set(ByVal value As TimeSpan)
                _hora_ini = value
            End Set
        End Property

        Private _hora_fin As TimeSpan
        Public Property hora_fin() As TimeSpan
            Get
                Return _hora_fin
            End Get
            Set(ByVal value As TimeSpan)
                _hora_fin = value
            End Set
        End Property

        Private _id_sede As String
        Public Property id_sede() As String
            Get
                Return _id_sede
            End Get
            Set(ByVal value As String)
                _id_sede = value
            End Set
        End Property

        Private _id_espacio As Integer
        Public Property id_espacio() As Integer
            Get
                Return _id_espacio
            End Get
            Set(ByVal value As Integer)
                _id_espacio = value
            End Set
        End Property

        'Private _vacantes As Integer?
        'Public Property vacantes() As Integer?
        '    Get
        '        Return _vacantes
        '    End Get
        '    Set(ByVal value As Integer?)
        '        _vacantes = value
        '    End Set
        'End Property

        Private _des_sede As String
        Public Property des_sede() As String
            Get
                Return _des_sede
            End Get
            Set(ByVal value As String)
                _des_sede = value
            End Set
        End Property

        Private _id_lugar As Integer
        Public Property id_lugar() As Integer
            Get
                Return _id_lugar
            End Get
            Set(ByVal value As Integer)
                _id_lugar = value
            End Set
        End Property

        Private _nombre_espacio As String
        Public Property nombre_espacio() As String
            Get
                Return _nombre_espacio
            End Get
            Set(ByVal value As String)
                _nombre_espacio = value
            End Set
        End Property

    End Class
End Namespace

