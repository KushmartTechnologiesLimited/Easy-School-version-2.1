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
	public partial class teachers_attendance
	{
		private void Button1_Click(object sender, EventArgs e)
		{
			int j = 0;
			int i = 0;
			j = DataGridView1.RowCount;
			if (j < 0) {
				return;
			}
			for (i = 0; i <= j - 1; i++) {
				DataGridView1.Rows[i].Cells["status"].Value = true;
				DataGridView1.Rows[i].Cells["status1"].Value = true;
			}
		}

		private void teachers_attendance_Load(object sender, EventArgs e)
		{
			Label2.Text = DateTimePicker1.Value.ToString("dddd dd MM yyyy");
			database data = new database();
			DataTable red = null;
			red = data.executeSQL("SELECT `name`,`national_id` FROM `teachers` ");
			DataGridView1.DataSource = red;
			var addcolumn = null;
			DataGridViewCheckBoxColumn addcolumn1 = new DataGridViewCheckBoxColumn();
			DataGridViewComboBoxColumn reson = new DataGridViewComboBoxColumn();
			var _with1 = addcolumn;
			_with1.HeaderText = "Morning";
			_with1.Name = "status";
			_with1.Width = 20;
			_with1.ReadOnly = false;
			var _with2 = addcolumn1;
			_with2.HeaderText = "Afternoon";
			_with2.Name = "status1";
			_with2.Width = 20;
			_with2.ReadOnly = false;
			var _with3 = reson;
			_with3.HeaderText = "reason";
			_with3.Name = "reason";
			_with3.Width = 40;
			_with3.Items.Add("");
			_with3.Items.Add("permissioned");
			_with3.Items.Add("not permissioned");
			_with3.Items.Add("sick");
			DataGridView1.Columns.Insert(2, addcolumn);
			DataGridView1.Columns.Insert(3, addcolumn1);
			DataGridView1.Columns.Insert(4, reson);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			int j = 0;
			int i = 0;
			j = DataGridView1.RowCount;
			if (j < 0) {
				return;
			}
			for (i = 0; i <= j - 1; i++) {
				DataGridView1.Rows[i].Cells["status"].Value = false;
				DataGridView1.Rows[i].Cells["status1"].Value = false;
			}
		}
		private void Button3_Click(object sender, EventArgs e)
		{
			database data = new database();
			int j = 0;
			int i = 0;
			string id = null;
			string stats = null;
			string stats1 = null;
			string reason = null;
			string sql = null;
			string sql1 = null;
			string atdate = null;
			j = DataGridView1.RowCount;
			if (j < 0) {
				return;
			}
			sql = "INSERT INTO `tr_attendance`(`id_no`, `tr_date`, `morning`, `afternoon`, `reason`) VALUES ";
			for (i = 0; i <= j - 1; i++) {
				id = DataGridView1.Rows[i].Cells["national_id"].Value;
				if (DataGridView1.Rows[i].Cells["status"].Value == true) {
					stats = 1;
				} else {
					stats = 0;
				}
				if (DataGridView1.Rows[i].Cells["status1"].Value == true) {
					stats1 = 1;
				} else {
					stats1 = 0;
				}
				reason = DataGridView1.Rows[i].Cells["reason"].Value;
				if (i < j) {
					if (i > 0) {
						sql1 = sql1 + " ,";
					}
				}
				atdate = DateTimePicker1.Value.ToString("yyyy-MM-dd");
				sql1 = sql1 + " ('" + id + "','" + atdate + "','" + stats + "','" + stats1 + "','" + reason + "')";
			}
			data.@add(ref sql + sql1);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			DateTime latestdate = DateTimePicker1.Value;
			DateTime nextdate = default(DateTime);
			nextdate = latestdate.AddDays(1);
			DateTimePicker1.Value = nextdate;
			Label2.Text = DateTimePicker1.Value.ToString("dddd  dd/MM/yyyy");
		}
		private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			Label2.Text = DateTimePicker1.Value.ToString("dddd dd MM yyyy");
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			DateTime latestdate = DateTimePicker1.Value;
			DateTime nextdate = default(DateTime);
			nextdate = latestdate.AddDays(-1);
			DateTimePicker1.Value = nextdate;
			Label2.Text = DateTimePicker1.Value.ToString("dddd  dd/MM/yyyy");
		}
	}
}
