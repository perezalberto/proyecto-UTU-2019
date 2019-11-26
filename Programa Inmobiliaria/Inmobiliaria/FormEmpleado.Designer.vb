<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmpleado
    Inherits Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmpleado))
        Me.TopBar = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMaxRest = New System.Windows.Forms.Button()
        Me.lvlTopBarText = New System.Windows.Forms.Label()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.tlpClientes = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.chbClientesMostrarDeshabilitados = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel23 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.tbxClientesCorreo = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.chbClientesBuscarPorCorreo = New System.Windows.Forms.CheckBox()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.btnClientesAgregarAEmpleado = New System.Windows.Forms.Button()
        Me.btnClientesEditar = New System.Windows.Forms.Button()
        Me.btnClientesRegistro = New System.Windows.Forms.Button()
        Me.btnClientesDeshabilitar = New System.Windows.Forms.Button()
        Me.btnClientesBuscar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel25 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.tbxClientesApellido = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tbxClientesNombre = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.mtbClientesCi = New System.Windows.Forms.MaskedTextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.chbClientesBuscarPorCI = New System.Windows.Forms.CheckBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.tlpEmpleados = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.chbEmpleadosMostrarDeshabilitados = New System.Windows.Forms.CheckBox()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.btnEmpleadosAgregarACliente = New System.Windows.Forms.Button()
        Me.btnEmpleadosEditar = New System.Windows.Forms.Button()
        Me.btnEmpleadosRegistro = New System.Windows.Forms.Button()
        Me.btnEmpleadosDeshabilitar = New System.Windows.Forms.Button()
        Me.btnEmpleadosBuscar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel22 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.cbxEmpleadosSucursal = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.chbEmpleadosBuscarPorSucursal = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.tbxEmpleadosApellido = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbxEmpleadosNombre = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.mtbEmpleadosCi = New System.Windows.Forms.MaskedTextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chbEmpleadosBuscarPorCi = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.tlpPropiedades = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPropiedadBuscar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel20 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPropiedadPorUbic = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbxPropiedadLoc = New System.Windows.Forms.ComboBox()
        Me.cbxPropiedadDepart = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel21 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPropiedadPorTipo = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbxPropiedadTipo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPropiedadPorOperac = New System.Windows.Forms.CheckBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.cbxPropiedadOperac = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPropiedadPorHabs = New System.Windows.Forms.CheckBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.nudPropiedadMaxHabs = New System.Windows.Forms.NumericUpDown()
        Me.nudPropiedadMinHabs = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPropiedadPorMts2 = New System.Windows.Forms.CheckBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.nudPropiedadMaxMts2 = New System.Windows.Forms.NumericUpDown()
        Me.nudPropiedadMinMts2 = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.nudPropiedadMaxPrecio = New System.Windows.Forms.NumericUpDown()
        Me.nudPropiedadMinPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chbPropiedadPorPrecio = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbxPropiedadImagen = New System.Windows.Forms.PictureBox()
        Me.tlpPropiedadHerramientas = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPropiedadAgregar = New System.Windows.Forms.Button()
        Me.btnPropiedadEliminar = New System.Windows.Forms.Button()
        Me.btnPropiedadEditar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPropiedades = New System.Windows.Forms.DataGridView()
        Me.tlpVisitasModificadas = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvModificadas = New System.Windows.Forms.DataGridView()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnModifBuscar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tbxModifClienteApellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxModifClienteNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mtbModifCiCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chbModifPorCliente = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.dtpModifFechaMax = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpModifFechaMin = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chbModifPorFecha = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tlpVisitasCanceladas = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvCanceladas = New System.Windows.Forms.DataGridView()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelBuscar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbxCancelClienteApellido = New System.Windows.Forms.TextBox()
        Me.tbxCancelClienteNombre = New System.Windows.Forms.TextBox()
        Me.mtbCancelCiCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.chbCancelPorCliente = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel18 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.dtpCancelFechMax = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpCancelFechMin = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.chbCancelPorFecha = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TlpVisitasAsignadas = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel24 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnVisitasAsignadasVer = New System.Windows.Forms.Button()
        Me.TableLayoutPanel26 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnVisitasAsignadasCancelar = New System.Windows.Forms.Button()
        Me.BtnVisitasAsignadasEditar = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel27 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.RbtVisitasAsignadasDia = New System.Windows.Forms.RadioButton()
        Me.RbtVisitasAsignadas7Dias = New System.Windows.Forms.RadioButton()
        Me.RbtVisitasAsignadas30Dias = New System.Windows.Forms.RadioButton()
        Me.RbtVisitasAsignadasTodas = New System.Windows.Forms.RadioButton()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.DgvVisitasAsignadas = New System.Windows.Forms.DataGridView()
        Me.tlpAgenda = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgendaAceptarVisita = New System.Windows.Forms.Button()
        Me.btnAgendaVerVisita = New System.Windows.Forms.Button()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgendaCancelVisita = New System.Windows.Forms.Button()
        Me.btnAgendaModifVisita = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgendaBuscar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbxAgendaApellCliente = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbxAgendaNomCliente = New System.Windows.Forms.TextBox()
        Me.mtbAgendaCiCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chbAgendaPorUsuario = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.dtpAgendaFechaMax = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpAgendaFechaMin = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.chbAgendaPorFecha = New System.Windows.Forms.CheckBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.DgvAgenda = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lmbPropiedades = New Inmobiliaria.ListMenuButton()
        Me.lmbAgenda = New Inmobiliaria.ListMenuButton()
        Me.LmbVisitasAsignadas = New Inmobiliaria.ListMenuButton()
        Me.lmbVisitasModificadas = New Inmobiliaria.ListMenuButton()
        Me.lmbVisitasCanceladas = New Inmobiliaria.ListMenuButton()
        Me.lmbEmpleados = New Inmobiliaria.ListMenuButton()
        Me.lmbClientes = New Inmobiliaria.ListMenuButton()
        Me.WindowAction = New Inmobiliaria.WindowAction()
        Me.TopBar.SuspendLayout()
        Me.panelContenido.SuspendLayout()
        Me.tlpClientes.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.TableLayoutPanel23.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.TableLayoutPanel25.SuspendLayout()
        Me.Panel26.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpEmpleados.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.TableLayoutPanel22.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPropiedades.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel20.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel21.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.nudPropiedadMaxHabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPropiedadMinHabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.nudPropiedadMaxMts2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPropiedadMinMts2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.nudPropiedadMaxPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPropiedadMinPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPropiedadImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPropiedadHerramientas.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgvPropiedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpVisitasModificadas.SuspendLayout()
        CType(Me.dgvModificadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel19.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.tlpVisitasCanceladas.SuspendLayout()
        CType(Me.dgvCanceladas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel17.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.TableLayoutPanel18.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.TlpVisitasAsignadas.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.TableLayoutPanel24.SuspendLayout()
        Me.TableLayoutPanel26.SuspendLayout()
        Me.TableLayoutPanel27.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        CType(Me.DgvVisitasAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpAgenda.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.DgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopBar
        '
        Me.TopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.TopBar.ColumnCount = 5
        Me.TopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TopBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TopBar.Controls.Add(Me.btnMinimize, 2, 0)
        Me.TopBar.Controls.Add(Me.btnBack, 0, 0)
        Me.TopBar.Controls.Add(Me.btnClose, 4, 0)
        Me.TopBar.Controls.Add(Me.btnMaxRest, 3, 0)
        Me.TopBar.Controls.Add(Me.lvlTopBarText, 1, 0)
        Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBar.Location = New System.Drawing.Point(1, 1)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.RowCount = 1
        Me.TopBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopBar.Size = New System.Drawing.Size(1248, 40)
        Me.TopBar.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.Inmobiliaria.My.Resources.Resources.icons8_Subtract_16px
        Me.btnMinimize.Location = New System.Drawing.Point(1128, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimize.TabIndex = 6
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = Global.Inmobiliaria.My.Resources.Resources.left_arrow_white
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 40)
        Me.btnBack.TabIndex = 0
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Inmobiliaria.My.Resources.Resources.delete
        Me.btnClose.Location = New System.Drawing.Point(1208, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 8
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMaxRest
        '
        Me.btnMaxRest.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnMaxRest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaxRest.FlatAppearance.BorderSize = 0
        Me.btnMaxRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaxRest.Image = Global.Inmobiliaria.My.Resources.Resources.arrow_up_white
        Me.btnMaxRest.Location = New System.Drawing.Point(1168, 0)
        Me.btnMaxRest.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMaxRest.Name = "btnMaxRest"
        Me.btnMaxRest.Size = New System.Drawing.Size(40, 40)
        Me.btnMaxRest.TabIndex = 7
        Me.btnMaxRest.UseVisualStyleBackColor = False
        '
        'lvlTopBarText
        '
        Me.lvlTopBarText.AutoSize = True
        Me.lvlTopBarText.BackColor = System.Drawing.Color.Transparent
        Me.lvlTopBarText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvlTopBarText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlTopBarText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lvlTopBarText.Location = New System.Drawing.Point(43, 0)
        Me.lvlTopBarText.Name = "lvlTopBarText"
        Me.lvlTopBarText.Padding = New System.Windows.Forms.Padding(10)
        Me.lvlTopBarText.Size = New System.Drawing.Size(1082, 40)
        Me.lvlTopBarText.TabIndex = 5
        Me.lvlTopBarText.Text = "Empleado"
        Me.lvlTopBarText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelContenido
        '
        Me.panelContenido.Controls.Add(Me.tlpPropiedades)
        Me.panelContenido.Controls.Add(Me.tlpVisitasModificadas)
        Me.panelContenido.Controls.Add(Me.tlpVisitasCanceladas)
        Me.panelContenido.Controls.Add(Me.TlpVisitasAsignadas)
        Me.panelContenido.Controls.Add(Me.tlpAgenda)
        Me.panelContenido.Controls.Add(Me.tlpClientes)
        Me.panelContenido.Controls.Add(Me.tlpEmpleados)
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(225, 41)
        Me.panelContenido.Margin = New System.Windows.Forms.Padding(0)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(1024, 598)
        Me.panelContenido.TabIndex = 3
        '
        'tlpClientes
        '
        Me.tlpClientes.BackColor = System.Drawing.Color.White
        Me.tlpClientes.ColumnCount = 2
        Me.tlpClientes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpClientes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.tlpClientes.Controls.Add(Me.Panel23, 1, 0)
        Me.tlpClientes.Controls.Add(Me.dgvClientes, 0, 0)
        Me.tlpClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpClientes.Location = New System.Drawing.Point(0, 0)
        Me.tlpClientes.Name = "tlpClientes"
        Me.tlpClientes.RowCount = 1
        Me.tlpClientes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpClientes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 598.0!))
        Me.tlpClientes.Size = New System.Drawing.Size(1024, 598)
        Me.tlpClientes.TabIndex = 9
        '
        'Panel23
        '
        Me.Panel23.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel23.BackColor = System.Drawing.SystemColors.Control
        Me.Panel23.Controls.Add(Me.chbClientesMostrarDeshabilitados)
        Me.Panel23.Controls.Add(Me.TableLayoutPanel23)
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Controls.Add(Me.btnClientesBuscar)
        Me.Panel23.Controls.Add(Me.TableLayoutPanel25)
        Me.Panel23.Controls.Add(Me.Label40)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel23.Location = New System.Drawing.Point(674, 0)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(350, 598)
        Me.Panel23.TabIndex = 1
        '
        'chbClientesMostrarDeshabilitados
        '
        Me.chbClientesMostrarDeshabilitados.BackColor = System.Drawing.Color.LightGray
        Me.chbClientesMostrarDeshabilitados.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbClientesMostrarDeshabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbClientesMostrarDeshabilitados.Location = New System.Drawing.Point(6, 266)
        Me.chbClientesMostrarDeshabilitados.Margin = New System.Windows.Forms.Padding(0)
        Me.chbClientesMostrarDeshabilitados.Name = "chbClientesMostrarDeshabilitados"
        Me.chbClientesMostrarDeshabilitados.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbClientesMostrarDeshabilitados.Size = New System.Drawing.Size(338, 30)
        Me.chbClientesMostrarDeshabilitados.TabIndex = 15
        Me.chbClientesMostrarDeshabilitados.Text = "Mostrar clientes deshabilitados"
        Me.chbClientesMostrarDeshabilitados.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel23
        '
        Me.TableLayoutPanel23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel23.ColumnCount = 1
        Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel23.Controls.Add(Me.Panel25, 0, 1)
        Me.TableLayoutPanel23.Controls.Add(Me.chbClientesBuscarPorCorreo, 0, 0)
        Me.TableLayoutPanel23.Location = New System.Drawing.Point(6, 182)
        Me.TableLayoutPanel23.Name = "TableLayoutPanel23"
        Me.TableLayoutPanel23.RowCount = 2
        Me.TableLayoutPanel23.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel23.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel23.Size = New System.Drawing.Size(338, 78)
        Me.TableLayoutPanel23.TabIndex = 14
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.tbxClientesCorreo)
        Me.Panel25.Controls.Add(Me.Label35)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel25.Location = New System.Drawing.Point(3, 33)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(332, 42)
        Me.Panel25.TabIndex = 1
        '
        'tbxClientesCorreo
        '
        Me.tbxClientesCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxClientesCorreo.Location = New System.Drawing.Point(58, 10)
        Me.tbxClientesCorreo.Name = "tbxClientesCorreo"
        Me.tbxClientesCorreo.Size = New System.Drawing.Size(266, 22)
        Me.tbxClientesCorreo.TabIndex = 7
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(9, 13)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(49, 16)
        Me.Label35.TabIndex = 6
        Me.Label35.Text = "Correo"
        '
        'chbClientesBuscarPorCorreo
        '
        Me.chbClientesBuscarPorCorreo.AutoSize = True
        Me.chbClientesBuscarPorCorreo.BackColor = System.Drawing.Color.LightGray
        Me.chbClientesBuscarPorCorreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbClientesBuscarPorCorreo.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbClientesBuscarPorCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbClientesBuscarPorCorreo.Location = New System.Drawing.Point(0, 0)
        Me.chbClientesBuscarPorCorreo.Margin = New System.Windows.Forms.Padding(0)
        Me.chbClientesBuscarPorCorreo.Name = "chbClientesBuscarPorCorreo"
        Me.chbClientesBuscarPorCorreo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbClientesBuscarPorCorreo.Size = New System.Drawing.Size(338, 30)
        Me.chbClientesBuscarPorCorreo.TabIndex = 2
        Me.chbClientesBuscarPorCorreo.Text = "Buscar por Correo"
        Me.chbClientesBuscarPorCorreo.UseVisualStyleBackColor = False
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.btnClientesAgregarAEmpleado)
        Me.Panel24.Controls.Add(Me.btnClientesEditar)
        Me.Panel24.Controls.Add(Me.btnClientesRegistro)
        Me.Panel24.Controls.Add(Me.btnClientesDeshabilitar)
        Me.Panel24.Location = New System.Drawing.Point(0, 371)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(350, 190)
        Me.Panel24.TabIndex = 13
        '
        'btnClientesAgregarAEmpleado
        '
        Me.btnClientesAgregarAEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClientesAgregarAEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientesAgregarAEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientesAgregarAEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnClientesAgregarAEmpleado.Image = Global.Inmobiliaria.My.Resources.Resources.plus_green
        Me.btnClientesAgregarAEmpleado.Location = New System.Drawing.Point(6, 138)
        Me.btnClientesAgregarAEmpleado.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClientesAgregarAEmpleado.Name = "btnClientesAgregarAEmpleado"
        Me.btnClientesAgregarAEmpleado.Size = New System.Drawing.Size(338, 38)
        Me.btnClientesAgregarAEmpleado.TabIndex = 17
        Me.btnClientesAgregarAEmpleado.Text = "AGREGAR SELECCIONADO A EMPLEADOS"
        Me.btnClientesAgregarAEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientesAgregarAEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientesAgregarAEmpleado.UseVisualStyleBackColor = True
        '
        'btnClientesEditar
        '
        Me.btnClientesEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnClientesEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientesEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientesEditar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnClientesEditar.Image = Global.Inmobiliaria.My.Resources.Resources.edit_blue
        Me.btnClientesEditar.Location = New System.Drawing.Point(6, 50)
        Me.btnClientesEditar.Name = "btnClientesEditar"
        Me.btnClientesEditar.Size = New System.Drawing.Size(338, 38)
        Me.btnClientesEditar.TabIndex = 16
        Me.btnClientesEditar.Text = "EDITAR CLIENTE"
        Me.btnClientesEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientesEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientesEditar.UseVisualStyleBackColor = True
        '
        'btnClientesRegistro
        '
        Me.btnClientesRegistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClientesRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientesRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientesRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnClientesRegistro.Image = Global.Inmobiliaria.My.Resources.Resources.plus_green
        Me.btnClientesRegistro.Location = New System.Drawing.Point(6, 94)
        Me.btnClientesRegistro.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClientesRegistro.Name = "btnClientesRegistro"
        Me.btnClientesRegistro.Size = New System.Drawing.Size(338, 38)
        Me.btnClientesRegistro.TabIndex = 10
        Me.btnClientesRegistro.Text = "NUEVO CLIENTE"
        Me.btnClientesRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientesRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientesRegistro.UseVisualStyleBackColor = True
        '
        'btnClientesDeshabilitar
        '
        Me.btnClientesDeshabilitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnClientesDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientesDeshabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientesDeshabilitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnClientesDeshabilitar.Image = Global.Inmobiliaria.My.Resources.Resources.delete_red
        Me.btnClientesDeshabilitar.Location = New System.Drawing.Point(6, 6)
        Me.btnClientesDeshabilitar.Name = "btnClientesDeshabilitar"
        Me.btnClientesDeshabilitar.Size = New System.Drawing.Size(338, 38)
        Me.btnClientesDeshabilitar.TabIndex = 7
        Me.btnClientesDeshabilitar.Text = "DESHABILITAR CLIENTE"
        Me.btnClientesDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientesDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientesDeshabilitar.UseVisualStyleBackColor = True
        '
        'btnClientesBuscar
        '
        Me.btnClientesBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClientesBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientesBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientesBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClientesBuscar.Location = New System.Drawing.Point(6, 305)
        Me.btnClientesBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClientesBuscar.Name = "btnClientesBuscar"
        Me.btnClientesBuscar.Size = New System.Drawing.Size(338, 38)
        Me.btnClientesBuscar.TabIndex = 12
        Me.btnClientesBuscar.Text = "BUSCAR"
        Me.btnClientesBuscar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel25
        '
        Me.TableLayoutPanel25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel25.ColumnCount = 1
        Me.TableLayoutPanel25.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel25.Controls.Add(Me.Panel26, 0, 1)
        Me.TableLayoutPanel25.Controls.Add(Me.chbClientesBuscarPorCI, 0, 0)
        Me.TableLayoutPanel25.Location = New System.Drawing.Point(6, 45)
        Me.TableLayoutPanel25.Name = "TableLayoutPanel25"
        Me.TableLayoutPanel25.RowCount = 2
        Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel25.Size = New System.Drawing.Size(338, 131)
        Me.TableLayoutPanel25.TabIndex = 10
        '
        'Panel26
        '
        Me.Panel26.Controls.Add(Me.tbxClientesApellido)
        Me.Panel26.Controls.Add(Me.Label36)
        Me.Panel26.Controls.Add(Me.tbxClientesNombre)
        Me.Panel26.Controls.Add(Me.Label38)
        Me.Panel26.Controls.Add(Me.mtbClientesCi)
        Me.Panel26.Controls.Add(Me.Label39)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel26.Location = New System.Drawing.Point(3, 33)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(332, 95)
        Me.Panel26.TabIndex = 1
        '
        'tbxClientesApellido
        '
        Me.tbxClientesApellido.Enabled = False
        Me.tbxClientesApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxClientesApellido.Location = New System.Drawing.Point(96, 64)
        Me.tbxClientesApellido.Name = "tbxClientesApellido"
        Me.tbxClientesApellido.Size = New System.Drawing.Size(228, 22)
        Me.tbxClientesApellido.TabIndex = 7
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(33, 67)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(58, 16)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Apellido"
        '
        'tbxClientesNombre
        '
        Me.tbxClientesNombre.Enabled = False
        Me.tbxClientesNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxClientesNombre.Location = New System.Drawing.Point(96, 36)
        Me.tbxClientesNombre.Name = "tbxClientesNombre"
        Me.tbxClientesNombre.Size = New System.Drawing.Size(228, 22)
        Me.tbxClientesNombre.TabIndex = 5
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(34, 39)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(57, 16)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "Nombre"
        '
        'mtbClientesCi
        '
        Me.mtbClientesCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbClientesCi.Location = New System.Drawing.Point(96, 7)
        Me.mtbClientesCi.Mask = "0000000-0"
        Me.mtbClientesCi.Name = "mtbClientesCi"
        Me.mtbClientesCi.Size = New System.Drawing.Size(228, 22)
        Me.mtbClientesCi.TabIndex = 3
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(10, 10)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(81, 16)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "CI de cliente"
        '
        'chbClientesBuscarPorCI
        '
        Me.chbClientesBuscarPorCI.AutoSize = True
        Me.chbClientesBuscarPorCI.BackColor = System.Drawing.Color.LightGray
        Me.chbClientesBuscarPorCI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbClientesBuscarPorCI.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbClientesBuscarPorCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbClientesBuscarPorCI.Location = New System.Drawing.Point(0, 0)
        Me.chbClientesBuscarPorCI.Margin = New System.Windows.Forms.Padding(0)
        Me.chbClientesBuscarPorCI.Name = "chbClientesBuscarPorCI"
        Me.chbClientesBuscarPorCI.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbClientesBuscarPorCI.Size = New System.Drawing.Size(338, 30)
        Me.chbClientesBuscarPorCI.TabIndex = 2
        Me.chbClientesBuscarPorCI.Text = "Buscar por CI"
        Me.chbClientesBuscarPorCI.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(0, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Padding = New System.Windows.Forms.Padding(10)
        Me.Label40.Size = New System.Drawing.Size(350, 40)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Buscar cliente"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClientes.Location = New System.Drawing.Point(0, 0)
        Me.dgvClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(674, 598)
        Me.dgvClientes.TabIndex = 5
        '
        'tlpEmpleados
        '
        Me.tlpEmpleados.BackColor = System.Drawing.Color.White
        Me.tlpEmpleados.ColumnCount = 2
        Me.tlpEmpleados.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEmpleados.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.tlpEmpleados.Controls.Add(Me.Panel8, 1, 0)
        Me.tlpEmpleados.Controls.Add(Me.dgvEmpleados, 0, 0)
        Me.tlpEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.tlpEmpleados.Name = "tlpEmpleados"
        Me.tlpEmpleados.RowCount = 1
        Me.tlpEmpleados.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpEmpleados.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 598.0!))
        Me.tlpEmpleados.Size = New System.Drawing.Size(1024, 598)
        Me.tlpEmpleados.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Controls.Add(Me.chbEmpleadosMostrarDeshabilitados)
        Me.Panel8.Controls.Add(Me.Panel22)
        Me.Panel8.Controls.Add(Me.btnEmpleadosBuscar)
        Me.Panel8.Controls.Add(Me.TableLayoutPanel22)
        Me.Panel8.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel8.Controls.Add(Me.Label24)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(674, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(350, 598)
        Me.Panel8.TabIndex = 1
        '
        'chbEmpleadosMostrarDeshabilitados
        '
        Me.chbEmpleadosMostrarDeshabilitados.BackColor = System.Drawing.Color.LightGray
        Me.chbEmpleadosMostrarDeshabilitados.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbEmpleadosMostrarDeshabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEmpleadosMostrarDeshabilitados.Location = New System.Drawing.Point(6, 265)
        Me.chbEmpleadosMostrarDeshabilitados.Margin = New System.Windows.Forms.Padding(0)
        Me.chbEmpleadosMostrarDeshabilitados.Name = "chbEmpleadosMostrarDeshabilitados"
        Me.chbEmpleadosMostrarDeshabilitados.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbEmpleadosMostrarDeshabilitados.Size = New System.Drawing.Size(338, 30)
        Me.chbEmpleadosMostrarDeshabilitados.TabIndex = 14
        Me.chbEmpleadosMostrarDeshabilitados.Text = "Mostrar los empleados deshabilitados"
        Me.chbEmpleadosMostrarDeshabilitados.UseVisualStyleBackColor = False
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.btnEmpleadosAgregarACliente)
        Me.Panel22.Controls.Add(Me.btnEmpleadosEditar)
        Me.Panel22.Controls.Add(Me.btnEmpleadosRegistro)
        Me.Panel22.Controls.Add(Me.btnEmpleadosDeshabilitar)
        Me.Panel22.Location = New System.Drawing.Point(0, 371)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(350, 187)
        Me.Panel22.TabIndex = 13
        '
        'btnEmpleadosAgregarACliente
        '
        Me.btnEmpleadosAgregarACliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnEmpleadosAgregarACliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleadosAgregarACliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleadosAgregarACliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnEmpleadosAgregarACliente.Image = Global.Inmobiliaria.My.Resources.Resources.plus_green
        Me.btnEmpleadosAgregarACliente.Location = New System.Drawing.Point(6, 138)
        Me.btnEmpleadosAgregarACliente.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEmpleadosAgregarACliente.Name = "btnEmpleadosAgregarACliente"
        Me.btnEmpleadosAgregarACliente.Size = New System.Drawing.Size(338, 38)
        Me.btnEmpleadosAgregarACliente.TabIndex = 14
        Me.btnEmpleadosAgregarACliente.Text = "AGREGAR SELECCIONADO A CLIENTES"
        Me.btnEmpleadosAgregarACliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleadosAgregarACliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleadosAgregarACliente.UseVisualStyleBackColor = True
        '
        'btnEmpleadosEditar
        '
        Me.btnEmpleadosEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnEmpleadosEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleadosEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleadosEditar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEmpleadosEditar.Image = Global.Inmobiliaria.My.Resources.Resources.edit_blue
        Me.btnEmpleadosEditar.Location = New System.Drawing.Point(6, 50)
        Me.btnEmpleadosEditar.Name = "btnEmpleadosEditar"
        Me.btnEmpleadosEditar.Size = New System.Drawing.Size(338, 38)
        Me.btnEmpleadosEditar.TabIndex = 13
        Me.btnEmpleadosEditar.Text = "EDITAR EMPLEADO"
        Me.btnEmpleadosEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleadosEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleadosEditar.UseVisualStyleBackColor = True
        '
        'btnEmpleadosRegistro
        '
        Me.btnEmpleadosRegistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnEmpleadosRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleadosRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleadosRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnEmpleadosRegistro.Image = Global.Inmobiliaria.My.Resources.Resources.plus_green
        Me.btnEmpleadosRegistro.Location = New System.Drawing.Point(6, 94)
        Me.btnEmpleadosRegistro.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEmpleadosRegistro.Name = "btnEmpleadosRegistro"
        Me.btnEmpleadosRegistro.Size = New System.Drawing.Size(338, 38)
        Me.btnEmpleadosRegistro.TabIndex = 12
        Me.btnEmpleadosRegistro.Text = "REGISTRAR NUEVO EMPLEADO"
        Me.btnEmpleadosRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleadosRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleadosRegistro.UseVisualStyleBackColor = True
        '
        'btnEmpleadosDeshabilitar
        '
        Me.btnEmpleadosDeshabilitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnEmpleadosDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleadosDeshabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleadosDeshabilitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnEmpleadosDeshabilitar.Image = Global.Inmobiliaria.My.Resources.Resources.delete_red
        Me.btnEmpleadosDeshabilitar.Location = New System.Drawing.Point(6, 6)
        Me.btnEmpleadosDeshabilitar.Name = "btnEmpleadosDeshabilitar"
        Me.btnEmpleadosDeshabilitar.Size = New System.Drawing.Size(338, 38)
        Me.btnEmpleadosDeshabilitar.TabIndex = 11
        Me.btnEmpleadosDeshabilitar.Text = "DESHABILITAR EMPLEADO"
        Me.btnEmpleadosDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleadosDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleadosDeshabilitar.UseVisualStyleBackColor = True
        '
        'btnEmpleadosBuscar
        '
        Me.btnEmpleadosBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEmpleadosBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleadosBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleadosBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEmpleadosBuscar.Location = New System.Drawing.Point(6, 304)
        Me.btnEmpleadosBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEmpleadosBuscar.Name = "btnEmpleadosBuscar"
        Me.btnEmpleadosBuscar.Size = New System.Drawing.Size(338, 38)
        Me.btnEmpleadosBuscar.TabIndex = 12
        Me.btnEmpleadosBuscar.Text = "BUSCAR"
        Me.btnEmpleadosBuscar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel22
        '
        Me.TableLayoutPanel22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel22.ColumnCount = 1
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel22.Controls.Add(Me.Panel20, 0, 1)
        Me.TableLayoutPanel22.Controls.Add(Me.chbEmpleadosBuscarPorSucursal, 0, 0)
        Me.TableLayoutPanel22.Location = New System.Drawing.Point(6, 183)
        Me.TableLayoutPanel22.Name = "TableLayoutPanel22"
        Me.TableLayoutPanel22.RowCount = 2
        Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel22.Size = New System.Drawing.Size(338, 75)
        Me.TableLayoutPanel22.TabIndex = 11
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.cbxEmpleadosSucursal)
        Me.Panel20.Controls.Add(Me.Label37)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel20.Location = New System.Drawing.Point(3, 33)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(332, 39)
        Me.Panel20.TabIndex = 1
        '
        'cbxEmpleadosSucursal
        '
        Me.cbxEmpleadosSucursal.FormattingEnabled = True
        Me.cbxEmpleadosSucursal.Location = New System.Drawing.Point(72, 9)
        Me.cbxEmpleadosSucursal.Name = "cbxEmpleadosSucursal"
        Me.cbxEmpleadosSucursal.Size = New System.Drawing.Size(252, 21)
        Me.cbxEmpleadosSucursal.TabIndex = 3
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(9, 10)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(57, 16)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Nombre"
        '
        'chbEmpleadosBuscarPorSucursal
        '
        Me.chbEmpleadosBuscarPorSucursal.AutoSize = True
        Me.chbEmpleadosBuscarPorSucursal.BackColor = System.Drawing.Color.LightGray
        Me.chbEmpleadosBuscarPorSucursal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbEmpleadosBuscarPorSucursal.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbEmpleadosBuscarPorSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEmpleadosBuscarPorSucursal.Location = New System.Drawing.Point(0, 0)
        Me.chbEmpleadosBuscarPorSucursal.Margin = New System.Windows.Forms.Padding(0)
        Me.chbEmpleadosBuscarPorSucursal.Name = "chbEmpleadosBuscarPorSucursal"
        Me.chbEmpleadosBuscarPorSucursal.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbEmpleadosBuscarPorSucursal.Size = New System.Drawing.Size(338, 30)
        Me.chbEmpleadosBuscarPorSucursal.TabIndex = 2
        Me.chbEmpleadosBuscarPorSucursal.Text = "Buscar por sucursal"
        Me.chbEmpleadosBuscarPorSucursal.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel19, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.chbEmpleadosBuscarPorCi, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 45)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(338, 131)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.tbxEmpleadosApellido)
        Me.Panel19.Controls.Add(Me.Label25)
        Me.Panel19.Controls.Add(Me.tbxEmpleadosNombre)
        Me.Panel19.Controls.Add(Me.Label30)
        Me.Panel19.Controls.Add(Me.mtbEmpleadosCi)
        Me.Panel19.Controls.Add(Me.Label32)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(3, 33)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(332, 95)
        Me.Panel19.TabIndex = 1
        '
        'tbxEmpleadosApellido
        '
        Me.tbxEmpleadosApellido.Enabled = False
        Me.tbxEmpleadosApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEmpleadosApellido.Location = New System.Drawing.Point(119, 64)
        Me.tbxEmpleadosApellido.Name = "tbxEmpleadosApellido"
        Me.tbxEmpleadosApellido.Size = New System.Drawing.Size(205, 22)
        Me.tbxEmpleadosApellido.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(55, 67)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 16)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Apellido"
        '
        'tbxEmpleadosNombre
        '
        Me.tbxEmpleadosNombre.Enabled = False
        Me.tbxEmpleadosNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEmpleadosNombre.Location = New System.Drawing.Point(119, 36)
        Me.tbxEmpleadosNombre.Name = "tbxEmpleadosNombre"
        Me.tbxEmpleadosNombre.Size = New System.Drawing.Size(205, 22)
        Me.tbxEmpleadosNombre.TabIndex = 5
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(56, 39)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(57, 16)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Nombre"
        '
        'mtbEmpleadosCi
        '
        Me.mtbEmpleadosCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbEmpleadosCi.Location = New System.Drawing.Point(119, 7)
        Me.mtbEmpleadosCi.Mask = "0000000-0"
        Me.mtbEmpleadosCi.Name = "mtbEmpleadosCi"
        Me.mtbEmpleadosCi.Size = New System.Drawing.Size(205, 22)
        Me.mtbEmpleadosCi.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(9, 10)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 16)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "CI de empleado"
        '
        'chbEmpleadosBuscarPorCi
        '
        Me.chbEmpleadosBuscarPorCi.AutoSize = True
        Me.chbEmpleadosBuscarPorCi.BackColor = System.Drawing.Color.LightGray
        Me.chbEmpleadosBuscarPorCi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbEmpleadosBuscarPorCi.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbEmpleadosBuscarPorCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEmpleadosBuscarPorCi.Location = New System.Drawing.Point(0, 0)
        Me.chbEmpleadosBuscarPorCi.Margin = New System.Windows.Forms.Padding(0)
        Me.chbEmpleadosBuscarPorCi.Name = "chbEmpleadosBuscarPorCi"
        Me.chbEmpleadosBuscarPorCi.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbEmpleadosBuscarPorCi.Size = New System.Drawing.Size(338, 30)
        Me.chbEmpleadosBuscarPorCi.TabIndex = 2
        Me.chbEmpleadosBuscarPorCi.Text = "Buscar por CI"
        Me.chbEmpleadosBuscarPorCi.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(0, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Padding = New System.Windows.Forms.Padding(10)
        Me.Label24.Size = New System.Drawing.Size(350, 40)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Buscar empleado"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.dgvEmpleados.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvEmpleados.MultiSelect = False
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(674, 598)
        Me.dgvEmpleados.TabIndex = 5
        '
        'tlpPropiedades
        '
        Me.tlpPropiedades.BackColor = System.Drawing.Color.White
        Me.tlpPropiedades.ColumnCount = 2
        Me.tlpPropiedades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPropiedades.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.tlpPropiedades.Controls.Add(Me.Panel3, 1, 0)
        Me.tlpPropiedades.Controls.Add(Me.dgvPropiedades, 0, 0)
        Me.tlpPropiedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPropiedades.Location = New System.Drawing.Point(0, 0)
        Me.tlpPropiedades.Name = "tlpPropiedades"
        Me.tlpPropiedades.RowCount = 1
        Me.tlpPropiedades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPropiedades.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 598.0!))
        Me.tlpPropiedades.Size = New System.Drawing.Size(1024, 598)
        Me.tlpPropiedades.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Controls.Add(Me.pbxPropiedadImagen)
        Me.Panel3.Controls.Add(Me.tlpPropiedadHerramientas)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(674, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 598)
        Me.Panel3.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnPropiedadBuscar, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 195)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(350, 313)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btnPropiedadBuscar
        '
        Me.btnPropiedadBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPropiedadBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPropiedadBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPropiedadBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPropiedadBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPropiedadBuscar.Location = New System.Drawing.Point(5, 270)
        Me.btnPropiedadBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPropiedadBuscar.Name = "btnPropiedadBuscar"
        Me.btnPropiedadBuscar.Size = New System.Drawing.Size(340, 38)
        Me.btnPropiedadBuscar.TabIndex = 2
        Me.btnPropiedadBuscar.Text = "BUSCAR"
        Me.btnPropiedadBuscar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel20)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel21)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel11)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.TableLayoutPanel7)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 43)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(344, 219)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel20
        '
        Me.TableLayoutPanel20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel20.ColumnCount = 1
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel20.Controls.Add(Me.chbPropiedadPorUbic, 0, 0)
        Me.TableLayoutPanel20.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel20.Location = New System.Drawing.Point(4, 3)
        Me.TableLayoutPanel20.Name = "TableLayoutPanel20"
        Me.TableLayoutPanel20.RowCount = 2
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel20.Size = New System.Drawing.Size(320, 113)
        Me.TableLayoutPanel20.TabIndex = 13
        '
        'chbPropiedadPorUbic
        '
        Me.chbPropiedadPorUbic.AutoSize = True
        Me.chbPropiedadPorUbic.BackColor = System.Drawing.Color.LightGray
        Me.chbPropiedadPorUbic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPropiedadPorUbic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chbPropiedadPorUbic.Location = New System.Drawing.Point(0, 0)
        Me.chbPropiedadPorUbic.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPropiedadPorUbic.Name = "chbPropiedadPorUbic"
        Me.chbPropiedadPorUbic.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPropiedadPorUbic.Size = New System.Drawing.Size(320, 30)
        Me.chbPropiedadPorUbic.TabIndex = 3
        Me.chbPropiedadPorUbic.Text = "Buscar por ubicación"
        Me.chbPropiedadPorUbic.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cbxPropiedadLoc)
        Me.Panel4.Controls.Add(Me.cbxPropiedadDepart)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(314, 77)
        Me.Panel4.TabIndex = 1
        '
        'cbxPropiedadLoc
        '
        Me.cbxPropiedadLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPropiedadLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cbxPropiedadLoc.FormattingEnabled = True
        Me.cbxPropiedadLoc.Location = New System.Drawing.Point(111, 41)
        Me.cbxPropiedadLoc.Name = "cbxPropiedadLoc"
        Me.cbxPropiedadLoc.Size = New System.Drawing.Size(189, 24)
        Me.cbxPropiedadLoc.TabIndex = 1
        '
        'cbxPropiedadDepart
        '
        Me.cbxPropiedadDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPropiedadDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cbxPropiedadDepart.FormattingEnabled = True
        Me.cbxPropiedadDepart.Location = New System.Drawing.Point(110, 11)
        Me.cbxPropiedadDepart.Name = "cbxPropiedadDepart"
        Me.cbxPropiedadDepart.Size = New System.Drawing.Size(189, 24)
        Me.cbxPropiedadDepart.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(37, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Localidad"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label31.Location = New System.Drawing.Point(10, 14)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(94, 16)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Departamento"
        '
        'TableLayoutPanel21
        '
        Me.TableLayoutPanel21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel21.ColumnCount = 1
        Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel21.Controls.Add(Me.chbPropiedadPorTipo, 0, 0)
        Me.TableLayoutPanel21.Controls.Add(Me.Panel5, 0, 1)
        Me.TableLayoutPanel21.Location = New System.Drawing.Point(4, 122)
        Me.TableLayoutPanel21.Name = "TableLayoutPanel21"
        Me.TableLayoutPanel21.RowCount = 2
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel21.Size = New System.Drawing.Size(320, 81)
        Me.TableLayoutPanel21.TabIndex = 12
        '
        'chbPropiedadPorTipo
        '
        Me.chbPropiedadPorTipo.AutoSize = True
        Me.chbPropiedadPorTipo.BackColor = System.Drawing.Color.LightGray
        Me.chbPropiedadPorTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPropiedadPorTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPropiedadPorTipo.Location = New System.Drawing.Point(0, 0)
        Me.chbPropiedadPorTipo.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPropiedadPorTipo.Name = "chbPropiedadPorTipo"
        Me.chbPropiedadPorTipo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPropiedadPorTipo.Size = New System.Drawing.Size(320, 30)
        Me.chbPropiedadPorTipo.TabIndex = 3
        Me.chbPropiedadPorTipo.Text = "Buscar por tipo de propiedad"
        Me.chbPropiedadPorTipo.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cbxPropiedadTipo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 33)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(314, 45)
        Me.Panel5.TabIndex = 1
        '
        'cbxPropiedadTipo
        '
        Me.cbxPropiedadTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPropiedadTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPropiedadTipo.FormattingEnabled = True
        Me.cbxPropiedadTipo.Items.AddRange(New Object() {"Casa", "Apartamento", "Local Comercial"})
        Me.cbxPropiedadTipo.Location = New System.Drawing.Point(16, 11)
        Me.cbxPropiedadTipo.Name = "cbxPropiedadTipo"
        Me.cbxPropiedadTipo.Size = New System.Drawing.Size(285, 24)
        Me.cbxPropiedadTipo.TabIndex = 1
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.chbPropiedadPorOperac, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Panel21, 0, 1)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(4, 209)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(320, 81)
        Me.TableLayoutPanel11.TabIndex = 10
        '
        'chbPropiedadPorOperac
        '
        Me.chbPropiedadPorOperac.AutoSize = True
        Me.chbPropiedadPorOperac.BackColor = System.Drawing.Color.LightGray
        Me.chbPropiedadPorOperac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPropiedadPorOperac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPropiedadPorOperac.Location = New System.Drawing.Point(0, 0)
        Me.chbPropiedadPorOperac.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPropiedadPorOperac.Name = "chbPropiedadPorOperac"
        Me.chbPropiedadPorOperac.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPropiedadPorOperac.Size = New System.Drawing.Size(320, 30)
        Me.chbPropiedadPorOperac.TabIndex = 3
        Me.chbPropiedadPorOperac.Text = "Buscar por operación ( Alquiler / Venta )"
        Me.chbPropiedadPorOperac.UseVisualStyleBackColor = False
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.cbxPropiedadOperac)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(3, 33)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(314, 45)
        Me.Panel21.TabIndex = 1
        '
        'cbxPropiedadOperac
        '
        Me.cbxPropiedadOperac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPropiedadOperac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPropiedadOperac.FormattingEnabled = True
        Me.cbxPropiedadOperac.Items.AddRange(New Object() {"Alquiler", "Venta"})
        Me.cbxPropiedadOperac.Location = New System.Drawing.Point(16, 11)
        Me.cbxPropiedadOperac.Name = "cbxPropiedadOperac"
        Me.cbxPropiedadOperac.Size = New System.Drawing.Size(285, 24)
        Me.cbxPropiedadOperac.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.chbPropiedadPorHabs, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel10, 0, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(4, 296)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(320, 73)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'chbPropiedadPorHabs
        '
        Me.chbPropiedadPorHabs.AutoSize = True
        Me.chbPropiedadPorHabs.BackColor = System.Drawing.Color.LightGray
        Me.chbPropiedadPorHabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPropiedadPorHabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPropiedadPorHabs.Location = New System.Drawing.Point(0, 0)
        Me.chbPropiedadPorHabs.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPropiedadPorHabs.Name = "chbPropiedadPorHabs"
        Me.chbPropiedadPorHabs.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPropiedadPorHabs.Size = New System.Drawing.Size(320, 30)
        Me.chbPropiedadPorHabs.TabIndex = 3
        Me.chbPropiedadPorHabs.Text = "Buscar por número de habitaciones"
        Me.chbPropiedadPorHabs.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.nudPropiedadMaxHabs)
        Me.Panel10.Controls.Add(Me.nudPropiedadMinHabs)
        Me.Panel10.Controls.Add(Me.Label11)
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(3, 33)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(314, 37)
        Me.Panel10.TabIndex = 1
        '
        'nudPropiedadMaxHabs
        '
        Me.nudPropiedadMaxHabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPropiedadMaxHabs.Location = New System.Drawing.Point(216, 8)
        Me.nudPropiedadMaxHabs.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudPropiedadMaxHabs.Name = "nudPropiedadMaxHabs"
        Me.nudPropiedadMaxHabs.Size = New System.Drawing.Size(85, 22)
        Me.nudPropiedadMaxHabs.TabIndex = 7
        '
        'nudPropiedadMinHabs
        '
        Me.nudPropiedadMinHabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPropiedadMinHabs.Location = New System.Drawing.Point(68, 8)
        Me.nudPropiedadMinHabs.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudPropiedadMinHabs.Name = "nudPropiedadMinHabs"
        Me.nudPropiedadMinHabs.Size = New System.Drawing.Size(84, 22)
        Me.nudPropiedadMinHabs.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(166, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Hasta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Desde"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.chbPropiedadPorMts2, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel11, 0, 1)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 375)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(320, 73)
        Me.TableLayoutPanel6.TabIndex = 8
        '
        'chbPropiedadPorMts2
        '
        Me.chbPropiedadPorMts2.AutoSize = True
        Me.chbPropiedadPorMts2.BackColor = System.Drawing.Color.LightGray
        Me.chbPropiedadPorMts2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPropiedadPorMts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPropiedadPorMts2.Location = New System.Drawing.Point(0, 0)
        Me.chbPropiedadPorMts2.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPropiedadPorMts2.Name = "chbPropiedadPorMts2"
        Me.chbPropiedadPorMts2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPropiedadPorMts2.Size = New System.Drawing.Size(320, 30)
        Me.chbPropiedadPorMts2.TabIndex = 3
        Me.chbPropiedadPorMts2.Text = "Buscar por mts²"
        Me.chbPropiedadPorMts2.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.nudPropiedadMaxMts2)
        Me.Panel11.Controls.Add(Me.nudPropiedadMinMts2)
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Controls.Add(Me.Label14)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(3, 33)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(314, 37)
        Me.Panel11.TabIndex = 1
        '
        'nudPropiedadMaxMts2
        '
        Me.nudPropiedadMaxMts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPropiedadMaxMts2.Location = New System.Drawing.Point(216, 8)
        Me.nudPropiedadMaxMts2.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudPropiedadMaxMts2.Name = "nudPropiedadMaxMts2"
        Me.nudPropiedadMaxMts2.Size = New System.Drawing.Size(85, 22)
        Me.nudPropiedadMaxMts2.TabIndex = 7
        '
        'nudPropiedadMinMts2
        '
        Me.nudPropiedadMinMts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPropiedadMinMts2.Location = New System.Drawing.Point(68, 8)
        Me.nudPropiedadMinMts2.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudPropiedadMinMts2.Name = "nudPropiedadMinMts2"
        Me.nudPropiedadMinMts2.Size = New System.Drawing.Size(84, 22)
        Me.nudPropiedadMinMts2.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(166, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Hasta"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Desde"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Panel12, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.chbPropiedadPorPrecio, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(4, 454)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(320, 75)
        Me.TableLayoutPanel7.TabIndex = 9
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.nudPropiedadMaxPrecio)
        Me.Panel12.Controls.Add(Me.nudPropiedadMinPrecio)
        Me.Panel12.Controls.Add(Me.Label16)
        Me.Panel12.Controls.Add(Me.Label17)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(3, 33)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(314, 39)
        Me.Panel12.TabIndex = 1
        '
        'nudPropiedadMaxPrecio
        '
        Me.nudPropiedadMaxPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPropiedadMaxPrecio.Location = New System.Drawing.Point(216, 9)
        Me.nudPropiedadMaxPrecio.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudPropiedadMaxPrecio.Name = "nudPropiedadMaxPrecio"
        Me.nudPropiedadMaxPrecio.Size = New System.Drawing.Size(85, 22)
        Me.nudPropiedadMaxPrecio.TabIndex = 21
        '
        'nudPropiedadMinPrecio
        '
        Me.nudPropiedadMinPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPropiedadMinPrecio.Location = New System.Drawing.Point(68, 9)
        Me.nudPropiedadMinPrecio.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudPropiedadMinPrecio.Name = "nudPropiedadMinPrecio"
        Me.nudPropiedadMinPrecio.Size = New System.Drawing.Size(84, 22)
        Me.nudPropiedadMinPrecio.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(166, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Hasta"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Desde"
        '
        'chbPropiedadPorPrecio
        '
        Me.chbPropiedadPorPrecio.AutoSize = True
        Me.chbPropiedadPorPrecio.BackColor = System.Drawing.Color.LightGray
        Me.chbPropiedadPorPrecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPropiedadPorPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPropiedadPorPrecio.Location = New System.Drawing.Point(0, 0)
        Me.chbPropiedadPorPrecio.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPropiedadPorPrecio.Name = "chbPropiedadPorPrecio"
        Me.chbPropiedadPorPrecio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPropiedadPorPrecio.Size = New System.Drawing.Size(320, 30)
        Me.chbPropiedadPorPrecio.TabIndex = 2
        Me.chbPropiedadPorPrecio.Text = "Buscar por precio (dolares americanos)"
        Me.chbPropiedadPorPrecio.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(350, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Búsqueda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxPropiedadImagen
        '
        Me.pbxPropiedadImagen.BackgroundImage = Global.Inmobiliaria.My.Resources.Resources.image_preview_default1
        Me.pbxPropiedadImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxPropiedadImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxPropiedadImagen.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxPropiedadImagen.Location = New System.Drawing.Point(0, 0)
        Me.pbxPropiedadImagen.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxPropiedadImagen.Name = "pbxPropiedadImagen"
        Me.pbxPropiedadImagen.Size = New System.Drawing.Size(350, 195)
        Me.pbxPropiedadImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPropiedadImagen.TabIndex = 0
        Me.pbxPropiedadImagen.TabStop = False
        '
        'tlpPropiedadHerramientas
        '
        Me.tlpPropiedadHerramientas.ColumnCount = 1
        Me.tlpPropiedadHerramientas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPropiedadHerramientas.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.tlpPropiedadHerramientas.Controls.Add(Me.Label2, 0, 0)
        Me.tlpPropiedadHerramientas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpPropiedadHerramientas.Location = New System.Drawing.Point(0, 508)
        Me.tlpPropiedadHerramientas.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPropiedadHerramientas.Name = "tlpPropiedadHerramientas"
        Me.tlpPropiedadHerramientas.RowCount = 2
        Me.tlpPropiedadHerramientas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPropiedadHerramientas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpPropiedadHerramientas.Size = New System.Drawing.Size(350, 90)
        Me.tlpPropiedadHerramientas.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnPropiedadAgregar, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnPropiedadEliminar, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnPropiedadEditar, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 43)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(344, 44)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'btnPropiedadAgregar
        '
        Me.btnPropiedadAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPropiedadAgregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPropiedadAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnPropiedadAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPropiedadAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPropiedadAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnPropiedadAgregar.Image = Global.Inmobiliaria.My.Resources.Resources.plus_green
        Me.btnPropiedadAgregar.Location = New System.Drawing.Point(3, 3)
        Me.btnPropiedadAgregar.Name = "btnPropiedadAgregar"
        Me.btnPropiedadAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPropiedadAgregar.Size = New System.Drawing.Size(108, 38)
        Me.btnPropiedadAgregar.TabIndex = 0
        Me.btnPropiedadAgregar.Text = "AGREGAR"
        Me.btnPropiedadAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPropiedadAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPropiedadAgregar.UseVisualStyleBackColor = True
        '
        'btnPropiedadEliminar
        '
        Me.btnPropiedadEliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPropiedadEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnPropiedadEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPropiedadEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPropiedadEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnPropiedadEliminar.Image = Global.Inmobiliaria.My.Resources.Resources.delete_red
        Me.btnPropiedadEliminar.Location = New System.Drawing.Point(117, 3)
        Me.btnPropiedadEliminar.Name = "btnPropiedadEliminar"
        Me.btnPropiedadEliminar.Size = New System.Drawing.Size(108, 38)
        Me.btnPropiedadEliminar.TabIndex = 1
        Me.btnPropiedadEliminar.Text = "ELIMINAR"
        Me.btnPropiedadEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPropiedadEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPropiedadEliminar.UseVisualStyleBackColor = True
        '
        'btnPropiedadEditar
        '
        Me.btnPropiedadEditar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPropiedadEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnPropiedadEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPropiedadEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPropiedadEditar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnPropiedadEditar.Image = Global.Inmobiliaria.My.Resources.Resources.edit_blue
        Me.btnPropiedadEditar.Location = New System.Drawing.Point(231, 3)
        Me.btnPropiedadEditar.Name = "btnPropiedadEditar"
        Me.btnPropiedadEditar.Size = New System.Drawing.Size(110, 38)
        Me.btnPropiedadEditar.TabIndex = 2
        Me.btnPropiedadEditar.Text = "EDITAR"
        Me.btnPropiedadEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPropiedadEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPropiedadEditar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10)
        Me.Label2.Size = New System.Drawing.Size(350, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Herramientas  de propiedades"
        '
        'dgvPropiedades
        '
        Me.dgvPropiedades.AllowUserToAddRows = False
        Me.dgvPropiedades.AllowUserToDeleteRows = False
        Me.dgvPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPropiedades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPropiedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPropiedades.Location = New System.Drawing.Point(0, 0)
        Me.dgvPropiedades.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvPropiedades.MultiSelect = False
        Me.dgvPropiedades.Name = "dgvPropiedades"
        Me.dgvPropiedades.ReadOnly = True
        Me.dgvPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPropiedades.Size = New System.Drawing.Size(674, 598)
        Me.dgvPropiedades.TabIndex = 5
        '
        'tlpVisitasModificadas
        '
        Me.tlpVisitasModificadas.BackColor = System.Drawing.Color.White
        Me.tlpVisitasModificadas.ColumnCount = 2
        Me.tlpVisitasModificadas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpVisitasModificadas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.tlpVisitasModificadas.Controls.Add(Me.dgvModificadas, 0, 0)
        Me.tlpVisitasModificadas.Controls.Add(Me.Panel18, 1, 0)
        Me.tlpVisitasModificadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpVisitasModificadas.Location = New System.Drawing.Point(0, 0)
        Me.tlpVisitasModificadas.Name = "tlpVisitasModificadas"
        Me.tlpVisitasModificadas.RowCount = 1
        Me.tlpVisitasModificadas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpVisitasModificadas.Size = New System.Drawing.Size(1024, 598)
        Me.tlpVisitasModificadas.TabIndex = 7
        '
        'dgvModificadas
        '
        Me.dgvModificadas.AllowUserToAddRows = False
        Me.dgvModificadas.AllowUserToDeleteRows = False
        Me.dgvModificadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvModificadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvModificadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModificadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvModificadas.Location = New System.Drawing.Point(0, 0)
        Me.dgvModificadas.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvModificadas.MultiSelect = False
        Me.dgvModificadas.Name = "dgvModificadas"
        Me.dgvModificadas.ReadOnly = True
        Me.dgvModificadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvModificadas.Size = New System.Drawing.Size(674, 598)
        Me.dgvModificadas.TabIndex = 3
        '
        'Panel18
        '
        Me.Panel18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel18.BackColor = System.Drawing.SystemColors.Control
        Me.Panel18.Controls.Add(Me.TableLayoutPanel12)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel18.Location = New System.Drawing.Point(674, 0)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(350, 598)
        Me.Panel18.TabIndex = 1
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 1
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.btnModifBuscar, 0, 2)
        Me.TableLayoutPanel12.Controls.Add(Me.FlowLayoutPanel4, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel12.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 3
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(350, 318)
        Me.TableLayoutPanel12.TabIndex = 2
        '
        'btnModifBuscar
        '
        Me.btnModifBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModifBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModifBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModifBuscar.Location = New System.Drawing.Point(5, 269)
        Me.btnModifBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnModifBuscar.Name = "btnModifBuscar"
        Me.btnModifBuscar.Size = New System.Drawing.Size(340, 44)
        Me.btnModifBuscar.TabIndex = 2
        Me.btnModifBuscar.Text = "BUSCAR"
        Me.btnModifBuscar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoScroll = True
        Me.FlowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel4.Controls.Add(Me.TableLayoutPanel15)
        Me.FlowLayoutPanel4.Controls.Add(Me.TableLayoutPanel19)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 43)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(344, 218)
        Me.FlowLayoutPanel4.TabIndex = 3
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel15.ColumnCount = 1
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.Panel6, 0, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.chbModifPorCliente, 0, 0)
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 2
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(338, 131)
        Me.TableLayoutPanel15.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.tbxModifClienteApellido)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.tbxModifClienteNombre)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.mtbModifCiCliente)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 33)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(332, 95)
        Me.Panel6.TabIndex = 1
        '
        'tbxModifClienteApellido
        '
        Me.tbxModifClienteApellido.Enabled = False
        Me.tbxModifClienteApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxModifClienteApellido.Location = New System.Drawing.Point(96, 64)
        Me.tbxModifClienteApellido.Name = "tbxModifClienteApellido"
        Me.tbxModifClienteApellido.Size = New System.Drawing.Size(228, 22)
        Me.tbxModifClienteApellido.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Apellido"
        '
        'tbxModifClienteNombre
        '
        Me.tbxModifClienteNombre.Enabled = False
        Me.tbxModifClienteNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxModifClienteNombre.Location = New System.Drawing.Point(96, 36)
        Me.tbxModifClienteNombre.Name = "tbxModifClienteNombre"
        Me.tbxModifClienteNombre.Size = New System.Drawing.Size(228, 22)
        Me.tbxModifClienteNombre.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nombre"
        '
        'mtbModifCiCliente
        '
        Me.mtbModifCiCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbModifCiCliente.Location = New System.Drawing.Point(96, 7)
        Me.mtbModifCiCliente.Mask = "0000000-0"
        Me.mtbModifCiCliente.Name = "mtbModifCiCliente"
        Me.mtbModifCiCliente.Size = New System.Drawing.Size(228, 22)
        Me.mtbModifCiCliente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CI de cliente"
        '
        'chbModifPorCliente
        '
        Me.chbModifPorCliente.AutoSize = True
        Me.chbModifPorCliente.BackColor = System.Drawing.Color.LightGray
        Me.chbModifPorCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbModifPorCliente.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbModifPorCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbModifPorCliente.Location = New System.Drawing.Point(0, 0)
        Me.chbModifPorCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.chbModifPorCliente.Name = "chbModifPorCliente"
        Me.chbModifPorCliente.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbModifPorCliente.Size = New System.Drawing.Size(338, 30)
        Me.chbModifPorCliente.TabIndex = 2
        Me.chbModifPorCliente.Text = "Buscar por cliente"
        Me.chbModifPorCliente.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel19.ColumnCount = 1
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel19.Controls.Add(Me.Panel7, 0, 1)
        Me.TableLayoutPanel19.Controls.Add(Me.chbModifPorFecha, 0, 0)
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(3, 140)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.RowCount = 2
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(338, 75)
        Me.TableLayoutPanel19.TabIndex = 10
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.dtpModifFechaMax)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.dtpModifFechaMin)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 33)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(332, 39)
        Me.Panel7.TabIndex = 1
        '
        'dtpModifFechaMax
        '
        Me.dtpModifFechaMax.CustomFormat = "dd/MM/yyyy"
        Me.dtpModifFechaMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpModifFechaMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpModifFechaMax.Location = New System.Drawing.Point(225, 9)
        Me.dtpModifFechaMax.Name = "dtpModifFechaMax"
        Me.dtpModifFechaMax.Size = New System.Drawing.Size(99, 22)
        Me.dtpModifFechaMax.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hasta"
        '
        'dtpModifFechaMin
        '
        Me.dtpModifFechaMin.CustomFormat = "dd/MM/yyyy"
        Me.dtpModifFechaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpModifFechaMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpModifFechaMin.Location = New System.Drawing.Point(64, 9)
        Me.dtpModifFechaMin.Name = "dtpModifFechaMin"
        Me.dtpModifFechaMin.Size = New System.Drawing.Size(96, 22)
        Me.dtpModifFechaMin.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Desde"
        '
        'chbModifPorFecha
        '
        Me.chbModifPorFecha.AutoSize = True
        Me.chbModifPorFecha.BackColor = System.Drawing.Color.LightGray
        Me.chbModifPorFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbModifPorFecha.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbModifPorFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbModifPorFecha.Location = New System.Drawing.Point(0, 0)
        Me.chbModifPorFecha.Margin = New System.Windows.Forms.Padding(0)
        Me.chbModifPorFecha.Name = "chbModifPorFecha"
        Me.chbModifPorFecha.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbModifPorFecha.Size = New System.Drawing.Size(338, 30)
        Me.chbModifPorFecha.TabIndex = 2
        Me.chbModifPorFecha.Text = "Buscar por Fecha de modificación"
        Me.chbModifPorFecha.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(10)
        Me.Label6.Size = New System.Drawing.Size(350, 40)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Filtrar visitas modificadas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpVisitasCanceladas
        '
        Me.tlpVisitasCanceladas.BackColor = System.Drawing.Color.White
        Me.tlpVisitasCanceladas.ColumnCount = 2
        Me.tlpVisitasCanceladas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpVisitasCanceladas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.tlpVisitasCanceladas.Controls.Add(Me.dgvCanceladas, 0, 0)
        Me.tlpVisitasCanceladas.Controls.Add(Me.Panel13, 1, 0)
        Me.tlpVisitasCanceladas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpVisitasCanceladas.Location = New System.Drawing.Point(0, 0)
        Me.tlpVisitasCanceladas.Name = "tlpVisitasCanceladas"
        Me.tlpVisitasCanceladas.RowCount = 1
        Me.tlpVisitasCanceladas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpVisitasCanceladas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 598.0!))
        Me.tlpVisitasCanceladas.Size = New System.Drawing.Size(1024, 598)
        Me.tlpVisitasCanceladas.TabIndex = 6
        '
        'dgvCanceladas
        '
        Me.dgvCanceladas.AllowUserToAddRows = False
        Me.dgvCanceladas.AllowUserToDeleteRows = False
        Me.dgvCanceladas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCanceladas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCanceladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCanceladas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCanceladas.Location = New System.Drawing.Point(0, 0)
        Me.dgvCanceladas.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvCanceladas.MultiSelect = False
        Me.dgvCanceladas.Name = "dgvCanceladas"
        Me.dgvCanceladas.ReadOnly = True
        Me.dgvCanceladas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCanceladas.Size = New System.Drawing.Size(674, 598)
        Me.dgvCanceladas.TabIndex = 3
        '
        'Panel13
        '
        Me.Panel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel13.BackColor = System.Drawing.SystemColors.Control
        Me.Panel13.Controls.Add(Me.TableLayoutPanel16)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(674, 0)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(350, 598)
        Me.Panel13.TabIndex = 1
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.ColumnCount = 1
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.btnCancelBuscar, 0, 2)
        Me.TableLayoutPanel16.Controls.Add(Me.FlowLayoutPanel3, 0, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.Label29, 0, 0)
        Me.TableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel16.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 3
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(350, 318)
        Me.TableLayoutPanel16.TabIndex = 1
        '
        'btnCancelBuscar
        '
        Me.btnCancelBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelBuscar.Location = New System.Drawing.Point(5, 269)
        Me.btnCancelBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelBuscar.Name = "btnCancelBuscar"
        Me.btnCancelBuscar.Size = New System.Drawing.Size(340, 44)
        Me.btnCancelBuscar.TabIndex = 2
        Me.btnCancelBuscar.Text = "BUSCAR"
        Me.btnCancelBuscar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoScroll = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.TableLayoutPanel17)
        Me.FlowLayoutPanel3.Controls.Add(Me.TableLayoutPanel18)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 43)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(344, 218)
        Me.FlowLayoutPanel3.TabIndex = 3
        '
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel17.ColumnCount = 1
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel17.Controls.Add(Me.Panel16, 0, 1)
        Me.TableLayoutPanel17.Controls.Add(Me.chbCancelPorCliente, 0, 0)
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 2
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(338, 131)
        Me.TableLayoutPanel17.TabIndex = 9
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Label23)
        Me.Panel16.Controls.Add(Me.Label12)
        Me.Panel16.Controls.Add(Me.tbxCancelClienteApellido)
        Me.Panel16.Controls.Add(Me.tbxCancelClienteNombre)
        Me.Panel16.Controls.Add(Me.mtbCancelCiCliente)
        Me.Panel16.Controls.Add(Me.Label26)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(3, 33)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(332, 95)
        Me.Panel16.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(32, 66)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 16)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Apellido"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Nombre"
        '
        'tbxCancelClienteApellido
        '
        Me.tbxCancelClienteApellido.Enabled = False
        Me.tbxCancelClienteApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCancelClienteApellido.Location = New System.Drawing.Point(96, 64)
        Me.tbxCancelClienteApellido.Name = "tbxCancelClienteApellido"
        Me.tbxCancelClienteApellido.Size = New System.Drawing.Size(228, 22)
        Me.tbxCancelClienteApellido.TabIndex = 5
        '
        'tbxCancelClienteNombre
        '
        Me.tbxCancelClienteNombre.Enabled = False
        Me.tbxCancelClienteNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCancelClienteNombre.Location = New System.Drawing.Point(96, 35)
        Me.tbxCancelClienteNombre.Name = "tbxCancelClienteNombre"
        Me.tbxCancelClienteNombre.Size = New System.Drawing.Size(228, 22)
        Me.tbxCancelClienteNombre.TabIndex = 4
        '
        'mtbCancelCiCliente
        '
        Me.mtbCancelCiCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCancelCiCliente.Location = New System.Drawing.Point(96, 7)
        Me.mtbCancelCiCliente.Mask = "0000000-0"
        Me.mtbCancelCiCliente.Name = "mtbCancelCiCliente"
        Me.mtbCancelCiCliente.Size = New System.Drawing.Size(228, 22)
        Me.mtbCancelCiCliente.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(9, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 16)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "CI de cliente"
        '
        'chbCancelPorCliente
        '
        Me.chbCancelPorCliente.AutoSize = True
        Me.chbCancelPorCliente.BackColor = System.Drawing.Color.LightGray
        Me.chbCancelPorCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbCancelPorCliente.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbCancelPorCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCancelPorCliente.Location = New System.Drawing.Point(0, 0)
        Me.chbCancelPorCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.chbCancelPorCliente.Name = "chbCancelPorCliente"
        Me.chbCancelPorCliente.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbCancelPorCliente.Size = New System.Drawing.Size(338, 30)
        Me.chbCancelPorCliente.TabIndex = 2
        Me.chbCancelPorCliente.Text = "Buscar por cliente"
        Me.chbCancelPorCliente.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel18
        '
        Me.TableLayoutPanel18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel18.ColumnCount = 1
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.Controls.Add(Me.Panel17, 0, 1)
        Me.TableLayoutPanel18.Controls.Add(Me.chbCancelPorFecha, 0, 0)
        Me.TableLayoutPanel18.Location = New System.Drawing.Point(3, 140)
        Me.TableLayoutPanel18.Name = "TableLayoutPanel18"
        Me.TableLayoutPanel18.RowCount = 2
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel18.Size = New System.Drawing.Size(338, 75)
        Me.TableLayoutPanel18.TabIndex = 10
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.dtpCancelFechMax)
        Me.Panel17.Controls.Add(Me.Label27)
        Me.Panel17.Controls.Add(Me.dtpCancelFechMin)
        Me.Panel17.Controls.Add(Me.Label28)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel17.Location = New System.Drawing.Point(3, 33)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(332, 39)
        Me.Panel17.TabIndex = 1
        '
        'dtpCancelFechMax
        '
        Me.dtpCancelFechMax.CustomFormat = "dd/MM/yyyy"
        Me.dtpCancelFechMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCancelFechMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCancelFechMax.Location = New System.Drawing.Point(225, 9)
        Me.dtpCancelFechMax.Name = "dtpCancelFechMax"
        Me.dtpCancelFechMax.Size = New System.Drawing.Size(99, 22)
        Me.dtpCancelFechMax.TabIndex = 7
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(176, 12)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(44, 16)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Hasta"
        '
        'dtpCancelFechMin
        '
        Me.dtpCancelFechMin.CustomFormat = "dd/MM/yyyy"
        Me.dtpCancelFechMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCancelFechMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCancelFechMin.Location = New System.Drawing.Point(64, 9)
        Me.dtpCancelFechMin.Name = "dtpCancelFechMin"
        Me.dtpCancelFechMin.Size = New System.Drawing.Size(96, 22)
        Me.dtpCancelFechMin.TabIndex = 5
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(9, 12)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 16)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Desde"
        '
        'chbCancelPorFecha
        '
        Me.chbCancelPorFecha.AutoSize = True
        Me.chbCancelPorFecha.BackColor = System.Drawing.Color.LightGray
        Me.chbCancelPorFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbCancelPorFecha.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbCancelPorFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCancelPorFecha.Location = New System.Drawing.Point(0, 0)
        Me.chbCancelPorFecha.Margin = New System.Windows.Forms.Padding(0)
        Me.chbCancelPorFecha.Name = "chbCancelPorFecha"
        Me.chbCancelPorFecha.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbCancelPorFecha.Size = New System.Drawing.Size(338, 30)
        Me.chbCancelPorFecha.TabIndex = 2
        Me.chbCancelPorFecha.Text = "Buscar por Fecha de visita"
        Me.chbCancelPorFecha.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(0, 0)
        Me.Label29.Margin = New System.Windows.Forms.Padding(0)
        Me.Label29.Name = "Label29"
        Me.Label29.Padding = New System.Windows.Forms.Padding(10)
        Me.Label29.Size = New System.Drawing.Size(350, 40)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Filtrar visitas canceladas"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TlpVisitasAsignadas
        '
        Me.TlpVisitasAsignadas.BackColor = System.Drawing.Color.White
        Me.TlpVisitasAsignadas.ColumnCount = 2
        Me.TlpVisitasAsignadas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpVisitasAsignadas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TlpVisitasAsignadas.Controls.Add(Me.Panel27, 1, 0)
        Me.TlpVisitasAsignadas.Controls.Add(Me.DgvVisitasAsignadas, 0, 0)
        Me.TlpVisitasAsignadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpVisitasAsignadas.Location = New System.Drawing.Point(0, 0)
        Me.TlpVisitasAsignadas.Name = "TlpVisitasAsignadas"
        Me.TlpVisitasAsignadas.RowCount = 1
        Me.TlpVisitasAsignadas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpVisitasAsignadas.Size = New System.Drawing.Size(1024, 598)
        Me.TlpVisitasAsignadas.TabIndex = 10
        '
        'Panel27
        '
        Me.Panel27.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel27.BackColor = System.Drawing.SystemColors.Control
        Me.Panel27.Controls.Add(Me.TableLayoutPanel24)
        Me.Panel27.Controls.Add(Me.TableLayoutPanel27)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel27.Location = New System.Drawing.Point(674, 0)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(350, 598)
        Me.Panel27.TabIndex = 1
        '
        'TableLayoutPanel24
        '
        Me.TableLayoutPanel24.ColumnCount = 1
        Me.TableLayoutPanel24.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel24.Controls.Add(Me.BtnVisitasAsignadasVer, 0, 2)
        Me.TableLayoutPanel24.Controls.Add(Me.TableLayoutPanel26, 0, 1)
        Me.TableLayoutPanel24.Controls.Add(Me.Label41, 0, 0)
        Me.TableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel24.Location = New System.Drawing.Point(0, 264)
        Me.TableLayoutPanel24.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel24.Name = "TableLayoutPanel24"
        Me.TableLayoutPanel24.RowCount = 3
        Me.TableLayoutPanel24.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel24.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel24.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel24.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel24.Size = New System.Drawing.Size(350, 140)
        Me.TableLayoutPanel24.TabIndex = 3
        '
        'BtnVisitasAsignadasVer
        '
        Me.BtnVisitasAsignadasVer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVisitasAsignadasVer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnVisitasAsignadasVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVisitasAsignadasVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisitasAsignadasVer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnVisitasAsignadasVer.Location = New System.Drawing.Point(6, 96)
        Me.BtnVisitasAsignadasVer.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnVisitasAsignadasVer.Name = "BtnVisitasAsignadasVer"
        Me.BtnVisitasAsignadasVer.Size = New System.Drawing.Size(338, 38)
        Me.BtnVisitasAsignadasVer.TabIndex = 5
        Me.BtnVisitasAsignadasVer.Text = "VER VISITA"
        Me.BtnVisitasAsignadasVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVisitasAsignadasVer.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel26
        '
        Me.TableLayoutPanel26.ColumnCount = 2
        Me.TableLayoutPanel26.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel26.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel26.Controls.Add(Me.BtnVisitasAsignadasCancelar, 0, 0)
        Me.TableLayoutPanel26.Controls.Add(Me.BtnVisitasAsignadasEditar, 1, 0)
        Me.TableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel26.Location = New System.Drawing.Point(3, 43)
        Me.TableLayoutPanel26.Name = "TableLayoutPanel26"
        Me.TableLayoutPanel26.RowCount = 1
        Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel26.Size = New System.Drawing.Size(344, 44)
        Me.TableLayoutPanel26.TabIndex = 1
        '
        'BtnVisitasAsignadasCancelar
        '
        Me.BtnVisitasAsignadasCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVisitasAsignadasCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BtnVisitasAsignadasCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVisitasAsignadasCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisitasAsignadasCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BtnVisitasAsignadasCancelar.Image = Global.Inmobiliaria.My.Resources.Resources.delete_red
        Me.BtnVisitasAsignadasCancelar.Location = New System.Drawing.Point(3, 3)
        Me.BtnVisitasAsignadasCancelar.Name = "BtnVisitasAsignadasCancelar"
        Me.BtnVisitasAsignadasCancelar.Size = New System.Drawing.Size(166, 38)
        Me.BtnVisitasAsignadasCancelar.TabIndex = 1
        Me.BtnVisitasAsignadasCancelar.Text = "CANCELAR VISITA"
        Me.BtnVisitasAsignadasCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVisitasAsignadasCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVisitasAsignadasCancelar.UseVisualStyleBackColor = True
        '
        'BtnVisitasAsignadasEditar
        '
        Me.BtnVisitasAsignadasEditar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVisitasAsignadasEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnVisitasAsignadasEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVisitasAsignadasEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisitasAsignadasEditar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnVisitasAsignadasEditar.Image = Global.Inmobiliaria.My.Resources.Resources.edit_blue
        Me.BtnVisitasAsignadasEditar.Location = New System.Drawing.Point(175, 3)
        Me.BtnVisitasAsignadasEditar.Name = "BtnVisitasAsignadasEditar"
        Me.BtnVisitasAsignadasEditar.Size = New System.Drawing.Size(166, 38)
        Me.BtnVisitasAsignadasEditar.TabIndex = 2
        Me.BtnVisitasAsignadasEditar.Text = "EDITAR VISITA"
        Me.BtnVisitasAsignadasEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVisitasAsignadasEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVisitasAsignadasEditar.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label41.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(0, 0)
        Me.Label41.Margin = New System.Windows.Forms.Padding(0)
        Me.Label41.Name = "Label41"
        Me.Label41.Padding = New System.Windows.Forms.Padding(10)
        Me.Label41.Size = New System.Drawing.Size(350, 40)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Herramientas  de agenda"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel27
        '
        Me.TableLayoutPanel27.ColumnCount = 1
        Me.TableLayoutPanel27.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel27.Controls.Add(Me.FlowLayoutPanel6, 0, 1)
        Me.TableLayoutPanel27.Controls.Add(Me.Label47, 0, 0)
        Me.TableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel27.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel27.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel27.Name = "TableLayoutPanel27"
        Me.TableLayoutPanel27.RowCount = 2
        Me.TableLayoutPanel27.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel27.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219.0!))
        Me.TableLayoutPanel27.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel27.Size = New System.Drawing.Size(350, 264)
        Me.TableLayoutPanel27.TabIndex = 1
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.AutoScroll = True
        Me.FlowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel6.Controls.Add(Me.RbtVisitasAsignadasDia)
        Me.FlowLayoutPanel6.Controls.Add(Me.RbtVisitasAsignadas7Dias)
        Me.FlowLayoutPanel6.Controls.Add(Me.RbtVisitasAsignadas30Dias)
        Me.FlowLayoutPanel6.Controls.Add(Me.RbtVisitasAsignadasTodas)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(3, 43)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(344, 218)
        Me.FlowLayoutPanel6.TabIndex = 3
        '
        'RbtVisitasAsignadasDia
        '
        Me.RbtVisitasAsignadasDia.BackColor = System.Drawing.Color.LightGray
        Me.RbtVisitasAsignadasDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtVisitasAsignadasDia.Location = New System.Drawing.Point(3, 3)
        Me.RbtVisitasAsignadasDia.Name = "RbtVisitasAsignadasDia"
        Me.RbtVisitasAsignadasDia.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtVisitasAsignadasDia.Size = New System.Drawing.Size(338, 30)
        Me.RbtVisitasAsignadasDia.TabIndex = 13
        Me.RbtVisitasAsignadasDia.Text = "Visitas del dia"
        Me.RbtVisitasAsignadasDia.UseVisualStyleBackColor = False
        '
        'RbtVisitasAsignadas7Dias
        '
        Me.RbtVisitasAsignadas7Dias.BackColor = System.Drawing.Color.LightGray
        Me.RbtVisitasAsignadas7Dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtVisitasAsignadas7Dias.Location = New System.Drawing.Point(3, 39)
        Me.RbtVisitasAsignadas7Dias.Name = "RbtVisitasAsignadas7Dias"
        Me.RbtVisitasAsignadas7Dias.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtVisitasAsignadas7Dias.Size = New System.Drawing.Size(338, 30)
        Me.RbtVisitasAsignadas7Dias.TabIndex = 14
        Me.RbtVisitasAsignadas7Dias.Text = "Visitas en proximos 7 dias"
        Me.RbtVisitasAsignadas7Dias.UseVisualStyleBackColor = False
        '
        'RbtVisitasAsignadas30Dias
        '
        Me.RbtVisitasAsignadas30Dias.BackColor = System.Drawing.Color.LightGray
        Me.RbtVisitasAsignadas30Dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtVisitasAsignadas30Dias.Location = New System.Drawing.Point(3, 75)
        Me.RbtVisitasAsignadas30Dias.Name = "RbtVisitasAsignadas30Dias"
        Me.RbtVisitasAsignadas30Dias.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtVisitasAsignadas30Dias.Size = New System.Drawing.Size(338, 30)
        Me.RbtVisitasAsignadas30Dias.TabIndex = 15
        Me.RbtVisitasAsignadas30Dias.Text = "Visitas en proximos 30 dias"
        Me.RbtVisitasAsignadas30Dias.UseVisualStyleBackColor = False
        '
        'RbtVisitasAsignadasTodas
        '
        Me.RbtVisitasAsignadasTodas.BackColor = System.Drawing.Color.LightGray
        Me.RbtVisitasAsignadasTodas.Checked = True
        Me.RbtVisitasAsignadasTodas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtVisitasAsignadasTodas.Location = New System.Drawing.Point(3, 111)
        Me.RbtVisitasAsignadasTodas.Name = "RbtVisitasAsignadasTodas"
        Me.RbtVisitasAsignadasTodas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RbtVisitasAsignadasTodas.Size = New System.Drawing.Size(338, 30)
        Me.RbtVisitasAsignadasTodas.TabIndex = 16
        Me.RbtVisitasAsignadasTodas.TabStop = True
        Me.RbtVisitasAsignadasTodas.Text = "Todas las visitas"
        Me.RbtVisitasAsignadasTodas.UseVisualStyleBackColor = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label47.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(0, 0)
        Me.Label47.Margin = New System.Windows.Forms.Padding(0)
        Me.Label47.Name = "Label47"
        Me.Label47.Padding = New System.Windows.Forms.Padding(10)
        Me.Label47.Size = New System.Drawing.Size(350, 40)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Filtrar visitas"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvVisitasAsignadas
        '
        Me.DgvVisitasAsignadas.AllowUserToAddRows = False
        Me.DgvVisitasAsignadas.AllowUserToDeleteRows = False
        Me.DgvVisitasAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVisitasAsignadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvVisitasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVisitasAsignadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvVisitasAsignadas.Location = New System.Drawing.Point(0, 0)
        Me.DgvVisitasAsignadas.Margin = New System.Windows.Forms.Padding(0)
        Me.DgvVisitasAsignadas.MultiSelect = False
        Me.DgvVisitasAsignadas.Name = "DgvVisitasAsignadas"
        Me.DgvVisitasAsignadas.ReadOnly = True
        Me.DgvVisitasAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVisitasAsignadas.Size = New System.Drawing.Size(674, 598)
        Me.DgvVisitasAsignadas.TabIndex = 2
        '
        'tlpAgenda
        '
        Me.tlpAgenda.BackColor = System.Drawing.Color.White
        Me.tlpAgenda.ColumnCount = 2
        Me.tlpAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.tlpAgenda.Controls.Add(Me.Panel2, 1, 0)
        Me.tlpAgenda.Controls.Add(Me.DgvAgenda, 0, 0)
        Me.tlpAgenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAgenda.Location = New System.Drawing.Point(0, 0)
        Me.tlpAgenda.Name = "tlpAgenda"
        Me.tlpAgenda.RowCount = 1
        Me.tlpAgenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAgenda.Size = New System.Drawing.Size(1024, 598)
        Me.tlpAgenda.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.TableLayoutPanel13)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(674, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(350, 598)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 1
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.btnAgendaAceptarVisita, 0, 3)
        Me.TableLayoutPanel13.Controls.Add(Me.btnAgendaVerVisita, 0, 2)
        Me.TableLayoutPanel13.Controls.Add(Me.TableLayoutPanel14, 0, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.Label34, 0, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(0, 309)
        Me.TableLayoutPanel13.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 4
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(350, 199)
        Me.TableLayoutPanel13.TabIndex = 3
        '
        'btnAgendaAceptarVisita
        '
        Me.btnAgendaAceptarVisita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgendaAceptarVisita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAgendaAceptarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendaAceptarVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendaAceptarVisita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnAgendaAceptarVisita.Location = New System.Drawing.Point(6, 152)
        Me.btnAgendaAceptarVisita.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAgendaAceptarVisita.Name = "btnAgendaAceptarVisita"
        Me.btnAgendaAceptarVisita.Size = New System.Drawing.Size(338, 41)
        Me.btnAgendaAceptarVisita.TabIndex = 6
        Me.btnAgendaAceptarVisita.Text = "ACEPTAR VISITA"
        Me.btnAgendaAceptarVisita.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgendaAceptarVisita.UseVisualStyleBackColor = True
        '
        'btnAgendaVerVisita
        '
        Me.btnAgendaVerVisita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgendaVerVisita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnAgendaVerVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendaVerVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendaVerVisita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnAgendaVerVisita.Location = New System.Drawing.Point(6, 99)
        Me.btnAgendaVerVisita.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAgendaVerVisita.Name = "btnAgendaVerVisita"
        Me.btnAgendaVerVisita.Size = New System.Drawing.Size(338, 41)
        Me.btnAgendaVerVisita.TabIndex = 5
        Me.btnAgendaVerVisita.Text = "VER VISITA"
        Me.btnAgendaVerVisita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgendaVerVisita.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 2
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.btnAgendaCancelVisita, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.btnAgendaModifVisita, 1, 0)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(3, 43)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 1
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(344, 47)
        Me.TableLayoutPanel14.TabIndex = 1
        '
        'btnAgendaCancelVisita
        '
        Me.btnAgendaCancelVisita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgendaCancelVisita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAgendaCancelVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendaCancelVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendaCancelVisita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnAgendaCancelVisita.Image = Global.Inmobiliaria.My.Resources.Resources.delete_red
        Me.btnAgendaCancelVisita.Location = New System.Drawing.Point(3, 3)
        Me.btnAgendaCancelVisita.Name = "btnAgendaCancelVisita"
        Me.btnAgendaCancelVisita.Size = New System.Drawing.Size(166, 41)
        Me.btnAgendaCancelVisita.TabIndex = 1
        Me.btnAgendaCancelVisita.Text = "CANCELAR VISITA"
        Me.btnAgendaCancelVisita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgendaCancelVisita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgendaCancelVisita.UseVisualStyleBackColor = True
        '
        'btnAgendaModifVisita
        '
        Me.btnAgendaModifVisita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgendaModifVisita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnAgendaModifVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendaModifVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendaModifVisita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnAgendaModifVisita.Image = Global.Inmobiliaria.My.Resources.Resources.edit_blue
        Me.btnAgendaModifVisita.Location = New System.Drawing.Point(175, 3)
        Me.btnAgendaModifVisita.Name = "btnAgendaModifVisita"
        Me.btnAgendaModifVisita.Size = New System.Drawing.Size(166, 41)
        Me.btnAgendaModifVisita.TabIndex = 2
        Me.btnAgendaModifVisita.Text = "EDITAR VISITA"
        Me.btnAgendaModifVisita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgendaModifVisita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgendaModifVisita.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(0, 0)
        Me.Label34.Margin = New System.Windows.Forms.Padding(0)
        Me.Label34.Name = "Label34"
        Me.Label34.Padding = New System.Windows.Forms.Padding(10)
        Me.Label34.Size = New System.Drawing.Size(350, 40)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Herramientas  de agenda"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.btnAgendaBuscar, 0, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label33, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 3
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(350, 309)
        Me.TableLayoutPanel9.TabIndex = 1
        '
        'btnAgendaBuscar
        '
        Me.btnAgendaBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgendaBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgendaBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendaBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendaBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgendaBuscar.Location = New System.Drawing.Point(5, 264)
        Me.btnAgendaBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAgendaBuscar.Name = "btnAgendaBuscar"
        Me.btnAgendaBuscar.Size = New System.Drawing.Size(340, 40)
        Me.btnAgendaBuscar.TabIndex = 2
        Me.btnAgendaBuscar.Text = "BUSCAR"
        Me.btnAgendaBuscar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.TableLayoutPanel8)
        Me.FlowLayoutPanel2.Controls.Add(Me.TableLayoutPanel10)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 43)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(344, 213)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Panel14, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.chbAgendaPorUsuario, 0, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(338, 128)
        Me.TableLayoutPanel8.TabIndex = 9
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label21)
        Me.Panel14.Controls.Add(Me.tbxAgendaApellCliente)
        Me.Panel14.Controls.Add(Me.Label20)
        Me.Panel14.Controls.Add(Me.tbxAgendaNomCliente)
        Me.Panel14.Controls.Add(Me.mtbAgendaCiCliente)
        Me.Panel14.Controls.Add(Me.Label18)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(3, 33)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(332, 92)
        Me.Panel14.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(32, 66)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 16)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Apellido"
        '
        'tbxAgendaApellCliente
        '
        Me.tbxAgendaApellCliente.Enabled = False
        Me.tbxAgendaApellCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAgendaApellCliente.Location = New System.Drawing.Point(96, 63)
        Me.tbxAgendaApellCliente.Name = "tbxAgendaApellCliente"
        Me.tbxAgendaApellCliente.Size = New System.Drawing.Size(228, 22)
        Me.tbxAgendaApellCliente.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(33, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 16)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Nombre"
        '
        'tbxAgendaNomCliente
        '
        Me.tbxAgendaNomCliente.Enabled = False
        Me.tbxAgendaNomCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAgendaNomCliente.Location = New System.Drawing.Point(96, 35)
        Me.tbxAgendaNomCliente.Name = "tbxAgendaNomCliente"
        Me.tbxAgendaNomCliente.Size = New System.Drawing.Size(228, 22)
        Me.tbxAgendaNomCliente.TabIndex = 4
        '
        'mtbAgendaCiCliente
        '
        Me.mtbAgendaCiCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbAgendaCiCliente.Location = New System.Drawing.Point(96, 8)
        Me.mtbAgendaCiCliente.Mask = "0000000-0"
        Me.mtbAgendaCiCliente.Name = "mtbAgendaCiCliente"
        Me.mtbAgendaCiCliente.Size = New System.Drawing.Size(228, 22)
        Me.mtbAgendaCiCliente.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "CI de cliente"
        '
        'chbAgendaPorUsuario
        '
        Me.chbAgendaPorUsuario.AutoSize = True
        Me.chbAgendaPorUsuario.BackColor = System.Drawing.Color.LightGray
        Me.chbAgendaPorUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbAgendaPorUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbAgendaPorUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAgendaPorUsuario.Location = New System.Drawing.Point(0, 0)
        Me.chbAgendaPorUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.chbAgendaPorUsuario.Name = "chbAgendaPorUsuario"
        Me.chbAgendaPorUsuario.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbAgendaPorUsuario.Size = New System.Drawing.Size(338, 30)
        Me.chbAgendaPorUsuario.TabIndex = 2
        Me.chbAgendaPorUsuario.Text = "Buscar por Usuario"
        Me.chbAgendaPorUsuario.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Panel15, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.chbAgendaPorFecha, 0, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 137)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(338, 73)
        Me.TableLayoutPanel10.TabIndex = 10
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.dtpAgendaFechaMax)
        Me.Panel15.Controls.Add(Me.Label19)
        Me.Panel15.Controls.Add(Me.dtpAgendaFechaMin)
        Me.Panel15.Controls.Add(Me.Label22)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(3, 33)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(332, 37)
        Me.Panel15.TabIndex = 1
        '
        'dtpAgendaFechaMax
        '
        Me.dtpAgendaFechaMax.CustomFormat = "dd/MM/yyyy"
        Me.dtpAgendaFechaMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAgendaFechaMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAgendaFechaMax.Location = New System.Drawing.Point(226, 9)
        Me.dtpAgendaFechaMax.Name = "dtpAgendaFechaMax"
        Me.dtpAgendaFechaMax.Size = New System.Drawing.Size(98, 22)
        Me.dtpAgendaFechaMax.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(176, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 16)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Hasta"
        '
        'dtpAgendaFechaMin
        '
        Me.dtpAgendaFechaMin.CustomFormat = "dd/MM/yyyy"
        Me.dtpAgendaFechaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAgendaFechaMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAgendaFechaMin.Location = New System.Drawing.Point(64, 9)
        Me.dtpAgendaFechaMin.Name = "dtpAgendaFechaMin"
        Me.dtpAgendaFechaMin.Size = New System.Drawing.Size(96, 22)
        Me.dtpAgendaFechaMin.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 16)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Desde"
        '
        'chbAgendaPorFecha
        '
        Me.chbAgendaPorFecha.AutoSize = True
        Me.chbAgendaPorFecha.BackColor = System.Drawing.Color.LightGray
        Me.chbAgendaPorFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbAgendaPorFecha.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chbAgendaPorFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAgendaPorFecha.Location = New System.Drawing.Point(0, 0)
        Me.chbAgendaPorFecha.Margin = New System.Windows.Forms.Padding(0)
        Me.chbAgendaPorFecha.Name = "chbAgendaPorFecha"
        Me.chbAgendaPorFecha.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbAgendaPorFecha.Size = New System.Drawing.Size(338, 30)
        Me.chbAgendaPorFecha.TabIndex = 2
        Me.chbAgendaPorFecha.Text = "Buscar por Fecha"
        Me.chbAgendaPorFecha.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(0, 0)
        Me.Label33.Margin = New System.Windows.Forms.Padding(0)
        Me.Label33.Name = "Label33"
        Me.Label33.Padding = New System.Windows.Forms.Padding(10)
        Me.Label33.Size = New System.Drawing.Size(350, 40)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Busqueda"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvAgenda
        '
        Me.DgvAgenda.AllowUserToAddRows = False
        Me.DgvAgenda.AllowUserToDeleteRows = False
        Me.DgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAgenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvAgenda.Location = New System.Drawing.Point(0, 0)
        Me.DgvAgenda.Margin = New System.Windows.Forms.Padding(0)
        Me.DgvAgenda.MultiSelect = False
        Me.DgvAgenda.Name = "DgvAgenda"
        Me.DgvAgenda.ReadOnly = True
        Me.DgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAgenda.Size = New System.Drawing.Size(674, 598)
        Me.DgvAgenda.TabIndex = 2
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.lmbPropiedades)
        Me.FlowLayoutPanel5.Controls.Add(Me.lmbAgenda)
        Me.FlowLayoutPanel5.Controls.Add(Me.LmbVisitasAsignadas)
        Me.FlowLayoutPanel5.Controls.Add(Me.lmbVisitasModificadas)
        Me.FlowLayoutPanel5.Controls.Add(Me.lmbVisitasCanceladas)
        Me.FlowLayoutPanel5.Controls.Add(Me.lmbEmpleados)
        Me.FlowLayoutPanel5.Controls.Add(Me.lmbClientes)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(1, 41)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(224, 598)
        Me.FlowLayoutPanel5.TabIndex = 11
        '
        'lmbPropiedades
        '
        Me.lmbPropiedades.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lmbPropiedades.BgColorClick = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbPropiedades.BgColorDefault = System.Drawing.Color.Empty
        Me.lmbPropiedades.BgColorHover = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbPropiedades.BgColorSelected = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lmbPropiedades.FlatAppearance.BorderSize = 0
        Me.lmbPropiedades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lmbPropiedades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lmbPropiedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lmbPropiedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmbPropiedades.ForeColor = System.Drawing.Color.White
        Me.lmbPropiedades.Image = Global.Inmobiliaria.My.Resources.Resources.icons8_Apartment_24px_3
        Me.lmbPropiedades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbPropiedades.LeftBarColorDefault = System.Drawing.Color.Empty
        Me.lmbPropiedades.LeftBarColorHover = System.Drawing.Color.Empty
        Me.lmbPropiedades.LeftBarColorSelected = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lmbPropiedades.Location = New System.Drawing.Point(0, 0)
        Me.lmbPropiedades.Margin = New System.Windows.Forms.Padding(0)
        Me.lmbPropiedades.Name = "lmbPropiedades"
        Me.lmbPropiedades.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lmbPropiedades.Selected = True
        Me.lmbPropiedades.Size = New System.Drawing.Size(226, 50)
        Me.lmbPropiedades.TabIndex = 0
        Me.lmbPropiedades.Text = "  Propiedades"
        Me.lmbPropiedades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbPropiedades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lmbPropiedades.UseVisualStyleBackColor = True
        '
        'lmbAgenda
        '
        Me.lmbAgenda.BgColorClick = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbAgenda.BgColorDefault = System.Drawing.Color.Empty
        Me.lmbAgenda.BgColorHover = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbAgenda.BgColorSelected = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lmbAgenda.FlatAppearance.BorderSize = 0
        Me.lmbAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lmbAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmbAgenda.ForeColor = System.Drawing.Color.White
        Me.lmbAgenda.Image = Global.Inmobiliaria.My.Resources.Resources.calendar
        Me.lmbAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbAgenda.LeftBarColorDefault = System.Drawing.Color.Empty
        Me.lmbAgenda.LeftBarColorHover = System.Drawing.Color.Empty
        Me.lmbAgenda.LeftBarColorSelected = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lmbAgenda.Location = New System.Drawing.Point(0, 50)
        Me.lmbAgenda.Margin = New System.Windows.Forms.Padding(0)
        Me.lmbAgenda.Name = "lmbAgenda"
        Me.lmbAgenda.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lmbAgenda.Selected = False
        Me.lmbAgenda.Size = New System.Drawing.Size(226, 50)
        Me.lmbAgenda.TabIndex = 1
        Me.lmbAgenda.Text = "  Agenda"
        Me.lmbAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lmbAgenda.UseVisualStyleBackColor = True
        '
        'LmbVisitasAsignadas
        '
        Me.LmbVisitasAsignadas.BgColorClick = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.LmbVisitasAsignadas.BgColorDefault = System.Drawing.Color.Empty
        Me.LmbVisitasAsignadas.BgColorHover = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.LmbVisitasAsignadas.BgColorSelected = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.LmbVisitasAsignadas.FlatAppearance.BorderSize = 0
        Me.LmbVisitasAsignadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.LmbVisitasAsignadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.LmbVisitasAsignadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LmbVisitasAsignadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LmbVisitasAsignadas.ForeColor = System.Drawing.Color.White
        Me.LmbVisitasAsignadas.Image = Global.Inmobiliaria.My.Resources.Resources.assignment_ind_white_24x24
        Me.LmbVisitasAsignadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LmbVisitasAsignadas.LeftBarColorDefault = System.Drawing.Color.Empty
        Me.LmbVisitasAsignadas.LeftBarColorHover = System.Drawing.Color.Empty
        Me.LmbVisitasAsignadas.LeftBarColorSelected = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.LmbVisitasAsignadas.Location = New System.Drawing.Point(0, 100)
        Me.LmbVisitasAsignadas.Margin = New System.Windows.Forms.Padding(0)
        Me.LmbVisitasAsignadas.Name = "LmbVisitasAsignadas"
        Me.LmbVisitasAsignadas.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.LmbVisitasAsignadas.Selected = False
        Me.LmbVisitasAsignadas.Size = New System.Drawing.Size(226, 50)
        Me.LmbVisitasAsignadas.TabIndex = 6
        Me.LmbVisitasAsignadas.Text = "  Visitas Asignadas"
        Me.LmbVisitasAsignadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LmbVisitasAsignadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LmbVisitasAsignadas.UseVisualStyleBackColor = True
        '
        'lmbVisitasModificadas
        '
        Me.lmbVisitasModificadas.BgColorClick = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbVisitasModificadas.BgColorDefault = System.Drawing.Color.Empty
        Me.lmbVisitasModificadas.BgColorHover = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbVisitasModificadas.BgColorSelected = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lmbVisitasModificadas.FlatAppearance.BorderSize = 0
        Me.lmbVisitasModificadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbVisitasModificadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbVisitasModificadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lmbVisitasModificadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmbVisitasModificadas.ForeColor = System.Drawing.Color.White
        Me.lmbVisitasModificadas.Image = Global.Inmobiliaria.My.Resources.Resources.calendar_edit
        Me.lmbVisitasModificadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbVisitasModificadas.LeftBarColorDefault = System.Drawing.Color.Empty
        Me.lmbVisitasModificadas.LeftBarColorHover = System.Drawing.Color.Empty
        Me.lmbVisitasModificadas.LeftBarColorSelected = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lmbVisitasModificadas.Location = New System.Drawing.Point(0, 150)
        Me.lmbVisitasModificadas.Margin = New System.Windows.Forms.Padding(0)
        Me.lmbVisitasModificadas.Name = "lmbVisitasModificadas"
        Me.lmbVisitasModificadas.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lmbVisitasModificadas.Selected = False
        Me.lmbVisitasModificadas.Size = New System.Drawing.Size(226, 50)
        Me.lmbVisitasModificadas.TabIndex = 3
        Me.lmbVisitasModificadas.Text = "  Visitas Modificadas"
        Me.lmbVisitasModificadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbVisitasModificadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lmbVisitasModificadas.UseVisualStyleBackColor = True
        '
        'lmbVisitasCanceladas
        '
        Me.lmbVisitasCanceladas.BgColorClick = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbVisitasCanceladas.BgColorDefault = System.Drawing.Color.Empty
        Me.lmbVisitasCanceladas.BgColorHover = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbVisitasCanceladas.BgColorSelected = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lmbVisitasCanceladas.FlatAppearance.BorderSize = 0
        Me.lmbVisitasCanceladas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbVisitasCanceladas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbVisitasCanceladas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lmbVisitasCanceladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmbVisitasCanceladas.ForeColor = System.Drawing.Color.White
        Me.lmbVisitasCanceladas.Image = Global.Inmobiliaria.My.Resources.Resources.calendar_cancel
        Me.lmbVisitasCanceladas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbVisitasCanceladas.LeftBarColorDefault = System.Drawing.Color.Empty
        Me.lmbVisitasCanceladas.LeftBarColorHover = System.Drawing.Color.Empty
        Me.lmbVisitasCanceladas.LeftBarColorSelected = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lmbVisitasCanceladas.Location = New System.Drawing.Point(0, 200)
        Me.lmbVisitasCanceladas.Margin = New System.Windows.Forms.Padding(0)
        Me.lmbVisitasCanceladas.Name = "lmbVisitasCanceladas"
        Me.lmbVisitasCanceladas.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lmbVisitasCanceladas.Selected = False
        Me.lmbVisitasCanceladas.Size = New System.Drawing.Size(226, 50)
        Me.lmbVisitasCanceladas.TabIndex = 2
        Me.lmbVisitasCanceladas.Text = "  Visitas Canceladas"
        Me.lmbVisitasCanceladas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbVisitasCanceladas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lmbVisitasCanceladas.UseVisualStyleBackColor = True
        '
        'lmbEmpleados
        '
        Me.lmbEmpleados.BgColorClick = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbEmpleados.BgColorDefault = System.Drawing.Color.Empty
        Me.lmbEmpleados.BgColorHover = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbEmpleados.BgColorSelected = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lmbEmpleados.FlatAppearance.BorderSize = 0
        Me.lmbEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lmbEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmbEmpleados.ForeColor = System.Drawing.Color.White
        Me.lmbEmpleados.Image = Global.Inmobiliaria.My.Resources.Resources.icons8_User_24px
        Me.lmbEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbEmpleados.LeftBarColorDefault = System.Drawing.Color.Empty
        Me.lmbEmpleados.LeftBarColorHover = System.Drawing.Color.Empty
        Me.lmbEmpleados.LeftBarColorSelected = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lmbEmpleados.Location = New System.Drawing.Point(0, 250)
        Me.lmbEmpleados.Margin = New System.Windows.Forms.Padding(0)
        Me.lmbEmpleados.Name = "lmbEmpleados"
        Me.lmbEmpleados.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lmbEmpleados.Selected = False
        Me.lmbEmpleados.Size = New System.Drawing.Size(226, 50)
        Me.lmbEmpleados.TabIndex = 4
        Me.lmbEmpleados.Text = "  Empleados"
        Me.lmbEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lmbEmpleados.UseVisualStyleBackColor = True
        '
        'lmbClientes
        '
        Me.lmbClientes.BgColorClick = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbClientes.BgColorDefault = System.Drawing.Color.Empty
        Me.lmbClientes.BgColorHover = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbClientes.BgColorSelected = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lmbClientes.FlatAppearance.BorderSize = 0
        Me.lmbClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lmbClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lmbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmbClientes.ForeColor = System.Drawing.Color.White
        Me.lmbClientes.Image = Global.Inmobiliaria.My.Resources.Resources.icons8_User_24px
        Me.lmbClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbClientes.LeftBarColorDefault = System.Drawing.Color.Empty
        Me.lmbClientes.LeftBarColorHover = System.Drawing.Color.Empty
        Me.lmbClientes.LeftBarColorSelected = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lmbClientes.Location = New System.Drawing.Point(0, 300)
        Me.lmbClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.lmbClientes.Name = "lmbClientes"
        Me.lmbClientes.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lmbClientes.Selected = False
        Me.lmbClientes.Size = New System.Drawing.Size(226, 50)
        Me.lmbClientes.TabIndex = 5
        Me.lmbClientes.Text = "  Clientes"
        Me.lmbClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lmbClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lmbClientes.UseVisualStyleBackColor = True
        '
        'WindowAction
        '
        Me.WindowAction.CloseButton = Me.btnClose
        Me.WindowAction.ContainerControl = Me
        Me.WindowAction.MaximizeBitmap = Global.Inmobiliaria.My.Resources.Resources.arrow_up_white
        Me.WindowAction.MaximizeButton = Me.btnMaxRest
        Me.WindowAction.MinimizeButton = Me.btnMinimize
        Me.WindowAction.RestoreBitmap = Global.Inmobiliaria.My.Resources.Resources.arrow_down_white
        Me.WindowAction.ShowShadow = False
        Me.WindowAction.TitleBar = Me.lvlTopBarText
        '
        'FormEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 640)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.FlowLayoutPanel5)
        Me.Controls.Add(Me.TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1250, 640)
        Me.Name = "FormEmpleado"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormularioEmpleado"
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.panelContenido.ResumeLayout(False)
        Me.tlpClientes.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.TableLayoutPanel23.ResumeLayout(False)
        Me.TableLayoutPanel23.PerformLayout()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.TableLayoutPanel25.ResumeLayout(False)
        Me.TableLayoutPanel25.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpEmpleados.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.TableLayoutPanel22.ResumeLayout(False)
        Me.TableLayoutPanel22.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPropiedades.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel20.ResumeLayout(False)
        Me.TableLayoutPanel20.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel21.ResumeLayout(False)
        Me.TableLayoutPanel21.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.nudPropiedadMaxHabs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPropiedadMinHabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.nudPropiedadMaxMts2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPropiedadMinMts2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.nudPropiedadMaxPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPropiedadMinPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPropiedadImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPropiedadHerramientas.ResumeLayout(False)
        Me.tlpPropiedadHerramientas.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.dgvPropiedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpVisitasModificadas.ResumeLayout(False)
        CType(Me.dgvModificadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.TableLayoutPanel19.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.tlpVisitasCanceladas.ResumeLayout(False)
        CType(Me.dgvCanceladas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel16.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel17.ResumeLayout(False)
        Me.TableLayoutPanel17.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.TableLayoutPanel18.ResumeLayout(False)
        Me.TableLayoutPanel18.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.TlpVisitasAsignadas.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        Me.TableLayoutPanel24.ResumeLayout(False)
        Me.TableLayoutPanel24.PerformLayout()
        Me.TableLayoutPanel26.ResumeLayout(False)
        Me.TableLayoutPanel27.ResumeLayout(False)
        Me.TableLayoutPanel27.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        CType(Me.DgvVisitasAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpAgenda.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.DgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopBar As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaxRest As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lvlTopBarText As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents panelContenido As Panel
    Friend WithEvents tlpAgenda As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents btnAgendaBuscar As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label33 As Label
    Friend WithEvents tlpPropiedades As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pbxPropiedadImagen As PictureBox
    Friend WithEvents tlpPropiedadHerramientas As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnPropiedadAgregar As Button
    Friend WithEvents btnPropiedadEliminar As Button
    Friend WithEvents btnPropiedadEditar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents chbAgendaPorUsuario As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents dtpAgendaFechaMax As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents dtpAgendaFechaMin As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents mtbAgendaCiCliente As MaskedTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tbxAgendaApellCliente As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbxAgendaNomCliente As TextBox
    Friend WithEvents chbAgendaPorFecha As CheckBox
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents btnAgendaCancelVisita As Button
    Friend WithEvents btnAgendaModifVisita As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents tlpVisitasCanceladas As TableLayoutPanel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents tlpVisitasModificadas As TableLayoutPanel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents WindowAction As WindowAction
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnPropiedadBuscar As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel20 As TableLayoutPanel
    Friend WithEvents chbPropiedadPorUbic As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbxPropiedadLoc As ComboBox
    Friend WithEvents cbxPropiedadDepart As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TableLayoutPanel21 As TableLayoutPanel
    Friend WithEvents chbPropiedadPorTipo As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cbxPropiedadTipo As ComboBox
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents chbPropiedadPorOperac As CheckBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents cbxPropiedadOperac As ComboBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents chbPropiedadPorHabs As CheckBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents nudPropiedadMaxHabs As NumericUpDown
    Friend WithEvents nudPropiedadMinHabs As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents chbPropiedadPorMts2 As CheckBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents nudPropiedadMaxMts2 As NumericUpDown
    Friend WithEvents nudPropiedadMinMts2 As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents nudPropiedadMaxPrecio As NumericUpDown
    Friend WithEvents nudPropiedadMinPrecio As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents chbPropiedadPorPrecio As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPropiedades As DataGridView
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents btnModifBuscar As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents mtbModifCiCliente As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chbModifPorCliente As CheckBox
    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents dtpModifFechaMax As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpModifFechaMin As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents chbModifPorFecha As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents btnCancelBuscar As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel17 As TableLayoutPanel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents mtbCancelCiCliente As MaskedTextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents chbCancelPorCliente As CheckBox
    Friend WithEvents TableLayoutPanel18 As TableLayoutPanel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents dtpCancelFechMax As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents dtpCancelFechMin As DateTimePicker
    Friend WithEvents Label28 As Label
    Friend WithEvents chbCancelPorFecha As CheckBox
    Friend WithEvents Label29 As Label
    Friend WithEvents DgvAgenda As DataGridView
    Friend WithEvents dgvModificadas As DataGridView
    Friend WithEvents dgvCanceladas As DataGridView
    Friend WithEvents btnAgendaVerVisita As Button
    Friend WithEvents btnAgendaAceptarVisita As Button
    Friend WithEvents tbxModifClienteApellido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbxModifClienteNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxCancelClienteApellido As TextBox
    Friend WithEvents tbxCancelClienteNombre As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tlpEmpleados As TableLayoutPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents Label24 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents tbxEmpleadosApellido As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents tbxEmpleadosNombre As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents mtbEmpleadosCi As MaskedTextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents chbEmpleadosBuscarPorCi As CheckBox
    Friend WithEvents TableLayoutPanel22 As TableLayoutPanel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents chbEmpleadosBuscarPorSucursal As CheckBox
    Friend WithEvents cbxEmpleadosSucursal As ComboBox
    Friend WithEvents btnEmpleadosBuscar As Button
    Friend WithEvents Panel22 As Panel
    Friend WithEvents tlpClientes As TableLayoutPanel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents btnClientesBuscar As Button
    Friend WithEvents TableLayoutPanel25 As TableLayoutPanel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents tbxClientesApellido As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents tbxClientesNombre As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents mtbClientesCi As MaskedTextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents chbClientesBuscarPorCI As CheckBox
    Friend WithEvents Label40 As Label
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents TableLayoutPanel23 As TableLayoutPanel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents tbxClientesCorreo As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents chbClientesBuscarPorCorreo As CheckBox
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents lmbPropiedades As ListMenuButton
    Friend WithEvents lmbAgenda As ListMenuButton
    Friend WithEvents lmbVisitasModificadas As ListMenuButton
    Friend WithEvents lmbVisitasCanceladas As ListMenuButton
    Friend WithEvents lmbEmpleados As ListMenuButton
    Friend WithEvents lmbClientes As ListMenuButton
    Friend WithEvents btnClientesRegistro As Button
    Friend WithEvents btnClientesDeshabilitar As Button
    Friend WithEvents btnEmpleadosRegistro As Button
    Friend WithEvents btnClientesEditar As Button
    Friend WithEvents btnEmpleadosEditar As Button
    Friend WithEvents chbEmpleadosMostrarDeshabilitados As CheckBox
    Friend WithEvents btnEmpleadosDeshabilitar As Button
    Friend WithEvents chbClientesMostrarDeshabilitados As CheckBox
    Friend WithEvents btnClientesAgregarAEmpleado As Button
    Friend WithEvents btnEmpleadosAgregarACliente As Button
    Friend WithEvents LmbVisitasAsignadas As ListMenuButton
    Friend WithEvents TlpVisitasAsignadas As TableLayoutPanel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents TableLayoutPanel24 As TableLayoutPanel
    Friend WithEvents BtnVisitasAsignadasVer As Button
    Friend WithEvents TableLayoutPanel26 As TableLayoutPanel
    Friend WithEvents BtnVisitasAsignadasCancelar As Button
    Friend WithEvents BtnVisitasAsignadasEditar As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents TableLayoutPanel27 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents Label47 As Label
    Friend WithEvents DgvVisitasAsignadas As DataGridView
    Friend WithEvents RbtVisitasAsignadasDia As RadioButton
    Friend WithEvents RbtVisitasAsignadas7Dias As RadioButton
    Friend WithEvents RbtVisitasAsignadas30Dias As RadioButton
    Friend WithEvents RbtVisitasAsignadasTodas As RadioButton
End Class
