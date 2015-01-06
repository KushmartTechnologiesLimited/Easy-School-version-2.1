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
	public partial class new_student
	{
		bool mama = false;
		bool papa = false;
		string padm;
		string pmid;
		string pfid;
		int fr;
		public string adm;
		public string sname;
		public string fname;
		public string lname;
		public string dob;
		public string gender;
		public string birthno;
		public string adm_date;
		public string pic;
		 class_id;
		List<string> str_id = new List<string>();
		string strm;
		string cl;
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			TextBox5.Text = "";
			if (CheckBox1.Checked == false) {
				TextBox5.ReadOnly = true;
			} else {
				TextBox5.ReadOnly = false;
			}
		}

		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBox3.Checked == false) {
				Panel4.Enabled = true;
			} else {
				Panel4.Enabled = false;
				TextBox7.Text = "";
				TextBox13.Text = "";
				TextBox11.Text = "";
				TextBox21.Text = "";
				TextBox8.Text = "";
				TextBox9.Text = "";
				TextBox12.Text = "";
			}
		}

		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBox2.Checked == false) {
				Panel5.Enabled = true;
			} else {
				Panel5.Enabled = false;
				TextBox18.Text = "";
				TextBox6.Text = "";
				TextBox15.Text = "";
				TextBox10.Text = "";
				TextBox17.Text = "";
				TextBox16.Text = "";
				TextBox14.Text = "";
			}
		}

		private void new_student_Load(object sender, EventArgs e)
		{
			database data = new database();
			TabPage page = null;
			foreach (TabPage page_loopVariable in TabControl1.TabPages) {
				page = page_loopVariable;
				page.Enabled = false;
			}
			TabControl1.TabPages[0].Enabled = true;
			DataTable rd = null;
			DataTable rd1 = null;
			rd = data.executeSQL("SELECT code,description  FROM class ORDER BY `level`");
			rd1 = data.executeSQL("SELECT code, name FROM stream");
			int i = 0;
			int j = 0;
			int k = 0;

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
		}


		//'test the codes
		public void getdata()
		{

		}
		private void Button5_Click(object sender, EventArgs e)
		{
			studentsdatabase ddd = new studentsdatabase();
			database data = new database();
			try {
				//add data to the database
				getdata();
				if (string.IsNullOrEmpty(TextBox1.Text)) {
					Interaction.MsgBox("admno can't be blank", MsgBoxStyle.Information, "error!");
					TextBox1.Focus();
					return;
				}
				if (string.IsNullOrEmpty(TextBox2.Text) & string.IsNullOrEmpty(TextBox3.Text) & string.IsNullOrEmpty(TextBox4.Text)) {
					Interaction.MsgBox("names  can't be blank", MsgBoxStyle.Information, "error!");
					TextBox2.Focus();
					return;
				}
				//If TextBox23.Text = "" Then
				//    MsgBox("birth certificate no can't be blank", MsgBoxStyle.Information, "error!")
				//    TextBox23.Focus()
				//    Exit Sub
				//End If
				adm = TextBox1.Text.ToUpper();
				sname = TextBox2.Text.ToUpper();
				fname = TextBox3.Text.ToUpper();
				lname = TextBox4.Text.ToUpper();
				dob = Date1.Value.ToString("yyyy-MM-dd");
				if (RadioButton1.Checked == true) {
					gender = "Female";
				} else if (RadioButton2.Checked == true) {
					gender = "Male";
				}

				birthno = TextBox23.Text;
				adm_date = DateTimePicker1.Value.ToString("yyyy-MM-dd");
				pic = "";
				// Me.Close()
				//pass variables to the calling view if the the insert was succesifull
				string sql = null;
				string nam = null;
				nam = Strings.LTrim(fname + " " + lname + " " + sname);
				sql = "INSERT INTO `schoolfees`.`students` (`admno`, `regno`, ` names`, `gender`, `DOB`, `Birthno`, `adm_date`, `pic`) VALUES ('" + adm + "', NULL, '" + nam + "', '" + gender + "', '" + dob + "', '" + birthno + "', '" + adm_date + "', '" + pic + "');";
				//  sql = "INSERT INTO students (admno, regno, names, gender, DOB, Birthno, adm_date, pic) VALUES ('" & adm & "', NULL, '" & nam & "', '" & gender & "', '" & dob & "', '" & birthno & "', '" & adm_date & "', '" & pic & "');"
				int stat = 0;
				stat = ddd.@add(ref sql);
				// data.add(sql)
				if (stat == 1) {
					TabControl1.TabPages[0].Enabled = false;
					TabControl1.TabPages[1].Enabled = true;
					TabControl1.SelectedIndex = 1;
					ProgressBar1.Value = ProgressBar1.Maximum / 3;
					Button5.Visible = false;
					Button1.Visible = true;

					padm = adm;
				}
				//create a sub to pass every thing(this is already done)

			} catch (Exception ex) {
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			//'THIS BUTTON SHOULD ADD ALL THE AVAILABLE PARENTS DATA TO THE DATABASE AND ASSIGN THE PARENTS DTAILS TO THE 
			//'PARTICULA STUDENT
			//TEST WHAT IS READY BEFORORE YOU INSERT
			studentsdatabase DATA = new studentsdatabase();
			string Mid = null;
			string Mnames = null;
			string Mtel = null;
			string Memail = null;
			string Mwork = null;
			string Memployer = null;
			string Mresidents = null;
			string Fid = null;
			string Fnames = null;
			string Ftel = null;
			string Femail = null;
			string Fwork = null;
			string Femployer = null;
			string Fresidents = null;
			bool FSTATUS = false;
			bool MSTATUS = false;
			try {
				if (mama == false & CheckBox3.Checked == false) {
					//ADDMOTHER()
					//Dim Mid, Mnames, Mtel, Memail, Mwork, Memployer, Mresidents As String
					//Dim DATA As New studentsdatabase
					try {
						if ((string.IsNullOrEmpty(TextBox13.Text))) {
							MSG();
							TextBox13.Focus();
							return;
						} else if (TextBox13.TextLength < 8) {
							Interaction.MsgBox("National Id No should be atleast 7 characters", MsgBoxStyle.Information, "error");
							TextBox13.Focus();
							return;
						}
						if ((string.IsNullOrEmpty(TextBox7.Text))) {
							MSG();
							TextBox7.Focus();
							return;
						}
						if ((string.IsNullOrEmpty(TextBox11.Text))) {
							MSG();
							TextBox11.Focus();
							return;
						}
						//If (TextBox21.Text = "") Then
						//    MSG()
						//    TextBox21.Focus()
						//    Exit Sub
						//End If
						//If (TextBox8.Text = "") Then
						//    MSG()
						//    TextBox8.Focus()
						//    Exit Sub
						//End If
						//If (TextBox9.Text = "") Then
						//    MSG()
						//    TextBox9.Focus()
						//    Exit Sub
						//End If
						//If (TextBox12.Text = "") Then
						//    MSG()
						//    TextBox12.Focus()
						//    Exit Sub
						//End If
						Mid = TextBox13.Text;
						Mnames = TextBox7.Text;
						Mtel = TextBox11.Text;
						Memail = TextBox21.Text;
						Mwork = TextBox8.Text;
						Memployer = TextBox9.Text;
						Mresidents = TextBox12.Text;
						MSTATUS = true;
						//DATA.add("INSERT INTO MOTHER  VALUES (" & Mid & ", '" & Mnames & "', '" & Mtel & "', '" & Memail & "', '" & Mwork & "', '" & Memployer & "', '" & Mresidents & "');")
						pmid = Mid;

					} catch (Exception ex) {
					}
				}
				if (papa == false & CheckBox2.Checked == false) {
					//ADDfather()
					//Dim Fid, Fnames, Ftel, Femail, Fwork, Femployer, Fresidents As String
					//Dim DATA As New database
					try {
						if ((string.IsNullOrEmpty(TextBox6.Text))) {
							MSG();
							TextBox6.Focus();
							return;
						} else if (TextBox6.TextLength < 7) {
							Interaction.MsgBox("National Id No should be atleast 7 characters", MsgBoxStyle.Information, "error");
							TextBox6.Focus();
							return;
						}
						if ((string.IsNullOrEmpty(TextBox18.Text))) {
							MSG();
							TextBox18.Focus();
							return;
						}
						if ((string.IsNullOrEmpty(TextBox15.Text))) {
							MSG();
							TextBox15.Focus();
							return;
						}
						//If (TextBox10.Text = "") Then
						//    MSG()
						//    TextBox10.Focus()
						//    Exit Sub
						//End If
						//If (TextBox17.Text = "") Then
						//    MSG()
						//    TextBox17.Focus()
						//    Exit Sub
						//End If
						//If (TextBox16.Text = "") Then
						//    MSG()
						//    TextBox16.Focus()
						//    Exit Sub
						//End If
						//If (TextBox14.Text = "") Then
						//    MSG()
						//    TextBox14.Focus()
						//    Exit Sub
						//End If
						Fid = TextBox6.Text;
						Fnames = TextBox18.Text;
						Ftel = TextBox15.Text;
						Femail = TextBox10.Text;
						Fwork = TextBox17.Text;
						Femployer = TextBox16.Text;
						Fresidents = TextBox14.Text;
						FSTATUS = true;
						//DATA.add("INSERT INTO father  VALUES (" & Fid & ", '" & Fnames & "', '" & Ftel & "', '" & Femail & "', '" & Fwork & "', '" & Femployer & "', '" & Fresidents & "');")
						pfid = Fid;

					} catch (Exception ex) {
					}
				}

				if (MSTATUS == true) {
					DATA.@add(ref "INSERT INTO MOTHER  VALUES (" + Mid + ", '" + Mnames + "', '" + Mtel + "', '" + Memail + "', '" + Mwork + "', '" + Memployer + "', '" + Mresidents + "');");
				}
				if (FSTATUS == true) {
					DATA.@add(ref "INSERT INTO father  VALUES (" + Fid + ", '" + Fnames + "', '" + Ftel + "', '" + Femail + "', '" + Fwork + "', '" + Femployer + "', '" + Fresidents + "');");
				}

				complete();
				TabControl1.TabPages[1].Enabled = false;
				TabControl1.TabPages[2].Enabled = true;
				TabControl1.SelectedIndex = 2;
				ProgressBar1.Value = ProgressBar1.Maximum * (2 / 3);
				Button1.Visible = false;
				Button2.Visible = true;


			} catch (Exception ex) {
			}

		}
		private object complete()
		{
			string ssql = null;
			studentsdatabase data = new studentsdatabase();
			ssql = "INSERT INTO parents (admno ,f_id_no ,id_no)VALUES ('" + padm + "',  '" + pfid + "',  '" + pmid + "')";
			data.@add(ref ssql);
		}
		public void ADDfather()
		{
			//Dim Fid, Fnames, Ftel, Femail, Fwork, Femployer, Fresidents As String
			//Dim DATA As New database
			//Try
			//    If (TextBox6.Text = "") Then
			//        MSG()
			//        TextBox6.Focus()
			//        Exit Sub
			//    ElseIf TextBox6.TextLength < 7 Then
			//        MsgBox("National Id No should be atleast 7 characters", MsgBoxStyle.Information, "error")
			//        TextBox6.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox18.Text = "") Then
			//        MSG()
			//        TextBox18.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox15.Text = "") Then
			//        MSG()
			//        TextBox15.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox10.Text = "") Then
			//        MSG()
			//        TextBox10.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox17.Text = "") Then
			//        MSG()
			//        TextBox17.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox16.Text = "") Then
			//        MSG()
			//        TextBox16.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox14.Text = "") Then
			//        MSG()
			//        TextBox14.Focus()
			//        Exit Sub
			//    End If
			//    Fid = TextBox6.Text
			//    Fnames = TextBox18.Text
			//    Ftel = TextBox15.Text
			//    Femail = TextBox10.Text
			//    Fwork = TextBox17.Text
			//    Femployer = TextBox16.Text
			//    Fresidents = TextBox14.Text
			//    DATA.add("INSERT INTO father  VALUES (" & Fid & ", '" & Fnames & "', '" & Ftel & "', '" & Femail & "', '" & Fwork & "', '" & Femployer & "', '" & Fresidents & "');")
			//    pfid = Fid
			//Catch ex As Exception

			//End Try
		}
		public void ADDMOTHER()
		{
			//Dim Mid, Mnames, Mtel, Memail, Mwork, Memployer, Mresidents As String
			//Dim DATA As New studentsdatabase
			//Try
			//    If (TextBox13.Text = "") Then
			//        MSG()
			//        TextBox13.Focus()
			//        Exit Sub
			//    ElseIf TextBox13.TextLength < 8 Then
			//        MsgBox("National Id No should be atleast 7 characters", MsgBoxStyle.Information, "error")
			//        TextBox13.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox7.Text = "") Then
			//        MSG()
			//        TextBox7.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox11.Text = "") Then
			//        MSG()
			//        TextBox11.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox21.Text = "") Then
			//        MSG()
			//        TextBox21.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox8.Text = "") Then
			//        MSG()
			//        TextBox8.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox9.Text = "") Then
			//        MSG()
			//        TextBox9.Focus()
			//        Exit Sub
			//    End If
			//    If (TextBox12.Text = "") Then
			//        MSG()
			//        TextBox12.Focus()
			//        Exit Sub
			//    End If
			//    Mid = TextBox13.Text
			//    Mnames = TextBox7.Text
			//    Mtel = TextBox11.Text
			//    Memail = TextBox21.Text
			//    Mwork = TextBox8.Text
			//    Memployer = TextBox9.Text
			//    Mresidents = TextBox12.Text
			//    DATA.add("INSERT INTO MOTHER  VALUES (" & Mid & ", '" & Mnames & "', '" & Mtel & "', '" & Memail & "', '" & Mwork & "', '" & Memployer & "', '" & Mresidents & "');")
			//    pmid = Mid
			//Catch ex As Exception

			//End Try
		}
		//add mothers details to the database
		public void MSG()
		{
			Interaction.MsgBox("Cant be blank!", MsgBoxStyle.Information, "error");
		}
		public void mother(string admno)
		{
			studentsdatabase DATA = new studentsdatabase();
			System.Data.DataTable red = null;
			DataRow drow = null;
			strparents pss = new strparents();
			red = DATA.executeSQL("SELECT `Id_No`, `names`, `tel`, `email`, `work`, `employer`, `resident_id` FROM `mother` WHERE `Id_No`=" + TextBox13.Text);
			if (red.Rows.Count > 0) {
				mama = true;
				Panel6.Enabled = false;
				pmid = admno;
			} else {
				mama = false;
				Panel6.Enabled = true;
				pmid = "";
			}

			foreach (DataRow drow_loopVariable in red.Rows) {
				drow = drow_loopVariable;
				pss.idm = drow[0].ToString().ToUpper().ToUpper();
				pss.names = drow[1].ToString().ToUpper();
				pss.tel = drow[2].ToString().ToUpper();
				pss.email = drow[3].ToString().ToUpper();
				pss.work = drow[4].ToString().ToUpper();
				pss.employer = drow[5].ToString().ToUpper();
				pss.resident = drow[6].ToString().ToUpper();

			}
			var _with1 = pss;
			TextBox7.Text = _with1.names;
			//TextBox13.Text = .idm
			TextBox11.Text = _with1.tel;
			TextBox21.Text = _with1.email;
			TextBox8.Text = _with1.work;
			TextBox9.Text = _with1.employer;
			TextBox12.Text = _with1.resident;

		}
		//mothers details
		private struct strparents
		{
			public string idm;
			public string names;
			public string tel;
			public string email;
			public string work;
			public string employer;
			public string resident;
		}
		//PARENTS STRUCT
		public void father(string admno)
		{
			studentsdatabase DATA = new studentsdatabase();
			System.Data.DataTable red = null;
			DataRow drow = null;
			strparents pss = new strparents();
			red = DATA.executeSQL("SELECT `f_Id_No`, `names`, `tel`, `email`, `work`, `employer`, `Resident_id` FROM `father` WHERE `f_Id_No`=" + admno);
			if (red.Rows.Count > 0) {
				papa = true;
				Panel7.Enabled = false;
				pfid = admno;
			} else {
				papa = false;
				Panel7.Enabled = true;
				pfid = "";
			}
			foreach (DataRow drow_loopVariable in red.Rows) {
				drow = drow_loopVariable;
				pss.idm = drow[0].ToString().ToUpper().ToUpper();
				pss.names = drow[1].ToString().ToUpper();
				pss.tel = drow[2].ToString().ToUpper();
				pss.email = drow[3].ToString().ToUpper();
				pss.work = drow[4].ToString().ToUpper();
				pss.employer = drow[5].ToString().ToUpper();
				pss.resident = drow[6].ToString().ToUpper();
			}
			var _with2 = pss;
			TextBox18.Text = _with2.names;
			// TextBox6.Text = .idm
			TextBox15.Text = _with2.tel;
			TextBox10.Text = _with2.email;
			TextBox17.Text = _with2.work;
			TextBox16.Text = _with2.employer;
			TextBox14.Text = _with2.resident;

		}
		//fathers details
		private void TextBox13_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate VAL = new validate();
			VAL.digits(sender, e);
		}
		private void TextBox13_TextChanged(object sender, EventArgs e)
		{
			if (TextBox13.TextLength > 6) {
				//'CHECK IN THE DATABASE FOR AN OCCURENCE
				mother(TextBox13.Text);

			} else {
			}


		}
		private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
		{
			validate VAL = new validate();
			VAL.digits(sender, e);
		}
		private void TextBox6_TextChanged(object sender, EventArgs e)
		{
			if (TextBox6.TextLength > 6) {
				//'CHECK IN THE DATABASE FOR AN OCCURENCE
				father(TextBox6.Text);
			}
		}


		private void Button2_Click(object sender, EventArgs e)
		{

			try {
				studentsdatabase data = new studentsdatabase();

				if (string.IsNullOrEmpty(ComboBox1.Text)) {
					Interaction.MsgBox("seletct a class", MsgBoxStyle.Information, "incorrect data");
					return;
				}
				if (string.IsNullOrEmpty(ComboBox2.Text)) {
					Interaction.MsgBox("seletct a stream", MsgBoxStyle.Information, "incorrect data");
					return;
				}
				cl = class_id(ComboBox1.SelectedIndex);
				strm = str_id[ComboBox2.SelectedIndex];
				data.add1("UPDATE students SET class_code=" + cl + ",str_code=" + strm + " WHERE admno=" + padm);
				data.add1("INSERT INTO `student_class`(`admno`, `class_code`, `str_code`) VALUES (" + padm + "," + cl + "," + strm + ")");
				ProgressBar1.Value = ProgressBar1.Maximum;
				Label27.Visible = true;
				//bill
				string yr = null;
				string term = null;
				string charge = null;
				string dat = null;
				dat = DateAndTime.Now.Month;
				//(DateTimePicker1.Value.Month)
				yr = DateAndTime.Now.Year;
				// (DateTimePicker1.Value.Year)
				if (dat >= 1 & dat <= 4) {
					term = "term 1";
				} else if (dat >= 5 & dat <= 8) {
					term = "term 2";
				} else if (dat >= 9 & dat <= 12) {
					term = "term 3";
				}
				string admn = padm;
				string lev = cl;
				DataTable amout = null;
				string sql1 = null;
				if (term == "term 1") {
					sql1 = "SELECT  ifnull(sum( amount),0)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly'  or `category`='registration' ) and `L_id`='" + lev + "'";
				} else {
					sql1 = "SELECT  ifnull(sum( amount),0)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" + lev + "'";
				}
				amout = data.executeSQL(sql1);
				// reads fees
				foreach (DataRow dro in amout.Rows) {
					charge = dro[0];
					string bil = null;
					bil = "INSERT INTO `schoolfees`.`bill` (`id`, `year`, `term`,`class_Id`, `admno`, `amount`, `status`, `date`) VALUES (NULL, '" + yr + "', '" + term + "','" + lev + "', '" + admn + "', '" + charge + "', '0', CURRENT_TIMESTAMP);";
					data.@add(ref bil);
				}
				//End bill
				//transfer to account fees

				int sd1 = 0;
				string admn1 = null;
				string cash = null;
				string bill_id = null;
				string sql11 = null;
				DataTable std = null;
				DataTable tras = null;
				int charge1 = 0;
				std = data.executeSQL("SELECT  admno ,  amount ,  id FROM  bill WHERE admno=" + adm + " and status =0");
				//reads throug list of names
				foreach (DataRow row in std.Rows) {
					admn1 = row[0].ToString();
					cash = row[1].ToString();
					bill_id = row[2].ToString();
					charge1 = 0;
					string nn = null;
					nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" + admn1 + "', 'Students billing', 'bill tranfers', 'bills', '', '" + bill_id + "', '" + cash + "', '" + charge1 + "', '" + (cash + charge1) + "', '0', CURRENT_TIMESTAMP);";
					data.@add(ref "UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" + admn1 + "'");
					data.@add(ref nn);
					data.@add(ref "UPDATE `bill` SET `status`=1 WHERE `admno`='" + admn1 + "'");
					sd1 = sd1 + 1;
				}
				//end
				Timer1.Enabled = true;
				Button2.Enabled = false;


			} catch (Exception ex) {
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (fr > 30) {
				this.Close();
			} else {
				fr = fr + 1;
			}
		}

		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Dim val As New validate
			//val.alphas(sender.text)

		}


		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			//If e.KeyChar=
		}

		private void TextBox2_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}

		private void TextBox3_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}

		private void TextBox4_TextChanged(object sender, EventArgs e)
		{
			validate val = new validate();
			val.alphas(sender.text);
		}


		private void Button3_Click(object sender, EventArgs e)
		{
		}
	}
}
