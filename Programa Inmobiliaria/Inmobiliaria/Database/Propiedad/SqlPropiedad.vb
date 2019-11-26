Public Class SqlPropiedad
    Private sqlFilter(-1) As String
    Private limOrigen As UInteger
    Private limCantidad As UInteger
    Private mostrarImagen As Boolean
    Private orden As String

    Public Sub New()
        limCantidad = 100
        limOrigen = 0
        mostrarImagen = False
    End Sub

    Public Function Filtro(tipo As FiltroPropiedad, valor As Object) As SqlPropiedad
        ReDim Preserve sqlFilter(UBound(sqlFilter) + 1)
        Try
            Select Case tipo
                Case FiltroPropiedad.CI_CLIENTE
                    sqlFilter(UBound(sqlFilter)) = "P.ci_cli = " + valor.ToString
                Case FiltroPropiedad.CODIGO_LOCALIDAD
                    sqlFilter(UBound(sqlFilter)) = "P.id_loc = " + valor.ToString
                Case FiltroPropiedad.ESTADO
                    If valor = EstadoDatos.ACTIVO Then
                        sqlFilter(UBound(sqlFilter)) = "P.activo = true"
                    ElseIf valor = EstadoDatos.INACTIVO Then
                        sqlFilter(UBound(sqlFilter)) = "P.activo = false"
                    End If
                Case FiltroPropiedad.HABITACIONES_MAXIMO
                    sqlFilter(UBound(sqlFilter)) = "P.cant_habs <= " + valor.ToString
                Case FiltroPropiedad.HABITACIONES_MINIMO
                    sqlFilter(UBound(sqlFilter)) = "P.cant_habs >= " + valor.ToString
                Case FiltroPropiedad.MTS2_MAXIMO
                    sqlFilter(UBound(sqlFilter)) = "P.mts2 <= " + valor.ToString
                Case FiltroPropiedad.MTS2_MINIMO
                    sqlFilter(UBound(sqlFilter)) = "P.mts2 >= " + valor.ToString
                Case FiltroPropiedad.OPERACION
                    If valor = OperacionPropiedad.ALQUILER Then
                        sqlFilter(UBound(sqlFilter)) = "P.operacion != 'venta'"
                    ElseIf valor = OperacionPropiedad.VENTA Then
                        sqlFilter(UBound(sqlFilter)) = "P.operacion != 'alquiler'"
                    End If
                Case FiltroPropiedad.PRECIO_MAXIMO
                    sqlFilter(UBound(sqlFilter)) = "P.precio <= " + valor.ToString
                Case FiltroPropiedad.PRECIO_MINIMO
                    sqlFilter(UBound(sqlFilter)) = "P.precio >= " + valor.ToString
                Case FiltroPropiedad.TIPO
                    If valor = TipoPropiedad.APARTAMENTO Then
                        sqlFilter(UBound(sqlFilter)) = "P.tipo = 'apartamento'"
                    ElseIf valor = TipoPropiedad.CASA Then
                        sqlFilter(UBound(sqlFilter)) = "P.tipo = 'casa'"
                    ElseIf valor = TipoPropiedad.LOCAL_COMERCIAL Then
                        sqlFilter(UBound(sqlFilter)) = "P.tipo = 'local comercial'"
                    End If
            End Select
        Catch ex As Exception
            ReDim Preserve sqlFilter(UBound(sqlFilter) - 1)
        End Try
        Return Me
    End Function

    Public Function Limite(origen As UInteger, cantidad As UInteger) As SqlPropiedad
        limOrigen = origen
        limCantidad = cantidad
        Return Me
    End Function

    Public Function Imagen(show As Boolean) As SqlPropiedad
        mostrarImagen = show
        Return Me
    End Function

    Public Function Asc() As SqlPropiedad
        orden = " ORDER BY p.cod_prop ASC "
        Return Me
    End Function

    Public Function Desc() As SqlPropiedad
        orden = " ORDER BY p.cod_prop DESC "
        Return Me
    End Function

    Public ReadOnly Property SqlText As String
        Get
            Dim sql = "SELECT "
            If mostrarImagen Then
                sql += "imagen,"
            End If
            sql += "P.cod_prop 'codigo',P.tipo,P.operacion,P.precio,P.cant_habs 'habitaciones',P.mts2,P.direc 'direccion', L.nombre 'localidad', D.nombre 'departamento' FROM propiedad P, departamento D, localidad L WHERE P.id_loc = L.id_loc AND L.id_dep = D.id_dep"

            If sqlFilter.Length > 0 Then
                sql += " AND " + String.Join(" AND ", sqlFilter)
            End If
            Return sql + orden + " LIMIT " + limOrigen.ToString + "," + limCantidad.ToString
        End Get
    End Property
End Class
