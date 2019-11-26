Public Class DatosPersona
    Private __ci As Integer
    Private __nombre As String
    Private __apellido As String
    Private __telefonos(-1) As String

    Public Property Ci As Integer
        Get
            Return __ci
        End Get
        Set(value As Integer)
            If IsValidCI(value) Then
                __ci = value
            Else
                Throw New CustomException("La CI no es valida")
            End If
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return __nombre
        End Get
        Set(value As String)
            If IsValidName(value) Then
                __nombre = value
            Else
                Throw New CustomException("El nombre no tiene el formato correcto")
            End If
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return __apellido
        End Get
        Set(value As String)
            If IsValidName(value) Then
                __apellido = value
            Else
                Throw New CustomException("El apellido no tiene el formato correcto")
            End If
        End Set
    End Property

    Public Property Direccion As String
    Public Property IdLocalidad As Integer

    Public Property Telefonos As String()
        Get
            Return __telefonos
        End Get
        Set(value As String())
            For Each tel In value
                AgregarTelefono(tel)
            Next
        End Set
    End Property

    Public Sub AgregarTelefono(tel As String)
        If IsValidTelephone(tel) Then
            ReDim Preserve __telefonos(UBound(__telefonos) + 1)
            __telefonos(UBound(__telefonos)) = tel
        Else
            Throw New CustomException("El telefono " + tel.ToString + " no es correcto")
        End If
    End Sub

End Class
