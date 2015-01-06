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
	public partial class Form1
	{
		database data = new database();
		public Microsoft.Office.Interop.Word.Document oDocs;
		public Microsoft.Office.Interop.Word.Table otable;
		public Microsoft.Office.Interop.Word.Paragraph para;
		private void Button2_Click(object sender, EventArgs e)
		{
			Microsoft.Office.Interop.Word.Application objWord = null;
			Microsoft.Office.Interop.Word.Document objDoc = null;
			objWord = Interaction.CreateObject("Word.Application");
			objWord.Visible = true;
			objDoc = objWord.Documents.Add();
			int _RowCount = DataGridView1.Rows.Count - 1;
			int _ColCount = DataGridView1.Columns.Count - 1;
			Microsoft.Office.Interop.Word.Table ht1 = null;
			ht1 = objDoc.Tables.Add(objDoc.Bookmarks["\\endofdoc"].Range, _RowCount + 1, _ColCount + 1);
			ht1.Borders.OutsideColor = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
			ht1.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
			ht1.Borders.InsideColor = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
			ht1.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

			for (int i = 0; i <= _RowCount; i++) {
				ht1.Rows.Add();
				for (int _col = 0; _col <= _ColCount; _col++) {
					ht1.Cell(i + 1, _col + 1).Range.Text = DataGridView1.Rows[i].Cells[_col].Value.ToString();
				}
			}
			//objDoc.SaveAs2("C:/tee.docx")
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

		private void Form1_Load(object sender, EventArgs e)
		{
			for (i = 1; i <= 11; i++) {
				ComboBox1.Items.Add(i);
			}
			var _with1 = ComboBox3.Items;
			_with1.Add(1);
			_with1.Add(2);
			_with1.Add(3);
			var _with2 = ComboBox2.Items;
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy") - 2);
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy") - 1);
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy"));
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy") + 1);
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy") + 2);
		}
		private void Button4_Click(object sender, EventArgs e)
		{
			System.Data.DataTable all = null;
			all = data.executeSQL("SELECT `admno`,  ` names` FROM `students` WHERE `class_code` =" + ComboBox1.Text + " and `status`=1");
			DataGridView1.DataSource = data.executeSQL("SELECT `admno`,  ` names` FROM `students` WHERE `class_code` =" + ComboBox1.Text + " and `status`=1");
		}
		private void Button5_Click(object sender, EventArgs e)
		{
			string ss = "SELECT distinct (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject',(SELECT  `score` FROM `marks` WHERE  `Exam_no`=1 and `admno`=" + DataGridView1[0, DataGridView1.CurrentRow.Index].Value.ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + DataGridView2[0, DataGridView2.CurrentRow.Index].Value.ToString() + ")'mark1',(SELECT  `score` FROM `marks` WHERE  `Exam_no`=2  and `admno`=" + DataGridView1[0, DataGridView1.CurrentRow.Index].Value.ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + DataGridView2[0, DataGridView2.CurrentRow.Index].Value.ToString() + ")'mark2' ,(SELECT  `score` FROM `marks` WHERE  `Exam_no`=3 and `admno`=" + DataGridView1[0, DataGridView1.CurrentRow.Index].Value.ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + DataGridView2[0, DataGridView2.CurrentRow.Index].Value.ToString() + ")'mark3'from marks where `admno`=" + DataGridView1[0, DataGridView1.CurrentRow.Index].Value.ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + DataGridView2[0, DataGridView2.CurrentRow.Index].Value.ToString() + "";
			System.Data.DataTable led = data.executeSQL(ss);
			//'   DataGridView2.Rows.Add()
			//For o = 0 To DataGridView3.Columns.Count
			//    DataGridView3.Rows.Insert(o + 1, 1)

			//    DataGridView3.Item(DataGridView3.Rows.Count + 1, o).Value = led.Rows(0).Item(o).ToString
			//Next
			DataGridView3.DataSource = led;


		}
		private void Button6_Click(object sender, EventArgs e)
		{
			string ss = "SELECT distinct `Subject_code`, (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject'  from `marks` where `admno`=" + DataGridView1[0, DataGridView1.CurrentRow.Index].Value.ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text;
			System.Data.DataTable led1 = data.executeSQL(ss);
			DataGridView2.DataSource = led1;

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			System.Data.DataTable all = null;
			all = data.executeSQL("SELECT `admno`,  ` names` FROM `students` WHERE `class_code` =" + ComboBox1.Text + " and `status`=1");
			foreach (DataRow drow in all.Rows) {
				//start to export data to ms word
				var oWord = new Microsoft.Office.Interop.Word.Application { Visible = true };
				oDocs = oWord.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "KIDS ZONE.dotx", , false);
				oDocs.SelectAllEditableRanges();
				Microsoft.Office.Interop.Word.Range rng = null;
				//Dim sel As Word.Selection
				rng = oDocs.Range(ref oDocs.Paragraphs[1].Range.Start, ref oDocs.Tables[4].Range.End);
				rng.Copy();
				otable = oDocs.Tables[1];
				otable.Cell(1, 1).Range.Text = "CHILD'S NAME:  " + drow[1];
				otable.Cell(1, 2).Range.Text = "  ADMNO : " + drow[0];
				//otable.Cell(3, 3).Range.Text = "CLASS  " & drow1(3) & "  " & drow1(2)
				//otable.Cell(3, 2).Range.Text = "TERM " & tr & "  Year " & yr
				//otable.Cell(3, 1).Range.Text = "DATE  " & DateTimePicker1.Value.ToShortDateString

				//read subject and their marks
				System.Data.DataTable subject = null;
				string ss = "SELECT distinct `Subject_code`, (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject'  from `marks` where `admno`=" + drow[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text;
				subject = data.executeSQL(ss);
				int _RowCount = subject.Rows.Count - 1;
				int i = 1;
				string POS = null;
				POS = "SELECT 'POSITION :',(SELECT COUNT(*) FROM `VIEW4` B WHERE B.N>A.N )+1 AS M1,(SELECT COUNT(*) FROM `VIEW4` C WHERE C.M>A.M )+1 AS M2,(SELECT COUNT(*) FROM `VIEW4` D WHERE D.B>A.B )+1 AS M3,(SELECT COUNT(*) FROM `VIEW4` E WHERE E.AVG>A.AVG  )+1 AS M4 FROM VIEW4 A WHERE A.ADMNO=" + drow[0].ToString();
				System.Data.DataTable POSS = data.executeSQL(POS);

				foreach (DataRow srow in subject.Rows) {
					string ss1 = "SELECT distinct (SELECT  `name` FROM `subject` WHERE `code`=`Subject_code`)'Subject',ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=1 and `admno`=" + drow[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0].ToString() + "),0)'mark1', ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=2  and `admno`=" + drow[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0].ToString() + "),0)'mark2' ,ifnull((SELECT  `score` FROM `marks` WHERE  `Exam_no`=3 and `admno`=" + drow[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0].ToString() + "),0)'mark3', ( select distinct (mark1+mark2+mark3)/3 from marks) as h from marks where `admno`=" + drow[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " and `Subject_code`=" + srow[0] + "";
					System.Data.DataTable marks = null;
					marks = data.executeSQL(ss1);
					Microsoft.Office.Interop.Word.Table otable = null;
					otable = oDocs.Tables[2];
					string tots = null;
					tots = "select distinct'Total :', (SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`=" + drow[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " ) n,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`=" + drow[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ) m ,(SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`=" + drow[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ) b,( select distinct (m+n+b)/3 from marks)  from marks";

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
								otable.Cell(i + 1, _col1 + 1).Range.Text = mrow2[_col1].ToString();
							}
						}
					}

				}





				//jj
				oDocs.PrintOut(false);
				oDocs.Close(SaveChanges: false);
				oDocs = null;
				oWord.Quit();
				oWord = null;
			}

		}


		private void Button7_Click(object sender, EventArgs e)
		{
			string GETADMNO = null;
			GETADMNO = " SELECT DISTINCT ADMNO  FROM `marks` WHERE  `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text;
			System.Data.DataTable RED = data.executeSQL(GETADMNO);
			data.@add(ref "TRUNCATE VIEW4");
			foreach (DataRow DROW in RED.Rows) {
				string INSER = null;
				INSER = " INSERT INTO  VIEW4 select distinct ADMNO, IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=1 and `admno`=" + DROW[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + " ),0) n,IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=2 and `admno`=" + DROW[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ),0) m ,IFNULL((SELECT  sum(`score`) FROM `marks` WHERE `Exam_no`=3 and `admno`=" + DROW[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text + "  ),0) b,( select distinct (m+n+b)/3 from marks) AVG  from marks WHERE `admno`=" + DROW[0].ToString() + " and `class_code`=" + ComboBox1.Text + " and `year`=" + ComboBox2.Text + " and `term`= " + ComboBox3.Text;
				data.@add(ref INSER);
			}


		}
		public Form1()
		{
			Load += Form1_Load;
			InitializeComponent();
		}
	}
}
