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
	public partial class class_assgn
	{
		database data = new database();
		 class_id;
		 teacher_id;
		 str_id;
		List<string> picha = new List<string>();
		private void LV_PatiView_SelectedIndexChanged(object sender, EventArgs e)
		{
			System.Windows.Forms.ListView.SelectedListViewItemCollection SelectedItems = ((ListView)sender).SelectedItems;
			if ((SelectedItems.Count > 0)) {
				ComboBox1.Text = SelectedItems[0].SubItems[0].Text;
				ComboBox2.Text = SelectedItems[0].SubItems[1].Text;
				ComboBox3.Text = SelectedItems[0].SubItems[2].Text;
				Button2.Hide();
			}
		}
		private void class_assgn_Load(object sender, EventArgs e)
		{
			refe();
			int i = 0;
			int j = 0;
			int k = 0;
			DataTable red = null;
			DataTable red1 = null;
			DataTable red2 = null;
			red = data.executeSQL("SELECT `national_id`, `name`,`pic` FROM `teachers`");
			//teachers
			foreach (object drow_loopVariable in red.Rows) {
				drow = drow_loopVariable;
				ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper);
				teacher_id.Add(drow.Item(0).ToString.ToUpper);
				picha.Add(drow.Item(2).ToString.ToUpper);
			}
			red2 = data.executeSQL("SELECT `code`, `level` FROM `class` ");
			//class
			foreach (object drow_loopVariable in red2.Rows) {
				drow = drow_loopVariable;
				ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper);
				class_id.Add(drow.Item(0).ToString.ToUpper);
			}
			red1 = data.executeSQL("SELECT `code`, `name` FROM `stream`");
			//streamms
			foreach (object drow_loopVariable in red1.Rows) {
				drow = drow_loopVariable;
				ComboBox3.Items.Add(drow.Item(1).ToString.ToUpper);
				str_id.Add(drow.Item(0).ToString.ToUpper);
			}
		}


		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Label5.Text = teacher_id(ComboBox1.SelectedIndex);
			try {
				PictureBox1.ImageLocation = picha[ComboBox1.SelectedIndex];
			} catch (Exception ex) {
				PictureBox1.Image.Dispose();
			}



		}

		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			Label5.Text = class_id(ComboBox2.SelectedIndex);
		}

		private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			Label5.Text = str_id(ComboBox3.SelectedIndex);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			string sql = null;
			string tr = null;
			string cl = null;
			string str = null;
			if (string.IsNullOrEmpty(ComboBox1.Text)) {
				Interaction.MsgBox("seletct a teacher", MsgBoxStyle.Information, "incorrect data");
			} else {
				tr = teacher_id(ComboBox1.SelectedIndex);
				if (string.IsNullOrEmpty(ComboBox2.Text)) {
					Interaction.MsgBox("seletct a class", MsgBoxStyle.Information, "incorrect data");
				} else {
					cl = class_id(ComboBox2.SelectedIndex);
					if (string.IsNullOrEmpty(ComboBox3.Text)) {
						Interaction.MsgBox("seletct a Stream", MsgBoxStyle.Information, "incorrect data");
					} else {
						ComboBox3.SelectedIndex = 0;
						str = str_id(ComboBox3.SelectedIndex);
						sql = "INSERT INTO `class_teacher`(`national_id`, `class_code`, `stream_code`) VALUES (" + tr + ", " + cl + "," + str + ")";
						data.@add(ref sql);
					}
				}
			}

			refe();
		}
		public void refe()
		{
			DataTable led = null;
			led = data.executeSQL("SELECT (select name from teachers where national_id=class_teacher.national_id) as NAMES,(SELECT level FROM class where code=class_teacher.class_code) as Class,(SELECT  name FROM stream WHERE class_teacher.stream_code =code) as Stream FROM class_teacher ");
			//teachers
			DataGridView1.DataSource = led;
		}


		private void Panel5_Paint(object sender, PaintEventArgs e)
		{
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = 0;
			string h = null;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with1 = DataGridView1;
				ComboBox1.Text = _with1.Item(0, i).Value;
				ComboBox2.Text = _with1.Item(1, i).Value;
				ComboBox3.Text = _with1.Item(2, i).Value;
				Button2.Enabled = false;
				Panel6.Enabled = true;
			}

		}

		private void Button7_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void DataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			int i = 0;
			string h = null;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with2 = DataGridView1;
				ComboBox1.Text = _with2.Item(0, i).Value;
				ComboBox2.Text = _with2.Item(1, i).Value;
				ComboBox3.Text = _with2.Item(2, i).Value;
				//Button2.Enabled = False
				//Panel6.Enabled = True
			}
		}

		private void Button6_Click_1(object sender, EventArgs e)
		{
			refe();
			//Button2.Enabled = True
			//Panel6.Enabled = False
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			if ((Interaction.MsgBox("are you sure you want to delete" + Constants.vbCrLf + "   TEACHER: " + ComboBox1.Text + Constants.vbCrLf + "    CLASS: " + ComboBox2.Text + Constants.vbCrLf + "    STREAM:  " + ComboBox3.Text, MsgBoxStyle.YesNo, "confirm") == MsgBoxResult.Yes)) {
				string FF = null;
				FF = "DELETE FROM `class_teacher` WHERE `national_id`=" + teacher_id(ComboBox1.SelectedIndex) + " AND `class_code`=" + class_id(ComboBox2.SelectedIndex) + " AND `stream_code`=" + str_id(ComboBox3.SelectedIndex);
				data.delete(FF);
			}
			refe();
		}
		public class_assgn()
		{
			Load += class_assgn_Load;
			InitializeComponent();
		}
	}
}
