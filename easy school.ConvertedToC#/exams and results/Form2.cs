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
namespace easy_school
{
	public partial class Form2
	{
		database data = new database();
		 class_id;
		List<string> str_id = new List<string>();
		string cl = 0;
		string strm = 0;
		int J;
		public int CLSS;
		public string STR;
		public string connstring = "Dsn=school;database=school;option=0;port=3306;server=localhost;uid=school; password=incorrect;";
		public VariantType admNo;
		public VariantType clas;
		public VariantType year;
		public VariantType term;
		public VariantType exam;
		public VariantType maths;
		public VariantType eng;
		public VariantType kisw;
		public VariantType social;
		public VariantType sci;
		public VariantType total;
		public VariantType position;
		public VariantType examno;
		public VariantType grammer;
		public VariantType reading;
		public VariantType composition;
		public VariantType lugha;
		public VariantType kusoma;
		public VariantType insha;
		public VariantType cre;
		public VariantType C0MP;
		public VariantType MUSIC;
		public VariantType SWIMMING;
		public VariantType PE;
		public VariantType examcode;
		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			eg();
		}
		private void TextBox3_TextChanged(object sender, EventArgs e)
		{
			eg();
		}
		private void TextBox4_TextChanged(object sender, EventArgs e)
		{
			eg();
		}
		private void TextBox5_TextChanged(object sender, EventArgs e)
		{
			eg();
		}
		private void TextBox9_TextChanged(object sender, EventArgs e)
		{
			ks();
		}
		private void TextBox8_TextChanged(object sender, EventArgs e)
		{
			ks();
		}
		private void TextBox7_TextChanged(object sender, EventArgs e)
		{
			ks();
		}
		private void TextBox6_TextChanged(object sender, EventArgs e)
		{
			ks();
		}

		private void Label10_Click(object sender, EventArgs e)
		{
		}

		private void Label12_Click(object sender, EventArgs e)
		{
		}

		private void Label11_Click(object sender, EventArgs e)
		{
		}

		private void Label13_Click(object sender, EventArgs e)
		{
		}

		private void GroupBox6_Enter(object sender, EventArgs e)
		{
		}

		private void Label9_Click(object sender, EventArgs e)
		{
		}

		private void Label7_Click(object sender, EventArgs e)
		{
		}

		private void Label8_Click(object sender, EventArgs e)
		{
		}

		private void Label6_Click(object sender, EventArgs e)
		{
		}

		private void GroupBox5_Enter(object sender, EventArgs e)
		{
		}

		private void GroupBox4_Enter(object sender, EventArgs e)
		{
		}

