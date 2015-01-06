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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;
namespace easy_school
{

	public partial class report_form
	{
		database data = new database();
		public Microsoft.Office.Interop.Word.Document oDocs;
		public Microsoft.Office.Interop.Word.Table otable;
		public Microsoft.Office.Interop.Word.Paragraph para;
		 class_id;
		List<string> str_id = new List<string>();
		string lala;
		// Public connstring As String = "Dsn=school;database=school;option=0;port=3306;server=localhost;uid=school; password=incorrect;"
		public int admno;
		public int yr;
		public int tr;
		public int BLANK;
		public int CLS;
		public int STB;
		public int STBB;
		public int kk;
		public int a;
		public int b;
		string POS;
		string OUT;
		int language3;
		int reading3;
		int comp3;
		int etotal3;
		int lugha3;
		int kusoma3;
		int insha3;
		int ktotal3;
		int maths3;
		int sci3;
		int social3;
		int cre3;
		int total3;
		int language1;
		int reading1;
		int comp1;
		int etotal1;
		int lugha1;
		int kusoma1;
		int insha1;
		int ktotal1;
		int maths1;
		int sci1;
		int social1;
		int cre1;
		int total1;
		int language2;
		int reading2;
		int comp2;
		int etotal2;
		int lugha2;
		int kusoma2;
		int insha2;
		int ktotal2;
		int maths2;
		int sci2;
		int social2;
		int cre2;
		int total2;
		int mark;

