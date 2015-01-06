Public Class Fees_Admin

    Private Sub AddNewFeesItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewFeesItemToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim residents As New type
        residents.Size = Panel1.Size
        residents.TopLevel = False
        residents.Parent = Panel1
        residents.Show()
    End Sub

    Private Sub CreateOrModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateOrModifyToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim residents As New fees_rates
        residents.Size = Panel1.Size
        residents.TopLevel = False
        residents.Parent = Panel1
        residents.Show()
    End Sub

    Private Sub BillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim residents As New billing
        residents.Size = Panel1.Size
        residents.TopLevel = False
        residents.Parent = Panel1
        residents.Show()
    End Sub

    Private Sub Fees_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BilllsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BilllsToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim residents As New bill_student
        residents.Size = Panel1.Size
        residents.TopLevel = False
        residents.Parent = Panel1
        residents.Show()
    End Sub

    Private Sub ProjectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectionsToolStripMenuItem.Click

    End Sub

    Private Sub YearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearToolStripMenuItem.Click
        Panel1.Controls.Clear()
        Dim residents As New report
        residents.Size = Panel1.Size
        residents.TopLevel = False
        residents.Parent = Panel1
        residents.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Panel1.Controls.Clear()
        Dim residents As New bill
        residents.Size = Panel1.Size
        residents.TopLevel = False
        residents.Parent = Panel1
        residents.Show()
    End Sub
End Class