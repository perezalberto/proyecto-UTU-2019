Imports System.Text.RegularExpressions


''' <summary>
''' Conjunto de funciones utilizadas para la validacion de los datos dados por los usuarios
''' </summary>
Module DataValidation

    ''' <summary>
    ''' Basado en codigo de https://github.com/francocorreasosa/ci_py
    ''' </summary>
    ''' <param name="ci">cedula uruguaya</param>
    ''' <returns>retorna true si la cédula es correcta</returns>
    Public Function IsValidCI(ci As String) As Boolean
        Dim a = 0
        Dim i = 0

        Dim valDigit = 0
        Dim ciNum = ci.Substring(0, 6)
        Dim ciDig = ci(ci.Length - 1)

        Regex.Replace(ci, "\D", "")

        If ci.Length < 7 Then
            For i = ci.Length To 6
                ci = "0" + ci
            Next
        End If
        For i = 0 To 6
            a += (Val("2987634"(i)) * Val(ci(i))) Mod 10
        Next

        If a Mod 10 <> 0 Then
            valDigit = 10 - a Mod 10
        End If

        Return ciDig.ToString = valDigit.ToString
    End Function

    ''' <summary>
    ''' Comprueba si el correo es correcto
    ''' </summary>
    ''' <param name="email">correo</param>
    ''' <returns>True si el correo es valido</returns>
    Public Function IsValidEmail(email As String) As Boolean
        Return Regex.IsMatch(email, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,})$")
    End Function

    ''' <summary>
    ''' Comprueba si el telefono es valido
    ''' </summary>
    ''' <param name="tel">Telefono</param>
    ''' <returns>True si el telefono es valido</returns>
    Public Function IsValidTelephone(tel As String) As Boolean
        Return Regex.IsMatch(tel, "(^[24][0-9]{7}$)|(^0[89][0-9]{7}$)")
    End Function

    ''' <summary>
    ''' Comprueba si el nombre o apellido tiene un formato valido
    ''' </summary>
    ''' <param name="name">Nombre</param>
    ''' <returns>True si es valido</returns>
    Public Function IsValidName(name As String) As Boolean
        Return Regex.IsMatch(name, "^([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\']+)([\s][A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\']+)*$")
    End Function

    ''' <summary>
    ''' Comprueba si la contraseña es valida
    ''' </summary>
    ''' <param name="pass"></param>
    ''' <param name="minSize"></param>
    ''' <returns></returns>
    Public Function IsValidPassword(pass As String, Optional minSize As UInteger = 8) As Boolean
        If minSize <= 0 Then Return False
        Return Regex.IsMatch(pass, "^[a-zA-Z0-9@.-_]{" + minSize.ToString + ",}$")
    End Function

End Module
