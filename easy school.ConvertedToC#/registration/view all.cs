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
	public partial class view_all
	{
		database data = new database();
		 class_id;
		List<string> str_id = new List<string>();
		string cl = 0;
		string strm = 0;
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			cl = class_id(ComboBox1.SelectedIndex);
			strm = str_id[ComboBox2.SelectedIndex];
			Strings.Filter();
		}

		private void TextBox1_KeyUp(object sender, KeyEventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			if (TextBox1.TextLength > 0) {
				DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered','TEL','Class','Stream' FROM `students`   WHERE  `admno` regexp '" + TextBox1.Text + "' or ` names` regexp '" + TextBox1.Text + "'");
			}
		}
		private void TextBox1_LostFocus(object sender, EventArgs e)
		{
			//    TextBox1.Focus()
		}
		public void filter()
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE `class_code`=" + cl + " and `str_code`= " + strm);
		}

		private void view_all_Load(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			DataTable rd = null;
			DataTable rd1 = null;
			rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`");
			rd1 = data.executeSQL("SELECT code, name FROM stream");
			foreach (object drow_loopVariable in rd.Rows) {
				drow = drow_loopVariable;
				ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper);
				class_id.Add(drow.Item(0).ToString.ToUpper);
			}
			foreach (object drow_loopVariable in rd1.Rows) {
				drow = drow_loopVariable;
				ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper);
				str_id.Add(drow.Item(0).ToString.ToUpper);
			}
			ComboBox1.SelectedItem = 1;
			ComboBox2.SelectedItem = 1;

			DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE 1");
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			new_student neww = new new_student();
			neww.ShowDialog();
			DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE 1");

		}

		private void Button3_Click(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			int i = 0;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with1 = DataGridView1;
				string ITEM = null;
				ITEM = DataGridView1[0, i].Value;
				profile editt = new profile();
				editt.TextBox26.Text = ITEM;
				editt.Button9.PerformClick();
				editt.ShowDialog();
			}
			DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE 1");

		}


		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement


			if (TextBox1.TextLength > 0) {
				DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE `admno` regexp '" + TextBox1.Text + "' or ` names` regexp '" + TextBox1.Text + "'");
			}
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = 0;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with2 = DataGridView1;
				string ITEM = null;
				ITEM = DataGridView1[0, i].Value;
				profile editt = new profile();
				editt.TextBox26.Text = ITEM;
				editt.Button9.PerformClick();
				editt.ShowDialog();
			}
		}


		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			cl = class_id(ComboBox1.SelectedIndex);
			strm = str_id[ComboBox2.SelectedIndex];
			Strings.Filter();
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			DataGridView1.DataSource = data.executeSQL("SELECT `admno`'ADM NO', ` names`'Names', `gender`'Gender', `DOB`'Date of Birth', `Birthno`'Birth Certifate No', `adm_date`'Date registered',(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE 1");

		}

		private void Button6_Click(object sender, EventArgs e)
		{
			collect_fees fee = new collect_fees();
			int i = 0;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with3 = DataGridView1;
				string ITEM = null;
				ITEM = DataGridView1[0, i].Value;
				fee.TextBox1.Text = ITEM;
				fee.TextBox1.ReadOnly = true;
				Button1.Visible = false;
				fee.ShowDialog();
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Fees_Admin adm = new Fees_Admin();
			adm.ShowDialog();
		}


		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}
		public view_all()
		{
			Load += view_all_Load;
			InitializeComponent();
		}
	}
}
