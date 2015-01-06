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
            'If checkblank(TextBox13) = False Then
            '    Exit Sub
            'ElseIf checkblank(TextBox7) = False Then
            '    Exit Sub
            'ElseIf checkblank(TextBox7) = False Then
            '    Exit Sub
            'ElseIf checkblank(TextBox11) = False Then
            '    Exit Sub
            'ElseIf checkblank(TextBox21) = False Then
            '    Exit Sub
            'ElseIf checkblank(TextBox8) = False Then
            '    Exit Sub
            'ElseIf checkblank(TextBox13) = False Then
            '    Exit Sub
            'ElseIf checkblank(TextBox12) = False Then
            '    Exit Sub
            'Else
            id = TextBox13.Text
            names = TextBox7.Text
            tel = TextBox11.Text
            email = TextBox21.Text
            work = TextBox8.Text
            employer = TextBox9.Text
            residents = TextBox12.Text
            DATA.add("INSERT INTO " & Me.Text & "  VALUES (" & id & ", '" & names & "', '" & tel & "', '" & email & "', '" & work & "', '" & employer & "', '1');")
            Me.Close()
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmparents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Me.Text.ToUpper & "'S DETAILS"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class