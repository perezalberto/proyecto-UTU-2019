Public Class Telefonos
    Private __tel(-1) As String

    Public Function SetNumber(tel As String) As Telefonos
        If IsValidTelephone(tel) Then
            ReDim Preserve __tel(UBound(__tel) + 1)
            __tel(UBound(__tel)) = tel
        Else
            Throw New CustomException("El numero de teléfono " + tel + " no es valido")
        End If
        Return Me
    End Function

    Public Function SetNumber(tels As String()) As Telefonos
        For Each tel In tels
            SetNumber(tel)
        Next
        Return Me
    End Function

    Private Function GetInsertSeq(ci As String) As String
        Dim res = ""
        For i = 0 To __tel.Length - 1
            res += "(" + ci.ToString + ",'" + __tel(i) + "')"
            If __tel.Length - 1 <> i Then
                res += ","
            End If
        Next
        Return res
    End Function

    Public Function ObtenerNumeros(ci As Integer) As String()
        Dim datos = Database.GetInstance.SQL("SELECT numero FROM telefono WHERE ci = " + ci.ToString)
        Dim numeros As String() = datos.AsEnumerable().[Select](Function(x) x.Field(Of String)("numero")).ToArray()
        Return numeros
    End Function

    Public Function EliminarTelefono(ci As Integer) As Boolean
        Return Database.GetInstance.DML("DELETE FROM telefono WHERE ci = " + ci.ToString)
    End Function

    Public Function EliminarTelefono(ci As Integer, num As String) As Boolean
        Return Database.GetInstance.DML("DELETE FROM telefono WHERE ci = " + ci.ToString + " AND numero = " + num)
    End Function

    Public Function Remplazar(ci As Integer) As Boolean
        If __tel.Length = 0 Then
            Return False
        End If
        EliminarTelefono(ci)
        Return Database.GetInstance.DML("INSERT INTO telefono (ci,numero) VALUES " + GetInsertSeq(ci))
    End Function

    Public Function Agregar(ci As Integer) As Boolean
        If __tel.Length = 0 Then
            Return False
        End If
        Return Database.GetInstance.DML("INSERT INTO telefono (ci,numero) VALUES " + GetInsertSeq(ci) + " ON DUPLICATE KEY UPDATE ci=ci,numero=numero")
    End Function

    Public Function ExisteTelefono(tel As String) As Boolean
        Try
            Dim res = Database.GetInstance.SQL("SELECT COUNT(numero) FROM telefono WHERE numero = '" + tel.ToString + "'").Rows(0).Item(0)
            If res = "0" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
