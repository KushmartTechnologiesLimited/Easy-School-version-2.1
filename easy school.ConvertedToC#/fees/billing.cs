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
	public partial class billing
	{
		database data = new database();

		List<string> cls = new List<string>();
		private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
		{
			e.Handled = true;
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Label3.Text = "Fees Strucure for  " + ComboBox1.Text;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(ComboBox1.Text)) {
				Interaction.MsgBox("select a class", MsgBoxStyle.Information, "error");
				ComboBox1.Focus();
				return;
			}
			string lev = null;
			lev = cls[ComboBox1.SelectedIndex];
			int o = 0;
			int sum = 0;
			DataTable red = null;
			red = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly' ) and `L_id`='" + lev + "'");
			DataGridView1.DataSource = red;
			while (!(o == red.Rows.Count)) {
				sum = sum + red.Rows[o][1].ToString();
				o = o + 1;
			}
			TextBox8.Text = sum;
			int oo = 0;
			int sumo = 0;
			DataTable redo = null;
			redo = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' ) and `L_id`='" + lev + "'");
			DataGridView2.DataSource = redo;
			while (!(oo == redo.Rows.Count)) {
				sumo = sumo + redo.Rows[oo][1].ToString();
				oo = oo + 1;
			}
			TextBox1.Text = sumo;
			int ooo = 0;
			int sumoo = 0;
			DataTable redoo = null;
			redoo = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" + lev + "'");
			DataGridView3.DataSource = redoo;
			while (!(ooo == redoo.Rows.Count)) {
				sumoo = sumoo + redoo.Rows[ooo][1].ToString();
				ooo = ooo + 1;
			}
			TextBox2.Text = sumoo;

			int i = 0;
			int sm = 0;
			DataTable rd = null;
			rd = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='registration') and `L_id`='" + lev + "'");
			while (!(i == rd.Rows.Count)) {
				sm = sm + rd.Rows[i][1].ToString();
				i = i + 1;
			}
			TextBox5.Text = sm;
			TextBox4.Text = sum + sumo + sumoo;
		}

		private void billing_Load(object sender, EventArgs e)
		{
			DataTable ff = null;
			int k = 0;
			ff = data.executeSQL("SELECT code,description FROM class ORDER BY `level`");
			foreach (object drow_loopVariable in ff.Rows) {
				drow = drow_loopVariable;
				ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper);
				cls.Add(drow.Item(0).ToString.ToUpper);
			}
		}


		private void Label2_Click(object sender, EventArgs e)
		{
		}
		public billing()
		{
			Load += billing_Load;
			InitializeComponent();
		}
	}
}
