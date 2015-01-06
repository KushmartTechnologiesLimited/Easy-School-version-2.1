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
	public partial class class_teachers
	{
		database data = new database();
		string ids;
		 class_id;
		List<string> str_id = new List<string>();
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			ListBox1.Items.Clear();
			string searchsql = null;
			if (TextBox1.TextLength > 0) {
				searchsql = "SELECT  `name` FROM `teachers` where `name` regexp  '" + TextBox1.Text + "' or `national_id` regexp '" + TextBox1.Text + "'";
				data.poplist(ref ListBox1, searchsql);
			}
		}
		private void filldata()
		{
			ids = "";
			try {
				string cc = null;
				DataTable red = null;
				cc = "SELECT  `name`, `qualification`, `institution`,`national_id` FROM `teachers` WHERE `name`='" + ListBox1.SelectedItem.ToString() + "'";
				red = data.executeSQL(cc);
				foreach (object drow_loopVariable in red.Rows) {
					drow = drow_loopVariable;
					TextBox4.Text = drow.Item(0).ToString.ToUpper;
					TextBox8.Text = drow.Item(1).ToString.ToUpper;
					TextBox3.Text = drow.Item(2).ToString.ToUpper;
					ids = drow.Item(3).ToString.ToUpper;
				}

			} catch (Exception ex) {
			}
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			filldata();
		}

		private void class_teachers_Load(object sender, EventArgs e)
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
			//data.populateDDList(ComboBox1, "SELECT  `level` FROM `class` ")
			//data.populateDDList(ComboBox2, "SELECT  `name` FROM `stream`")
			DataTable led = null;
			led = data.executeSQL("SELECT `code`, `name` FROM `subject` WHERE 1 ");
			DataGridView1.DataSource = led;
			DataGridView1.Columns[0].Visible = false;
			string nn = null;
			nn = "SELECT  `name` FROM `teachers` ";
			data.poplist(ref ListBox1, nn);
			// data.poplist(ListBox2, "SELECT `name` FROM `subject` ")
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			string ssql = null;
			string ss = null;
			ssql = "INSERT INTO `schoolfees`.`desinate` (`d_no`, `tr_id_no`, `sub_code`, `class_code`, `str_code`, `updatetime`)   VALUES (NULL, '" + ids + "', '" + DataGridView1[0, DataGridView1.CurrentRow.Index].Value.ToString() + "', '" + class_id(ComboBox1.SelectedIndex) + "', '" + str_id[ComboBox2.SelectedIndex] + "', CURRENT_TIMESTAMP);";
			ss = "UPDATE `desinate` SET `tr_id_no`='" + ids + "' where `sub_code`='" + DataGridView1[0, DataGridView1.CurrentRow.Index].Value.ToString() + "' and `class_code`='" + class_id(ComboBox1.SelectedIndex) + "' and `str_code`='" + str_id[ComboBox2.SelectedIndex] + "'";
			data.dd(ref ssql, ref ss);
			goo();
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			goo();
		}
		public void goo()
		{
			string sql = null;
			try {
				sql = "SELECT `d_no`, (SELECT `name` FROM `teachers` WHERE `national_id`=`tr_id_no`)'Teacher',(SELECT  `name` FROM `subject` WHERE  code=`sub_code`)'subject'  FROM `desinate` where `class_code`='" + class_id(ComboBox1.SelectedIndex) + "' and `str_code`='" + str_id[ComboBox2.SelectedIndex] + "'";
				DataTable redd = null;
				redd = data.executeSQL(sql);
				DataGridView2.DataSource = redd;
				DataGridView2.Columns[0].Visible = false;
			} catch (Exception ex) {
			}
		}

		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			goo();
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			int i = 0;
			string h = null;
			if (DataGridView2.RowCount > 0) {
				i = DataGridView2.CurrentRow.Index;
				var _with1 = DataGridView2;
				h = _with1.Item(0, i).Value;
				if (Interaction.MsgBox("are you sure you want to delete the record", MsgBoxStyle.YesNo, "confirm") == MsgBoxResult.Yes) {
					try {
						studentsdatabase data = new studentsdatabase();
						data.delete("DELETE FROM `desinate` WHERE  `d_no`=" + h);
						goo();
					} catch (Exception ex) {
					}
				}
			}
		}
		public class_teachers()
		{
			Load += class_teachers_Load;
			InitializeComponent();
		}

	}
}
