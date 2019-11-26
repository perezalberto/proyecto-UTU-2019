<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TopBarText = New System.Windows.Forms.Label()
        Me.WindowAction = New Inmobiliaria.WindowAction()
        Me.panelCliente = New System.Windows.Forms.Panel()
        Me.btnInicioCliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbCiCliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelEmpleado = New System.Windows.Forms.Panel()
        Me.RbtGerente = New System.Windows.Forms.RadioButton()
        Me.RbtAgente = New System.Windows.Forms.RadioButton()
        Me.btnInicioEmpleado = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtbCiEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxPasswordEmpleado = New System.Windows.Forms.TextBox()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panelCliente.SuspendLayout()
        Me.panelEmpleado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnConfig, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnMinimize, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnClose, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TopBarText, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(984, 40)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Image = Global.Inmobiliaria.My.Resources.Resources.settings
        Me.btnConfig.Location = New System.Drawing.Point(0, 0)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(40, 40)
        Me.btnConfig.TabIndex = 0
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(904, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(944, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 2
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'TopBarText
        '
        Me.TopBarText.AutoSize = True
        Me.TopBarText.BackColor = System.Drawing.Color.Transparent
        Me.TopBarText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopBarText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopBarText.ForeColor = System.Drawing.Color.White
        Me.TopBarText.Location = New System.Drawing.Point(43, 0)
        Me.TopBarText.Name = "TopBarText"
        Me.TopBarText.Padding = New System.Windows.Forms.Padding(10)
        Me.TopBarText.Size = New System.Drawing.Size(858, 40)
        Me.TopBarText.TabIndex = 3
        Me.TopBarText.Text = "Inicio de sesión"
        Me.TopBarText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WindowAction
        '
        Me.WindowAction.CloseButton = Me.btnClose
        Me.WindowAction.ContainerControl = Me
        Me.WindowAction.MaximizeBitmap = Nothing
        Me.WindowAction.MaximizeButton = Nothing
        Me.WindowAction.MinimizeButton = Me.btnMinimize
        Me.WindowAction.RestoreBitmap = Nothing
        Me.WindowAction.ShowShadow = False
        Me.WindowAction.TitleBar = Me.TopBarText
        '
        'panelCliente
        '
        Me.panelCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelCliente.Controls.Add(Me.btnInicioCliente)
        Me.panelCliente.Controls.Add(Me.Label2)
        Me.panelCliente.Controls.Add(Me.mtbCiCliente)
        Me.panelCliente.Controls.Add(Me.Label1)
        Me.panelCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCliente.Location = New System.Drawing.Point(70, 110)
        Me.panelCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.panelCliente.MaximumSize = New System.Drawing.Size(348, 369)
        Me.panelCliente.MinimumSize = New System.Drawing.Size(348, 369)
        Me.panelCliente.Name = "panelCliente"
        Me.panelCliente.Size = New System.Drawing.Size(348, 369)
        Me.panelCliente.TabIndex = 17
        '
        'btnInicioCliente
        '
        Me.btnInicioCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnInicioCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnInicioCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInicioCliente.Location = New System.Drawing.Point(76, 256)
        Me.btnInicioCliente.Name = "btnInicioCliente"
        Me.btnInicioCliente.Size = New System.Drawing.Size(202, 50)
        Me.btnInicioCliente.TabIndex = 6
        Me.btnInicioCliente.Text = "Iniciar sesión"
        Me.btnInicioCliente.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(70, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CI"
        '
        'mtbCiCliente
        '
        Me.mtbCiCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCiCliente.Location = New System.Drawing.Point(96, 150)
        Me.mtbCiCliente.Mask = "0000000-0"
        Me.mtbCiCliente.Name = "mtbCiCliente"
        Me.mtbCiCliente.Size = New System.Drawing.Size(182, 22)
        Me.mtbCiCliente.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(121, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'panelEmpleado
        '
        Me.panelEmpleado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelEmpleado.Controls.Add(Me.RbtGerente)
        Me.panelEmpleado.Controls.Add(Me.RbtAgente)
        Me.panelEmpleado.Controls.Add(Me.btnInicioEmpleado)
        Me.panelEmpleado.Controls.Add(Me.Label3)
        Me.panelEmpleado.Controls.Add(Me.mtbCiEmpleado)
        Me.panelEmpleado.Controls.Add(Me.Label4)
        Me.panelEmpleado.Controls.Add(Me.Label5)
        Me.panelEmpleado.Controls.Add(Me.tbxPasswordEmpleado)
        Me.panelEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEmpleado.Location = New System.Drawing.Point(70, 110)
        Me.panelEmpleado.Margin = New System.Windows.Forms.Padding(0)
        Me.panelEmpleado.MaximumSize = New System.Drawing.Size(348, 369)
        Me.panelEmpleado.MinimumSize = New System.Drawing.Size(348, 369)
        Me.panelEmpleado.Name = "panelEmpleado"
        Me.panelEmpleado.Size = New System.Drawing.Size(348, 369)
        Me.panelEmpleado.TabIndex = 18
        Me.panelEmpleado.Visible = False
        '
        'RbtGerente
        '
        Me.RbtGerente.AutoSize = True
        Me.RbtGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtGerente.Location = New System.Drawing.Point(204, 212)
        Me.RbtGerente.Name = "RbtGerente"
        Me.RbtGerente.Size = New System.Drawing.Size(74, 20)
        Me.RbtGerente.TabIndex = 13
        Me.RbtGerente.Text = "Gerente"
        Me.RbtGerente.UseVisualStyleBackColor = True
        '
        'RbtAgente
        '
        Me.RbtAgente.AutoSize = True
        Me.RbtAgente.Checked = True
        Me.RbtAgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtAgente.Location = New System.Drawing.Point(76, 212)
        Me.RbtAgente.Name = "RbtAgente"
        Me.RbtAgente.Size = New System.Drawing.Size(69, 20)
        Me.RbtAgente.TabIndex = 12
        Me.RbtAgente.TabStop = True
        Me.RbtAgente.Text = "Agente"
        Me.RbtAgente.UseVisualStyleBackColor = True
        '
        'btnInicioEmpleado
        '
        Me.btnInicioEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnInicioEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnInicioEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInicioEmpleado.Location = New System.Drawing.Point(76, 253)
        Me.btnInicioEmpleado.Name = "btnInicioEmpleado"
        Me.btnInicioEmpleado.Size = New System.Drawing.Size(202, 50)
        Me.btnInicioEmpleado.TabIndex = 11
        Me.btnInicioEmpleado.Text = "Iniciar sesión"
        Me.btnInicioEmpleado.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(114, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CI"
        '
        'mtbCiEmpleado
        '
        Me.mtbCiEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCiEmpleado.Location = New System.Drawing.Point(140, 122)
        Me.mtbCiEmpleado.Mask = "0000000-0"
        Me.mtbCiEmpleado.Name = "mtbCiEmpleado"
        Me.mtbCiEmpleado.Size = New System.Drawing.Size(138, 22)
        Me.mtbCiEmpleado.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(101, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Empleado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(57, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contraseña"
        '
        'tbxPasswordEmpleado
        '
        Me.tbxPasswordEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxPasswordEmpleado.Location = New System.Drawing.Point(140, 168)
        Me.tbxPasswordEmpleado.Name = "tbxPasswordEmpleado"
        Me.tbxPasswordEmpleado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPasswordEmpleado.Size = New System.Drawing.Size(138, 22)
        Me.tbxPasswordEmpleado.TabIndex = 10
        '
        'btnEmpleado
        '
        Me.btnEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnEmpleado.FlatAppearance.BorderSize = 3
        Me.btnEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnEmpleado.Location = New System.Drawing.Point(142, 331)
        Me.btnEmpleado.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(244, 85)
        Me.btnEmpleado.TabIndex = 4
        Me.btnEmpleado.Text = "EMPLEADO"
        Me.btnEmpleado.UseVisualStyleBackColor = False
        '
        'btnCliente
        '
        Me.btnCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnCliente.FlatAppearance.BorderSize = 2
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCliente.Location = New System.Drawing.Point(142, 162)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(244, 84)
        Me.btnCliente.TabIndex = 3
        Me.btnCliente.Text = "CLIENTE"
        Me.btnCliente.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEmpleado)
        Me.Panel1.Controls.Add(Me.btnCliente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 589)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.panelCliente)
        Me.Panel2.Controls.Add(Me.panelEmpleado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(455, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(70, 110, 70, 110)
        Me.Panel2.Size = New System.Drawing.Size(529, 589)
        Me.Panel2.TabIndex = 20
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 629)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.panelCliente.ResumeLayout(False)
        Me.panelCliente.PerformLayout()
        Me.panelEmpleado.ResumeLayout(False)
        Me.panelEmpleado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnConfig As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents TopBarText As Label
    Friend WithEvents WindowAction As WindowAction
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelCliente As Panel
    Friend WithEvents btnInicioCliente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbCiCliente As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelEmpleado As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxPasswordEmpleado As TextBox
    Friend WithEvents btnInicioEmpleado As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents mtbCiEmpleado As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEmpleado As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents RbtGerente As RadioButton
    Friend WithEvents RbtAgente As RadioButton
End Class
