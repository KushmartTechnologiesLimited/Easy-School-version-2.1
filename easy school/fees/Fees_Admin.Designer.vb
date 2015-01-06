<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fees_Admin
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddNewFeesItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateOrModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilllsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewFeesItemToolStripMenuItem, Me.CreateOrModifyToolStripMenuItem, Me.BillToolStripMenuItem, Me.BilllsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ProjectionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(897, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddNewFeesItemToolStripMenuItem
        '
        Me.AddNewFeesItemToolStripMenuItem.Name = "AddNewFeesItemToolStripMenuItem"
        Me.AddNewFeesItemToolStripMenuItem.Size = New System.Drawing.Size(187, 35)
        Me.AddNewFeesItemToolStripMenuItem.Text = "New Fees Item"
        '
        'CreateOrModifyToolStripMenuItem
        '
        Me.CreateOrModifyToolStripMenuItem.Name = "CreateOrModifyToolStripMenuItem"
        Me.CreateOrModifyToolStripMenuItem.Size = New System.Drawing.Size(86, 35)
        Me.CreateOrModifyToolStripMenuItem.Text = "Rates"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(185, 35)
        Me.BillToolStripMenuItem.Text = "Fees Strucures"
        '
        'BilllsToolStripMenuItem
        '
        Me.BilllsToolStripMenuItem.Name = "BilllsToolStripMenuItem"
        Me.BilllsToolStripMenuItem.Size = New System.Drawing.Size(77, 35)
        Me.BilllsToolStripMenuItem.Text = "Bills"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 35)
        Me.ToolStripMenuItem1.Text = "Change Classes "
        '
        'ProjectionsToolStripMenuItem
        '
        Me.ProjectionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YearToolStripMenuItem})
        Me.ProjectionsToolStripMenuItem.Name = "ProjectionsToolStripMenuItem"
        Me.ProjectionsToolStripMenuItem.Size = New System.Drawing.Size(111, 35)
        Me.ProjectionsToolStripMenuItem.Text = "Reports"
        '
        'YearToolStripMenuItem
        '
        Me.YearToolStripMenuItem.Name = "YearToolStripMenuItem"
        Me.YearToolStripMenuItem.Size = New System.Drawing.Size(219, 36)
        Me.YearToolStripMenuItem.Text = "Fees Report"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(897, 477)
        Me.Panel1.TabIndex = 1
        '
        'Fees_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fees_Admin"
        Me.Text = " "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddNewFeesItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateOrModifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BilllsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
