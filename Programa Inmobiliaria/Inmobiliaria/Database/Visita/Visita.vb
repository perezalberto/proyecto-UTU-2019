Public Class Visita
    Public Function Agendar(ciCli As Integer, idProp As Integer, fhVisita As Date) As Boolean
        If Database.GetInstance.DML("INSERT INTO visita (ci_cli,cod_prop,fh_visita,fh_reserva) VALUES (" + ciCli.ToString + "," + idProp.ToString + ",'" + DateToSql(fhVisita) + "',NOW()) ON DUPLICATE KEY UPDATE ci_emp = NULL,fh_visita = '" + DateToSql(fhVisita) + "',fh_reserva = NOW(),fh_modificada = NULL,fh_cancelada = NULL") Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Asigna un agente a una propiedad
    ''' </summary>
    ''' <param name="ciCli">ci del cliente que realiza una visita a una propiedad</param>
    ''' <param name="idProp">codigo de la propiedad a la que se realiza la visita</param>
    ''' <param name="ciEmp">ci del empleado que se asignará para realizar la visita</param>
    ''' <returns>Retorna true si la operacion se realiza con exito</returns>
    Public Function AsignarAgente(ciCli As Integer, idProp As Integer, ciEmp As Integer) As Boolean
        Return Database.GetInstance.DML("UPDATE visita SET ci_emp = " + ciEmp.ToString + " WHERE ci_cli = " + ciCli.ToString + " AND cod_prop = " + idProp.ToString + " AND ci_emp IS NULL")
    End Function

    Public Function Cancelar(ciCli As Integer, idProp As Integer) As Boolean
        Return Database.GetInstance.DML("UPDATE visita SET fh_cancelada = NOW() WHERE ci_cli = " + ciCli.ToString + " AND cod_prop = " + idProp.ToString)
    End Function

    Public Function Modificar(ciCli As Integer, idProp As Integer, fhVisita As Date) As Boolean
        Return Database.GetInstance.DML("UPDATE visita SET fh_modificada = NOW() ,fh_visita = '" + DateToSql(fhVisita) + "' WHERE ci_cli = " + ciCli.ToString + " AND cod_prop = " + idProp.ToString)
    End Function

    Public Function Lista(filtro As BuscarVisita) As DataTable
        Try
            Return Database.GetInstance.SQL(filtro.SqlText)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ObtenerUno(ciCli As Integer, codProp As Integer) As DatosVisita
        Try
            Dim datos As New DatosVisita
            Dim dRowVisita = Database.GetInstance.SQL("SELECT * FROM visita WHERE ci_cli = " + ciCli.ToString + " AND cod_prop = " + codProp.ToString).Rows(0)
            datos.CiCliente = dRowVisita.Item(0)
            datos.CodPropiedad = dRowVisita.Item(1)
            If Not IsDBNull(dRowVisita.Item(2)) Then
                datos.CiEmpleado = dRowVisita.Item(2)
            End If
            datos.FechaVisita = dRowVisita.Item(3)
            datos.FechaReserva = dRowVisita.Item(4)
            If Not IsDBNull(dRowVisita.Item(5)) Then
                datos.FechaModificada = dRowVisita.Item(5)
            End If
            If Not IsDBNull(dRowVisita.Item(6)) Then
                datos.FechaCancelada = dRowVisita.Item(6)
            End If
            Return datos
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
