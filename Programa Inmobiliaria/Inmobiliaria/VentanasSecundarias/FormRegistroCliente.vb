Imports System.Text.RegularExpressions

Public Class FormRegistroCliente

    Public Property CiCliente As Integer = 0
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
    Private DbCliData As DatosCliente

    Private cargarLocalidad As Boolean = True

    Private Sub formRegistroCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim departamentos = Database.GetInstance.Utilidades.Departamentos()
        cbxDepartamento.DataSource = departamentos.DefaultView
        cbxDepartamento.DisplayMember = "nombre"
        cbxDepartamento.ValueMember = "id_dep"

        If CiCliente <> 0 Then
            Try
                DbCliData = Database.GetInstance.Usuarios.ClientePorCi(CiCliente)

                If DbCliData Is Nothing Then
                    Throw New Exception()
                End If

                Dim IdDep = Database.GetInstance.Utilidades.DepPorCodLocalidad(DbCliData.IdLocalidad).Item(0)

                mtbCi.Text = DbCliData.Ci
                tbxNombre.Text = DbCliData.Nombre
                tbxApellido.Text = DbCliData.Apellido
                tbxCorreo.Text = DbCliData.Correo
                cbxDepartamento.SelectedValue = IdDep
                tbxDireccion.Text = DbCliData.Direccion
                lbxListaNumerosTelefono.Items.AddRange(DbCliData.Telefonos)

                Text = "Modificar cliente"
                btnAgregarModificar.Text = "Modificar"
            Catch ex As Exception
                MsgBox("Ha ocurrido un error, datos guardados incorrectos. Contacte al administrador para resolver el problema", MsgBoxStyle.Critical)
                Show()
                Close()
            End Try
        End If
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
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

    Private Sub cbxDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDepartamento.SelectedIndexChanged
        Try
            Dim localidades = Database.GetInstance.Utilidades.Localidades(CType(cbxDepartamento.SelectedItem, DataRowView).Item(0))
            cbxLocalidad.DataSource = localidades.DefaultView
            cbxLocalidad.DisplayMember = "nombre"
            cbxLocalidad.ValueMember = "id_loc"
            If cargarLocalidad Then
                cbxLocalidad.SelectedValue = DbCliData.IdLocalidad.ToString
                cargarLocalidad = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RegistroCliente()
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

        If tbxCorreo.Text.Equals(String.Empty) Then
            ctrlVacio = True
        End If

        If tbxDireccion.Text.Equals(String.Empty) Then
            ctrlVacio = True
        End If


        If ctrlVacio Then
            MsgBox("Debe rellenar todos los datos", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim telefonos(lbxListaNumerosTelefono.Items.Count - 1) As String
        lbxListaNumerosTelefono.Items.CopyTo(telefonos, 0)

        Try
            Dim datos As New DmlCliente
            Dim tel = Database.GetInstance.Telefonos

            datos.SetData(AtributoPersona.CI, mtbCi.Text.Remove(7, 1))
            datos.SetData(AtributoPersona.NOMBRE, tbxNombre.Text)
            datos.SetData(AtributoPersona.APELLIDO, tbxApellido.Text)
            datos.SetData(AtributoPersona.DIRECCION, tbxDireccion.Text)
            datos.SetData(AtributoPersona.LOCALIDAD, CType(cbxLocalidad.SelectedItem, DataRowView).Item(0).ToString)
            datos.SetData(AtributoCliente.CORREO, tbxCorreo.Text)
            datos.SetData(AtributoCliente.ESTADO, EstadoDatos.ACTIVO)

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
            MsgBox("Usuario no creado: El usuario ya existe o los datos ingesados son invalidos", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub EditarCliente()
        Dim dmlData As New DmlCliente

        Try
            If mtbCi.MaskCompleted And mtbCi.Text.Remove(7, 1) <> DbCliData.Ci.ToString Then
                dmlData.SetData(AtributoPersona.CI, mtbCi.Text.Remove(7, 1))
            End If

            If tbxNombre.Text <> DbCliData.Nombre Then
                dmlData.SetData(AtributoPersona.NOMBRE, tbxNombre.Text)
            End If

            If tbxApellido.Text <> DbCliData.Apellido Then
                dmlData.SetData(AtributoPersona.APELLIDO, tbxApellido.Text)
            End If

            If tbxDireccion.Text <> DbCliData.Direccion Then
                dmlData.SetData(AtributoPersona.DIRECCION, tbxDireccion.Text)
            End If

            If cbxLocalidad.SelectedValue <> DbCliData.IdLocalidad.ToString Then
                dmlData.SetData(AtributoPersona.LOCALIDAD, cbxLocalidad.SelectedValue)
            End If

            If tbxCorreo.Text <> DbCliData.Correo Then
                dmlData.SetData(AtributoCliente.CORREO, tbxCorreo.Text)
            End If

            Dim tempTel(lbxListaNumerosTelefono.Items.Count - 1) As String
            lbxListaNumerosTelefono.Items.CopyTo(tempTel, 0)
            Dim telInst = Database.GetInstance.Telefonos
            If Not tempTel.SequenceEqual(DbCliData.Telefonos) Then
                telInst.SetNumber(tempTel)
            End If

            telInst.Remplazar(DbCliData.Ci)
            If Database.GetInstance.Usuarios.Modificar(DbCliData.Ci, dmlData) Then
                resp = True
                MsgBox("Usuario modificado correctamente", MsgBoxStyle.Information)
                Close()
            Else
                MsgBox("No se ha podido modificar", MsgBoxStyle.Exclamation)
            End If
        Catch ex As CustomException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgregarModificar_Click(sender As Object, e As EventArgs) Handles btnAgregarModificar.Click
        If CiCliente <> 0 Then
            EditarCliente()
        Else
            RegistroCliente()
        End If
    End Sub
End Class