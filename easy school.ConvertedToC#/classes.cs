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
	public partial class classes
	{
		database data = new database();
		DataTable red;
		DataTable red1;
		DataTable red3;
		private void classes_Load(object sender, EventArgs e)
		{
			My.MyProject.Forms.view_all.Close();
			red = data.executeSQL("SELECT `code`, `level`, `Description` FROM `class` ORDER BY `level`");
			DataGridView2.DataSource = red;
			red1 = data.executeSQL("SELECT `code`, `name`, `strm_ids` FROM `stream`");
			DataGridView1.DataSource = red1;
			red3 = data.executeSQL("SELECT `code`,`name`  FROM `subject` ORDER BY `code`");
			DataGridView3.DataSource = red3;
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox3.Text) | string.IsNullOrEmpty(TextBox4.Text)) {
				Interaction.MsgBox("Data requied", MsgBoxStyle.Information, "error");
				return;
			} else {
				data.@add(ref "INSERT INTO `class`(`level`, `Description`) VALUES ('" + TextBox3.Text + "','" + TextBox4.Text + "')");
				red = data.executeSQL("SELECT `code`, `level`, `Description` FROM `class` ORDER BY `level`");
				clear();
				DataGridView2.DataSource = red;
			}
		}
		private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);
		}


		private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
		}
		public void clear()
		{
			TextBox1.Text = "";
			TextBox2.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox5.Text = "";
			TextBox6.Text = "";
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox2.Text)) {
				Interaction.MsgBox("Data requied", MsgBoxStyle.Information, "error");
				return;
			} else {
				data.@add(ref "INSERT INTO `stream`( `name`) VALUES ('" + TextBox2.Text + "')");
				red1 = data.executeSQL("SELECT `code`, `name`, `strm_ids` FROM `stream`");
				clear();
				DataGridView1.DataSource = red1;
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox5.Text) | string.IsNullOrEmpty(TextBox6.Text)) {
				Interaction.MsgBox("Data requied", MsgBoxStyle.Information, "error");
				return;
			} else {
				data.@add(ref "INSERT INTO `schoolfees`.`subject` (`code`, `name`, `description`, `id`, `type_id`) VALUES ('" + TextBox5.Text + "', '" + TextBox6.Text + "', NULL, NULL, '1');");
				//data.add("INSERT INTO `class`(`level`, `Description`) VALUES ('" & TextBox5.Text & "','" & TextBox6.Text & "')")
				red3 = data.executeSQL("SELECT `code`,`name`  FROM `subject` ORDER BY `code`");
				clear();
				DataGridView3.DataSource = red3;
			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			int i = 0;
			string ittem = null;
			if (DataGridView2.RowCount > 0) {
				i = DataGridView2.CurrentRow.Index;
				var _with1 = DataGridView2;
				ittem = DataGridView2[0, i].Value;


				if ((Interaction.MsgBox("are you sure you want to delete this record ", MsgBoxStyle.YesNo, "confirm") == MsgBoxResult.Yes)) {
					string FF = null;
					FF = "DELETE FROM `class` WHERE `code`=" + ittem;
					data.delete(FF);
				}
				red = data.executeSQL("SELECT `code`, `level`, `Description` FROM `class` ORDER BY `level`");
				DataGridView2.DataSource = red;
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			int i = 0;
			string ittem = null;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with2 = DataGridView1;
				ittem = DataGridView1[0, i].Value;

				if ((Interaction.MsgBox("are you sure you want to delete this record ", MsgBoxStyle.YesNo, "confirm") == MsgBoxResult.Yes)) {
					string FF = null;
					FF = "DELETE FROM `stream` WHERE `code`=" + ittem;
					data.delete(FF);
				}
				red1 = data.executeSQL("SELECT `code`, `name`, `strm_ids` FROM `stream`");
				DataGridView1.DataSource = red1;
			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			int i = 0;
			string ittem = null;
			if (DataGridView3.RowCount > 0) {
				i = DataGridView3.CurrentRow.Index;
				var _with3 = DataGridView3;
				ittem = DataGridView3[0, i].Value;
				if ((Interaction.MsgBox("are you sure you want to delete this record ", MsgBoxStyle.YesNo, "confirm") == MsgBoxResult.Yes)) {
					string FF = null;
					FF = "DELETE FROM `subject` WHERE `code`=" + ittem;
					data.delete(FF);
				}
				red3 = data.executeSQL("SELECT `code`,`name`  FROM `subject` ORDER BY `code`");
				DataGridView3.DataSource = red3;
			}

		}
		public classes()
		{
			Load += classes_Load;
			InitializeComponent();
		}
	}
}
