Public Class class_assgn
    Dim data As New database
    Dim class_id, teacher_id, str_id, picha As New List(Of String)
    Private Sub LV_PatiView_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim SelectedItems As ListView.SelectedListViewItemCollection = _
      CType(sender, ListView).SelectedItems
        If (SelectedItems.Count > 0) Then
            ComboBox1.Text = SelectedItems(0).SubItems(0).Text
            ComboBox2.Text = SelectedItems(0).SubItems(1).Text
            ComboBox3.Text = SelectedItems(0).SubItems(2).Text
            Button2.Hide()
        End If
    End Sub
    Private Sub class_assgn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refe()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim red, red1, red2 As DataTable
        red = data.executeSQL("SELECT `national_id`, `name`,`pic` FROM `teachers`")  'teachers
        For Each drow In red.Rows
            ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper)
            teacher_id.Add(drow.Item(0).ToString.ToUpper)
            picha.Add(drow.Item(2).ToString.ToUpper)
        Next
        red2 = data.executeSQL("SELECT `code`, `level` FROM `class` ")  'class
        For Each drow In red2.Rows
            ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper)
            class_id.Add(drow.Item(0).ToString.ToUpper)
        Next
        red1 = data.executeSQL("SELECT `code`, `name` FROM `stream`")  'streamms
        For Each drow In red1.Rows
            ComboBox3.Items.Add(drow.Item(1).ToString.ToUpper)
            str_id.Add(drow.Item(0).ToString.ToUpper)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Label5.Text = teacher_id(ComboBox1.SelectedIndex)
        Try
            PictureBox1.ImageLocation = picha(ComboBox1.SelectedIndex)
        Catch ex As Exception
            PictureBox1.Image.Dispose()
        End Try



    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label5.Text = class_id(ComboBox2.SelectedIndex)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Label5.Text = str_id(ComboBox3.SelectedIndex)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim tr, cl, str As String
        If ComboBox1.Text = "" Then
            MsgBox("seletct a teacher", MsgBoxStyle.Information, "incorrect data")
        Else
            tr = teacher_id(ComboBox1.SelectedIndex)
            If ComboBox2.Text = "" Then
                MsgBox("seletct a class", MsgBoxStyle.Information, "incorrect data")
            Else
                cl = class_id(ComboBox2.SelectedIndex)
                If ComboBox3.Text = "" Then
                    MsgBox("seletct a Stream", MsgBoxStyle.Information, "incorrect data")
                Else
                    ComboBox3.SelectedIndex = 0
                    str = str_id(ComboBox3.SelectedIndex)
                    sql = "INSERT INTO `class_teacher`(`national_id`, `class_code`, `stream_code`) VALUES (" & tr & ", " & cl & "," & str & ")"
                    data.add(sql)
                End If
            End If
        End If

        refe()
    End Sub
    Sub refe()
        Dim led As DataTable
        led = data.executeSQL("SELECT (select name from teachers where national_id=class_teacher.national_id) as NAMES,(SELECT level FROM class where code=class_teacher.class_code) as Class,(SELECT  name FROM stream WHERE class_teacher.stream_code =code) as Stream FROM class_teacher ")  'teachers
        DataGridView1.DataSource = led
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
         Dim i As Integer
        Dim h As String
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                ComboBox1.Text = .Item(0, i).Value
                ComboBox2.Text = .Item(1, i).Value
                ComboBox3.Text = .Item(2, i).Value
            End With
            Button2.Enabled = False
            Panel6.Enabled = True
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub


    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        On Error Resume Next
        Dim i As Integer
        Dim h As String
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                ComboBox1.Text = .Item(0, i).Value
                ComboBox2.Text = .Item(1, i).Value
                ComboBox3.Text = .Item(2, i).Value
            End With
            'Button2.Enabled = False
            'Panel6.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        refe()
        'Button2.Enabled = True
        'Panel6.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (MsgBox("are you sure you want to delete" + vbCrLf + "   TEACHER: " + ComboBox1.Text + vbCrLf + "    CLASS: " + ComboBox2.Text + vbCrLf + "    STREAM:  " + ComboBox3.Text, MsgBoxStyle.YesNo, "confirm") = MsgBoxResult.Yes) Then
            Dim FF As String
            FF = "DELETE FROM `class_teacher` WHERE `national_id`=" & teacher_id(ComboBox1.SelectedIndex) & " AND `class_code`=" & class_id(ComboBox2.SelectedIndex) & " AND `stream_code`=" & str_id(ComboBox3.SelectedIndex)
            data.delete(FF)
        End If
        refe()
    End Sub
End Class