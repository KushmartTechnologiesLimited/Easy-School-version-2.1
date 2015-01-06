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
	public partial class teacher
	{
		string picha;
		studentsdatabase data = new studentsdatabase();
		public void edit()
		{
			string sqledit = null;
			sqledit = "UPDATE `teachers` SET `national_id`='" + TextBox2.Text + "',`name`='" + TextBox1.Text + "',`gender`='" + ComboBox1.Text + "',`tel`='" + MaskedTextBox1.Text + "',`email`='" + TextBox4.Text + "',`DOB`='" + dob.Value + "',`emp_date`='" + empdate.Value + "',`box`='" + TextBox5.Text + "',`city`='" + TextBox6.Text + "',`village`='" + TextBox7.Text + "',`p_code`='" + TextBox8.Text + "',`qualification`='" + ComboBox2.Text + "',`year_out`='" + p_year.Value + "',`institution`='" + TextBox3.Text + "',`pic`='" + picha + "' WHERE `national_id`='" + TextBox2.Text + "'";
			data.executeSQL(sqledit.ToLower());
		}
		public void selected(DataTable datas)
		{
			try {
				DataTable red = datas;
				if (red.Rows.Count < 1) {
					this.Close();
				}
				//MsgBox(red.Rows.Count)

				foreach (object drow_loopVariable in red.Rows) {
					drow = drow_loopVariable;
					var _with1 = this;
					_with1.TextBox2.Text = drow.Item(0).ToString.ToUpper;
					//id
					_with1.TextBox1.Text = drow.Item(1).ToString.ToUpper.ToUpper;
					//name
					_with1.dob.Value = drow.Item(5).ToString.ToUpper.ToUpper;
					//date of birth
					_with1.ComboBox1.Text = drow.Item(2).ToString.ToUpper.ToUpper;
					//gender
					_with1.MaskedTextBox1.Text = drow.Item(3).ToString.ToUpper.ToUpper;
					//phone number
					_with1.TextBox4.Text = drow.Item(4).ToString.ToUpper.ToUpper;
					//email
					piv(drow.Item(14).ToString.ToUpper.ToUpper);
					//picha
					picha = drow.Item(14).ToString.ToUpper.ToUpper;
					_with1.TextBox5.Text = drow.Item(7).ToString.ToUpper.ToUpper;
					//box
					_with1.TextBox6.Text = drow.Item(8).ToString.ToUpper.ToUpper;
					//city
					_with1.TextBox7.Text = drow.Item(9).ToString.ToUpper.ToUpper;
					//village
					_with1.TextBox8.Text = drow.Item(10).ToString.ToUpper.ToUpper;
					//posal code
					_with1.ComboBox2.Text = drow.Item(11).ToString.ToUpper.ToUpper;
					//qualification
					_with1.TextBox3.Text = drow.Item(13).ToString.ToUpper.ToUpper;
					//institution
					_with1.empdate.Value = drow.Item(6).ToString.ToUpper.ToUpper;
					//employent date
					_with1.p_year.Value = drow.Item(12).ToString + "-01-01";
					//year out
				}
			} catch (Exception ex) {
				Interaction.MsgBox(ex.Message);
			}
		}
		public void piv(string fff)
		{
			try {
				PictureBox pb = PictureBox1;
				Bitmap bmp = new Bitmap(fff);
				if ((pb.Image != null))
					pb.Image.Dispose();
				//Optional if you want to destroy the previously loaded image
				pb.Image = bmp;
				picha = fff;
			} catch {
				// MsgBox("Not a valid image file.")
			}
		}
		public void OpenAnImageInPicturebox(ref PictureBox pb)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			// ofd.Filter = "JPEG|*.jpg|PNG|*.png|Bitmap|*.bmp" 'If you like file type filters you can add them here
			//any other modifications to the dialog
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				return;
			try {
				Bitmap bmp = new Bitmap(ofd.FileName);
				if ((pb.Image != null))
					pb.Image.Dispose();
				//Optional if you want to destroy the previously loaded image
				pb.Image = bmp;
				picha = ofd.FileName;
			} catch {
				Interaction.MsgBox("Not a valid image file.");
			}
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			OpenAnImageInPicturebox(ref PictureBox1);
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			string sql = null;
			if (string.IsNullOrEmpty(TextBox2.Text)) {
				Interaction.MsgBox("can' be blank", MsgBoxStyle.Information, "error");
				TextBox2.Focus();
				return;
			}
			if (string.IsNullOrEmpty(TextBox1.Text)) {
				Interaction.MsgBox("can' be blank", MsgBoxStyle.Information, "error");
				TextBox1.Focus();
				return;
			}
			if (ComboBox1.Text == Text) {
				Interaction.MsgBox("can' be blank", MsgBoxStyle.Information, "error");
				ComboBox1.Focus();
				return;
			}
			if (string.IsNullOrEmpty(MaskedTextBox1.Text)) {
				Interaction.MsgBox("can' be blank", MsgBoxStyle.Information, "error");
				MaskedTextBox1.Focus();
				return;
			}

			if (string.IsNullOrEmpty(TextBox4.Text)) {
				Interaction.MsgBox("can' be blank", MsgBoxStyle.Information, "error");
				TextBox4.Focus();
				return;
			}
			sql = "INSERT INTO `teachers` (`national_id`, `name`, `gender`, `tel`, `email`, `DOB`, `emp_date`, `box`, `city`, `village`, `p_code`, `qualification`, `year_out`, `institution`, `pic`) VALUES ('" + TextBox2.Text + "', '" + TextBox1.Text + "', '" + ComboBox1.Text + "', '" + MaskedTextBox1.Text + "', '" + TextBox4.Text + "', '" + dob.Value.ToString("yyyy-MM-dd") + "', '" + empdate.Value.ToString("yyyy-MM-dd") + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "', '" + TextBox7.Text + "', '" + TextBox8.Text + "', '" + ComboBox2.Text + "', '" + p_year.Value.ToString("yyyy") + "', '" + TextBox3.Text + "','" + picha + "');";
			data.@add(ref sql);
			TextBox2.Text = "";
			TextBox1.Text = "";
			ComboBox1.Text = "";
			MaskedTextBox1.Text = "";
			TextBox4.Text = "";
			dob.Value = DateAndTime.Now;
			empdate.Value = DateAndTime.Now;
			TextBox5.Text = "";
			TextBox6.Text = "";
			TextBox7.Text = "";
			TextBox8.Text = "";
			ComboBox2.Text = "";
			p_year.Value = DateAndTime.Now;
			TextBox3.Text = "";
			picha = "";
		}
		private void Button7_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			try {
				string sqledit = null;
				if (string.IsNullOrEmpty(TextBox2.Text)) {
					Interaction.MsgBox("can' be blank", MsgBoxStyle.Information, "error");
					TextBox2.Focus();
					return;
				}
				if (string.IsNullOrEmpty(TextBox1.Text)) {
					Interaction.MsgBox("can' be blank", MsgBoxStyle.Information, "error");
					TextBox1.Focus();
					return;
				}
				if (ComboBox1.Text == Text) {
					Interaction.MsgBox("can' be blank", MsgBoxStyle.Information, "error");
					ComboBox1.Focus();
					return;
				}
				if (string.IsNullOrEmpty(MaskedTextBox1.Text)) {
					Interaction.MsgBox("can' be blank", MsgBoxStyle.Information, "error");
					MaskedTextBox1.Focus();
					return;
				}
				sqledit = "UPDATE `teachers` SET `national_id`='" + TextBox2.Text + "',`name`='" + TextBox1.Text + "',`gender`='" + ComboBox1.Text + "',`tel`='" + MaskedTextBox1.Text + "',`email`='" + TextBox4.Text + "',`DOB`='" + dob.Value.ToString("yyyy-MM-dd") + "',`emp_date`='" + empdate.Value.ToString("yyyy-MM-dd") + "',`box`='" + TextBox5.Text + "',`city`='" + TextBox6.Text + "',`village`='" + TextBox7.Text + "',`p_code`='" + TextBox8.Text + "',`qualification`='" + ComboBox2.Text + "',`year_out`='" + p_year.Value.ToString("yyyy") + "',`institution`='" + TextBox3.Text + "',`pic`='" + picha + "' WHERE `national_id`='" + TextBox2.Text + "'";
				data.executeSQL(sqledit.ToLower());
				this.Close();
			} catch (Exception ex) {
				Interaction.MsgBox("an error occured ", , "error");
			}
		}


		private void teacher_Load(object sender, EventArgs e)
		{
		}
		public teacher()
		{
			Load += teacher_Load;
			InitializeComponent();
		}
	}
}
