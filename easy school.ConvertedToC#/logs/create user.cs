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
	public partial class create_user
	{
		database data = new database();

		public string idno = 111111111;
		private void Button1_Click(object sender, EventArgs e)
		{

		}

		private void Button2_Click(object sender, EventArgs e)
		{
			string vv = null;
			vv = TextBox1.Text;
			byte[] bout = System.Convert.FromBase64String(vv);
			string oot = System.Text.Encoding.UTF8.GetString(bout);
			TextBox1.Text = oot;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			//INSERT INTO  `library`.`users` (`ID` ,`password` ,`user_id` ,`created` ,`lastupdate` `status`)VALUES ('29328385 ',  'g',  'g',  '0', NOW( ) , CURRENT_TIMESTAMP ,  '1')
			if (string.IsNullOrEmpty(TextBox3.Text)) {
				Interaction.MsgBox("user name can't be empty", MsgBoxStyle.Information, "error");
				TextBox3.Focus();
				return;
			} else {
				if (string.IsNullOrEmpty(TextBox4.Text) | string.IsNullOrEmpty(TextBox5.Text)) {
					Interaction.MsgBox("password can't be empty", MsgBoxStyle.Information, "error");
					TextBox4.Text = "";
					TextBox5.Text = "";
					TextBox4.Focus();
					return;
				} else {
					if (TextBox4.Text == TextBox5.Text) {
						string s = null;
						s = TextBox4.Text;
						byte[] barray = System.Text.Encoding.UTF8.GetBytes(s);
						string passwordss = System.Convert.ToBase64String(barray);
						string th = "INSERT INTO  users (`password` ,`username` )VALUES ('" + passwordss + "',  '" + TextBox3.Text + " ')";
						data.@add(ref th);
						this.Close();
					} else {
						Interaction.MsgBox("password din't match", MsgBoxStyle.Information, "error");
						TextBox4.Text = "";
						TextBox5.Text = "";
						TextBox4.Focus();
					}
				}
			}

		}

		private void Button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void TextBox3_TextChanged(object sender, EventArgs e)
		{
		}
		public create_user()
		{
			InitializeComponent();
		}
	}
}
