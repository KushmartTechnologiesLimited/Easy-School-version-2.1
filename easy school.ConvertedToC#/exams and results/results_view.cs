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
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;
namespace easy_school
{

	public partial class Form5
	{
		database data = new database();
		public string connstring = "Dsn=school;database=school;option=0;port=3306;server=localhost;uid=school; password=incorrect;";
		public string term;
		public string exam;
		public string CLSS;
		public string Year;

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
		private void assign()
		{
			Year = ComboBox1.Text;
			term = ComboBox2.Text;
			CLSS = ComboBox3.Text;
			exam = ComboBox4.Text;

		}
		private void Form5_Load(object sender, EventArgs e)
		{
			var _with1 = ComboBox1.Items;
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") - 2);
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") - 1);
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy"));
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") + 1);
			_with1.Add(Strings.Format(DateAndTime.Now, "yyyy") + 2);
			ComboBox1.SelectedIndex = 2;
			var _with2 = ComboBox2.Items;
			for (b = 1; b <= 3; b++) {
				_with2.Add(b);
			}
			ComboBox2.SelectedIndex = 0;
			var _with3 = ComboBox3.Items;
			for (t = 1; t <= 8; t++) {
				_with3.Add(t);
			}
			var _with4 = ComboBox4.Items;
			for (b = 1; b <= 3; b++) {
				_with4.Add(b);
			}
			ComboBox4.SelectedIndex = 2;
			//Dim mh As New OdbcDataAdapter
			//Dim DS As DataSet
			//Dim DTABLE As System.Data.DataTable
			//Dim I As Integer
			TextBox1.Text = "TERM " + My.MyProject.Forms.Form2.term + "  EXAM  " + My.MyProject.Forms.Form2.exam + " OF CLASS  " + My.MyProject.Forms.Form2.CLSS + "  YEAR " + My.MyProject.Forms.Form2.year;
			System.Data.DataTable led = null;
			led = data.executeSQL("select admNo,grammer, reading, composition ,eng, lugha, kusoma, insha, kisw,maths,sci,social, cre, total, position'STATUS' from RESULTS WHERE YEAR=" + My.MyProject.Forms.Form2.year + " AND EXAM=" + My.MyProject.Forms.Form2.exam + " AND CLASS=" + My.MyProject.Forms.Form2.CLSS + " AND TERM=" + My.MyProject.Forms.Form2.term + ";");
			DataGridView1.DataSource = led;

			try {
				//    Dim conn As New OdbcConnection(connstring)
				//    Dim cn As New OdbcCommand
				//    Dim v As Integer
				//    If conn.State = ConnectionState.Open Then
				//        conn.Close()
				//    End If
				//    mh.SelectCommand = New OdbcCommand("select admNo,grammer, reading, composition ,eng, lugha, kusoma, insha, kisw,maths,sci,social, cre, total, position'STATUS' from RESULTS WHERE YEAR=" & Form2.year & " AND EXAM=" & Form2.exam & " AND CLASS=" & Form2.CLSS & " AND TERM=" & Form2.term & ";", conn)
				//    DS = New DataSet("STUDENTS")
				//    mh.Fill(DS, "STUDENTS")
				//    DTABLE = DS.Tables(0)
				//    v = DTABLE.Rows.Count
				//    If v < 1 Then
				//        MsgBox("no record found ", , "")
				//        Exit Sub
				//    End If
				//DataGridView1.DataSource = DS.Tables("STUDENTS").DefaultView
				for (I = 0; I <= 14; I++) {
					DataGridView1.AutoResizeColumn(I);

				}
				//conn.Open()
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void search()
		{
			//Dim mh As New OdbcDataAdapter
			//Dim DS As DataSet
			//Dim DTABLE As System.Data.DataTable
			//Dim I As Integer
			TextBox1.Text = "TERM " + term + "  EXAM  " + exam + " OF CLASS  " + CLSS + "  YEAR " + Year;
			try {
				System.Data.DataTable led = null;
				led = data.executeSQL("select students.name,results.admNo,grammer, reading, composition ,eng, lugha, kusoma, insha, kisw,maths,sci,social, cre, total, position'STATUS' from students, RESULTS WHERE students.admno=results.admno and  YEAR=" + Year + " AND EXAM=" + exam + " AND results.CLASS=" + CLSS + " AND TERM=" + term + " order by total desc;");
				DataGridView1.DataSource = led;
				//Dim conn As New OdbcConnection(connstring)
				//Dim cn As New OdbcCommand
				//Dim v As Integer
				//If conn.State = ConnectionState.Open Then
				//    conn.Close()
				//End If
				//mh.SelectCommand = New OdbcCommand("select students.name,results.admNo,grammer, reading, composition ,eng, lugha, kusoma, insha, kisw,maths,sci,social, cre, total, position'STATUS' from students, RESULTS WHERE students.admno=results.admno and  YEAR=" & Year & " AND EXAM=" & exam & " AND results.CLASS=" & CLSS & " AND TERM=" & term & " order by total desc;", conn)
				//DS = New DataSet("STUDENTS")
				//mh.Fill(DS, "STUDENTS")
				//DTABLE = DS.Tables(0)
				//v = DTABLE.Rows.Count
				//If v < 1 Then
				//    MsgBox("no record found ", , "")
				//    DataGridView1.DataSource = DS.Tables("STUDENTS").DefaultView
				//    Exit Sub
				//End If
				//DataGridView1.DataSource = DS.Tables("STUDENTS").DefaultView
				//For I = 0 To 14
				//    DataGridView1.AutoResizeColumn(I)

				//Next
				//conn.Open()
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			if (DataGridView1.RowCount == null) {
				MessageBox.Show("Sorry nothing to export into excel sheet.." + Constants.vbCrLf + "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			short rowsTotal = 0;
			short colsTotal = 0;
			short I = 0;
			short j = 0;
			short iC = 0;
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
			Excel.Application xlApp = new Excel.Application();

			try {
				Excel.Workbook excelBook = xlApp.Workbooks.Add();
				Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
				xlApp.Visible = true;
				rowsTotal = DataGridView1.RowCount - 1;
				colsTotal = DataGridView1.Columns.Count - 1;
				var _with5 = excelWorksheet;
				_with5.Cells.Select();
				_with5.Cells.Delete();
				for (iC = 0; iC <= colsTotal; iC++) {
					_with5.Cells(1, iC + 1).Value = DataGridView1.Columns[iC].HeaderText;
				}
				for (I = 0; I <= rowsTotal; I++) {
					for (j = 0; j <= colsTotal; j++) {
						_with5.Cells(I + 2, j + 1).value = DataGridView1.Rows[I].Cells[j].Value;
					}
				}

				//.Cells.Columns.AutoFit()
				//.Cells.Select()
				// .Cells.EntireColumn.AutoFit()
				_with5.Cells(1, 1).Select();
				_with5.SaveAs(TextBox1.Text + "_" + Strings.Format(DateAndTime.Now, "MMMM ss ") + ".xlsx");
				GC.Collect();
				GC.WaitForFullGCComplete();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				// xlApp.(TextBox1.Text & "_" & Format(Now, "MMMM dd ") & ".xlsx")
				//RELEASE ALLOACTED RESOURCES
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
				//xlApp.SaveWorkspace("D:\" & TextBox1.Text & ".XLW")
				xlApp = null;
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			assign();
			search();



		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			assign();
		}

		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			assign();
		}

		private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			assign();
		}
		public Form5()
		{
			Load += Form5_Load;
			InitializeComponent();
		}
	}
}
