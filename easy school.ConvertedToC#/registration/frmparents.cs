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
	public partial class mdyfrmparents
	{
		database DATA = new database();
		public string id;
		public string names;
		public string tel;
		public string email;
		public string work;
		public string employer;
		public string residents;

		private void TextBox7_TextChanged(object sender, EventArgs e)
		{
		}

		public bool checkblank(object sender)
		{
			if (sender.text.ToString.Length == 0) {
				Interaction.MsgBox("can't be blank", MsgBoxStyle.Information, "");
				// sender.focus = True
				return false;
			}
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			try {
				if (checkblank(TextBox13) == false) {
					return;
				} else if (checkblank(TextBox7) == false) {
					return;
				} else if (checkblank(TextBox7) == false) {
					return;
				} else if (checkblank(TextBox11) == false) {
					return;
				} else if (checkblank(TextBox21) == false) {
					return;
				} else if (checkblank(TextBox8) == false) {
					return;
				} else if (checkblank(TextBox13) == false) {
					return;
				} else if (checkblank(TextBox12) == false) {
					return;
				} else {
					id = TextBox13.Text;
					names = TextBox7.Text;
					tel = TextBox11.Text;
					email = TextBox21.Text;
					work = TextBox8.Text;
					employer = TextBox9.Text;
					residents = TextBox12.Text;
					DATA.@add(ref "INSERT INTO " + this.Text + "  VALUES (" + id + ", '" + names + "', '" + tel + "', '" + email + "', '" + work + "', '" + employer + "', '1');");
					this.Close();
				}

			} catch (Exception ex) {
			}
		}

		private void frmparents_Load(object sender, EventArgs e)
		{
			Label1.Text = this.Text.ToUpper() + "'S DETAILS";
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TextBox7_TextChanged_1(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}

		private void TextBox13_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);
		}


		private void TextBox13_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox11_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);
		}


		private void TextBox11_TextChanged(object sender, EventArgs e)
		{
		}


		private void TextBox21_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextBox21_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			validate val = new validate();
			val.emails(sender);
		}

		private void TextBox8_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}

		private void TextBox9_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}

		private void TextBox12_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}
		public mdyfrmparents()
		{
			Load += frmparents_Load;
			InitializeComponent();
		}
	}
}
