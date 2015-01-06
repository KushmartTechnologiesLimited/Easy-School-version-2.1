Imports System
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Odbc
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Interop.Word
Public Class collect_fees
    Public oDocs As Word.Document
    Public otable As Word.Table
    Public para As Word.Paragraph
    Dim lala As String
    Dim data As New database
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If sender.checked Then
            GroupBox4.Visible = False
            TextBox15.Text = ""
            TextBox14.Text = ""
        Else
            GroupBox4.Visible = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If sender.checked Then
            GroupBox4.Visible = True
            GroupBox4.Text = "Deposit Slip Details"
            Label15.Text = "Bank Name :"
            Label18.Text = "Transaction No :"
            TextBox15.Text = ""
            TextBox14.Text = ""
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If sender.checked Then
            GroupBox4.Visible = True
            GroupBox4.Text = "Cheque Details"
            Label15.Text = "Bank Name : "
            Label18.Text = "Cheque No :"
            TextBox15.Text = ""
            TextBox14.Text = ""
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If sender.checked Then
            GroupBox4.Visible = True
            GroupBox4.Text = "M-Pesa Details"
            Label15.Text = "Phone No :"
            Label18.Text = "Transaction No :"
            TextBox15.Text = ""
            TextBox14.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox4.Text = TextBox3.Text + TextBox2.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox4.Text = TextBox3.Text + TextBox2.Text
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim val As New validate
        val.digits(sender, e)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.TextLength > 0 Then
            TextBox6.Text = TextBox4.Text - TextBox5.Text
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim red As DataTable
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        red = data.executeSQL("SELECT  ` names` ,(SELECT  class.description FROM class WHERE class.code=`class_code`),(SELECT  stream.name FROM stream WHERE stream.code=str_code ) FROM students WHERE admno='" & TextBox1.Text & "'")
        For Each row As DataRow In red.Rows
            TextBox7.Text = row.Item(0).ToString.ToUpper
            TextBox8.Text = row.Item(1).ToString.ToUpper
            TextBox9.Text = row.Item(2).ToString.ToUpper
        Next
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
        Dim redfee As DataTable
        redfee = data.executeSQL("SELECT  `Amount`, `payable`, `Balance` FROM `fees accounting` WHERE `admno`='" & TextBox1.Text & "' and `Status`=0")
        If redfee.Rows.Count > 0 Then
            Panel5.Enabled = True
            TextBox1.ReadOnly = True
        End If

        For Each row As DataRow In redfee.Rows
            TextBox2.Text = row.Item(1).ToString.ToUpper
            TextBox3.Text = row.Item(0).ToString.ToUpper
            TextBox4.Text = row.Item(2).ToString.ToUpper
            TextBox6.Text = row.Item(2).ToString.ToUpper
        Next

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox5.Text = "" Then
            MsgBox("enter some value please", MsgBoxStyle.Information, "")
            TextBox5.Focus()
            Exit Sub
        End If
        If TextBox4.Text = TextBox6.Text Then
            MsgBox("You have not paid any amount", MsgBoxStyle.Information, "")
            TextBox5.Focus()
            Exit Sub
        End If
        Dim admn1, method As String
        admn1 = TextBox1.Text
        If RadioButton1.Checked Then
            method = "cash"
        ElseIf RadioButton2.Checked Then
            method = "bank slip"
        ElseIf RadioButton3.Checked Then
            method = "cheque"
        ElseIf RadioButton4.Checked Then
            method = "m pesa"
        End If
        Dim nn As String
        nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" & admn1 & "', 'Cash Collection','" & method & "', '" & TextBox15.Text & "', '" & TextBox14.Text & "', '', '" & TextBox5.Text & "', '" & TextBox4.Text & "', '" & TextBox6.Text & "', '0', CURRENT_TIMESTAMP);"
        data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" & admn1 & "'")
        data.add(nn)
        Dim oWord = New Word.Application With {.Visible = False}
        oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() & "receipt.dotx", , False)
        Dim otable3 As Word.Table
        otable3 = oDocs.Tables(1)
        otable3.Cell(1, 0).Range.Text = "Names : " & TextBox7.Text
        otable3.Cell(1, 2).Range.Text = "Adm No: " & TextBox1.Text
        otable3.Cell(2, 1).Range.Text = "Class:  " & TextBox8.Text
        otable3.Cell(2, 2).Range.Text = "Stream: " & TextBox9.Text
        Dim ress As DataTable
        ress = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly' ) and `L_id`=(SELECT `level` FROM `class` WHERE `Description`='" & TextBox8.Text & "')")
        Dim lim As Integer
        lim = ress.Rows.Count
        Dim index As Integer = 4
        Dim sum As Integer = 0
        For Each row As DataRow In ress.Rows
            otable3.Cell(index, 1).Range.Text = row.Item(0).ToString.ToUpper
            otable3.Cell(index, 2).Range.Text = row.Item(1).ToString.ToUpper
            sum = sum + (row.Item(1))
            index = index + 1
        Next
        Dim ids As DataTable = data.executeSQL("SELECT max(`fees_id`) FROM `fees accounting` ")
        otable3.Cell(11, 2).Range.Text = sum
        otable3.Cell(12, 2).Range.Text = TextBox4.Text
        otable3.Cell(13, 2).Range.Text = TextBox5.Text
        otable3.Cell(14, 2).Range.Text = TextBox6.Text
        otable3.Cell(15, 1).Range.Text = "Served By:  " & "Admin"
        otable3.Cell(15, 2).Range.Text = "Receipt No: " & ids.Rows.Item(0).Item(0)
        otable3.Cell(15, 3).Range.Text = "Date  " & DateTimePicker1.Value.ToString
        oDocs.PrintOut(False)
        oDocs.Close(SaveChanges:=False)
        oDocs = Nothing
        oWord.Quit()
        oWord = Nothing
        Panel5.Enabled = False
        TextBox1.ReadOnly = False
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        On Error Resume Next
        If TextBox5.TextLength > 0 Then
            TextBox6.Text = TextBox4.Text - TextBox5.Text
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sts As New students_fees
        sts.Size = Me.Size
        sts.Label2.Text = TextBox7.Text
        sts.ad = TextBox1.Text
        sts.ShowDialog()
    End Sub

    Private Sub collect_fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.PerformClick()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oWord = New Word.Application With {.Visible = False}
        oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() & "receipt.dotx", , False)
        Dim otable3 As Word.Table
        otable3 = oDocs.Tables(1)
        otable3.Cell(1, 0).Range.Text = "Names : " & TextBox7.Text
        otable3.Cell(1, 2).Range.Text = "Adm No: " & TextBox1.Text
        otable3.Cell(2, 1).Range.Text = "Class:  " & TextBox8.Text
        otable3.Cell(2, 2).Range.Text = "Stream: " & TextBox9.Text
        Dim ress As DataTable
        ress = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly' ) and `L_id`=(SELECT `level` FROM `class` WHERE `Description`='" & TextBox8.Text & "')")
        Dim lim As Integer
        lim = ress.Rows.Count
        Dim index As Integer = 4
        Dim sum As Integer = 0
        For Each row As DataRow In ress.Rows
            otable3.Cell(index, 1).Range.Text = row.Item(0).ToString.ToUpper
            otable3.Cell(index, 2).Range.Text = row.Item(1).ToString.ToUpper
            sum = sum + (row.Item(1))
            index = index + 1
        Next

        otable3.Cell(11, 2).Range.Text = sum
        otable3.Cell(12, 2).Range.Text = TextBox4.Text
        otable3.Cell(13, 2).Range.Text = 0
        otable3.Cell(14, 2).Range.Text = TextBox6.Text
        otable3.Cell(15, 1).Range.Text = "Served By:  " & "Admin"
        otable3.Cell(15, 2).Range.Text = "Invoice No: " & "#"
        otable3.Cell(15, 3).Range.Text = "Date  " & DateTimePicker1.Value.ToString
        oDocs.PrintOut(False)
        oDocs.Close(SaveChanges:=False)
        oDocs = Nothing
        oWord.Quit()
        oWord = Nothing
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim val As New validate
        val.digits(sender, e)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox5.Text = "" Then
            MsgBox("enter some value please", MsgBoxStyle.Information, "")
            TextBox5.Focus()
            Exit Sub
        End If
        If TextBox4.Text = TextBox6.Text Then
            MsgBox("You have not paid any amount", MsgBoxStyle.Information, "")
            TextBox5.Focus()
            Exit Sub
        End If
        Dim admn1, method As String
        admn1 = TextBox1.Text
        If RadioButton1.Checked Then
            method = "cash"
        ElseIf RadioButton2.Checked Then
            method = "bank slip"
        ElseIf RadioButton3.Checked Then
            method = "cheque"
        ElseIf RadioButton4.Checked Then
            method = "m pesa"
        End If
        Dim nn As String
        nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" & admn1 & "', 'Cash Collection','" & method & "', '" & TextBox15.Text & "', '" & TextBox14.Text & "', '', '" & TextBox5.Text & "', '" & TextBox4.Text & "', '" & TextBox6.Text & "', '0', CURRENT_TIMESTAMP);"
        data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" & admn1 & "'")
        data.add(nn)
        Panel5.Enabled = False
        TextBox1.ReadOnly = False
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
    End Sub
End Class