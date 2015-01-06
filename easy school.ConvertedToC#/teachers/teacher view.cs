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
	public partial class teacher_view
	{
		string sql = "SELECT  `name`, `national_id`,  `tel`, `email`,   `qualification`, `institution`, `year_out` FROM `teachers`";

		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
		}
		public void fillter()
		{
			studentsdatabase data = new studentsdatabase();

			string fil = " where `name` regexp  '" + TextBox2.Text + "' or `national_id` regexp '" + TextBox2.Text + "'";
			data.select_dgview(sql + fil, DataGridView1);
		}

		private void teacher_view_Load(object sender, EventArgs e)
		{
			studentsdatabase data = new studentsdatabase();

			data.select_dgview(sql, DataGridView1);
		}


		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
		}


		private void Button6_Click(object sender, EventArgs e)
		{
			studentsdatabase data = new studentsdatabase();

			data.select_dgview(sql, DataGridView1);
			TextBox2.Text = "";
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Button3_Click_1(object sender, EventArgs e)
		{
			int i = 0;
			string h = null;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with1 = DataGridView1;
				h = _with1.Item(1, i).Value;
				try {
					studentsdatabase data = new studentsdatabase();
					DataTable red = null;
					red = data.executeSQL("SELECT * FROM `teachers` WHERE `national_id`='" + h + "'");
					teacher tt = new teacher();
					tt.selected(red);
					tt.Button3.Enabled = true;
					tt.Button2.Enabled = false;
					tt.ShowDialog();

				} catch (Exception ex) {
				}
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			int i = 0;
			string h = null;
			if (DataGridView1.RowCount > 0) {
				i = DataGridView1.CurrentRow.Index;
				var _with2 = DataGridView1;
				h = _with2.Item(1, i).Value;
				if (Interaction.MsgBox("are you sure you want to delete the record", MsgBoxStyle.YesNo, "confirm") == MsgBoxResult.Yes) {
					try {
						studentsdatabase data = new studentsdatabase();
						DataTable red = null;
						red = data.executeSQL("DELETE FROM `teachers` WHERE  `national_id`='" + h + "'");
						Button6.PerformClick();
						teacher tt = new teacher();
					} catch (Exception ex) {
					}
				}
			}

		}

		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			if (TextBox2.TextLength > 0) {
				fillter();
			} else {
				Button6.PerformClick();
			}

		}
		public teacher_view()
		{
			Load += teacher_view_Load;
			InitializeComponent();
		}
	}
}
