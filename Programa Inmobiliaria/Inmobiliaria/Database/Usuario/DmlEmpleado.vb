Public Class DmlEmpleado
    Inherits DmlPersona

    Private dmlEmp(1, -1) As String

    Public Overloads Function SetData(tipo As AtributoEmpleado, valor As Object) As DmlEmpleado
        Select Case tipo
            Case AtributoEmpleado.PASSWORD
                If (dataReg And &B100000) = &B100000 Then
                    Exit Select
                End If
                If Not IsValidPassword(valor) Then
                    Throw New CustomException("La contraceña no es valida. Debe ser de mas de 8 caracteres y solo admite números, letras, guión, guión bajo, y punto")
                End If
                ReDim Preserve dmlEmp(1, UBound(dmlEmp, 2) + 1)
                dmlEmp(0, UBound(dmlEmp, 2)) = "passwd"
                dmlEmp(1, UBound(dmlEmp, 2)) = "PASSWORD('" + valor.ToString + "')"
                dataReg = dataReg Xor &B100000
            Case AtributoEmpleado.COD_SUCURSAL
                If (dataReg And &B1000000) = &B1000000 Then
                    Exit Select
                End If
                ReDim Preserve dmlEmp(1, UBound(dmlEmp, 2) + 1)
                dmlEmp(0, UBound(dmlEmp, 2)) = "cod_suc"
                dmlEmp(1, UBound(dmlEmp, 2)) = valor.ToString
                dataReg = dataReg Xor &B1000000
            Case AtributoEmpleado.ROL
                If (dataReg And &B10000000) = &B10000000 Then
                    Exit Select
                End If
                ReDim Preserve dmlEmp(1, UBound(dmlEmp, 2) + 1)
                If valor = RolEmpleado.AGENTE Then
                    dmlEmp(0, UBound(dmlEmp, 2)) = "rol"
                    dmlEmp(1, UBound(dmlEmp, 2)) = "'agente'"
                ElseIf valor = RolEmpleado.GERENTE Then
                    dmlEmp(0, UBound(dmlEmp, 2)) = "rol"
                    dmlEmp(1, UBound(dmlEmp, 2)) = "'gerente'"
                End If
                dataReg = dataReg Xor &B10000000
            Case AtributoEmpleado.ESTADO
                If (dataReg And &B100000000) = &B100000000 Then
                    Exit Select
                End If
                ReDim Preserve dmlEmp(1, UBound(dmlEmp, 2) + 1)
                If valor = EstadoDatos.ACTIVO Then
                    dmlEmp(0, UBound(dmlEmp, 2)) = "activo"
                    dmlEmp(1, UBound(dmlEmp, 2)) = "true"
                ElseIf valor = EstadoDatos.INACTIVO Then
                    dmlEmp(0, UBound(dmlEmp, 2)) = "activo"
                    dmlEmp(1, UBound(dmlEmp, 2)) = "false"
                End If
                dataReg = dataReg Xor &B100000000
        End Select
        Return Me
    End Function

    Public Overloads Function DmlInsert() As String
        If (dataReg >> 5) <> &B1111 Then
            Return ""
        End If

        If MyBase.ci = 0 Then
            Return ""
        End If

        Dim temp As String(,) = dmlEmp.Clone()
        ReDim Preserve temp(1, UBound(temp, 2) + 1)
        temp(0, UBound(temp, 2)) = "ci_emp"
        temp(1, UBound(temp, 2)) = MyBase.ci.ToString

        Return "INSERT INTO empleado (" + Join2d(temp, ",", 0) + ") VALUES (" + Join2d(temp, ",", 1) + ")"
    End Function

    Public Overloads Function DmlUpdate(ci As Integer) As String
        If Not IsSet() Then
            Return ""
        End If

        Return "UPDATE empleado SET " + Join2d(dmlEmp, " = ", ",") + " WHERE ci_emp = " + ci.ToString
    End Function

    Public Overloads Function IsSet() As Boolean
        Return (dataReg >> 5) <> &B0
    End Function

    Public Overloads Function IsAllSet() As Boolean
        Return dataReg = &B111111111
    End Function
End Class
