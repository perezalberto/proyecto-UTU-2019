Public Class Usuario

    Private datos As DatosPersona

    Private loggedIn = False

    Public Event OnUserCreated(tipo As TipoUsuario, datos As DatosPersona)
    Public Event OnLogin(tipo As TipoUsuario, datos As DatosPersona)
    Public Event OnLoggout()

    ''' <summary>
    ''' Comprueba si el cliente esta registrado y 
    ''' </summary>
    ''' <param name="ci">cedula del cliente</param>
    Public Sub LoginCliente(ci As Integer)
        Dim responce = Database.GetInstance.SQL("SELECT * FROM datos_cliente WHERE ci = " + ci.ToString)
        If responce IsNot Nothing AndAlso responce.Rows.Count > 0 Then
            Try
                datos = New DatosCliente
                CType(datos, DatosCliente).Ci = responce.Rows(0)(0)
                CType(datos, DatosCliente).Nombre = responce.Rows(0)(1)
                CType(datos, DatosCliente).Apellido = responce.Rows(0)(2)
                CType(datos, DatosCliente).Direccion = responce.Rows(0)(3)
                CType(datos, DatosCliente).IdLocalidad = responce.Rows(0)(4)
                CType(datos, DatosCliente).Correo = responce.Rows(0)(5)
                loggedIn = True
                RaiseEvent OnLogin(TipoUsuario.CLIENTE, datos)
            Catch ex As CustomException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Catch ex As Exception
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Comprueba el Usuario y contraseña del empleado
    ''' </summary>
    ''' <param name="ci">cedula del empleado</param>
    ''' <param name="passwd">contraseña del empleado</param>
    Public Sub LoginEmpleado(ci As Integer, passwd As String)
        If Not IsValidPassword(passwd, 1) Then
            loggedIn = False
            Return
        End If
        Dim responce = Database.GetInstance.SQL("SELECT P.*,E.cod_suc,E.rol FROM persona P, empleado E WHERE P.ci = E.ci_emp AND E.activo = true AND E.ci_emp = " + ci.ToString + " AND E.passwd = PASSWORD('" + passwd + "')")
        If responce.Rows.Count > 0 Then
            Try
                datos = New DatosEmpleado
                CType(datos, DatosEmpleado).Ci = responce.Rows(0)(0)
                CType(datos, DatosEmpleado).Nombre = responce.Rows(0)(1)
                CType(datos, DatosEmpleado).Apellido = responce.Rows(0)(2)
                CType(datos, DatosEmpleado).Direccion = responce.Rows(0)(3)
                CType(datos, DatosEmpleado).IdLocalidad = responce.Rows(0)(4)
                CType(datos, DatosEmpleado).CodigoSucursal = responce.Rows(0)(5)
                If responce.Rows(0)(6).ToString = "gerente" Then
                    CType(datos, DatosEmpleado).Rol = RolEmpleado.GERENTE
                Else
                    CType(datos, DatosEmpleado).Rol = RolEmpleado.AGENTE
                End If
                loggedIn = True
                RaiseEvent OnLogin(TipoUsuario.EMPLEADO, datos)
            Catch ex As CustomException
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Catch ex As Exception
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Comprueba si esta logeado
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Function IsLoggedIn()
        Return loggedIn
    End Function

    ''' <summary>
    ''' Obtiene los datos del usuario logeado
    ''' </summary>
    ''' <returns>DatosPersona: Datos de persona</returns>
    Public Function DatosLogeado() As DatosPersona
        Return datos
    End Function

    Public Function ClientePorCi(ci As Integer) As DatosCliente
        If Not loggedIn Or TypeOf datos Is DatosCliente Then
            Return Nothing
        End If
        Dim cliente As New DatosCliente
        Try
            Dim responce = Database.GetInstance.SQL("SELECT P.*,C.correo FROM persona P, cliente C WHERE P.ci = C.ci_cli AND P.ci = " + ci.ToString)
            cliente.Ci = responce.Rows(0)(0)
            cliente.Nombre = responce.Rows(0)(1)
            cliente.Apellido = responce.Rows(0)(2)
            cliente.Direccion = responce.Rows(0)(3)
            cliente.IdLocalidad = responce.Rows(0)(4)
            cliente.Correo = responce.Rows(0)(5)
            cliente.Telefonos = Database.GetInstance.Telefonos.ObtenerNumeros(ci)
        Catch ex As CustomException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try

        Return cliente
    End Function

    Public Function EmpleadoPorCi(ci As Integer) As DatosEmpleado
        If Not loggedIn Or TypeOf datos Is DatosCliente Then
            Return Nothing
        End If
        Dim empleado As New DatosEmpleado
        Try
            Dim responce = Database.GetInstance.SQL("SELECT P.*,E.cod_suc,E.rol FROM persona P, empleado E WHERE P.ci = E.ci_emp AND P.ci = " + ci.ToString)
            empleado.Ci = responce.Rows(0)(0)
            empleado.Nombre = responce.Rows(0)(1)
            empleado.Apellido = responce.Rows(0)(2)
            empleado.Direccion = responce.Rows(0)(3)
            empleado.IdLocalidad = responce.Rows(0)(4)
            empleado.CodigoSucursal = responce.Rows(0)(5)
            If responce.Rows(0)(6).ToString = "gerente" Then
                empleado.Rol = RolEmpleado.GERENTE
            Else
                empleado.Rol = RolEmpleado.AGENTE
            End If
            empleado.Telefonos = Database.GetInstance.Telefonos.ObtenerNumeros(ci)
        Catch ex As CustomException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try

        Return empleado
    End Function

    '<Obsolete("Este metodo es obsoleto, utilizar Modificar(ci, datos) para modificar caracteristicas de usuarios")>
    'Public Function DeshabilitarEmpleado(ci As Integer) As Boolean
    '    Return Database.GetInstance.DML("UPDATE empleado SET activo = false WHERE ci_emp = " + ci.ToString)
    'End Function
    '
    '<Obsolete("Este metodo es obsoleto, utilizar Modificar(ci, datos) para modificar caracteristicas de usuarios")>
    'Public Function HabilitarEmpleado(ci As Integer) As Boolean
    '    Return Database.GetInstance.DML("UPDATE empleado SET activo = true WHERE ci_emp = " + ci.ToString)
    'End Function

    Public Function Lista(filtro As ISqlUsuario) As DataTable
        Try
            Return Database.GetInstance.SQL(filtro.SqlText)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Modificar(ci As Integer, datos As DmlPersona) As Boolean
        Dim res = True

        If Not Database.GetInstance.DML(datos.DmlUpdate(ci)) Then
            res = False
        End If
        If TypeOf datos Is DmlCliente Then
            If Not Database.GetInstance.DML(CType(datos, DmlCliente).DmlUpdate(ci)) Then
                res = False
            End If
        ElseIf TypeOf datos Is DmlEmpleado Then
            If Not Database.GetInstance.DML(CType(datos, DmlEmpleado).DmlUpdate(ci)) Then
                res = False
            End If
        End If
        Return res
    End Function

    Public Function Agregar(datos As DmlPersona) As Boolean
        Dim dmlPersona = datos.DmlInsert
        Dim dmlUsuario = ""

        If dmlPersona = "" Then
            Return False
        End If

        If TypeOf datos Is DmlCliente Then
            dmlUsuario = CType(datos, DmlCliente).DmlInsert
        ElseIf TypeOf datos Is DmlEmpleado Then
            dmlUsuario = CType(datos, DmlEmpleado).DmlInsert
        End If

        If dmlUsuario = "" Then
            Return False
        End If

        If Database.GetInstance.DML(dmlPersona) Then
            If Database.GetInstance.DML(dmlUsuario) Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Sub Logout()
        loggedIn = False
        datos = Nothing
        RaiseEvent OnLoggout()
    End Sub

End Class
