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
	public partial class admin_fee
	{

		private void Button2_Click(object sender, EventArgs e)
		{
			GroupBox4.Text = "m-pesa";
			TextBox7.Visible = true;
			TextBox6.Visible = true;
			Label9.Text = "phone number";
			Label8.Text = "transaction number";
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			GroupBox4.Text = "cheque details";
			TextBox7.Visible = true;
			TextBox6.Visible = true;
			Label9.Text = "bank name";
			Label8.Text = "cheque number";
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			GroupBox4.Text = "deposit slip  details";
			TextBox7.Visible = true;
			TextBox6.Visible = true;
			Label9.Text = "bank name";
			Label8.Text = "transaction number";
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			GroupBox4.Text = "CASH";
			TextBox7.Visible = false;
			TextBox6.Visible = false;
			Label9.Text = "";
			Label8.Text = "";
		}

		private void TextBox13_TextChanged(object sender, EventArgs e)
		{
			TextBox4.Text = TextBox13.Text;
		}
		private void TextBox4_TextChanged(object sender, EventArgs e)
		{
			try {
				TextBox5.Text = TextBox3.Text - TextBox4.Text;

			} catch (Exception ex) {
			}
		}


		private void Button5_Click(object sender, EventArgs e)
		{
			PrintPreviewDialog1.PrintPreviewControl.Show();
			//Me.PrintPreviewDialog1.ShowDialog()
		}

		private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Font f = new Font("Vanada", 10);
			Font s = new Font("Vanada", 20);
			Font z = new Font("Vanada", 15);
			SolidBrush br = new SolidBrush(Color.Black);
			Pen p = new Pen(Color.Black);
			int wt = 780;
			int ht = 900;
			Pen l = null;
			l = new Pen(Color.Black, 0.025f);

			e.Graphics.DrawRectangle(l, 40f, 50.5f, wt, ht);
			// border of the table
			e.Graphics.DrawRectangle(l, 40f, 50.5f, 780, 150);
			e.Graphics.DrawRectangle(l, 40f, 50.5f, 500, 150);
			e.Graphics.DrawString(" " + "Label11.Text" + " ", s, br, 60, 60);
			e.Graphics.DrawString(" " + "Label9.Text" + "", z, br, 60, 110);
			e.Graphics.DrawString("  " + "Label10.Text" + "  ", z, br, 60, 130);
			e.Graphics.DrawString(" Date : ", f, br, 550, 60);
			e.Graphics.DrawString(" " + DateAndTime.Today.Date + " ", f, br, 650, 60);
			e.Graphics.DrawString(" Bill No : ", f, br, 550, 160);
			e.Graphics.DrawString(" " + Label6.Text + " ", f, br, 650, 160);
			e.Graphics.DrawString(" Class : ", f, br, 60, 220);
			e.Graphics.DrawString(" " + "ComboBox1.Text" + " ", f, br, 250, 220);
			e.Graphics.DrawString(" Student Name : ", f, br, 60, 270);
			e.Graphics.DrawString(" " + "ComboBox4.Text" + " ", f, br, 250, 270);
			e.Graphics.DrawString(" Section : ", f, br, 550, 220);
			e.Graphics.DrawString(" " + "ComboBox3.Text" + " ", f, br, 650, 220);
			e.Graphics.DrawRectangle(l, 40f, 300.5f, 780, 50);
			e.Graphics.DrawRectangle(l, 40f, 300.5f, 650, 50);
			e.Graphics.DrawString(" Fees  ", f, br, 240, 320);
			e.Graphics.DrawString(" " + "ComboBox2.Text" + "", f, br, 60, 420);
			e.Graphics.DrawString(" Amount ", f, br, 750, 320);
			e.Graphics.DrawString(" " + TextBox1.Text + " ", f, br, 750, 420);
			e.Graphics.DrawRectangle(l, 40f, 300.5f, 650, 600);
			e.Graphics.DrawRectangle(l, 40f, 900.5f, 780, 150);
			e.Graphics.DrawString(" Signature ", f, br, 50, 1020);
			e.Graphics.DrawString(" Seal ", f, br, 750, 1020);
			e.Graphics.DrawRectangle(l, 40f, 900.5f, 650, 50);
			e.Graphics.DrawString(" Total ", f, br, 550, 910);
			e.Graphics.DrawString(" " + TextBox1.Text + " ", f, br, 750, 910);
			ShowDialog();

		}


		private void PrintPreviewDialog1_Load(object sender, EventArgs e)
		{
		}
		public admin_fee()
		{
			InitializeComponent();
		}
	}
}
