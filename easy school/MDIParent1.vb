Imports System.Windows.Forms
Public Class MDIParent1
    Public role As String

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()

    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If role = 1 Then
            AdminToolStripMenuItem.Enabled = True
        End If
        Dim ChildForm As New view_all
        closeall()
        With ChildForm
            .MdiParent = Me
            ' .ControlBox = False
            '.WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .Text = ""
            .Show()
        End With
    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Dim ChildForm As New register_main
        closeall()
        '' Make it a child of this MDI form before showing it.
        'ChildForm.MdiParent = Me
        'ChildForm.Show()
    End Sub
    Sub closeall()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub RegisterNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterNewToolStripMenuItem.Click
        Dim bb As New new_student
        bb.ShowDialog()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim ChildForm As New student_profile
        'closeall()
        '' Make it a child of this MDI form before showing it.
        'With ChildForm
        '    .MdiParent = Me
        '    .ControlBox = False
        '    .WindowState = FormWindowState.Maximized
        '    .Text = ""
        '    .Show()
        'End With
    End Sub

    Private Sub ViewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        Dim ChildForm As New view_all
        closeall()
        With ChildForm
            .MdiParent = Me
            ' .ControlBox = False
            '.WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .Text = ""
            .Show()
        End With
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim ChildForm As New teacher
        'closeall()
        '' Make it a child of this MDI form before showing it.
        'With ChildForm
        '    .MdiParent = Me
        '    .ControlBox = False
        '    .WindowState = FormWindowState.Maximized
        '    .Text = ""
        '    .Show()
        'End With
    End Sub

    Private Sub ViewRecordsToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'Dim ChildForm As New teacher_view
        'closeall()
        '' Make it a child of this MDI form before showing it.
        'With ChildForm
        '    .MdiParent = Me
        '    .ControlBox = False
        '    .WindowState = FormWindowState.Maximized
        '    .Text = ""
        '    .Show()
        'End With
    End Sub

    Private Sub AssignClassTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim ChildForm As New class_assgn
        'closeall()
        '' Make it a child of this MDI form before showing it.
        'With ChildForm
        '    .MdiParent = Me
        '    .ControlBox = False
        '    .WindowState = FormWindowState.Maximized
        '    .Text = ""
        '    .Show()
        'End With
    End Sub

    Private Sub AssignASubjectToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub CreateSubjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateSubjectsToolStripMenuItem.Click
        Process.Start("sms.exe")
    End Sub

    Private Sub SchoolFeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchoolFeesToolStripMenuItem.Click
        Dim ChildForm As New Fees_Admin
        closeall()
        With ChildForm
            .MdiParent = Me
            ' .ControlBox = False
            '.WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .Text = ""
            .Show()
        End With
        'view_all
    End Sub

    Private Sub FeesReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeesReportsToolStripMenuItem.Click
        Dim ChildForm As New report
        closeall()
        With ChildForm
            .MdiParent = Me
            ' .ControlBox = False
            '.WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .Text = ""
            .Show()
        End With
    End Sub

    Private Sub AddUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUsersToolStripMenuItem.Click
        Dim ChildForm As New create_user
        '  closeall()
        With ChildForm
            .ShowDialog()

        End With
    End Sub

    Private Sub ViewProjectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProjectionsToolStripMenuItem.Click
        Dim ChildForm As New billing
        closeall()
        With ChildForm
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Text = ""
            .Show()
        End With
    End Sub


    Private Sub ClassesAndStreamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassesAndStreamsToolStripMenuItem.Click
        Dim ChildForm As New classes
        '  closeall()
        With ChildForm
            .ShowDialog()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub AddNewTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewTeacherToolStripMenuItem.Click
        Dim ChildForm As New teacher
        closeall()
        With ChildForm
            '.MdiParent = Me
            '.Dock = DockStyle.Fill
            .Text = ""
            .ShowDialog()
        End With
    End Sub

    Private Sub ClassTeachersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassTeachersToolStripMenuItem.Click
        Dim ChildForm As New class_teachers

        With ChildForm
            '.MdiParent = Me
            '.Dock = DockStyle.Fill
            .Text = ""
            .ShowDialog()
        End With
    End Sub

    Private Sub ViewTeachersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTeachersToolStripMenuItem.Click
        Dim ChildForm As New teacher_view
        closeall()
        With ChildForm
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Text = ""
            .Show()
        End With
    End Sub

    Private Sub TEachersAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TEachersAttendanceToolStripMenuItem.Click
        Dim ChildForm As New teachers_attendance

        With ChildForm
            '.MdiParent = Me
            '.Dock = DockStyle.Fill
            .Text = ""
            .ShowDialog()
        End With
    End Sub

    Private Sub SubjectDesignationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectDesignationToolStripMenuItem.Click
        Dim ChildForm As New class_assgn

        With ChildForm
            '.MdiParent = Me
            '.Dock = DockStyle.Fill
            .Text = ""
            .ShowDialog()
        End With
    End Sub

    Private Sub RegisterExamResultsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim ChildForm As New Form2
        closeall()
        With ChildForm
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Text = ""
            .Show()
        End With
    End Sub

    Private Sub ViewExamResultsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '    Dim ChildForm As New 
        '    closeall()
        '    With ChildForm
        '        .MdiParent = Me
        '        .Dock = DockStyle.Fill
        '        .Text = ""
        '        .Show()
        '    End With
    End Sub

    Private Sub PrintExamReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintExamReportsToolStripMenuItem.Click
        Dim ChildForm As New exam_reports
        closeall()
        With ChildForm
            .Text = ""
            .ShowDialog()
        End With
    End Sub
End Class
