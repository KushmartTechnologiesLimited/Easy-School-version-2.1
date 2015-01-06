<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassesAndStreamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProjectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimetableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateSubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateBlocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeachersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassTeachersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTeachersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TEachersAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectDesignationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintExamReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchoolFeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1095, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem, Me.FeesToolStripMenuItem, Me.TimetableToolStripMenuItem, Me.TeachersToolStripMenuItem, Me.ExamToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1095, 29)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterNewToolStripMenuItem, Me.ViewRecordsToolStripMenuItem, Me.ClassesAndStreamsToolStripMenuItem})
        Me.StudentsToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(87, 25)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'RegisterNewToolStripMenuItem
        '
        Me.RegisterNewToolStripMenuItem.Name = "RegisterNewToolStripMenuItem"
        Me.RegisterNewToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.RegisterNewToolStripMenuItem.Text = "register new"
        '
        'ViewRecordsToolStripMenuItem
        '
        Me.ViewRecordsToolStripMenuItem.Name = "ViewRecordsToolStripMenuItem"
        Me.ViewRecordsToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ViewRecordsToolStripMenuItem.Text = "view records"
        '
        'ClassesAndStreamsToolStripMenuItem
        '
        Me.ClassesAndStreamsToolStripMenuItem.Name = "ClassesAndStreamsToolStripMenuItem"
        Me.ClassesAndStreamsToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.ClassesAndStreamsToolStripMenuItem.Text = "Classes and Streams"
        '
        'FeesToolStripMenuItem
        '
        Me.FeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProjectionsToolStripMenuItem, Me.FeesReportsToolStripMenuItem})
        Me.FeesToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeesToolStripMenuItem.Name = "FeesToolStripMenuItem"
        Me.FeesToolStripMenuItem.Size = New System.Drawing.Size(52, 25)
        Me.FeesToolStripMenuItem.Text = "fees"
        '
        'ViewProjectionsToolStripMenuItem
        '
        Me.ViewProjectionsToolStripMenuItem.Name = "ViewProjectionsToolStripMenuItem"
        Me.ViewProjectionsToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.ViewProjectionsToolStripMenuItem.Text = "view Fees Structures"
        '
        'FeesReportsToolStripMenuItem
        '
        Me.FeesReportsToolStripMenuItem.Name = "FeesReportsToolStripMenuItem"
        Me.FeesReportsToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.FeesReportsToolStripMenuItem.Text = "fees reports"
        '
        'TimetableToolStripMenuItem
        '
        Me.TimetableToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateSubjectsToolStripMenuItem, Me.CreateBlocksToolStripMenuItem})
        Me.TimetableToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimetableToolStripMenuItem.Name = "TimetableToolStripMenuItem"
        Me.TimetableToolStripMenuItem.Size = New System.Drawing.Size(123, 25)
        Me.TimetableToolStripMenuItem.Text = "Sms Services"
        '
        'CreateSubjectsToolStripMenuItem
        '
        Me.CreateSubjectsToolStripMenuItem.Name = "CreateSubjectsToolStripMenuItem"
        Me.CreateSubjectsToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.CreateSubjectsToolStripMenuItem.Text = "Start Service"
        '
        'CreateBlocksToolStripMenuItem
        '
        Me.CreateBlocksToolStripMenuItem.Name = "CreateBlocksToolStripMenuItem"
        Me.CreateBlocksToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.CreateBlocksToolStripMenuItem.Text = "How to Use"
        '
        'TeachersToolStripMenuItem
        '
        Me.TeachersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewTeacherToolStripMenuItem, Me.ClassTeachersToolStripMenuItem, Me.ViewTeachersToolStripMenuItem, Me.TEachersAttendanceToolStripMenuItem, Me.SubjectDesignationToolStripMenuItem})
        Me.TeachersToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeachersToolStripMenuItem.Name = "TeachersToolStripMenuItem"
        Me.TeachersToolStripMenuItem.Size = New System.Drawing.Size(89, 25)
        Me.TeachersToolStripMenuItem.Text = "Teachers"
        '
        'AddNewTeacherToolStripMenuItem
        '
        Me.AddNewTeacherToolStripMenuItem.Name = "AddNewTeacherToolStripMenuItem"
        Me.AddNewTeacherToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.AddNewTeacherToolStripMenuItem.Text = "Add New Teacher"
        '
        'ClassTeachersToolStripMenuItem
        '
        Me.ClassTeachersToolStripMenuItem.Name = "ClassTeachersToolStripMenuItem"
        Me.ClassTeachersToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.ClassTeachersToolStripMenuItem.Text = "Class Teachers"
        '
        'ViewTeachersToolStripMenuItem
        '
        Me.ViewTeachersToolStripMenuItem.Name = "ViewTeachersToolStripMenuItem"
        Me.ViewTeachersToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.ViewTeachersToolStripMenuItem.Text = "View Teachers"
        '
        'TEachersAttendanceToolStripMenuItem
        '
        Me.TEachersAttendanceToolStripMenuItem.Name = "TEachersAttendanceToolStripMenuItem"
        Me.TEachersAttendanceToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.TEachersAttendanceToolStripMenuItem.Text = "Teachers Attendance"
        '
        'SubjectDesignationToolStripMenuItem
        '
        Me.SubjectDesignationToolStripMenuItem.Name = "SubjectDesignationToolStripMenuItem"
        Me.SubjectDesignationToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.SubjectDesignationToolStripMenuItem.Text = "Subject Designation"
        '
        'ExamToolStripMenuItem
        '
        Me.ExamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintExamReportsToolStripMenuItem})
        Me.ExamToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem"
        Me.ExamToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.ExamToolStripMenuItem.Text = "Exam"
        '
        'PrintExamReportsToolStripMenuItem
        '
        Me.PrintExamReportsToolStripMenuItem.Name = "PrintExamReportsToolStripMenuItem"
        Me.PrintExamReportsToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.PrintExamReportsToolStripMenuItem.Text = "Print Exam Reports"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchoolFeesToolStripMenuItem, Me.AddUsersToolStripMenuItem})
        Me.AdminToolStripMenuItem.Enabled = False
        Me.AdminToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(67, 25)
        Me.AdminToolStripMenuItem.Text = "admin"
        '
        'SchoolFeesToolStripMenuItem
        '
        Me.SchoolFeesToolStripMenuItem.Name = "SchoolFeesToolStripMenuItem"
        Me.SchoolFeesToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.SchoolFeesToolStripMenuItem.Text = "Adminstrator Switch"
        '
        'AddUsersToolStripMenuItem
        '
        Me.AddUsersToolStripMenuItem.Name = "AddUsersToolStripMenuItem"
        Me.AddUsersToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.AddUsersToolStripMenuItem.Text = "Add  Users"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1029, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 453)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProjectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimetableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateSubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateBlocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchoolFeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClassesAndStreamsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeachersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewTeacherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassTeachersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTeachersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TEachersAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectDesignationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintExamReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
