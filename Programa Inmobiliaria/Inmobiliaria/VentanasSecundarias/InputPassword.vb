Public Class InputPassword

    Private __passwd As String

    Public Property GrantAccess As Boolean

    Public Sub New(passwd As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        __passwd = passwd
        GrantAccess = False
    End Sub



    Private Sub InputPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxPasswd.Text = ""
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If __passwd = tbxPasswd.Text Then
            GrantAccess = True
            Close()
        Else
            MsgBox("Contraseña incorrecta!")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub chbMostrarPasswd_CheckStateChanged(sender As Object, e As EventArgs) Handles chbMostrarPasswd.CheckStateChanged
        If chbMostrarPasswd.Checked Then
            tbxPasswd.PasswordChar = ""
        Else
            tbxPasswd.PasswordChar = "*"
        End If
    End Sub
End Class