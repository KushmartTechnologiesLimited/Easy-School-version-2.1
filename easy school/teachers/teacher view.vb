Public Class teacher_view
    Dim sql As String = "SELECT  `name`, `national_id`,  `tel`, `email`,   `qualification`, `institution`, `year_out` FROM `teachers`"
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    Sub fillter()
        Dim data As New studentsdatabase

        Dim fil As String = " where `name` regexp  '" & TextBox2.Text & "' or `national_id` regexp '" & TextBox2.Text & "'"
        Data.select_dgview(sql + fil, DataGridView1)
    End Sub

    Private Sub teacher_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New studentsdatabase

        Data.select_dgview(sql, DataGridView1)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim data As New studentsdatabase

        Data.select_dgview(sql, DataGridView1)
        TextBox2.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        Dim h As String
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                h = .Item(1, i).Value
            End With
            Try
                Dim data As New studentsdatabase
                Dim red As DataTable
                red = data.executeSQL("SELECT * FROM `teachers` WHERE `national_id`='" & h & "'")
                Dim tt As New teacher
                tt.selected(red)
                tt.Button3.Enabled = True
                tt.Button2.Enabled = False
                tt.ShowDialog()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer
        Dim h As String
        If DataGridView1.RowCount > 0 Then
            i = DataGridView1.CurrentRow.Index
            With DataGridView1
                h = .Item(1, i).Value
                If MsgBox("are you sure you want to delete the record", MsgBoxStyle.YesNo, "confirm") = MsgBoxResult.Yes Then
                    Try
                        Dim data As New studentsdatabase
                        Dim red As DataTable
                        red = data.executeSQL("DELETE FROM `teachers` WHERE  `national_id`='" & h & "'")
                        Button6.PerformClick()
                        Dim tt As New teacher
                    Catch ex As Exception
                    End Try
                End If
            End With
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.TextLength > 0 Then
            fillter()
        Else
            Button6.PerformClick()
        End If

    End Sub
End Class