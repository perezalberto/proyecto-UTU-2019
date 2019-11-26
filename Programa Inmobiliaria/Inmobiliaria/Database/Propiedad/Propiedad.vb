Imports MySql.Data.MySqlClient

Public Class Propiedad

    ''' <summary>
    ''' Busca la(s) propiedad(es) a la venta y/o alquiler de un cliente
    ''' </summary>
    ''' <param name="ci">cedula del vendedor de la(s) propiedad(es) a buscar</param>
    ''' <returns>DataTable - lista de propiedades</returns>
    Public Function BuscarPorCI(ci As Integer) As DataTable
        Return Database.GetInstance.SQL("SELECT * FROM propiedad WHERE ci_ven = " + Str(ci))
    End Function

    ''' <summary>
    ''' Busca una propiedad por su codigo de propiedad
    ''' </summary>
    ''' <param name="cod">codigo de propiedad</param>
    ''' <returns>DataRow - Una propiedad</returns>
    Public Function BuscarPorCodigo(cod As Integer) As DatosPropiedad
        Try
            Dim datos As New DatosPropiedad
            Dim result = Database.GetInstance.SQL("SELECT * FROM propiedad WHERE cod_prop = " + cod.ToString).Rows(0)
            datos.CiCliente = result(1)
            If result(2).ToString = "casa" Then
                datos.Tipo = TipoPropiedad.CASA
            ElseIf result(2).ToString = "apartamento" Then
                datos.Tipo = TipoPropiedad.APARTAMENTO
            ElseIf result(2).ToString = "local comercial" Then
                datos.Tipo = TipoPropiedad.LOCAL_COMERCIAL
            End If
            If result(3).ToString = "alquiler" Then
                datos.Operacion = OperacionPropiedad.ALQUILER
            ElseIf result(3).ToString = "venta" Then
                datos.Operacion = OperacionPropiedad.VENTA
            End If
            datos.Precio = result(4)
            datos.Habitaciones = result(5)
            datos.Mts2 = result(6)
            datos.Direccion = result(7)
            datos.Localidad = result(8)
            If result(10).ToString = "1" Then
                datos.Estado = EstadoDatos.ACTIVO
            ElseIf result(10).ToString = "0" Then
                datos.Estado = EstadoDatos.INACTIVO
            End If
            datos.Imagen = ByteArrayToImage(result(9))
            Return datos
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Lista y Busca propiedades en la base de datos
    ''' </summary>
    ''' <param name="datos">Utilizado para realizar filtros en las propiedades</param>
    ''' <returns>Datatable - Selección de propiedades</returns>
    Public Function Lista(ByRef datos As SqlPropiedad) As DataTable
        Return Database.GetInstance.SQL(datos.SqlText)
    End Function

    ''' <summary>
    ''' Obtiene la imagen de una propiedad a través de su código de propiedad
    ''' </summary>
    ''' <param name="cod">código de propiedad</param>
    ''' <returns>Image - Retorna la imagen de la propiedad</returns>
    Public Function BuscarImagen(cod As Integer) As Image
        Dim arrimage As Byte()
        arrimage = Database.GetInstance.SQL("SELECT imagen FROM propiedad WHERE cod_prop = " + Str(cod)).Rows(0).Item(0)
        Return ByteArrayToImage(arrimage)
    End Function

    Public Sub Agregar(datos As DmlPropiedad)
        Database.GetInstance.DML(datos.DmlInsert)
    End Sub

    Public Sub Editar(id As Integer, datos As DmlPropiedad)
        Database.GetInstance.DML(datos.DmlUpdate(id))
    End Sub

    Public Sub Eliminar(id As Integer)
        Database.GetInstance.DML((New DmlPropiedad).SetData(AtributoPropiedad.ESTADO, EstadoDatos.INACTIVO).DmlUpdate(id))
    End Sub
End Class

