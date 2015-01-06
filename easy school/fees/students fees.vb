Public Class students_fees
    Dim data As New database
    Public ad As String
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub students_fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RED As DataTable
        RED = data.executeSQL("SELECT  `Details`, `method`, `acc_Name`, `acc_No`, `Amount`, `payable`, `Balance`, DATE_FORMAT(  `Datestamp` ,  '%d-%M-%Y' )'Date Paid'  FROM `fees accounting` WHERE  `admno`=" & ad & " ORDER BY  `fees accounting`.`Datestamp` DESC")
        DataGridView1.DataSource = RED
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RED As DataTable
        Dim gg As String
        gg = "SELECT  `Details`, `method`, `acc_Name`, `acc_No`, `Amount`, `payable`, `Balance`, DATE_FORMAT(  `Datestamp` ,  '%d-%M-%Y' )'Date Paid'  FROM `fees accounting` WHERE  `admno`=" & ad & " and `Datestamp` between '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & " 00:00:00' and '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & " 23:59:59' ORDER BY  `fees accounting`.`Datestamp` DESC"
        RED = data.executeSQL(gg)
        DataGridView1.DataSource = RED
    End Sub
End Class