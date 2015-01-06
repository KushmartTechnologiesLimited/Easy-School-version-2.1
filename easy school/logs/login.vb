Public Class login
    Dim data As New database
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s As String
        s = TextBox4.Text
        Dim barray() As Byte = System.Text.Encoding.UTF8.GetBytes(s)
        Dim passwordss As String = System.Convert.ToBase64String(barray)
        Dim red As New DataTable
        Dim sq As String = "SELECT * FROM `users` WHERE `username`='" & TextBox3.Text & "'  and `password`='" & passwordss & "'"
        red = data.executeSQL(sq)
        If red.Rows.Count > 0 Then
            Dim man As New MDIParent1
            man.Label1.Text = "User :" & red.Rows(0).Item(1).ToString
            man.role = red.Rows(0).Item(3).ToString
            Me.Hide()
            man.ShowDialog()
            Me.Close()
        Else
            MsgBox("wrong username or password " + vbCrLf + " try again", MsgBoxStyle.Exclamation, "login")
            TextBox4.Text = ""
            TextBox3.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim red As New DataTable
        red = data.executeSQL("SELECT * FROM `users`")
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class