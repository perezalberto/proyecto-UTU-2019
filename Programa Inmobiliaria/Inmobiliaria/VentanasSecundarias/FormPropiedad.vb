Public Class FormPropiedad

    Public Property IdPropiedad As Integer = -1
    Public Property Actividad As String

    Private datosPropiedad As DatosPropiedad
    Private datosUsuario As DatosCliente
    Private imageChanged As Boolean = False

    Private Sub FormPropiedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxImagen.Image = Nothing
        cbxDepartamento.DataSource = Database.GetInstance.Utilidades.Departamentos().DefaultView
        cbxDepartamento.DisplayMember = "nombre"
        cbxDepartamento.ValueMember = "id_dep"

        If Actividad = "editar" Then
            Text = "Editar propiedad"
            btnAceptar.Text = "Editar"
            If IdPropiedad <> -1 Then
                CargarPropiedad(IdPropiedad)
            End If

        ElseIf Actividad = "agregar" Then
            Text = "Agregar propiedad"
            btnAceptar.Text = "Agregar"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub CargarPropiedad(codigo As Integer)
        Try
            datosPropiedad = Database.GetInstance.Propiedades.BuscarPorCodigo(codigo)

            mtbCi.Text = datosPropiedad.CiCliente
            tbxDireccion.Text = datosPropiedad.Direccion
            cbxDepartamento.SelectedValue = Database.GetInstance.Utilidades.DepPorCodLocalidad(datosPropiedad.Localidad)(0)
            cbxLocalidad.SelectedValue = datosPropiedad.Localidad

            If datosPropiedad.Operacion = OperacionPropiedad.ALQUILER Then
                cbxOperacion.SelectedIndex = 0
            ElseIf datosPropiedad.Operacion = OperacionPropiedad.VENTA Then
                cbxOperacion.SelectedIndex = 1
            Else
                cbxOperacion.SelectedIndex = 2
            End If

            If datosPropiedad.Tipo = TipoPropiedad.CASA Then
                cbxTipo.SelectedIndex = 0
            ElseIf datosPropiedad.Tipo = TipoPropiedad.APARTAMENTO Then
                cbxTipo.SelectedIndex = 1
            ElseIf datosPropiedad.Tipo = TipoPropiedad.LOCAL_COMERCIAL Then
                cbxTipo.SelectedIndex = 2
            End If

            nudMts2.Value = datosPropiedad.Mts2
            nudNumHabs.Value = datosPropiedad.Habitaciones
            nudPrecio.Value = datosPropiedad.Precio
            pbxImagen.Image = datosPropiedad.Imagen
        Catch ex As Exception
        End Try

    End Sub

    Private Sub cbxDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDepartamento.SelectedIndexChanged
        cbxLocalidad.DataSource = Database.GetInstance.Utilidades.Localidades(CType(cbxDepartamento.SelectedItem, DataRowView).Item(0)).DefaultView
        cbxLocalidad.DisplayMember = "nombre"
        cbxLocalidad.ValueMember = "id_loc"
    End Sub

    Private Function EditarPropiedad() As Boolean
        Dim dmlCons As New DmlPropiedad
        If mtbCi.MaskCompleted And mtbCi.Text.Remove(7, 1) <> datosPropiedad.CiCliente Then
            dmlCons.SetData(AtributoPropiedad.CI_CLIENTE, mtbCi.Text.Remove(7, 1))
        End If

        If tbxDireccion.Text <> datosPropiedad.Direccion Then
            dmlCons.SetData(AtributoPropiedad.DIRECCION, tbxDireccion.Text)
        End If

        If CInt(cbxLocalidad.SelectedValue) <> datosPropiedad.Localidad Then
            dmlCons.SetData(AtributoPropiedad.CODIGO_LOCALIDAD, cbxLocalidad.SelectedValue)
        End If

        Dim num = OperacionPropiedad.NULL
        If cbxOperacion.Text = "Alquiler" Then
            num = OperacionPropiedad.ALQUILER
        ElseIf cbxOperacion.Text = "Venta" Then
            num = OperacionPropiedad.VENTA
        End If
        If num <> datosPropiedad.Operacion Then
            dmlCons.SetData(AtributoPropiedad.OPERACION, num)
        End If

        num = TipoPropiedad.NULL
        If cbxTipo.Text = "Casa" Then
            num = TipoPropiedad.CASA
        ElseIf cbxTipo.Text = "Apartamento" Then
            num = TipoPropiedad.APARTAMENTO
        ElseIf cbxTipo.Text = "Local Comercial" Then
            num = TipoPropiedad.LOCAL_COMERCIAL
        End If
        If num <> datosPropiedad.Tipo Then
            dmlCons.SetData(AtributoPropiedad.TIPO, num)
        End If

        If nudPrecio.Value <> datosPropiedad.Precio Then
            dmlCons.SetData(AtributoPropiedad.PRECIO, nudPrecio.Value.ToString)
        End If

        If nudNumHabs.Value <> datosPropiedad.Habitaciones Then
            dmlCons.SetData(AtributoPropiedad.HABITACIONES, nudNumHabs.Value.ToString)
        End If

        If nudMts2.Value <> datosPropiedad.Mts2 Then
            dmlCons.SetData(AtributoPropiedad.MTS2, nudMts2.Value.ToString)
        End If

        If imageChanged Then
            dmlCons.SetData(AtributoPropiedad.IMAGEN, pbxImagen.Image)
        End If

        If dmlCons.IsSet And IdPropiedad <> -1 Then
            If Database.GetInstance.DML(dmlCons.DmlUpdate(IdPropiedad)) Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Function AgregarPropiedad() As Boolean
        Dim dmlCons As New DmlPropiedad
        Dim isAllSet = True

        If mtbCi.MaskCompleted Then
            dmlCons.SetData(AtributoPropiedad.CI_CLIENTE, mtbCi.Text.Remove(7, 1))
        End If

        If tbxDireccion.Text <> "" Then
            dmlCons.SetData(AtributoPropiedad.DIRECCION, tbxDireccion.Text)
        End If

        dmlCons.SetData(AtributoPropiedad.CODIGO_LOCALIDAD, cbxLocalidad.SelectedValue)

        If cbxOperacion.SelectedIndex <> -1 Then
            If cbxOperacion.Text = "Alquiler" Then
                dmlCons.SetData(AtributoPropiedad.OPERACION, OperacionPropiedad.ALQUILER)
            ElseIf cbxOperacion.Text = "Venta" Then
                dmlCons.SetData(AtributoPropiedad.OPERACION, OperacionPropiedad.VENTA)
            Else
                dmlCons.SetData(AtributoPropiedad.OPERACION, OperacionPropiedad.NULL)
            End If
        End If

        If cbxTipo.SelectedIndex <> -1 Then
            If cbxTipo.Text = "Casa" Then
                dmlCons.SetData(AtributoPropiedad.TIPO, TipoPropiedad.CASA)
            ElseIf cbxTipo.Text = "Apartamento" Then
                dmlCons.SetData(AtributoPropiedad.TIPO, TipoPropiedad.APARTAMENTO)
            ElseIf cbxTipo.Text = "Local Comercial" Then
                dmlCons.SetData(AtributoPropiedad.TIPO, TipoPropiedad.LOCAL_COMERCIAL)
            End If
        End If

        If nudPrecio.Value <> 0 Then
            dmlCons.SetData(AtributoPropiedad.PRECIO, nudPrecio.Value.ToString)
        End If

        dmlCons.SetData(AtributoPropiedad.HABITACIONES, nudNumHabs.Value.ToString)

        If nudMts2.Value <> 0 Then
            dmlCons.SetData(AtributoPropiedad.MTS2, nudMts2.Value.ToString)
        End If

        If imageChanged Then
            dmlCons.SetData(AtributoPropiedad.IMAGEN, pbxImagen.Image)
        End If

        dmlCons.SetData(AtributoPropiedad.ESTADO, EstadoDatos.ACTIVO)

        If dmlCons.IsAllSet Then
            If Database.GetInstance.DML(dmlCons.DmlInsert) Then
                Return True
            End If
        End If
        Return False

    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If Actividad = "editar" Then
                If MsgBox("Esta seguro de modificar la propiedad", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
                    Return
                End If
                If Not EditarPropiedad() Then
                    MsgBox("No se han realizado cambios, debe modificar al menos un dato", MsgBoxStyle.Exclamation)
                    Return
                End If
            ElseIf Actividad = "agregar" Then
                If Not AgregarPropiedad() Then
                    MsgBox("No se ha agregado la propiedad, todos los datos deben ser ingresados", MsgBoxStyle.Exclamation)
                    Return
                End If
            End If
            Close()
        Catch ex As Exception
            MsgBox(ex.StackTrace)
        End Try
    End Sub

    Private Sub btnBuscarImagenes_Click(sender As Object, e As EventArgs) Handles btnBuscarImagenes.Click
        Try
            Dim byteFileData = LoadImageFile(OfdArchivos)
            If byteFileData IsNot Nothing Then
                pbxImagen.Image = ByteArrayToImage(byteFileData)
                imageChanged = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mtbCi_TextChanged(sender As Object, e As EventArgs) Handles mtbCi.TextChanged
        If mtbCi.MaskCompleted Then
            Try
                datosUsuario = Database.GetInstance.Usuarios.ClientePorCi(mtbCi.Text.Remove(7, 1))
                tbxNombre.Text = datosUsuario.Nombre
                tbxApellido.Text = datosUsuario.Apellido
            Catch ex As Exception
                tbxNombre.Text = "Usuario no registrado"
                tbxApellido.Text = ""
            End Try
        Else
            tbxNombre.Text = ""
            tbxApellido.Text = ""
        End If
    End Sub

End Class