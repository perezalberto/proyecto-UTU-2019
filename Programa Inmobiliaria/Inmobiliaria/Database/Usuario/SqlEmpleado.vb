Public Class SqlEmpleado
    Implements ISqlUsuario

    Private sqlFilter(-1) As String
    Private orderBy As String
    Private groupBy As String
    Private limit As String
    Private DatosVisitas As Boolean = False
    Private DatosVisitasPorFecha As Boolean = False

    ''' <summary>
    ''' Filtros de busqueda para empleados
    ''' </summary>
    ''' <param name="tipo"></param>
    ''' <param name="dato"></param>
    ''' <returns></returns>
    Public Function Filtro(tipo As FiltroEmpleado, dato As Object) As SqlEmpleado
        ReDim Preserve sqlFilter(UBound(sqlFilter) + 1)
        Try
            Select Case tipo
                Case FiltroEmpleado.CI
                    sqlFilter(UBound(sqlFilter)) = "P.ci = " + dato.ToString
                Case FiltroEmpleado.ID_SUCURSAL
                    sqlFilter(UBound(sqlFilter)) = "E.cod_suc = " + dato.ToString
                Case FiltroEmpleado.ROL
                    If dato = RolEmpleado.AGENTE Then
                        sqlFilter(UBound(sqlFilter)) = "E.rol = 'agente'"
                    ElseIf dato = RolEmpleado.GERENTE Then
                        sqlFilter(UBound(sqlFilter)) = "E.rol = 'gerente'"
                    End If
                Case FiltroEmpleado.ESTADO
                    If dato = EstadoDatos.ACTIVO Then
                        sqlFilter(UBound(sqlFilter)) = "E.activo = true"
                    ElseIf dato = EstadoDatos.INACTIVO Then
                        sqlFilter(UBound(sqlFilter)) = "E.activo = false"
                    End If
            End Select
        Catch ex As Exception
            ReDim Preserve sqlFilter(UBound(sqlFilter) - 1)
        End Try
        Return Me
    End Function

    ''' <summary>
    ''' Resultados en orden descendente segun el numero de visitas
    ''' </summary>
    ''' <returns></returns>
    Public Function Desc() As SqlEmpleado
        If Not DatosVisitas Then Return Me
        orderBy = " ORDER BY visitas DESC"
        Return Me
    End Function

    ''' <summary>
    ''' Resultados en orden ascendente segun el numero de visitas
    ''' </summary>
    ''' <returns></returns>
    Public Function Asc() As SqlEmpleado
        If Not DatosVisitas Then Return Me
        orderBy = " ORDER BY visitas ASC"
        Return Me
    End Function

    ''' <summary>
    ''' Limita la cantidad y el punto de inicio de los datos a obtener
    ''' </summary>
    ''' <param name="desde"></param>
    ''' <param name="cantidad"></param>
    ''' <returns></returns>
    Public Function Limite(desde As Integer, cantidad As Integer) As SqlEmpleado
        limit = " LIMIT " + desde.ToString + "," + cantidad.ToString
        Return Me
    End Function

    ''' <summary>
    ''' Muestra la cantidad total de visitas
    ''' </summary>
    ''' <returns></returns>
    Public Function MostrarVisitas() As SqlEmpleado
        DatosVisitas = True
        groupBy = " GROUP BY E.ci_emp"
        Return Me
    End Function

    ''' <summary>
    ''' Muestra todas las visitas de un dia en especifico
    ''' </summary>
    ''' <param name="fecha">Fecha</param>
    ''' <returns></returns>
    Public Function MostrarVisitas(fecha As Date) As SqlEmpleado
        MostrarVisitas()
        DatosVisitasPorFecha = True
        ReDim Preserve sqlFilter(UBound(sqlFilter) + 1)
        sqlFilter(UBound(sqlFilter)) = "V.ci_emp = E.ci_emp AND V.fh_visita >= DATE_FORMAT(" + DateToSql(fecha) + ", '%Y-%m-%d') AND V.fh_visita < DATE_ADD(DATE_FORMAT(" + DateToSql(fecha) + ", '%Y-%m-%d'), INTERVAL 1 DAY)"
        Return Me
    End Function

    ''' <summary>
    ''' Retorna uns string con la consulta de busqueda
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SqlText As String Implements ISqlUsuario.SqlText
        Get
            Dim sqlStr = "SELECT P.ci,P.nombre,P.apellido,S.nombre 'sucursal'"
            If DatosVisitas Then
                sqlStr += ",(SELECT COUNT(V2.ci_emp) FROM visita V2 WHERE V2.ci_emp = E.ci_emp AND V2.fh_cancelada = NULL) 'visitas',E.activo FROM empleado E, persona P,"
                If DatosVisitasPorFecha Then
                    sqlStr += " visita V,"
                End If
                sqlStr += " sucursal S WHERE E.ci_emp = P.ci AND S.cod_suc = E.cod_suc"
            Else
                sqlStr += ",E.activo FROM empleado E, persona P, sucursal S WHERE E.ci_emp = P.ci AND S.cod_suc = E.cod_suc"
            End If
            If sqlFilter.Length <> 0 Then
                sqlStr += " AND " + String.Join(" AND ", sqlFilter)
            End If
            sqlStr += groupBy
            sqlStr += orderBy
            sqlStr += limit
            Return sqlStr
        End Get
    End Property
End Class
