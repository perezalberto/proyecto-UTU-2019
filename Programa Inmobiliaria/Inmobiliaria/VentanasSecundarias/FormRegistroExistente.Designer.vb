<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistroExistente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEmpleado = New System.Windows.Forms.Panel()
        Me.TbxPasswd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbxSucursal = New System.Windows.Forms.ComboBox()
        Me.CbxRol = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbxCorreo = New System.Windows.Forms.TextBox()
        Me.PanelCliente = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.PanelEmpleado.SuspendLayout()
        Me.PanelCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSalir)
        Me.Panel3.Controls.Add(Me.btnModificar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(311, 55)
        Me.Panel3.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(12, 8)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(124, 35)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.Location = New System.Drawing.Point(175, 8)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(124, 35)
        Me.btnModificar.TabIndex = 30
        Me.btnModificar.Text = "Agregar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo"
        '
        'PanelEmpleado
        '
        Me.PanelEmpleado.Controls.Add(Me.TbxPasswd)
        Me.PanelEmpleado.Controls.Add(Me.Label4)
        Me.PanelEmpleado.Controls.Add(Me.CbxSucursal)
        Me.PanelEmpleado.Controls.Add(Me.CbxRol)
        Me.PanelEmpleado.Controls.Add(Me.Label3)
        Me.PanelEmpleado.Controls.Add(Me.Label2)
        Me.PanelEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.PanelEmpleado.Name = "PanelEmpleado"
        Me.PanelEmpleado.Size = New System.Drawing.Size(311, 161)
        Me.PanelEmpleado.TabIndex = 1
        '
        'TbxPasswd
        '
        Me.TbxPasswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxPasswd.Location = New System.Drawing.Point(91, 72)
        Me.TbxPasswd.Name = "TbxPasswd"
        Me.TbxPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxPasswd.Size = New System.Drawing.Size(208, 22)
        Me.TbxPasswd.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password"
        '
        'CbxSucursal
        '
        Me.CbxSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSucursal.FormattingEnabled = True
        Me.CbxSucursal.Location = New System.Drawing.Point(91, 42)
        Me.CbxSucursal.Name = "CbxSucursal"
        Me.CbxSucursal.Size = New System.Drawing.Size(208, 24)
        Me.CbxSucursal.TabIndex = 3
        '
        'CbxRol
        '
        Me.CbxRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxRol.FormattingEnabled = True
        Me.CbxRol.Items.AddRange(New Object() {"Agente", "Gerente"})
        Me.CbxRol.Location = New System.Drawing.Point(91, 12)
        Me.CbxRol.Name = "CbxRol"
        Me.CbxRol.Size = New System.Drawing.Size(208, 24)
        Me.CbxRol.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rol"
        '
        'TbxCorreo
        '
        Me.TbxCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxCorreo.Location = New System.Drawing.Point(72, 44)
        Me.TbxCorreo.Name = "TbxCorreo"
        Me.TbxCorreo.Size = New System.Drawing.Size(227, 22)
        Me.TbxCorreo.TabIndex = 0
        '
        'PanelCliente
        '
        Me.PanelCliente.Controls.Add(Me.TbxCorreo)
        Me.PanelCliente.Controls.Add(Me.Label1)
        Me.PanelCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCliente.Location = New System.Drawing.Point(0, 0)
        Me.PanelCliente.Name = "PanelCliente"
        Me.PanelCliente.Size = New System.Drawing.Size(311, 161)
        Me.PanelCliente.TabIndex = 0
        '
        'FormRegistroExistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 161)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelEmpleado)
        Me.Controls.Add(Me.PanelCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRegistroExistente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar cuenta existente"
        Me.Panel3.ResumeLayout(False)
        Me.PanelEmpleado.ResumeLayout(False)
        Me.PanelEmpleado.PerformLayout()
        Me.PanelCliente.ResumeLayout(False)
        Me.PanelCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelEmpleado As Panel
    Friend WithEvents CbxSucursal As ComboBox
    Friend WithEvents CbxRol As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbxCorreo As TextBox
    Friend WithEvents PanelCliente As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents TbxPasswd As TextBox
    Friend WithEvents Label4 As Label
End Class
