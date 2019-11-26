Public Class FormVerTelefonos
    Public Property CiUsuario As Integer = -1

    Private Sub FormVerTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CiUsuario <> -1 Then
            Dim listTel = Database.GetInstance.Telefonos.ObtenerNumeros(CiUsuario)
            lbxTelefonos.Items.AddRange(listTel)
        Else
            Dispose()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class