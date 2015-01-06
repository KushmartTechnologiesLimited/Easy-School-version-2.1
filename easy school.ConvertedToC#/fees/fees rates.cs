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
	public partial class fees_rates
	{
		database data = new database();
		 level;
		List<string> feety = new List<string>();
		string lev;
		string cla;
		string ikk;
		private void fees_rates_Load(object sender, EventArgs e)
		{
			DataTable red = new DataTable();
			red = data.executeSQL("SELECT `code`,  `description` FROM `class` ORDER BY `level`");
			//subjects
			foreach (object drow_loopVariable in red.Rows) {
				drow = drow_loopVariable;
				ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper);
				level.Add(drow.Item(0).ToString.ToUpper);
			}
			DataTable red1 = new DataTable();
			red1 = data.executeSQL("SELECT `ID`, `Type_Name` FROM `type`");
			//subjects
			foreach (object drow_loopVariable in red1.Rows) {
				drow = drow_loopVariable;
				ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper);
				feety.Add(drow.Item(0).ToString.ToUpper);
			}

		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (CheckBox1.Checked == true) {
				int j = 0;
				foreach (string b in level) {
					data.@add(ref "INSERT INTO `rates`( `L_id`, `T_id`, `amount`) VALUES ('" + b + "','" + cla + "'," + TextBox1.Text + ")");
					j = j + 1;
				}
				DataTable ggf = null;
				ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates");
				DataGridView1.DataSource = ggf;
				int i = 0;
				int sum = 0;
				while (!(i == DataGridView1.Rows.Count)) {
					sum = sum + DataGridView1.Rows[i].Cells[3].Value;
					i = i + 1;
				}
				Label3.Text = "Total = Ksh " + sum;
				return;
			}

			//dsfgg
			if (string.IsNullOrEmpty(ComboBox1.Text) | ComboBox1.SelectedIndex < 0) {
				Interaction.MsgBox("data required", MsgBoxStyle.Information, "error");
				ComboBox1.Focus();
				return;
			} else {
				if (string.IsNullOrEmpty(ComboBox2.Text) | ComboBox2.SelectedIndex < 0) {
					Interaction.MsgBox("data required", MsgBoxStyle.Information, "error");
					ComboBox2.Focus();
					return;
				} else {
					if (string.IsNullOrEmpty(TextBox1.Text)) {
						Interaction.MsgBox("data required", MsgBoxStyle.Information, "error");
						TextBox1.Focus();
						return;
					} else {
						data.@add(ref "INSERT INTO `rates`( `L_id`, `T_id`, `amount`) VALUES ('" + lev + "','" + cla + "'," + TextBox1.Text + ")");
						DataTable ggf = null;
						ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" + lev);
						DataGridView1.DataSource = ggf;
						int i = 0;
						int sum = 0;
						while (!(i == DataGridView1.Rows.Count)) {
							sum = sum + DataGridView1.Rows[i].Cells[3].Value;
							i = i + 1;
						}
						Label3.Text = "Total = Ksh " + sum;
					}
				}
			}
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			lev = level(ComboBox1.SelectedIndex);
			DataTable ggf = null;
			ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" + lev);
			DataGridView1.DataSource = ggf;
			int i = 0;
			int sum = 0;
			while (!(i == DataGridView1.Rows.Count)) {
				sum = sum + DataGridView1.Rows[i].Cells[3].Value;
				i = i + 1;
			}
			Label3.Text = "Total = Ksh " + sum;
		}

		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			cla = feety[ComboBox2.SelectedIndex];
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			int i = 0;
			string h = null;
			if (Button3.Text == "Save") {
				data.@add(ref "UPDATE `rates` SET `amount`=" + TextBox1.Text + " WHERE `ID`=" + ikk);
				ComboBox1.Text = "";
				ComboBox2.Text = "";
				TextBox1.Text = "";
				ComboBox1.Enabled = true;
				ComboBox2.Enabled = true;
				Button3.Text = "&Modify F3";
				Button2.Enabled = true;
				lev = level(ComboBox1.SelectedIndex);
				DataTable ggf = null;
				ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" + lev);
				DataGridView1.DataSource = ggf;
				int j = 0;
				int sum = 0;
				while (!(j == DataGridView1.Rows.Count)) {
					sum = sum + DataGridView1.Rows[i].Cells[3].Value;
					j = j + 1;
				}
				Label3.Text = "Total = Ksh " + sum;
				return;
			}
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with1 = DataGridView1;
				h = _with1.Item(0, i).Value;
				ikk = h;
				ComboBox1.Text = _with1.Item(1, i).Value;
				ComboBox2.Text = _with1.Item(2, i).Value;
				TextBox1.Text = _with1.Item(3, i).Value;
				ComboBox1.Enabled = false;
				ComboBox2.Enabled = false;
				Button3.Text = "Save";
				Button2.Enabled = false;
			}

		}

		private void Button6_Click(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			lev = level(ComboBox1.SelectedIndex);
			DataTable ggf = null;
			ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" + lev);
			DataGridView1.DataSource = ggf;
			int i = 0;
			int sum = 0;
			while (!(i == DataGridView1.Rows.Count)) {
				sum = sum + DataGridView1.Rows[i].Cells[3].Value;
				i = i + 1;
			}
			Label3.Text = "Total = Ksh " + sum;
		}

		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);
		}


		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			int i = 0;
			string h = null;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with2 = DataGridView1;
				h = _with2.Item(0, i).Value;
				if (Interaction.MsgBox(" are you sure you want to delete" + Constants.vbCrLf + _with2.Item(1, i).Value + " " + _with2.Item(2, i).Value, Constants.vbYesNo, "confirm") == Constants.vbYes) {
					data.delete("DELETE FROM `rates` WHERE `ID`=" + h);
					lev = level(ComboBox1.SelectedIndex);
					DataTable ggf = null;
					ggf = data.executeSQL("SELECT ID, (SELECT description FROM class WHERE code=rates.L_id)'Class', (SELECT Type_Name FROM type WHERE  ID=rates.T_id)'Type', amount FROM rates WHERE rates.L_id =" + lev);
					DataGridView1.DataSource = ggf;
				}
			}
		}



		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBox1.Checked == true) {
				ComboBox1.Enabled = false;
			} else {
				ComboBox1.Enabled = true;
			}
		}
		public fees_rates()
		{
			Load += fees_rates_Load;
			InitializeComponent();
		}
	}
}
