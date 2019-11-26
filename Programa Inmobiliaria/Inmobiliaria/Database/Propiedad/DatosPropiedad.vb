Public Class DatosPropiedad
    Public Property CiCliente As Integer = 0
    Public Property Tipo As TipoPropiedad = TipoPropiedad.NULL
    Public Property Operacion As OperacionPropiedad = OperacionPropiedad.NULL
    Public Property Precio As Integer = -1
    Public Property Habitaciones As Integer = -1
    Public Property Mts2 As Integer = -1
    Public Property Direccion As String = ""
    Public Property Localidad As Integer = -1
    Public Property Estado As EstadoDatos = EstadoDatos.NULL
    Public Property Imagen As Image = Nothing

    Public Function IsAllSet() As Boolean
        Dim ok As Boolean = True

        If CiCliente = 0 Then
            ok = False
        End If

        If Tipo = TipoPropiedad.NULL Then
            ok = False
        End If

        If Operacion = OperacionPropiedad.NULL Then
            ok = False
        End If

        If Precio = -1 Then
            ok = False
        End If

        If Habitaciones = -1 Then
            ok = False
        End If

        If Mts2 = -1 Then
            ok = False
        End If

        If Direccion = "" Then
            ok = False
        End If

        If Localidad = -1 Then
            ok = False
        End If

        If Estado = EstadoDatos.NULL Then
            ok = False
        End If

        If Imagen Is Nothing Then
            ok = False
        End If

        Return ok

    End Function
End Class
