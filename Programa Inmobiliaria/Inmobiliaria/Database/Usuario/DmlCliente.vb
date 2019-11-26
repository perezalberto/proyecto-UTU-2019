Public Class DmlCliente
    Inherits DmlPersona

    Private dmlCli(1, -1) As String

    Public Overloads Function SetData(tipo As AtributoCliente, valor As Object) As DmlCliente
        Select Case tipo
            Case AtributoCliente.CORREO
                If (dataReg And &B100000) = &B100000 Then
                    Exit Select
                End If
                If Not IsValidEmail(valor) Then
                    Throw New CustomException("El correo no tiene el formato correcto!")
                End If
                ReDim Preserve dmlCli(1, UBound(dmlCli, 2) + 1)
                dmlCli(0, UBound(dmlCli, 2)) = "correo"
                dmlCli(1, UBound(dmlCli, 2)) = "'" + valor.ToString + "'"
                dataReg = dataReg Xor &B100000
            Case AtributoCliente.ESTADO
                If (dataReg And &B1000000) = &B1000000 Then
                    Exit Select
                End If
                ReDim Preserve dmlCli(1, UBound(dmlCli, 2) + 1)
                If valor = EstadoDatos.ACTIVO Then
                    dmlCli(0, UBound(dmlCli, 2)) = "activo"
                    dmlCli(1, UBound(dmlCli, 2)) = "true"
                ElseIf valor = EstadoDatos.INACTIVO Then
                    dmlCli(0, UBound(dmlCli, 2)) = "activo"
                    dmlCli(1, UBound(dmlCli, 2)) = "false"
                End If
                dataReg = dataReg Xor &B1000000
        End Select
        Return Me
    End Function

    Public Overloads Function DmlInsert() As String
        If (dataReg >> 5) <> &B11 Then
            Return ""
        End If

        If MyBase.ci = 0 Then
            Return ""
        End If

        Dim temp As String(,) = dmlCli.Clone()
        ReDim Preserve temp(1, UBound(temp, 2) + 1)
        temp(0, UBound(temp, 2)) = "ci_cli"
        temp(1, UBound(temp, 2)) = MyBase.ci.ToString

        Return "INSERT INTO cliente (" + Join2d(temp, ",", 0) + ") VALUES (" + Join2d(temp, ",", 1) + ")"
    End Function

    Public Overloads Function DmlUpdate(ci As Integer) As String
        If Not IsSet() Then
            Return ""
        End If
        Return "UPDATE cliente SET " + Join2d(dmlCli, " = ", ",") + " WHERE ci_cli = " + ci.ToString
    End Function

    Public Overloads Function IsSet() As Boolean
        Return (dataReg >> 5) <> &B0
    End Function

    Public Overloads Function IsAllSet() As Boolean
        Return dataReg = &B1111111
    End Function
End Class
