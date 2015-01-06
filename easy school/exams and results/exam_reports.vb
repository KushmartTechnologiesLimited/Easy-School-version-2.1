Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.Data
Public Class exam_reports
    Dim data As New database
    Public oDocs As Word.Document
    Public otable As Word.Table
    Public para As Word.Paragraph
    Dim class_id, str_id As New List(Of String)
    Dim f As Integer = 0
    Dim lala As String
    Private Sub report_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox2.Items
            .Add(Format(Now, "yyyy") - 2)
            .Add(Format(Now, "yyyy") - 1)
            .Add(Format(Now, "yyyy"))
            .Add(Format(Now, "yyyy") + 1)
            .Add(Format(Now, "yyyy") + 2)
        End With
        ComboBox2.SelectedIndex = 3
        With ComboBox3.Items
            For b = 1 To 3
                .Add(b)
            Next
        End With
        ComboBox3.SelectedIndex = 0
        On Error Resume Next
        Dim rd As System.Data.DataTable
        rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`")
        For Each drow In rd.Rows
            ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper)
            class_id.Add(drow.Item(0).ToString.ToUpper)
        Next

        ComboBox1.SelectedIndex = 0
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '
        Me.Cursor = Cursors.WaitCursor
        process(False)
        Me.Cursor = Cursors.Default
    End Sub
    Private Function grade(ByVal mark As Integer) As String
        Dim grad As String = ""
        If mark > 69 Then
            grad = "Very good"
        ElseIf mark > 49 And mark <= 69 Then
            grad = "Good"
        ElseIf mark > 29 And mark <= 49 Then
            grad = "Emerging"
        ElseIf mark <= 29 Then
            grad = "Not yet"
        End If
        Return grad
    End Function
    Sub nn()
        Dim cls As String
        cls = class_id(ComboBox1.SelectedIndex)
        Dim GETADMNO As String
        GETADMNO = " SELECT DISTINCT ADMNO  FROM `marks` WHERE  `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text
        Dim RED As System.Data.DataTable = data.executeSQL(GETADMNO)
        data.add("TRUNCATE VIEW4")
        For Each DROW As DataRow In RED.Rows
            Dim INSER As String
            INSER = " INSERT INTO  VIEW4 select distinct ADMNO, IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`='" & DROW.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " ),0) n,IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`='" & DROW.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ),0) m ,IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`='" & DROW.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ),0) b,( select distinct (m+n+b)/3 from marks) AVG  from marks WHERE `admno`='" & DROW.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text
            data.add(INSER)
        Next

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Function process(ByVal stat As Boolean)
        nn()
        ProgressBar1.Value = 0
        Dim cls As String
        cls = class_id(ComboBox1.SelectedIndex)
        Dim all As System.Data.DataTable
        Dim oWord = New Word.Application With {.Visible = False}
        oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() & "KIDS ZONE.dotx", , False)
        oDocs.SelectAllEditableRanges()
        Dim rng As Word.Range
        'Dim sel As Word.Selection
        rng = oDocs.Range(oDocs.Paragraphs(1).Range.Start, oDocs.Tables(4).Range.End)
        rng.Copy()
        all = data.executeSQL("SELECT `admno`,` names`, (SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE `class_code`=" & class_id(ComboBox1.SelectedIndex) & " and `status`=1")
        f = 0
        For Each drow As DataRow In all.Rows
            'start to export data to ms word
            Dim nn As Integer = all.Rows.Count
            Me.Text = nn
            otable = oDocs.Tables(1)
            otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " & drow(1)
            otable.Cell(1, 2).Range.Text = "  ADMNO : " & drow(0)
            otable.Cell(3, 3).Range.Text = "  " & drow(2) & "  " & drow(3)
            otable.Cell(3, 2).Range.Text = "TERM " & ComboBox3.Text & "  Year " & ComboBox2.Text
            otable.Cell(3, 1).Range.Text = "DATE  " & DateTimePicker1.Value.ToShortDateString

            'read subject and their marks
            Dim subject As System.Data.DataTable
            Dim ss As String = "SELECT distinct `Subject_code`, (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject'  from `marks` where `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text
            subject = data.executeSQL(ss)
            Dim _RowCount As Integer = subject.Rows.Count - 1
            Dim i As Integer = 1
            Dim POS As String
            POS = "SELECT 'POSITION :',(SELECT COUNT(*) FROM `VIEW4` B WHERE B.N>A.N )+1 AS M1,(SELECT COUNT(*) FROM `VIEW4` C WHERE C.M>A.M )+1 AS M2,(SELECT COUNT(*) FROM `VIEW4` D WHERE D.B>A.B )+1 AS M3,(SELECT COUNT(*) FROM `VIEW4` E WHERE E.AVG>A.AVG  )+1 AS M4 FROM VIEW4 A WHERE A.ADMNO='" & drow.Item(0).ToString & "'"
            Dim POSS As System.Data.DataTable = data.executeSQL(POS)

            For Each srow As DataRow In subject.Rows
                Dim ss1 As String = "SELECT distinct (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject',ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=1 and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0).ToString & "),0)'mark1', ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=2  and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0).ToString & "),0)'mark2' ,ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=3 and `admno`=" & drow.Item(0).ToString & " and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0).ToString & "),0)'mark3', ( select distinct (mark1+mark2+mark3)/3 from marks) as h from marks where `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0) & ""
                Dim marks As System.Data.DataTable
                marks = data.executeSQL(ss1)
                Dim otable As Word.Table
                otable = oDocs.Tables(2)
                Dim tots As String
                tots = "select distinct'Total :', (SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " ) n,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ) m ,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ) b,( select distinct (m+n+b)/3 from marks)  from marks"

                Dim total As System.Data.DataTable
                total = data.executeSQL(tots)
                For Each mrow As DataRow In marks.Rows
                    Dim _ColCount As Integer = marks.Columns.Count - 1
                    Dim f As Integer
                    For _col As Integer = 0 To _ColCount
                        otable.Cell(i + 1, _col + 1).Range.Text = _
                            mrow.Item(_col).ToString
                        f = _col
                    Next
                    otable.Cell(i + 1, f + 2).Range.Text = grade(mrow.Item(f))
                    'Next
                    'End read
                    i = i + 1
                    otable.Rows.Add()
                    For Each mrow1 As DataRow In total.Rows
                        Dim _ColCount1 As Integer = total.Columns.Count - 1
                        For _col1 As Integer = 0 To _ColCount1
                            otable.Cell(i + 1, _col1 + 1).Range.Text = _
                            mrow1.Item(_col1).ToString()
                        Next
                    Next
                    For Each mrow2 As DataRow In POSS.Rows
                        Dim _ColCount1 As Integer = total.Columns.Count - 1
                        For _col1 As Integer = 0 To _ColCount1
                            otable.Cell(i + 2, _col1 + 1).Range.Text = _
                            mrow2.Item(_col1).ToString()
                        Next
                    Next
                Next

            Next

            Dim otable3 As Word.Table
            otable3 = oDocs.Tables(3)
            otable3.Cell(1, 1).Range.Text = otable3.Cell(1, 1).Range.Text & "  " & TextBox1.Text
            ' otable3.Cell(1, 1).Range.Text = "GENERAL COMMENTS  " & TextBox1.Text
            otable3.Cell(1, 1).Range.Underline = WdUnderline.wdUnderlineNone
            otable3.Cell(1, 1).Range.Font.Size = 12
            Dim otable2 As Word.Table
            otable2 = oDocs.Tables(4)
            otable2.Cell(1, 1).Range.Text = DateTimePicker2.Value.ToShortDateString
            If stat = False Then
                oDocs.SaveAs(TextBox2.Text & "/" & drow(1) & " term  " & ComboBox3.Text & " year " & ComboBox2.Text & ".doc")
            Else
                oDocs.PrintOut(False)
            End If
            Try
                oDocs.Undo(1000)
            Catch ex As Exception

            End Try
            f = f + 1
            ProgressBar1.Value = (f / all.Rows.Count * 100)
            Label7.Text = f & " of " & all.Rows.Count
        Next
        Label7.Text = Label7.Text & " completed !"
        oDocs.Close(SaveChanges:=False)
        oDocs = Nothing
        oWord.Quit()
        oWord = Nothing
        Return 0
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        process(True)
        'Me.Dispose()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveFileDialog1.ShowDialog()
        Dim blah As String = SaveFileDialog1.FileName()
        'Dim saveDlg As New SaveFileDialog()
        SaveFileDialog1.FileName = "backup"
        SaveFileDialog1.DefaultExt = ".doc"
        'saveDlg.InitialDirectory = "."
        SaveFileDialog1.InitialDirectory = "."
        SaveFileDialog1.Filter = "BackUp (*.doc)|*.doc"
        SaveFileDialog1.RestoreDirectory = True
        SaveFileDialog1.FileName = "Back up"



        Dim meh As Integer = blah.LastIndexOf("\")
        lala = blah.Substring(0, meh)
        Dim path As String = lala
        TextBox2.Text = lala
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim all As System.Data.DataTable
        all = data.executeSQL("SELECT `admno`,` names`, (SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE `admno`='" & TextBox3.Text & "' and `status`=1")
        f = 0
        If all.Rows.Count < 1 Then
            MsgBox("no record found")
            Exit Sub
        End If
        nn()
        ProgressBar1.Value = 0
        Dim cls As String
        cls = class_id(ComboBox1.SelectedIndex)

        Dim oWord = New Word.Application With {.Visible = False}
        oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() & "KIDS ZONE.dotx", , False)
        oDocs.SelectAllEditableRanges()
        Dim rng As Word.Range
        'Dim sel As Word.Selection
        rng = oDocs.Range(oDocs.Paragraphs(1).Range.Start, oDocs.Tables(4).Range.End)
        rng.Copy()

        For Each drow As DataRow In all.Rows
            'start to export data to ms word
            Dim nn As Integer = all.Rows.Count
            Me.Text = nn
            otable = oDocs.Tables(1)
            otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " & drow(1)
            otable.Cell(1, 2).Range.Text = "  ADMNO : " & drow(0)
            otable.Cell(3, 3).Range.Text = "  " & drow(2) & "  " & drow(3)
            otable.Cell(3, 2).Range.Text = "TERM " & ComboBox3.Text & "  Year " & ComboBox2.Text
            otable.Cell(3, 1).Range.Text = "DATE  " & DateTimePicker1.Value.ToShortDateString

            'read subject and their marks
            Dim subject As System.Data.DataTable
            Dim ss As String = "SELECT distinct `Subject_code`, (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject'  from `marks` where `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text
            subject = data.executeSQL(ss)
            Dim _RowCount As Integer = subject.Rows.Count - 1
            Dim i As Integer = 1
            Dim POS As String
            POS = "SELECT 'POSITION :',(SELECT COUNT(*) FROM `VIEW4` B WHERE B.N>A.N )+1 AS M1,(SELECT COUNT(*) FROM `VIEW4` C WHERE C.M>A.M )+1 AS M2,(SELECT COUNT(*) FROM `VIEW4` D WHERE D.B>A.B )+1 AS M3,(SELECT COUNT(*) FROM `VIEW4` E WHERE E.AVG>A.AVG  )+1 AS M4 FROM VIEW4 A WHERE A.ADMNO='" & drow.Item(0).ToString & "'"
            Dim POSS As System.Data.DataTable = data.executeSQL(POS)

            For Each srow As DataRow In subject.Rows
                Dim ss1 As String = "SELECT distinct (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject',ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=1 and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0).ToString & "),0)'mark1', ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=2  and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0).ToString & "),0)'mark2' ,ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=3 and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0).ToString & "),0)'mark3', ( select distinct (mark1+mark2+mark3)/3 from marks) as h from marks where `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0) & ""
                Dim marks As System.Data.DataTable
                marks = data.executeSQL(ss1)
                Dim otable As Word.Table
                otable = oDocs.Tables(2)
                Dim tots As String
                tots = "select distinct'Total :', (SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " ) n,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ) m ,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`='" & drow.Item(0).ToString & "' and `class_code`=" & cls & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ) b,( select distinct (m+n+b)/3 from marks)  from marks"

                Dim total As System.Data.DataTable
                total = data.executeSQL(tots)
                For Each mrow As DataRow In marks.Rows
                    Dim _ColCount As Integer = marks.Columns.Count - 1
                    Dim f As Integer
                    For _col As Integer = 0 To _ColCount
                        otable.Cell(i + 1, _col + 1).Range.Text = _
                            mrow.Item(_col).ToString
                        f = _col
                    Next
                    otable.Cell(i + 1, f + 2).Range.Text = grade(mrow.Item(f))
                    'Next
                    'End read
                    i = i + 1
                    otable.Rows.Add()
                    For Each mrow1 As DataRow In total.Rows
                        Dim _ColCount1 As Integer = total.Columns.Count - 1
                        For _col1 As Integer = 0 To _ColCount1
                            otable.Cell(i + 1, _col1 + 1).Range.Text = _
                            mrow1.Item(_col1).ToString()
                        Next
                    Next
                    For Each mrow2 As DataRow In POSS.Rows
                        Dim _ColCount1 As Integer = total.Columns.Count - 1
                        For _col1 As Integer = 0 To _ColCount1
                            otable.Cell(i + 2, _col1 + 1).Range.Text = _
                            mrow2.Item(_col1).ToString()
                        Next
                    Next
                Next

            Next

            Dim otable3 As Word.Table
            otable3 = oDocs.Tables(3)
            otable3.Cell(1, 1).Range.Text = otable3.Cell(1, 1).Range.Text & "  " & TextBox1.Text
            ' otable3.Cell(1, 1).Range.Text = "GENERAL COMMENTS  " & TextBox1.Text
            otable3.Cell(1, 1).Range.Underline = WdUnderline.wdUnderlineNone
            otable3.Cell(1, 1).Range.Font.Size = 12
            Dim otable2 As Word.Table
            otable2 = oDocs.Tables(4)
            otable2.Cell(1, 1).Range.Text = DateTimePicker2.Value.ToShortDateString
            oDocs.PrintOut(False)
            Try
                oDocs.Undo(1000)
            Catch ex As Exception

            End Try
            f = f + 1
            ProgressBar1.Value = (f / all.Rows.Count * 100)
            Label7.Text = f & " of " & all.Rows.Count
        Next
        Label7.Text = Label7.Text & " completed !"
        oDocs.Close(SaveChanges:=False)
        oDocs = Nothing
        oWord.Quit()
        oWord = Nothing
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton2.Checked = True Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
