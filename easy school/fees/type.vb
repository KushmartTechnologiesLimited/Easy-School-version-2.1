Public Class type
    Dim data As New database
    Private Sub type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ref As New DataTable
        ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ")
        DataGridView1.DataSource = ref
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MsgBox("data required  ", MsgBoxStyle.Information, "error")
            Exit Sub
        Else
            data.add("INSERT INTO `type`(`Type_Name`, `category`) VALUES ('" & TextBox2.Text & "','" & ComboBox1.Text & "')")
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
            Dim ref As New DataTable
            ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ")
            DataGridView1.DataSource = ref
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        Dim h As String
        If Button3.Text = "save" Then
            data.add("UPDATE `type` SET `Type_Name`='" & TextBox2.Text & "',`category`='" & ComboBox1.Text & "'  WHERE  `ID`=" & TextBox1.Text)
            Button3.Text = "&Modify"
            Button2.Enabled = True
            TextBox1.Text = ""
            TextBox2.Text = ""
            Dim ref As New DataTable
            ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ")
            DataGridView1.DataSource = ref
            Exit Sub
        End If
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                h = .Item(0, i).Value
                TextBox1.Text = h
                TextBox2.Text = .Item(1, i).Value
                ComboBox1.Text = .Item(2, i).Value
                Button3.Text = "save"
                Button2.Enabled = False
            End With
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer
        Dim h As String
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                h = .Item(0, i).Value
                If MsgBox(" are you sure you want to delete" + vbCrLf + .Item(1, i).Value, vbYesNo, "confirm") = vbYes Then
                    data.delete("DELETE FROM `type` WHERE `ID`=" & h)
                    Dim ref As New DataTable
                    ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ")
                    DataGridView1.DataSource = ref
                End If
            End With
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ref As New DataTable
        ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ")
        DataGridView1.DataSource = ref
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim val As New validate
        val.alphas(sender.text)
    End Sub
End Class