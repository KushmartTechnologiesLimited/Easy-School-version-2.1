Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word

Public Class Form5
    Dim data As New database
    Public connstring As String = "Dsn=school;database=school;option=0;port=3306;server=localhost;uid=school; password=incorrect;"
    Public term, exam, CLSS, Year As String
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub assign()
        Year = ComboBox1.Text
        term = ComboBox2.Text
        CLSS = ComboBox3.Text
        exam = ComboBox4.Text

    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add(Format(Now, "yyyy") - 2)
            .Add(Format(Now, "yyyy") - 1)
            .Add(Format(Now, "yyyy"))
            .Add(Format(Now, "yyyy") + 1)
            .Add(Format(Now, "yyyy") + 2)
        End With
        ComboBox1.SelectedIndex = 2
        With ComboBox2.Items
            For b = 1 To 3
                .Add(b)
            Next
        End With
        ComboBox2.SelectedIndex = 0
        With ComboBox3.Items
            For t = 1 To 8
                .Add(t)
            Next
        End With
        With ComboBox4.Items
            For b = 1 To 3
                .Add(b)
            Next
        End With
        ComboBox4.SelectedIndex = 2
        'Dim mh As New OdbcDataAdapter
        'Dim DS As DataSet
        'Dim DTABLE As System.Data.DataTable
        'Dim I As Integer
        TextBox1.Text = "TERM " & Form2.term & "  EXAM  " & Form2.exam & " OF CLASS  " & Form2.CLSS & "  YEAR " & Form2.year
        Dim led As System.Data.DataTable
        led = data.executeSQL("select admNo,grammer, reading, composition ,eng, lugha, kusoma, insha, kisw,maths,sci,social, cre, total, position'STATUS' from RESULTS WHERE YEAR=" & Form2.year & " AND EXAM=" & Form2.exam & " AND CLASS=" & Form2.CLSS & " AND TERM=" & Form2.term & ";")
        DataGridView1.DataSource = led
        Try

            '    Dim conn As New OdbcConnection(connstring)
            '    Dim cn As New OdbcCommand
            '    Dim v As Integer
            '    If conn.State = ConnectionState.Open Then
            '        conn.Close()
            '    End If
            '    mh.SelectCommand = New OdbcCommand("select admNo,grammer, reading, composition ,eng, lugha, kusoma, insha, kisw,maths,sci,social, cre, total, position'STATUS' from RESULTS WHERE YEAR=" & Form2.year & " AND EXAM=" & Form2.exam & " AND CLASS=" & Form2.CLSS & " AND TERM=" & Form2.term & ";", conn)
            '    DS = New DataSet("STUDENTS")
            '    mh.Fill(DS, "STUDENTS")
            '    DTABLE = DS.Tables(0)
            '    v = DTABLE.Rows.Count
            '    If v < 1 Then
            '        MsgBox("no record found ", , "")
            '        Exit Sub
            '    End If
            'DataGridView1.DataSource = DS.Tables("STUDENTS").DefaultView
            For I = 0 To 14
                DataGridView1.AutoResizeColumn(I)

            Next
            'conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
 
    Private Sub search()
        'Dim mh As New OdbcDataAdapter
        'Dim DS As DataSet
        'Dim DTABLE As System.Data.DataTable
        'Dim I As Integer
        TextBox1.Text = "TERM " & term & "  EXAM  " & exam & " OF CLASS  " & CLSS & "  YEAR " & Year
        Try
            Dim led As System.Data.DataTable
            led = data.executeSQL("select students.name,results.admNo,grammer, reading, composition ,eng, lugha, kusoma, insha, kisw,maths,sci,social, cre, total, position'STATUS' from students, RESULTS WHERE students.admno=results.admno and  YEAR=" & Year & " AND EXAM=" & exam & " AND results.CLASS=" & CLSS & " AND TERM=" & term & " order by total desc;")
            DataGridView1.DataSource = led
            'Dim conn As New OdbcConnection(connstring)
            'Dim cn As New OdbcCommand
            'Dim v As Integer
            'If conn.State = ConnectionState.Open Then
            '    conn.Close()
            'End If
            'mh.SelectCommand = New OdbcCommand("select students.name,results.admNo,grammer, reading, composition ,eng, lugha, kusoma, insha, kisw,maths,sci,social, cre, total, position'STATUS' from students, RESULTS WHERE students.admno=results.admno and  YEAR=" & Year & " AND EXAM=" & exam & " AND results.CLASS=" & CLSS & " AND TERM=" & term & " order by total desc;", conn)
            'DS = New DataSet("STUDENTS")
            'mh.Fill(DS, "STUDENTS")
            'DTABLE = DS.Tables(0)
            'v = DTABLE.Rows.Count
            'If v < 1 Then
            '    MsgBox("no record found ", , "")
            '    DataGridView1.DataSource = DS.Tables("STUDENTS").DefaultView
            '    Exit Sub
            'End If
            'DataGridView1.DataSource = DS.Tables("STUDENTS").DefaultView
            'For I = 0 To 14
            '    DataGridView1.AutoResizeColumn(I)

            'Next
            'conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True
            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                    For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                    Next
                For I = 0 To rowsTotal
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I

                    '.Cells.Columns.AutoFit()
                    '.Cells.Select()
                    ' .Cells.EntireColumn.AutoFit()
                    .Cells(1, 1).Select()
                .SaveAs(TextBox1.Text & "_" & Format(Now, "MMMM ss ") & ".xlsx")
                GC.Collect()
                GC.WaitForFullGCComplete()
                End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' xlApp.(TextBox1.Text & "_" & Format(Now, "MMMM dd ") & ".xlsx")
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            'xlApp.SaveWorkspace("D:\" & TextBox1.Text & ".XLW")
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        assign()
        search()

        
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        assign()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        assign()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        assign()
    End Sub
End Class