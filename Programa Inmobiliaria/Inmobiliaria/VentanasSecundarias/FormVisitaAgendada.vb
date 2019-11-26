Public Class FormVisitaAgendada
    Public Property QrCodeMessage As String
    Private Sub FormVisitaAgendada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxQrCode.Image = CreateQrCode(QrCodeMessage)
    End Sub
End Class