Public Class BuscarVisita
    Private sqlFilter(-1) As String
    Private limOrigen As UInteger
    Private limCantidad As UInteger
    Private orden As String

    Public Sub New()
        limCantidad = 100
        limOrigen = 0
    End Sub

    Public Function Filtro(tipo As FiltroVisita, valor As Object) As BuscarVisita
        ReDim Preserve sqlFilter(UBound(sqlFilter) + 1)
        Try
            Select Case tipo
                Case FiltroVisita.CI_CLIENTE
                    sqlFilter(UBound(sqlFilter)) = "ci_cli = " + valor.ToString

                Case FiltroVisita.CI_EMPLEADO
                    sqlFilter(UBound(sqlFilter)) = "ci_emp = " + valor.ToString

                Case FiltroVisita.CODIGO_PROPIEDAD
                    sqlFilter(UBound(sqlFilter)) = "cod_prop = " + valor.ToString

                Case FiltroVisita.FECHA_MAXIMA_RESERVA
                    sqlFilter(UBound(sqlFilter)) = "fh_reserva <= '" + DateToSql(valor) + "'"

                Case FiltroVisita.FECHA_MAXIMA_VISITA
                    sqlFilter(UBound(sqlFilter)) = "fh_visita <= '" + DateToSql(valor) + "'"

                Case FiltroVisita.FECHA_MINIMA_RESERVA
                    sqlFilter(UBound(sqlFilter)) = "fh_reserva >= '" + DateToSql(valor) + "'"

                Case FiltroVisita.FECHA_MINIMA_VISITA
                    sqlFilter(UBound(sqlFilter)) = "fh_visita >= '" + DateToSql(valor) + "'"
                Case FiltroVisita.ESTADO_VISITA
                    If valor = EstadoVisita.CANCELADAS Then
                        sqlFilter(UBound(sqlFilter)) = "fh_cancelada IS NOT NULL"
                    ElseIf valor = EstadoVisita.MODIFICADAS Then
                        sqlFilter(UBound(sqlFilter)) = "fh_modificada IS NOT NULL"
                    ElseIf valor = EstadoVisita.ACTIVAS Then
                        sqlFilter(UBound(sqlFilter)) = "fh_cancelada IS NULL AND fh_visita >= NOW()"
                    End If
            End Select
        Catch ex As Exception
            ReDim Preserve sqlFilter(UBound(sqlFilter) - 1)
        End Try
        Return Me
    End Function

    Public Function Limite(origen As UInteger, cantidad As UInteger) As BuscarVisita
        limOrigen = origen
        limCantidad = cantidad
        Return Me
    End Function

    Public Function Asc() As BuscarVisita
        orden = " ORDER BY fh_visita ASC "
        Return Me
    End Function

    Public Function Desc() As BuscarVisita
        orden = " ORDER BY fh_visita DESC "
        Return Me
    End Function

    Public ReadOnly Property SqlText As String
        Get
            Dim sql = "SELECT ci_cli 'CI cliente', cod_prop 'Codigo propiedad', ci_emp 'CI empleado', fh_visita 'Fecha visita', fh_reserva 'Fecha reserva' FROM visita"
            If sqlFilter.Length <> 0 Then
                sql += " WHERE " + String.Join(" AND ", sqlFilter)
            End If

            Return sql + orden + " LIMIT " + limOrigen.ToString + "," + limCantidad.ToString
        End Get
    End Property

End Class
