Public Class teacher
    Dim picha As String
    Dim data As New studentsdatabase
    Sub edit()
        Dim sqledit As String
        sqledit = "UPDATE `teachers` SET `national_id`='" & TextBox2.Text & "',`name`='" & TextBox1.Text & "',`gender`='" & ComboBox1.Text & "',`tel`='" & MaskedTextBox1.Text & "',`email`='" & TextBox4.Text & "',`DOB`='" & dob.Value & "',`emp_date`='" & empdate.Value & "',`box`='" & TextBox5.Text & "',`city`='" & TextBox6.Text & "',`village`='" & TextBox7.Text & "',`p_code`='" & TextBox8.Text & "',`qualification`='" & ComboBox2.Text & "',`year_out`='" & p_year.Value & "',`institution`='" & TextBox3.Text & "',`pic`='" & picha & "' WHERE `national_id`='" & TextBox2.Text & "'"
        data.executeSQL(sqledit.ToLower)
    End Sub
    Public Sub selected(ByVal datas As DataTable)
        Try
            Dim red As DataTable = datas
            If red.Rows.Count < 1 Then
                Me.Close()
            End If
            'MsgBox(red.Rows.Count)

            For Each drow In red.Rows
                With Me
                    .TextBox2.Text = drow.Item(0).ToString.ToUpper 'id
                    .TextBox1.Text = drow.Item(1).ToString.ToUpper.ToUpper  'name
                    .dob.Value = drow.Item(5).ToString.ToUpper.ToUpper  'date of birth
                    .ComboBox1.Text = drow.Item(2).ToString.ToUpper.ToUpper  'gender
                    .MaskedTextBox1.Text = drow.Item(3).ToString.ToUpper.ToUpper  'phone number
                    .TextBox4.Text = drow.Item(4).ToString.ToUpper.ToUpper  'email
                    piv(drow.Item(14).ToString.ToUpper.ToUpper)  'picha
                    picha = drow.Item(14).ToString.ToUpper.ToUpper
                    .TextBox5.Text = drow.Item(7).ToString.ToUpper.ToUpper  'box
                    .TextBox6.Text = drow.Item(8).ToString.ToUpper.ToUpper   'city
                    .TextBox7.Text = drow.Item(9).ToString.ToUpper.ToUpper   'village
                    .TextBox8.Text = drow.Item(10).ToString.ToUpper.ToUpper  'posal code
                    .ComboBox2.Text = drow.Item(11).ToString.ToUpper.ToUpper   'qualification
                    .TextBox3.Text = drow.Item(13).ToString.ToUpper.ToUpper  'institution
                    .empdate.Value = drow.Item(6).ToString.ToUpper.ToUpper  'employent date
                    .p_year.Value = drow.Item(12).ToString & "-01-01"  'year out
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub piv(ByVal fff As String)
        Try
            Dim pb As PictureBox = PictureBox1
            Dim bmp As New Bitmap(fff)
            If Not IsNothing(pb.Image) Then pb.Image.Dispose() 'Optional if you want to destroy the previously loaded image
            pb.Image = bmp
            picha = fff
        Catch
            ' MsgBox("Not a valid image file.")
        End Try
    End Sub
    Sub OpenAnImageInPicturebox(ByRef pb As PictureBox)
        Dim ofd As New OpenFileDialog
        ' ofd.Filter = "JPEG|*.jpg|PNG|*.png|Bitmap|*.bmp" 'If you like file type filters you can add them here
        'any other modifications to the dialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Try
            Dim bmp As New Bitmap(ofd.FileName)
            If Not IsNothing(pb.Image) Then pb.Image.Dispose() 'Optional if you want to destroy the previously loaded image
            pb.Image = bmp
            picha = ofd.FileName
        Catch
            MsgBox("Not a valid image file.")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenAnImageInPicturebox(PictureBox1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        If TextBox2.Text = "" Then
            MsgBox("can' be blank", MsgBoxStyle.Information, "error")
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MsgBox("can' be blank", MsgBoxStyle.Information, "error")
            TextBox1.Focus()
            Exit Sub
        End If
        If ComboBox1.Text = Text Then
            MsgBox("can' be blank", MsgBoxStyle.Information, "error")
            ComboBox1.Focus()
            Exit Sub
        End If
        If MaskedTextBox1.Text = "" Then
            MsgBox("can' be blank", MsgBoxStyle.Information, "error")
            MaskedTextBox1.Focus()
            Exit Sub
        End If
        If TextBox4.Text = "" Then

            MsgBox("can' be blank", MsgBoxStyle.Information, "error")
            TextBox4.Focus()
            Exit Sub
        End If
        sql = "INSERT INTO `teachers` (`national_id`, `name`, `gender`, `tel`, `email`, `DOB`, `emp_date`, `box`, `city`, `village`, `p_code`, `qualification`, `year_out`, `institution`, `pic`) VALUES ('" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & ComboBox1.Text & "', '" & MaskedTextBox1.Text & "', '" & TextBox4.Text & "', '" & dob.Value.ToString("yyyy-MM-dd") & "', '" & empdate.Value.ToString("yyyy-MM-dd") & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & ComboBox2.Text & "', '" & p_year.Value.ToString("yyyy") & "', '" & TextBox3.Text & "','" & picha & "');"
        data.add(sql)
        TextBox2.Text = ""
        TextBox1.Text = ""
        ComboBox1.Text = ""
        MaskedTextBox1.Text = ""
        TextBox4.Text = ""
        dob.Value = Now
        empdate.Value = Now
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox2.Text = ""
        p_year.Value = Now
        TextBox3.Text = ""
        picha = ""
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim sqledit As String
            If TextBox2.Text = "" Then
                MsgBox("can' be blank", MsgBoxStyle.Information, "error")
                TextBox2.Focus()
                Exit Sub
            End If
            If TextBox1.Text = "" Then
                MsgBox("can' be blank", MsgBoxStyle.Information, "error")
                TextBox1.Focus()
                Exit Sub
            End If
            If ComboBox1.Text = Text Then
                MsgBox("can' be blank", MsgBoxStyle.Information, "error")
                ComboBox1.Focus()
                Exit Sub
            End If
            If MaskedTextBox1.Text = "" Then
                MsgBox("can' be blank", MsgBoxStyle.Information, "error")
                MaskedTextBox1.Focus()
                Exit Sub
            End If
            sqledit = "UPDATE `teachers` SET `national_id`='" & TextBox2.Text & "',`name`='" & TextBox1.Text & "',`gender`='" & ComboBox1.Text & "',`tel`='" & MaskedTextBox1.Text & "',`email`='" & TextBox4.Text & "',`DOB`='" & dob.Value.ToString("yyyy-MM-dd") & "',`emp_date`='" & empdate.Value.ToString("yyyy-MM-dd") & "',`box`='" & TextBox5.Text & "',`city`='" & TextBox6.Text & "',`village`='" & TextBox7.Text & "',`p_code`='" & TextBox8.Text & "',`qualification`='" & ComboBox2.Text & "',`year_out`='" & p_year.Value.ToString("yyyy") & "',`institution`='" & TextBox3.Text & "',`pic`='" & picha & "' WHERE `national_id`='" & TextBox2.Text & "'"
            data.executeSQL(sqledit.ToLower)
            Me.Close()
        Catch ex As Exception
            MsgBox("an error occured ", , "error")
        End Try
    End Sub

    Private Sub teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class