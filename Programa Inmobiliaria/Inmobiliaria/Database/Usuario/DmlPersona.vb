Public Class DmlPersona

    Private dmlPer(1, -1) As String
    Protected dataReg As UShort = &B0
    Protected ci As Integer = 0

    Public Function SetData(tipo As AtributoPersona, valor As Object) As DmlPersona
        Select Case tipo
            Case AtributoPersona.CI
                If (dataReg And &B1) = &B1 Then
                    Exit Select
                End If
                If Not IsValidCI(valor) Then
                    Throw New CustomException("La cedula no es valida")
                End If
                ReDim Preserve dmlPer(1, UBound(dmlPer, 2) + 1)
                dmlPer(0, UBound(dmlPer, 2)) = "ci"
                dmlPer(1, UBound(dmlPer, 2)) = valor.ToString
                ci = valor
                dataReg = dataReg Xor &B1
            Case AtributoPersona.NOMBRE
                If (dataReg And &B10) = &B10 Then
                    Exit Select
                End If
                ReDim Preserve dmlPer(1, UBound(dmlPer, 2) + 1)
                dmlPer(0, UBound(dmlPer, 2)) = "nombre"
                dmlPer(1, UBound(dmlPer, 2)) = "'" + valor.ToString + "'"
                dataReg = dataReg Xor &B10
            Case AtributoPersona.APELLIDO
                If (dataReg And &B100) = &B100 Then
                    Exit Select
                End If
                ReDim Preserve dmlPer(1, UBound(dmlPer, 2) + 1)
                dmlPer(0, UBound(dmlPer, 2)) = "apellido"
                dmlPer(1, UBound(dmlPer, 2)) = "'" + valor.ToString + "'"
                dataReg = dataReg Xor &B100
            Case AtributoPersona.DIRECCION
                If (dataReg And &B1000) = &B1000 Then
                    Exit Select
                End If
                ReDim Preserve dmlPer(1, UBound(dmlPer, 2) + 1)
                dmlPer(0, UBound(dmlPer, 2)) = "direc"
                dmlPer(1, UBound(dmlPer, 2)) = "'" + valor.ToString + "'"
                dataReg = dataReg Xor &B1000
            Case AtributoPersona.LOCALIDAD
                If (dataReg And &B10000) = &B10000 Then
                    Exit Select
                End If
                ReDim Preserve dmlPer(1, UBound(dmlPer, 2) + 1)
                dmlPer(0, UBound(dmlPer, 2)) = "id_loc"
                dmlPer(1, UBound(dmlPer, 2)) = valor.ToString
                dataReg = dataReg Xor &B10000
        End Select
        Return Me
    End Function

    Public Function DmlInsert() As String
        If Not IsAllSet() Then
            Return ""
        End If
        Return "INSERT INTO persona (" + Join2d(dmlPer, ",", 0) + ") VALUES (" + Join2d(dmlPer, ",", 1) + ")"
    End Function

    Public Function DmlUpdate(ci As Integer) As String
        If Not IsSet() Then
            Return ""
        End If
        Return "UPDATE persona SET " + Join2d(dmlPer, " = ", ",") + " WHERE ci = " + ci.ToString
    End Function

    Public Function IsSet() As Boolean
        Return (dataReg << 11) <> &B0
    End Function

    Public Function IsAllSet() As Boolean
        Return (dataReg << 11) = (&B11111 << 11)
    End Function

    Public Function IsExtendedSet() As Boolean
        Return dataReg > &B11111
    End Function
End Class
