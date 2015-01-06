Public Class new_student
    Dim mama As Boolean = False
    Dim papa As Boolean = False
    Dim padm, pmid, pfid As String
    Dim fr As Integer
    Public adm, sname, fname, lname, dob, gender, birthno, adm_date, pic As String
    Dim class_id, str_id As New List(Of String)
    Dim strm, cl As String
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox5.Text = ""
        If CheckBox1.Checked = False Then
            TextBox5.ReadOnly = True
        Else
            TextBox5.ReadOnly = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = False Then
            Panel4.Enabled = True
        Else
            Panel4.Enabled = False
            TextBox7.Text = ""
            TextBox13.Text = ""
            TextBox11.Text = ""
            TextBox21.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox12.Text = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            Panel5.Enabled = True
        Else
            Panel5.Enabled = False
            TextBox18.Text = ""
            TextBox6.Text = ""
            TextBox15.Text = ""
            TextBox10.Text = ""
            TextBox17.Text = ""
            TextBox16.Text = ""
            TextBox14.Text = ""
        End If
    End Sub

    Private Sub new_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New database
        Dim page As TabPage
        For Each page In TabControl1.TabPages
            page.Enabled = False
        Next
        TabControl1.TabPages(0).Enabled = True
        Dim rd, rd1 As DataTable
        rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`")
        rd1 = data.executeSQL("SELECT code, name FROM stream")
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0

        For Each drow In rd.Rows
            ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper)
            class_id.Add(drow.Item(0).ToString.ToUpper)
        Next
        For Each drow In rd1.Rows
            ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper)
            str_id.Add(drow.Item(0).ToString.ToUpper)
        Next
    End Sub


    ''test the codes
    Public Sub getdata()
        
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ddd As New studentsdatabase
        Dim data As New database
        Try
            'add data to the database
            getdata()
            If TextBox1.Text = "" Then
                MsgBox("admno can't be blank", MsgBoxStyle.Information, "error!")
                TextBox1.Focus()
                Exit Sub
            End If
            If TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" Then
                MsgBox("names  can't be blank", MsgBoxStyle.Information, "error!")
                TextBox2.Focus()
                Exit Sub
            End If
            'If TextBox23.Text = "" Then
            '    MsgBox("birth certificate no can't be blank", MsgBoxStyle.Information, "error!")
            '    TextBox23.Focus()
            '    Exit Sub
            'End If
            adm = TextBox1.Text.ToUpper
            sname = TextBox2.Text.ToUpper
            fname = TextBox3.Text.ToUpper
            lname = TextBox4.Text.ToUpper
            dob = Date1.Value.ToString("yyyy-MM-dd")
            If RadioButton1.Checked = True Then
                gender = "Female"
            ElseIf RadioButton2.Checked = True Then
                gender = "Male"
            End If

            birthno = TextBox23.Text
            adm_date = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            pic = ""
            ' Me.Close()
            'pass variables to the calling view if the the insert was succesifull
            Dim sql, nam As String
            nam = LTrim(fname + " " + lname + " " + sname)
            sql = "INSERT INTO `schoolfees`.`students` (`admno`, `regno`, ` names`, `gender`, `DOB`, `Birthno`, `adm_date`, `pic`) VALUES ('" & adm & "', NULL, '" & nam & "', '" & gender & "', '" & dob & "', '" & birthno & "', '" & adm_date & "', '" & pic & "');"
            '  sql = "INSERT INTO students (admno, regno, names, gender, DOB, Birthno, adm_date, pic) VALUES ('" & adm & "', NULL, '" & nam & "', '" & gender & "', '" & dob & "', '" & birthno & "', '" & adm_date & "', '" & pic & "');"
            Dim stat As Integer
            stat = ddd.add(sql)
            ' data.add(sql)
            If stat = 1 Then
                TabControl1.TabPages(0).Enabled = False
                TabControl1.TabPages(1).Enabled = True
                TabControl1.SelectedIndex = 1
                ProgressBar1.Value = ProgressBar1.Maximum / 3
                Button5.Visible = False
                Button1.Visible = True

                padm = adm
            End If
            'create a sub to pass every thing(this is already done)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''THIS BUTTON SHOULD ADD ALL THE AVAILABLE PARENTS DATA TO THE DATABASE AND ASSIGN THE PARENTS DTAILS TO THE 
        ''PARTICULA STUDENT
        'TEST WHAT IS READY BEFORORE YOU INSERT
        Dim DATA As New studentsdatabase
        Dim Mid, Mnames, Mtel, Memail, Mwork, Memployer, Mresidents As String
        Dim Fid, Fnames, Ftel, Femail, Fwork, Femployer, Fresidents As String
        Dim FSTATUS As Boolean = False
        Dim MSTATUS As Boolean = False
        Try
            If mama = False And CheckBox3.Checked = False Then
                'ADDMOTHER()
                'Dim Mid, Mnames, Mtel, Memail, Mwork, Memployer, Mresidents As String
                'Dim DATA As New studentsdatabase
                Try
                    If (TextBox13.Text = "") Then
                        MSG()
                        TextBox13.Focus()
                        Exit Sub
                    ElseIf TextBox13.TextLength < 8 Then
                        MsgBox("National Id No should be atleast 7 characters", MsgBoxStyle.Information, "error")
                        TextBox13.Focus()
                        Exit Sub
                    End If
                    If (TextBox7.Text = "") Then
                        MSG()
                        TextBox7.Focus()
                        Exit Sub
                    End If
                    If (TextBox11.Text = "") Then
                        MSG()
                        TextBox11.Focus()
                        Exit Sub
                    End If
                    'If (TextBox21.Text = "") Then
                    '    MSG()
                    '    TextBox21.Focus()
                    '    Exit Sub
                    'End If
                    'If (TextBox8.Text = "") Then
                    '    MSG()
                    '    TextBox8.Focus()
                    '    Exit Sub
                    'End If
                    'If (TextBox9.Text = "") Then
                    '    MSG()
                    '    TextBox9.Focus()
                    '    Exit Sub
                    'End If
                    'If (TextBox12.Text = "") Then
                    '    MSG()
                    '    TextBox12.Focus()
                    '    Exit Sub
                    'End If
                    Mid = TextBox13.Text
                    Mnames = TextBox7.Text
                    Mtel = TextBox11.Text
                    Memail = TextBox21.Text
                    Mwork = TextBox8.Text
                    Memployer = TextBox9.Text
                    Mresidents = TextBox12.Text
                    MSTATUS = True
                    'DATA.add("INSERT INTO MOTHER  VALUES (" & Mid & ", '" & Mnames & "', '" & Mtel & "', '" & Memail & "', '" & Mwork & "', '" & Memployer & "', '" & Mresidents & "');")
                    pmid = Mid
                Catch ex As Exception

                End Try
            End If
            If papa = False And CheckBox2.Checked = False Then
                'ADDfather()
                'Dim Fid, Fnames, Ftel, Femail, Fwork, Femployer, Fresidents As String
                'Dim DATA As New database
                Try
                    If (TextBox6.Text = "") Then
                        MSG()
                        TextBox6.Focus()
                        Exit Sub
                    ElseIf TextBox6.TextLength < 7 Then
                        MsgBox("National Id No should be atleast 7 characters", MsgBoxStyle.Information, "error")
                        TextBox6.Focus()
                        Exit Sub
                    End If
                    If (TextBox18.Text = "") Then
                        MSG()
                        TextBox18.Focus()
                        Exit Sub
                    End If
                    If (TextBox15.Text = "") Then
                        MSG()
                        TextBox15.Focus()
                        Exit Sub
                    End If
                    'If (TextBox10.Text = "") Then
                    '    MSG()
                    '    TextBox10.Focus()
                    '    Exit Sub
                    'End If
                    'If (TextBox17.Text = "") Then
                    '    MSG()
                    '    TextBox17.Focus()
                    '    Exit Sub
                    'End If
                    'If (TextBox16.Text = "") Then
                    '    MSG()
                    '    TextBox16.Focus()
                    '    Exit Sub
                    'End If
                    'If (TextBox14.Text = "") Then
                    '    MSG()
                    '    TextBox14.Focus()
                    '    Exit Sub
                    'End If
                    Fid = TextBox6.Text
                    Fnames = TextBox18.Text
                    Ftel = TextBox15.Text
                    Femail = TextBox10.Text
                    Fwork = TextBox17.Text
                    Femployer = TextBox16.Text
                    Fresidents = TextBox14.Text
                    FSTATUS = True
                    'DATA.add("INSERT INTO father  VALUES (" & Fid & ", '" & Fnames & "', '" & Ftel & "', '" & Femail & "', '" & Fwork & "', '" & Femployer & "', '" & Fresidents & "');")
                    pfid = Fid
                Catch ex As Exception

                End Try
            End If

            If MSTATUS = True Then
                Data.add("INSERT INTO MOTHER  VALUES (" & Mid & ", '" & Mnames & "', '" & Mtel & "', '" & Memail & "', '" & Mwork & "', '" & Memployer & "', '" & Mresidents & "');")
            End If
            If FSTATUS = True Then
                DATA.add("INSERT INTO father  VALUES (" & Fid & ", '" & Fnames & "', '" & Ftel & "', '" & Femail & "', '" & Fwork & "', '" & Femployer & "', '" & Fresidents & "');")
            End If

            complete()
            TabControl1.TabPages(1).Enabled = False
            TabControl1.TabPages(2).Enabled = True
            TabControl1.SelectedIndex = 2
            ProgressBar1.Value = ProgressBar1.Maximum * (2 / 3)
            Button1.Visible = False
            Button2.Visible = True

        Catch ex As Exception

        End Try

    End Sub
    Private Function complete()
        Dim ssql As String
        Dim data As New studentsdatabase
        ssql = "INSERT INTO parents (admno ,f_id_no ,id_no)VALUES ('" & padm & "',  '" & pfid & "',  '" & pmid & "')"
        data.add(ssql)
    End Function
    Sub ADDfather()
        'Dim Fid, Fnames, Ftel, Femail, Fwork, Femployer, Fresidents As String
        'Dim DATA As New database
        'Try
        '    If (TextBox6.Text = "") Then
        '        MSG()
        '        TextBox6.Focus()
        '        Exit Sub
        '    ElseIf TextBox6.TextLength < 7 Then
        '        MsgBox("National Id No should be atleast 7 characters", MsgBoxStyle.Information, "error")
        '        TextBox6.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox18.Text = "") Then
        '        MSG()
        '        TextBox18.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox15.Text = "") Then
        '        MSG()
        '        TextBox15.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox10.Text = "") Then
        '        MSG()
        '        TextBox10.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox17.Text = "") Then
        '        MSG()
        '        TextBox17.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox16.Text = "") Then
        '        MSG()
        '        TextBox16.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox14.Text = "") Then
        '        MSG()
        '        TextBox14.Focus()
        '        Exit Sub
        '    End If
        '    Fid = TextBox6.Text
        '    Fnames = TextBox18.Text
        '    Ftel = TextBox15.Text
        '    Femail = TextBox10.Text
        '    Fwork = TextBox17.Text
        '    Femployer = TextBox16.Text
        '    Fresidents = TextBox14.Text
        '    DATA.add("INSERT INTO father  VALUES (" & Fid & ", '" & Fnames & "', '" & Ftel & "', '" & Femail & "', '" & Fwork & "', '" & Femployer & "', '" & Fresidents & "');")
        '    pfid = Fid
        'Catch ex As Exception

        'End Try
    End Sub
    Sub ADDMOTHER()
        'Dim Mid, Mnames, Mtel, Memail, Mwork, Memployer, Mresidents As String
        'Dim DATA As New studentsdatabase
        'Try
        '    If (TextBox13.Text = "") Then
        '        MSG()
        '        TextBox13.Focus()
        '        Exit Sub
        '    ElseIf TextBox13.TextLength < 8 Then
        '        MsgBox("National Id No should be atleast 7 characters", MsgBoxStyle.Information, "error")
        '        TextBox13.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox7.Text = "") Then
        '        MSG()
        '        TextBox7.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox11.Text = "") Then
        '        MSG()
        '        TextBox11.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox21.Text = "") Then
        '        MSG()
        '        TextBox21.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox8.Text = "") Then
        '        MSG()
        '        TextBox8.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox9.Text = "") Then
        '        MSG()
        '        TextBox9.Focus()
        '        Exit Sub
        '    End If
        '    If (TextBox12.Text = "") Then
        '        MSG()
        '        TextBox12.Focus()
        '        Exit Sub
        '    End If
        '    Mid = TextBox13.Text
        '    Mnames = TextBox7.Text
        '    Mtel = TextBox11.Text
        '    Memail = TextBox21.Text
        '    Mwork = TextBox8.Text
        '    Memployer = TextBox9.Text
        '    Mresidents = TextBox12.Text
        '    DATA.add("INSERT INTO MOTHER  VALUES (" & Mid & ", '" & Mnames & "', '" & Mtel & "', '" & Memail & "', '" & Mwork & "', '" & Memployer & "', '" & Mresidents & "');")
        '    pmid = Mid
        'Catch ex As Exception

        'End Try
    End Sub   'add mothers details to the database
    Sub MSG()
        MsgBox("Cant be blank!", MsgBoxStyle.Information, "error")
    End Sub
    Sub mother(ByVal admno As String)
        Dim DATA As New studentsdatabase
        Dim red As Data.DataTable
        Dim drow As DataRow
        Dim pss As New strparents
        red = DATA.executeSQL("SELECT `Id_No`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `mother` WHERE `Id_No`=" & TextBox13.Text)
        If red.Rows.Count > 0 Then
            mama = True
            Panel6.Enabled = False
            pmid = admno
        Else
            mama = False
            Panel6.Enabled = True
            pmid = ""
        End If
        For Each drow In red.Rows

            pss.idm = drow.Item(0).ToString.ToUpper.ToUpper
            pss.names = drow.Item(1).ToString.ToUpper
            pss.tel = drow.Item(2).ToString.ToUpper
            pss.email = drow.Item(3).ToString.ToUpper
            pss.work = drow.Item(4).ToString.ToUpper
            pss.employer = drow.Item(5).ToString.ToUpper
            pss.resident = drow.Item(6).ToString.ToUpper

        Next
        With pss
            TextBox7.Text = .names
            'TextBox13.Text = .idm
            TextBox11.Text = .tel
            TextBox21.Text = .email
            TextBox8.Text = .work
            TextBox9.Text = .employer
            TextBox12.Text = .resident

        End With
    End Sub  'mothers details
    Private Structure strparents
        Public idm As String
        Public names As String
        Public tel As String
        Public email As String
        Public work As String
        Public employer As String
        Public resident As String
    End Structure     'PARENTS STRUCT
    Sub father(ByVal admno As String)
        Dim DATA As New studentsdatabase
        Dim red As Data.DataTable
        Dim drow As DataRow
        Dim pss As New strparents
        red = DATA.executeSQL("SELECT `f_Id_No`, `names`, `tel`, `email`, `work`, `employer`, `Resident_id` FROM `father` WHERE `f_Id_No`=" & admno)
        If red.Rows.Count > 0 Then
            papa = True
            Panel7.Enabled = False
            pfid = admno
        Else
            papa = False
            Panel7.Enabled = True
            pfid = ""
        End If
        For Each drow In red.Rows
            pss.idm = drow.Item(0).ToString.ToUpper.ToUpper
            pss.names = drow.Item(1).ToString.ToUpper
            pss.tel = drow.Item(2).ToString.ToUpper
            pss.email = drow.Item(3).ToString.ToUpper
            pss.work = drow.Item(4).ToString.ToUpper
            pss.employer = drow.Item(5).ToString.ToUpper
            pss.resident = drow.Item(6).ToString.ToUpper
        Next
        With pss
            TextBox18.Text = .names
            ' TextBox6.Text = .idm
            TextBox15.Text = .tel
            TextBox10.Text = .email
            TextBox17.Text = .work
            TextBox16.Text = .employer
            TextBox14.Text = .resident

        End With
    End Sub   'fathers details
    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        Dim VAL As New validate
        VAL.digits(sender, e)
    End Sub
    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If TextBox13.TextLength > 6 Then
            ''CHECK IN THE DATABASE FOR AN OCCURENCE
            mother(TextBox13.Text)
        Else

        End If


    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim VAL As New validate
        VAL.digits(sender, e)
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.TextLength > 6 Then
            ''CHECK IN THE DATABASE FOR AN OCCURENCE
            father(TextBox6.Text)
        End If
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim data As New studentsdatabase

            If ComboBox1.Text = "" Then
                MsgBox("seletct a class", MsgBoxStyle.Information, "incorrect data")
                Exit Sub
            End If
            If ComboBox2.Text = "" Then
                MsgBox("seletct a stream", MsgBoxStyle.Information, "incorrect data")
                Exit Sub
            End If
            cl = class_id(ComboBox1.SelectedIndex)
            strm = str_id(ComboBox2.SelectedIndex)
            data.add1("UPDATE students SET class_code=" & cl & ",str_code=" & strm & " WHERE admno=" & padm)
            data.add1("INSERT INTO `student_class`(`admno`, `class_code`, `str_code`) VALUES (" & padm & "," & cl & "," & strm & ")")
            ProgressBar1.Value = ProgressBar1.Maximum
            Label27.Visible = True
            'bill
            Dim yr, term, charge As String
            Dim dat As String
            dat = Now.Month
            '(DateTimePicker1.Value.Month)
            yr = Now.Year
            ' (DateTimePicker1.Value.Year)
            If dat >= 1 And dat <= 4 Then
                term = "term 1"
            ElseIf dat >= 5 And dat <= 8 Then
                term = "term 2"
            ElseIf dat >= 9 And dat <= 12 Then
                term = "term 3"
            End If
            Dim admn As String = padm
            Dim lev As String = cl
            Dim amout As DataTable
            Dim sql1 As String
            If term = "term 1" Then
                sql1 = "SELECT  ifnull(sum( amount),0)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly'  or `category`='registration' ) and `L_id`='" & lev & "'"
            Else
                sql1 = "SELECT  ifnull(sum( amount),0)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" & lev & "'"
            End If
            amout = data.executeSQL(sql1)
            For Each dro As DataRow In amout.Rows ' reads fees
                charge = dro.Item(0)
                Dim bil As String
                bil = "INSERT INTO `schoolfees`.`bill` (`id`, `year`, `term`,`class_Id`, `admno`, `amount`, `status`, `date`) VALUES (NULL, '" & yr & "', '" & term & "','" & lev & "', '" & admn & "', '" & charge & "', '0', CURRENT_TIMESTAMP);"
                data.add(bil)
            Next
            'End bill
            'transfer to account fees

            Dim sd1 As Integer
            Dim admn1, cash, bill_id, sql11 As String
            Dim std, tras As DataTable
            Dim charge1 As Integer
            std = data.executeSQL("SELECT  admno ,  amount ,  id FROM  bill WHERE admno=" & adm & " and status =0")
            For Each row As DataRow In std.Rows 'reads throug list of names
                admn1 = row.Item(0).ToString
                cash = row.Item(1).ToString
                bill_id = row.Item(2).ToString
                charge1 = 0
                Dim nn As String
                nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" & admn1 & "', 'Students billing', 'bill tranfers', 'bills', '', '" & bill_id & "', '" & cash & "', '" & charge1 & "', '" & (cash + charge1) & "', '0', CURRENT_TIMESTAMP);"
                data.add("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" & admn1 & "'")
                data.add(nn)
                data.add("UPDATE `bill` SET `status`=1 WHERE `admno`='" & admn1 & "'")
                sd1 = sd1 + 1
            Next
            'end
            Timer1.Enabled = True
            Button2.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If fr > 30 Then
            Me.Close()
        Else
            fr = fr + 1
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'Dim val As New validate
        'val.alphas(sender.text)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        'If e.KeyChar=
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class