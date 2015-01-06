Public Class classes
    Dim data As New database
    Dim red, red1, red3 As DataTable
    Private Sub classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view_all.Close()
        red = data.executeSQL("SELECT `code`, `level`, `Description` FROM `class` ORDER BY `level`")
        DataGridView2.DataSource = red
        red1 = data.executeSQL("SELECT `code`, `name`, `strm_ids` FROM `stream`")
        DataGridView1.DataSource = red1
        red3 = data.executeSQL("SELECT `code`,`name`  FROM `subject` ORDER BY `code`")
        DataGridView3.DataSource = red3
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data requied", MsgBoxStyle.Information, "error")
            Exit Sub
        Else
            data.add("INSERT INTO `class`(`level`, `Description`) VALUES ('" & TextBox3.Text & "','" & TextBox4.Text & "')")
            red = data.executeSQL("SELECT `code`, `level`, `Description` FROM `class` ORDER BY `level`")
            clear()
            DataGridView2.DataSource = red
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim val As New validate
        val.digits(sender, e)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress

    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            MsgBox("Data requied", MsgBoxStyle.Information, "error")
            Exit Sub
        Else
            data.add("INSERT INTO `stream`( `name`) VALUES ('" & TextBox2.Text & "')")
            red1 = data.executeSQL("SELECT `code`, `name`, `strm_ids` FROM `stream`")
            clear()
            DataGridView1.DataSource = red1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data requied", MsgBoxStyle.Information, "error")
            Exit Sub
        Else
            data.add("INSERT INTO `schoolfees`.`subject` (`code`, `name`, `description`, `id`, `type_id`) VALUES ('" & TextBox5.Text & "', '" & TextBox6.Text & "', NULL, NULL, '1');")
            'data.add("INSERT INTO `class`(`level`, `Description`) VALUES ('" & TextBox5.Text & "','" & TextBox6.Text & "')")
            red3 = data.executeSQL("SELECT `code`,`name`  FROM `subject` ORDER BY `code`")
            clear()
            DataGridView3.DataSource = red3
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        Dim ittem As String
        If DataGridView2.RowCount > 0 Then
            i = DataGridView2.CurrentRow.Index
            With DataGridView2
                ittem = DataGridView2.Item(0, i).Value
            End With


            If (MsgBox("are you sure you want to delete this record ", MsgBoxStyle.YesNo, "confirm") = MsgBoxResult.Yes) Then
                Dim FF As String
                FF = "DELETE FROM `class` WHERE `code`=" & ittem
                data.delete(FF)
            End If
            red = data.executeSQL("SELECT `code`, `level`, `Description` FROM `class` ORDER BY `level`")
            DataGridView2.DataSource = red
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer
        Dim ittem As String
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                ittem = DataGridView1.Item(0, i).Value
            End With

            If (MsgBox("are you sure you want to delete this record ", MsgBoxStyle.YesNo, "confirm") = MsgBoxResult.Yes) Then
                Dim FF As String
                FF = "DELETE FROM `stream` WHERE `code`=" & ittem
                data.delete(FF)
            End If
            red1 = data.executeSQL("SELECT `code`, `name`, `strm_ids` FROM `stream`")
            DataGridView1.DataSource = red1
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer
        Dim ittem As String
        If DataGridView3.RowCount > 0 Then
            i = DataGridView3.CurrentRow.Index
            With DataGridView3
                ittem = DataGridView3.Item(0, i).Value
            End With
            If (MsgBox("are you sure you want to delete this record ", MsgBoxStyle.YesNo, "confirm") = MsgBoxResult.Yes) Then
                Dim FF As String
                FF = "DELETE FROM `subject` WHERE `code`=" & ittem
                data.delete(FF)
            End If
            red3 = data.executeSQL("SELECT `code`,`name`  FROM `subject` ORDER BY `code`")
            DataGridView3.DataSource = red3
        End If

    End Sub
End Class