Imports System
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Odbc
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.Drawing.Printing

Public Class prints
    Public oDocs As Word.Document
    Public otable As Word.Table
    Public para As Word.Paragraph
    Dim lala As String
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As Font = New Font("Vanada", 10)
        Dim s As Font = New Font("Vanada", 20)
        Dim z As Font = New Font("Vanada", 15)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim p As Pen = New Pen(Color.Black)
        Dim wt As Integer = 350
        Dim ht As Integer = 900
        Dim l As Pen
        l = New Pen(Color.Black, 0.025F)
        'Dim wt1,ht1 As 
        With e.Graphics
            .DrawRectangle(l, 40.0F, 50.5F, wt, ht) ' border of the table
            ' .DrawRectangle(l, 40.0F, 50.5F, wt * 2 / 3, 5)

        End With



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mpt As Bitmap
        mpt = New Bitmap(Me.Width, Me.Height)
        Dim rec As System.Drawing.Rectangle
        rec.Width = Me.Width
        rec.Height = Me.Height
        Me.DrawToBitmap(mpt, rec)
        Dim Prn As PrintDocument
        Prn = New PrintDocument
        Prn.Print()





    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim oWord = New Word.Application With {.Visible = True}
        oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() & "receipt.dotx", , False)
        Dim otable3 As Word.Table
        otable3 = oDocs.Tables(1)
        otable3.Cell(1, 0).Range.Text = "Names : " & "Samuel Kamau Biu"
        otable3.Cell(1, 2).Range.Text = "Adm No: " & "8257"
        otable3.Cell(2, 1).Range.Text = "Class:  " & "one"
        otable3.Cell(2, 2).Range.Text = "Stream: " & "East"
        For index = 4 To 9
            otable3.Cell(index, 1).Range.Text = "Kush"
            otable3.Cell(index, 2).Range.Text = "10000"
        Next
        oDocs.PrintOut(False)
        oDocs.Close(SaveChanges:=False)
        oDocs = Nothing
        oWord.Quit()
        oWord = Nothing
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For i = 1055 To 10000000
            Me.Text = i
            Dim adm As String = i
            Dim ssql, sql As String
            Dim data As New database
            sql = "INSERT INTO `schoolfees`.`students` (`admno`, `regno`, ` names`, `gender`,`DOB`, `adm_date`) VALUES ('" & adm & "', NULL, 'name " & adm & "', ' male ','2014-08-10','2014-08-06 00:00:00');"

            ssql = "INSERT INTO parents (admno ,f_id_no ,id_no)VALUES ('" & adm & "',  '20000000',  '10000000')"
            data.add(sql)
            data.add(ssql)
        Next
    End Sub
End Class