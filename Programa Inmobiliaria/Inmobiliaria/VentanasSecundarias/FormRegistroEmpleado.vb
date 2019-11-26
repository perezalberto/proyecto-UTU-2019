Imports System.Text.RegularExpressions

Public Class FormRegistroEmpleado

    Public Property CiEmpleado As Integer = 0
    Public ReadOnly Property Respuesta As Boolean
        Get
            If resp Then
                Return True
                resp = False
            Else
                Return False
            End If
        End Get
    End Property

    Private resp As Boolean = False
    Private dbDatosEmp As DatosEmpleado

    Private cargarlocalidad As Boolean = True

    Private Sub FormRegistroEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim departamentos = Database.GetInstance.Utilidades.Departamentos()
        cbxSucursal.DataSource = Database.GetInstance.Sucursales.Lista().DefaultView
        cbxSucursal.DisplayMember = "nombre"
        cbxSucursal.ValueMember = "cod_suc"
        cbxDepartamento.DataSource = departamentos.DefaultView
        cbxDepartamento.DisplayMember = "nombre"
        cbxDepartamento.ValueMember = "id_dep"

        If CiEmpleado <> 0 Then
            Try
                dbDatosEmp = Database.GetInstance.Usuarios.EmpleadoPorCi(CiEmpleado)

                If dbDatosEmp Is Nothing Then
                    Throw New Exception()
                End If

                Dim IdDep = Database.GetInstance.Utilidades.DepPorCodLocalidad(dbDatosEmp.IdLocalidad).Item(0)

                mtbCi.Text = dbDatosEmp.Ci
                tbxNombre.Text = dbDatosEmp.Nombre
                tbxApellido.Text = dbDatosEmp.Apellido
                cbxDepartamento.SelectedValue = IdDep
                tbxDireccion.Text = dbDatosEmp.Direccion
                lbxListaNumerosTelefono.Items.AddRange(dbDatosEmp.Telefonos)
                cbxSucursal.SelectedValue = dbDatosEmp.CodigoSucursal

                If dbDatosEmp.Rol = RolEmpleado.AGENTE Then
                    cbxRol.SelectedIndex = 0
                ElseIf dbDatosEmp.Rol = RolEmpleado.GERENTE Then
                    cbxRol.SelectedIndex = 1
                End If

                Text = "Modificar Empleado"
                btnAgregarModificar.Text = "Modificar"
            Catch ex As Exception
                MsgBox("Ha ocurrido un error, datos guardados incorrectos. Contacte al administrador de la base de datos para resolver el problema", MsgBoxStyle.Critical)
                Show()
                Close()
            End Try

        End If

    End Sub

    Private Sub cbxDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDepartamento.SelectedIndexChanged
        Try
            cbxLocalidad.DataSource = Database.GetInstance.Utilidades.Localidades(CType(cbxDepartamento.SelectedItem, DataRowView).Item(0)).DefaultView
            cbxLocalidad.DisplayMember = "nombre"
            cbxLocalidad.ValueMember = "id_loc"
            If cargarlocalidad Then
                cbxLocalidad.SelectedValue = dbDatosEmp.IdLocalidad.ToString
                cargarlocalidad = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click
        If Not lbxListaNumerosTelefono.Items.Contains(mtbNumeroTelefono.Text) Then
            If Database.GetInstance.Telefonos.ExisteTelefono(mtbNumeroTelefono.Text) Then
                MsgBox("El telefono ya existe", MsgBoxStyle.Exclamation)
                Return
            End If
            lbxListaNumerosTelefono.Items.Add(mtbNumeroTelefono.Text)
        End If
    End Sub

    Private Sub mtbNumeroTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtbNumeroTelefono.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbNumeroTelefono_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbNumeroTelefono.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        mtbNumeroTelefono.Text = digitsOnly.Replace(mtbNumeroTelefono.Text, "")
    End Sub

    Private Sub btnBorrarTelefono_Click(sender As Object, e As EventArgs) Handles btnBorrarTelefono.Click
        If lbxListaNumerosTelefono.SelectedIndex <> -1 Then
            lbxListaNumerosTelefono.Items.RemoveAt(lbxListaNumerosTelefono.SelectedIndex)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub RegistroEmpleado()
        Dim ctrlVacio = False

        If Not mtbCi.MaskCompleted Then
            ctrlVacio = True
        End If

        If tbxNombre.Text.Equals(String.Empty) Then
            ctrlVacio = True
        End If

        If tbxApellido.Text.Equals(String.Empty) Then
            ctrlVacio = True
        End If

        If tbxPasswd.Text.Equals(String.Empty) Then
            ctrlVacio = True
        End If

        If tbxDireccion.Text.Equals(String.Empty) Then
            ctrlVacio = True
        End If

        If lbxListaNumerosTelefono.Items.Count = 0 Then
            ctrlVacio = True
        End If

        If ctrlVacio Then
            MsgBox("Debe rellenar todos los datos", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim telefonos(lbxListaNumerosTelefono.Items.Count - 1) As String
        lbxListaNumerosTelefono.Items.CopyTo(telefonos, 0)

        Try
            Dim datos As New DmlEmpleado
            Dim tel = Database.GetInstance.Telefonos

            datos.SetData(AtributoPersona.CI, mtbCi.Text.Remove(7, 1))
            datos.SetData(AtributoPersona.NOMBRE, tbxNombre.Text)
            datos.SetData(AtributoPersona.APELLIDO, tbxApellido.Text)
            datos.SetData(AtributoPersona.DIRECCION, tbxDireccion.Text)
            datos.SetData(AtributoPersona.LOCALIDAD, CType(cbxLocalidad.SelectedItem, DataRowView).Item(0).ToString)
            datos.SetData(AtributoEmpleado.COD_SUCURSAL, cbxSucursal.SelectedValue)
            Dim selectedRole As RolEmpleado
            If cbxRol.Text = "Agente" Then
                selectedRole = RolEmpleado.AGENTE
            ElseIf cbxRol.Text = "Gerente" Then
                selectedRole = RolEmpleado.GERENTE
            End If
            datos.SetData(AtributoEmpleado.ROL, selectedRole)
            datos.SetData(AtributoEmpleado.PASSWORD, tbxPasswd.Text)
            datos.SetData(AtributoEmpleado.ESTADO, EstadoDatos.ACTIVO)

            tel.SetNumber(telefonos)

            If Database.GetInstance.Usuarios.Agregar(datos) Then
                resp = True
                If lbxListaNumerosTelefono.Items.Count <> 0 And Not tel.Agregar(mtbCi.Text.Remove(7, 1)) Then
                    MsgBox("Error al guardar el número de telefono", MsgBoxStyle.Information)
                End If
                MsgBox("Usuario creado!", MsgBoxStyle.Information)
                FormPrincipal.mtbCiCliente.Text = mtbCi.Text
                Close()
            End If
        Catch ex As CustomException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message + " - " + ex.StackTrace)
            MsgBox("Usuario no creado: El usuario ya existe o los datos ingesados son invalidos", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub EditarEmpleado()
        Dim dmlData As New DmlEmpleado

        Try
            If mtbCi.MaskCompleted And mtbCi.Text.Remove(7, 1) <> dbDatosEmp.Ci.ToString Then
                dmlData.SetData(AtributoPersona.CI, mtbCi.Text.Remove(7, 1))
            End If

            If tbxNombre.Text <> dbDatosEmp.Nombre Then
                dmlData.SetData(AtributoPersona.NOMBRE, tbxNombre.Text)
            End If

            If tbxApellido.Text <> dbDatosEmp.Apellido Then
                dmlData.SetData(AtributoPersona.APELLIDO, tbxApellido.Text)
            End If

            If tbxDireccion.Text <> dbDatosEmp.Direccion Then
                dmlData.SetData(AtributoPersona.DIRECCION, tbxDireccion.Text)
            End If

            If cbxLocalidad.SelectedValue <> dbDatosEmp.IdLocalidad.ToString Then
                dmlData.SetData(AtributoPersona.LOCALIDAD, cbxLocalidad.SelectedValue)
            End If

            Dim selectedRole As RolEmpleado
            If cbxRol.Text = "Agente" Then
                selectedRole = RolEmpleado.AGENTE
            ElseIf cbxRol.Text = "Gerente" Then
                selectedRole = RolEmpleado.GERENTE
            End If

            If dbDatosEmp.Rol <> selectedRole Then
                dmlData.SetData(AtributoEmpleado.ROL, selectedRole)
            End If

            If dbDatosEmp.CodigoSucursal.ToString <> cbxSucursal.SelectedValue Then
                dmlData.SetData(AtributoEmpleado.COD_SUCURSAL, cbxSucursal.SelectedValue)
            End If

            If tbxPasswd.Text <> "" Then
                dmlData.SetData(AtributoEmpleado.PASSWORD, tbxPasswd.Text)
            End If

            Dim tempTel(lbxListaNumerosTelefono.Items.Count - 1) As String
            lbxListaNumerosTelefono.Items.CopyTo(tempTel, 0)
            Dim telInst = Database.GetInstance.Telefonos
            If Not tempTel.SequenceEqual(dbDatosEmp.Telefonos) Then
                telInst.SetNumber(tempTel)
            End If

            telInst.Remplazar(dbDatosEmp.Ci)
            Database.GetInstance.Usuarios.Modificar(dbDatosEmp.Ci, dmlData)

            resp = True
            MsgBox("Usuario modificado correctamente", MsgBoxStyle.Information)
            Close()
        Catch ex As CustomException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgregarModificar_Click(sender As Object, e As EventArgs) Handles btnAgregarModificar.Click
        If CiEmpleado <> 0 Then
            EditarEmpleado()
        Else
            RegistroEmpleado()
        End If
    End Sub
End Class