		string grad;
		private void Button1_Click(object sender, EventArgs e)
		{
			//   MsgBox(System.AppDomain.CurrentDomain.BaseDirectory.ToString())
			yr = 0;
			tr = 0;
			CLS = 0;
			STBB = 0;
			STB = 0;
			ProgressBar1.Value = 0;
			Label7.Text = "";
			this.Cursor = Cursors.WaitCursor;

			try {
				//otable = oDocs.Tables.Add(oDocs.Bookmarks.Item("\endofdoc").Range, rowsTotal + 1, colsTotal)
				yr = ComboBox1.Text;
				tr = ComboBox2.Text;
				CLS = class_id(ComboBox3.SelectedIndex);
				//C:\Users\sam\Documents\Visual Studio 2012\Projects\school"
				var oWord = new Microsoft.Office.Interop.Word.Application { Visible = true };

				oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "KIDS ZONE.dotx", , false);
				//Dim conn As New OdbcConnection(connstring)
				//Dim cn As New OdbcCommand
				//Dim cmd As New OdbcDataAdapter
				System.Data.DataTable DT = null;
				//Dim dt As DataTable

				//Dim DF As DataSet
				// Dim YR As String = 2012
				//conn.Open()
				//cmd.SelectCommand = New OdbcCommand("SELECT results.admno,students.name,students.stream,students.class FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno", conn)
				//DF = New DataSet("DF")
				//cmd.Fill(DF)
				DT = data.executeSQL("SELECT results.admno,students.` names`,students.`str_code`,students.`class_code` FROM `results`,students WHERE year= " + yr + " and term= " + tr + " and RESULTS.CLASS= " + CLS + " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno");
				//data.executeSQL("SELECT results.admno,students.' names','students.stream','students.class' FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno")
				// DT = DF.Tables(0)
				Microsoft.Office.Interop.Word.Table otable3 = null;
				otable3 = oDocs.Tables[3];
				otable3.Cell(1, 1).Range.Text = otable3.Cell(1, 1).Range.Text + "  " + TextBox1.Text;
				// otable3.Cell(1, 1).Range.Text = "GENERAL COMMENTS  " & TextBox1.Text
				otable3.Cell(1, 1).Range.Underline = WdUnderline.wdUnderlineNone;
				otable3.Cell(1, 1).Range.Font.Size = 12;
				Microsoft.Office.Interop.Word.Table otable2 = null;
				otable2 = oDocs.Tables[4];
				otable2.Cell(1, 1).Range.Text = DateTimePicker2.Value.ToShortDateString();

				STB = DT.Rows.Count;
				STBB = 1;

				foreach (DataRow drow1 in DT.Rows) {
					otable = oDocs.Tables[1];
					otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " + drow1[1];
					otable.Cell(1, 2).Range.Text = "  ADMNO : " + drow1[0];
					otable.Cell(3, 3).Range.Text = "CLASS  " + drow1[3] + "  " + drow1[2];
					otable.Cell(3, 2).Range.Text = "TERM " + tr + "  Year " + yr;
					otable.Cell(3, 1).Range.Text = "DATE  " + DateTimePicker1.Value.ToShortDateString();
					admno = drow1[0];
					cat();
					cat2();
					cat3();
					//MsgBox("HHH")
					oDocs.PrintOut(false);
					Label7.Text = STBB + " of " + STB;
					ProgressBar1.Value = (STBB / STB * 100);
					STBB = STBB + 1;
				}

				oDocs.Close(SaveChanges: false);
				oDocs = null;
				oWord.Quit();
				oWord = null;
				//conn.Close()
				Interaction.MsgBox("PRINT COMPLETED ", MsgBoxStyle.Information, "");
			} catch (Exception d) {
				Interaction.MsgBox(d.Message + Constants.vbTab + "SOME DOCUMENTS MIGHT NOT HAVE PROCESED");
			}
			this.Cursor = Cursors.Default;
			yr = 0;
			tr = 0;
			CLS = 0;
			STBB = 0;
			STB = 0;
			ProgressBar1.Value = 0;
			Label7.Text = "";
		}
		private void cat()
		{
			try {
				Microsoft.Office.Interop.Word.Table otable = null;
				otable = oDocs.Tables[2];
				//Dim conn As New OdbcConnection(connstring)
				//Dim cmd1 As New OdbcDataAdapter
				System.Data.DataTable DT1 = null;
				//Dim DF1 As DataSet
				//conn.Open()
				OUT = "(SELECT count( * ) FROM results where  year= " + yr + " and term= " + tr + " and RESULTS.CLASS= " + CLS + " and exam=1)";
				POS = "(SELECT (SELECT count( * ) FROM results b WHERE b.total > a.total  AND TERM=" + tr + " and RESULTS.CLASS= " + CLS + "  AND YEAR= " + yr + " AND EXAM=1 ) +1 AS Rank FROM results a WHERE ADMNO =" + admno + " and RESULTS.CLASS= " + CLS + " AND TERM=" + tr + "  AND YEAR= " + yr + " AND EXAM=1 ORDER BY rank )";
				//cmd1.SelectCommand = New OdbcCommand("SELECT *," & POS & "," & OUT & " From results where admno=" & admno & " and RESULTS.CLASS= " & CLS & " and year= " & yr & " and term= " & tr & " and exam=1;", conn)
				//DF1 = New DataSet("DF")
				//cmd1.Fill(DF1)
				//DT1 = DF1.Tables(0)
				DT1 = data.executeSQL("SELECT *," + POS + "," + OUT + " From results where admno=" + admno + " and RESULTS.CLASS= " + CLS + " and year= " + yr + " and term= " + tr + " and exam=1;");
				if (DT1.Rows.Count < 1) {
					BLANK = 2;
					GTY();
					setzero1();
				}

				foreach (DataRow CAT1 in DT1.Rows) {
					otable.Cell(2, 2).Range.Text = CAT1[13];
					otable.Cell(3, 2).Range.Text = CAT1[14];
					otable.Cell(4, 2).Range.Text = CAT1[15];
					otable.Cell(5, 2).Range.Text = CAT1[6];
					otable.Cell(7, 2).Range.Text = CAT1[16];
					otable.Cell(8, 2).Range.Text = CAT1[17];
					otable.Cell(9, 2).Range.Text = CAT1[18];
					otable.Cell(10, 2).Range.Text = CAT1[7];
					otable.Cell(12, 2).Range.Text = CAT1[5];
					otable.Cell(13, 2).Range.Text = CAT1[9];
					otable.Cell(14, 2).Range.Text = CAT1[8];
					//otable.Cell(16, 2).Range.Text = ("sci")
					otable.Cell(17, 2).Range.Text = CAT1[20];
					otable.Cell(18, 2).Range.Text = CAT1[23];
					otable.Cell(19, 2).Range.Text = CAT1[21];
					//otable.Cell(20, 2).Range.Text = ("art")
					otable.Cell(21, 2).Range.Text = CAT1[22];
					otable.Cell(23, 2).Range.Text = CAT1[10];
					otable.Cell(24, 2).Range.Text = Strings.Format((CAT1[10] / 5), "0.0");
					otable.Cell(25, 2).Range.Text = CAT1[25];
					otable.Cell(26, 2).Range.Text = CAT1[26];
					kk = CAT1[12];
					markj();
					////////



					//\\\\
					language1 = CAT1[13];
					reading1 = CAT1[14];
					comp1 = CAT1[15];
					etotal1 = CAT1[6];
					lugha1 = CAT1[16];
					kusoma1 = CAT1[17];
					insha1 = CAT1[18];
					ktotal1 = CAT1[7];
					maths1 = CAT1[5];
					sci1 = CAT1[9];
					social1 = CAT1[8];
					//otable.Cell(16,  3).Range.Text = ("sci")
					//cre1 = CAT1(20)
					//otable.Cell(18, 3).Range.Text = CAT2(23)
					//otable.Cell(19, 3).Range.Text = CAT2(21)
					//'otable.Cell(20,  3).Range.Text = ("art")
					//otable.Cell(21, 3).Range.Text = CAT2(22)
					total1 = CAT1[10];
					//otable.Cell(24, 3).Range.Text = Format((CAT2(10) / 5), "0.0")
					//otable.Cell(25, 3).Range.Text = CAT2(25)
					//otable.Cell(26, 3).Range.Text = CAT2(26)

					/////////
				}
			} catch (Exception EX) {
				Interaction.MsgBox(EX.Message, , 11);
			}

		}
		private void cat2()
		{
			try {
				Microsoft.Office.Interop.Word.Table otable = null;
				otable = oDocs.Tables[2];
				//Dim conn As New OdbcConnection(connstring)
				//Dim cmd2 As New OdbcDataAdapter
				System.Data.DataTable DT2 = null;
				//Dim DF2 As DataSet
				//conn.Open()
				OUT = "(SELECT count( * ) FROM results where  year= " + yr + " and term= " + tr + " and RESULTS.CLASS= " + CLS + " and exam=2)";
				POS = "(SELECT (SELECT count( * ) FROM results b WHERE b.total > a.total  AND TERM=" + tr + " and RESULTS.CLASS= " + CLS + "  AND YEAR= " + yr + " AND EXAM=2 ) +1 AS Rank FROM results a WHERE ADMNO =" + admno + " and RESULTS.CLASS= " + CLS + " AND TERM=" + tr + "  AND YEAR= " + yr + " AND EXAM=2 ORDER BY rank )";
				//cmd2.SelectCommand = New OdbcCommand("SELECT *," & POS & "," & OUT & " From results where admno=" & admno & " and RESULTS.CLASS= " & CLS & " and year= " & yr & " and term= " & tr & " and exam=2;", conn)
				//DF2 = New DataSet("DF")
				//cmd2.Fill(DF2)
				DT2 = data.executeSQL("SELECT *," + POS + "," + OUT + " From results where admno=" + admno + " and RESULTS.CLASS= " + CLS + " and year= " + yr + " and term= " + tr + " and exam=2;");
				//DT2 = DF2.Tables(0)
				if (DT2.Rows.Count < 1) {
					BLANK = 3;
					GTY();
					setzero2();
				}

				foreach (DataRow CAT2 in DT2.Rows) {
					otable.Cell(2, 3).Range.Text = CAT2[13];
					otable.Cell(3, 3).Range.Text = CAT2[14];
					otable.Cell(4, 3).Range.Text = CAT2[15];
					otable.Cell(5, 3).Range.Text = CAT2[6];
					otable.Cell(7, 3).Range.Text = CAT2[16];
					otable.Cell(8, 3).Range.Text = CAT2[17];
					otable.Cell(9, 3).Range.Text = CAT2[18];
					otable.Cell(10, 3).Range.Text = CAT2[7];
					otable.Cell(12, 3).Range.Text = CAT2[5];
					otable.Cell(13, 3).Range.Text = CAT2[9];
					otable.Cell(14, 3).Range.Text = CAT2[8];
					//otable.Cell(16,  3).Range.Text = ("sci")
					otable.Cell(17, 3).Range.Text = CAT2[20];
					otable.Cell(18, 3).Range.Text = CAT2[23];
					otable.Cell(19, 3).Range.Text = CAT2[21];
					//otable.Cell(20,  3).Range.Text = ("art")
					otable.Cell(21, 3).Range.Text = CAT2[22];
					otable.Cell(23, 3).Range.Text = CAT2[10];
					otable.Cell(24, 3).Range.Text = Strings.Format((CAT2[10] / 5), "0.0");
					otable.Cell(25, 3).Range.Text = CAT2[25];
					otable.Cell(26, 3).Range.Text = CAT2[26];
					kk = CAT2[12];
					markj();



					//\\\\
					language2 = CAT2[13];
					reading2 = CAT2[14];
					comp2 = CAT2[15];
					etotal2 = CAT2[6];
					lugha2 = CAT2[16];
					kusoma2 = CAT2[17];
					insha2 = CAT2[18];
					ktotal2 = CAT2[7];
					maths2 = CAT2[5];
					sci2 = CAT2[9];
					social2 = CAT2[8];
					//otable.Cell(16,  3).Range.Text = ("sci")
					//  cre2 = CAT2(20)
					//otable.Cell(18, 3).Range.Text = CAT2(23)
					//otable.Cell(19, 3).Range.Text = CAT2(21)
					//'otable.Cell(20,  3).Range.Text = ("art")
					//otable.Cell(21, 3).Range.Text = CAT2(22)
					total2 = CAT2[10];
					//otable.Cell(24, 3).Range.Text = Format((CAT2(10) / 5), "0.0")
					//otable.Cell(25, 3).Range.Text = CAT2(25)
					//otable.Cell(26, 3).Range.Text = CAT2(26)

					//\\\\\
				}

			} catch (Exception EX) {
				Interaction.MsgBox(EX.Message, , 22);
			}
		}
		//'end term

