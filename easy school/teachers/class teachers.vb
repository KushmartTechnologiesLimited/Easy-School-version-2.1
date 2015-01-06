Public Class class_teachers
    Dim data As New database
    Dim ids As String
    Dim class_id, str_id As New List(Of String)
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListBox1.Items.Clear()
        Dim searchsql As String
        If TextBox1.TextLength > 0 Then
            searchsql = "SELECT  `name` FROM `teachers` where `name` regexp  '" & TextBox1.Text & "' or `national_id` regexp '" & TextBox1.Text & "'"
            data.poplist(ListBox1, searchsql)
        End If
    End Sub
    Private Sub filldata()
        ids = ""
        Try
            Dim cc As String
            Dim red As DataTable
            cc = "SELECT  `name`, `qualification`, `institution`,`national_id` FROM `teachers` WHERE `name`='" & ListBox1.SelectedItem.ToString & "'"
            red = data.executeSQL(cc)
            For Each drow In red.Rows
                TextBox4.Text = drow.Item(0).ToString.ToUpper
                TextBox8.Text = drow.Item(1).ToString.ToUpper
                TextBox3.Text = drow.Item(2).ToString.ToUpper
                ids = drow.Item(3).ToString.ToUpper
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        filldata()
    End Sub

    Private Sub class_teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'data.populateDDList(ComboBox1, "SELECT  `level` FROM `class` ")
        'data.populateDDList(ComboBox2, "SELECT  `name` FROM `stream`")
        Dim led As DataTable
        led = data.executeSQL("SELECT `code`, `name` FROM `subject` WHERE 1 ")
        DataGridView1.DataSource = led
        DataGridView1.Columns(0).Visible = False
        Dim nn As String
        nn = "SELECT  `name` FROM `teachers` "
        data.poplist(ListBox1, nn)
        ' data.poplist(ListBox2, "SELECT `name` FROM `subject` ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim ssql, ss As String
        ssql = "INSERT INTO `schoolfees`.`desinate` (`d_no`, `tr_id_no`, `sub_code`, `class_code`, `str_code`, `updatetime`)   VALUES (NULL, '" & ids & "', '" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString & "', '" & class_id(ComboBox1.SelectedIndex) & "', '" & str_id(ComboBox2.SelectedIndex) & "', CURRENT_TIMESTAMP);"
        ss = "UPDATE `desinate` SET `tr_id_no`='" & ids & "' where `sub_code`='" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString & "' and `class_code`='" & class_id(ComboBox1.SelectedIndex) & "' and `str_code`='" & str_id(ComboBox2.SelectedIndex) & "'"
        data.dd(ssql, ss)
        goo()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        goo()
    End Sub
    Public Sub goo()
        Dim sql As String
        Try
            sql = "SELECT `d_no`, (SELECT `name` FROM `teachers` WHERE `national_id`=`tr_id_no`)'Teacher',(SELECT  `name` FROM `subject` WHERE  code=`sub_code`)'subject'  FROM `desinate` where `class_code`='" & class_id(ComboBox1.SelectedIndex) & "' and `str_code`='" & str_id(ComboBox2.SelectedIndex) & "'"
            Dim redd As DataTable
            redd = data.executeSQL(sql)
            DataGridView2.DataSource = redd
            DataGridView2.Columns.Item(0).Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        goo()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim h As String
        If DataGridView2.RowCount > 0 Then
            i = DataGridView2.CurrentRow.Index
            With DataGridView2
                h = .Item(0, i).Value
                If MsgBox("are you sure you want to delete the record", MsgBoxStyle.YesNo, "confirm") = MsgBoxResult.Yes Then
                    Try
                        Dim data As New studentsdatabase
                        data.delete("DELETE FROM `desinate` WHERE  `d_no`=" & h)
                        goo()
                    Catch ex As Exception
                    End Try
                End If
            End With
        End If
    End Sub

End Class