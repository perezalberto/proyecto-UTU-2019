Public Class FormEmpleado

    Public Property UsuarioLogueado As DatosEmpleado

    Private limit = 500
    Private isLoadedPropiededes = False
    Private isLoadedAgenda = False
    Private isLoadedVisitasAsignadas = False
    Private isLoadedVisitasCanceladas = False
    Private isLoadedVisitasModificadas = False
    Private isLoadedEmpleados = False
    Private isLoadedClientes = False

    Private Sub LoadPropiedades(Optional reload As Boolean = False)
        If isLoadedPropiededes And Not reload Then
            Return
        End If

        cbxPropiedadDepart.DataSource = Database.GetInstance.Utilidades.Departamentos().DefaultView
        cbxPropiedadDepart.DisplayMember = "nombre"

        cbxPropiedadTipo.SelectedItem = "Casa"
        cbxPropiedadOperac.SelectedItem = "Alquiler"

        dgvPropiedades.DataSource = Database.GetInstance.Propiedades.Lista((New SqlPropiedad).Filtro(FiltroPropiedad.ESTADO, EstadoDatos.ACTIVO).Desc().Limite(0, limit))
        isLoadedPropiededes = True
    End Sub

    Private Sub LoadAgenda(Optional reload As Boolean = False)
        If isLoadedAgenda And Not reload Then
            Return
        End If
        DgvAgenda.DataSource = Database.GetInstance.Visitas.Lista((New BuscarVisita).Filtro(FiltroVisita.ESTADO_VISITA, EstadoVisita.ACTIVAS).Desc().Limite(0, limit))
        isLoadedAgenda = True
    End Sub

    Private Sub LoadVisitasAsignadas(Optional reload As Boolean = False)
        If isLoadedVisitasAsignadas And Not reload Then
            Return
        End If
        Dim result = Database.GetInstance.Visitas.Lista((New BuscarVisita).Filtro(FiltroVisita.ESTADO_VISITA, EstadoVisita.ACTIVAS).Filtro(FiltroVisita.CI_EMPLEADO, UsuarioLogueado.Ci).Desc().Limite(0, limit))
        result.Columns.RemoveAt(2)
        DgvVisitasAsignadas.DataSource = result
        isLoadedVisitasAsignadas = True
    End Sub

    Private Sub LoadVisitasCanceladas(Optional reload As Boolean = False)
        If isLoadedVisitasCanceladas And Not reload Then
            Return
        End If
        dgvCanceladas.DataSource = Database.GetInstance.Visitas.Lista((New BuscarVisita).Filtro(FiltroVisita.ESTADO_VISITA, EstadoVisita.CANCELADAS).Desc().Limite(0, limit))
        isLoadedVisitasCanceladas = True
    End Sub

    Private Sub LoadVisitasModificadas(Optional reload As Boolean = False)
        If isLoadedVisitasModificadas And Not reload Then
            Return
        End If
        dgvModificadas.DataSource = Database.GetInstance.Visitas.Lista((New BuscarVisita).Filtro(FiltroVisita.ESTADO_VISITA, EstadoVisita.MODIFICADAS).Desc().Limite(0, limit))
        isLoadedVisitasModificadas = True
    End Sub

    Private Sub LoadEmpleados(Optional reload As Boolean = False)
        If isLoadedEmpleados And Not reload Then
            Return
        End If

        cbxEmpleadosSucursal.DataSource = Database.GetInstance.Sucursales.Lista().DefaultView
        cbxEmpleadosSucursal.DisplayMember = "nombre"

        Dim SqlEmp As New SqlEmpleado

        If Not chbEmpleadosMostrarDeshabilitados.Checked Then
            SqlEmp.Filtro(FiltroEmpleado.ESTADO, EstadoDatos.ACTIVO)
        End If

        SqlEmp.MostrarVisitas().Desc().Limite(0, limit)

        dgvEmpleados.DataSource = Database.GetInstance.Usuarios.Lista(SqlEmp)
        isLoadedEmpleados = True
    End Sub

    Private Sub LoadClientes(Optional reload As Boolean = False)
        If isLoadedClientes And Not reload Then
            Return
        End If
        Dim sqlCli As New SqlCliente
        If Not chbClientesMostrarDeshabilitados.Checked Then
            sqlCli.Filtro(FiltroCliente.ESTADO, EstadoDatos.ACTIVO)
        End If
        sqlCli.MostrarVisitas()
        sqlCli.Desc().Limite(0, limit)
        dgvClientes.DataSource = Database.GetInstance.Usuarios.Lista(sqlCli)
        isLoadedClientes = True
    End Sub

    Private Sub FormEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rol As RolEmpleado
        Try
            rol = CType(Database.GetInstance.Usuarios.DatosLogeado(), DatosEmpleado).Rol
        Catch ex As Exception
        End Try
        If rol = RolEmpleado.AGENTE Then
            tlpVisitasCanceladas.Visible = False
            tlpVisitasModificadas.Visible = False
            tlpEmpleados.Visible = False
            lmbVisitasCanceladas.Visible = False
            lmbVisitasModificadas.Visible = False
            lmbEmpleados.Visible = False
            btnClientesAgregarAEmpleado.Visible = False
            lvlTopBarText.Text = "Agente"
        Else
            TlpVisitasAsignadas.Visible = False
            btnAgendaAceptarVisita.Visible = False
            LmbVisitasAsignadas.Visible = False
            lvlTopBarText.Text = "Gerente"
        End If

        LoadPropiedades()
    End Sub

    Private Sub FormularioEmpleado_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Database.ClearInstance()
        UsuarioLogueado = Nothing
        FormPrincipal.Show()
    End Sub

    Private Sub lmbPropiedades_Click(sender As Object, e As EventArgs) Handles lmbPropiedades.Click
        LoadPropiedades()

        lmbAgenda.Selected = False
        lmbVisitasCanceladas.Selected = False
        lmbVisitasModificadas.Selected = False
        lmbEmpleados.Selected = False
        LmbVisitasAsignadas.Selected = False
        lmbClientes.Selected = False
        lmbPropiedades.Selected = True

        tlpPropiedades.Visible = True
        tlpClientes.Visible = False
        TlpVisitasAsignadas.Visible = False
        tlpEmpleados.Visible = False
        tlpAgenda.Visible = False
        tlpVisitasCanceladas.Visible = False
        tlpVisitasModificadas.Visible = False
    End Sub

    Private Sub lmbAgenda_Click(sender As Object, e As EventArgs) Handles lmbAgenda.Click
        LoadAgenda()

        lmbPropiedades.Selected = False
        lmbVisitasCanceladas.Selected = False
        lmbVisitasModificadas.Selected = False
        lmbEmpleados.Selected = False
        lmbClientes.Selected = False
        LmbVisitasAsignadas.Selected = False
        lmbAgenda.Selected = True

        tlpAgenda.Visible = True
        TlpVisitasAsignadas.Visible = False
        tlpClientes.Visible = False
        tlpEmpleados.Visible = False
        tlpPropiedades.Visible = False
        tlpVisitasCanceladas.Visible = False
        tlpVisitasModificadas.Visible = False
    End Sub

    Private Sub LmbVisitasAsignadas_Click(sender As Object, e As EventArgs) Handles LmbVisitasAsignadas.Click
        LoadVisitasAsignadas()

        lmbPropiedades.Selected = False
        lmbVisitasCanceladas.Selected = False
        lmbVisitasModificadas.Selected = False
        lmbEmpleados.Selected = False
        lmbClientes.Selected = False
        lmbAgenda.Selected = False
        LmbVisitasAsignadas.Selected = True

        TlpVisitasAsignadas.Visible = True
        tlpAgenda.Visible = False
        tlpClientes.Visible = False
        tlpEmpleados.Visible = False
        tlpPropiedades.Visible = False
        tlpVisitasCanceladas.Visible = False
        tlpVisitasModificadas.Visible = False
    End Sub

    Private Sub lmbVisitasCanceladas_Click(sender As Object, e As EventArgs) Handles lmbVisitasCanceladas.Click
        LoadVisitasCanceladas()

        lmbPropiedades.Selected = False
        lmbAgenda.Selected = False
        lmbVisitasModificadas.Selected = False
        LmbVisitasAsignadas.Selected = False
        lmbEmpleados.Selected = False
        lmbClientes.Selected = False
        lmbVisitasCanceladas.Selected = True

        tlpVisitasCanceladas.Visible = True
        tlpClientes.Visible = False
        tlpEmpleados.Visible = False
        TlpVisitasAsignadas.Visible = False
        tlpPropiedades.Visible = False
        tlpAgenda.Visible = False
        tlpVisitasModificadas.Visible = False
    End Sub

    Private Sub lmbVisitasModificadas_Click(sender As Object, e As EventArgs) Handles lmbVisitasModificadas.Click
        LoadVisitasModificadas()

        lmbPropiedades.Selected = False
        lmbAgenda.Selected = False
        lmbVisitasCanceladas.Selected = False
        LmbVisitasAsignadas.Selected = False
        lmbEmpleados.Selected = False
        lmbClientes.Selected = False
        lmbVisitasModificadas.Selected = True

        tlpVisitasModificadas.Visible = True
        tlpClientes.Visible = False
        tlpEmpleados.Visible = False
        tlpPropiedades.Visible = False
        TlpVisitasAsignadas.Visible = False
        tlpAgenda.Visible = False
        tlpVisitasCanceladas.Visible = False
    End Sub

    Private Sub lmbEmpleados_Click(sender As Object, e As EventArgs) Handles lmbEmpleados.Click
        LoadEmpleados()

        lmbPropiedades.Selected = False
        lmbAgenda.Selected = False
        lmbVisitasCanceladas.Selected = False
        lmbVisitasModificadas.Selected = False
        LmbVisitasAsignadas.Selected = False
        lmbClientes.Selected = False
        lmbEmpleados.Selected = True

        tlpEmpleados.Visible = True
        tlpClientes.Visible = False
        TlpVisitasAsignadas.Visible = False
        tlpVisitasModificadas.Visible = False
        tlpPropiedades.Visible = False
        tlpAgenda.Visible = False
        tlpVisitasCanceladas.Visible = False
    End Sub

    Private Sub lmbClientes_Click(sender As Object, e As EventArgs) Handles lmbClientes.Click
        LoadClientes()

        lmbPropiedades.Selected = False
        lmbAgenda.Selected = False
        lmbVisitasCanceladas.Selected = False
        lmbVisitasModificadas.Selected = False
        lmbEmpleados.Selected = False
        LmbVisitasAsignadas.Selected = False
        lmbClientes.Selected = True

        tlpClientes.Visible = True
        TlpVisitasAsignadas.Visible = False
        tlpEmpleados.Visible = False
        tlpVisitasModificadas.Visible = False
        tlpPropiedades.Visible = False
        tlpAgenda.Visible = False
        tlpVisitasCanceladas.Visible = False
    End Sub

    Private Sub cbxDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPropiedadDepart.SelectedIndexChanged
        cbxPropiedadLoc.DataSource = Database.GetInstance.Utilidades.Localidades(CType(cbxPropiedadDepart.SelectedItem, DataRowView).Item(0)).DefaultView
        cbxPropiedadLoc.DisplayMember = "nombre"
    End Sub

    Private Sub btnAgregarPropiedad_Click(sender As Object, e As EventArgs) Handles btnPropiedadAgregar.Click
        Dim form As New FormPropiedad
        form.Actividad = "agregar"
        form.ShowDialog(Me)
        dgvPropiedades.DataSource = BusquedaPropiedades()
    End Sub

    Private Sub btnEditarPropiedad_Click(sender As Object, e As EventArgs) Handles btnPropiedadEditar.Click
        Try
            Dim form As New FormPropiedad
            form.Actividad = "editar"
            form.IdPropiedad = dgvPropiedades.SelectedRows(0).Cells(0).Value
            form.ShowDialog(Me)
            dgvPropiedades.DataSource = BusquedaPropiedades()
        Catch ex As Exception
            MsgBox("No se ha seleccionado una propiedad", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnPropiedadBuscar_Click(sender As Object, e As EventArgs) Handles btnPropiedadBuscar.Click
        Try
            dgvPropiedades.DataSource = BusquedaPropiedades()
        Catch ex As Exception
        End Try
    End Sub ' btnBuscar_Click

    Private Function BusquedaPropiedades() As DataTable

        Dim datos As New SqlPropiedad

        If chbPropiedadPorUbic.Checked Then
            datos.Filtro(FiltroPropiedad.CODIGO_LOCALIDAD, CType(cbxPropiedadLoc.SelectedItem, DataRowView).Item(0))
        End If

        If chbPropiedadPorTipo.Checked Then
            If cbxPropiedadTipo.Text = "Casa" Then
                datos.Filtro(FiltroPropiedad.TIPO, TipoPropiedad.CASA)
            ElseIf cbxPropiedadTipo.Text = "Apartamento" Then
                datos.Filtro(FiltroPropiedad.TIPO, TipoPropiedad.APARTAMENTO)
            ElseIf cbxPropiedadTipo.Text = "Local Comercial" Then
                datos.Filtro(FiltroPropiedad.TIPO, TipoPropiedad.LOCAL_COMERCIAL)
            End If
        End If

        If chbPropiedadPorOperac.Checked Then
            If cbxPropiedadOperac.Text = "Alquiler" Then
                datos.Filtro(FiltroPropiedad.OPERACION, OperacionPropiedad.ALQUILER)
            ElseIf cbxPropiedadOperac.Text = "Venta" Then
                datos.Filtro(FiltroPropiedad.OPERACION, OperacionPropiedad.VENTA)
            End If
        End If

        If chbPropiedadPorHabs.Checked Then
            datos.Filtro(FiltroPropiedad.HABITACIONES_MAXIMO, nudPropiedadMaxHabs.Value)
            datos.Filtro(FiltroPropiedad.HABITACIONES_MINIMO, nudPropiedadMinHabs.Value)
        End If

        If chbPropiedadPorMts2.Checked Then
            datos.Filtro(FiltroPropiedad.MTS2_MAXIMO, nudPropiedadMaxMts2.Value)
            datos.Filtro(FiltroPropiedad.MTS2_MINIMO, nudPropiedadMinMts2.Value)
        End If

        If chbPropiedadPorPrecio.Checked Then
            datos.Filtro(FiltroPropiedad.PRECIO_MAXIMO, nudPropiedadMaxPrecio.Value)
            datos.Filtro(FiltroPropiedad.PRECIO_MINIMO, nudPropiedadMinPrecio.Value)
        End If

        datos.Filtro(FiltroPropiedad.ESTADO, EstadoDatos.ACTIVO)

        datos.Desc()

        datos.Limite(0, limit)
        Return Database.GetInstance.Propiedades.Lista(datos)
    End Function

    Private Sub nudMinHabs_ValueChanged(sender As Object, e As EventArgs) Handles nudPropiedadMinHabs.ValueChanged
        nudPropiedadMaxHabs.Minimum = nudPropiedadMinHabs.Value
    End Sub

    Private Sub nudMaxHabs_ValueChanged(sender As Object, e As EventArgs) Handles nudPropiedadMaxHabs.ValueChanged
        nudPropiedadMinHabs.Maximum = nudPropiedadMaxHabs.Value
    End Sub

    Private Sub nudMinMts2_ValueChanged(sender As Object, e As EventArgs) Handles nudPropiedadMinMts2.ValueChanged
        nudPropiedadMaxMts2.Minimum = nudPropiedadMinMts2.Value
    End Sub

    Private Sub nudMaxMts2_ValueChanged(sender As Object, e As EventArgs) Handles nudPropiedadMaxMts2.ValueChanged
        nudPropiedadMinMts2.Maximum = nudPropiedadMaxMts2.Value
    End Sub

    Private Sub nudMinPrecio_ValueChanged(sender As Object, e As EventArgs) Handles nudPropiedadMinPrecio.ValueChanged
        nudPropiedadMaxPrecio.Minimum = nudPropiedadMinPrecio.Value
    End Sub

    Private Sub nudMaxPrecio_ValueChanged(sender As Object, e As EventArgs) Handles nudPropiedadMaxPrecio.ValueChanged
        nudPropiedadMinPrecio.Maximum = nudPropiedadMaxPrecio.Value
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub

    Private Sub dgvPropiedades_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPropiedades.SelectionChanged
        Try
            pbxPropiedadImagen.Image = Database.GetInstance.Propiedades.BuscarImagen(dgvPropiedades.SelectedRows(0).Cells(0).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnPropiedadEliminar_Click(sender As Object, e As EventArgs) Handles btnPropiedadEliminar.Click
        Try
            Dim codProp = dgvPropiedades.SelectedRows(0).Cells(0).Value
            If MsgBox("¿Está seguro de borrar la propiedad?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Database.GetInstance.Propiedades.Eliminar(codProp)
                dgvPropiedades.DataSource = BusquedaPropiedades()
            End If
        Catch ex As Exception
            MsgBox("No se ha seleccionado una propiedad", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub pbxPropiedadImagen_Click(sender As Object, e As EventArgs) Handles pbxPropiedadImagen.Click
        If pbxPropiedadImagen.Image IsNot Nothing Then
            FormImageViewer.Imagen = pbxPropiedadImagen.Image
            FormImageViewer.ShowDialog(Me)
        End If
    End Sub

    Private Sub BuscarVisitas(DgvLista As DataGridView, chbCliente As CheckBox, MtbCiCli As MaskedTextBox, chbFecha As CheckBox, fhMin As DateTimePicker, fhMax As DateTimePicker, tipo As EstadoVisita)
        Dim datos As New BuscarVisita

        Try
            If chbCliente.Checked And MtbCiCli.MaskCompleted And IsValidCI(MtbCiCli.Text.Remove(7, 1)) Then
                datos.Filtro(FiltroVisita.CI_CLIENTE, MtbCiCli.Text.Remove(7, 1))
            End If

            If chbFecha.Checked Then
                datos.Filtro(FiltroVisita.FECHA_MINIMA_VISITA, fhMin.Value)
                datos.Filtro(FiltroVisita.FECHA_MAXIMA_VISITA, fhMax.Value)
            End If

            datos.Filtro(FiltroVisita.ESTADO_VISITA, tipo)

            datos.Desc()

            datos.Limite(0, limit)
        Catch ex As CustomException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return
        Catch ex As Exception
        End Try

        DgvLista.DataSource = Database.GetInstance.Visitas.Lista(datos)
    End Sub

    Private Sub btnAgendaBuscar_Click(sender As Object, e As EventArgs) Handles btnAgendaBuscar.Click
        BuscarVisitas(DgvAgenda, chbAgendaPorUsuario, mtbAgendaCiCliente, chbAgendaPorFecha, dtpAgendaFechaMin, dtpAgendaFechaMax, EstadoVisita.ACTIVAS)
    End Sub

    Private Sub btnModifBuscar_Click(sender As Object, e As EventArgs) Handles btnModifBuscar.Click
        BuscarVisitas(dgvModificadas, chbModifPorCliente, mtbModifCiCliente, chbModifPorFecha, dtpModifFechaMin, dtpModifFechaMax, EstadoVisita.MODIFICADAS)
    End Sub

    Private Sub btnCancelBuscar_Click(sender As Object, e As EventArgs) Handles btnCancelBuscar.Click
        BuscarVisitas(dgvCanceladas, chbCancelPorCliente, mtbCancelCiCliente, chbCancelPorFecha, dtpCancelFechMin, dtpCancelFechMax, EstadoVisita.CANCELADAS)
    End Sub

    Private Sub btnEmpleadosBuscar_Click(sender As Object, e As EventArgs) Handles btnEmpleadosBuscar.Click
        Dim datos As New SqlEmpleado

        Try
            If chbEmpleadosBuscarPorCi.Checked And mtbEmpleadosCi.MaskCompleted And IsValidCI(mtbEmpleadosCi.Text.Remove(7, 1)) Then
                datos.Filtro(FiltroEmpleado.CI, mtbEmpleadosCi.Text.Remove(7, 1))
            End If

            If chbEmpleadosBuscarPorSucursal.Checked Then
                datos.Filtro(FiltroEmpleado.ID_SUCURSAL, CType(cbxEmpleadosSucursal.SelectedValue, DataRowView).Item(0))
            End If

            If Not chbEmpleadosMostrarDeshabilitados.Checked Then
                datos.Filtro(FiltroEmpleado.ESTADO, EstadoDatos.ACTIVO)
            End If

            datos.MostrarVisitas()

            datos.Desc()

            datos.Limite(0, limit)
        Catch ex As CustomException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return
        Catch ex As Exception
        End Try

        dgvEmpleados.DataSource = Database.GetInstance.Usuarios.Lista(datos)
    End Sub

    Private Sub btnClientesBuscar_Click(sender As Object, e As EventArgs) Handles btnClientesBuscar.Click
        Dim datos As New SqlCliente
        Try
            If chbClientesBuscarPorCI.Checked And mtbClientesCi.MaskCompleted And IsValidCI(mtbClientesCi.Text.Remove(7, 1)) Then
                datos.Filtro(FiltroCliente.CI, mtbClientesCi.Text.Remove(7, 1))
            End If

            If chbClientesBuscarPorCorreo.Checked And IsValidEmail(tbxClientesCorreo.Text) Then
                datos.Filtro(FiltroCliente.CORREO, tbxClientesCorreo.Text)
            End If

            If Not chbClientesMostrarDeshabilitados.Checked Then
                datos.Filtro(FiltroCliente.ESTADO, EstadoDatos.ACTIVO)
            End If

            datos.MostrarVisitas()

            datos.Desc().Limite(0, limit)
        Catch ex As CustomException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return
        Catch ex As Exception
        End Try

        dgvClientes.DataSource = Database.GetInstance.Usuarios.Lista(datos)
    End Sub

    Private Sub SetDataFromCi(mtb As MaskedTextBox, tbxNom As TextBox, tbxApell As TextBox, tipo As TipoUsuario)
        Dim datosUsuario As New DatosPersona
        If mtb.MaskCompleted Then
            Try
                If tipo = TipoUsuario.CLIENTE Then
                    datosUsuario = Database.GetInstance.Usuarios.ClientePorCi(mtb.Text.Remove(7, 1))
                ElseIf tipo = TipoUsuario.EMPLEADO Then
                    datosUsuario = Database.GetInstance.Usuarios.EmpleadoPorCi(mtb.Text.Remove(7, 1))
                Else
                    Return
                End If
                tbxNom.Text = datosUsuario.Nombre
                tbxApell.Text = datosUsuario.Apellido
            Catch ex As Exception
                tbxNom.Text = "Usuario no registrado"
                tbxApell.Text = ""
            End Try
        Else
            tbxNom.Text = ""
            tbxApell.Text = ""
        End If
    End Sub

    Private Sub mtbAgendaCiCliente_TextChanged(sender As Object, e As EventArgs) Handles mtbAgendaCiCliente.TextChanged
        SetDataFromCi(mtbAgendaCiCliente, tbxAgendaNomCliente, tbxAgendaApellCliente, TipoUsuario.CLIENTE)
    End Sub

    Private Sub mtbModifCiCliente_TextChanged(sender As Object, e As EventArgs) Handles mtbModifCiCliente.TextChanged
        SetDataFromCi(mtbModifCiCliente, tbxModifClienteNombre, tbxModifClienteApellido, TipoUsuario.CLIENTE)
    End Sub

    Private Sub mtbCancelCiCliente_TextChanged(sender As Object, e As EventArgs) Handles mtbCancelCiCliente.TextChanged
        SetDataFromCi(mtbCancelCiCliente, tbxCancelClienteNombre, tbxCancelClienteApellido, TipoUsuario.CLIENTE)
    End Sub

    Private Sub mtbEmpleadosCi_TextChanged(sender As Object, e As EventArgs) Handles mtbEmpleadosCi.TextChanged
        SetDataFromCi(mtbEmpleadosCi, tbxEmpleadosNombre, tbxEmpleadosApellido, TipoUsuario.EMPLEADO)
    End Sub

    Private Sub mtbClientesCi_TextChanged(sender As Object, e As EventArgs) Handles mtbClientesCi.TextChanged
        SetDataFromCi(mtbClientesCi, tbxClientesNombre, tbxClientesApellido, TipoUsuario.CLIENTE)
    End Sub

    Private Sub dtpAgendaFechaMin_ValueChanged(sender As Object, e As EventArgs) Handles dtpAgendaFechaMin.ValueChanged
        dtpAgendaFechaMin.MaxDate = dtpAgendaFechaMax.Value
    End Sub

    Private Sub dtpAgendaFechaMax_ValueChanged(sender As Object, e As EventArgs) Handles dtpAgendaFechaMax.ValueChanged
        dtpAgendaFechaMax.MinDate = dtpAgendaFechaMin.Value
    End Sub

    Private Sub dtpModifFechaMin_ValueChanged(sender As Object, e As EventArgs) Handles dtpModifFechaMin.ValueChanged
        dtpModifFechaMin.MaxDate = dtpModifFechaMax.Value
    End Sub

    Private Sub dtpModifFechaMax_ValueChanged(sender As Object, e As EventArgs) Handles dtpModifFechaMax.ValueChanged
        dtpModifFechaMax.MinDate = dtpModifFechaMin.Value
    End Sub

    Private Sub dtpCancelFechMin_ValueChanged(sender As Object, e As EventArgs) Handles dtpCancelFechMin.ValueChanged
        dtpCancelFechMin.MaxDate = dtpCancelFechMax.Value
    End Sub

    Private Sub dtpCancelFechMax_ValueChanged(sender As Object, e As EventArgs) Handles dtpCancelFechMax.ValueChanged
        dtpCancelFechMax.MinDate = dtpCancelFechMin.Value
    End Sub

    Private Sub btnAgendaModifVisita_Click(sender As Object, e As EventArgs) Handles btnAgendaModifVisita.Click
        Try
            FormEditarVisita.CiCliente = DgvAgenda.SelectedRows(0).Cells(0).Value
            FormEditarVisita.IdPropiedad = DgvAgenda.SelectedRows(0).Cells(1).Value
        Catch ex As Exception
            MsgBox("No se ha seleccionado ninguna visita", MsgBoxStyle.Exclamation)
            Return
        End Try

        FormEditarVisita.ShowDialog(Me)

        If FormEditarVisita.Respuesta Then
            btnAgendaBuscar_Click(sender, e)
            isLoadedVisitasModificadas = False
            isLoadedVisitasAsignadas = False
        End If
    End Sub

    Private Sub btnAgendaCancelVisita_Click(sender As Object, e As EventArgs) Handles btnAgendaCancelVisita.Click
        Try
            Dim ciCli As Integer = DgvAgenda.SelectedRows(0).Cells(0).Value
            Dim idProp As Integer = DgvAgenda.SelectedRows(0).Cells(1).Value
            If MsgBox("¿Está seguro de cancelar la visita?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Database.GetInstance.Visitas.Cancelar(ciCli, idProp) Then
                    btnAgendaBuscar_Click(sender, e)
                    isLoadedVisitasCanceladas = False
                    isLoadedVisitasAsignadas = False
                    MsgBox("Visita cancelada!", MsgBoxStyle.Information)
                Else
                    MsgBox("No se ha podido cancelar la visita!", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox("No se ha seleccionado ninguna visita", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnAgendaVerVisita_Click(sender As Object, e As EventArgs) Handles btnAgendaVerVisita.Click
        Try
            Dim fVerVisita As New FormVerVisita
            fVerVisita.CiCliente = DgvAgenda.SelectedRows(0).Cells(0).Value
            fVerVisita.CodPropiedad = DgvAgenda.SelectedRows(0).Cells(1).Value
            fVerVisita.ShowDialog(Me)
        Catch ex As Exception
            MsgBox("No se ha seleccionado ninguna visita", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub btnAgendaAceptarVisita_Click(sender As Object, e As EventArgs) Handles btnAgendaAceptarVisita.Click
        Try
            Dim ciCli = DgvAgenda.SelectedRows(0).Cells(0).Value
            Dim codProp = DgvAgenda.SelectedRows(0).Cells(1).Value
            If MsgBox("¿Está seguro de aceptar la visita seleccionada?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Database.GetInstance.Visitas.AsignarAgente(ciCli, codProp, UsuarioLogueado.Ci) Then
                    MsgBox("Visita asignada", MsgBoxStyle.Information)
                    btnAgendaBuscar_Click(sender, e)
                    isLoadedVisitasAsignadas = False
                Else
                    MsgBox("No se ha podido asignar la visita", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox("No se ha seleccionado ninguna visita", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnClientesRegistro_Click(sender As Object, e As EventArgs) Handles btnClientesRegistro.Click
        Dim frmRegCli As New FormRegistroCliente
        frmRegCli.ShowDialog(Me)
        If frmRegCli.Respuesta Then
            btnClientesBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub btnClientesEditar_Click(sender As Object, e As EventArgs) Handles btnClientesEditar.Click
        Try
            Dim frmRegCli As New FormRegistroCliente
            frmRegCli.CiCliente = dgvClientes.SelectedRows(0).Cells(0).Value
            frmRegCli.ShowDialog(Me)
            If frmRegCli.Respuesta Then
                btnClientesBuscar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox("No se ha seleccionado un cliente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnClientesDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnClientesDeshabilitar.Click
        Try
            If dgvClientes("activo", dgvClientes.SelectedRows(0).Index).Value = "1" Then
                If MsgBox("¿Está seguro de deshabilitar la cuenta del cliente?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If Database.GetInstance.Usuarios.Modificar(dgvClientes.SelectedRows(0).Cells(0).Value, (New DmlCliente).SetData(AtributoCliente.ESTADO, EstadoDatos.INACTIVO)) Then
                        MsgBox("El usuario se ha deshabilitado!", MsgBoxStyle.Information)
                        btnClientesBuscar_Click(sender, e)
                    Else
                        MsgBox("El usuario no se ha podido deshabilitar", MsgBoxStyle.Critical)
                    End If
                End If
            Else
                If MsgBox("¿Está seguro de habilitar la cuenta del cliente?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If Database.GetInstance.Usuarios.Modificar(dgvClientes.SelectedRows(0).Cells(0).Value, (New DmlCliente).SetData(AtributoCliente.ESTADO, EstadoDatos.ACTIVO)) Then
                        MsgBox("El usuario se ha habilitado!", MsgBoxStyle.Information)
                        btnClientesBuscar_Click(sender, e)
                    Else
                        MsgBox("El usuario no se ha podido habilitar", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("No se ha seleccionado un cliente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub dgvClientes_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.RowEnter
        Try
            If dgvClientes("activo", dgvClientes.SelectedRows(0).Index).Value = "1" Then
                btnClientesDeshabilitar.Image = My.Resources.delete_red
                btnClientesDeshabilitar.Text = "DESHABILITAR CLIENTE"
            Else
                btnClientesDeshabilitar.Image = My.Resources.ok_red
                btnClientesDeshabilitar.Text = "HABILITAR CLIENTE"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvEmpleados_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.RowEnter
        Try
            If dgvEmpleados("activo", dgvEmpleados.SelectedRows(0).Index).Value = "1" Then
                btnEmpleadosDeshabilitar.Image = My.Resources.delete_red
                btnEmpleadosDeshabilitar.Text = "DESHABILITAR EMPLEADO"
            Else
                btnEmpleadosDeshabilitar.Image = My.Resources.ok_red
                btnEmpleadosDeshabilitar.Text = "HABILITAR EMPLEADO"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEmpleadosDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnEmpleadosDeshabilitar.Click
        If dgvEmpleados.SelectedRows(0).Cells(0).Value = UsuarioLogueado.Ci.ToString Then
            MsgBox("No se puede deshabilitar el empleado a si mismo", MsgBoxStyle.Exclamation)
        End If
        If dgvEmpleados("activo", dgvEmpleados.SelectedRows(0).Index).Value = "1" Then
            If MsgBox("¿Está seguro de deshabilitar la cuenta del empleado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Database.GetInstance.Usuarios.Modificar(dgvEmpleados.SelectedRows(0).Cells(0).Value, (New DmlEmpleado).SetData(AtributoEmpleado.ESTADO, EstadoDatos.INACTIVO)) Then
                    MsgBox("El usuario ha sido deshabilitado!", MsgBoxStyle.Information)
                    btnEmpleadosBuscar_Click(sender, e)
                Else
                    MsgBox("El usuario no se ha podido deshabilitar", MsgBoxStyle.Critical)
                End If
            End If
        Else
            If MsgBox("¿Está seguro de habilitar la cuenta del empleado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Database.GetInstance.Usuarios.Modificar(dgvEmpleados.SelectedRows(0).Cells(0).Value, (New DmlEmpleado).SetData(AtributoEmpleado.ESTADO, EstadoDatos.ACTIVO)) Then
                    MsgBox("El usuario ha sido habilitado!", MsgBoxStyle.Information)
                    btnEmpleadosBuscar_Click(sender, e)
                Else
                    MsgBox("El usuario no se ha podido habilitar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub btnEmpleadosRegistro_Click(sender As Object, e As EventArgs) Handles btnEmpleadosRegistro.Click
        Dim fRegEmp As New FormRegistroEmpleado
        fRegEmp.ShowDialog(Me)
        If fRegEmp.Respuesta Then
            btnEmpleadosBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub btnEmpleadosEditar_Click(sender As Object, e As EventArgs) Handles btnEmpleadosEditar.Click
        Dim fRegEmp As New FormRegistroEmpleado
        fRegEmp.CiEmpleado = dgvEmpleados.SelectedRows(0).Cells(0).Value
        fRegEmp.ShowDialog(Me)
        If fRegEmp.Respuesta Then
            btnEmpleadosBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub btnClientesAgregarAEmpleado_Click(sender As Object, e As EventArgs) Handles btnClientesAgregarAEmpleado.Click
        Try
            Dim fRegEx As New FormRegistroExistente
            fRegEx.CIUsuario = dgvClientes.SelectedRows(0).Cells(0).Value
            fRegEx.AgregarComo = TipoUsuario.EMPLEADO
            fRegEx.ShowDialog(Me)
            If fRegEx.Respuesta Then
                btnEmpleadosBuscar_Click(sender, e)
                isLoadedEmpleados = False
            End If
        Catch ex As Exception
            MsgBox("No se ha seleccionado un cliente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnEmpleadosAgregarACliente_Click(sender As Object, e As EventArgs) Handles btnEmpleadosAgregarACliente.Click
        Try
            Dim fRegEx As New FormRegistroExistente
            fRegEx.CIUsuario = dgvEmpleados.SelectedRows(0).Cells(0).Value
            fRegEx.AgregarComo = TipoUsuario.CLIENTE
            fRegEx.ShowDialog(Me)
            If fRegEx.Respuesta Then
                btnClientesBuscar_Click(sender, e)
                isLoadedClientes = False
            End If
        Catch ex As Exception
            MsgBox("No se ha seleccionado un empleado", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub RbtVisitasAsignadas_CheckedChanged(sender As Object, e As EventArgs) Handles RbtVisitasAsignadasDia.CheckedChanged, RbtVisitasAsignadas7Dias.CheckedChanged, RbtVisitasAsignadas30Dias.CheckedChanged, RbtVisitasAsignadasTodas.CheckedChanged
        Try
            Dim SqlVAsignadas As New BuscarVisita

            SqlVAsignadas.Filtro(FiltroVisita.FECHA_MINIMA_VISITA, Now.Date)

            If RbtVisitasAsignadasDia.Checked Then
                SqlVAsignadas.Filtro(FiltroVisita.FECHA_MAXIMA_VISITA, Now.Date.AddDays(1))
            ElseIf RbtVisitasAsignadas7Dias.Checked Then
                SqlVAsignadas.Filtro(FiltroVisita.FECHA_MAXIMA_VISITA, Now.Date.AddDays(7))
            ElseIf RbtVisitasAsignadas30Dias.Checked Then
                SqlVAsignadas.Filtro(FiltroVisita.FECHA_MAXIMA_VISITA, Now.Date.AddDays(30))
            End If

            SqlVAsignadas.Filtro(FiltroVisita.ESTADO_VISITA, EstadoVisita.ACTIVAS)
            SqlVAsignadas.Filtro(FiltroVisita.CI_EMPLEADO, UsuarioLogueado.Ci)
            SqlVAsignadas.Desc().Limite(0, limit)
            Dim result = Database.GetInstance.Visitas.Lista(SqlVAsignadas)
            result.Columns.RemoveAt(2)
            DgvVisitasAsignadas.DataSource = result
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnVisitasAsignadasCancelar_Click(sender As Object, e As EventArgs) Handles BtnVisitasAsignadasCancelar.Click
        Try
            Dim ciCli = DgvVisitasAsignadas.SelectedRows(0).Cells(0).Value
            Dim codProp = DgvVisitasAsignadas.SelectedRows(0).Cells(1).Value
            If MsgBox("¿Está seguro de cancelar la visita?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Database.GetInstance.Visitas.Cancelar(ciCli, codProp) Then
                    MsgBox("La visita ha sido cancelada!", MsgBoxStyle.Information)
                    RbtVisitasAsignadas_CheckedChanged(sender, e)
                    isLoadedAgenda = False
                Else
                    MsgBox("La visita no se ha podido cancelar", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            MsgBox("No se ha seleccionado un visita", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub BtnVisitasAsignadasEditar_Click(sender As Object, e As EventArgs) Handles BtnVisitasAsignadasEditar.Click
        Try
            FormEditarVisita.CiCliente = DgvVisitasAsignadas.SelectedRows(0).Cells(0).Value
            FormEditarVisita.IdPropiedad = DgvVisitasAsignadas.SelectedRows(0).Cells(1).Value
        Catch ex As Exception
            MsgBox("No se ha seleccionado ninguna visita", MsgBoxStyle.Exclamation)
            Return
        End Try

        FormEditarVisita.ShowDialog(Me)

        If FormEditarVisita.Respuesta Then
            RbtVisitasAsignadas_CheckedChanged(sender, e)
            isLoadedAgenda = False
        End If
    End Sub

    Private Sub BtnVisitasAsignadasVer_Click(sender As Object, e As EventArgs) Handles BtnVisitasAsignadasVer.Click
        Try
            Dim fVerVisita As New FormVerVisita
            fVerVisita.CiCliente = DgvVisitasAsignadas.SelectedRows(0).Cells(0).Value
            fVerVisita.CodPropiedad = DgvVisitasAsignadas.SelectedRows(0).Cells(1).Value
            fVerVisita.ShowDialog(Me)
        Catch ex As Exception
            MsgBox("No se ha seleccionado ninguna visita", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class