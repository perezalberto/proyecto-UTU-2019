Public Class FormCliente
    Private limite As Integer = 500

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles Me.Load

        cbxDepartamento.DataSource = Database.GetInstance.Utilidades.Departamentos().DefaultView
        cbxDepartamento.DisplayMember = "nombre"

        cbxTipo.SelectedItem = "Casa"
        cbxOperacion.SelectedItem = "Alquiler"

        Dim data = Database.GetInstance.Propiedades.Lista((New SqlPropiedad).Filtro(FiltroPropiedad.ESTADO, EstadoDatos.ACTIVO).Desc().Limite(0, limite))
        dgvPropiedades.DataSource = data
        dtpFechaHora.MinDate = Now()
    End Sub

    Private Sub cbxDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDepartamento.SelectedIndexChanged
        cbxLocalidad.DataSource = Database.GetInstance.Utilidades.Localidades(CType(cbxDepartamento.SelectedItem, DataRowView).Item(0)).DefaultView
        cbxLocalidad.DisplayMember = "nombre"
    End Sub

    Private Sub FormularioCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Database.ClearInstance()
        FormPrincipal.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim datos As New SqlPropiedad()

        If chbPorUbicacion.Checked Then
            datos.Filtro(FiltroPropiedad.CODIGO_LOCALIDAD, CType(cbxLocalidad.SelectedItem, DataRowView).Item(0))
        End If

        If chbPorTipo.Checked Then
            If cbxTipo.Text = "Casa" Then
                datos.Filtro(FiltroPropiedad.TIPO, TipoPropiedad.CASA)
            ElseIf cbxTipo.Text = "Apartamento" Then
                datos.Filtro(FiltroPropiedad.TIPO, TipoPropiedad.APARTAMENTO)
            ElseIf cbxTipo.Text = "Local Comercial" Then
                datos.Filtro(FiltroPropiedad.TIPO, TipoPropiedad.LOCAL_COMERCIAL)
            End If
        End If

        If chbPorOperacion.Checked Then
            If cbxOperacion.Text = "Alquiler" Then
                datos.Filtro(FiltroPropiedad.OPERACION, OperacionPropiedad.ALQUILER)
            ElseIf cbxOperacion.Text = "Venta" Then
                datos.Filtro(FiltroPropiedad.OPERACION, OperacionPropiedad.VENTA)
            End If
        End If

        If chbPorHabitaciones.Checked Then
            datos.Filtro(FiltroPropiedad.HABITACIONES_MAXIMO, nudMaxHabs.Value)
            datos.Filtro(FiltroPropiedad.HABITACIONES_MINIMO, nudMinHabs.Value)
        End If

        If chbPorMts2.Checked Then
            datos.Filtro(FiltroPropiedad.MTS2_MAXIMO, nudMaxMts2.Value)
            datos.Filtro(FiltroPropiedad.MTS2_MINIMO, nudMinMts2.Value)
        End If

        If chbPorPrecio.Checked Then
            datos.Filtro(FiltroPropiedad.PRECIO_MAXIMO, nudMaxPrecio.Value)
            datos.Filtro(FiltroPropiedad.PRECIO_MINIMO, nudMinPrecio.Value)
        End If

        datos.Desc()

        datos.Limite(0, limite)

        Try
            Dim dt = Database.GetInstance.Propiedades.Lista(datos)
            dgvPropiedades.DataSource = dt
            dgvPropiedades.Update()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvPropiedades_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPropiedades.SelectionChanged
        Try
            pbxImagen.Image = Database.GetInstance.Propiedades.BuscarImagen(dgvPropiedades.SelectedRows(0).Cells(0).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub nudMinHabs_ValueChanged(sender As Object, e As EventArgs) Handles nudMinHabs.ValueChanged
        nudMaxHabs.Minimum = nudMinHabs.Value
    End Sub

    Private Sub nudMaxHabs_ValueChanged(sender As Object, e As EventArgs) Handles nudMaxHabs.ValueChanged
        nudMinHabs.Maximum = nudMaxHabs.Value
    End Sub

    Private Sub nudMinMts2_ValueChanged(sender As Object, e As EventArgs) Handles nudMinMts2.ValueChanged
        nudMaxMts2.Minimum = nudMinMts2.Value
    End Sub

    Private Sub nudMaxMts2_ValueChanged(sender As Object, e As EventArgs) Handles nudMaxMts2.ValueChanged
        nudMinMts2.Maximum = nudMaxMts2.Value
    End Sub

    Private Sub nudMinPrecio_ValueChanged(sender As Object, e As EventArgs) Handles nudMinPrecio.ValueChanged
        nudMaxPrecio.Minimum = nudMinPrecio.Value
    End Sub

    Private Sub nudMaxPrecio_ValueChanged(sender As Object, e As EventArgs) Handles nudMaxPrecio.ValueChanged
        nudMinPrecio.Maximum = nudMaxPrecio.Value
    End Sub

    Private Sub btnAgendar_Click(sender As Object, e As EventArgs) Handles btnAgendar.Click
        If MsgBox("Se agendara una visita para la fecha " + dtpFechaHora.Value.ToString("dd/MM/yyyy") + " a la hora " + dtpFechaHora.Value.ToString("HH:mm") + vbCrLf + "¿Esta seguro de agendar la visita?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If Database.GetInstance.Visitas.Agendar(Database.GetInstance.Usuarios.DatosLogeado.Ci, dgvPropiedades.SelectedRows(0).Cells(0).Value, dtpFechaHora.Value) Then
                FormVisitaAgendada.QrCodeMessage = "Visita agendada. Ubicacion de la propiedad - " + dgvPropiedades.SelectedRows(0).Cells(6).Value + ", " + dgvPropiedades.SelectedRows(0).Cells(8).Value + ". Fecha - " + dtpFechaHora.Value.ToString("dd/MM/yyyy") + ". Hora - " + dtpFechaHora.Value.ToString("HH:mm")
                FormVisitaAgendada.ShowDialog()
            Else
                MsgBox("No se ha podido agendar la visita, ya tiene una visita agendada a la propiedad", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub dtpFechaHora_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaHora.ValueChanged
        Dim tmpTime = dtpFechaHora.Value

        If tmpTime.Minute > 45 Then
            tmpTime = tmpTime.AddMinutes(60 - tmpTime.Minute)
        ElseIf tmpTime.Minute <= 15 Then
            tmpTime = tmpTime.AddMinutes(tmpTime.Minute * -1)
        Else
            tmpTime = tmpTime.Date.AddHours(tmpTime.Hour).AddMinutes(30)
        End If

        If tmpTime <= dtpFechaHora.MinDate Then
            tmpTime = tmpTime.AddMinutes(30)
        End If

        dtpFechaHora.Value = tmpTime
    End Sub

    Private Sub pbxImagen_Click(sender As Object, e As EventArgs) Handles pbxImagen.Click
        If pbxImagen.Image IsNot Nothing Then
            FormImageViewer.Imagen = pbxImagen.Image
            FormImageViewer.ShowDialog(Me)
        End If
    End Sub
End Class