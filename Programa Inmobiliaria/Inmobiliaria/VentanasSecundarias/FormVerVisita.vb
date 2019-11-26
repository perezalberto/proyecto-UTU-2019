Public Class FormVerVisita
    Public Property CiCliente As Integer = -1
    Public Property CodPropiedad As Integer = -1

    Private ciDue As Integer ' CI del dueño
    Private ciInt As Integer ' CI del interesado

    Private Sub FormVerVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim datosVis = Database.GetInstance.Visitas.ObtenerUno(CiCliente, CodPropiedad)
            Dim datosProp = Database.GetInstance.Propiedades.BuscarPorCodigo(datosVis.CodPropiedad)
            Dim datosDue = Database.GetInstance.Usuarios.ClientePorCi(datosProp.CiCliente)
            Dim datosInt = Database.GetInstance.Usuarios.ClientePorCi(datosVis.CiCliente)
            Dim imagen = Database.GetInstance.Propiedades.BuscarImagen(datosVis.CodPropiedad)

            ciDue = datosProp.CiCliente
            ciInt = datosVis.CiCliente

            mtbDueCi.Text = datosDue.Ci
            tbxDueNombre.Text = datosDue.Nombre
            tbxDueApellido.Text = datosDue.Apellido
            tbxDueCorreo.Text = datosDue.Correo

            mtbInterCi.Text = datosInt.Ci
            tbxInterNombre.Text = datosInt.Nombre
            tbxInterApellido.Text = datosInt.Apellido
            tbxInterCorreo.Text = datosInt.Correo

            tbxPropHabitaciones.Text = datosProp.Habitaciones
            tbxPropMts2.Text = datosProp.Mts2
            tbxPropPrecio.Text = "USD " + datosProp.Precio.ToString
            tbxPropLocalidad.Text = Database.GetInstance.Utilidades.NombreLocalidadPorCodigo(datosProp.Localidad)
            tbxPropDepartamento.Text = Database.GetInstance.Utilidades.DepPorCodLocalidad(datosProp.Localidad).Item(1)

            If datosProp.Operacion = OperacionPropiedad.ALQUILER Then
                tbxPropOperacion.Text = "Alquiler"
            ElseIf datosProp.Operacion = OperacionPropiedad.VENTA Then
                tbxPropOperacion.Text = "Venta"
            ElseIf datosProp.Operacion = OperacionPropiedad.NULL Then
                tbxPropOperacion.Text = "Alquiler/Venta"
            End If

            If datosProp.Tipo = TipoPropiedad.APARTAMENTO Then
                tbxPropTipo.Text = "Apartamento"
            ElseIf datosProp.Tipo = TipoPropiedad.CASA Then
                tbxPropTipo.Text = "Casa"
            ElseIf datosProp.Tipo = TipoPropiedad.LOCAL_COMERCIAL Then
                tbxPropTipo.Text = "Local comercial"
            End If

            pbxImagen.Image = imagen

            tbxVisitaFecha.Text = datosVis.FechaVisita.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnInterVerNumeros_Click(sender As Object, e As EventArgs) Handles btnInterVerNumeros.Click
        Dim fVerTel As New FormVerTelefonos
        fVerTel.CiUsuario = ciInt
        fVerTel.ShowDialog(Me)
    End Sub

    Private Sub btnDueVerNumeros_Click(sender As Object, e As EventArgs) Handles btnDueVerNumeros.Click
        Dim fVerTel As New FormVerTelefonos
        fVerTel.CiUsuario = ciDue
        fVerTel.ShowDialog(Me)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class