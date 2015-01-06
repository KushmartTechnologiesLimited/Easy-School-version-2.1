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
	public partial class MDIParent1
	{

		public string role;
		private void ShowNewForm(object sender, EventArgs e)
		{
			// Create a new instance of the child form.
			System.Windows.Forms.Form ChildForm = new System.Windows.Forms.Form();
			// Make it a child of this MDI form before showing it.
			ChildForm.MdiParent = this;

			m_ChildFormNumber += 1;
			ChildForm.Text = "Window " + m_ChildFormNumber;

			ChildForm.Show();

		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog OpenFileDialog = new OpenFileDialog();
			OpenFileDialog.InitialDirectory = easy_school.My.MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments;
			OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if ((OpenFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)) {
				string FileName = OpenFileDialog.FileName;
				// TODO: Add code here to open the file.
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog SaveFileDialog = new SaveFileDialog();
			SaveFileDialog.InitialDirectory = easy_school.My.MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments;
			SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

			if ((SaveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)) {
				string FileName = SaveFileDialog.FileName;
				// TODO: Add code here to save the current contents of the form to a file.
			}
		}


		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Use My.Computer.Clipboard to insert the selected text or images into the clipboard
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Use My.Computer.Clipboard to insert the selected text or images into the clipboard
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
		}



		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Close all child forms of the parent.
			foreach (Form ChildForm in this.MdiChildren) {
				ChildForm.Close();
			}
		}


		private int m_ChildFormNumber;
		private void MDIParent1_Load(object sender, EventArgs e)
		{
			if (role == 1) {
				AdminToolStripMenuItem.Enabled = true;
			}
			view_all ChildForm = new view_all();
			closeall();
			var _with1 = ChildForm;
			_with1.MdiParent = this;
			// .ControlBox = False
			//.WindowState = FormWindowState.Maximized
			_with1.Dock = DockStyle.Fill;
			_with1.Text = "";
			_with1.Show();
		}


		private void PrintToolStripButton_Click(object sender, EventArgs e)
		{
		}

		private void StudentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Dim ChildForm As New register_main
			closeall();
			//' Make it a child of this MDI form before showing it.
			//ChildForm.MdiParent = Me
			//ChildForm.Show()
		}
		public void closeall()
		{
			foreach (Form ChildForm in this.MdiChildren) {
				ChildForm.Close();
			}
		}

		private void RegisterNewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new_student bb = new new_student();
			bb.ShowDialog();
		}

		private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Dim ChildForm As New student_profile
			//closeall()
			//' Make it a child of this MDI form before showing it.
			//With ChildForm
			//    .MdiParent = Me
			//    .ControlBox = False
			//    .WindowState = FormWindowState.Maximized
			//    .Text = ""
			//    .Show()
			//End With
		}

		private void ViewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			view_all ChildForm = new view_all();
			closeall();
			var _with2 = ChildForm;
			_with2.MdiParent = this;
			// .ControlBox = False
			//.WindowState = FormWindowState.Maximized
			_with2.Dock = DockStyle.Fill;
			_with2.Text = "";
			_with2.Show();
		}

		private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Dim ChildForm As New teacher
			//closeall()
			//' Make it a child of this MDI form before showing it.
			//With ChildForm
			//    .MdiParent = Me
			//    .ControlBox = False
			//    .WindowState = FormWindowState.Maximized
			//    .Text = ""
			//    .Show()
			//End With
		}

		private void ViewRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//Dim ChildForm As New teacher_view
			//closeall()
			//' Make it a child of this MDI form before showing it.
			//With ChildForm
			//    .MdiParent = Me
			//    .ControlBox = False
			//    .WindowState = FormWindowState.Maximized
			//    .Text = ""
			//    .Show()
			//End With
		}

		private void AssignClassTeacherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Dim ChildForm As New class_assgn
			//closeall()
			//' Make it a child of this MDI form before showing it.
			//With ChildForm
			//    .MdiParent = Me
			//    .ControlBox = False
			//    .WindowState = FormWindowState.Maximized
			//    .Text = ""
			//    .Show()
			//End With
		}

		private void AssignASubjectToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CreateSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("sms.exe");
		}

		private void SchoolFeesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Fees_Admin ChildForm = new Fees_Admin();
			closeall();
			var _with3 = ChildForm;
			_with3.MdiParent = this;
			// .ControlBox = False
			//.WindowState = FormWindowState.Maximized
			_with3.Dock = DockStyle.Fill;
			_with3.Text = "";
			_with3.Show();
			//view_all
		}

		private void FeesReportsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			report ChildForm = new report();
			closeall();
			var _with4 = ChildForm;
			_with4.MdiParent = this;
			// .ControlBox = False
			//.WindowState = FormWindowState.Maximized
			_with4.Dock = DockStyle.Fill;
			_with4.Text = "";
			_with4.Show();
		}

		private void AddUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			create_user ChildForm = new create_user();
			//  closeall()
			var _with5 = ChildForm;
			_with5.ShowDialog();

		}

		private void ViewProjectionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			billing ChildForm = new billing();
			closeall();
			var _with6 = ChildForm;
			_with6.MdiParent = this;
			_with6.Dock = DockStyle.Fill;
			_with6.Text = "";
			_with6.Show();
		}


		private void ClassesAndStreamsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			classes ChildForm = new classes();
			//  closeall()
			var _with7 = ChildForm;
			_with7.ShowDialog();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void AddNewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			teacher ChildForm = new teacher();
			closeall();
			var _with8 = ChildForm;
			//.MdiParent = Me
			//.Dock = DockStyle.Fill
			_with8.Text = "";
			_with8.ShowDialog();
		}

		private void ClassTeachersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			class_teachers ChildForm = new class_teachers();

			var _with9 = ChildForm;
			//.MdiParent = Me
			//.Dock = DockStyle.Fill
			_with9.Text = "";
			_with9.ShowDialog();
		}

		private void ViewTeachersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			teacher_view ChildForm = new teacher_view();
			closeall();
			var _with10 = ChildForm;
			_with10.MdiParent = this;
			_with10.Dock = DockStyle.Fill;
			_with10.Text = "";
			_with10.Show();
		}

		private void TEachersAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			teachers_attendance ChildForm = new teachers_attendance();

			var _with11 = ChildForm;
			//.MdiParent = Me
			//.Dock = DockStyle.Fill
			_with11.Text = "";
			_with11.ShowDialog();
		}

		private void SubjectDesignationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			class_assgn ChildForm = new class_assgn();

			var _with12 = ChildForm;
			//.MdiParent = Me
			//.Dock = DockStyle.Fill
			_with12.Text = "";
			_with12.ShowDialog();
		}

		private void RegisterExamResultsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 ChildForm = new Form2();
			closeall();
			var _with13 = ChildForm;
			_with13.MdiParent = this;
			_with13.Dock = DockStyle.Fill;
			_with13.Text = "";
			_with13.Show();
		}

		private void ViewExamResultsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//    Dim ChildForm As New 
			//    closeall()
			//    With ChildForm
			//        .MdiParent = Me
			//        .Dock = DockStyle.Fill
			//        .Text = ""
			//        .Show()
			//    End With
		}

		private void PrintExamReportsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			exam_reports ChildForm = new exam_reports();
			closeall();
			var _with14 = ChildForm;
			_with14.Text = "";
			_with14.ShowDialog();
		}
		public MDIParent1()
		{
			Load += MDIParent1_Load;
			InitializeComponent();
		}
	}
}
