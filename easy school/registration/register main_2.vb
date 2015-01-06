Public Class register_main
    Dim data As New database
    Dim PROG As Integer
    Dim sadm, sfid, smid, ssql As String 'this holds the parent table data sql
    Dim tim As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim reg As New register
            reg.ShowDialog()
            TextBox17.Text = reg.adm
            TextBox16.Text = reg.sname
            TextBox15.Text = reg.fname
            TextBox14.Text = reg.lname
            TextBox18.Text = reg.dob
            TextBox19.Text = reg.gender.ToUpper
            TextBox23.Text = reg.birthno
            sadm = reg.adm
            '' PictureBox1
            ProgressBar1.Value = 30
            Button3.Visible = True
            Button2.Visible = False
            Button3.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim comboi As New ComboBox
            comboi = ComboBox2
            data.populateDDList(comboi, "SELECT code, name FROM stream")
            Dim nh As New mdyfrmparents
            nh.Text = "mother"
            nh.ShowDialog()
            TextBox13.Text = nh.id.ToUpper
            TextBox7.Text = nh.names.ToUpper
            TextBox11.Text = nh.tel.ToUpper
            TextBox21.Text = nh.email.ToUpper
            TextBox8.Text = nh.work.ToUpper
            TextBox9.Text = nh.employer.ToUpper
            TextBox12.Text = nh.residents.ToUpper
            smid = nh.id
            ProgressBar1.Value = 60
            Button4.Visible = True
            Button3.Visible = False
            Button4.PerformClick()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim comboi As New ComboBox
            comboi = ComboBox1
            data.populateDDList(comboi, "SELECT code,description  FROM class")
            Dim nh1 As New mdyfrmparents
            nh1.Text = "father"
            nh1.ShowDialog()
            TextBox1.Text = nh1.id.ToUpper
            TextBox10.Text = nh1.names.ToUpper
            TextBox4.Text = nh1.tel.ToUpper
            TextBox2.Text = nh1.email.ToUpper
            TextBox6.Text = nh1.work.ToUpper
            TextBox5.Text = nh1.employer.ToUpper
            TextBox3.Text = nh1.residents.ToUpper
            sfid = nh1.id
            ProgressBar1.Value = 90
            Button4.Visible = False
        Catch ex As Exception

        End Try

    End Sub
   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        complete()
        ProgressBar1.Value = 100
        Dim fee As New admin_fee
        With fee
            .TextBox2.Text = Me.TextBox17.Text
            .TextBox1.Text = Me.TextBox15.Text & " " & Me.TextBox14.Text & " " & Me.TextBox16.Text
            .ShowDialog()
            'if the student pays assign class and stream
            data.add("INSERT INTO student_class (admno,class_code,str_code) VALUES ('" & LTrim(TextBox17.Text) & "', '" & ComboBox1.Text & "', '" & ComboBox2.Text & "');")
        End With

    End Sub
    Private Function complete()

        ssql = "INSERT INTO parents (admno ,f_id_no ,id_no)VALUES ('" & LTrim(sadm) & "',  '" & LTrim(sfid) & "',  '" & LTrim(smid) & "')"
        data.add(ssql)
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

   
    Private Sub register_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tim = tim + 1
        If tim = 1 Then
            Timer1.Enabled = False
            Button2.PerformClick()
        End If
    End Sub
End Class