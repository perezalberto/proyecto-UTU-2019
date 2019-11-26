Public Class PanelSeparator
    Inherits Panel
    Private Sub PanelSeparator_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim Brush As New Drawing.Pen(Color.FromArgb(32, 0, 0, 0))
        e.Graphics.DrawLine(Brush, 0, 0, Width, 0)
    End Sub
End Class
