<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConfig
    Inherits System.Windows.Forms.Form

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
        Me.tbxServidor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxBaseDeDatos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbxDbClienteUid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxDbClientePassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudPuerto = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxConfigPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbxDbGerenteUid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxDbGerentePassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbxDbAgenteUid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxDbAgentePassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PanelSeparator1 = New Inmobiliaria.PanelSeparator()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudPuerto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxServidor
        '
        Me.tbxServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxServidor.Location = New System.Drawing.Point(115, 13)
        Me.tbxServidor.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxServidor.Name = "tbxServidor"
        Me.tbxServidor.Size = New System.Drawing.Size(179, 22)
        Me.tbxServidor.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(48, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Servidor"
        '
        'tbxBaseDeDatos
        '
        Me.tbxBaseDeDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxBaseDeDatos.Location = New System.Drawing.Point(114, 43)
        Me.tbxBaseDeDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxBaseDeDatos.Name = "tbxBaseDeDatos"
        Me.tbxBaseDeDatos.Size = New System.Drawing.Size(180, 22)
        Me.tbxBaseDeDatos.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(10, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Base de datos"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(13, 470)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(144, 35)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(163, 470)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(143, 35)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbxDbClienteUid)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbxDbClientePassword)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 87)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuario de base de datos (Cliente)"
        '
        'tbxDbClienteUid
        '
        Me.tbxDbClienteUid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxDbClienteUid.Location = New System.Drawing.Point(101, 25)
        Me.tbxDbClienteUid.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxDbClienteUid.Name = "tbxDbClienteUid"
        Me.tbxDbClienteUid.Size = New System.Drawing.Size(178, 22)
        Me.tbxDbClienteUid.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(45, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "UserId"
        '
        'tbxDbClientePassword
        '
        Me.tbxDbClientePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxDbClientePassword.Location = New System.Drawing.Point(101, 55)
        Me.tbxDbClientePassword.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxDbClientePassword.Name = "tbxDbClientePassword"
        Me.tbxDbClientePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxDbClientePassword.Size = New System.Drawing.Size(178, 22)
        Me.tbxDbClientePassword.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(16, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(60, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Puerto"
        '
        'nudPuerto
        '
        Me.nudPuerto.Location = New System.Drawing.Point(114, 72)
        Me.nudPuerto.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nudPuerto.Name = "nudPuerto"
        Me.nudPuerto.Size = New System.Drawing.Size(180, 22)
        Me.nudPuerto.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbxConfigPassword)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 380)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 61)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contraseña para ventana de configuración"
        '
        'tbxConfigPassword
        '
        Me.tbxConfigPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxConfigPassword.Location = New System.Drawing.Point(104, 27)
        Me.tbxConfigPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxConfigPassword.Name = "tbxConfigPassword"
        Me.tbxConfigPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxConfigPassword.Size = New System.Drawing.Size(178, 22)
        Me.tbxConfigPassword.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(19, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Contraseña"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbxDbGerenteUid)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbxDbGerentePassword)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 87)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Usuario de base de datos (Gerente)"
        '
        'tbxDbGerenteUid
        '
        Me.tbxDbGerenteUid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxDbGerenteUid.Location = New System.Drawing.Point(101, 25)
        Me.tbxDbGerenteUid.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxDbGerenteUid.Name = "tbxDbGerenteUid"
        Me.tbxDbGerenteUid.Size = New System.Drawing.Size(178, 22)
        Me.tbxDbGerenteUid.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(45, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "UserId"
        '
        'tbxDbGerentePassword
        '
        Me.tbxDbGerentePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxDbGerentePassword.Location = New System.Drawing.Point(101, 55)
        Me.tbxDbGerentePassword.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxDbGerentePassword.Name = "tbxDbGerentePassword"
        Me.tbxDbGerentePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxDbGerentePassword.Size = New System.Drawing.Size(178, 22)
        Me.tbxDbGerentePassword.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(16, 58)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Contraseña"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbxDbAgenteUid)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.tbxDbAgentePassword)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 287)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(294, 87)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Usuario de base de datos (Agente)"
        '
        'tbxDbAgenteUid
        '
        Me.tbxDbAgenteUid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxDbAgenteUid.Location = New System.Drawing.Point(101, 25)
        Me.tbxDbAgenteUid.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxDbAgenteUid.Name = "tbxDbAgenteUid"
        Me.tbxDbAgenteUid.Size = New System.Drawing.Size(178, 22)
        Me.tbxDbAgenteUid.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(45, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "UserId"
        '
        'tbxDbAgentePassword
        '
        Me.tbxDbAgentePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxDbAgentePassword.Location = New System.Drawing.Point(101, 55)
        Me.tbxDbAgentePassword.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxDbAgentePassword.Name = "tbxDbAgentePassword"
        Me.tbxDbAgentePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxDbAgentePassword.Size = New System.Drawing.Size(178, 22)
        Me.tbxDbAgentePassword.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(16, 58)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Contraseña"
        '
        'PanelSeparator1
        '
        Me.PanelSeparator1.Location = New System.Drawing.Point(13, 454)
        Me.PanelSeparator1.Name = "PanelSeparator1"
        Me.PanelSeparator1.Size = New System.Drawing.Size(293, 10)
        Me.PanelSeparator1.TabIndex = 8
        '
        'FormConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 518)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nudPuerto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.PanelSeparator1)
        Me.Controls.Add(Me.tbxBaseDeDatos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxServidor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConfig"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuracion de Conección"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudPuerto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxServidor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxBaseDeDatos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelSeparator1 As PanelSeparator
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbxDbClienteUid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxDbClientePassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudPuerto As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxConfigPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbxDbGerenteUid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxDbGerentePassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbxDbAgenteUid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbxDbAgentePassword As TextBox
    Friend WithEvents Label10 As Label
End Class
