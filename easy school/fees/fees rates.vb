Public Class fees_rates
    Dim data As New database
    Dim level, feety As New List(Of String)
    Dim lev, cla, ikk As String
    Private Sub fees_rates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim red As New DataTable
        red = data.executeSQL("SELECT `code`,  `description` FROM `class` ORDER BY `level`")  'subjects
        For Each drow In red.Rows
            ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper)
            level.Add(drow.Item(0).ToString.ToUpper)
        Next
        Dim red1 As New DataTable
        red1 = data.executeSQL("SELECT `ID`, `Type_Name` FROM `type`")  'subjects
        For Each drow In red1.Rows
            ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper)
            feety.Add(drow.Item(0).ToString.ToUpper)
        Next
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            Dim j As Integer
            For Each b As String In level
                data.add("INSERT INTO `rates`( `L_id`, `T_id`, `amount`) VALUES ('" & b & "','" & cla & "'," & TextBox1.Text & ")")
                j = j + 1
            Next
            Dim ggf As DataTable
            ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates")
            DataGridView1.DataSource = ggf
            Dim i, sum As Integer
            Do Until i = DataGridView1.Rows.Count
                sum = sum + DataGridView1.Rows(i).Cells(3).Value
                i = i + 1
            Loop
            Label3.Text = "Total = Ksh " & sum
            Exit Sub
        End If

        'dsfgg
        If ComboBox1.Text = "" Or ComboBox1.SelectedIndex < 0 Then
            MsgBox("data required", MsgBoxStyle.Information, "error")
            ComboBox1.Focus()
            Exit Sub
        Else
            If ComboBox2.Text = "" Or ComboBox2.SelectedIndex < 0 Then
                MsgBox("data required", MsgBoxStyle.Information, "error")
                ComboBox2.Focus()
                Exit Sub
            Else
                If TextBox1.Text = "" Then
                    MsgBox("data required", MsgBoxStyle.Information, "error")
                    TextBox1.Focus()
                    Exit Sub
                Else
                    data.add("INSERT INTO `rates`( `L_id`, `T_id`, `amount`) VALUES ('" & lev & "','" & cla & "'," & TextBox1.Text & ")")
                    Dim ggf As DataTable
                    ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" & lev)
                    DataGridView1.DataSource = ggf
                    Dim i, sum As Integer
                    Do Until i = DataGridView1.Rows.Count
                        sum = sum + DataGridView1.Rows(i).Cells(3).Value
                        i = i + 1
                    Loop
                    Label3.Text = "Total = Ksh " & sum
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        lev = level(ComboBox1.SelectedIndex)
        Dim ggf As DataTable
        ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" & lev)
        DataGridView1.DataSource = ggf
        Dim i, sum As Integer
        Do Until i = DataGridView1.Rows.Count
            sum = sum + DataGridView1.Rows(i).Cells(3).Value
            i = i + 1
        Loop
        Label3.Text = "Total = Ksh " & sum
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        cla = feety(ComboBox2.SelectedIndex)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        Dim i As Integer
        Dim h As String
        If Button3.Text = "Save" Then
            data.add("UPDATE `rates` SET `amount`=" & TextBox1.Text & " WHERE `ID`=" & ikk)
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox1.Text = ""
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            Button3.Text = "&Modify F3"
            Button2.Enabled = True
            lev = level(ComboBox1.SelectedIndex)
            Dim ggf As DataTable
            ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" & lev)
            DataGridView1.DataSource = ggf
            Dim j, sum As Integer
            Do Until j = DataGridView1.Rows.Count
                sum = sum + DataGridView1.Rows(i).Cells(3).Value
                j = j + 1
            Loop
            Label3.Text = "Total = Ksh " & sum
            Exit Sub
        End If
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                h = .Item(0, i).Value
                ikk = h
                ComboBox1.Text = .Item(1, i).Value
                ComboBox2.Text = .Item(2, i).Value
                TextBox1.Text = .Item(3, i).Value
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                Button3.Text = "Save"
                Button2.Enabled = False
            End With
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next
        lev = level(ComboBox1.SelectedIndex)
        Dim ggf As DataTable
        ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" & lev)
        DataGridView1.DataSource = ggf
        Dim i, sum As Integer
        Do Until i = DataGridView1.Rows.Count
            sum = sum + DataGridView1.Rows(i).Cells(3).Value
            i = i + 1
        Loop
        Label3.Text = "Total = Ksh " & sum
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
       
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim val As New validate
        val.digits(sender, e)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer
        Dim h As String
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                h = .Item(0, i).Value
                If MsgBox(" are you sure you want to delete" + vbCrLf + .Item(1, i).Value + " " + .Item(2, i).Value, vbYesNo, "confirm") = vbYes Then
                    data.delete("DELETE FROM `rates` WHERE `ID`=" & h)
                    lev = level(ComboBox1.SelectedIndex)
                    Dim ggf As DataTable
                    ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" & lev)
                    DataGridView1.DataSource = ggf
                End If
            End With
        End If
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ComboBox1.Enabled = False
        Else
            ComboBox1.Enabled = True
        End If
    End Sub
End Class