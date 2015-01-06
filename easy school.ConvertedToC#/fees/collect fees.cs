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
using System.Data.SqlClient;
using System.Data.Odbc;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using Microsoft.Office.Interop;
namespace easy_school
{
	//Imports Microsoft.Office.Interop.Word
	public partial class collect_fees
	{
		public Microsoft.Office.Interop.Word.Document oDocs;
		public Microsoft.Office.Interop.Word.Table otable;
		public Microsoft.Office.Interop.Word.Paragraph para;
		string lala;
		database data = new database();
		private void Button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (sender.@checked) {
				GroupBox4.Visible = false;
				TextBox15.Text = "";
				TextBox14.Text = "";
			} else {
				GroupBox4.Visible = true;
			}
		}

		private void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (sender.@checked) {
				GroupBox4.Visible = true;
				GroupBox4.Text = "Deposit Slip Details";
				Label15.Text = "Bank Name :";
				Label18.Text = "Transaction No :";
				TextBox15.Text = "";
				TextBox14.Text = "";
			}
		}

		private void RadioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (sender.@checked) {
				GroupBox4.Visible = true;
				GroupBox4.Text = "Cheque Details";
				Label15.Text = "Bank Name : ";
				Label18.Text = "Cheque No :";
				TextBox15.Text = "";
				TextBox14.Text = "";
			}
		}

		private void RadioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (sender.@checked) {
				GroupBox4.Visible = true;
				GroupBox4.Text = "M-Pesa Details";
				Label15.Text = "Phone No :";
				Label18.Text = "Transaction No :";
				TextBox15.Text = "";
				TextBox14.Text = "";
			}
		}

		private void TextBox3_TextChanged(object sender, EventArgs e)
		{
			TextBox4.Text = TextBox3.Text + TextBox2.Text;
		}

		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			TextBox4.Text = TextBox3.Text + TextBox2.Text;
		}
		private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);
		}

		private void TextBox5_TextChanged(object sender, EventArgs e)
		{
			if (TextBox5.TextLength > 0) {
				TextBox6.Text = TextBox4.Text - TextBox5.Text;
			}

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			DataTable red = null;
			TextBox7.Text = "";
			TextBox8.Text = "";
			TextBox9.Text = "";
			red = data.executeSQL("SELECT  ` names` ,(SELECT  class.description FROM class WHERE class.code=`class_code`),(SELECT  stream.name FROM stream WHERE stream.code=str_code ) FROM students WHERE admno='" + TextBox1.Text + "'");
			foreach (DataRow row in red.Rows) {
				TextBox7.Text = row[0].ToString().ToUpper();
				TextBox8.Text = row[1].ToString().ToUpper();
				TextBox9.Text = row[2].ToString().ToUpper();
			}
			TextBox2.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox6.Text = "";
			TextBox5.Text = "";
			DataTable redfee = null;
			redfee = data.executeSQL("SELECT  `Amount`, `payable`, `Balance` FROM `fees accounting` WHERE `admno`='" + TextBox1.Text + "' and `Status`=0");
			if (redfee.Rows.Count > 0) {
				Panel5.Enabled = true;
				TextBox1.ReadOnly = true;
			}

			foreach (DataRow row in redfee.Rows) {
				TextBox2.Text = row[1].ToString().ToUpper();
				TextBox3.Text = row[0].ToString().ToUpper();
				TextBox4.Text = row[2].ToString().ToUpper();
				TextBox6.Text = row[2].ToString().ToUpper();
			}

		}


		private void Button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox5.Text)) {
				Interaction.MsgBox("enter some value please", MsgBoxStyle.Information, "");
				TextBox5.Focus();
				return;
			}
			if (TextBox4.Text == TextBox6.Text) {
				Interaction.MsgBox("You have not paid any amount", MsgBoxStyle.Information, "");
				TextBox5.Focus();
				return;
			}
			string admn1 = null;
			string method = null;
			admn1 = TextBox1.Text;
			if (RadioButton1.Checked) {
				method = "cash";
			} else if (RadioButton2.Checked) {
				method = "bank slip";
			} else if (RadioButton3.Checked) {
				method = "cheque";
			} else if (RadioButton4.Checked) {
				method = "m pesa";
			}
			string nn = null;
			nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" + admn1 + "', 'Cash Collection','" + method + "', '" + TextBox15.Text + "', '" + TextBox14.Text + "', '', '" + TextBox5.Text + "', '" + TextBox4.Text + "', '" + TextBox6.Text + "', '0', CURRENT_TIMESTAMP);";
			data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" + admn1 + "'");
			data.@add(ref nn);
			var oWord = new Microsoft.Office.Interop.Word.Application { Visible = false };
			oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "receipt.dotx", , false);
			Microsoft.Office.Interop.Word.Table otable3 = null;
			otable3 = oDocs.Tables[1];
			otable3.Cell(1, 0).Range.Text = "Names : " + TextBox7.Text;
			otable3.Cell(1, 2).Range.Text = "Adm No: " + TextBox1.Text;
			otable3.Cell(2, 1).Range.Text = "Class:  " + TextBox8.Text;
			otable3.Cell(2, 2).Range.Text = "Stream: " + TextBox9.Text;
			DataTable ress = null;
			ress = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly' ) and `L_id`=(SELECT `level` FROM `class` WHERE `Description`='" + TextBox8.Text + "')");
			int lim = 0;
			lim = ress.Rows.Count;
			int index = 4;
			int sum = 0;
			foreach (DataRow row in ress.Rows) {
				otable3.Cell(index, 1).Range.Text = row[0].ToString().ToUpper();
				otable3.Cell(index, 2).Range.Text = row[1].ToString().ToUpper();
				sum = sum + (row[1]);
				index = index + 1;
			}
			DataTable ids = data.executeSQL("SELECT max(`fees_id`) FROM `fees accounting` ");
			otable3.Cell(11, 2).Range.Text = sum;
			otable3.Cell(12, 2).Range.Text = TextBox4.Text;
			otable3.Cell(13, 2).Range.Text = TextBox5.Text;
			otable3.Cell(14, 2).Range.Text = TextBox6.Text;
			otable3.Cell(15, 1).Range.Text = "Served By:  " + "Admin";
			otable3.Cell(15, 2).Range.Text = "Receipt No: " + ids.Rows[0][0];
			otable3.Cell(15, 3).Range.Text = "Date  " + DateTimePicker1.Value.ToString();
			oDocs.PrintOut(false);
			oDocs.Close(SaveChanges: false);
			oDocs = null;
			oWord.Quit();
			oWord = null;
			Panel5.Enabled = false;
			TextBox1.ReadOnly = false;
			TextBox7.Text = "";
			TextBox8.Text = "";
			TextBox9.Text = "";
			TextBox2.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox6.Text = "";
			TextBox5.Text = "";

		}

		private void TextBox4_TextChanged(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			if (TextBox5.TextLength > 0) {
				TextBox6.Text = TextBox4.Text - TextBox5.Text;
			}
		}

		private void Button3_Click_1(object sender, EventArgs e)
		{

		}

		private void Button4_Click(object sender, EventArgs e)
		{
			students_fees sts = new students_fees();
			sts.Size = this.Size;
			sts.Label2.Text = TextBox7.Text;
			sts.ad = TextBox1.Text;
			sts.ShowDialog();
		}

		private void collect_fees_Load(object sender, EventArgs e)
		{
			Button1.PerformClick();
		}


		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			var oWord = new Microsoft.Office.Interop.Word.Application { Visible = false };
			oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "receipt.dotx", , false);
			Microsoft.Office.Interop.Word.Table otable3 = null;
			otable3 = oDocs.Tables[1];
			otable3.Cell(1, 0).Range.Text = "Names : " + TextBox7.Text;
			otable3.Cell(1, 2).Range.Text = "Adm No: " + TextBox1.Text;
			otable3.Cell(2, 1).Range.Text = "Class:  " + TextBox8.Text;
			otable3.Cell(2, 2).Range.Text = "Stream: " + TextBox9.Text;
			DataTable ress = null;
			ress = data.executeSQL("SELECT  (SELECT type.Type_Name FROM type WHERE type.ID=T_id)'Fee Item', amount'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly' ) and `L_id`=(SELECT `level` FROM `class` WHERE `Description`='" + TextBox8.Text + "')");
			int lim = 0;
			lim = ress.Rows.Count;
			int index = 4;
			int sum = 0;
			foreach (DataRow row in ress.Rows) {
				otable3.Cell(index, 1).Range.Text = row[0].ToString().ToUpper();
				otable3.Cell(index, 2).Range.Text = row[1].ToString().ToUpper();
				sum = sum + (row[1]);
				index = index + 1;
			}

			otable3.Cell(11, 2).Range.Text = sum;
			otable3.Cell(12, 2).Range.Text = TextBox4.Text;
			otable3.Cell(13, 2).Range.Text = 0;
			otable3.Cell(14, 2).Range.Text = TextBox6.Text;
			otable3.Cell(15, 1).Range.Text = "Served By:  " + "Admin";
			otable3.Cell(15, 2).Range.Text = "Invoice No: " + "#";
			otable3.Cell(15, 3).Range.Text = "Date  " + DateTimePicker1.Value.ToString();
			oDocs.PrintOut(false);
			oDocs.Close(SaveChanges: false);
			oDocs = null;
			oWord.Quit();
			oWord = null;
		}

		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate val = new validate();
			val.digits(sender, e);
		}


		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextBox15_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox5.Text)) {
				Interaction.MsgBox("enter some value please", MsgBoxStyle.Information, "");
				TextBox5.Focus();
				return;
			}
			if (TextBox4.Text == TextBox6.Text) {
				Interaction.MsgBox("You have not paid any amount", MsgBoxStyle.Information, "");
				TextBox5.Focus();
				return;
			}
			string admn1 = null;
			string method = null;
			admn1 = TextBox1.Text;
			if (RadioButton1.Checked) {
				method = "cash";
			} else if (RadioButton2.Checked) {
				method = "bank slip";
			} else if (RadioButton3.Checked) {
				method = "cheque";
			} else if (RadioButton4.Checked) {
				method = "m pesa";
			}
			string nn = null;
			nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" + admn1 + "', 'Cash Collection','" + method + "', '" + TextBox15.Text + "', '" + TextBox14.Text + "', '', '" + TextBox5.Text + "', '" + TextBox4.Text + "', '" + TextBox6.Text + "', '0', CURRENT_TIMESTAMP);";
			data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" + admn1 + "'");
			data.@add(ref nn);
			Panel5.Enabled = false;
			TextBox1.ReadOnly = false;
			TextBox7.Text = "";
			TextBox8.Text = "";
			TextBox9.Text = "";
			TextBox2.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox6.Text = "";
			TextBox5.Text = "";
		}
		public collect_fees()
		{
			Load += collect_fees_Load;
			InitializeComponent();
		}
	}
}
