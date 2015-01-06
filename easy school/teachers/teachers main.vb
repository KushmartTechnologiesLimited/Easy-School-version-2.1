Public Class teachers_main

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Controls.Clear()
        Dim residents As New teacher
        residents.ControlBox = False
        residents.Text = ""
        residents.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        residents.Size = Panel2.Size
        residents.TopLevel = False
        residents.Parent = Panel2
        residents.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Controls.Clear()
        Dim residents As New teacher_view
        residents.ControlBox = False
        residents.Text = ""
        residents.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        residents.Size = Panel2.Size
        residents.TopLevel = False
        residents.Parent = Panel2
        residents.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Controls.Clear()
        Dim residents As New class_teachers
        residents.ControlBox = False
        residents.Text = ""
        residents.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        residents.Size = Panel2.Size
        residents.TopLevel = False
        residents.Parent = Panel2
        residents.Show()
    End Sub

    Private Sub teachers_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Controls.Clear()
        Dim residents As New teachers_attendance
        residents.ControlBox = False
        residents.Text = ""
        residents.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        residents.Size = Panel2.Size
        residents.TopLevel = False
        residents.Parent = Panel2
        residents.Show()
    End Sub
End Class