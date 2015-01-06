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
	public partial class mdparent
	{
		public string table;
		public string id;
		database data = new database();
		private struct strparents
		{
			public string idm;
			public string names;
			public string tel;
			public string email;
			public string work;
			public string employer;
			public string resident;
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			if (Interaction.MsgBox("are you sure you want to edit this detais", MsgBoxStyle.Information + Constants.vbYesNo, "confirm") == MsgBoxResult.Yes) {
				updatedetails();
				Interaction.MsgBox("results updated", , "confirmed");
			} else {
				return;
			}

		}
		public void updatedetails()
		{
			strparents das = default(strparents);
			das.idm = TextBox13.Text;
			das.names = TextBox7.Text;
			das.tel = TextBox11.Text;
			das.email = TextBox21.Text;
			das.work = TextBox8.Text;
			das.employer = TextBox9.Text;
			das.resident = TextBox12.Text;

			string fsql = null;
			string msql = null;
			var _with1 = das;
			if (table == "father") {
				fsql = "UPDATE `father` SET `names`='" + _with1.names + "',`tel`='" + _with1.tel + "',`email`='" + _with1.email + "',`work`='" + _with1.work + "',`employer`='" + _with1.employer + "',`Resident_id`='" + _with1.resident + "' WHERE `f_Id_No`=" + _with1.idm;
				data.executeSQL(fsql);
			} else if (table == "mother") {
				msql = "UPDATE `mother` SET `names`='" + _with1.names + "',`tel`='" + _with1.tel + "',`email`='" + _with1.email + "',`work`='" + _with1.work + "',`employer`='" + _with1.employer + "',`Resident_id`='" + _with1.resident + "' WHERE `Id_No`=" + _with1.idm;
				data.executeSQL(msql);
			}
			this.Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void mdparent_Load(object sender, EventArgs e)
		{
			Label1.Text = this.table.ToUpper() + "'S DETAILS ";
			selectcase(table);

		}
		public void selectcase(string tabl)
		{
			string vsql = null;
			switch (tabl) {
				case  // ERROR: Case labels with binary operators are unsupported : Equality
"mother":
					vsql = "SELECT `mother`.`Id_No`, `mother`.`names`, `mother`.`tel`, `mother`.`email`, `mother`.`work`, `mother`.`employer`, `mother`.`Resident_id` FROM `mother` WHERE  `mother`.`id_no`=" + id;
					father(vsql);
					break;
				case  // ERROR: Case labels with binary operators are unsupported : Equality
"father":
					vsql = "SELECT `father`.`f_Id_No`, `father`.`names`, `father`.`tel`, `father`.`email`, `father`.`work`, `father`.`employer`, `father`.`Resident_id`  FROM `father` WHERE  `father`.`f_id_no`=" + id;
					father(vsql);
					break;
			}

		}
		public void father(string admno)
		{
			System.Data.DataTable red = null;
			DataRow drow = null;
			strparents pss = new strparents();
			red = data.executeSQL(admno);
			foreach (DataRow drow_loopVariable in red.Rows) {
				drow = drow_loopVariable;
				pss.idm = drow[0].ToString().ToUpper().ToUpper();
				pss.names = drow[1].ToString().ToUpper();
				pss.tel = drow[2].ToString().ToUpper();
				pss.email = drow[3].ToString().ToUpper();
				pss.work = drow[4].ToString().ToUpper();
				pss.employer = drow[5].ToString().ToUpper();
				pss.resident = drow[6].ToString().ToUpper();
			}
			var _with2 = pss;
			TextBox7.Text = _with2.names;
			TextBox13.Text = _with2.idm;
			TextBox11.Text = _with2.tel;
			TextBox21.Text = _with2.email;
			TextBox8.Text = _with2.work;
			TextBox9.Text = _with2.employer;
			TextBox12.Text = _with2.resident;

		}


		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}


		private void TextBox21_TextChanged(object sender, EventArgs e)
		{
		}


		private void TextBox21_Validated(object sender, EventArgs e)
		{
		}

		private void TextBox21_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			validate val = new validate();
			val.emails(sender);
		}

		private void TextBox7_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}

		private void TextBox11_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);

		}


		private void TextBox11_TextChanged(object sender, EventArgs e)
		{
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
		public mdparent()
		{
			Load += mdparent_Load;
			InitializeComponent();
		}
	}
}
