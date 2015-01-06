Public Class view_all
    Dim data As New database
    Dim class_id, str_id As New List(Of String)
    Dim cl As String = 0
    Dim strm As String = 0
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        cl = class_id(ComboBox1.SelectedIndex)
        strm = str_id(ComboBox2.SelectedIndex)
        filter()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        On Error Resume Next
        If TextBox1.TextLength > 0 Then
            DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered','TEL','Class','Stream' FROM `students`   WHERE  `admno` regexp '" & TextBox1.Text & "' or ` names` regexp '" & TextBox1.Text & "'")
        End If
    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        '    TextBox1.Focus()
    End Sub
    Sub filter()
        On Error Resume Next
        DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE `class_code`=" & cl & " and `str_code`= " & strm)
    End Sub

    Private Sub view_all_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE 1")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim neww As New new_student
        neww.ShowDialog()
        DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE 1")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        Dim i As Integer
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                Dim ITEM As String
                ITEM = DataGridView1.Item(0, i).Value
                Dim editt As New profile
                editt.TextBox26.Text = ITEM
                editt.Button9.PerformClick()
                editt.ShowDialog()
            End With
        End If
        DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE 1")

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        On Error Resume Next
        If TextBox1.TextLength > 0 Then

            DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE `admno` regexp '" & TextBox1.Text & "' or ` names` regexp '" & TextBox1.Text & "'")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                Dim ITEM As String
                ITEM = DataGridView1.Item(0, i).Value
                Dim editt As New profile
                editt.TextBox26.Text = ITEM
                editt.Button9.PerformClick()
                editt.ShowDialog()
            End With
        End If
    End Sub

    
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        On Error Resume Next
        cl = class_id(ComboBox1.SelectedIndex)
        strm = str_id(ComboBox2.SelectedIndex)
        filter()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE 1")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fee As New collect_fees
        Dim i As Integer
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                Dim ITEM As String
                ITEM = DataGridView1.Item(0, i).Value
                fee.TextBox1.Text = ITEM
                fee.TextBox1.ReadOnly = True
                Button1.Visible = False
                fee.ShowDialog()
            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim adm As New Fees_Admin
        adm.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class