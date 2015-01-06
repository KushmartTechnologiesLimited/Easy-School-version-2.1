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
	public partial class bill
	{
		database data = new database();
		List<string> class_id = new List<string>();
		string adm;
		int first;
		int last;
		int current_class;

		int current;
		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButton1.Checked == true) {
				Panel2.Visible = true;
			} else {
				Panel2.Visible = false;
			}
		}

		private void bill_Load(object sender, EventArgs e)
		{
			DataTable rd = null;
			rd = data.executeSQL("SELECT code,description,level  FROM class ORDER BY `level`");
			foreach (object drow_loopVariable in rd.Rows) {
				drow = drow_loopVariable;
				ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper);
				ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper);
				class_id.Add(drow.Item(2).ToString.ToUpper);

			}
			ComboBox1.SelectedIndex = (0);
			ComboBox2.SelectedIndex = rd.Rows.Count - 1;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (Button2.Text == "Set") {
				first = class_id[ComboBox1.SelectedIndex];
				last = class_id[ComboBox2.SelectedIndex];
				if (first >= last) {
					Interaction.MsgBox("invalid selection", MsgBoxStyle.Information, "error");
					return;
				}
				//MsgBox("first class is " & first & " and last class is " & last)
				ComboBox1.Enabled = false;
				ComboBox2.Enabled = false;
				Button2.Text = "Reset";
				Panel1.Enabled = true;
			} else if (Button2.Text == "Reset") {
				ComboBox1.Enabled = true;
				ComboBox2.Enabled = true;
				Button2.Text = "Set";
				Panel1.Enabled = false;
			}

		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox4.Text)) {
				return;
			}
			TextBox1.Text = "";
			TextBox2.Text = "";
			TextBox3.Text = "";
			DataTable red = null;
			red = data.executeSQL("SELECT `admno`, ` names`,(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  class.level FROM class WHERE class.code=`class_code`)'CLass' FROM `students` WHERE `admno`=" + TextBox4.Text);
			if (red.Rows.Count < 1) {
				Interaction.MsgBox("No Record found!!!", MsgBoxStyle.Information, "   Message");
				//TextBox4.Text = ""
				TextBox4.Focus();
				return;
			}
			foreach (object drow_loopVariable in red.Rows) {
				drow = drow_loopVariable;
				TextBox1.Text = drow.Item(1).ToString.ToUpper;
				TextBox2.Text = drow.Item(0).ToString.ToUpper;
				TextBox3.Text = drow.Item(2).ToString.ToUpper;
				current_class = drow.Item(3);
				adm = drow.Item(0).ToString.ToUpper;
				TextBox4.Focus();
			}
		}

		private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			string sql = null;
			current = current_class - 1;
			if (current < first | current > last) {
				Interaction.MsgBox("Opperation not Allowed!", MsgBoxStyle.Information, "Error");
				return;
			}
			sql = "UPDATE `students` SET `class_code`=(SELECT `code` FROM `class` WHERE `level`=" + current + ") WHERE `admno`=" + adm;
			data.@add(ref sql);
			Button3.PerformClick();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			string sql = null;
			current = current_class + 1;
			if (current < first | current > last) {
				Interaction.MsgBox("Opperation not Allowed!", MsgBoxStyle.Information, "Error");
				return;
			}
			sql = "UPDATE `students` SET `class_code`=(SELECT `code` FROM `class` WHERE `level`=" + current + ") WHERE `admno`=" + adm;
			data.@add(ref sql);
			Button3.PerformClick();
		}


		private void Button5_Click(object sender, EventArgs e)
		{
			DataTable red = null;
			string sql = null;
			red = data.executeSQL("SELECT `admno`, ` names`,(SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  class.level FROM class WHERE class.code=`class_code`)'CLass' FROM `students` WHERE status=1");
			if (red.Rows.Count < 1) {
				Interaction.MsgBox("No Record found!!!", MsgBoxStyle.Information, "   Message");
				return;
			} else {
				foreach (object drow_loopVariable in red.Rows) {
					drow = drow_loopVariable;
					current_class = drow.Item(3);
					adm = drow.Item(0).ToString.ToUpper;

					current = current_class + 1;
					if (current > last) {
						sql = "UPDATE `students` SET status=0  WHERE `admno`=" + adm;
						data.add1(sql);
					} else {
						sql = "UPDATE `students` SET `class_code`=(SELECT `code` FROM `class` WHERE `level`=" + current + ") WHERE `admno`=" + adm;
						data.add1(sql);
					}

				}
				Interaction.MsgBox("Operation Completed !!", MsgBoxStyle.Information, " Message");
			}
		}
	}
}
