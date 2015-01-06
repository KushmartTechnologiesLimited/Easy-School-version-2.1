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
	public partial class profile
	{

		database data = new database();
		private void Button9_Click(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			DataTable red = null;
			DataTable fred = null;
			DataTable mred = null;
			TextBox1.Text = "";
			TextBox2.Text = "";
			TextBox7.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox9.Text = "";
			TextBox8.Text = "";
			TextBox28.Text = "";
			TextBox27.Text = "";
			TextBox11.Text = "";
			TextBox10.Text = "";
			TextBox13.Text = "";
			TextBox12.Text = "";
			//TextBox15.Text = .Item(4)
			TextBox14.Text = "";
			TextBox17.Text = "";
			TextBox16.Text = "";
			TextBox25.Text = "";
			TextBox24.Text = "";
			TextBox23.Text = "";
			TextBox22.Text = "";
			//TextBox15.Text = .Item(4)
			TextBox20.Text = "";
			TextBox19.Text = "";
			TextBox18.Text = "";

			red = data.executeSQL("SELECT  `admno`, ` names`, `gender`, `DOB`, `Birthno`  , (SELECT  class.description FROM class WHERE class.code=`class_code`),(SELECT  stream.name FROM stream WHERE stream.code=str_code ),  `adm_date` ,  `status` FROM  `students` WHERE admno= '" + TextBox26.Text + "'");
			foreach (DataRow fd in red.Rows) {
				var _with1 = fd;
				TextBox1.Text = _with1.Item(0);
				TextBox2.Text = _with1.Item(1);
				TextBox7.Text = _with1.Item(2);
				TextBox3.Text = _with1.Item(3);
				TextBox4.Text = _with1.Item(4);
				TextBox9.Text = _with1.Item(5);
				TextBox8.Text = _with1.Item(6);
				TextBox28.Text = _with1.Item(7);
				if (_with1.Item(8) == 1) {
					TextBox27.Text = "Active";
					TextBox27.ForeColor = Color.Green;
				} else if (_with1.Item(8) == 0) {
					TextBox27.Text = "De Active";
					TextBox27.ForeColor = Color.Red;
				} else {
					TextBox27.Text = "";
					TextBox27.BackColor = Color.Orange;
				}

			}
			mred = data.executeSQL("SELECT `f_id_no`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `father` WHERE `f_id_no` in (SELECT `f_id_no` FROM `parents` WHERE`admno`='" + TextBox26.Text + "')");

			foreach (DataRow fdm in mred.Rows) {
				var _with2 = fdm;
				TextBox25.Text = _with2.Item(1);
				TextBox24.Text = _with2.Item(0);
				TextBox23.Text = _with2.Item(2);
				TextBox22.Text = _with2.Item(3);
				//TextBox15.Text = .Item(4)
				TextBox20.Text = _with2.Item(4);
				TextBox19.Text = _with2.Item(5);
				TextBox18.Text = _with2.Item(6);
			}
			fred = data.executeSQL("SELECT `Id_No`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `mother` WHERE `Id_No` in (SELECT `id_no` FROM `parents` WHERE`admno`='" + TextBox26.Text + "')");

			foreach (DataRow fdm1 in fred.Rows) {
				var _with3 = fdm1;
				TextBox11.Text = _with3.Item(1);
				TextBox10.Text = _with3.Item(0);
				TextBox13.Text = _with3.Item(2);
				TextBox12.Text = _with3.Item(3);
				//TextBox15.Text = .Item(4)
				TextBox14.Text = _with3.Item(4);
				TextBox17.Text = _with3.Item(5);
				TextBox16.Text = _with3.Item(6);
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			mdparent frm1 = new mdparent();
			frm1.table = "mother";
			frm1.id = TextBox10.Text;
			frm1.ShowDialog();
			DataTable fred = new DataTable();
			fred = data.executeSQL("SELECT `Id_No`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `mother` WHERE `Id_No` in (SELECT `id_no` FROM `parents` WHERE`admno`='" + TextBox26.Text + "')");

			foreach (DataRow fdm1 in fred.Rows) {
				var _with4 = fdm1;
				TextBox11.Text = _with4.Item(1);
				TextBox10.Text = _with4.Item(0);
				TextBox13.Text = _with4.Item(2);
				TextBox12.Text = _with4.Item(3);
				//TextBox15.Text = .Item(4)
				TextBox14.Text = _with4.Item(4);
				TextBox17.Text = _with4.Item(5);
				TextBox16.Text = _with4.Item(6);
			}
		}


		private void Button2_Click(object sender, EventArgs e)
		{
			mdparent frm = new mdparent();
			DataTable mred = null;
			frm.table = "father";
			frm.id = TextBox24.Text;
			frm.ShowDialog();
			mred = data.executeSQL("SELECT `f_id_no`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `father` WHERE `f_id_no` in (SELECT `f_id_no` FROM `parents` WHERE`admno`='" + TextBox26.Text + "')");

			foreach (DataRow fdm in mred.Rows) {
				var _with5 = fdm;
				TextBox25.Text = _with5.Item(1);
				TextBox24.Text = _with5.Item(0);
				TextBox23.Text = _with5.Item(2);
				TextBox22.Text = _with5.Item(3);
				//TextBox15.Text = .Item(4)
				TextBox20.Text = _with5.Item(4);
				TextBox19.Text = _with5.Item(5);
				TextBox18.Text = _with5.Item(6);
			}

		}

		private void profile_Load(object sender, EventArgs e)
		{
			Button9.PerformClick();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			edit_students edi = new edit_students();
			edi.TextBox1.Text = TextBox1.Text;
			edi.ShowDialog();
			Button9.PerformClick();
		}

		private void TextBox26_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);
		}


		private void TextBox26_TextChanged(object sender, EventArgs e)
		{
		}


		private void GroupBox5_Enter(object sender, EventArgs e)
		{
		}
	}
}
