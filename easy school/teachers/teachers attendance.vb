Public Class teachers_attendance
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j, i As Integer
        j = DataGridView1.RowCount
        If j < 0 Then
            Exit Sub
        End If
        For i = 0 To j - 1
            DataGridView1.Rows(i).Cells("status").Value = True
            DataGridView1.Rows(i).Cells("status1").Value = True
        Next
    End Sub

    Private Sub teachers_attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = DateTimePicker1.Value.ToString("dddd dd MM yyyy")
        Dim data As New database
        Dim red As DataTable
        red = data.executeSQL("SELECT `name`,`national_id` FROM `teachers` ")
        DataGridView1.DataSource = red
        Dim addcolumn, addcolumn1 As New DataGridViewCheckBoxColumn
        Dim reson As New DataGridViewComboBoxColumn
        With addcolumn
            .HeaderText = "Morning"
            .Name = "status"
            .Width = 20
            .ReadOnly = False
        End With
        With addcolumn1
            .HeaderText = "Afternoon"
            .Name = "status1"
            .Width = 20
            .ReadOnly = False
        End With
        With reson
            .HeaderText = "reason"
            .Name = "reason"
            .Width = 40
            .Items.Add("")
            .Items.Add("permissioned")
            .Items.Add("not permissioned")
            .Items.Add("sick")
        End With
        DataGridView1.Columns.Insert(2, addcolumn)
        DataGridView1.Columns.Insert(3, addcolumn1)
        DataGridView1.Columns.Insert(4, reson)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim j, i As Integer
        j = DataGridView1.RowCount
        If j < 0 Then
            Exit Sub
        End If
        For i = 0 To j - 1
            DataGridView1.Rows(i).Cells("status").Value = False
            DataGridView1.Rows(i).Cells("status1").Value = False
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim data As New database
        Dim j, i As Integer
        Dim id, stats, stats1, reason, sql, sql1 As String
        Dim atdate As String
        j = DataGridView1.RowCount
        If j < 0 Then
            Exit Sub
        End If
        sql = "INSERT INTO `tr_attendance`(`id_no`, `tr_date`, `morning`, `afternoon`, `reason`) VALUES "
        For i = 0 To j - 1
            id = DataGridView1.Rows(i).Cells("national_id").Value
            If DataGridView1.Rows(i).Cells("status").Value = True Then
                stats = 1
            Else
                stats = 0
            End If
            If DataGridView1.Rows(i).Cells("status1").Value = True Then
                stats1 = 1
            Else
                stats1 = 0
            End If
            reason = DataGridView1.Rows(i).Cells("reason").Value
            If i < j Then
                If i > 0 Then
                    sql1 = sql1 + " ,"
                End If
            End If
            atdate = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            sql1 = sql1 + " ('" & id & "','" & atdate & "','" & stats & "','" & stats1 & "','" & reason & "')"
        Next
        data.add(sql + sql1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim latestdate As DateTime = DateTimePicker1.Value
        Dim nextdate As DateTime
        nextdate = latestdate.AddDays(1)
        DateTimePicker1.Value = nextdate
        Label2.Text = DateTimePicker1.Value.ToString("dddd  dd/MM/yyyy")
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label2.Text = DateTimePicker1.Value.ToString("dddd dd MM yyyy")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim latestdate As DateTime = DateTimePicker1.Value
        Dim nextdate As DateTime
        nextdate = latestdate.AddDays(-1)
        DateTimePicker1.Value = nextdate
        Label2.Text = DateTimePicker1.Value.ToString("dddd  dd/MM/yyyy")
    End Sub
End Class