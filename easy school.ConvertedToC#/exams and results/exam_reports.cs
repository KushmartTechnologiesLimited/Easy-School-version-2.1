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
	public partial class exam_reports
	{
		database data = new database();
		public Microsoft.Office.Interop.Word.Document oDocs;
		public Microsoft.Office.Interop.Word.Table otable;
		public Microsoft.Office.Interop.Word.Paragraph para;
		 class_id;
		List<string> str_id = new List<string>();
		int f = 0;
		string lala;
		private void report_form_Load(object sender, EventArgs e)
		{
			var _with1 = ComboBox2.Items;
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") - 2);
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") - 1);
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy"));
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") + 1);
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") + 2);
			ComboBox2.SelectedIndex = 3;
			var _with2 = ComboBox3.Items;
			for (b = 1; b <= 3; b++) {
				_with2.Add(b);
			}
			ComboBox3.SelectedIndex = 0;
			 // ERROR: Not supported in C#: OnErrorStatement

			System.Data.DataTable rd = null;
			rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`");
			foreach (object drow_loopVariable in rd.Rows) {
				drow = drow_loopVariable;
				ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper);
				class_id.Add(drow.Item(0).ToString.ToUpper);
			}

			ComboBox1.SelectedIndex = 0;
		}


		//
		private void Button3_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			process(false);
			this.Cursor = Cursors.Default;
		}
		private string grade(int mark)
		{
			string grad = "";
			if (mark > 69) {
				grad = "Very good";
			} else if (mark > 49 & mark <= 69) {
				grad = "Good";
			} else if (mark > 29 & mark <= 49) {
				grad = "Emerging";
			} else if (mark <= 29) {
				grad = "Not yet";
			}
			return grad;
		}
		public void nn()
		{
			string cls = null;
			cls = class_id(ComboBox1.SelectedIndex);
			string GETADMNO = null;
			GETADMNO = " SELECT DISTINCT ADMNO  FROM `marks` WHERE  `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text;
			System.Data.DataTable RED = data.executeSQL(GETADMNO);
			data.@add(ref "TRUNCATE VIEW4");
			foreach (DataRow DROW in RED.Rows) {
				string INSER = null;
				INSER = " INSERT INTO  VIEW4 select distinct ADMNO, IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`='" + DROW[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " ),0) n,IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`='" + DROW[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ),0) m ,IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`='" + DROW[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ),0) b,( select distinct (m+n+b)/3 from marks) AVG  from marks WHERE `admno`='" + DROW[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text;
				data.@add(ref INSER);
			}

		}

		private void Button2_Click(object sender, EventArgs e)
		{
		}
		private object process(bool stat)
		{
			nn();
			ProgressBar1.Value = 0;
			string cls = null;
			cls = class_id(ComboBox1.SelectedIndex);
			System.Data.DataTable all = null;
			var oWord = new Microsoft.Office.Interop.Word.Application { Visible = false };
			oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "KIDS ZONE.dotx", , false);
			oDocs.SelectAllEditableRanges();
			Microsoft.Office.Interop.Word.Range rng = null;
			//Dim sel As Word.Selection
			rng = oDocs.Range(ref oDocs.Paragraphs[1].Range.Start, ref oDocs.Tables[4].Range.End);
			rng.Copy();
			all = data.executeSQL("SELECT `admno`,` names`, (SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE `class_code`=" + class_id(ComboBox1.SelectedIndex) + " and `status`=1");
			f = 0;
			foreach (DataRow drow in all.Rows) {
				//start to export data to ms word
				int nn = all.Rows.Count;
				this.Text = nn;
				otable = oDocs.Tables[1];
				otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " + drow[1];
				otable.Cell(1, 2).Range.Text = "  ADMNO : " + drow[0];
				otable.Cell(3, 3).Range.Text = "  " + drow[2] + "  " + drow[3];
				otable.Cell(3, 2).Range.Text = "TERM " + ComboBox3.Text + "  Year " + ComboBox2.Text;
				otable.Cell(3, 1).Range.Text = "DATE  " + DateTimePicker1.Value.ToShortDateString();

				//read subject and their marks
				System.Data.DataTable subject = null;
				string ss = "SELECT distinct `Subject_code`, (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject'  from `marks` where `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text;
				subject = data.executeSQL(ss);
				int _RowCount = subject.Rows.Count - 1;
				int i = 1;
				string POS = null;
				POS = "SELECT 'POSITION :',(SELECT COUNT(*) FROM `VIEW4` B WHERE B.N>A.N )+1 AS M1,(SELECT COUNT(*) FROM `VIEW4` C WHERE C.M>A.M )+1 AS M2,(SELECT COUNT(*) FROM `VIEW4` D WHERE D.B>A.B )+1 AS M3,(SELECT COUNT(*) FROM `VIEW4` E WHERE E.AVG>A.AVG  )+1 AS M4 FROM VIEW4 A WHERE A.ADMNO='" + drow[0].ToString() + "'";
				System.Data.DataTable POSS = data.executeSQL(POS);

				foreach (DataRow srow in subject.Rows) {
					string ss1 = "SELECT distinct (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject',ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=1 and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0].ToString() + "),0)'mark1', ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=2  and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0].ToString() + "),0)'mark2' ,ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=3 and `admno`=" + drow[0].ToString() + " and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0].ToString() + "),0)'mark3', ( select distinct (mark1+mark2+mark3)/3 from marks) as h from marks where `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0] + "";
					System.Data.DataTable marks = null;
					marks = data.executeSQL(ss1);
					Microsoft.Office.Interop.Word.Table otable = null;
					otable = oDocs.Tables[2];
					string tots = null;
					tots = "select distinct'Total :', (SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " ) n,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ) m ,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ) b,( select distinct (m+n+b)/3 from marks)  from marks";

					System.Data.DataTable total = null;
					total = data.executeSQL(tots);
					foreach (DataRow mrow in marks.Rows) {
						int _ColCount = marks.Columns.Count - 1;
						int f = 0;
						for (int _col = 0; _col <= _ColCount; _col++) {
							otable.Cell(i + 1, _col + 1).Range.Text = mrow[_col].ToString();
							f = _col;
						}
						otable.Cell(i + 1, f + 2).Range.Text = grade(mrow[f]);
						//Next
						//End read
						i = i + 1;
						otable.Rows.Add();
						foreach (DataRow mrow1 in total.Rows) {
							int _ColCount1 = total.Columns.Count - 1;
							for (int _col1 = 0; _col1 <= _ColCount1; _col1++) {
								otable.Cell(i + 1, _col1 + 1).Range.Text = mrow1[_col1].ToString();
							}
						}
						foreach (DataRow mrow2 in POSS.Rows) {
							int _ColCount1 = total.Columns.Count - 1;
							for (int _col1 = 0; _col1 <= _ColCount1; _col1++) {
								otable.Cell(i + 2, _col1 + 1).Range.Text = mrow2[_col1].ToString();
							}
						}
					}

				}

				Microsoft.Office.Interop.Word.Table otable3 = null;
				otable3 = oDocs.Tables[3];
				otable3.Cell(1, 1).Range.Text = otable3.Cell(1, 1).Range.Text + "  " + TextBox1.Text;
				// otable3.Cell(1, 1).Range.Text = "GENERAL COMMENTS  " & TextBox1.Text
				otable3.Cell(1, 1).Range.Underline = WdUnderline.wdUnderlineNone;
				otable3.Cell(1, 1).Range.Font.Size = 12;
				Microsoft.Office.Interop.Word.Table otable2 = null;
				otable2 = oDocs.Tables[4];
				otable2.Cell(1, 1).Range.Text = DateTimePicker2.Value.ToShortDateString();
				if (stat == false) {
					oDocs.SaveAs(TextBox2.Text + "/" + drow[1] + " term  " + ComboBox3.Text + " year " + ComboBox2.Text + ".doc");
				} else {
					oDocs.PrintOut(false);
				}
				try {
					oDocs.Undo(ref 1000);

				} catch (Exception ex) {
				}
				f = f + 1;
				ProgressBar1.Value = (f / all.Rows.Count * 100);
				Label7.Text = f + " of " + all.Rows.Count;
			}
			Label7.Text = Label7.Text + " completed !";
			oDocs.Close(SaveChanges: false);
			oDocs = null;
			oWord.Quit();
			oWord = null;
			return 0;
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			process(true);
			//Me.Dispose()
			this.Cursor = Cursors.Default;
		}

		private void Button4_Click(object sender, EventArgs e)
		{
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


		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
		}


		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void Button2_Click_1(object sender, EventArgs e)
		{
			System.Data.DataTable all = null;
			all = data.executeSQL("SELECT `admno`,` names`, (SELECT  class.description FROM class WHERE class.code=`class_code`)'CLass',(SELECT  stream.name FROM stream WHERE stream.code=str_code )'Stream' FROM `students` WHERE `admno`='" + TextBox3.Text + "' and `status`=1");
			f = 0;
			if (all.Rows.Count < 1) {
				Interaction.MsgBox("no record found");
				return;
			}
			nn();
			ProgressBar1.Value = 0;
			string cls = null;
			cls = class_id(ComboBox1.SelectedIndex);

			var oWord = new Microsoft.Office.Interop.Word.Application { Visible = false };
			oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "KIDS ZONE.dotx", , false);
			oDocs.SelectAllEditableRanges();
			Microsoft.Office.Interop.Word.Range rng = null;
			//Dim sel As Word.Selection
			rng = oDocs.Range(ref oDocs.Paragraphs[1].Range.Start, ref oDocs.Tables[4].Range.End);
			rng.Copy();

			foreach (DataRow drow in all.Rows) {
				//start to export data to ms word
				int nn = all.Rows.Count;
				this.Text = nn;
				otable = oDocs.Tables[1];
				otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " + drow[1];
				otable.Cell(1, 2).Range.Text = "  ADMNO : " + drow[0];
				otable.Cell(3, 3).Range.Text = "  " + drow[2] + "  " + drow[3];
				otable.Cell(3, 2).Range.Text = "TERM " + ComboBox3.Text + "  Year " + ComboBox2.Text;
				otable.Cell(3, 1).Range.Text = "DATE  " + DateTimePicker1.Value.ToShortDateString();

				//read subject and their marks
				System.Data.DataTable subject = null;
				string ss = "SELECT distinct `Subject_code`, (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject'  from `marks` where `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text;
				subject = data.executeSQL(ss);
				int _RowCount = subject.Rows.Count - 1;
				int i = 1;
				string POS = null;
				POS = "SELECT 'POSITION :',(SELECT COUNT(*) FROM `VIEW4` B WHERE B.N>A.N )+1 AS M1,(SELECT COUNT(*) FROM `VIEW4` C WHERE C.M>A.M )+1 AS M2,(SELECT COUNT(*) FROM `VIEW4` D WHERE D.B>A.B )+1 AS M3,(SELECT COUNT(*) FROM `VIEW4` E WHERE E.AVG>A.AVG  )+1 AS M4 FROM VIEW4 A WHERE A.ADMNO='" + drow[0].ToString() + "'";
				System.Data.DataTable POSS = data.executeSQL(POS);

				foreach (DataRow srow in subject.Rows) {
					string ss1 = "SELECT distinct (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject',ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=1 and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0].ToString() + "),0)'mark1', ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=2  and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0].ToString() + "),0)'mark2' ,ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=3 and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0].ToString() + "),0)'mark3', ( select distinct (mark1+mark2+mark3)/3 from marks) as h from marks where `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0] + "";
					System.Data.DataTable marks = null;
					marks = data.executeSQL(ss1);
					Microsoft.Office.Interop.Word.Table otable = null;
					otable = oDocs.Tables[2];
					string tots = null;
					tots = "select distinct'Total :', (SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " ) n,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ) m ,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`='" + drow[0].ToString() + "' and `class_code`=" + cls + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ) b,( select distinct (m+n+b)/3 from marks)  from marks";

					System.Data.DataTable total = null;
					total = data.executeSQL(tots);
					foreach (DataRow mrow in marks.Rows) {
						int _ColCount = marks.Columns.Count - 1;
						int f = 0;
						for (int _col = 0; _col <= _ColCount; _col++) {
							otable.Cell(i + 1, _col + 1).Range.Text = mrow[_col].ToString();
							f = _col;
						}
						otable.Cell(i + 1, f + 2).Range.Text = grade(mrow[f]);
						//Next
						//End read
						i = i + 1;
						otable.Rows.Add();
						foreach (DataRow mrow1 in total.Rows) {
							int _ColCount1 = total.Columns.Count - 1;
							for (int _col1 = 0; _col1 <= _ColCount1; _col1++) {
								otable.Cell(i + 1, _col1 + 1).Range.Text = mrow1[_col1].ToString();
							}
						}
						foreach (DataRow mrow2 in POSS.Rows) {
							int _ColCount1 = total.Columns.Count - 1;
							for (int _col1 = 0; _col1 <= _ColCount1; _col1++) {
								otable.Cell(i + 2, _col1 + 1).Range.Text = mrow2[_col1].ToString();
							}
						}
					}

				}

				Microsoft.Office.Interop.Word.Table otable3 = null;
				otable3 = oDocs.Tables[3];
				otable3.Cell(1, 1).Range.Text = otable3.Cell(1, 1).Range.Text + "  " + TextBox1.Text;
				// otable3.Cell(1, 1).Range.Text = "GENERAL COMMENTS  " & TextBox1.Text
				otable3.Cell(1, 1).Range.Underline = WdUnderline.wdUnderlineNone;
				otable3.Cell(1, 1).Range.Font.Size = 12;
				Microsoft.Office.Interop.Word.Table otable2 = null;
				otable2 = oDocs.Tables[4];
				otable2.Cell(1, 1).Range.Text = DateTimePicker2.Value.ToShortDateString();
				oDocs.PrintOut(false);
				try {
					oDocs.Undo(ref 1000);

				} catch (Exception ex) {
				}
				f = f + 1;
				ProgressBar1.Value = (f / all.Rows.Count * 100);
				Label7.Text = f + " of " + all.Rows.Count;
			}
			Label7.Text = Label7.Text + " completed !";
			oDocs.Close(SaveChanges: false);
			oDocs = null;
			oWord.Quit();
			oWord = null;
		}

		private void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButton2.Checked == true) {
				Panel1.Visible = true;
			} else {
				Panel1.Visible = false;
			}
		}

		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButton2.Checked == true) {
				Panel1.Visible = true;
			} else {
				Panel1.Visible = false;
			}
		}


		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}
		public exam_reports()
		{
			Load += report_form_Load;
			InitializeComponent();
		}
	}
}
