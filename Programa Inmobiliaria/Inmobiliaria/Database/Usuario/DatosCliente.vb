Public Class DatosCliente
    Inherits DatosPersona
    Private __correo As String
    Public Property Correo As String
        Get
            Return __correo
        End Get
        Set(value As String)
            If IsValidEmail(value) Then
                __correo = value
            Else
                Throw New CustomException("El correo no tiene el formato correcto")
            End If
        End Set
    End Property
End Class
