Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Odbc
Public Class Form2
    Dim data As New database
    Dim class_id, str_id As New List(Of String)
    Dim cl As String = 0
    Dim strm As String = 0
    Dim J As Integer
    Public CLSS As Integer
    Public STR As String
    Public connstring As String = "Dsn=school;database=school;option=0;port=3306;server=localhost;uid=school; password=incorrect;"
    Public admNo, clas, year, term, exam, maths, eng, kisw, social, sci, total, position, examno, grammer, reading, composition, lugha, kusoma, insha, cre, C0MP, MUSIC, SWIMMING, PE, examcode As VariantType
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        eg()
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        eg()
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        eg()
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        eg()
    End Sub
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        ks()
    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        ks()
    End Sub
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        ks()
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        ks()
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
    Dim kis, tot As Integer
    Private Sub ks()
        If Val(TextBox9.Text) > 50 Then
            MsgBox("marks out of range", , "")
            TextBox9.Focus()
            TextBox9.Text = ""
        End If
        If Val(TextBox8.Text) > 30 Then
            MsgBox("marks out of range", , "")
            TextBox8.Focus()
            TextBox8.Text = ""
        End If
        If Val(TextBox7.Text) > 20 Then
            MsgBox("marks out of range", , "")
            TextBox7.Focus()
            TextBox7.Text = ""
        End If
        kis = Val(TextBox9.Text) + Val(TextBox8.Text) + Val(TextBox7.Text)
        TextBox6.Text = kis
        totl()
    End Sub
    Private Sub eg()
        If Val(TextBox2.Text) > 50 Then
            MsgBox("marks out of range", , "")
            TextBox2.Focus()
            TextBox2.Text = ""
        End If
        If Val(TextBox3.Text) > 30 Then
            MsgBox("marks out of range", , "")
            TextBox3.Focus()
            TextBox3.Text = ""
        End If
        If Val(TextBox4.Text) > 20 Then
            MsgBox("marks out of range", , "")
            TextBox4.Focus()
            TextBox4.Text = ""
        End If
        eng = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)
        TextBox5.Text = eng
        totl()
    End Sub
    Private Sub totl()
        If Val(TextBox10.Text) > 50 Then
            MsgBox("marks out of range", , "")
            TextBox10.Focus()
            TextBox10.Text = ""
        End If
        If Val(TextBox11.Text) > 50 Then
            MsgBox("marks out of range", , "")
            TextBox11.Focus()
            TextBox11.Text = ""
        End If
        If Val(TextBox12.Text) > 30 Then
            MsgBox("marks out of range", , "")
            TextBox12.Focus()
            TextBox12.Text = ""
        End If
        If Val(TextBox13.Text) > 20 Then
            MsgBox("marks out of range", , "")
            TextBox13.Focus()
            TextBox13.Text = ""
        End If
        tot = kis + eng + (2 * Val(TextBox10.Text)) + (2 * Val(TextBox11.Text)) + (2 * (Val(TextBox12.Text) + Val(TextBox13.Text)))
        TextBox18.Text = tot
    End Sub
    Private Sub CLEAR()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox20.Text = ""
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim rd, rd1 As DataTable
        rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`")
        rd1 = data.executeSQL("SELECT code, name FROM stream")
        For Each drow In rd.Rows
            ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper)
            class_id.Add(drow.Item(0).ToString.ToUpper)
        Next
        For Each drow In rd1.Rows
            ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper)
            str_id.Add(drow.Item(0).ToString.ToUpper)
        Next
        ComboBox1.SelectedItem = 1
        ComboBox2.SelectedItem = 1
        TextBox20.Enabled = False
        'With ComboBox1.Items
        '    For G As Integer = 1 To 8
        '        .Add(G)
        '    Next
        'End With
        With ComboBox3.Items
            .Add(1)
            .Add(2)
            .Add(3)
        End With
        With ComboBox4.Items
            .Add(Format(Now, "yyyy") - 2)
            .Add(Format(Now, "yyyy") - 1)
            .Add(Format(Now, "yyyy"))
            .Add(Format(Now, "yyyy") + 1)
            .Add(Format(Now, "yyyy") + 2)
        End With
        'With ComboBox2.Items
        '    .Add("VANILLA")
        '    .Add("STRAWBERRY")
        '    .Add("CHOCOLATE")
        'End With
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        totl()
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        totl()

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        totl()

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        totl()

    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        totl()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CLSS = class_id(ComboBox1.SelectedIndex)
        STR = str_id(ComboBox2.SelectedIndex)
        GroupBox1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        year = Val(ComboBox4.Text)
        term = Val(ComboBox3.Text)
        If RadioButton1.Checked = True Then
            exam = 1
        End If
        If RadioButton2.Checked = True Then
            exam = 2
        End If
        If RadioButton3.Checked = True Then
            exam = 3
        End If
        TextBox21.Text = year & " " & term & " " & exam
        GroupBox2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mh As New OdbcDataAdapter
        Dim DS As DataSet
        Dim DTABLE As DataTable
        TextBox20.Text = ""
        Try

            'Dim conn As New OdbcConnection(connstring)
            'Dim cn As New OdbcCommand
            Dim v As Integer
            'If conn.State = ConnectionState.Open Then
            '    conn.Close()
            'End If
            'mh.SelectCommand = New OdbcCommand("select * from students where admno='" & Val(TextBox1.Text) & "' and  status=1", conn)
            'DS = New DataSet("DS")
            'mh.Fill(DS)
            'DTABLE = DS.Tables(0)
            DTABLE = data.executeSQL("select * from students where admno='" & Val(TextBox1.Text) & "' and  status=1")

            v = DTABLE.Rows.Count
            If v < 1 Then
                MsgBox("no record found ", , "")
                DataGridView1.DataSource = Nothing
                TextBox1.Text = ""
                TextBox1.Focus()
                admNo = Nothing
                Button3.Enabled = True
                Exit Sub
            End If

            GroupBox3.Enabled = True
            For Each drow As DataRow In DTABLE.Rows
                TextBox20.Text = drow(0) & "  " & drow(2)
                '& " " & drow(5)
                'DocName.SelectedIndex = -1
                admNo = drow(0)
                clas = drow(7)

            Next
            Button3.Enabled = False
            'conn.Open()

            'If conn.State = ConnectionState.Open Then
            '    conn.Close()
            'End If
            'mh.SelectCommand = New OdbcCommand("select exam'Cat', grammer, reading, composition'comp' ,eng, lugha, kusoma, insha, kisw,maths,sci,(social+ cre)'social', total from RESULTS WHERE YEAR=" & year & " AND admno=" & admNo & " AND CLASS=" & CLSS & " AND TERM=" & term & ";", conn)
            'DS = New DataSet("STUDENTS")
            'mh.Fill(DS, "STUDENTS")
            'DTABLE = DS.Tables(0)
            DTABLE = data.executeSQL("select exam'Cat', grammer, reading, composition'comp' ,eng, lugha, kusoma, insha, kisw,maths,sci,(social+ cre)'social', total from RESULTS WHERE YEAR=" & year & " AND admno=" & admNo & " AND CLASS=" & CLSS & " AND TERM=" & term & ";")
            v = DTABLE.Rows.Count
            If v < 1 Then
                DataGridView1.DataSource = Nothing
                Exit Sub
            End If
            DataGridView1.DataSource = DTABLE

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CHECKQ()
        If J > 0 Then
            MsgBox("ENRTY ALREADY EXISTS ", , "")
            Button3.Enabled = True
            Exit Sub
        End If
        results()
        Dim mh As New OdbcDataAdapter
        Try

            'Dim conn As New OdbcConnection(connstring)
            'Dim cn As New OdbcCommand
            'If conn.State = ConnectionState.Open Then
            '    conn.Close()
            'End If
            'conn.Open()
            'cn.CommandText = ("INSERT INTO results(admNo, class, year, term, exam, maths, eng, kisw, social,sci, total, position,grammer, reading, composition, lugha, kusoma, insha, cre, C0MP, MUSIC, SWIMMING, Pe) VALUES(" & admNo & ", " & clas & ", " & year & ", " & term & "," & exam & ", " & maths & ", " & eng & ", " & kisw & ", " & social & "," & sci & "," & total & "," & position & "," & grammer & "," & reading & "," & composition & "," & lugha & "," & kusoma & "," & insha & "," & cre & "," & C0MP & "," & MUSIC & "," & SWIMMING & "," & PE & ")")
            'cn.Connection = conn
            'mh.SelectCommand = cn
            'cn.ExecuteNonQuery()
            'MsgBox("record added ", vbOKOnly + vbInformation)
            data.add("INSERT INTO results(admNo, class, year, term, exam, maths, eng, kisw, social,sci, total, position,grammer, reading, composition, lugha, kusoma, insha, cre, C0MP, MUSIC, SWIMMING, Pe) VALUES(" & admNo & ", " & clas & ", " & year & ", " & term & "," & exam & ", " & maths & ", " & eng & ", " & kisw & ", " & social & "," & sci & "," & total & "," & position & "," & grammer & "," & reading & "," & composition & "," & lugha & "," & kusoma & "," & insha & "," & cre & "," & C0MP & "," & MUSIC & "," & SWIMMING & "," & PE & ")")
            admNo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        admNo = Nothing
        GroupBox3.Enabled = False
        Button3.Enabled = True

        CLEAR()
    End Sub
    Private Sub results()
        maths = (Val(TextBox10.Text) * 2)
        eng = Val(TextBox5.Text)
        kisw = Val(TextBox6.Text)
        social = Val(TextBox12.Text) * 2
        sci = Val(TextBox11.Text) * 2
        total = Val(TextBox18.Text)
        position = 0
        grammer = Val(TextBox2.Text)
        reading = Val(TextBox4.Text)
        composition = Val(TextBox3.Text)
        lugha = Val(TextBox9.Text)
        kusoma = Val(TextBox7.Text)
        insha = Val(TextBox8.Text)
        cre = Val(TextBox13.Text) * 2
        C0MP = Val(TextBox17.Text) * 2
        MUSIC = Val(TextBox16.Text) * 2
        SWIMMING = Val(TextBox15.Text) * 2
        PE = Val(TextBox14.Text) * 2
    End Sub

    Private Sub CHECKQ()
        Dim mh As New OdbcDataAdapter
        Dim DS As DataSet
        Dim DTABLE As DataTable
        Try

            'Dim conn As New OdbcConnection(connstring)
            'Dim cn As New OdbcCommand

            'If conn.State = ConnectionState.Open Then
            '    conn.Close()
            'End If
            'mh.SelectCommand = New OdbcCommand("select * from RESULTS where admno='" & admNo & "' AND YEAR=" & year & " AND EXAM=" & exam & ";", conn)
            'DS = New DataSet("DS")
            'mh.Fill(DS)
            'DTABLE = DS.Tables(0)
            DTABLE = data.executeSQL("select * from RESULTS where admno='" & admNo & "' AND YEAR=" & year & " AND EXAM=" & exam & ";")
            J = DTABLE.Rows.Count

            'conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ChildForl As New Form5
        ' Make it a child of this MDI form before showing it.
        'ChildForl.MdiParent = home2
        'ChildForl.Show()
        ' Form5.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox3.Enabled = False
        Button3.Enabled = True

        CLEAR()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True

    End Sub
End Class