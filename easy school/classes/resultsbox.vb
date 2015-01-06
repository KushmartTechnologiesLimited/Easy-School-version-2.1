Public Class resultsbox
    Dim i As Integer = 0
    Private Sub resultsbox_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub resultsbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 20
        Me.Left = 300
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1
        Me.Opacity = 100 - (i * 80 / 5)
        If i > 5 Then
            Me.Close()
        End If
    End Sub
End Class