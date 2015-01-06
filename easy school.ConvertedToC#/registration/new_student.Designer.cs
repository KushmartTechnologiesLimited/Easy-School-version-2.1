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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class new_student : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Label21 = new System.Windows.Forms.Label();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.Date1 = new System.Windows.Forms.DateTimePicker();
			this.TextBox23 = new System.Windows.Forms.TextBox();
			this.Label28 = new System.Windows.Forms.Label();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.CheckBox3 = new System.Windows.Forms.CheckBox();
			this.CheckBox2 = new System.Windows.Forms.CheckBox();
			this.Panel5 = new System.Windows.Forms.Panel();
			this.Panel7 = new System.Windows.Forms.Panel();
			this.TextBox10 = new System.Windows.Forms.TextBox();
			this.TextBox14 = new System.Windows.Forms.TextBox();
			this.TextBox15 = new System.Windows.Forms.TextBox();
			this.TextBox16 = new System.Windows.Forms.TextBox();
			this.TextBox17 = new System.Windows.Forms.TextBox();
			this.TextBox18 = new System.Windows.Forms.TextBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.Panel6 = new System.Windows.Forms.Panel();
			this.TextBox21 = new System.Windows.Forms.TextBox();
			this.TextBox12 = new System.Windows.Forms.TextBox();
			this.TextBox11 = new System.Windows.Forms.TextBox();
			this.TextBox9 = new System.Windows.Forms.TextBox();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.TextBox7 = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.TextBox13 = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label23 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label27 = new System.Windows.Forms.Label();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label26 = new System.Windows.Forms.Label();
			this.Label25 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button5 = new System.Windows.Forms.Button();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.Label24 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Panel2.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.Panel7.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.Panel6.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Location = new System.Drawing.Point(0, 1);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(846, 39);
			this.Panel1.TabIndex = 0;
			//
			//Panel2
			//
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.TabControl1);
			this.Panel2.Location = new System.Drawing.Point(4, 44);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(842, 414);
			this.Panel2.TabIndex = 1;
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Location = new System.Drawing.Point(-1, 3);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(838, 410);
			this.TabControl1.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.BackColor = System.Drawing.Color.LightGray;
			this.TabPage1.Controls.Add(this.Panel3);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(830, 384);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Student Details";
			//
			//Panel3
			//
			this.Panel3.BackColor = System.Drawing.Color.Gainsboro;
			this.Panel3.Controls.Add(this.TextBox5);
			this.Panel3.Controls.Add(this.CheckBox1);
			this.Panel3.Controls.Add(this.DateTimePicker1);
			this.Panel3.Controls.Add(this.Label21);
			this.Panel3.Controls.Add(this.RadioButton2);
			this.Panel3.Controls.Add(this.RadioButton1);
			this.Panel3.Controls.Add(this.Date1);
			this.Panel3.Controls.Add(this.TextBox23);
			this.Panel3.Controls.Add(this.Label28);
			this.Panel3.Controls.Add(this.TextBox4);
			this.Panel3.Controls.Add(this.TextBox3);
			this.Panel3.Controls.Add(this.TextBox2);
			this.Panel3.Controls.Add(this.TextBox1);
			this.Panel3.Controls.Add(this.Label7);
			this.Panel3.Controls.Add(this.Label5);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Controls.Add(this.Label3);
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel3.Location = new System.Drawing.Point(3, 3);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(824, 378);
			this.Panel3.TabIndex = 2;
			//
			//TextBox5
			//
			this.TextBox5.Location = new System.Drawing.Point(478, 40);
			this.TextBox5.Multiline = true;
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.ReadOnly = true;
			this.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBox5.Size = new System.Drawing.Size(317, 93);
			this.TextBox5.TabIndex = 67;
			//
			//CheckBox1
			//
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Location = new System.Drawing.Point(478, 17);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(126, 17);
			this.CheckBox1.TabIndex = 66;
			this.CheckBox1.Text = "any medical conditon";
			this.CheckBox1.UseVisualStyleBackColor = true;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(188, 297);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(239, 26);
			this.DateTimePicker1.TabIndex = 64;
			this.DateTimePicker1.Value = new System.DateTime(2014, 6, 4, 9, 14, 4, 0);
			//
			//Label21
			//
			this.Label21.AutoSize = true;
			this.Label21.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label21.Location = new System.Drawing.Point(41, 303);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(139, 19);
			this.Label21.TabIndex = 65;
			this.Label21.Text = "ADMISSION DATE";
			//
			//RadioButton2
			//
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.RadioButton2.Location = new System.Drawing.Point(329, 175);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(58, 23);
			this.RadioButton2.TabIndex = 51;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "Male";
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//RadioButton1
			//
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			this.RadioButton1.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.RadioButton1.Location = new System.Drawing.Point(192, 175);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(71, 23);
			this.RadioButton1.TabIndex = 50;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "Female";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//Date1
			//
			this.Date1.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.Date1.Location = new System.Drawing.Point(190, 207);
			this.Date1.Name = "Date1";
			this.Date1.Size = new System.Drawing.Size(237, 26);
			this.Date1.TabIndex = 6;
			//
			//TextBox23
			//
			this.TextBox23.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox23.Location = new System.Drawing.Point(190, 257);
			this.TextBox23.Name = "TextBox23";
			this.TextBox23.Size = new System.Drawing.Size(239, 26);
			this.TextBox23.TabIndex = 7;
			//
			//Label28
			//
			this.Label28.AutoSize = true;
			this.Label28.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label28.Location = new System.Drawing.Point(4, 264);
			this.Label28.Name = "Label28";
			this.Label28.Size = new System.Drawing.Size(180, 19);
			this.Label28.TabIndex = 48;
			this.Label28.Text = "BIRTH CERTIFICATE NO";
			//
			//TextBox4
			//
			this.TextBox4.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox4.Location = new System.Drawing.Point(190, 133);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(239, 26);
			this.TextBox4.TabIndex = 3;
			//
			//TextBox3
			//
			this.TextBox3.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox3.Location = new System.Drawing.Point(190, 85);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(239, 26);
			this.TextBox3.TabIndex = 2;
			//
			//TextBox2
			//
			this.TextBox2.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox2.Location = new System.Drawing.Point(190, 43);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(239, 26);
			this.TextBox2.TabIndex = 1;
			//
			//TextBox1
			//
			this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox1.Location = new System.Drawing.Point(188, 7);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(239, 26);
			this.TextBox1.TabIndex = 0;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(109, 179);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(71, 19);
			this.Label7.TabIndex = 44;
			this.Label7.Text = "GENDER";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(60, 214);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(120, 19);
			this.Label5.TabIndex = 41;
			this.Label5.Text = "DATE OF BIRTH";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(83, 136);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(97, 19);
			this.Label4.TabIndex = 39;
			this.Label4.Text = "LAST NAME";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(79, 92);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 19);
			this.Label3.TabIndex = 37;
			this.Label3.Text = "FIRST NAME";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(91, 50);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(89, 19);
			this.Label2.TabIndex = 35;
			this.Label2.Text = "SUR NAME";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(111, 14);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(69, 19);
			this.Label1.TabIndex = 33;
			this.Label1.Text = "ADMNO";
			//
			//TabPage2
			//
			this.TabPage2.BackColor = System.Drawing.Color.LightGray;
			this.TabPage2.Controls.Add(this.CheckBox3);
			this.TabPage2.Controls.Add(this.CheckBox2);
			this.TabPage2.Controls.Add(this.Panel5);
			this.TabPage2.Controls.Add(this.Panel4);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(830, 384);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Parents/guardian";
			//
			//CheckBox3
			//
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.Location = new System.Drawing.Point(302, 27);
			this.CheckBox3.Name = "CheckBox3";
			this.CheckBox3.Size = new System.Drawing.Size(88, 17);
			this.CheckBox3.TabIndex = 69;
			this.CheckBox3.Text = "Not available";
			this.CheckBox3.UseVisualStyleBackColor = true;
			//
			//CheckBox2
			//
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.Location = new System.Drawing.Point(714, 27);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Size = new System.Drawing.Size(88, 17);
			this.CheckBox2.TabIndex = 68;
			this.CheckBox2.Text = "Not available";
			this.CheckBox2.UseVisualStyleBackColor = true;
			//
			//Panel5
			//
			this.Panel5.Controls.Add(this.Panel7);
			this.Panel5.Controls.Add(this.Label22);
			this.Panel5.Controls.Add(this.TextBox6);
			this.Panel5.Controls.Add(this.Label6);
			this.Panel5.Controls.Add(this.Label11);
			this.Panel5.Controls.Add(this.Label15);
			this.Panel5.Controls.Add(this.Label16);
			this.Panel5.Controls.Add(this.Label17);
			this.Panel5.Controls.Add(this.Label18);
			this.Panel5.Controls.Add(this.Label19);
			this.Panel5.Location = new System.Drawing.Point(423, 50);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new System.Drawing.Size(401, 313);
			this.Panel5.TabIndex = 53;
			//
			//Panel7
			//
			this.Panel7.Controls.Add(this.TextBox10);
			this.Panel7.Controls.Add(this.TextBox14);
			this.Panel7.Controls.Add(this.TextBox15);
			this.Panel7.Controls.Add(this.TextBox16);
			this.Panel7.Controls.Add(this.TextBox17);
			this.Panel7.Controls.Add(this.TextBox18);
			this.Panel7.Enabled = false;
			this.Panel7.Location = new System.Drawing.Point(127, 72);
			this.Panel7.Name = "Panel7";
			this.Panel7.Size = new System.Drawing.Size(259, 238);
			this.Panel7.TabIndex = 69;
			//
			//TextBox10
			//
			this.TextBox10.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox10.Location = new System.Drawing.Point(4, 88);
			this.TextBox10.Name = "TextBox10";
			this.TextBox10.Size = new System.Drawing.Size(252, 26);
			this.TextBox10.TabIndex = 60;
			//
			//TextBox14
			//
			this.TextBox14.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox14.Location = new System.Drawing.Point(4, 201);
			this.TextBox14.Name = "TextBox14";
			this.TextBox14.Size = new System.Drawing.Size(250, 26);
			this.TextBox14.TabIndex = 63;
			//
			//TextBox15
			//
			this.TextBox15.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox15.Location = new System.Drawing.Point(3, 51);
			this.TextBox15.Name = "TextBox15";
			this.TextBox15.Size = new System.Drawing.Size(252, 26);
			this.TextBox15.TabIndex = 59;
			//
			//TextBox16
			//
			this.TextBox16.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox16.Location = new System.Drawing.Point(3, 163);
			this.TextBox16.Name = "TextBox16";
			this.TextBox16.Size = new System.Drawing.Size(252, 26);
			this.TextBox16.TabIndex = 62;
			//
			//TextBox17
			//
			this.TextBox17.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox17.Location = new System.Drawing.Point(4, 126);
			this.TextBox17.Name = "TextBox17";
			this.TextBox17.Size = new System.Drawing.Size(250, 26);
			this.TextBox17.TabIndex = 61;
			//
			//TextBox18
			//
			this.TextBox18.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox18.Location = new System.Drawing.Point(3, 11);
			this.TextBox18.Name = "TextBox18";
			this.TextBox18.Size = new System.Drawing.Size(252, 26);
			this.TextBox18.TabIndex = 58;
			//
			//Label22
			//
			this.Label22.AutoSize = true;
			this.Label22.Font = new System.Drawing.Font("Times New Roman", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label22.Location = new System.Drawing.Point(123, 6);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(84, 31);
			this.Label22.TabIndex = 68;
			this.Label22.Text = "Father";
			//
			//TextBox6
			//
			this.TextBox6.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox6.Location = new System.Drawing.Point(127, 40);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new System.Drawing.Size(252, 26);
			this.TextBox6.TabIndex = 52;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(47, 44);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(50, 22);
			this.Label6.TabIndex = 65;
			this.Label6.Text = "ID NO";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label11.Location = new System.Drawing.Point(54, 168);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(51, 22);
			this.Label11.TabIndex = 64;
			this.Label11.Text = "EMAIL";
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label15.Location = new System.Drawing.Point(26, 281);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(88, 22);
			this.Label15.TabIndex = 63;
			this.Label15.Text = "RESIDENCE";
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label16.Location = new System.Drawing.Point(20, 131);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(94, 22);
			this.Label16.TabIndex = 62;
			this.Label16.Text = "TELEPHONE";
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label17.Location = new System.Drawing.Point(20, 243);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(85, 22);
			this.Label17.TabIndex = 60;
			this.Label17.Text = "EMPLOYER";
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label18.Location = new System.Drawing.Point(20, 206);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(103, 22);
			this.Label18.TabIndex = 59;
			this.Label18.Text = "OCCUPATION";
			//
			//Label19
			//
			this.Label19.AutoSize = true;
			this.Label19.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label19.Location = new System.Drawing.Point(47, 87);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(57, 22);
			this.Label19.TabIndex = 58;
			this.Label19.Text = "NAMES";
			//
			//Panel4
			//
			this.Panel4.Controls.Add(this.Panel6);
			this.Panel4.Controls.Add(this.Label20);
			this.Panel4.Controls.Add(this.TextBox13);
			this.Panel4.Controls.Add(this.Label14);
			this.Panel4.Controls.Add(this.Label23);
			this.Panel4.Controls.Add(this.Label13);
			this.Panel4.Controls.Add(this.Label12);
			this.Panel4.Controls.Add(this.Label10);
			this.Panel4.Controls.Add(this.Label9);
			this.Panel4.Controls.Add(this.Label8);
			this.Panel4.Location = new System.Drawing.Point(6, 50);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(401, 313);
			this.Panel4.TabIndex = 52;
			//
			//Panel6
			//
			this.Panel6.Controls.Add(this.TextBox21);
			this.Panel6.Controls.Add(this.TextBox12);
			this.Panel6.Controls.Add(this.TextBox11);
			this.Panel6.Controls.Add(this.TextBox9);
			this.Panel6.Controls.Add(this.TextBox8);
			this.Panel6.Controls.Add(this.TextBox7);
			this.Panel6.Enabled = false;
			this.Panel6.Location = new System.Drawing.Point(116, 65);
			this.Panel6.Name = "Panel6";
			this.Panel6.Size = new System.Drawing.Size(268, 248);
			this.Panel6.TabIndex = 68;
			//
			//TextBox21
			//
			this.TextBox21.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox21.Location = new System.Drawing.Point(9, 93);
			this.TextBox21.Name = "TextBox21";
			this.TextBox21.Size = new System.Drawing.Size(252, 26);
			this.TextBox21.TabIndex = 60;
			//
			//TextBox12
			//
			this.TextBox12.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox12.Location = new System.Drawing.Point(9, 206);
			this.TextBox12.Name = "TextBox12";
			this.TextBox12.Size = new System.Drawing.Size(250, 26);
			this.TextBox12.TabIndex = 63;
			//
			//TextBox11
			//
			this.TextBox11.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox11.Location = new System.Drawing.Point(8, 56);
			this.TextBox11.Name = "TextBox11";
			this.TextBox11.Size = new System.Drawing.Size(252, 26);
			this.TextBox11.TabIndex = 59;
			//
			//TextBox9
			//
			this.TextBox9.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox9.Location = new System.Drawing.Point(8, 168);
			this.TextBox9.Name = "TextBox9";
			this.TextBox9.Size = new System.Drawing.Size(252, 26);
			this.TextBox9.TabIndex = 62;
			//
			//TextBox8
			//
			this.TextBox8.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox8.Location = new System.Drawing.Point(9, 131);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.Size = new System.Drawing.Size(250, 26);
			this.TextBox8.TabIndex = 61;
			//
			//TextBox7
			//
			this.TextBox7.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox7.Location = new System.Drawing.Point(8, 17);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.Size = new System.Drawing.Size(252, 26);
			this.TextBox7.TabIndex = 58;
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.Font = new System.Drawing.Font("Times New Roman", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label20.Location = new System.Drawing.Point(163, 1);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(95, 31);
			this.Label20.TabIndex = 67;
			this.Label20.Text = "Mother";
			//
			//TextBox13
			//
			this.TextBox13.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox13.Location = new System.Drawing.Point(130, 36);
			this.TextBox13.Name = "TextBox13";
			this.TextBox13.Size = new System.Drawing.Size(252, 26);
			this.TextBox13.TabIndex = 52;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label14.Location = new System.Drawing.Point(57, 40);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(50, 22);
			this.Label14.TabIndex = 65;
			this.Label14.Text = "ID NO";
			//
			//Label23
			//
			this.Label23.AutoSize = true;
			this.Label23.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label23.Location = new System.Drawing.Point(57, 163);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(51, 22);
			this.Label23.TabIndex = 64;
			this.Label23.Text = "EMAIL";
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(29, 276);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(88, 22);
			this.Label13.TabIndex = 63;
			this.Label13.Text = "RESIDENCE";
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label12.Location = new System.Drawing.Point(23, 126);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(94, 22);
			this.Label12.TabIndex = 62;
			this.Label12.Text = "TELEPHONE";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label10.Location = new System.Drawing.Point(23, 238);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(85, 22);
			this.Label10.TabIndex = 60;
			this.Label10.Text = "EMPLOYER";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(14, 197);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(103, 22);
			this.Label9.TabIndex = 59;
			this.Label9.Text = "OCCUPATION";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(50, 83);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(57, 22);
			this.Label8.TabIndex = 58;
			this.Label8.Text = "NAMES";
			//
			//TabPage3
			//
			this.TabPage3.BackColor = System.Drawing.Color.LightGray;
			this.TabPage3.Controls.Add(this.GroupBox1);
			this.TabPage3.Controls.Add(this.GroupBox3);
			this.TabPage3.Location = new System.Drawing.Point(4, 22);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage3.Size = new System.Drawing.Size(830, 384);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "official";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label27);
			this.GroupBox1.Location = new System.Drawing.Point(111, 141);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(606, 146);
			this.GroupBox1.TabIndex = 74;
			this.GroupBox1.TabStop = false;
			//
			//Label27
			//
			this.Label27.AutoSize = true;
			this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label27.Location = new System.Drawing.Point(6, 32);
			this.Label27.Name = "Label27";
			this.Label27.Size = new System.Drawing.Size(578, 62);
			this.Label27.TabIndex = 0;
			this.Label27.Text = "You have successfully registed into the system" + Strings.ChrW(13) + Strings.ChrW(10) + "                             than" + "k you";
			this.Label27.Visible = false;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.ComboBox2);
			this.GroupBox3.Controls.Add(this.ComboBox1);
			this.GroupBox3.Controls.Add(this.Label26);
			this.GroupBox3.Controls.Add(this.Label25);
			this.GroupBox3.Location = new System.Drawing.Point(6, 6);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(818, 70);
			this.GroupBox3.TabIndex = 73;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Official Details";
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(295, 21);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(109, 21);
			this.ComboBox2.TabIndex = 45;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(105, 21);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(86, 21);
			this.ComboBox1.TabIndex = 44;
			//
			//Label26
			//
			this.Label26.AutoSize = true;
			this.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label26.Location = new System.Drawing.Point(214, 27);
			this.Label26.Name = "Label26";
			this.Label26.Size = new System.Drawing.Size(54, 15);
			this.Label26.TabIndex = 43;
			this.Label26.Text = "STREAM";
			//
			//Label25
			//
			this.Label25.AutoSize = true;
			this.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label25.Location = new System.Drawing.Point(22, 27);
			this.Label25.Name = "Label25";
			this.Label25.Size = new System.Drawing.Size(43, 15);
			this.Label25.TabIndex = 42;
			this.Label25.Text = "CLASS";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(750, 464);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(85, 27);
			this.Button1.TabIndex = 57;
			this.Button1.Text = "NEXT";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Visible = false;
			//
			//Button5
			//
			this.Button5.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button5.Location = new System.Drawing.Point(750, 464);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(85, 27);
			this.Button5.TabIndex = 54;
			this.Button5.Text = "NEXT";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(199, 464);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(491, 11);
			this.ProgressBar1.TabIndex = 55;
			//
			//Label24
			//
			this.Label24.AutoSize = true;
			this.Label24.Location = new System.Drawing.Point(250, 478);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(36, 13);
			this.Label24.TabIndex = 56;
			this.Label24.Text = "stage ";
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(750, 461);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(85, 30);
			this.Button2.TabIndex = 68;
			this.Button2.Text = "FINISH";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.Visible = false;
			//
			//Timer1
			//
			//
			//new_student
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 496);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label24);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Button5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "new_student";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "new_student";
			this.Panel2.ResumeLayout(false);
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.Panel5.ResumeLayout(false);
			this.Panel5.PerformLayout();
			this.Panel7.ResumeLayout(false);
			this.Panel7.PerformLayout();
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			this.Panel6.ResumeLayout(false);
			this.Panel6.PerformLayout();
			this.TabPage3.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.TextBox TextBox5;
		private System.Windows.Forms.CheckBox withEventsField_CheckBox1;
		internal System.Windows.Forms.CheckBox CheckBox1 {
			get { return withEventsField_CheckBox1; }
			set {
				if (withEventsField_CheckBox1 != null) {
					withEventsField_CheckBox1.CheckedChanged -= CheckBox1_CheckedChanged;
				}
				withEventsField_CheckBox1 = value;
				if (withEventsField_CheckBox1 != null) {
					withEventsField_CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;
				}
			}
		}
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.DateTimePicker Date1;
		internal System.Windows.Forms.TextBox TextBox23;
		internal System.Windows.Forms.Label Label28;
		private System.Windows.Forms.TextBox withEventsField_TextBox4;
		internal System.Windows.Forms.TextBox TextBox4 {
			get { return withEventsField_TextBox4; }
			set {
				if (withEventsField_TextBox4 != null) {
					withEventsField_TextBox4.TextChanged -= TextBox4_TextChanged;
				}
				withEventsField_TextBox4 = value;
				if (withEventsField_TextBox4 != null) {
					withEventsField_TextBox4.TextChanged += TextBox4_TextChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox3;
		internal System.Windows.Forms.TextBox TextBox3 {
			get { return withEventsField_TextBox3; }
			set {
				if (withEventsField_TextBox3 != null) {
					withEventsField_TextBox3.TextChanged -= TextBox3_TextChanged;
				}
				withEventsField_TextBox3 = value;
				if (withEventsField_TextBox3 != null) {
					withEventsField_TextBox3.TextChanged += TextBox3_TextChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox2;
		internal System.Windows.Forms.TextBox TextBox2 {
			get { return withEventsField_TextBox2; }
			set {
				if (withEventsField_TextBox2 != null) {
					withEventsField_TextBox2.KeyPress -= TextBox2_KeyPress;
					withEventsField_TextBox2.TextChanged -= TextBox2_TextChanged;
				}
				withEventsField_TextBox2 = value;
				if (withEventsField_TextBox2 != null) {
					withEventsField_TextBox2.KeyPress += TextBox2_KeyPress;
					withEventsField_TextBox2.TextChanged += TextBox2_TextChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox1;
		internal System.Windows.Forms.TextBox TextBox1 {
			get { return withEventsField_TextBox1; }
			set {
				if (withEventsField_TextBox1 != null) {
					withEventsField_TextBox1.KeyPress -= TextBox1_KeyPress;
					withEventsField_TextBox1.TextChanged -= TextBox1_TextChanged;
				}
				withEventsField_TextBox1 = value;
				if (withEventsField_TextBox1 != null) {
					withEventsField_TextBox1.KeyPress += TextBox1_KeyPress;
					withEventsField_TextBox1.TextChanged += TextBox1_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TabPage TabPage3;
		private System.Windows.Forms.Button withEventsField_Button5;
		internal System.Windows.Forms.Button Button5 {
			get { return withEventsField_Button5; }
			set {
				if (withEventsField_Button5 != null) {
					withEventsField_Button5.Click -= Button5_Click;
				}
				withEventsField_Button5 = value;
				if (withEventsField_Button5 != null) {
					withEventsField_Button5.Click += Button5_Click;
				}
			}
		}
		internal System.Windows.Forms.Panel Panel5;
		internal System.Windows.Forms.Label Label22;
		private System.Windows.Forms.TextBox withEventsField_TextBox6;
		internal System.Windows.Forms.TextBox TextBox6 {
			get { return withEventsField_TextBox6; }
			set {
				if (withEventsField_TextBox6 != null) {
					withEventsField_TextBox6.KeyPress -= TextBox6_KeyPress;
					withEventsField_TextBox6.TextChanged -= TextBox6_TextChanged;
				}
				withEventsField_TextBox6 = value;
				if (withEventsField_TextBox6 != null) {
					withEventsField_TextBox6.KeyPress += TextBox6_KeyPress;
					withEventsField_TextBox6.TextChanged += TextBox6_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Label Label20;
		private System.Windows.Forms.TextBox withEventsField_TextBox13;
		internal System.Windows.Forms.TextBox TextBox13 {
			get { return withEventsField_TextBox13; }
			set {
				if (withEventsField_TextBox13 != null) {
					withEventsField_TextBox13.KeyPress -= TextBox13_KeyPress;
					withEventsField_TextBox13.TextChanged -= TextBox13_TextChanged;
				}
				withEventsField_TextBox13 = value;
				if (withEventsField_TextBox13 != null) {
					withEventsField_TextBox13.KeyPress += TextBox13_KeyPress;
					withEventsField_TextBox13.TextChanged += TextBox13_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.Label Label25;
		private System.Windows.Forms.CheckBox withEventsField_CheckBox3;
		internal System.Windows.Forms.CheckBox CheckBox3 {
			get { return withEventsField_CheckBox3; }
			set {
				if (withEventsField_CheckBox3 != null) {
					withEventsField_CheckBox3.CheckedChanged -= CheckBox3_CheckedChanged;
				}
				withEventsField_CheckBox3 = value;
				if (withEventsField_CheckBox3 != null) {
					withEventsField_CheckBox3.CheckedChanged += CheckBox3_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.CheckBox withEventsField_CheckBox2;
		internal System.Windows.Forms.CheckBox CheckBox2 {
			get { return withEventsField_CheckBox2; }
			set {
				if (withEventsField_CheckBox2 != null) {
					withEventsField_CheckBox2.CheckedChanged -= CheckBox2_CheckedChanged;
				}
				withEventsField_CheckBox2 = value;
				if (withEventsField_CheckBox2 != null) {
					withEventsField_CheckBox2.CheckedChanged += CheckBox2_CheckedChanged;
				}
			}
		}
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		internal System.Windows.Forms.Label Label24;
		private System.Windows.Forms.Button withEventsField_Button1;
		internal System.Windows.Forms.Button Button1 {
			get { return withEventsField_Button1; }
			set {
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click -= Button1_Click;
				}
				withEventsField_Button1 = value;
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click += Button1_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button2;
		internal System.Windows.Forms.Button Button2 {
			get { return withEventsField_Button2; }
			set {
				if (withEventsField_Button2 != null) {
					withEventsField_Button2.Click -= Button2_Click;
				}
				withEventsField_Button2 = value;
				if (withEventsField_Button2 != null) {
					withEventsField_Button2.Click += Button2_Click;
				}
			}
		}
		internal System.Windows.Forms.Panel Panel6;
		internal System.Windows.Forms.TextBox TextBox21;
		internal System.Windows.Forms.TextBox TextBox12;
		internal System.Windows.Forms.TextBox TextBox11;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.TextBox TextBox7;
		internal System.Windows.Forms.Panel Panel7;
		internal System.Windows.Forms.TextBox TextBox10;
		internal System.Windows.Forms.TextBox TextBox14;
		internal System.Windows.Forms.TextBox TextBox15;
		internal System.Windows.Forms.TextBox TextBox16;
		internal System.Windows.Forms.TextBox TextBox17;
		internal System.Windows.Forms.TextBox TextBox18;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label27;
		private System.Windows.Forms.Timer withEventsField_Timer1;
		internal System.Windows.Forms.Timer Timer1 {
			get { return withEventsField_Timer1; }
			set {
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick -= Timer1_Tick;
				}
				withEventsField_Timer1 = value;
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick += Timer1_Tick;
				}
			}
		}
		public new_student()
		{
			Load += new_student_Load;
			InitializeComponent();
		}
	}
}
