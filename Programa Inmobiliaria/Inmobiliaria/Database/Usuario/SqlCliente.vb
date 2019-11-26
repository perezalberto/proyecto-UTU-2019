Imports Inmobiliaria

Public Class SqlCliente
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
    Public Function Filtro(tipo As FiltroCliente, dato As Object) As SqlCliente
        ReDim Preserve sqlFilter(UBound(sqlFilter) + 1)
        Try
            Select Case tipo
                Case FiltroCliente.CI
                    sqlFilter(UBound(sqlFilter)) = "P.ci = " + dato.ToString
                Case FiltroCliente.CORREO
                    sqlFilter(UBound(sqlFilter)) = "C.correo = '" + dato.ToString + "'"
                Case FiltroCliente.ESTADO
                    If dato = EstadoDatos.ACTIVO Then
                        sqlFilter(UBound(sqlFilter)) = "C.activo = true"
                    ElseIf dato = EstadoDatos.INACTIVO Then
                        sqlFilter(UBound(sqlFilter)) = "C.activo = false"
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
    Public Function Desc() As SqlCliente
        If Not DatosVisitas Then Return Me
        orderBy = " ORDER BY visitas DESC"
        Return Me
    End Function

    ''' <summary>
    ''' Resultados en orden ascendente segun el numero de visitas
    ''' </summary>
    ''' <returns></returns>
    Public Function Asc() As SqlCliente
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
    Public Function Limite(desde As Integer, cantidad As Integer) As SqlCliente
        limit = " LIMIT " + desde.ToString + "," + cantidad.ToString
        Return Me
    End Function

    ''' <summary>
    ''' Muestra la cantidad total de visitas
    ''' </summary>
    ''' <returns></returns>
    Public Function MostrarVisitas() As SqlCliente
        DatosVisitas = True
        groupBy = " GROUP BY C.ci_cli"
        Return Me
    End Function

    ''' <summary>
    ''' Muestra todas las visitas de un dia en especifico
    ''' </summary>
    ''' <param name="fecha">Fecha</param>
    ''' <returns></returns>
    Public Function MostrarVisitas(fecha As Date) As SqlCliente
        MostrarVisitas()
        DatosVisitasPorFecha = True
        ReDim Preserve sqlFilter(UBound(sqlFilter) + 1)
        sqlFilter(UBound(sqlFilter)) = "V.ci_cli = C.ci_cli AND V.fh_visita >= DATE_FORMAT(" + DateToSql(fecha) + ", '%Y-%m-%d') AND V.fh_visita < DATE_ADD(DATE_FORMAT(" + DateToSql(fecha) + ", '%Y-%m-%d'), INTERVAL 1 DAY)"
        Return Me
    End Function

    ''' <summary>
    ''' Retorna uns string con la consulta de busqueda
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SqlText As String Implements ISqlUsuario.SqlText
        Get
            Dim sqlStr = "SELECT P.ci,P.nombre,P.apellido,C.correo"
            If DatosVisitas Then
                sqlStr += ",(SELECT COUNT(V2.ci_cli) FROM visita V2 WHERE V2.ci_cli = C.ci_cli AND V2.fh_cancelada = NULL) 'visitas',C.activo FROM cliente C, persona P"
                If DatosVisitasPorFecha Then
                    sqlStr += ", visita V"
                End If
                sqlStr += " WHERE C.ci_cli = P.ci"
            Else
                sqlStr += ",C.activo FROM cliente C, persona P WHERE C.ci_cli = P.ci"
            End If
            Dim condExtr = String.Join(" AND ", sqlFilter)
            If condExtr <> "" Then
                sqlStr += " AND " + condExtr
            End If
            sqlStr += groupBy
            sqlStr += orderBy
            sqlStr += limit
            Return sqlStr
        End Get
    End Property
End Class
