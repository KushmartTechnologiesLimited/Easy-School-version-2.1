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
	public partial class edit_students
	{
		studentsdatabase data = new studentsdatabase();
		 class_id;
		List<string> str_id = new List<string>();

		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		private void edit_students_Load(object sender, EventArgs e)
		{
			DataTable rd = null;
			DataTable rd1 = null;
			DataTable red = null;
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
			red = data.executeSQL("SELECT `admno`, ` names`, `gender`,`DOB`, `Birthno`, (SELECT  class.description FROM class WHERE class.code=`class_code`),(SELECT  stream.name FROM stream WHERE stream.code=str_code ) FROM `students` WHERE `admno`=" + TextBox1.Text);
			foreach (object drow_loopVariable in red.Rows) {
				drow = drow_loopVariable;
				TextBox2.Text = drow.Item(1).ToString.ToUpper;
				ComboBox3.Text = drow.Item(2).ToString.ToUpper;
				DateTimePicker1.Value = drow.Item(3).ToString;
				TextBox4.Text = drow.Item(4).ToString.ToUpper;
				ComboBox1.Text = drow.Item(5).ToString.ToUpper;
				ComboBox2.Text = drow.Item(6).ToString.ToUpper;
			}
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			string sql = null;
			sql = "UPDATE `students` SET ` names`='" + TextBox2.Text + "',`gender`='" + ComboBox3.Text + "',`DOB`='" + DateTimePicker1.Value.ToString("yyyy-MM-dd") + "',`Birthno`='" + TextBox4.Text + "',`class_code`= (SELECT `code`  FROM `class` WHERE `Description`='" + ComboBox1.Text + "'),`str_code`=(SELECT `code` FROM `stream` WHERE `name`='" + ComboBox2.Text + "' ) WHERE `admno`=" + TextBox1.Text;
			data.update(sql);
			this.Close();
		}

		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}

		private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);
		}


		private void TextBox4_TextChanged(object sender, EventArgs e)
		{

		}


		private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
		public edit_students()
		{
			Load += edit_students_Load;
			InitializeComponent();
		}
	}
}
