Public Class Sucursal
    Public Function BuscarPorCodigo(cod As Integer) As DataRow
        Return Database.GetInstance.SQL("SELECT * FROM sucursal WHERE cod_suc = " + cod.ToString).Rows(0)
    End Function

    Public Function AgregarSucursal(nom As String, direc As String, idLoc As Integer) As Boolean
        Return Database.GetInstance.DML("INSERT INTO sucursal VALUE (NULL,'" + nom + "','" + direc + "'," + idLoc.ToString + ",1)")
    End Function

    Public Function ModificarSucursal(codSuc As Integer, Optional nom As String = "", Optional direc As String = "", Optional idLoc As Integer = -1) As Boolean
        Dim dmlStr = ""

        If nom <> "" Then
            dmlStr += "nombre = " + nom + ","
        End If
        If direc <> "" Then
            dmlStr += "direc = " + direc + ","
        End If
        If idLoc <> "" Then
            dmlStr += "id_loc = " + idLoc + ","
        End If

        dmlStr = dmlStr.Remove(dmlStr.Length - 1)

        Return Database.GetInstance.DML("UPDATE TABLE sucursal SET " + dmlStr + " WHERE cod_suc = " + codSuc)
    End Function

    Public Function habilitarSucursal(codSuc As Integer) As Boolean
        Return Database.GetInstance.DML("UPDATE TABLE sucursal SET activo = true WHERE cod_suc = " + codSuc)
    End Function

    Public Function DeshabilitarSucursal(codSuc As Integer) As Boolean
        Return Database.GetInstance.DML("UPDATE TABLE sucursal SET activo = false WHERE cod_suc = " + codSuc)
    End Function

    Public Function Lista() As DataTable
        Return Database.GetInstance.SQL("SELECT * FROM sucursal")
    End Function

    Public Function ListaExtendida() As DataTable
        Return Database.GetInstance.SQL("SELECT S.cod_suc 'codigo',S.nombre,S.direc 'direccion',D.nombre 'departamento',L.nombre 'localidad' FROM sucursal S, departamento D, localidad L WHERE D.id_dep = L.id_dep AND S.id_loc = L.id_loc")
    End Function
End Class
