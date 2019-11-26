Imports MySql.Data.MySqlClient

Public Class DmlPropiedad
    Private dmlData(1, -1) As String
    Private imagen As Image
    Private dataReg As Integer = &B0

    Public Function SetData(atrib As AtributoPropiedad, valor As Object) As DmlPropiedad
        ReDim Preserve dmlData(1, UBound(dmlData, 2) + 1)
        Dim restore As Boolean = False
        Try
            Select Case atrib
                Case AtributoPropiedad.CI_CLIENTE
                    If (dataReg And &B1) = &B1 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "ci_cli"
                    dmlData(1, UBound(dmlData, 2)) = valor.ToString
                    dataReg = dataReg Xor &B1
                Case AtributoPropiedad.CODIGO_LOCALIDAD
                    If (dataReg And &B10) = &B10 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "id_loc"
                    dmlData(1, UBound(dmlData, 2)) = valor.ToString
                    dataReg = dataReg Xor &B10
                Case AtributoPropiedad.DIRECCION
                    If (dataReg And &B100) = &B100 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "direc"
                    dmlData(1, UBound(dmlData, 2)) = "'" + valor.ToString + "'"
                    dataReg = dataReg Xor &B100
                Case AtributoPropiedad.ESTADO
                    If (dataReg And &B1000) = &B1000 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "activo"
                    If CType(valor, EstadoDatos) = EstadoDatos.ACTIVO Then
                        dmlData(1, UBound(dmlData, 2)) = "1"
                    ElseIf CType(valor, EstadoDatos) = EstadoDatos.INACTIVO Then
                        dmlData(1, UBound(dmlData, 2)) = "0"
                    End If
                    dataReg = dataReg Xor &B1000
                Case AtributoPropiedad.HABITACIONES
                    If (dataReg And &B10000) = &B10000 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "cant_habs"
                    dmlData(1, UBound(dmlData, 2)) = valor.ToString
                    dataReg = dataReg Xor &B10000
                Case AtributoPropiedad.MTS2
                    If (dataReg And &B100000) = &B100000 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "mts2"
                    dmlData(1, UBound(dmlData, 2)) = valor.ToString
                    dataReg = dataReg Xor &B100000
                Case AtributoPropiedad.OPERACION
                    If (dataReg And &B1000000) = &B1000000 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "operacion"
                    If CType(valor, OperacionPropiedad) = OperacionPropiedad.ALQUILER Then
                        dmlData(1, UBound(dmlData, 2)) = "'alquiler'"
                    ElseIf CType(valor, OperacionPropiedad) = OperacionPropiedad.VENTA Then
                        dmlData(1, UBound(dmlData, 2)) = "'venta'"
                    ElseIf CType(valor, OperacionPropiedad) = OperacionPropiedad.NULL Then
                        dmlData(1, UBound(dmlData, 2)) = "'ambas'"
                    End If
                    dataReg = dataReg Xor &B1000000
                Case AtributoPropiedad.PRECIO
                    If (dataReg And &B10000000) = &B10000000 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "precio"
                    dmlData(1, UBound(dmlData, 2)) = valor.ToString
                    dataReg = dataReg Xor &B10000000
                Case AtributoPropiedad.TIPO
                    If (dataReg And &B100000000) = &B100000000 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "tipo"
                    If CType(valor, TipoPropiedad) = TipoPropiedad.APARTAMENTO Then
                        dmlData(1, UBound(dmlData, 2)) = "'apartamento'"
                    ElseIf CType(valor, TipoPropiedad) = TipoPropiedad.CASA Then
                        dmlData(1, UBound(dmlData, 2)) = "'casa'"
                    ElseIf CType(valor, TipoPropiedad) = TipoPropiedad.LOCAL_COMERCIAL Then
                        dmlData(1, UBound(dmlData, 2)) = "'local comercial'"
                    End If
                    dataReg = dataReg Xor &B100000000
                Case AtributoPropiedad.IMAGEN
                    If (dataReg And &B1000000000) = &B1000000000 Then
                        restore = True
                        Exit Select
                    End If
                    dmlData(0, UBound(dmlData, 2)) = "imagen"
                    dmlData(1, UBound(dmlData, 2)) = "?"
                    imagen = ImageResize(valor, My.Settings.MaxImageWidth, My.Settings.MaxImageHeight)
                    dataReg = dataReg Xor &B1000000000
            End Select
        Catch ex As Exception
            ReDim Preserve dmlData(1, UBound(dmlData, 2) - 1)
        End Try
        If restore Then
            ReDim Preserve dmlData(1, UBound(dmlData, 2) - 1)
        End If
        Return Me
    End Function

    Public Function DmlUpdate(id As Integer) As MySqlCommand

        If Not IsSet() Then
            Return Nothing
        End If

        Dim command As New MySqlCommand("UPDATE propiedad SET " + Join2d(dmlData, " = ", ",") + " WHERE cod_prop = " + id.ToString)

        If imagen IsNot Nothing And IsSet() Then
            Dim imgParam As New MySqlParameter("imagen", ImageToByteArray(imagen))
            imgParam.MySqlDbType = MySqlDbType.MediumBlob
            command.Parameters.Add(imgParam)
        End If

        Return command
    End Function

    Public Function DmlInsert() As MySqlCommand

        If Not IsAllSet() Then
            Return Nothing
        End If

        Dim command As New MySqlCommand("INSERT INTO propiedad (" + Join2d(dmlData, ",", 0) + ") VALUES (" + Join2d(dmlData, ",", 1) + ")")

        If imagen IsNot Nothing Then
            Dim imgParam As New MySqlParameter("imagen", ImageToByteArray(imagen))
            imgParam.MySqlDbType = MySqlDbType.MediumBlob
            command.Parameters.Add(imgParam)
        End If

        Return command
    End Function

    Public Function IsSet() As Boolean
        Return dataReg <> &B0
    End Function

    Public Function IsAllSet() As Boolean
        Return dataReg = &B1111111111
    End Function
End Class

