<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCliente))
        Me.TopBar = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TopBarText = New System.Windows.Forms.Label()
        Me.btnMaxRest = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel20 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPorUbicacion = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbxLocalidad = New System.Windows.Forms.ComboBox()
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel21 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPorTipo = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPorOperacion = New System.Windows.Forms.CheckBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.cbxOperacion = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPorHabitaciones = New System.Windows.Forms.CheckBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.nudMaxHabs = New System.Windows.Forms.NumericUpDown()
        Me.nudMinHabs = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.chbPorMts2 = New System.Windows.Forms.CheckBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.nudMaxMts2 = New System.Windows.Forms.NumericUpDown()
        Me.nudMinMts2 = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.nudMaxPrecio = New System.Windows.Forms.NumericUpDown()
        Me.nudMinPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chbPorPrecio = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbxImagen = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpFechaHora = New System.Windows.Forms.DateTimePicker()
        Me.btnAgendar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPropiedades = New System.Windows.Forms.DataGridView()
        Me.WindowAction = New Inmobiliaria.WindowAction()
        Me.TopBar.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        CType(Me.nudMaxHabs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinHabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.nudMaxMts2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinMts2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.nudMaxPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPropiedades, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TopBar.Controls.Add(Me.TopBarText, 1, 0)
        Me.TopBar.Controls.Add(Me.btnMaxRest, 3, 0)
        Me.TopBar.Controls.Add(Me.btnClose, 4, 0)
        Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBar.Location = New System.Drawing.Point(1, 1)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.RowCount = 1
        Me.TopBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TopBar.Size = New System.Drawing.Size(1164, 40)
        Me.TopBar.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.Inmobiliaria.My.Resources.Resources.icons8_Subtract_16px
        Me.btnMinimize.Location = New System.Drawing.Point(1044, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimize.TabIndex = 3
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
        'TopBarText
        '
        Me.TopBarText.AutoSize = True
        Me.TopBarText.BackColor = System.Drawing.Color.Transparent
        Me.TopBarText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopBarText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopBarText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TopBarText.Location = New System.Drawing.Point(43, 0)
        Me.TopBarText.Name = "TopBarText"
        Me.TopBarText.Padding = New System.Windows.Forms.Padding(10)
        Me.TopBarText.Size = New System.Drawing.Size(998, 40)
        Me.TopBarText.TabIndex = 4
        Me.TopBarText.Text = "Cliente"
        Me.TopBarText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMaxRest
        '
        Me.btnMaxRest.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnMaxRest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMaxRest.FlatAppearance.BorderSize = 0
        Me.btnMaxRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaxRest.Image = Global.Inmobiliaria.My.Resources.Resources.arrow_up_white
        Me.btnMaxRest.Location = New System.Drawing.Point(1084, 0)
        Me.btnMaxRest.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMaxRest.Name = "btnMaxRest"
        Me.btnMaxRest.Size = New System.Drawing.Size(40, 40)
        Me.btnMaxRest.TabIndex = 5
        Me.btnMaxRest.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Inmobiliaria.My.Resources.Resources.delete
        Me.btnClose.Location = New System.Drawing.Point(1124, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.pbxImagen)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(815, 41)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(350, 608)
        Me.Panel2.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnBuscar, 0, 2)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(350, 323)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscar.Location = New System.Drawing.Point(5, 280)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(340, 38)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(344, 229)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel20
        '
        Me.TableLayoutPanel20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel20.ColumnCount = 1
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel20.Controls.Add(Me.chbPorUbicacion, 0, 0)
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
        'chbPorUbicacion
        '
        Me.chbPorUbicacion.AutoSize = True
        Me.chbPorUbicacion.BackColor = System.Drawing.Color.LightGray
        Me.chbPorUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPorUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chbPorUbicacion.Location = New System.Drawing.Point(0, 0)
        Me.chbPorUbicacion.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPorUbicacion.Name = "chbPorUbicacion"
        Me.chbPorUbicacion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPorUbicacion.Size = New System.Drawing.Size(320, 30)
        Me.chbPorUbicacion.TabIndex = 3
        Me.chbPorUbicacion.Text = "Buscar por ubicación"
        Me.chbPorUbicacion.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cbxLocalidad)
        Me.Panel4.Controls.Add(Me.cbxDepartamento)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(314, 77)
        Me.Panel4.TabIndex = 1
        '
        'cbxLocalidad
        '
        Me.cbxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cbxLocalidad.FormattingEnabled = True
        Me.cbxLocalidad.Location = New System.Drawing.Point(111, 41)
        Me.cbxLocalidad.Name = "cbxLocalidad"
        Me.cbxLocalidad.Size = New System.Drawing.Size(189, 24)
        Me.cbxLocalidad.TabIndex = 1
        '
        'cbxDepartamento
        '
        Me.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.Location = New System.Drawing.Point(110, 11)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(189, 24)
        Me.cbxDepartamento.TabIndex = 1
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
        Me.TableLayoutPanel21.Controls.Add(Me.chbPorTipo, 0, 0)
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
        'chbPorTipo
        '
        Me.chbPorTipo.AutoSize = True
        Me.chbPorTipo.BackColor = System.Drawing.Color.LightGray
        Me.chbPorTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPorTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPorTipo.Location = New System.Drawing.Point(0, 0)
        Me.chbPorTipo.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPorTipo.Name = "chbPorTipo"
        Me.chbPorTipo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPorTipo.Size = New System.Drawing.Size(320, 30)
        Me.chbPorTipo.TabIndex = 3
        Me.chbPorTipo.Text = "Buscar por tipo de propiedad"
        Me.chbPorTipo.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cbxTipo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 33)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(314, 45)
        Me.Panel5.TabIndex = 1
        '
        'cbxTipo
        '
        Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Casa", "Apartamento", "Local Comercial"})
        Me.cbxTipo.Location = New System.Drawing.Point(16, 11)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(285, 24)
        Me.cbxTipo.TabIndex = 1
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.chbPorOperacion, 0, 0)
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
        'chbPorOperacion
        '
        Me.chbPorOperacion.AutoSize = True
        Me.chbPorOperacion.BackColor = System.Drawing.Color.LightGray
        Me.chbPorOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPorOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPorOperacion.Location = New System.Drawing.Point(0, 0)
        Me.chbPorOperacion.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPorOperacion.Name = "chbPorOperacion"
        Me.chbPorOperacion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPorOperacion.Size = New System.Drawing.Size(320, 30)
        Me.chbPorOperacion.TabIndex = 3
        Me.chbPorOperacion.Text = "Buscar por operación ( Alquiler / Venta )"
        Me.chbPorOperacion.UseVisualStyleBackColor = False
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.cbxOperacion)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(3, 33)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(314, 45)
        Me.Panel21.TabIndex = 1
        '
        'cbxOperacion
        '
        Me.cbxOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOperacion.FormattingEnabled = True
        Me.cbxOperacion.Items.AddRange(New Object() {"Alquiler", "Venta"})
        Me.cbxOperacion.Location = New System.Drawing.Point(16, 11)
        Me.cbxOperacion.Name = "cbxOperacion"
        Me.cbxOperacion.Size = New System.Drawing.Size(285, 24)
        Me.cbxOperacion.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.chbPorHabitaciones, 0, 0)
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
        'chbPorHabitaciones
        '
        Me.chbPorHabitaciones.AutoSize = True
        Me.chbPorHabitaciones.BackColor = System.Drawing.Color.LightGray
        Me.chbPorHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPorHabitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPorHabitaciones.Location = New System.Drawing.Point(0, 0)
        Me.chbPorHabitaciones.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPorHabitaciones.Name = "chbPorHabitaciones"
        Me.chbPorHabitaciones.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPorHabitaciones.Size = New System.Drawing.Size(320, 30)
        Me.chbPorHabitaciones.TabIndex = 3
        Me.chbPorHabitaciones.Text = "Buscar por número de habitaciones"
        Me.chbPorHabitaciones.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.nudMaxHabs)
        Me.Panel10.Controls.Add(Me.nudMinHabs)
        Me.Panel10.Controls.Add(Me.Label11)
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(3, 33)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(314, 37)
        Me.Panel10.TabIndex = 1
        '
        'nudMaxHabs
        '
        Me.nudMaxHabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMaxHabs.Location = New System.Drawing.Point(216, 8)
        Me.nudMaxHabs.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMaxHabs.Name = "nudMaxHabs"
        Me.nudMaxHabs.Size = New System.Drawing.Size(85, 22)
        Me.nudMaxHabs.TabIndex = 7
        '
        'nudMinHabs
        '
        Me.nudMinHabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMinHabs.Location = New System.Drawing.Point(68, 8)
        Me.nudMinHabs.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudMinHabs.Name = "nudMinHabs"
        Me.nudMinHabs.Size = New System.Drawing.Size(84, 22)
        Me.nudMinHabs.TabIndex = 6
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
        Me.TableLayoutPanel6.Controls.Add(Me.chbPorMts2, 0, 0)
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
        'chbPorMts2
        '
        Me.chbPorMts2.AutoSize = True
        Me.chbPorMts2.BackColor = System.Drawing.Color.LightGray
        Me.chbPorMts2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPorMts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPorMts2.Location = New System.Drawing.Point(0, 0)
        Me.chbPorMts2.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPorMts2.Name = "chbPorMts2"
        Me.chbPorMts2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPorMts2.Size = New System.Drawing.Size(320, 30)
        Me.chbPorMts2.TabIndex = 3
        Me.chbPorMts2.Text = "Buscar por mts²"
        Me.chbPorMts2.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.nudMaxMts2)
        Me.Panel11.Controls.Add(Me.nudMinMts2)
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Controls.Add(Me.Label14)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(3, 33)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(314, 37)
        Me.Panel11.TabIndex = 1
        '
        'nudMaxMts2
        '
        Me.nudMaxMts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMaxMts2.Location = New System.Drawing.Point(216, 8)
        Me.nudMaxMts2.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudMaxMts2.Name = "nudMaxMts2"
        Me.nudMaxMts2.Size = New System.Drawing.Size(85, 22)
        Me.nudMaxMts2.TabIndex = 7
        '
        'nudMinMts2
        '
        Me.nudMinMts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMinMts2.Location = New System.Drawing.Point(68, 8)
        Me.nudMinMts2.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudMinMts2.Name = "nudMinMts2"
        Me.nudMinMts2.Size = New System.Drawing.Size(84, 22)
        Me.nudMinMts2.TabIndex = 6
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
        Me.TableLayoutPanel7.Controls.Add(Me.chbPorPrecio, 0, 0)
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
        Me.Panel12.Controls.Add(Me.nudMaxPrecio)
        Me.Panel12.Controls.Add(Me.nudMinPrecio)
        Me.Panel12.Controls.Add(Me.Label16)
        Me.Panel12.Controls.Add(Me.Label17)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(3, 33)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(314, 39)
        Me.Panel12.TabIndex = 1
        '
        'nudMaxPrecio
        '
        Me.nudMaxPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMaxPrecio.Location = New System.Drawing.Point(216, 9)
        Me.nudMaxPrecio.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudMaxPrecio.Name = "nudMaxPrecio"
        Me.nudMaxPrecio.Size = New System.Drawing.Size(85, 22)
        Me.nudMaxPrecio.TabIndex = 21
        '
        'nudMinPrecio
        '
        Me.nudMinPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMinPrecio.Location = New System.Drawing.Point(68, 9)
        Me.nudMinPrecio.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudMinPrecio.Name = "nudMinPrecio"
        Me.nudMinPrecio.Size = New System.Drawing.Size(84, 22)
        Me.nudMinPrecio.TabIndex = 8
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
        'chbPorPrecio
        '
        Me.chbPorPrecio.AutoSize = True
        Me.chbPorPrecio.BackColor = System.Drawing.Color.LightGray
        Me.chbPorPrecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbPorPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPorPrecio.Location = New System.Drawing.Point(0, 0)
        Me.chbPorPrecio.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPorPrecio.Name = "chbPorPrecio"
        Me.chbPorPrecio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbPorPrecio.Size = New System.Drawing.Size(320, 30)
        Me.chbPorPrecio.TabIndex = 2
        Me.chbPorPrecio.Text = "Buscar por precio (dolares americanos)"
        Me.chbPorPrecio.UseVisualStyleBackColor = False
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
        'pbxImagen
        '
        Me.pbxImagen.BackgroundImage = Global.Inmobiliaria.My.Resources.Resources.image_preview_default1
        Me.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxImagen.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxImagen.Location = New System.Drawing.Point(0, 0)
        Me.pbxImagen.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(350, 195)
        Me.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxImagen.TabIndex = 0
        Me.pbxImagen.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 518)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(350, 90)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.22093!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.77907!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnAgendar, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 43)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(344, 44)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.dtpFechaHora)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 38)
        Me.Panel1.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 16)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Fecha y Hora"
        '
        'dtpFechaHora
        '
        Me.dtpFechaHora.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpFechaHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaHora.Location = New System.Drawing.Point(96, 8)
        Me.dtpFechaHora.Name = "dtpFechaHora"
        Me.dtpFechaHora.Size = New System.Drawing.Size(136, 22)
        Me.dtpFechaHora.TabIndex = 0
        '
        'btnAgendar
        '
        Me.btnAgendar.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnAgendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnAgendar.FlatAppearance.BorderSize = 2
        Me.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgendar.Location = New System.Drawing.Point(248, 3)
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Size = New System.Drawing.Size(93, 38)
        Me.btnAgendar.TabIndex = 1
        Me.btnAgendar.Text = "AGENDAR"
        Me.btnAgendar.UseVisualStyleBackColor = False
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
        Me.Label2.Text = "Agendar fecha y Hora de visita"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvPropiedades
        '
        Me.dgvPropiedades.AllowUserToAddRows = False
        Me.dgvPropiedades.AllowUserToDeleteRows = False
        Me.dgvPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPropiedades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPropiedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPropiedades.Location = New System.Drawing.Point(1, 41)
        Me.dgvPropiedades.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvPropiedades.MultiSelect = False
        Me.dgvPropiedades.Name = "dgvPropiedades"
        Me.dgvPropiedades.ReadOnly = True
        Me.dgvPropiedades.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPropiedades.Size = New System.Drawing.Size(814, 608)
        Me.dgvPropiedades.TabIndex = 4
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
        Me.WindowAction.TitleBar = Me.TopBarText
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1166, 650)
        Me.Controls.Add(Me.dgvPropiedades)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1166, 650)
        Me.Name = "FormCliente"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormularioCliente"
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.Panel2.ResumeLayout(False)
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
        CType(Me.nudMaxHabs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinHabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.nudMaxMts2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinMts2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.nudMaxPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPropiedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents TopBar As TableLayoutPanel
    Friend WithEvents TopBarText As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaxRest As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbxImagen As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpFechaHora As DateTimePicker
    Friend WithEvents btnAgendar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel20 As TableLayoutPanel
    Friend WithEvents chbPorUbicacion As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbxLocalidad As ComboBox
    Friend WithEvents cbxDepartamento As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TableLayoutPanel21 As TableLayoutPanel
    Friend WithEvents chbPorTipo As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents chbPorOperacion As CheckBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents cbxOperacion As ComboBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents chbPorHabitaciones As CheckBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents nudMaxHabs As NumericUpDown
    Friend WithEvents nudMinHabs As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents chbPorMts2 As CheckBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents nudMaxMts2 As NumericUpDown
    Friend WithEvents nudMinMts2 As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents nudMaxPrecio As NumericUpDown
    Friend WithEvents nudMinPrecio As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents chbPorPrecio As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WindowAction As WindowAction
    Friend WithEvents dgvPropiedades As DataGridView
    Friend WithEvents Label18 As Label
End Class