		private void cat3()
		{
			//Try
			Microsoft.Office.Interop.Word.Table otable = null;
			otable = oDocs.Tables[2];
			//Dim conn As New OdbcConnection(connstring)
			//Dim cmd3 As New OdbcDataAdapter
			System.Data.DataTable DT3 = null;
			//Dim DF3 As DataSet
			//conn.Open()
			OUT = "(SELECT count( * ) FROM results where  year= " + yr + " and term= " + tr + " and RESULTS.CLASS= " + CLS + " and exam=3)";
			POS = "(SELECT (SELECT count( * ) FROM results b WHERE b.total > a.total  AND TERM=" + tr + " and RESULTS.CLASS= " + CLS + "  AND YEAR= " + yr + " AND EXAM=3 ) +1 AS Rank FROM results a WHERE ADMNO =" + admno + " and RESULTS.CLASS= " + CLS + " AND TERM=" + tr + "  AND YEAR= " + yr + " AND EXAM=3 ORDER BY rank )";
			//cmd3.SelectCommand = New OdbcCommand("SELECT *," & POS & "," & OUT & " From results where admno=" & admno & " and RESULTS.CLASS= " & CLS & " and year= " & yr & " and term= " & tr & " and exam=3;", conn)
			//DF3 = New DataSet("DF")
			//cmd3.Fill(DF3)
			//DT3 = DF3.Tables(0)
			DT3 = data.executeSQL("SELECT *," + POS + "," + OUT + " From results where admno=" + admno + " and RESULTS.CLASS= " + CLS + " and year= " + yr + " and term= " + tr + " and exam=3;");
			if (DT3.Rows.Count < 1) {
				BLANK = 4;
				GTY();
				setzero3();

			}
			foreach (DataRow CAT3 in DT3.Rows) {
				otable.Cell(2, 4).Range.Text = CAT3[13];
				otable.Cell(3, 4).Range.Text = CAT3[14];
				otable.Cell(4, 4).Range.Text = CAT3[15];
				otable.Cell(5, 4).Range.Text = CAT3[6];
				otable.Cell(7, 4).Range.Text = CAT3[16];
				otable.Cell(8, 4).Range.Text = CAT3[17];
				otable.Cell(9, 4).Range.Text = CAT3[18];
				otable.Cell(10, 4).Range.Text = CAT3[7];
				otable.Cell(12, 4).Range.Text = CAT3[5];
				otable.Cell(13, 4).Range.Text = CAT3[9];
				otable.Cell(14, 4).Range.Text = CAT3[8];
				//otable.Cell(16,  3).Range.Text = ("sci")
				otable.Cell(17, 4).Range.Text = CAT3[20];
				otable.Cell(18, 4).Range.Text = CAT3[23];
				otable.Cell(19, 4).Range.Text = CAT3[21];
				//otable.Cell(20,  3).Range.Text = ("art")
				otable.Cell(21, 4).Range.Text = CAT3[22];
				otable.Cell(23, 4).Range.Text = CAT3[10];
				otable.Cell(24, 4).Range.Text = Strings.Format((CAT3[10] / 5), "0.0");
				otable.Cell(25, 4).Range.Text = CAT3[25];
				otable.Cell(26, 4).Range.Text = CAT3[26];
				kk = CAT3[12];
				markj();
				//\\\\
				language3 = CAT3[13];
				reading3 = CAT3[14];
				comp3 = CAT3[15];
				etotal3 = CAT3[6];
				lugha3 = CAT3[16];
				kusoma3 = CAT3[17];
				insha3 = CAT3[18];
				ktotal3 = CAT3[7];
				maths3 = CAT3[5];
				sci3 = CAT3[9];
				social3 = CAT3[8];
				//otable.Cell(16,  3).Range.Text = ("sci")
				// cre3 = CAT3(30)
				//otable.Cell(18, 3).Range.Text = CAT3(33)
				//otable.Cell(19, 3).Range.Text = CAT3(31)
				//'otable.Cell(30,  3).Range.Text = ("art")
				//otable.Cell(31, 3).Range.Text = CAT3(33)
				total3 = CAT3[10];
				//otable.Cell(24, 3).Range.Text = Format((CAT2(10) / 5), "0.0")
				//otable.Cell(25, 3).Range.Text = CAT2(25)
				//otable.Cell(26, 3).Range.Text = CAT2(26)

			}
			// Catch EX As Exception
			//  MsgBox(EX.Message, , 333)
			//End Try
		}
		private void GTY()
		{
			Microsoft.Office.Interop.Word.Table otable = null;
			otable = oDocs.Tables[2];
			otable.Cell(2, BLANK).Range.Text = " _";
			otable.Cell(3, BLANK).Range.Text = " _";
			otable.Cell(4, BLANK).Range.Text = " _";
			otable.Cell(5, BLANK).Range.Text = " _";
			otable.Cell(7, BLANK).Range.Text = " _";
			otable.Cell(8, BLANK).Range.Text = " _";
			otable.Cell(9, BLANK).Range.Text = " _";
			otable.Cell(10, BLANK).Range.Text = " _";
			otable.Cell(12, BLANK).Range.Text = " _";
			otable.Cell(13, BLANK).Range.Text = " _";
			otable.Cell(14, BLANK).Range.Text = " _";
			//otable.Cell(16, BLANK).Range.Text = ("sci")
			otable.Cell(17, BLANK).Range.Text = " _";
			otable.Cell(18, BLANK).Range.Text = " _";
			otable.Cell(19, BLANK).Range.Text = " _";
			//otable.Cell(20, BLANK).Range.Text = ("art")
			otable.Cell(21, BLANK).Range.Text = " _";
			otable.Cell(23, BLANK).Range.Text = " _";
			otable.Cell(24, BLANK).Range.Text = " _";
			otable.Cell(25, BLANK).Range.Text = " _";
			otable.Cell(26, BLANK).Range.Text = " _";
		}


		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
		private void grade()
		{
			if (mark > 69) {
				grad = "Very good";
			} else if (mark > 49 & mark <= 69) {
				grad = "Good";
			} else if (mark > 29 & mark <= 69) {
				grad = "Emerging";
			} else if (mark <= 29) {
				grad = "Not yet";
			}

		}
		private void report_form_Load(object sender, EventArgs e)
		{
			var _with1 = ComboBox1.Items;
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") - 2);
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") - 1);
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy"));
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") + 1);
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") + 2);
			ComboBox1.SelectedIndex = 3;
			var _with2 = ComboBox2.Items;
			for (b = 1; b <= 3; b++) {
				_with2.Add(b);
			}
			ComboBox2.SelectedIndex = 0;
			 // ERROR: Not supported in C#: OnErrorStatement

			System.Data.DataTable rd = null;
			rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`");
			foreach (object drow_loopVariable in rd.Rows) {
				drow = drow_loopVariable;
				ComboBox3.Items.Add(drow.Item(1).ToString.ToUpper);
				class_id.Add(drow.Item(0).ToString.ToUpper);
			}

			ComboBox3.SelectedIndex = 0;
		}



		private void markj()
		{
			//Dim conn As New OdbcConnection(connstring)
			string sqk = null;
			sqk = "update results set position=0 where examno =" + kk;
			//  MsgBox(sqk)
			data.add1(sqk);
			//Try
			//    Dim md As New OdbcCommand(sqk, conn)
			//    conn.Open()
			//    'md.Connection = conn
			//    Dim reader As OdbcDataReader = md.ExecuteReader
			//    conn.Close()
			//Catch V As Exception
			//    MsgBox(V.Message, , 44)
			//End Try
		}


		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			//   MsgBox(System.AppDomain.CurrentDomain.BaseDirectory.ToString())
			yr = 0;
			tr = 0;
			CLS = 0;
			STBB = 0;
			STB = 0;
			ProgressBar1.Value = 0;
			Label7.Text = "";
			this.Cursor = Cursors.WaitCursor;
			// Try

			//otable = oDocs.Tables.Add(oDocs.Bookmarks.Item("\endofdoc").Range, rowsTotal + 1, colsTotal)
			yr = ComboBox1.Text;
			tr = ComboBox2.Text;
			CLS = class_id(ComboBox3.SelectedIndex);
			//C:\Users\sam\Documents\Visual Studio 2012\Projects\school"
			var oWord = new Microsoft.Office.Interop.Word.Application { Visible = true };

			oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "KIDS ZONE.dotx", , false);
			oDocs.SelectAllEditableRanges();
			Microsoft.Office.Interop.Word.Range rng = null;
			//Dim sel As Word.Selection
			rng = oDocs.Range(ref oDocs.Paragraphs[1].Range.Start, ref oDocs.Tables[4].Range.End);

			rng.Copy();

			//Dim conn As New OdbcConnection(connstring)
			//Dim cn As New OdbcCommand
			//Dim cmd As New OdbcDataAdapter
			System.Data.DataTable DT = null;
			//Dim DF As DataSet
			// Dim YR As String = 2012
			//conn.Open()
			//cmd.SelectCommand = New OdbcCommand("SELECT results.admno,students.name,students.stream,students.class FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno", conn)
			//DF = New DataSet("DF")
			//cmd.Fill(DF)
			//DT = DF.Tables(0)
			DT = data.executeSQL("SELECT results.admno,students.` names`,students.`str_code`,students.`class_code` FROM `results`,students WHERE year= " + yr + " and term= " + tr + " and RESULTS.CLASS= " + CLS + " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno");
			//DT = data.executeSQL("SELECT results.admno,students.name,students.stream,students.class FROM `results`,students WHERE year= " & yr & " and term= " & tr & " and RESULTS.CLASS= " & CLS & " and results.admno=students.admno  and results.position=0 and `status`=1  group by students.admno")
			Microsoft.Office.Interop.Word.Table otable3 = null;
			otable3 = oDocs.Tables[3];
			otable3.Cell(1, 1).Range.Text = otable3.Cell(1, 1).Range.Text + "  " + TextBox1.Text;
			// otable3.Cell(1, 1).Range.Text = "GENERAL COMMENTS  " & TextBox1.Text
			otable3.Cell(1, 1).Range.Underline = WdUnderline.wdUnderlineNone;
			otable3.Cell(1, 1).Range.Font.Size = 12;
			Microsoft.Office.Interop.Word.Table otable2 = null;
			otable2 = oDocs.Tables[4];
			otable2.Cell(1, 1).Range.Text = DateTimePicker2.Value.ToShortDateString();

			STB = DT.Rows.Count;
			STBB = 1;
			//For nm = 1 To STB - 1
			//    oWord.Selection.Paste()
			//Next

			foreach (DataRow drow1 in DT.Rows) {
				otable = oDocs.Tables[1];
				otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " + drow1[1];
				otable.Cell(1, 2).Range.Text = "  ADMNO : " + drow1[0];
				otable.Cell(3, 3).Range.Text = "CLASS  " + drow1[3] + "  " + drow1[2];
				otable.Cell(3, 2).Range.Text = "TERM " + tr + "  Year " + yr;
				otable.Cell(3, 1).Range.Text = "DATE  " + DateTimePicker1.Value.ToShortDateString();
				admno = drow1[0];
				cat();
				cat2();
				cat3();
				sum();

				//MsgBox("HHH")
				//        oDocs.PrintOut(False)
				Label7.Text = STBB + " of " + STB;
				ProgressBar1.Value = (STBB / STB * 100);
				STBB = STBB + 1;
				//oDocs.
				//MsgBox("")
				oDocs.SaveAs(lala + "/" + drow1[1] + " term  " + tr + " year " + yr + ".doc");

			}

			oDocs.Close(SaveChanges: false);
			oDocs = null;
			oWord.Quit();
			oWord = null;
			//conn.Close()
			Interaction.MsgBox("PRINT COMPLETED ", MsgBoxStyle.Information, "");
			//Catch d As Exception
			//MsgBox(d.Message & vbTab & "SOME DOCUMENTS MIGHT NOT HAVE PROCESED")
			//End Try
			this.Cursor = Cursors.Default;
			yr = 0;
			tr = 0;
			CLS = 0;
			STBB = 0;
			STB = 0;
			ProgressBar1.Value = 0;
			Label7.Text = "";
		}


		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			//SaveFileDialog1.ShowDialog()
			//Dim blah As String = SaveFileDialog1.FileName("kush.doc")

			//'SaveFileDialog1.FileName = "backup"
			//'SaveFileDialog1.DefaultExt = ".doc"

			//Dim meh As Integer = blah.LastIndexOf("\")
			//lala = blah.Substring(0, meh)
			//Dim path As String = lala
			//TextBox2.Text = lala
			SaveFileDialog1.ShowDialog();
			string blah = SaveFileDialog1.FileName();
			//Dim saveDlg As New SaveFileDialog()
			SaveFileDialog1.FileName = "backup";
			SaveFileDialog1.DefaultExt = ".doc";
			//saveDlg.InitialDirectory = "."
			SaveFileDialog1.InitialDirectory = ".";
			SaveFileDialog1.Filter = "BackUp (*.doc)|*.doc";
			SaveFileDialog1.RestoreDirectory = true;
			SaveFileDialog1.FileName = "Back up";



			int meh = blah.LastIndexOf("\\");
			lala = blah.Substring(0, meh);
			string path = lala;
			TextBox2.Text = lala;
		}
		private void sum()
		{
			Microsoft.Office.Interop.Word.Table otable = null;
			otable = oDocs.Tables[2];
			int language = 0;
			int reading = 0;
			int comp = 0;
			int etotal = 0;
			int lugha = 0;
			int kusoma = 0;
			int insha = 0;
			int ktotal = 0;
			int maths = 0;
			int sci = 0;
			int social = 0;
			int cre = 0;
			int total = 0;
			language = Strings.Format((language1 + language2 + language3) / 3, "0.0");
			mark = language;
			grade();
			otable.Cell(2, 5).Range.Text = language;
			//otable.Cell(2, 6).Range.Text = grad
			mark = 0;

			reading = Strings.Format((reading1 + reading2 + reading3) / 3, "0.0");
			mark = reading;
			grade();
			otable.Cell(3, 5).Range.Text = mark;
			//otable.Cell(3, 6).Range.Text = grad
			mark = 0;
			comp = Strings.Format((comp1 + comp2 + comp3) / 3, "0.0");
			mark = comp;
			grade();
			otable.Cell(4, 5).Range.Text = mark;
			//otable.Cell(4, 6).Range.Text = grad
			mark = 0;
			etotal = Strings.Format((etotal1 + etotal2 + etotal3) / 3, "0.0");
			mark = etotal;
			grade();
			otable.Cell(5, 5).Range.Text = mark;
			otable.Cell(5, 6).Range.Text = grad;
			mark = 0;
			lugha = Strings.Format((lugha1 + lugha2 + lugha3) / 3, "0.0");
			mark = lugha;
			grade();
			otable.Cell(7, 5).Range.Text = mark;
			//otable.Cell(7, 6).Range.Text = grad
			mark = 0;
			kusoma = Strings.Format((kusoma1 + kusoma2 + kusoma3) / 3, "0.0");
			mark = kusoma;
			grade();
			otable.Cell(8, 5).Range.Text = mark;
			//otable.Cell(8, 6).Range.Text = grad
			mark = 0;
			insha = Strings.Format((insha1 + insha2 + insha3) / 3, "0.0");
			mark = insha;
			grade();
			otable.Cell(9, 5).Range.Text = mark;
			//otable.Cell(9, 6).Range.Text = grad
			mark = 0;
			ktotal = Strings.Format((ktotal1 + ktotal2 + ktotal3) / 3, "0.0");
			mark = ktotal;
			grade();
			otable.Cell(10, 5).Range.Text = mark;
			otable.Cell(10, 6).Range.Text = grad;
			mark = 0;
			maths = Strings.Format((maths1 + maths2 + maths3) / 3, "0.0");
			mark = maths;
			grade();
			otable.Cell(12, 5).Range.Text = mark;
			otable.Cell(12, 6).Range.Text = grad;
			mark = 0;
			sci = Strings.Format((sci1 + sci2 + sci3) / 3, "0.0");
			mark = sci;
			grade();
			otable.Cell(13, 5).Range.Text = mark;
			otable.Cell(13, 6).Range.Text = grad;
			mark = 0;
			social = Strings.Format((social1 + social2 + social3) / 3, "0.0");
			mark = social;
			grade();
			otable.Cell(14, 5).Range.Text = mark;
			otable.Cell(14, 6).Range.Text = grad;
			//cre = Format((cre1 + cre2 + cre3) / 3, "0.0")
			//mark = cre
			//grade()
			//otable.Cell(15, 5).Range.Text = mark
			//otable.Cell(15, 6).Range.Text = grad
			mark = 0;
			total = Strings.Format((total1 + total2 + total3) / 3, "0.0");
			mark = (total / 5);
			grade();
			otable.Cell(23, 5).Range.Text = total;
			otable.Cell(24, 5).Range.Text = mark;
			otable.Cell(24, 6).Range.Text = grad;
			mark = 0;

		}
		private void setzero3()
		{
			language3 = 0;
			reading3 = 0;
			comp3 = 0;
			etotal3 = 0;
			lugha3 = 0;
			kusoma3 = 0;
			insha3 = 0;
			ktotal3 = 0;
			maths3 = 0;
			sci3 = 0;
			social3 = 0;
			total3 = 0;
		}
		private void setzero2()
		{
			language2 = 0;
			reading2 = 0;
			comp2 = 0;
			etotal2 = 0;
			lugha2 = 0;
			kusoma2 = 0;
			insha2 = 0;
			ktotal2 = 0;
			maths2 = 0;
			sci2 = 0;
			social2 = 0;
			total2 = 0;
		}
		private void setzero1()
		{
			language1 = 0;
			reading1 = 0;
			comp1 = 0;
			etotal1 = 0;
			lugha1 = 0;
			kusoma1 = 0;
			insha1 = 0;
			ktotal1 = 0;
			maths1 = 0;
			sci1 = 0;
			social1 = 0;
			total1 = 0;
		}
		public report_form()
		{
			Load += report_form_Load;
			InitializeComponent();
		}
	}
}
