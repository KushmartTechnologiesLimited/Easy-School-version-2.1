Public Class edit_students
    Dim data As New studentsdatabase
    Dim class_id, str_id As New List(Of String)
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub edit_students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rd, rd1, red As DataTable
        rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`")
        rd1 = Data.executeSQL("SELECT code, name FROM stream")
        For Each drow In rd.Rows
            ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper)
            class_id.Add(drow.Item(0).ToString.ToUpper)
        Next
        For Each drow In rd1.Rows
            ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper)
            str_id.Add(drow.Item(0).ToString.ToUpper)
        Next
        red = data.executeSQL("SELECT `admno`, ` names`, `gender`,`DOB`, `Birthno`, (SELECT  class.description FROM class WHERE class.code=`class_code`),(SELECT  stream.name FROM stream WHERE stream.code=str_code ) FROM `students` WHERE `admno`=" & TextBox1.Text)
        For Each drow In red.Rows
            TextBox2.Text = drow.Item(1).ToString.ToUpper
            ComboBox3.Text = drow.Item(2).ToString.ToUpper
            DateTimePicker1.Value = drow.Item(3).ToString
            TextBox4.Text = drow.Item(4).ToString.ToUpper
            ComboBox1.Text = drow.Item(5).ToString.ToUpper
            ComboBox2.Text = drow.Item(6).ToString.ToUpper
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sql As String
        sql = "UPDATE `students` SET ` names`='" & TextBox2.Text & "',`gender`='" & ComboBox3.Text & "',`DOB`='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "',`Birthno`='" & TextBox4.Text & "',`class_code`= (SELECT `code`  FROM `class` WHERE `Description`='" & ComboBox1.Text & "'),`str_code`=(SELECT `code` FROM `stream` WHERE `name`='" & ComboBox2.Text & "' ) WHERE `admno`=" & TextBox1.Text
        data.update(sql)
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim val As New validate
        val.digits(sender, e)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub
End Class