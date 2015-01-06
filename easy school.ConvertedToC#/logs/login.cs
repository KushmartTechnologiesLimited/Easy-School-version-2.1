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
	public partial class login
	{
		database data = new database();
		private void Button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void Button3_Click(object sender, EventArgs e)
		{
			string s = null;
			s = TextBox4.Text;
			byte[] barray = System.Text.Encoding.UTF8.GetBytes(s);
			string passwordss = System.Convert.ToBase64String(barray);
			DataTable red = new DataTable();
			string sq = "SELECT * FROM `users` WHERE `username`='" + TextBox3.Text + "'  and `password`='" + passwordss + "'";
			red = data.executeSQL(sq);
			if (red.Rows.Count > 0) {
				MDIParent1 man = new MDIParent1();
				man.Label1.Text = "User :" + red.Rows[0][1].ToString();
				man.role = red.Rows[0][3].ToString();
				this.Hide();
				man.ShowDialog();
				this.Close();
			} else {
				Interaction.MsgBox("wrong username or password " + Constants.vbCrLf + " try again", MsgBoxStyle.Exclamation, "login");
				TextBox4.Text = "";
				TextBox3.Text = "";
				return;
			}
		}
		private void login_Load(object sender, EventArgs e)
		{
			DataTable red = new DataTable();
			red = data.executeSQL("SELECT * FROM `users`");
		}
		public login()
		{
			Load += login_Load;
			InitializeComponent();
		}
	}
}
