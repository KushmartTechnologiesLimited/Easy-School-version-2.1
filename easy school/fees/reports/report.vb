Public Class report
    Dim data As New database
    Dim red As New DataTable
    Dim class_id As New List(Of String)
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rd As DataTable
        rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`")
        For Each drow In rd.Rows
            ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper)
            class_id.Add(drow.Item(0).ToString.ToUpper)
        Next
        red = data.executeSQL("SELECT `fees_id`'Receipt No',students.Admno'Adm No',` names`, `Details`, `Method`, `acc_Name`, `Acc_no`, `amount`, `payable`, `balance` FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and balance>0 and `fees accounting`.status=0")
        DataGridView1.DataSource = red
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength > 0 Then
            red = data.executeSQL("SELECT  `fees_id`'Receipt No',students.Admno'Adm No', ` names`, `Details`, `Method`, `acc_Name`, `Acc_no`, `amount`, `payable`, `balance` FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and `students`.`admno` regexp '" & TextBox1.Text & "' or `students`.` names` regexp '" & TextBox1.Text & "' limit 50")
            DataGridView1.DataSource = red
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex > -1 Then
            red = data.executeSQL("SELECT  `fees_id`'Receipt No',students.Admno'Adm No', ` names`, `Details`, `Method`, `acc_Name`, `Acc_no`, `amount`, `payable`, `balance` FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and `students`.`class_code` = '" & class_id(ComboBox1.SelectedIndex) & "' and balance>0 and `fees accounting`.status=0")
            DataGridView1.DataSource = red
            Dim red2 As DataTable

            If red.Rows.Count > 0 Then
                Dim gg1 As String = "SELECT sum(`amount`)  FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and `students`.`class_code` = '" & class_id(ComboBox1.SelectedIndex) & "' and balance>0 and `fees accounting`.status=0"
                red2 = data.executeSQL(gg1)
                Label6.Text = red2.Rows(0).Item(0).ToString
            Else
                Label6.Text = 0
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gg As String = "SELECT `fees_id`'Receipt No',students.Admno'Adm No',` names`, `Details`, `Method`, `acc_Name`, `Acc_no`, `amount`, `payable`, `balance` FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and DATE_FORMAT(  `Datestamp` ,  '%d-%m-%Y' ) = '" & DateTimePicker1.Value.ToString("dd-MM-yyyy") & "'"
        red = data.executeSQL(gg)
        DataGridView1.DataSource = red
        DataGridView1.Columns(0).Visible = False
        Dim red2 As DataTable

        If red.Rows.Count > 0 Then
            Dim gg1 As String = "SELECT sum(`amount`)  FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and DATE_FORMAT(  `Datestamp` ,  '%d-%m-%Y' ) = '" & DateTimePicker1.Value.ToString("dd-MM-yyyy") & "'"
            red2 = data.executeSQL(gg1)
            Label6.Text = red2.Rows(0).Item(0).ToString
        Else
            Label6.Text = 0
        End If

    End Sub
End Class