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
	public partial class type
	{
		database data = new database();
		private void type_Load(object sender, EventArgs e)
		{
			DataTable @ref = new DataTable();
			@ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ");
			DataGridView1.DataSource = @ref;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox2.Text)) {
				Interaction.MsgBox("data required  ", MsgBoxStyle.Information, "error");
				return;
			} else {
				data.@add(ref "INSERT INTO `type`(`Type_Name`, `category`) VALUES ('" + TextBox2.Text + "','" + ComboBox1.Text + "')");
				TextBox1.Text = "";
				TextBox2.Text = "";
				ComboBox1.Text = "";
				DataTable @ref = new DataTable();
				@ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ");
				DataGridView1.DataSource = @ref;
			}

		}

		private void Button3_Click(object sender, EventArgs e)
		{
			int i = 0;
			string h = null;
			if (Button3.Text == "save") {
				data.@add(ref "UPDATE `type` SET `Type_Name`='" + TextBox2.Text + "',`category`='" + ComboBox1.Text + "'  WHERE  `ID`=" + TextBox1.Text);
				Button3.Text = "&Modify";
				Button2.Enabled = true;
				TextBox1.Text = "";
				TextBox2.Text = "";
				DataTable @ref = new DataTable();
				@ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ");
				DataGridView1.DataSource = @ref;
				return;
			}
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with1 = DataGridView1;
				h = _with1.Item(0, i).Value;
				TextBox1.Text = h;
				TextBox2.Text = _with1.Item(1, i).Value;
				ComboBox1.Text = _with1.Item(2, i).Value;
				Button3.Text = "save";
				Button2.Enabled = false;
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			int i = 0;
			string h = null;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with2 = DataGridView1;
				h = _with2.Item(0, i).Value;
				if (Interaction.MsgBox(" are you sure you want to delete" + Constants.vbCrLf + _with2.Item(1, i).Value, Constants.vbYesNo, "confirm") == Constants.vbYes) {
					data.delete("DELETE FROM `type` WHERE `ID`=" + h);
					DataTable @ref = new DataTable();
					@ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ");
					DataGridView1.DataSource = @ref;
				}
			}
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			DataTable @ref = new DataTable();
			@ref = data.executeSQL("SELECT `ID`, `Type_Name`, `category` FROM `type` ");
			DataGridView1.DataSource = @ref;
		}

		private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}


		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}
	}
}
