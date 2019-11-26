<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputPassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxPasswd = New System.Windows.Forms.TextBox()
        Me.chbMostrarPasswd = New System.Windows.Forms.CheckBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña"
        '
        'tbxPasswd
        '
        Me.tbxPasswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbxPasswd.Location = New System.Drawing.Point(95, 12)
        Me.tbxPasswd.Name = "tbxPasswd"
        Me.tbxPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPasswd.Size = New System.Drawing.Size(242, 22)
        Me.tbxPasswd.TabIndex = 1
        '
        'chbMostrarPasswd
        '
        Me.chbMostrarPasswd.AutoSize = True
        Me.chbMostrarPasswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chbMostrarPasswd.Location = New System.Drawing.Point(15, 42)
        Me.chbMostrarPasswd.Name = "chbMostrarPasswd"
        Me.chbMostrarPasswd.Size = New System.Drawing.Size(142, 20)
        Me.chbMostrarPasswd.TabIndex = 2
        Me.chbMostrarPasswd.Text = "Mostrar contraseña"
        Me.chbMostrarPasswd.UseVisualStyleBackColor = True
        '
        'btnEntrar
        '
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnEntrar.Location = New System.Drawing.Point(15, 74)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(88, 25)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(249, 74)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 25)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'InputPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 111)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.chbMostrarPasswd)
        Me.Controls.Add(Me.tbxPasswd)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputPassword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Contraseña requerida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbxPasswd As TextBox
    Friend WithEvents chbMostrarPasswd As CheckBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnCancelar As Button
End Class
