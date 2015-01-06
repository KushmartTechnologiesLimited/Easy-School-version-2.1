using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
namespace easy_school
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class MDIParent1 : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}


		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RegisterNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ClassesAndStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewProjectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FeesReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TimetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CreateSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CreateBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddNewTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ClassTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TEachersAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SubjectDesignationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PrintExamReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SchoolFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Label1 = new System.Windows.Forms.Label();
			this.StatusStrip.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//StatusStrip
			//
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.ToolStripStatusLabel });
			this.StatusStrip.Location = new System.Drawing.Point(0, 431);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(1095, 22);
			this.StatusStrip.TabIndex = 7;
			this.StatusStrip.Text = "StatusStrip";
			//
			//ToolStripStatusLabel
			//
			this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
			this.ToolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.ToolStripStatusLabel.Text = "Status";
			//
			//MenuStrip1
			//
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.StudentsToolStripMenuItem,
				this.FeesToolStripMenuItem,
				this.TimetableToolStripMenuItem,
				this.TeachersToolStripMenuItem,
				this.ExamToolStripMenuItem,
				this.AdminToolStripMenuItem
			});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(1095, 29);
			this.MenuStrip1.TabIndex = 9;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//StudentsToolStripMenuItem
			//
			this.StudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.RegisterNewToolStripMenuItem,
				this.ViewRecordsToolStripMenuItem,
				this.ClassesAndStreamsToolStripMenuItem
			});
			this.StudentsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem";
			this.StudentsToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
			this.StudentsToolStripMenuItem.Text = "Students";
			//
			//RegisterNewToolStripMenuItem
			//
			this.RegisterNewToolStripMenuItem.Name = "RegisterNewToolStripMenuItem";
			this.RegisterNewToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
			this.RegisterNewToolStripMenuItem.Text = "register new";
			//
			//ViewRecordsToolStripMenuItem
			//
			this.ViewRecordsToolStripMenuItem.Name = "ViewRecordsToolStripMenuItem";
			this.ViewRecordsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
			this.ViewRecordsToolStripMenuItem.Text = "view records";
			//
			//ClassesAndStreamsToolStripMenuItem
			//
			this.ClassesAndStreamsToolStripMenuItem.Name = "ClassesAndStreamsToolStripMenuItem";
			this.ClassesAndStreamsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
			this.ClassesAndStreamsToolStripMenuItem.Text = "Classes and Streams";
			//
			//FeesToolStripMenuItem
			//
			this.FeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.ViewProjectionsToolStripMenuItem,
				this.FeesReportsToolStripMenuItem
			});
			this.FeesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FeesToolStripMenuItem.Name = "FeesToolStripMenuItem";
			this.FeesToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
			this.FeesToolStripMenuItem.Text = "fees";
			//
			//ViewProjectionsToolStripMenuItem
			//
			this.ViewProjectionsToolStripMenuItem.Name = "ViewProjectionsToolStripMenuItem";
			this.ViewProjectionsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.ViewProjectionsToolStripMenuItem.Text = "view Fees Structures";
			//
			//FeesReportsToolStripMenuItem
			//
			this.FeesReportsToolStripMenuItem.Name = "FeesReportsToolStripMenuItem";
			this.FeesReportsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.FeesReportsToolStripMenuItem.Text = "fees reports";
			//
			//TimetableToolStripMenuItem
			//
			this.TimetableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.CreateSubjectsToolStripMenuItem,
				this.CreateBlocksToolStripMenuItem
			});
			this.TimetableToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TimetableToolStripMenuItem.Name = "TimetableToolStripMenuItem";
			this.TimetableToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
			this.TimetableToolStripMenuItem.Text = "Sms Services";
			//
			//CreateSubjectsToolStripMenuItem
			//
			this.CreateSubjectsToolStripMenuItem.Name = "CreateSubjectsToolStripMenuItem";
			this.CreateSubjectsToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
			this.CreateSubjectsToolStripMenuItem.Text = "Start Service";
			//
			//CreateBlocksToolStripMenuItem
			//
			this.CreateBlocksToolStripMenuItem.Name = "CreateBlocksToolStripMenuItem";
			this.CreateBlocksToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
			this.CreateBlocksToolStripMenuItem.Text = "How to Use";
			//
			//TeachersToolStripMenuItem
			//
			this.TeachersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.AddNewTeacherToolStripMenuItem,
				this.ClassTeachersToolStripMenuItem,
				this.ViewTeachersToolStripMenuItem,
				this.TEachersAttendanceToolStripMenuItem,
				this.SubjectDesignationToolStripMenuItem
			});
			this.TeachersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TeachersToolStripMenuItem.Name = "TeachersToolStripMenuItem";
			this.TeachersToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
			this.TeachersToolStripMenuItem.Text = "Teachers";
			//
			//AddNewTeacherToolStripMenuItem
			//
			this.AddNewTeacherToolStripMenuItem.Name = "AddNewTeacherToolStripMenuItem";
			this.AddNewTeacherToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.AddNewTeacherToolStripMenuItem.Text = "Add New Teacher";
			//
			//ClassTeachersToolStripMenuItem
			//
			this.ClassTeachersToolStripMenuItem.Name = "ClassTeachersToolStripMenuItem";
			this.ClassTeachersToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.ClassTeachersToolStripMenuItem.Text = "Class Teachers";
			//
			//ViewTeachersToolStripMenuItem
			//
			this.ViewTeachersToolStripMenuItem.Name = "ViewTeachersToolStripMenuItem";
			this.ViewTeachersToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.ViewTeachersToolStripMenuItem.Text = "View Teachers";
			//
			//TEachersAttendanceToolStripMenuItem
			//
			this.TEachersAttendanceToolStripMenuItem.Name = "TEachersAttendanceToolStripMenuItem";
			this.TEachersAttendanceToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.TEachersAttendanceToolStripMenuItem.Text = "Teachers Attendance";
			//
			//SubjectDesignationToolStripMenuItem
			//
			this.SubjectDesignationToolStripMenuItem.Name = "SubjectDesignationToolStripMenuItem";
			this.SubjectDesignationToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.SubjectDesignationToolStripMenuItem.Text = "Subject Designation";
			//
			//ExamToolStripMenuItem
			//
			this.ExamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.PrintExamReportsToolStripMenuItem });
			this.ExamToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem";
			this.ExamToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
			this.ExamToolStripMenuItem.Text = "Exam";
			//
			//PrintExamReportsToolStripMenuItem
			//
			this.PrintExamReportsToolStripMenuItem.Name = "PrintExamReportsToolStripMenuItem";
			this.PrintExamReportsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
			this.PrintExamReportsToolStripMenuItem.Text = "Print Exam Reports";
			//
			//AdminToolStripMenuItem
			//
			this.AdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.SchoolFeesToolStripMenuItem,
				this.AddUsersToolStripMenuItem
			});
			this.AdminToolStripMenuItem.Enabled = false;
			this.AdminToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
			this.AdminToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
			this.AdminToolStripMenuItem.Text = "admin";
			//
			//SchoolFeesToolStripMenuItem
			//
			this.SchoolFeesToolStripMenuItem.Name = "SchoolFeesToolStripMenuItem";
			this.SchoolFeesToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
			this.SchoolFeesToolStripMenuItem.Text = "Adminstrator Switch";
			//
			//AddUsersToolStripMenuItem
			//
			this.AddUsersToolStripMenuItem.Name = "AddUsersToolStripMenuItem";
			this.AddUsersToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
			this.AddUsersToolStripMenuItem.Text = "Add  Users";
			//
			//Label1
			//
			this.Label1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(1029, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(39, 13);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Label1";
			//
			//MDIParent1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1095, 453);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.MenuStrip1);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.IsMdiContainer = true;
			this.Name = "MDIParent1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.ToolTip ToolTip;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
		internal System.Windows.Forms.StatusStrip StatusStrip;
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_RegisterNewToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RegisterNewToolStripMenuItem {
			get { return withEventsField_RegisterNewToolStripMenuItem; }
			set {
				if (withEventsField_RegisterNewToolStripMenuItem != null) {
					withEventsField_RegisterNewToolStripMenuItem.Click -= RegisterNewToolStripMenuItem_Click;
				}
				withEventsField_RegisterNewToolStripMenuItem = value;
				if (withEventsField_RegisterNewToolStripMenuItem != null) {
					withEventsField_RegisterNewToolStripMenuItem.Click += RegisterNewToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ViewRecordsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ViewRecordsToolStripMenuItem {
			get { return withEventsField_ViewRecordsToolStripMenuItem; }
			set {
				if (withEventsField_ViewRecordsToolStripMenuItem != null) {
					withEventsField_ViewRecordsToolStripMenuItem.Click -= ViewRecordsToolStripMenuItem_Click;
				}
				withEventsField_ViewRecordsToolStripMenuItem = value;
				if (withEventsField_ViewRecordsToolStripMenuItem != null) {
					withEventsField_ViewRecordsToolStripMenuItem.Click += ViewRecordsToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem AdminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_AddUsersToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddUsersToolStripMenuItem {
			get { return withEventsField_AddUsersToolStripMenuItem; }
			set {
				if (withEventsField_AddUsersToolStripMenuItem != null) {
					withEventsField_AddUsersToolStripMenuItem.Click -= AddUsersToolStripMenuItem_Click;
				}
				withEventsField_AddUsersToolStripMenuItem = value;
				if (withEventsField_AddUsersToolStripMenuItem != null) {
					withEventsField_AddUsersToolStripMenuItem.Click += AddUsersToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem FeesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ViewProjectionsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ViewProjectionsToolStripMenuItem {
			get { return withEventsField_ViewProjectionsToolStripMenuItem; }
			set {
				if (withEventsField_ViewProjectionsToolStripMenuItem != null) {
					withEventsField_ViewProjectionsToolStripMenuItem.Click -= ViewProjectionsToolStripMenuItem_Click;
				}
				withEventsField_ViewProjectionsToolStripMenuItem = value;
				if (withEventsField_ViewProjectionsToolStripMenuItem != null) {
					withEventsField_ViewProjectionsToolStripMenuItem.Click += ViewProjectionsToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_FeesReportsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FeesReportsToolStripMenuItem {
			get { return withEventsField_FeesReportsToolStripMenuItem; }
			set {
				if (withEventsField_FeesReportsToolStripMenuItem != null) {
					withEventsField_FeesReportsToolStripMenuItem.Click -= FeesReportsToolStripMenuItem_Click;
				}
				withEventsField_FeesReportsToolStripMenuItem = value;
				if (withEventsField_FeesReportsToolStripMenuItem != null) {
					withEventsField_FeesReportsToolStripMenuItem.Click += FeesReportsToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem TimetableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_CreateSubjectsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CreateSubjectsToolStripMenuItem {
			get { return withEventsField_CreateSubjectsToolStripMenuItem; }
			set {
				if (withEventsField_CreateSubjectsToolStripMenuItem != null) {
					withEventsField_CreateSubjectsToolStripMenuItem.Click -= CreateSubjectsToolStripMenuItem_Click;
				}
				withEventsField_CreateSubjectsToolStripMenuItem = value;
				if (withEventsField_CreateSubjectsToolStripMenuItem != null) {
					withEventsField_CreateSubjectsToolStripMenuItem.Click += CreateSubjectsToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem CreateBlocksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_SchoolFeesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SchoolFeesToolStripMenuItem {
			get { return withEventsField_SchoolFeesToolStripMenuItem; }
			set {
				if (withEventsField_SchoolFeesToolStripMenuItem != null) {
					withEventsField_SchoolFeesToolStripMenuItem.Click -= SchoolFeesToolStripMenuItem_Click;
				}
				withEventsField_SchoolFeesToolStripMenuItem = value;
				if (withEventsField_SchoolFeesToolStripMenuItem != null) {
					withEventsField_SchoolFeesToolStripMenuItem.Click += SchoolFeesToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ClassesAndStreamsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ClassesAndStreamsToolStripMenuItem {
			get { return withEventsField_ClassesAndStreamsToolStripMenuItem; }
			set {
				if (withEventsField_ClassesAndStreamsToolStripMenuItem != null) {
					withEventsField_ClassesAndStreamsToolStripMenuItem.Click -= ClassesAndStreamsToolStripMenuItem_Click;
				}
				withEventsField_ClassesAndStreamsToolStripMenuItem = value;
				if (withEventsField_ClassesAndStreamsToolStripMenuItem != null) {
					withEventsField_ClassesAndStreamsToolStripMenuItem.Click += ClassesAndStreamsToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem TeachersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_AddNewTeacherToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddNewTeacherToolStripMenuItem {
			get { return withEventsField_AddNewTeacherToolStripMenuItem; }
			set {
				if (withEventsField_AddNewTeacherToolStripMenuItem != null) {
					withEventsField_AddNewTeacherToolStripMenuItem.Click -= AddNewTeacherToolStripMenuItem_Click;
				}
				withEventsField_AddNewTeacherToolStripMenuItem = value;
				if (withEventsField_AddNewTeacherToolStripMenuItem != null) {
					withEventsField_AddNewTeacherToolStripMenuItem.Click += AddNewTeacherToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ClassTeachersToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ClassTeachersToolStripMenuItem {
			get { return withEventsField_ClassTeachersToolStripMenuItem; }
			set {
				if (withEventsField_ClassTeachersToolStripMenuItem != null) {
					withEventsField_ClassTeachersToolStripMenuItem.Click -= ClassTeachersToolStripMenuItem_Click;
				}
				withEventsField_ClassTeachersToolStripMenuItem = value;
				if (withEventsField_ClassTeachersToolStripMenuItem != null) {
					withEventsField_ClassTeachersToolStripMenuItem.Click += ClassTeachersToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ViewTeachersToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ViewTeachersToolStripMenuItem {
			get { return withEventsField_ViewTeachersToolStripMenuItem; }
			set {
				if (withEventsField_ViewTeachersToolStripMenuItem != null) {
					withEventsField_ViewTeachersToolStripMenuItem.Click -= ViewTeachersToolStripMenuItem_Click;
				}
				withEventsField_ViewTeachersToolStripMenuItem = value;
				if (withEventsField_ViewTeachersToolStripMenuItem != null) {
					withEventsField_ViewTeachersToolStripMenuItem.Click += ViewTeachersToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_TEachersAttendanceToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem TEachersAttendanceToolStripMenuItem {
			get { return withEventsField_TEachersAttendanceToolStripMenuItem; }
			set {
				if (withEventsField_TEachersAttendanceToolStripMenuItem != null) {
					withEventsField_TEachersAttendanceToolStripMenuItem.Click -= TEachersAttendanceToolStripMenuItem_Click;
				}
				withEventsField_TEachersAttendanceToolStripMenuItem = value;
				if (withEventsField_TEachersAttendanceToolStripMenuItem != null) {
					withEventsField_TEachersAttendanceToolStripMenuItem.Click += TEachersAttendanceToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_SubjectDesignationToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SubjectDesignationToolStripMenuItem {
			get { return withEventsField_SubjectDesignationToolStripMenuItem; }
			set {
				if (withEventsField_SubjectDesignationToolStripMenuItem != null) {
					withEventsField_SubjectDesignationToolStripMenuItem.Click -= SubjectDesignationToolStripMenuItem_Click;
				}
				withEventsField_SubjectDesignationToolStripMenuItem = value;
				if (withEventsField_SubjectDesignationToolStripMenuItem != null) {
					withEventsField_SubjectDesignationToolStripMenuItem.Click += SubjectDesignationToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem ExamToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_PrintExamReportsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem PrintExamReportsToolStripMenuItem {
			get { return withEventsField_PrintExamReportsToolStripMenuItem; }
			set {
				if (withEventsField_PrintExamReportsToolStripMenuItem != null) {
					withEventsField_PrintExamReportsToolStripMenuItem.Click -= PrintExamReportsToolStripMenuItem_Click;
				}
				withEventsField_PrintExamReportsToolStripMenuItem = value;
				if (withEventsField_PrintExamReportsToolStripMenuItem != null) {
					withEventsField_PrintExamReportsToolStripMenuItem.Click += PrintExamReportsToolStripMenuItem_Click;
				}
			}

		}
	}
}
