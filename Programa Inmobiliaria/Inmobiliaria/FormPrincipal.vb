Public Class FormPrincipal

    Friend WithEvents usr As Usuario

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        usr = Database.GetInstance.Usuarios
    End Sub

    Private Sub Usuarios_OnLogin(tipo As TipoUsuario, datos As DatosPersona) Handles usr.OnLogin
        If tipo = TipoUsuario.EMPLEADO Then
            Dim selectedRole As RolEmpleado
            If RbtAgente.Checked Then
                selectedRole = RolEmpleado.AGENTE
            ElseIf RbtGerente.Checked Then
                selectedRole = RolEmpleado.GERENTE
            End If
            If CType(datos, DatosEmpleado).Rol <> selectedRole Then
                MsgBox("Error de autenticacion: cedula, contraceña o tipo de usuario incorrecto", MsgBoxStyle.Exclamation)
                Return
            End If
            FormEmpleado.UsuarioLogueado = datos
            tbxPasswordEmpleado.Text = ""
            mtbCiEmpleado.Text = ""
            FormEmpleado.Show()
            Close()
        Else
            mtbCiCliente.Text = ""
            FormCliente.Show()
            Close()
        End If
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Dim passwdDialog = New InputPassword(My.Settings.config_passwd)
        If My.Settings.config_passwd = "" Then
            FormConfig.ShowDialog(Me)
        Else
            passwdDialog.ShowDialog(Me)
            If passwdDialog.GrantAccess Then
                FormConfig.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub mtbCiCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles mtbCiCliente.MouseDown
        If Not mtbCiCliente.MaskCompleted Then
            mtbCiCliente.SelectionStart = 0
        End If
    End Sub

    Private Sub mtbCiEmpleado_MouseDown(sender As Object, e As MouseEventArgs) Handles mtbCiEmpleado.MouseDown
        If Not mtbCiEmpleado.MaskCompleted Then
            mtbCiEmpleado.SelectionStart = 0
        End If
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        panelCliente.Visible = True
        panelEmpleado.Visible = False
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        panelEmpleado.Visible = True
        panelCliente.Visible = False
    End Sub

    Private Sub btnRegistroCliente_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnInicioCliente_Click(sender As Object, e As EventArgs) Handles btnInicioCliente.Click
        If mtbCiCliente.MaskCompleted Then
            Try
                Database.GetInstance.LoginSQL(My.Settings.sql_cliente_id, My.Settings.sql_cliente_passwd)
            Catch ex As Exception
                MsgBox("Error: No se ha podido conectar con la base de datos", MsgBoxStyle.Exclamation)
                Return
            End Try
            Database.GetInstance.Usuarios.LoginCliente(mtbCiCliente.Text.Remove(7, 1))
            If Not Database.GetInstance.Usuarios.IsLoggedIn Then
                MsgBox("Cliente no registrado, regístrese para ingresar", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Debe ingresar su cedula para acceder", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnInicioEmpleado_Click(sender As Object, e As EventArgs) Handles btnInicioEmpleado.Click
        If mtbCiEmpleado.MaskCompleted Then
            Try
                If RbtAgente.Checked Then
                    Database.GetInstance.LoginSQL(My.Settings.sql_agente_id, My.Settings.sql_agente_passwd)
                Else
                    Database.GetInstance.LoginSQL(My.Settings.sql_gerente_id, My.Settings.sql_gerente_passwd)
                End If
            Catch ex As Exception
                MsgBox("Error: No se ha podido conectar con la base de datos", MsgBoxStyle.Exclamation)
                Return
            End Try
            Database.GetInstance.Usuarios.LoginEmpleado(mtbCiEmpleado.Text.Remove(7, 1), tbxPasswordEmpleado.Text)
            If Not Database.GetInstance.Usuarios.IsLoggedIn Then
                MsgBox("Error de autenticacion: cedula, contraceña o tipo de usuario incorrecto", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Debe ingresar su cedula para acceder", MsgBoxStyle.Information)
        End If
    End Sub
End Class
