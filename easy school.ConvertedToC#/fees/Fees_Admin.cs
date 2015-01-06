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
	public partial class Fees_Admin
	{

		private void AddNewFeesItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Panel1.Controls.Clear();
			type residents = new type();
			residents.Size = Panel1.Size;
			residents.TopLevel = false;
			residents.Parent = Panel1;
			residents.Show();
		}

		private void CreateOrModifyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Panel1.Controls.Clear();
			fees_rates residents = new fees_rates();
			residents.Size = Panel1.Size;
			residents.TopLevel = false;
			residents.Parent = Panel1;
			residents.Show();
		}

		private void BillToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Panel1.Controls.Clear();
			billing residents = new billing();
			residents.Size = Panel1.Size;
			residents.TopLevel = false;
			residents.Parent = Panel1;
			residents.Show();
		}


		private void Fees_Admin_Load(object sender, EventArgs e)
		{
		}

		private void BilllsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Panel1.Controls.Clear();
			bill_student residents = new bill_student();
			residents.Size = Panel1.Size;
			residents.TopLevel = false;
			residents.Parent = Panel1;
			residents.Show();
		}


		private void ProjectionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void YearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Panel1.Controls.Clear();
			report residents = new report();
			residents.Size = Panel1.Size;
			residents.TopLevel = false;
			residents.Parent = Panel1;
			residents.Show();
		}

		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Panel1.Controls.Clear();
			bill residents = new bill();
			residents.Size = Panel1.Size;
			residents.TopLevel = false;
			residents.Parent = Panel1;
			residents.Show();
		}
		public Fees_Admin()
		{
			Load += Fees_Admin_Load;
			InitializeComponent();
		}
	}
}
