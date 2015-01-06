Public Class admin_fee

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox4.Text = "m-pesa"
        TextBox7.Visible = True
        TextBox6.Visible = True
        Label9.Text = "phone number"
        Label8.Text = "transaction number"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox4.Text = "cheque details"
        TextBox7.Visible = True
        TextBox6.Visible = True
        Label9.Text = "bank name"
        Label8.Text = "cheque number"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox4.Text = "deposit slip  details"
        TextBox7.Visible = True
        TextBox6.Visible = True
        Label9.Text = "bank name"
        Label8.Text = "transaction number"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox4.Text = "CASH"
        TextBox7.Visible = False
        TextBox6.Visible = False
        Label9.Text = ""
        Label8.Text = ""
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        TextBox4.Text = TextBox13.Text
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Try
            TextBox5.Text = TextBox3.Text - TextBox4.Text
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.PrintPreviewDialog1.ShowDialog()
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As Font = New Font("Vanada", 10)
        Dim s As Font = New Font("Vanada", 20)
        Dim z As Font = New Font("Vanada", 15)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim p As Pen = New Pen(Color.Black)
        Dim wt As Integer = 780
        Dim ht As Integer = 900
        Dim l As Pen
        l = New Pen(Color.Black, 0.025F)

        e.Graphics.DrawRectangle(l, 40.0F, 50.5F, wt, ht) ' border of the table
        e.Graphics.DrawRectangle(l, 40.0F, 50.5F, 780, 150)
        e.Graphics.DrawRectangle(l, 40.0F, 50.5F, 500, 150)
        e.Graphics.DrawString(" " & "Label11.Text" & " ", s, br, 60, 60)
        e.Graphics.DrawString(" " & "Label9.Text" & "", z, br, 60, 110)
        e.Graphics.DrawString("  " & "Label10.Text" & "  ", z, br, 60, 130)
        e.Graphics.DrawString(" Date : ", f, br, 550, 60)
        e.Graphics.DrawString(" " & Today.Date & " ", f, br, 650, 60)
        e.Graphics.DrawString(" Bill No : ", f, br, 550, 160)
        e.Graphics.DrawString(" " & Label6.Text & " ", f, br, 650, 160)
        e.Graphics.DrawString(" Class : ", f, br, 60, 220)
        e.Graphics.DrawString(" " & "ComboBox1.Text" & " ", f, br, 250, 220)
        e.Graphics.DrawString(" Student Name : ", f, br, 60, 270)
        e.Graphics.DrawString(" " & "ComboBox4.Text" & " ", f, br, 250, 270)
        e.Graphics.DrawString(" Section : ", f, br, 550, 220)
        e.Graphics.DrawString(" " & "ComboBox3.Text" & " ", f, br, 650, 220)
        e.Graphics.DrawRectangle(l, 40.0F, 300.5F, 780, 50)
        e.Graphics.DrawRectangle(l, 40.0F, 300.5F, 650, 50)
        e.Graphics.DrawString(" Fees  ", f, br, 240, 320)
        e.Graphics.DrawString(" " & "ComboBox2.Text" & "", f, br, 60, 420)
        e.Graphics.DrawString(" Amount ", f, br, 750, 320)
        e.Graphics.DrawString(" " & TextBox1.Text & " ", f, br, 750, 420)
        e.Graphics.DrawRectangle(l, 40.0F, 300.5F, 650, 600)
        e.Graphics.DrawRectangle(l, 40.0F, 900.5F, 780, 150)
        e.Graphics.DrawString(" Signature ", f, br, 50, 1020)
        e.Graphics.DrawString(" Seal ", f, br, 750, 1020)
        e.Graphics.DrawRectangle(l, 40.0F, 900.5F, 650, 50)
        e.Graphics.DrawString(" Total ", f, br, 550, 910)
        e.Graphics.DrawString(" " & TextBox1.Text & " ", f, br, 750, 910)
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class