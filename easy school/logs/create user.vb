Public Class create_user
    Dim data As New database
    Public idno As String = 111111111

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vv As String
        vv = TextBox1.Text
        Dim bout() As Byte = System.Convert.FromBase64String(vv)
        Dim oot As String = System.Text.Encoding.UTF8.GetString(bout)
        TextBox1.Text = oot
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'INSERT INTO  `library`.`users` (`ID` ,`password` ,`user_id` ,`created` ,`lastupdate` `status`)VALUES ('29328385 ',  'g',  'g',  '0', NOW( ) , CURRENT_TIMESTAMP ,  '1')
        If TextBox3.Text = "" Then
            MsgBox("user name can't be empty", MsgBoxStyle.Information, "error")
            TextBox3.Focus()
            Exit Sub
        Else
            If TextBox4.Text = "" Or TextBox5.Text = "" Then
                MsgBox("password can't be empty", MsgBoxStyle.Information, "error")
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox4.Focus()
                Exit Sub
            Else
                If TextBox4.Text = TextBox5.Text Then
                    Dim s As String
                    s = TextBox4.Text
                    Dim barray() As Byte = System.Text.Encoding.UTF8.GetBytes(s)
                    Dim passwordss As String = System.Convert.ToBase64String(barray)
                    Dim th As String = "INSERT INTO  users (`password` ,`username` )VALUES ('" & passwordss & "',  '" & TextBox3.Text & " ')"
                    data.add(th)
                    Me.Close()
                Else
                    MsgBox("password din't match", MsgBoxStyle.Information, "error")
                    TextBox4.Text = ""
                    TextBox5.Text = ""
                    TextBox4.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class