		private void GroupBox3_Enter(object sender, EventArgs e)
		{
		}
		int kis;
		int tot;
		private void ks()
		{
			if (Conversion.Val(TextBox9.Text) > 50) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox9.Focus();
				TextBox9.Text = "";
			}
			if (Conversion.Val(TextBox8.Text) > 30) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox8.Focus();
				TextBox8.Text = "";
			}
			if (Conversion.Val(TextBox7.Text) > 20) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox7.Focus();
				TextBox7.Text = "";
			}
			kis = Conversion.Val(TextBox9.Text) + Conversion.Val(TextBox8.Text) + Conversion.Val(TextBox7.Text);
			TextBox6.Text = kis;
			totl();
		}
		private void eg()
		{
			if (Conversion.Val(TextBox2.Text) > 50) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox2.Focus();
				TextBox2.Text = "";
			}
			if (Conversion.Val(TextBox3.Text) > 30) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox3.Focus();
				TextBox3.Text = "";
			}
			if (Conversion.Val(TextBox4.Text) > 20) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox4.Focus();
				TextBox4.Text = "";
			}
			eng = Conversion.Val(TextBox2.Text) + Conversion.Val(TextBox3.Text) + Conversion.Val(TextBox4.Text);
			TextBox5.Text = eng;
			totl();
		}
		private void totl()
		{
			if (Conversion.Val(TextBox10.Text) > 50) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox10.Focus();
				TextBox10.Text = "";
			}
			if (Conversion.Val(TextBox11.Text) > 50) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox11.Focus();
				TextBox11.Text = "";
			}
			if (Conversion.Val(TextBox12.Text) > 30) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox12.Focus();
				TextBox12.Text = "";
			}
			if (Conversion.Val(TextBox13.Text) > 20) {
				Interaction.MsgBox("marks out of range", , "");
				TextBox13.Focus();
				TextBox13.Text = "";
			}
			tot = kis + eng + (2 * Conversion.Val(TextBox10.Text)) + (2 * Conversion.Val(TextBox11.Text)) + (2 * (Conversion.Val(TextBox12.Text) + Conversion.Val(TextBox13.Text)));
			TextBox18.Text = tot;
		}
		private void CLEAR()
		{
			TextBox2.Text = "";
			TextBox3.Text = "";
			TextBox4.Text = "";
			TextBox5.Text = "";
			TextBox6.Text = "";
			TextBox7.Text = "";
			TextBox8.Text = "";
			TextBox9.Text = "";
			TextBox10.Text = "";
			TextBox11.Text = "";
			TextBox12.Text = "";
			TextBox13.Text = "";
			TextBox14.Text = "";
			TextBox20.Text = "";
			TextBox1.Text = "";
			TextBox1.Focus();
		}


		private void Form2_Load(object sender, EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			DataTable rd = null;
			DataTable rd1 = null;
			rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`");
			rd1 = data.executeSQL("SELECT code, name FROM stream");
			foreach (object drow_loopVariable in rd.Rows) {
				drow = drow_loopVariable;
				ComboBox1.Items.Add(drow.Item(1).ToString.ToUpper);
				class_id.Add(drow.Item(0).ToString.ToUpper);
			}
			foreach (object drow_loopVariable in rd1.Rows) {
				drow = drow_loopVariable;
				ComboBox2.Items.Add(drow.Item(1).ToString.ToUpper);
				str_id.Add(drow.Item(0).ToString.ToUpper);
			}
			ComboBox1.SelectedItem = 1;
			ComboBox2.SelectedItem = 1;
			TextBox20.Enabled = false;
			//With ComboBox1.Items
			//    For G As Integer = 1 To 8
			//        .Add(G)
			//    Next
			//End With
			var _with1 = ComboBox3.Items;
			_with1.Add(1);
			_with1.Add(2);
			_with1.Add(3);
			var _with2 = ComboBox4.Items;
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy") - 2);
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy") - 1);
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy"));
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy") + 1);
			_with2.Add(Strings.Format(DateAndTime.Now, "yyyy") + 2);
			//With ComboBox2.Items
			//    .Add("VANILLA")
			//    .Add("STRAWBERRY")
			//    .Add("CHOCOLATE")
			//End With
		}

		private void TextBox10_TextChanged(object sender, EventArgs e)
		{
			totl();
		}

		private void TextBox11_TextChanged(object sender, EventArgs e)
		{
			totl();

		}

		private void TextBox12_TextChanged(object sender, EventArgs e)
		{
			totl();

		}

		private void TextBox13_TextChanged(object sender, EventArgs e)
		{
			totl();

		}

		private void TextBox18_TextChanged(object sender, EventArgs e)
		{
			totl();
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			CLSS = class_id(ComboBox1.SelectedIndex);
			STR = str_id[ComboBox2.SelectedIndex];
			GroupBox1.Enabled = false;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			year = Conversion.Val(ComboBox4.Text);
			term = Conversion.Val(ComboBox3.Text);
			if (RadioButton1.Checked == true) {
				exam = 1;
			}
			if (RadioButton2.Checked == true) {
				exam = 2;
			}
			if (RadioButton3.Checked == true) {
				exam = 3;
			}
			TextBox21.Text = year + " " + term + " " + exam;
			GroupBox2.Enabled = false;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			OdbcDataAdapter mh = new OdbcDataAdapter();
			DataSet DS = null;
			DataTable DTABLE = null;
			TextBox20.Text = "";

			try {
				//Dim conn As New OdbcConnection(connstring)
				//Dim cn As New OdbcCommand
				int v = 0;
				//If conn.State = ConnectionState.Open Then
				//    conn.Close()
				//End If
				//mh.SelectCommand = New OdbcCommand("select * from students where admno='" & Val(TextBox1.Text) & "' and  status=1", conn)
				//DS = New DataSet("DS")
				//mh.Fill(DS)
				//DTABLE = DS.Tables(0)
				DTABLE = data.executeSQL("select * from students where admno='" + Conversion.Val(TextBox1.Text) + "' and  status=1");

				v = DTABLE.Rows.Count;
				if (v < 1) {
					Interaction.MsgBox("no record found ", , "");
					DataGridView1.DataSource = null;
					TextBox1.Text = "";
					TextBox1.Focus();
					admNo = null;
					Button3.Enabled = true;
					return;
				}

				GroupBox3.Enabled = true;
				foreach (DataRow drow in DTABLE.Rows) {
					TextBox20.Text = drow[0] + "  " + drow[2];
					//& " " & drow(5)
					//DocName.SelectedIndex = -1
					admNo = drow[0];
					clas = drow[7];

				}
				Button3.Enabled = false;
				//conn.Open()

				//If conn.State = ConnectionState.Open Then
				//    conn.Close()
				//End If
				//mh.SelectCommand = New OdbcCommand("select exam'Cat', grammer, reading, composition'comp' ,eng, lugha, kusoma, insha, kisw,maths,sci,(social+ cre)'social', total from RESULTS WHERE YEAR=" & year & " AND admno=" & admNo & " AND CLASS=" & CLSS & " AND TERM=" & term & ";", conn)
				//DS = New DataSet("STUDENTS")
				//mh.Fill(DS, "STUDENTS")
				//DTABLE = DS.Tables(0)
				DTABLE = data.executeSQL("select exam'Cat', grammer, reading, composition'comp' ,eng, lugha, kusoma, insha, kisw,maths,sci,(social+ cre)'social', total from RESULTS WHERE YEAR=" + year + " AND admno=" + admNo + " AND CLASS=" + CLSS + " AND TERM=" + term + ";");
				v = DTABLE.Rows.Count;
				if (v < 1) {
					DataGridView1.DataSource = null;
					return;
				}
				DataGridView1.DataSource = DTABLE;

			} catch (Exception ex) {
				//MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			CHECKQ();
			if (J > 0) {
				Interaction.MsgBox("ENRTY ALREADY EXISTS ", , "");
				Button3.Enabled = true;
				return;
			}
			results();
			OdbcDataAdapter mh = new OdbcDataAdapter();

			try {
				//Dim conn As New OdbcConnection(connstring)
				//Dim cn As New OdbcCommand
				//If conn.State = ConnectionState.Open Then
				//    conn.Close()
				//End If
				//conn.Open()
				//cn.CommandText = ("INSERT INTO results(admNo, class, year, term, exam, maths, eng, kisw, social,sci, total, position,grammer, reading, composition, lugha, kusoma, insha, cre, C0MP, MUSIC, SWIMMING, Pe) VALUES(" & admNo & ", " & clas & ", " & year & ", " & term & "," & exam & ", " & maths & ", " & eng & ", " & kisw & ", " & social & "," & sci & "," & total & "," & position & "," & grammer & "," & reading & "," & composition & "," & lugha & "," & kusoma & "," & insha & "," & cre & "," & C0MP & "," & MUSIC & "," & SWIMMING & "," & PE & ")")
				//cn.Connection = conn
				//mh.SelectCommand = cn
				//cn.ExecuteNonQuery()
				//MsgBox("record added ", vbOKOnly + vbInformation)
				data.@add(ref "INSERT INTO results(admNo, class, year, term, exam, maths, eng, kisw, social,sci, total, position,grammer, reading, composition, lugha, kusoma, insha, cre, C0MP, MUSIC, SWIMMING, Pe) VALUES(" + admNo + ", " + clas + ", " + year + ", " + term + "," + exam + ", " + maths + ", " + eng + ", " + kisw + ", " + social + "," + sci + "," + total + "," + position + "," + grammer + "," + reading + "," + composition + "," + lugha + "," + kusoma + "," + insha + "," + cre + "," + C0MP + "," + MUSIC + "," + SWIMMING + "," + PE + ")");
				admNo = null;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			admNo = null;
			GroupBox3.Enabled = false;
			Button3.Enabled = true;

			CLEAR();
		}
		private void results()
		{
			maths = (Conversion.Val(TextBox10.Text) * 2);
			eng = Conversion.Val(TextBox5.Text);
			kisw = Conversion.Val(TextBox6.Text);
			social = Conversion.Val(TextBox12.Text) * 2;
			sci = Conversion.Val(TextBox11.Text) * 2;
			total = Conversion.Val(TextBox18.Text);
			position = 0;
			grammer = Conversion.Val(TextBox2.Text);
			reading = Conversion.Val(TextBox4.Text);
			composition = Conversion.Val(TextBox3.Text);
			lugha = Conversion.Val(TextBox9.Text);
			kusoma = Conversion.Val(TextBox7.Text);
			insha = Conversion.Val(TextBox8.Text);
			cre = Conversion.Val(TextBox13.Text) * 2;
			C0MP = Conversion.Val(TextBox17.Text) * 2;
			MUSIC = Conversion.Val(TextBox16.Text) * 2;
			SWIMMING = Conversion.Val(TextBox15.Text) * 2;
			PE = Conversion.Val(TextBox14.Text) * 2;
		}

		private void CHECKQ()
		{
			OdbcDataAdapter mh = new OdbcDataAdapter();
			DataSet DS = null;
			DataTable DTABLE = null;

			try {
				//Dim conn As New OdbcConnection(connstring)
				//Dim cn As New OdbcCommand

				//If conn.State = ConnectionState.Open Then
				//    conn.Close()
				//End If
				//mh.SelectCommand = New OdbcCommand("select * from RESULTS where admno='" & admNo & "' AND YEAR=" & year & " AND EXAM=" & exam & ";", conn)
				//DS = New DataSet("DS")
				//mh.Fill(DS)
				//DTABLE = DS.Tables(0)
				DTABLE = data.executeSQL("select * from RESULTS where admno='" + admNo + "' AND YEAR=" + year + " AND EXAM=" + exam + ";");
				J = DTABLE.Rows.Count;

				//conn.Open()
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void Button5_Click(object sender, EventArgs e)
		{

		}


		private void Button5_Click_1(object sender, EventArgs e)
		{
		}

		private void Button5_Click_2(object sender, EventArgs e)
		{
			Form5 ChildForl = new Form5();
			// Make it a child of this MDI form before showing it.
			//ChildForl.MdiParent = home2
			//ChildForl.Show()
			// Form5.Show()
		}
		private void Button6_Click(object sender, EventArgs e)
		{
			GroupBox3.Enabled = false;
			Button3.Enabled = true;

			CLEAR();
		}
		private void Button7_Click(object sender, EventArgs e)
		{
			GroupBox1.Enabled = true;
			GroupBox2.Enabled = true;

		}
		public Form2()
		{
			Load += Form2_Load;
			InitializeComponent();
		}
	}
}
