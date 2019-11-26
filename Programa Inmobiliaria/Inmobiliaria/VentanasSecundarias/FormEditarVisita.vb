Public Class FormEditarVisita
    Public Property IdPropiedad As Integer = -1
    Public Property CiCliente As Integer = -1

    Private resp As Boolean
    Public ReadOnly Property Respuesta As Boolean
        Get
            If resp Then
                resp = False
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Private Sub formEditarVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idPropiedad = -1 Or ciCliente = -1 Then
            MsgBox("Error: Visita no seleccionada", MsgBoxStyle.Critical)
            Close()
        End If
        dtpFechaHora.MinDate = Now()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MsgBox("¿Esta seguro de modificar la visita?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Database.GetInstance.Visitas.Modificar(CiCliente, IdPropiedad, dtpFechaHora.Value) Then
                MsgBox("Visita modificada", MsgBoxStyle.Information)
                resp = True
                Close()
            Else
                MsgBox("No se pudo modificar la visita", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub dtpFechaHora_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaHora.ValueChanged
        Dim tmpTime = dtpFechaHora.Value

        If tmpTime.Minute > 45 Then
            tmpTime = tmpTime.AddMinutes(60 - tmpTime.Minute)
        ElseIf tmpTime.Minute <= 15 Then
            tmpTime = tmpTime.AddMinutes(tmpTime.Minute * -1)
        Else
            tmpTime = tmpTime.Date.AddHours(tmpTime.Hour).AddMinutes(30)
        End If

        If tmpTime <= dtpFechaHora.MinDate Then
            tmpTime = tmpTime.AddMinutes(30)
        End If

        dtpFechaHora.Value = tmpTime
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class