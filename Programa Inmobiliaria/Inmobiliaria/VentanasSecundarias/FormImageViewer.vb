Public Class FormImageViewer
    Public Property Imagen As Image
    Private Sub FormImageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxImagen.Image = Imagen
    End Sub

    Private Sub pbxImagen_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles pbxImagen.MouseDoubleClick
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub
End Class