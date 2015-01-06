Public Class billing
    Dim data As New database
    Dim cls As New List(Of String)

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Text = "Fees Strucure for  " & ComboBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("select a class", MsgBoxStyle.Information, "error")
            ComboBox1.Focus()
            Exit Sub
        End If
        Dim lev As String
        lev = cls(ComboBox1.SelectedIndex)
        Dim o As Integer
        Dim sum As Integer
        Dim red As DataTable
        red = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly' ) and `L_id`='" & lev & "'")
        DataGridView1.DataSource = red
        Do Until o = red.Rows.Count
            sum = sum + red.Rows(o).Item(1).ToString()
            o = o + 1
        Loop
        TextBox8.Text = sum
        Dim oo As Integer
        Dim sumo As Integer
        Dim redo As DataTable
        redo = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' ) and `L_id`='" & lev & "'")
        DataGridView2.DataSource = redo
        Do Until oo = redo.Rows.Count
            sumo = sumo + redo.Rows(oo).Item(1).ToString()
            oo = oo + 1
        Loop
        TextBox1.Text = sumo
        Dim ooo As Integer
        Dim sumoo As Integer
        Dim redoo As DataTable
        redoo = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" & lev & "'")
        DataGridView3.DataSource = redoo
        Do Until ooo = redoo.Rows.Count
            sumoo = sumoo + redoo.Rows(ooo).Item(1).ToString()
            ooo = ooo + 1
        Loop
        TextBox2.Text = sumoo

        Dim i As Integer
        Dim sm As Integer
        Dim rd As DataTable
        rd = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='registration') and `L_id`='" & lev & "'")
        Do Until i = rd.Rows.Count
            sm = sm + rd.Rows(i).Item(1).ToString()
            i = i + 1
        Loop
        TextBox5.Text = sm
        TextBox4.Text = sum + sumo + sumoo
    End Sub

    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ff As DataTable
        Dim k As Integer
        ff = data.executeSQL("SELECT code,description FROM class ORDER BY `level`")
        For Each drow In ff.Rows
            ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper)
            cls.Add(drow.Item(0).ToString.ToUpper)
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class