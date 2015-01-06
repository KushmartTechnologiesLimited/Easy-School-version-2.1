
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.Data
Public Class Form1
    Dim data As New database
    Public oDocs As Word.Document
    Public otable As Word.Table
    Public para As Word.Paragraph
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objWord As Word.Application
        Dim objDoc As Word.Document
        objWord = CreateObject("Word.Application")
        objWord.Visible = True
        objDoc = objWord.Documents.Add
        Dim _RowCount As Integer = DataGridView1.Rows.Count - 1
        Dim _ColCount As Integer = DataGridView1.Columns.Count - 1
        Dim ht1 As Word.Table
        ht1 = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, _
                              _RowCount + 1, _ColCount + 1)
        ht1.Borders.OutsideColor = Word.WdColor.wdColorBlack
        ht1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
        ht1.Borders.InsideColor = Word.WdColor.wdColorBlack
        ht1.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle

        For i As Integer = 0 To _RowCount
            ht1.Rows.Add()
            For _col As Integer = 0 To _ColCount
                ht1.Cell(i + 1, _col + 1).Range.Text = _
                    DataGridView1.Rows(i).Cells(_col).Value.ToString()
            Next
        Next
        'objDoc.SaveAs2("C:/tee.docx")
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
       
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 11
            ComboBox1.Items.Add(i)
        Next
        With ComboBox3.Items
            .Add(1)
            .Add(2)
            .Add(3)
        End With
        With ComboBox2.Items
            .Add(Format(Now, "yyyy") - 2)
            .Add(Format(Now, "yyyy") - 1)
            .Add(Format(Now, "yyyy"))
            .Add(Format(Now, "yyyy") + 1)
            .Add(Format(Now, "yyyy") + 2)
        End With
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim all As System.Data.DataTable
        all = data.executeSQL("SELECT `admno`,  ` names` FROM `students` WHERE `class_code` =" & ComboBox1.Text & " and `status`=1")
        DataGridView1.DataSource = data.executeSQL("SELECT `admno`,  ` names` FROM `students` WHERE `class_code` =" & ComboBox1.Text & " and `status`=1")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ss As String = "SELECT distinct (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject',(SELECT  `score` FROM `marks` WHERE  `Exam_no`=1 and `admno`=" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value.ToString & ")'mark1',(SELECT  `score` FROM `marks` WHERE  `Exam_no`=2  and `admno`=" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value.ToString & ")'mark2' ,(SELECT  `score` FROM `marks` WHERE  `Exam_no`=3 and `admno`=" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value.ToString & ")'mark3'from marks where `admno`=" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & DataGridView2.Item(0, DataGridView2.CurrentRow.Index).Value.ToString & ""
        Dim led As System.Data.DataTable = data.executeSQL(ss)
        ''   DataGridView2.Rows.Add()
        'For o = 0 To DataGridView3.Columns.Count
        '    DataGridView3.Rows.Insert(o + 1, 1)

        '    DataGridView3.Item(DataGridView3.Rows.Count + 1, o).Value = led.Rows(0).Item(o).ToString
        'Next
        DataGridView3.DataSource = led


    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ss As String = "SELECT distinct `Subject_code`, (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject'  from `marks` where `admno`=" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text
        Dim led1 As System.Data.DataTable = data.executeSQL(ss)
        DataGridView2.DataSource = led1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim all As System.Data.DataTable
        all = data.executeSQL("SELECT `admno`,  ` names` FROM `students` WHERE `class_code` =" & ComboBox1.Text & " and `status`=1")
        For Each drow As DataRow In all.Rows
            'start to export data to ms word
            Dim oWord = New Word.Application With {.Visible = True}
            oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() & "KIDS ZONE.dotx", , False)
            oDocs.SelectAllEditableRanges()
            Dim rng As Word.Range
            'Dim sel As Word.Selection
            rng = oDocs.Range(oDocs.Paragraphs(1).Range.Start, oDocs.Tables(4).Range.End)
            rng.Copy()
            otable = oDocs.Tables(1)
            otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " & drow(1)
            otable.Cell(1, 2).Range.Text = "  ADMNO : " & drow(0)
            'otable.Cell(3, 3).Range.Text = "CLASS  " & drow1(3) & "  " & drow1(2)
            'otable.Cell(3, 2).Range.Text = "TERM " & tr & "  Year " & yr
            'otable.Cell(3, 1).Range.Text = "DATE  " & DateTimePicker1.Value.ToShortDateString

            'read subject and their marks
            Dim subject As System.Data.DataTable
            Dim ss As String = "SELECT distinct `Subject_code`, (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject'  from `marks` where `admno`=" & drow.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text
            subject = data.executeSQL(ss)
            Dim _RowCount As Integer = subject.Rows.Count - 1
            Dim i As Integer = 1
            Dim POS As String
            POS = "SELECT 'POSITION :',(SELECT COUNT(*) FROM `VIEW4` B WHERE B.N>A.N )+1 AS M1,(SELECT COUNT(*) FROM `VIEW4` C WHERE C.M>A.M )+1 AS M2,(SELECT COUNT(*) FROM `VIEW4` D WHERE D.B>A.B )+1 AS M3,(SELECT COUNT(*) FROM `VIEW4` E WHERE E.AVG>A.AVG  )+1 AS M4 FROM VIEW4 A WHERE A.ADMNO=" & drow.Item(0).ToString
            Dim POSS As System.Data.DataTable = data.executeSQL(POS)

            For Each srow As DataRow In subject.Rows
                Dim ss1 As String = "SELECT distinct (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject',ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=1 and `admno`=" & drow.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0).ToString & "),0)'mark1', ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=2  and `admno`=" & drow.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0).ToString & "),0)'mark2' ,ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=3 and `admno`=" & drow.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0).ToString & "),0)'mark3', ( select distinct (mark1+mark2+mark3)/3 from marks) as h from marks where `admno`=" & drow.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " and `Subject_code`=" & srow.Item(0) & ""
                Dim marks As System.Data.DataTable
                marks = data.executeSQL(ss1)
                Dim otable As Word.Table
                otable = oDocs.Tables(2)
                Dim tots As String
                tots = "select distinct'Total :', (SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`=" & drow.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " ) n,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`=" & drow.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ) m ,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`=" & drow.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ) b,( select distinct (m+n+b)/3 from marks)  from marks"

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
                            otable.Cell(i + 1, _col1 + 1).Range.Text = _
                            mrow2.Item(_col1).ToString()
                        Next
                    Next
                Next
              
            Next

           
           

           
            'jj
            oDocs.PrintOut(False)
            oDocs.Close(SaveChanges:=False)
            oDocs = Nothing
            oWord.Quit()
            oWord = Nothing
        Next

    End Sub

  
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim GETADMNO As String
        GETADMNO = " SELECT DISTINCT ADMNO  FROM `marks` WHERE  `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text
        Dim RED As System.Data.DataTable = data.executeSQL(GETADMNO)
        data.add("TRUNCATE VIEW4")
        For Each DROW As DataRow In RED.Rows
            Dim INSER As String
            INSER = " INSERT INTO  VIEW4 select distinct ADMNO, IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`=" & DROW.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & " ),0) n,IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`=" & DROW.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ),0) m ,IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`=" & DROW.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text & "  ),0) b,( select distinct (m+n+b)/3 from marks) AVG  from marks WHERE `admno`=" & DROW.Item(0).ToString & " and `class_code`=" & ComboBox1.Text & " and `year`=" & ComboBox2.Text & " and `term`= " & ComboBox3.Text
            data.add(INSER)
        Next


    End Sub
End Class