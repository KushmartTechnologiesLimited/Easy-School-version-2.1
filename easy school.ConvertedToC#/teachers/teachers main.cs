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
	public partial class teachers_main
	{

		private void Button1_Click(object sender, EventArgs e)
		{
			Panel2.Controls.Clear();
			teacher residents = new teacher();
			residents.ControlBox = false;
			residents.Text = "";
			residents.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			residents.Size = Panel2.Size;
			residents.TopLevel = false;
			residents.Parent = Panel2;
			residents.Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Panel2.Controls.Clear();
			teacher_view residents = new teacher_view();
			residents.ControlBox = false;
			residents.Text = "";
			residents.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			residents.Size = Panel2.Size;
			residents.TopLevel = false;
			residents.Parent = Panel2;
			residents.Show();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			Panel2.Controls.Clear();
			class_teachers residents = new class_teachers();
			residents.ControlBox = false;
			residents.Text = "";
			residents.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			residents.Size = Panel2.Size;
			residents.TopLevel = false;
			residents.Parent = Panel2;
			residents.Show();
		}


		private void teachers_main_Load(object sender, EventArgs e)
		{
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			Panel2.Controls.Clear();
			teachers_attendance residents = new teachers_attendance();
			residents.ControlBox = false;
			residents.Text = "";
			residents.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			residents.Size = Panel2.Size;
			residents.TopLevel = false;
			residents.Parent = Panel2;
			residents.Show();
		}
		public teachers_main()
		{
			Load += teachers_main_Load;
			InitializeComponent();
		}
	}
}
