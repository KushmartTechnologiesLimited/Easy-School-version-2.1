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
	public partial class report
	{
		database data = new database();
		DataTable red = new DataTable();
		List<string> class_id = new List<string>();
		private void report_Load(object sender, EventArgs e)
		{
			DataTable rd = null;
			rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`");
			foreach (object drow_loopVariable in rd.Rows) {
				drow = drow_loopVariable;
				ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper);
				class_id.Add(drow.Item(0).ToString.ToUpper);
			}
			red = data.executeSQL("SELECT `fees_id`'Receipt No',students.Admno'Adm No',` names`, `Details`, `Method`, `acc_Name`, `Acc_no`, `amount`, `payable`, `balance` FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and balance>0 and `fees accounting`.status=0");
			DataGridView1.DataSource = red;
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			if (TextBox1.TextLength > 0) {
				red = data.executeSQL("SELECT  `fees_id`'Receipt No',students.Admno'Adm No', ` names`, `Details`, `Method`, `acc_Name`, `Acc_no`, `amount`, `payable`, `balance` FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and `students`.`admno` regexp '" + TextBox1.Text + "' or `students`.` names` regexp '" + TextBox1.Text + "' limit 50");
				DataGridView1.DataSource = red;
			}
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ComboBox1.SelectedIndex > -1) {
				red = data.executeSQL("SELECT  `fees_id`'Receipt No',students.Admno'Adm No', ` names`, `Details`, `Method`, `acc_Name`, `Acc_no`, `amount`, `payable`, `balance` FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and `students`.`class_code` = '" + class_id[ComboBox1.SelectedIndex] + "' and balance>0 and `fees accounting`.status=0");
				DataGridView1.DataSource = red;
				DataTable red2 = null;

				if (red.Rows.Count > 0) {
					string gg1 = "SELECT sum(`amount`)  FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and `students`.`class_code` = '" + class_id[ComboBox1.SelectedIndex] + "' and balance>0 and `fees accounting`.status=0";
					red2 = data.executeSQL(gg1);
					Label6.Text = red2.Rows[0][0].ToString();
				} else {
					Label6.Text = 0;
				}
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			string gg = "SELECT `fees_id`'Receipt No',students.Admno'Adm No',` names`, `Details`, `Method`, `acc_Name`, `Acc_no`, `amount`, `payable`, `balance` FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and DATE_FORMAT(  `Datestamp` ,  '%d-%m-%Y' ) = '" + DateTimePicker1.Value.ToString("dd-MM-yyyy") + "'";
			red = data.executeSQL(gg);
			DataGridView1.DataSource = red;
			DataGridView1.Columns[0].Visible = false;
			DataTable red2 = null;

			if (red.Rows.Count > 0) {
				string gg1 = "SELECT sum(`amount`)  FROM students,`fees accounting` WHERE  `students`.`admno`=`fees accounting`.`admno` and DATE_FORMAT(  `Datestamp` ,  '%d-%m-%Y' ) = '" + DateTimePicker1.Value.ToString("dd-MM-yyyy") + "'";
				red2 = data.executeSQL(gg1);
				Label6.Text = red2.Rows[0][0].ToString();
			} else {
				Label6.Text = 0;
			}

		}
		public report()
		{
			Load += report_Load;
			InitializeComponent();
		}
	}
}
