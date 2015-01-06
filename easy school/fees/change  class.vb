Public Class bill
    Dim data As New database
    Dim class_id As New List(Of String)
    Dim adm As String
    Dim first, last, current_class, current As Integer

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If
    End Sub
    Private Sub bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rd As DataTable
        rd = data.executeSQL("SELECT code,description,level  FROM class ORDER BY `level`")
        For Each drow In rd.Rows
            ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper)
            ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper)
            class_id.Add(drow.Item(2).ToString.ToUpper)

        Next
        ComboBox1.SelectedIndex = (0)
        ComboBox2.SelectedIndex = rd.Rows.Count - 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Set" Then
            first = class_id(ComboBox1.SelectedIndex)
            last = class_id(ComboBox2.SelectedIndex)
            If first >= last Then
                MsgBox("invalid selection", MsgBoxStyle.Information, "error")
                Exit Sub
            End If
            'MsgBox("first class is " & first & " and last class is " & last)
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            Button2.Text = "Reset"
            Panel1.Enabled = True
        ElseIf Button2.Text = "Reset" Then
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            Button2.Text = "Set"
            Panel1.Enabled = False
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox4.Text = "" Then
            Exit Sub
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Dim red As DataTable
        red = data.executeSQL("SELECT `admno`, ` names`,(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  class.level FROM class WHERE class.code=`class_code`)'CLass' FROM `students` WHERE `admno`=" & TextBox4.Text)
        If red.Rows.Count < 1 Then
            MsgBox("No Record found!!!", MsgBoxStyle.Information, "   Message")
            'TextBox4.Text = ""
            TextBox4.Focus()
            Exit Sub
        End If
        For Each drow In red.Rows
            TextBox1.Text = drow.Item(1).ToString.ToUpper
            TextBox2.Text = drow.Item(0).ToString.ToUpper
            TextBox3.Text = drow.Item(2).ToString.ToUpper
            current_class = drow.Item(3)
            adm = drow.Item(0).ToString.ToUpper
            TextBox4.Focus()
        Next
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim val As New validate
        val.digits(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sql As String
        current = current_class - 1
        If current < first Or current > last Then
            MsgBox("Opperation not Allowed!", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If
        Sql = "UPDATE `students` SET `class_code`=(SELECT `code` FROM `class` WHERE `level`=" & current & ") WHERE `admno`=" & adm
        data.add(sql)
        Button3.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        current = current_class + 1
        If current < first Or current > last Then
            MsgBox("Opperation not Allowed!", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If
        sql = "UPDATE `students` SET `class_code`=(SELECT `code` FROM `class` WHERE `level`=" & current & ") WHERE `admno`=" & adm
        data.add(sql)
        Button3.PerformClick()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim red As DataTable
        Dim sql As String
        red = data.executeSQL("SELECT `admno`, ` names`,(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  class.level FROM class WHERE class.code=`class_code`)'CLass' FROM `students` WHERE status=1")
        If red.Rows.Count < 1 Then
            MsgBox("No Record found!!!", MsgBoxStyle.Information, "   Message")
            Exit Sub
        Else
            For Each drow In red.Rows
                current_class = drow.Item(3)
                adm = drow.Item(0).ToString.ToUpper

                current = current_class + 1
                If current > last Then
                    sql = "UPDATE `students` SET status=0  WHERE `admno`=" & adm
                    data.add1(sql)
                Else
                    sql = "UPDATE `students` SET `class_code`=(SELECT `code` FROM `class` WHERE `level`=" & current & ") WHERE `admno`=" & adm
                    data.add1(sql)
                End If

            Next
            MsgBox("Operation Completed !!", MsgBoxStyle.Information, " Message")
        End If
    End Sub
End Class