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
using Microsoft.Office.Interop.Word;
using System.Drawing.Printing;
namespace easy_school
{

	public partial class prints
	{
		public Microsoft.Office.Interop.Word.Document oDocs;
		public Microsoft.Office.Interop.Word.Table otable;
		public Microsoft.Office.Interop.Word.Paragraph para;
		string lala;
		private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Font f = new Font("Vanada", 10);
			Font s = new Font("Vanada", 20);
			Font z = new Font("Vanada", 15);
			SolidBrush br = new SolidBrush(Color.Black);
			Pen p = new Pen(Color.Black);
			int wt = 350;
			int ht = 900;
			Pen l = null;
			l = new Pen(Color.Black, 0.025f);
			//Dim wt1,ht1 As 
			var _with1 = e.Graphics;
			_with1.DrawRectangle(l, 40f, 50.5f, wt, ht);
			// border of the table
			// .DrawRectangle(l, 40.0F, 50.5F, wt * 2 / 3, 5)




		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (PrintDialog1.ShowDialog() == DialogResult.OK) {
				PrintDocument1.Print();
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Bitmap mpt = null;
			mpt = new Bitmap(this.Width, this.Height);
			System.Drawing.Rectangle rec = default(System.Drawing.Rectangle);
			rec.Width = this.Width;
			rec.Height = this.Height;
			this.DrawToBitmap(mpt, rec);
			PrintDocument Prn = null;
			Prn = new PrintDocument();
			Prn.Print();





		}

		private void Button6_Click(object sender, EventArgs e)
		{
			var oWord = new Microsoft.Office.Interop.Word.Application { Visible = true };
			oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "receipt.dotx", , false);
			Microsoft.Office.Interop.Word.Table otable3 = null;
			otable3 = oDocs.Tables[1];
			otable3.Cell(1, 0).Range.Text = "Names : " + "Samuel Kamau Biu";
			otable3.Cell(1, 2).Range.Text = "Adm No: " + "8257";
			otable3.Cell(2, 1).Range.Text = "Class:  " + "one";
			otable3.Cell(2, 2).Range.Text = "Stream: " + "East";
			for (index = 4; index <= 9; index++) {
				otable3.Cell(index, 1).Range.Text = "Kush";
				otable3.Cell(index, 2).Range.Text = "10000";
			}
			oDocs.PrintOut(false);
			oDocs.Close(SaveChanges: false);
			oDocs = null;
			oWord.Quit();
			oWord = null;
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			for (i = 1055; i <= 10000000; i++) {
				this.Text = i;
				string adm = i;
				string ssql = null;
				string sql = null;
				database data = new database();
				sql = "INSERT INTO `schoolfees`.`students` (`admno`, `regno`, ` names`, `gender`,`DOB`, `adm_date`) VALUES ('" + adm + "', NULL, 'name " + adm + "', ' male ','2014-08-10','2014-08-06 00:00:00');";

				ssql = "INSERT INTO parents (admno ,f_id_no ,id_no)VALUES ('" + adm + "',  '20000000',  '10000000')";
				data.@add(ref sql);
				data.@add(ref ssql);
			}
		}
		public prints()
		{
			InitializeComponent();
		}
	}
}
