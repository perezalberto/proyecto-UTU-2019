Public Class Localidades
    ''' <summary>
    ''' Retorna todos los depatramentos de la base de datos
    ''' </summary>
    ''' <returns>Datatable de departamentos</returns>
    Public Function Departamentos() As DataTable
        Return Database.GetInstance.SQL("SELECT id_dep,nombre FROM departamento")
    End Function

    ''' <summary>
    ''' Busca la localidades a partir del id del depratamento
    ''' </summary>
    ''' <param name="depId">Id del departamento</param>
    ''' <returns>Datatable con el resultado de la seleccion de las localidades de un departamento</returns>
    Public Function Localidades(depId As Integer) As DataTable
        Return Database.GetInstance.SQL("SELECT id_loc,nombre FROM localidad WHERE id_dep = " + depId.ToString)
    End Function

    ''' <summary>
    ''' Retorna un DataRow en el cual la posicion 0 = id_dep y la 1 = nombre
    ''' </summary>
    ''' <param name="codLoc">codigo de localidad</param>
    ''' <returns></returns>
    Public Function DepPorCodLocalidad(codLoc As Integer) As DataRow
        Return Database.GetInstance.SQL("SELECT D.id_dep,D.nombre FROM departamento D, localidad L WHERE D.id_dep = L.id_dep AND L.id_loc = " + codLoc.ToString).Rows(0)
    End Function

    Public Function NombreLocalidadPorCodigo(cod As Integer) As String
        Try
            Return Database.GetInstance.SQL("SELECT nombre FROM localidad WHERE id_loc = " + cod.ToString).Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function NombreDepartamentoPorCodigo(cod As Integer) As String
        Try
            Return Database.GetInstance.SQL("SELECT nombre FROM departamento WHERE id_dep = " + cod.ToString).Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class
