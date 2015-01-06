Public Class register
    Dim data As New database
    Public adm, sname, fname, lname, dob, gender, birthno, adm_date, pic As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'add data to the database
            getdata()

            Me.Close()
            'pass variables to the calling view if the the insert was succesifull
            Dim sql, nam As String
            nam = LTrim(fname + " " + lname + " " + sname)
            sql = "INSERT INTO students (admno, regno, names, gender, DOB, Birthno, adm_date, pic) VALUES ('" & adm & "', NULL, '" & nam & "', '" & gender & "', '" & dob & "', '" & birthno & "', '" & adm_date & "', '" & pic & "');"
            data.add(sql)
            'create a sub to pass every thing(this is already done)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
    Public Sub getdata()
        adm = TextBox1.Text.ToUpper
        sname = TextBox2.Text.ToUpper
        fname = TextBox3.Text.ToUpper
        lname = TextBox4.Text.ToUpper
        dob = Format(Date1.Value.ToShortDateString, ("yyyy-mm-dd"))
        If RadioButton1.Checked = True Then
            gender = "Female"
        ElseIf RadioButton2.Checked = True Then
            gender = "Male"
        End If

        birthno = TextBox23.Text
        adm_date = DateTimePicker1.Value.ToShortDateString
        pic = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Space Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        Dim VAL As New validate
        VAL.digits(sender, e)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyData = Keys.Space Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim VAL As New validate
        VAL.alphas(sender.TEXT)
    End Sub


    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyData = Keys.Space Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyData = Keys.Space Then
            ' TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
