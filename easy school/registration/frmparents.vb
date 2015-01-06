Public Class mdyfrmparents
    Dim DATA As New database
    Public id, names, tel, email, work, employer, residents As String
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Function checkblank(ByVal sender As Object) As Boolean
        If sender.text.ToString.Length = 0 Then
            MsgBox("can't be blank", MsgBoxStyle.Information, "")
            ' sender.focus = True
            Return False
        End If
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If checkblank(TextBox13) = False Then
                Exit Sub
            ElseIf checkblank(TextBox7) = False Then
                Exit Sub
            ElseIf checkblank(TextBox7) = False Then
                Exit Sub
            ElseIf checkblank(TextBox11) = False Then
                Exit Sub
            ElseIf checkblank(TextBox21) = False Then
                Exit Sub
            ElseIf checkblank(TextBox8) = False Then
                Exit Sub
            ElseIf checkblank(TextBox13) = False Then
                Exit Sub
            ElseIf checkblank(TextBox12) = False Then
                Exit Sub
            Else
                id = TextBox13.Text
                names = TextBox7.Text
                tel = TextBox11.Text
                email = TextBox21.Text
                work = TextBox8.Text
                employer = TextBox9.Text
                residents = TextBox12.Text
                DATA.add("INSERT INTO " & Me.Text & "  VALUES (" & id & ", '" & names & "', '" & tel & "', '" & email & "', '" & work & "', '" & employer & "', '1');")
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmparents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Me.Text.ToUpper & "'S DETAILS"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox7_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        Dim val As New validate
        val.digits(sender, e)
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged


    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        Dim val As New validate
        val.digits(sender, e)
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged

    End Sub

    Private Sub TextBox21_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox21.Validating
        Dim val As New validate
        val.emails(sender)
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub
End Class