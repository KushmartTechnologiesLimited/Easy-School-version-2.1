Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.Data

Public Class report_form
    Dim data As New database
    Public oDocs As Word.Document
    Public otable As Word.Table
    Public para As Word.Paragraph
    Dim class_id, str_id As New List(Of String)
    Dim lala As String
    ' Public connstring As String = "Dsn=school;database=school;option=0;port=3306;server=localhost;uid=school; password=incorrect;"
    Public admno, yr, tr, BLANK, CLS, STB, STBB, kk, a, b As Integer
    Dim POS, OUT As String
    Dim language3, reading3, comp3, etotal3, lugha3, kusoma3, insha3, ktotal3, maths3, sci3, social3, cre3, total3 As Integer
    Dim language1, reading1, comp1, etotal1, lugha1, kusoma1, insha1, ktotal1, maths1, sci1, social1, cre1, total1 As Integer
    Dim language2, reading2, comp2, etotal2, lugha2, kusoma2, insha2, ktotal2, maths2, sci2, social2, cre2, total2 As Integer
    Dim mark As Integer
    Dim grad As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '   MsgBox(System.AppDomain.CurrentDomain.BaseDirectory.ToString())
        yr = 0
        tr = 0
        CLS = 0
        STBB = 0
        STB = 0
        ProgressBar1.Value = 0
        Label7.Text = ""
        Me.Cursor = Cursors.WaitCursor
        Try

            'otable = oDocs.Tables.Add(oDocs.Bookmarks.Item("\endofdoc").Range, rowsTotal + 1, colsTotal)
            yr = ComboBox1.Text
            tr = ComboBox2.Text
            CLS = class_id(ComboBox3.SelectedIndex)
            'C:\Users\sam\Documents\Visual Studio 2012\Projects\school"
            Dim oWord = New Word.Application With {.Visible = true}

            oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() & "KIDS ZONE.dotx", , False)
            'Dim conn As New OdbcConnection(connstring)
            'Dim cn As New OdbcCommand
            'Dim cmd As New OdbcDataAdapter
            Dim DT As System.Data.DataTable
            'Dim dt As DataTable

            'Dim DF As DataSet
            ' Dim YR As String = 2012
            'conn.Open()
            'cmd.SelectCommand = New OdbcCommand("SELECT results.admno,students.name,students.stream,students.class FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno", conn)
            'DF = New DataSet("DF")
            'cmd.Fill(DF)
            DT = data.executeSQL("SELECT results.admno,students.` names`,students.`str_code`,students.`class_code` FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno")
            'data.executeSQL("SELECT results.admno,students.' names','students.stream','students.class' FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno")
            ' DT = DF.Tables(0)
            Dim otable3 As Word.Table
            otable3 = oDocs.Tables(3)
            otable3.Cell(1, 1).Range.Text = otable3.Cell(1, 1).Range.Text & "  " & TextBox1.Text
            ' otable3.Cell(1, 1).Range.Text = "GENERAL COMMENTS  " & TextBox1.Text
            otable3.Cell(1, 1).Range.Underline = WdUnderline.wdUnderlineNone
            otable3.Cell(1, 1).Range.Font.Size = 12
            Dim otable2 As Word.Table
            otable2 = oDocs.Tables(4)
            otable2.Cell(1, 1).Range.Text = DateTimePicker2.Value.ToShortDateString

            STB = DT.Rows.Count
            STBB = 1
            For Each drow1 As DataRow In DT.Rows

                otable = oDocs.Tables(1)
                otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " & drow1(1)
                otable.Cell(1, 2).Range.Text = "  ADMNO : " & drow1(0)
                otable.Cell(3, 3).Range.Text = "CLASS  " & drow1(3) & "  " & drow1(2)
                otable.Cell(3, 2).Range.Text = "TERM " & tr & "  Year " & yr
                otable.Cell(3, 1).Range.Text = "DATE  " & DateTimePicker1.Value.ToShortDateString
                admno = drow1(0)
                cat()
                cat2()
                cat3()
                'MsgBox("HHH")
                oDocs.PrintOut(False)
                Label7.Text = STBB & " of " & STB
                ProgressBar1.Value = (STBB / STB * 100)
                STBB = STBB + 1
            Next

            oDocs.Close(SaveChanges:=False)
            oDocs = Nothing
            oWord.Quit()
            oWord = Nothing
            'conn.Close()
            MsgBox("PRINT COMPLETED ", MsgBoxStyle.Information, "")
        Catch d As Exception
            MsgBox(d.Message & vbTab & "SOME DOCUMENTS MIGHT NOT HAVE PROCESED")
        End Try
        Me.Cursor = Cursors.Default
        yr = 0
        tr = 0
        CLS = 0
        STBB = 0
        STB = 0
        ProgressBar1.Value = 0
        Label7.Text = ""
    End Sub
    Private Sub cat()
        Try
            Dim otable As Word.Table
            otable = oDocs.Tables(2)
            'Dim conn As New OdbcConnection(connstring)
            'Dim cmd1 As New OdbcDataAdapter
            Dim DT1 As System.Data.DataTable
            'Dim DF1 As DataSet
            'conn.Open()
            OUT = "(SELECT count( * ) FROM results where  year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and exam=1)"
            POS = "(SELECT (SELECT count( * ) FROM results b WHERE b.total > a.total  AND TERM=" & tr & " and RESULTS.CLASS= " & CLS & "  AND YEAR= " & yr & " AND EXAM=1 ) +1 AS Rank FROM results a WHERE ADMNO =" & admno & " and RESULTS.CLASS= " & CLS & " AND TERM=" & tr & "  AND YEAR= " & yr & " AND EXAM=1 ORDER BY rank )"
            'cmd1.SelectCommand = New OdbcCommand("SELECT *," & POS & "," & OUT & " From results where admno=" & admno & " and RESULTS.CLASS= " & CLS & " and year= " & yr & " and term= " & tr & " and exam=1;", conn)
            'DF1 = New DataSet("DF")
            'cmd1.Fill(DF1)
            'DT1 = DF1.Tables(0)
            DT1 = data.executeSQL("SELECT *," & POS & "," & OUT & " From results where admno=" & admno & " and RESULTS.CLASS= " & CLS & " and year= " & yr & " and term= " & tr & " and exam=1;")
            If DT1.Rows.Count < 1 Then
                BLANK = 2
                Call GTY()
                Call setzero1()
            End If

            For Each CAT1 As DataRow In DT1.Rows
                otable.Cell(2, 2).Range.Text = CAT1(13)
                otable.Cell(3, 2).Range.Text = CAT1(14)
                otable.Cell(4, 2).Range.Text = CAT1(15)
                otable.Cell(5, 2).Range.Text = CAT1(6)
                otable.Cell(7, 2).Range.Text = CAT1(16)
                otable.Cell(8, 2).Range.Text = CAT1(17)
                otable.Cell(9, 2).Range.Text = CAT1(18)
                otable.Cell(10, 2).Range.Text = CAT1(7)
                otable.Cell(12, 2).Range.Text = CAT1(5)
                otable.Cell(13, 2).Range.Text = CAT1(9)
                otable.Cell(14, 2).Range.Text = CAT1(8)
                'otable.Cell(16, 2).Range.Text = ("sci")
                otable.Cell(17, 2).Range.Text = CAT1(20)
                otable.Cell(18, 2).Range.Text = CAT1(23)
                otable.Cell(19, 2).Range.Text = CAT1(21)
                'otable.Cell(20, 2).Range.Text = ("art")
                otable.Cell(21, 2).Range.Text = CAT1(22)
                otable.Cell(23, 2).Range.Text = CAT1(10)
                otable.Cell(24, 2).Range.Text = Format((CAT1(10) / 5), "0.0")
                otable.Cell(25, 2).Range.Text = CAT1(25)
                otable.Cell(26, 2).Range.Text = CAT1(26)
                kk = CAT1(12)
                markj()
                '//////



                '\\\\
                language1 = CAT1(13)
                reading1 = CAT1(14)
                comp1 = CAT1(15)
                etotal1 = CAT1(6)
                lugha1 = CAT1(16)
                kusoma1 = CAT1(17)
                insha1 = CAT1(18)
                ktotal1 = CAT1(7)
                maths1 = CAT1(5)
                sci1 = CAT1(9)
                social1 = CAT1(8)
                'otable.Cell(16,  3).Range.Text = ("sci")
                'cre1 = CAT1(20)
                'otable.Cell(18, 3).Range.Text = CAT2(23)
                'otable.Cell(19, 3).Range.Text = CAT2(21)
                ''otable.Cell(20,  3).Range.Text = ("art")
                'otable.Cell(21, 3).Range.Text = CAT2(22)
                total1 = CAT1(10)
                'otable.Cell(24, 3).Range.Text = Format((CAT2(10) / 5), "0.0")
                'otable.Cell(25, 3).Range.Text = CAT2(25)
                'otable.Cell(26, 3).Range.Text = CAT2(26)

                '///////
            Next
        Catch EX As Exception
            MsgBox(EX.Message, , 11)
        End Try

    End Sub
    Private Sub cat2()
        Try
            Dim otable As Word.Table
            otable = oDocs.Tables(2)
            'Dim conn As New OdbcConnection(connstring)
            'Dim cmd2 As New OdbcDataAdapter
            Dim DT2 As System.Data.DataTable
            'Dim DF2 As DataSet
            'conn.Open()
            OUT = "(SELECT count( * ) FROM results where  year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and exam=2)"
            POS = "(SELECT (SELECT count( * ) FROM results b WHERE b.total > a.total  AND TERM=" & tr & " and RESULTS.CLASS= " & CLS & "  AND YEAR= " & yr & " AND EXAM=2 ) +1 AS Rank FROM results a WHERE ADMNO =" & admno & " and RESULTS.CLASS= " & CLS & " AND TERM=" & tr & "  AND YEAR= " & yr & " AND EXAM=2 ORDER BY rank )"
            'cmd2.SelectCommand = New OdbcCommand("SELECT *," & POS & "," & OUT & " From results where admno=" & admno & " and RESULTS.CLASS= " & CLS & " and year= " & yr & " and term= " & tr & " and exam=2;", conn)
            'DF2 = New DataSet("DF")
            'cmd2.Fill(DF2)
            DT2 = data.executeSQL("SELECT *," & POS & "," & OUT & " From results where admno=" & admno & " and RESULTS.CLASS= " & CLS & " and year= " & yr & " and term= " & tr & " and exam=2;")
            'DT2 = DF2.Tables(0)
            If DT2.Rows.Count < 1 Then
                BLANK = 3
                Call GTY()
                Call setzero2()
            End If

            For Each CAT2 As DataRow In DT2.Rows
                otable.Cell(2, 3).Range.Text = CAT2(13)
                otable.Cell(3, 3).Range.Text = CAT2(14)
                otable.Cell(4, 3).Range.Text = CAT2(15)
                otable.Cell(5, 3).Range.Text = CAT2(6)
                otable.Cell(7, 3).Range.Text = CAT2(16)
                otable.Cell(8, 3).Range.Text = CAT2(17)
                otable.Cell(9, 3).Range.Text = CAT2(18)
                otable.Cell(10, 3).Range.Text = CAT2(7)
                otable.Cell(12, 3).Range.Text = CAT2(5)
                otable.Cell(13, 3).Range.Text = CAT2(9)
                otable.Cell(14, 3).Range.Text = CAT2(8)
                'otable.Cell(16,  3).Range.Text = ("sci")
                otable.Cell(17, 3).Range.Text = CAT2(20)
                otable.Cell(18, 3).Range.Text = CAT2(23)
                otable.Cell(19, 3).Range.Text = CAT2(21)
                'otable.Cell(20,  3).Range.Text = ("art")
                otable.Cell(21, 3).Range.Text = CAT2(22)
                otable.Cell(23, 3).Range.Text = CAT2(10)
                otable.Cell(24, 3).Range.Text = Format((CAT2(10) / 5), "0.0")
                otable.Cell(25, 3).Range.Text = CAT2(25)
                otable.Cell(26, 3).Range.Text = CAT2(26)
                kk = CAT2(12)
                markj()



                '\\\\
                language2 = CAT2(13)
                reading2 = CAT2(14)
                comp2 = CAT2(15)
                etotal2 = CAT2(6)
                lugha2 = CAT2(16)
                kusoma2 = CAT2(17)
                insha2 = CAT2(18)
                ktotal2 = CAT2(7)
                maths2 = CAT2(5)
                sci2 = CAT2(9)
                social2 = CAT2(8)
                'otable.Cell(16,  3).Range.Text = ("sci")
                '  cre2 = CAT2(20)
                'otable.Cell(18, 3).Range.Text = CAT2(23)
                'otable.Cell(19, 3).Range.Text = CAT2(21)
                ''otable.Cell(20,  3).Range.Text = ("art")
                'otable.Cell(21, 3).Range.Text = CAT2(22)
                total2 = CAT2(10)
                'otable.Cell(24, 3).Range.Text = Format((CAT2(10) / 5), "0.0")
                'otable.Cell(25, 3).Range.Text = CAT2(25)
                'otable.Cell(26, 3).Range.Text = CAT2(26)

                '\\\\\
            Next

        Catch EX As Exception
            MsgBox(EX.Message, , 22)
        End Try
    End Sub
    ''end term
  
    Private Sub cat3()
        'Try
        Dim otable As Word.Table
        otable = oDocs.Tables(2)
        'Dim conn As New OdbcConnection(connstring)
        'Dim cmd3 As New OdbcDataAdapter
        Dim DT3 As System.Data.DataTable
        'Dim DF3 As DataSet
        'conn.Open()
        OUT = "(SELECT count( * ) FROM results where  year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and exam=3)"
        POS = "(SELECT (SELECT count( * ) FROM results b WHERE b.total > a.total  AND TERM=" & tr & " and RESULTS.CLASS= " & CLS & "  AND YEAR= " & yr & " AND EXAM=3 ) +1 AS Rank FROM results a WHERE ADMNO =" & admno & " and RESULTS.CLASS= " & CLS & " AND TERM=" & tr & "  AND YEAR= " & yr & " AND EXAM=3 ORDER BY rank )"
        'cmd3.SelectCommand = New OdbcCommand("SELECT *," & POS & "," & OUT & " From results where admno=" & admno & " and RESULTS.CLASS= " & CLS & " and year= " & yr & " and term= " & tr & " and exam=3;", conn)
        'DF3 = New DataSet("DF")
        'cmd3.Fill(DF3)
        'DT3 = DF3.Tables(0)
        DT3 = data.executeSQL("SELECT *," & POS & "," & OUT & " From results where admno=" & admno & " and RESULTS.CLASS= " & CLS & " and year= " & yr & " and term= " & tr & " and exam=3;")
        If DT3.Rows.Count < 1 Then
            BLANK = 4
            Call GTY()
            Call setzero3()

        End If
        For Each CAT3 As DataRow In DT3.Rows
            otable.Cell(2, 4).Range.Text = CAT3(13)
            otable.Cell(3, 4).Range.Text = CAT3(14)
            otable.Cell(4, 4).Range.Text = CAT3(15)
            otable.Cell(5, 4).Range.Text = CAT3(6)
            otable.Cell(7, 4).Range.Text = CAT3(16)
            otable.Cell(8, 4).Range.Text = CAT3(17)
            otable.Cell(9, 4).Range.Text = CAT3(18)
            otable.Cell(10, 4).Range.Text = CAT3(7)
            otable.Cell(12, 4).Range.Text = CAT3(5)
            otable.Cell(13, 4).Range.Text = CAT3(9)
            otable.Cell(14, 4).Range.Text = CAT3(8)
            'otable.Cell(16,  3).Range.Text = ("sci")
            otable.Cell(17, 4).Range.Text = CAT3(20)
            otable.Cell(18, 4).Range.Text = CAT3(23)
            otable.Cell(19, 4).Range.Text = CAT3(21)
            'otable.Cell(20,  3).Range.Text = ("art")
            otable.Cell(21, 4).Range.Text = CAT3(22)
            otable.Cell(23, 4).Range.Text = CAT3(10)
            otable.Cell(24, 4).Range.Text = Format((CAT3(10) / 5), "0.0")
            otable.Cell(25, 4).Range.Text = CAT3(25)
            otable.Cell(26, 4).Range.Text = CAT3(26)
            kk = CAT3(12)
            markj()
            '\\\\
            language3 = CAT3(13)
            reading3 = CAT3(14)
            comp3 = CAT3(15)
            etotal3 = CAT3(6)
            lugha3 = CAT3(16)
            kusoma3 = CAT3(17)
            insha3 = CAT3(18)
            ktotal3 = CAT3(7)
            maths3 = CAT3(5)
            sci3 = CAT3(9)
            social3 = CAT3(8)
            'otable.Cell(16,  3).Range.Text = ("sci")
            ' cre3 = CAT3(30)
            'otable.Cell(18, 3).Range.Text = CAT3(33)
            'otable.Cell(19, 3).Range.Text = CAT3(31)
            ''otable.Cell(30,  3).Range.Text = ("art")
            'otable.Cell(31, 3).Range.Text = CAT3(33)
            total3 = CAT3(10)
            'otable.Cell(24, 3).Range.Text = Format((CAT2(10) / 5), "0.0")
            'otable.Cell(25, 3).Range.Text = CAT2(25)
            'otable.Cell(26, 3).Range.Text = CAT2(26)

        Next
        ' Catch EX As Exception
        '  MsgBox(EX.Message, , 333)
        'End Try
    End Sub
    Private Sub GTY()
        Dim otable As Word.Table
        otable = oDocs.Tables(2)
        otable.Cell(2, BLANK).Range.Text = " _"
        otable.Cell(3, BLANK).Range.Text = " _"
        otable.Cell(4, BLANK).Range.Text = " _"
        otable.Cell(5, BLANK).Range.Text = " _"
        otable.Cell(7, BLANK).Range.Text = " _"
        otable.Cell(8, BLANK).Range.Text = " _"
        otable.Cell(9, BLANK).Range.Text = " _"
        otable.Cell(10, BLANK).Range.Text = " _"
        otable.Cell(12, BLANK).Range.Text = " _"
        otable.Cell(13, BLANK).Range.Text = " _"
        otable.Cell(14, BLANK).Range.Text = " _"
        'otable.Cell(16, BLANK).Range.Text = ("sci")
        otable.Cell(17, BLANK).Range.Text = " _"
        otable.Cell(18, BLANK).Range.Text = " _"
        otable.Cell(19, BLANK).Range.Text = " _"
        'otable.Cell(20, BLANK).Range.Text = ("art")
        otable.Cell(21, BLANK).Range.Text = " _"
        otable.Cell(23, BLANK).Range.Text = " _"
        otable.Cell(24, BLANK).Range.Text = " _"
        otable.Cell(25, BLANK).Range.Text = " _"
        otable.Cell(26, BLANK).Range.Text = " _"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub grade()
        If mark > 69 Then
            grad = "Very good"
        ElseIf mark > 49 And mark <= 69 Then
            grad = "Good"
        ElseIf mark > 29 And mark <= 69 Then
            grad = "Emerging"
        ElseIf mark <= 29 Then
            grad = "Not yet"
        End If
       
    End Sub
    Private Sub report_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add(Format(Now, "yyyy") - 2)
            .Add(Format(Now, "yyyy") - 1)
            .Add(Format(Now, "yyyy"))
            .Add(Format(Now, "yyyy") + 1)
            .Add(Format(Now, "yyyy") + 2)
        End With
        ComboBox1.SelectedIndex = 3
        With ComboBox2.Items
            For b = 1 To 3
                .Add(b)
            Next
        End With
        ComboBox2.SelectedIndex = 0
        On Error Resume Next
        Dim rd As System.Data.DataTable
        rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`")
        For Each drow In rd.Rows
            ComboBox3.Items.Add(drow.Item(1).ToString.ToUpper)
            class_id.Add(drow.Item(0).ToString.ToUpper)
        Next

        ComboBox3.SelectedIndex = 0
    End Sub



    Private Sub markj()
        'Dim conn As New OdbcConnection(connstring)
        Dim sqk As String
        sqk = "update results set position=0 where examno =" & kk
        '  MsgBox(sqk)
        data.add1(sqk)
        'Try
        '    Dim md As New OdbcCommand(sqk, conn)
        '    conn.Open()
        '    'md.Connection = conn
        '    Dim reader As OdbcDataReader = md.ExecuteReader
        '    conn.Close()
        'Catch V As Exception
        '    MsgBox(V.Message, , 44)
        'End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '   MsgBox(System.AppDomain.CurrentDomain.BaseDirectory.ToString())
        yr = 0
        tr = 0
        CLS = 0
        STBB = 0
        STB = 0
        ProgressBar1.Value = 0
        Label7.Text = ""
        Me.Cursor = Cursors.WaitCursor
        ' Try

        'otable = oDocs.Tables.Add(oDocs.Bookmarks.Item("\endofdoc").Range, rowsTotal + 1, colsTotal)
        yr = ComboBox1.Text
        tr = ComboBox2.Text
        CLS = class_id(ComboBox3.SelectedIndex)
        'C:\Users\sam\Documents\Visual Studio 2012\Projects\school"
        Dim oWord = New Word.Application With {.Visible = True}

        oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() & "KIDS ZONE.dotx", , False)
        oDocs.SelectAllEditableRanges()
        Dim rng As Word.Range
        'Dim sel As Word.Selection
        rng = oDocs.Range(oDocs.Paragraphs(1).Range.Start, oDocs.Tables(4).Range.End)

        rng.Copy()

        'Dim conn As New OdbcConnection(connstring)
        'Dim cn As New OdbcCommand
        'Dim cmd As New OdbcDataAdapter
        Dim DT As System.Data.DataTable
        'Dim DF As DataSet
        ' Dim YR As String = 2012
        'conn.Open()
        'cmd.SelectCommand = New OdbcCommand("SELECT results.admno,students.name,students.stream,students.class FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno", conn)
        'DF = New DataSet("DF")
        'cmd.Fill(DF)
        'DT = DF.Tables(0)
        DT = data.executeSQL("SELECT results.admno,students.` names`,students.`str_code`,students.`class_code` FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno")
        'DT = data.executeSQL("SELECT results.admno,students.name,students.stream,students.class FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno")
        Dim otable3 As Word.Table
        otable3 = oDocs.Tables(3)
        otable3.Cell(1, 1).Range.Text = otable3.Cell(1, 1).Range.Text & "  " & TextBox1.Text
        ' otable3.Cell(1, 1).Range.Text = "GENERAL COMMENTS  " & TextBox1.Text
        otable3.Cell(1, 1).Range.Underline = WdUnderline.wdUnderlineNone
        otable3.Cell(1, 1).Range.Font.Size = 12
        Dim otable2 As Word.Table
        otable2 = oDocs.Tables(4)
        otable2.Cell(1, 1).Range.Text = DateTimePicker2.Value.ToShortDateString

        STB = DT.Rows.Count
        STBB = 1
        'For nm = 1 To STB - 1
        '    oWord.Selection.Paste()
        'Next
        For Each drow1 As DataRow In DT.Rows

            otable = oDocs.Tables(1)
            otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " & drow1(1)
            otable.Cell(1, 2).Range.Text = "  ADMNO : " & drow1(0)
            otable.Cell(3, 3).Range.Text = "CLASS  " & drow1(3) & "  " & drow1(2)
            otable.Cell(3, 2).Range.Text = "TERM " & tr & "  Year " & yr
            otable.Cell(3, 1).Range.Text = "DATE  " & DateTimePicker1.Value.ToShortDateString
            admno = drow1(0)
            cat()
            cat2()
            cat3()
            sum()

            'MsgBox("HHH")
            '        oDocs.PrintOut(False)
            Label7.Text = STBB & " of " & STB
            ProgressBar1.Value = (STBB / STB * 100)
            STBB = STBB + 1
            'oDocs.
            'MsgBox("")
            oDocs.SaveAs(lala & "/" & drow1(1) & " term  " & tr & " year " & yr & ".doc")

        Next

        oDocs.Close(SaveChanges:=False)
        oDocs = Nothing
        oWord.Quit()
        oWord = Nothing
        'conn.Close()
        MsgBox("PRINT COMPLETED ", MsgBoxStyle.Information, "")
        'Catch d As Exception
        'MsgBox(d.Message & vbTab & "SOME DOCUMENTS MIGHT NOT HAVE PROCESED")
        'End Try
        Me.Cursor = Cursors.Default
        yr = 0
        tr = 0
        CLS = 0
        STBB = 0
        STB = 0
        ProgressBar1.Value = 0
        Label7.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'SaveFileDialog1.ShowDialog()
        'Dim blah As String = SaveFileDialog1.FileName("kush.doc")

        ''SaveFileDialog1.FileName = "backup"
        ''SaveFileDialog1.DefaultExt = ".doc"

        'Dim meh As Integer = blah.LastIndexOf("\")
        'lala = blah.Substring(0, meh)
        'Dim path As String = lala
        'TextBox2.Text = lala
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
    Private Sub sum()
        Dim otable As Word.Table
        otable = oDocs.Tables(2)
        Dim language, reading, comp, etotal, lugha, kusoma, insha, ktotal, maths, sci, social, cre, total As Integer
        language = Format((language1 + language2 + language3) / 3, "0.0")
        mark = language
        grade()
        otable.Cell(2, 5).Range.Text = language
        'otable.Cell(2, 6).Range.Text = grad
        mark = 0

        reading = Format((reading1 + reading2 + reading3) / 3, "0.0")
        mark = reading
        grade()
        otable.Cell(3, 5).Range.Text = mark
        'otable.Cell(3, 6).Range.Text = grad
        mark = 0
        comp = Format((comp1 + comp2 + comp3) / 3, "0.0")
        mark = comp
        grade()
        otable.Cell(4, 5).Range.Text = mark
        'otable.Cell(4, 6).Range.Text = grad
        mark = 0
        etotal = Format((etotal1 + etotal2 + etotal3) / 3, "0.0")
        mark = etotal
        grade()
        otable.Cell(5, 5).Range.Text = mark
        otable.Cell(5, 6).Range.Text = grad
        mark = 0
        lugha = Format((lugha1 + lugha2 + lugha3) / 3, "0.0")
        mark = lugha
        grade()
        otable.Cell(7, 5).Range.Text = mark
        'otable.Cell(7, 6).Range.Text = grad
        mark = 0
        kusoma = Format((kusoma1 + kusoma2 + kusoma3) / 3, "0.0")
        mark = kusoma
        grade()
        otable.Cell(8, 5).Range.Text = mark
        'otable.Cell(8, 6).Range.Text = grad
        mark = 0
        insha = Format((insha1 + insha2 + insha3) / 3, "0.0")
        mark = insha
        grade()
        otable.Cell(9, 5).Range.Text = mark
        'otable.Cell(9, 6).Range.Text = grad
        mark = 0
        ktotal = Format((ktotal1 + ktotal2 + ktotal3) / 3, "0.0")
        mark = ktotal
        grade()
        otable.Cell(10, 5).Range.Text = mark
        otable.Cell(10, 6).Range.Text = grad
        mark = 0
        maths = Format((maths1 + maths2 + maths3) / 3, "0.0")
        mark = maths
        grade()
        otable.Cell(12, 5).Range.Text = mark
        otable.Cell(12, 6).Range.Text = grad
        mark = 0
        sci = Format((sci1 + sci2 + sci3) / 3, "0.0")
        mark = sci
        grade()
        otable.Cell(13, 5).Range.Text = mark
        otable.Cell(13, 6).Range.Text = grad
        mark = 0
        social = Format((social1 + social2 + social3) / 3, "0.0")
        mark = social
        grade()
        otable.Cell(14, 5).Range.Text = mark
        otable.Cell(14, 6).Range.Text = grad
        'cre = Format((cre1 + cre2 + cre3) / 3, "0.0")
        'mark = cre
        'grade()
        'otable.Cell(15, 5).Range.Text = mark
        'otable.Cell(15, 6).Range.Text = grad
        mark = 0
        total = Format((total1 + total2 + total3) / 3, "0.0")
        mark = (total / 5)
        grade()
        otable.Cell(23, 5).Range.Text = total
        otable.Cell(24, 5).Range.Text = mark
        otable.Cell(24, 6).Range.Text = grad
        mark = 0

    End Sub
    Private Sub setzero3()
        language3 = 0
        reading3 = 0
        comp3 = 0
        etotal3 = 0
        lugha3 = 0
        kusoma3 = 0
        insha3 = 0
        ktotal3 = 0
        maths3 = 0
        sci3 = 0
        social3 = 0
        total3 = 0
    End Sub
    Private Sub setzero2()
        language2 = 0
        reading2 = 0
        comp2 = 0
        etotal2 = 0
        lugha2 = 0
        kusoma2 = 0
        insha2 = 0
        ktotal2 = 0
        maths2 = 0
        sci2 = 0
        social2 = 0
        total2 = 0
    End Sub
    Private Sub setzero1()
        language1 = 0
        reading1 = 0
        comp1 = 0
        etotal1 = 0
        lugha1 = 0
        kusoma1 = 0
        insha1 = 0
        ktotal1 = 0
        maths1 = 0
        sci1 = 0
        social1 = 0
        total1 = 0
    End Sub
End Class