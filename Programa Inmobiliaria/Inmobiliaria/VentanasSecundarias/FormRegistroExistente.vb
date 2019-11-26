Public Class FormRegistroExistente
    Public Property AgregarComo As TipoUsuario = TipoUsuario.NULL
    Public Property CIUsuario As Integer = -1
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

    Private Sub FormRegistroEmpleadoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AgregarComo = TipoUsuario.NULL Or CIUsuario = -1 Then
            Dispose()
        End If

        If AgregarComo = TipoUsuario.CLIENTE Then
            PanelEmpleado.Visible = False
        ElseIf AgregarComo = TipoUsuario.EMPLEADO Then
            PanelCliente.Visible = False
        End If

        CbxSucursal.DataSource = Database.GetInstance.Sucursales.Lista()
        CbxSucursal.DisplayMember = "nombre"
        CbxSucursal.ValueMember = "cod_suc"
        CbxSucursal.SelectedIndex = 0
        CbxRol.SelectedIndex = 0
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If AgregarComo = TipoUsuario.CLIENTE Then
                If MsgBox("¿Esta seguro de registrar el usuario como cliente?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim dmlCli As New DmlCliente
                    dmlCli.SetData(AtributoPersona.CI, CIUsuario)
                    dmlCli.SetData(AtributoCliente.CORREO, TbxCorreo.Text)
                    dmlCli.SetData(AtributoCliente.ESTADO, EstadoDatos.ACTIVO)
                    If Database.GetInstance.DML(dmlCli.DmlInsert) Then
                        MsgBox("Cliente registrado", MsgBoxStyle.Information)
                        resp = True
                    Else
                        MsgBox("No registrado, el usuario ya existe como cliente", MsgBoxStyle.Exclamation)
                    End If
                End If
            ElseIf AgregarComo = TipoUsuario.EMPLEADO Then
                If MsgBox("¿Esta seguro de registrar el usuario como empleado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim dmlEmp As New DmlEmpleado
                    dmlEmp.SetData(AtributoPersona.CI, CIUsuario)
                    dmlEmp.SetData(AtributoEmpleado.COD_SUCURSAL, CbxSucursal.SelectedValue)
                    Dim rolSelec As RolEmpleado
                    If CbxRol.Text = "Agente" Then
                        rolSelec = RolEmpleado.AGENTE
                    ElseIf CbxRol.Text = "Gerente" Then
                        rolSelec = RolEmpleado.GERENTE
                    End If
                    dmlEmp.SetData(AtributoEmpleado.ROL, rolSelec)
                    dmlEmp.SetData(AtributoEmpleado.PASSWORD, TbxPasswd.Text)
                    dmlEmp.SetData(AtributoEmpleado.ESTADO, EstadoDatos.ACTIVO)
                    If Database.GetInstance.DML(dmlEmp.DmlInsert) Then
                        MsgBox("Empleado registrado", MsgBoxStyle.Information)
                        resp = True
                        Close()
                    Else
                        MsgBox("No registrado, el usuario ya existe como empleado", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If

        Catch ex As CustomException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class