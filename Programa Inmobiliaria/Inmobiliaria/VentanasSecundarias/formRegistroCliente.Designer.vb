﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistroCliente
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbxDireccion = New System.Windows.Forms.TextBox()
        Me.cbxLocalidad = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbxApellido = New System.Windows.Forms.TextBox()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.mtbCi = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBorrarTelefono = New System.Windows.Forms.Button()
        Me.lbxListaNumerosTelefono = New System.Windows.Forms.ListBox()
        Me.mtbNumeroTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.btnAgregarTelefono = New System.Windows.Forms.Button()
        Me.btnAgregarModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label22, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 178)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(321, 134)
        Me.TableLayoutPanel2.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbxDireccion)
        Me.Panel2.Controls.Add(Me.cbxLocalidad)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.cbxDepartamento)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(315, 98)
        Me.Panel2.TabIndex = 1
        '
        'tbxDireccion
        '
        Me.tbxDireccion.Location = New System.Drawing.Point(93, 65)
        Me.tbxDireccion.Name = "tbxDireccion"
        Me.tbxDireccion.Size = New System.Drawing.Size(206, 20)
        Me.tbxDireccion.TabIndex = 23
        '
        'cbxLocalidad
        '
        Me.cbxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLocalidad.FormattingEnabled = True
        Me.cbxLocalidad.Location = New System.Drawing.Point(93, 38)
        Me.cbxLocalidad.Name = "cbxLocalidad"
        Me.cbxLocalidad.Size = New System.Drawing.Size(206, 21)
        Me.cbxLocalidad.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Dirección"
        '
        'cbxDepartamento
        '
        Me.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.Location = New System.Drawing.Point(93, 11)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(206, 21)
        Me.cbxDepartamento.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Localidad"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(13, 14)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(74, 13)
        Me.Label31.TabIndex = 18
        Me.Label31.Text = "Departamento"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.LightGray
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Margin = New System.Windows.Forms.Padding(0)
        Me.Label22.Name = "Label22"
        Me.Label22.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label22.Size = New System.Drawing.Size(321, 30)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Dirección de residencia"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(321, 160)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbxCorreo)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.tbxApellido)
        Me.Panel1.Controls.Add(Me.tbxNombre)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.mtbCi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 124)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Correo"
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Location = New System.Drawing.Point(63, 89)
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.Size = New System.Drawing.Size(236, 20)
        Me.tbxCorreo.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 66)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Apellido"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Nombre"
        '
        'tbxApellido
        '
        Me.tbxApellido.Location = New System.Drawing.Point(63, 63)
        Me.tbxApellido.Name = "tbxApellido"
        Me.tbxApellido.Size = New System.Drawing.Size(236, 20)
        Me.tbxApellido.TabIndex = 9
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(63, 37)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(236, 20)
        Me.tbxNombre.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(40, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "CI"
        '
        'mtbCi
        '
        Me.mtbCi.Location = New System.Drawing.Point(63, 11)
        Me.mtbCi.Mask = "0000000-0"
        Me.mtbCi.Name = "mtbCi"
        Me.mtbCi.Size = New System.Drawing.Size(236, 20)
        Me.mtbCi.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.LightGray
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Margin = New System.Windows.Forms.Padding(0)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label18.Size = New System.Drawing.Size(321, 30)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Datos Personales"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 318)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(321, 146)
        Me.TableLayoutPanel3.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(321, 30)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Telefonos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnBorrarTelefono)
        Me.Panel3.Controls.Add(Me.lbxListaNumerosTelefono)
        Me.Panel3.Controls.Add(Me.mtbNumeroTelefono)
        Me.Panel3.Controls.Add(Me.btnAgregarTelefono)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(315, 110)
        Me.Panel3.TabIndex = 3
        '
        'btnBorrarTelefono
        '
        Me.btnBorrarTelefono.Location = New System.Drawing.Point(196, 75)
        Me.btnBorrarTelefono.Name = "btnBorrarTelefono"
        Me.btnBorrarTelefono.Size = New System.Drawing.Size(103, 23)
        Me.btnBorrarTelefono.TabIndex = 27
        Me.btnBorrarTelefono.Text = "Borrar"
        Me.btnBorrarTelefono.UseVisualStyleBackColor = True
        '
        'lbxListaNumerosTelefono
        '
        Me.lbxListaNumerosTelefono.FormattingEnabled = True
        Me.lbxListaNumerosTelefono.Location = New System.Drawing.Point(16, 41)
        Me.lbxListaNumerosTelefono.Name = "lbxListaNumerosTelefono"
        Me.lbxListaNumerosTelefono.Size = New System.Drawing.Size(174, 56)
        Me.lbxListaNumerosTelefono.TabIndex = 26
        '
        'mtbNumeroTelefono
        '
        Me.mtbNumeroTelefono.Location = New System.Drawing.Point(16, 15)
        Me.mtbNumeroTelefono.Name = "mtbNumeroTelefono"
        Me.mtbNumeroTelefono.Size = New System.Drawing.Size(174, 20)
        Me.mtbNumeroTelefono.TabIndex = 24
        '
        'btnAgregarTelefono
        '
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(196, 14)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(103, 23)
        Me.btnAgregarTelefono.TabIndex = 25
        Me.btnAgregarTelefono.Text = "Agregar número"
        Me.btnAgregarTelefono.UseVisualStyleBackColor = True
        '
        'btnAgregarModificar
        '
        Me.btnAgregarModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnAgregarModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnAgregarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarModificar.Location = New System.Drawing.Point(209, 470)
        Me.btnAgregarModificar.Name = "btnAgregarModificar"
        Me.btnAgregarModificar.Size = New System.Drawing.Size(124, 35)
        Me.btnAgregarModificar.TabIndex = 28
        Me.btnAgregarModificar.Text = "Agregar"
        Me.btnAgregarModificar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(12, 470)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(124, 35)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'FormRegistroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 516)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregarModificar)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRegistroCliente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de cliente"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbxLocalidad As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbxDepartamento As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAgregarTelefono As Button
    Friend WithEvents btnAgregarModificar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents mtbNumeroTelefono As MaskedTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBorrarTelefono As Button
    Friend WithEvents lbxListaNumerosTelefono As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tbxApellido As TextBox
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents mtbCi As MaskedTextBox
    Friend WithEvents tbxDireccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxCorreo As TextBox
End Class
