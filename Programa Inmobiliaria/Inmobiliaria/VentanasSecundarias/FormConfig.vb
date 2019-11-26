Public Class FormConfig
    Private Sub FormConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxServidor.Text = My.Settings.server
        tbxBaseDeDatos.Text = My.Settings.database
        nudPuerto.Text = My.Settings.port
        tbxDbClienteUid.Text = My.Settings.sql_cliente_id
        tbxDbClientePassword.Text = "xxxxxx"
        tbxDbAgenteUid.Text = My.Settings.sql_agente_id
        tbxDbAgentePassword.Text = "xxxxxx"
        tbxDbGerenteUid.Text = My.Settings.sql_gerente_id
        tbxDbGerentePassword.Text = "xxxxxx"
        tbxConfigPassword.Text = "xxxxxx"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        My.Settings.server = tbxServidor.Text
        My.Settings.database = tbxBaseDeDatos.Text
        My.Settings.port = nudPuerto.Text

        My.Settings.sql_cliente_id = tbxDbClienteUid.Text
        If tbxDbClientePassword.Text <> "xxxxxx" Then
            My.Settings.sql_cliente_passwd = tbxDbClientePassword.Text
        End If

        My.Settings.sql_agente_id = tbxDbAgenteUid.Text
        If tbxDbAgentePassword.Text <> "xxxxxx" Then
            My.Settings.sql_agente_passwd = tbxDbAgentePassword.Text
        End If

        My.Settings.sql_gerente_id = tbxDbGerenteUid.Text
        If tbxDbGerentePassword.Text <> "xxxxxx" Then
            My.Settings.sql_gerente_passwd = tbxDbGerentePassword.Text
        End If

        If tbxConfigPassword.Text <> "xxxxxx" Then
            My.Settings.config_passwd = tbxConfigPassword.Text
        End If

        Enabled = False
        Try
            Database.GetInstance.LoginSQL(My.Settings.sql_cliente_id, My.Settings.sql_cliente_passwd)
            My.Settings.Save()
            Close()
        Catch ex As Exception
            MsgBox("Error: Datos de configuración incorrectos, no se ha podido conectar con la base de datos", MsgBoxStyle.Exclamation)
            My.Settings.Reload()
        End Try
        Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub tbxClientePassword_Enter(sender As Object, e As EventArgs) Handles tbxDbClientePassword.Enter, tbxDbAgentePassword.Enter, tbxDbGerentePassword.Enter, tbxConfigPassword.Enter
        Dim tbxSender As TextBox = sender
        If tbxSender.Text = "xxxxxx" Then
            tbxSender.Text = ""
        End If
    End Sub

    Private Sub tbxClientePassword_Leave(sender As Object, e As EventArgs) Handles tbxDbClientePassword.Leave, tbxDbAgentePassword.Leave, tbxDbGerentePassword.Leave, tbxConfigPassword.Leave
        Dim tbxSender As TextBox = sender
        If tbxSender.Text = "" Then
            tbxSender.Text = "xxxxxx"
        End If
    End Sub
End Class