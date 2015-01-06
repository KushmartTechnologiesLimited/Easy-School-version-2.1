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
	partial class collect_fees : System.Windows.Forms.Form
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label11 = new System.Windows.Forms.Label();
			this.TextBox9 = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.TextBox7 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Button3 = new System.Windows.Forms.Button();
			this.Panel5 = new System.Windows.Forms.Panel();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.TextBox14 = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.TextBox15 = new System.Windows.Forms.TextBox();
			this.RadioButton4 = new System.Windows.Forms.RadioButton();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.Label8 = new System.Windows.Forms.Label();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Button6 = new System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.Button5);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label11);
			this.Panel1.Controls.Add(this.TextBox9);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.TextBox8);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.TextBox7);
			this.Panel1.Controls.Add(this.TextBox1);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Location = new System.Drawing.Point(12, 10);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(772, 147);
			this.Panel1.TabIndex = 0;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(515, 11);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(119, 23);
			this.Button5.TabIndex = 124;
			this.Button5.Text = "Generate Invoice";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Location = new System.Drawing.Point(360, 10);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(102, 23);
			this.Button1.TabIndex = 123;
			this.Button1.Text = "Find";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label11.Location = new System.Drawing.Point(375, 104);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(62, 21);
			this.Label11.TabIndex = 121;
			this.Label11.Text = "Stream";
			//
			//TextBox9
			//
			this.TextBox9.BackColor = System.Drawing.Color.LightGray;
			this.TextBox9.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox9.Location = new System.Drawing.Point(443, 96);
			this.TextBox9.Name = "TextBox9";
			this.TextBox9.ReadOnly = true;
			this.TextBox9.Size = new System.Drawing.Size(237, 29);
			this.TextBox9.TabIndex = 122;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label10.Location = new System.Drawing.Point(90, 104);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(51, 21);
			this.Label10.TabIndex = 119;
			this.Label10.Text = "Class";
			//
			//TextBox8
			//
			this.TextBox8.BackColor = System.Drawing.Color.LightGray;
			this.TextBox8.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox8.Location = new System.Drawing.Point(150, 96);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.ReadOnly = true;
			this.TextBox8.Size = new System.Drawing.Size(170, 29);
			this.TextBox8.TabIndex = 120;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(18, 60);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(123, 21);
			this.Label9.TabIndex = 117;
			this.Label9.Text = "Students Name";
			//
			//TextBox7
			//
			this.TextBox7.BackColor = System.Drawing.Color.LightGray;
			this.TextBox7.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox7.Location = new System.Drawing.Point(150, 52);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.ReadOnly = true;
			this.TextBox7.Size = new System.Drawing.Size(533, 29);
			this.TextBox7.TabIndex = 118;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(150, 10);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(192, 20);
			this.TextBox1.TabIndex = 112;
			this.TextBox1.Text = "0";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(81, 14);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(60, 16);
			this.Label5.TabIndex = 111;
			this.Label5.Text = "Adm No ";
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.Button3);
			this.Panel2.Controls.Add(this.Panel5);
			this.Panel2.Controls.Add(this.Panel4);
			this.Panel2.Controls.Add(this.Panel3);
			this.Panel2.Location = new System.Drawing.Point(2, 163);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(772, 349);
			this.Panel2.TabIndex = 1;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(701, 310);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(56, 23);
			this.Button3.TabIndex = 131;
			this.Button3.Text = "Cancel";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Panel5
			//
			this.Panel5.Controls.Add(this.Button6);
			this.Panel5.Controls.Add(this.Button4);
			this.Panel5.Controls.Add(this.Button2);
			this.Panel5.Enabled = false;
			this.Panel5.Location = new System.Drawing.Point(346, 290);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new System.Drawing.Size(349, 56);
			this.Panel5.TabIndex = 130;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(11, 20);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(115, 23);
			this.Button4.TabIndex = 129;
			this.Button4.Text = "View Fees Summary";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(149, 20);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(91, 23);
			this.Button2.TabIndex = 127;
			this.Button2.Text = "Save and Print";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Panel4
			//
			this.Panel4.Controls.Add(this.GroupBox4);
			this.Panel4.Controls.Add(this.RadioButton4);
			this.Panel4.Controls.Add(this.RadioButton3);
			this.Panel4.Controls.Add(this.RadioButton2);
			this.Panel4.Controls.Add(this.RadioButton1);
			this.Panel4.Controls.Add(this.Label8);
			this.Panel4.Location = new System.Drawing.Point(341, 3);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(399, 283);
			this.Panel4.TabIndex = 126;
			//
			//GroupBox4
			//
			this.GroupBox4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.GroupBox4.Controls.Add(this.Label18);
			this.GroupBox4.Controls.Add(this.TextBox14);
			this.GroupBox4.Controls.Add(this.Label15);
			this.GroupBox4.Controls.Add(this.TextBox15);
			this.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox4.Location = new System.Drawing.Point(20, 98);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(367, 159);
			this.GroupBox4.TabIndex = 130;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "deposit slip  details";
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label18.Location = new System.Drawing.Point(8, 92);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(120, 17);
			this.Label18.TabIndex = 3;
			this.Label18.Text = "transaction number";
			//
			//TextBox14
			//
			this.TextBox14.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox14.Location = new System.Drawing.Point(138, 89);
			this.TextBox14.Name = "TextBox14";
			this.TextBox14.Size = new System.Drawing.Size(208, 25);
			this.TextBox14.TabIndex = 2;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label15.Location = new System.Drawing.Point(16, 48);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(72, 17);
			this.Label15.TabIndex = 1;
			this.Label15.Text = "bank name";
			//
			//TextBox15
			//
			this.TextBox15.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox15.Location = new System.Drawing.Point(138, 40);
			this.TextBox15.Name = "TextBox15";
			this.TextBox15.Size = new System.Drawing.Size(208, 25);
			this.TextBox15.TabIndex = 0;
			//
			//RadioButton4
			//
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.RadioButton4.Location = new System.Drawing.Point(309, 44);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new System.Drawing.Size(78, 25);
			this.RadioButton4.TabIndex = 128;
			this.RadioButton4.Text = "Mpesa";
			this.RadioButton4.UseVisualStyleBackColor = true;
			//
			//RadioButton3
			//
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.RadioButton3.Location = new System.Drawing.Point(210, 44);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new System.Drawing.Size(93, 25);
			this.RadioButton3.TabIndex = 127;
			this.RadioButton3.Text = "Cheques";
			this.RadioButton3.UseVisualStyleBackColor = true;
			//
			//RadioButton2
			//
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.RadioButton2.Location = new System.Drawing.Point(112, 44);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(92, 25);
			this.RadioButton2.TabIndex = 126;
			this.RadioButton2.Text = "Bankslip" + Strings.ChrW(13) + Strings.ChrW(10);
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//RadioButton1
			//
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			this.RadioButton1.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.RadioButton1.Location = new System.Drawing.Point(20, 44);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(66, 25);
			this.RadioButton1.TabIndex = 125;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "Cash";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(108, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(137, 21);
			this.Label8.TabIndex = 124;
			this.Label8.Text = "Payment Method";
			//
			//Panel3
			//
			this.Panel3.Controls.Add(this.DateTimePicker1);
			this.Panel3.Controls.Add(this.Label12);
			this.Panel3.Controls.Add(this.Label7);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Controls.Add(this.TextBox2);
			this.Panel3.Controls.Add(this.TextBox6);
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Controls.Add(this.Label6);
			this.Panel3.Controls.Add(this.TextBox3);
			this.Panel3.Controls.Add(this.TextBox5);
			this.Panel3.Controls.Add(this.Label3);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Controls.Add(this.TextBox4);
			this.Panel3.Location = new System.Drawing.Point(3, 3);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(332, 339);
			this.Panel3.TabIndex = 125;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(135, 41);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(170, 29);
			this.DateTimePicker1.TabIndex = 125;
			this.DateTimePicker1.Value = new System.DateTime(2014, 7, 5, 23, 15, 4, 0);
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label12.Location = new System.Drawing.Point(53, 48);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(44, 21);
			this.Label12.TabIndex = 124;
			this.Label12.Text = "Date" + Strings.ChrW(13) + Strings.ChrW(10);
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(131, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(129, 21);
			this.Label7.TabIndex = 123;
			this.Label7.Text = "Account Details";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(25, 101);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(94, 21);
			this.Label1.TabIndex = 113;
			this.Label1.Text = "Balance b/f";
			this.Label1.Visible = false;
			//
			//TextBox2
			//
			this.TextBox2.BackColor = System.Drawing.Color.LightGray;
			this.TextBox2.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox2.Location = new System.Drawing.Point(135, 98);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.ReadOnly = true;
			this.TextBox2.Size = new System.Drawing.Size(170, 29);
			this.TextBox2.TabIndex = 114;
			this.TextBox2.Text = "0";
			this.TextBox2.Visible = false;
			//
			//TextBox6
			//
			this.TextBox6.BackColor = System.Drawing.Color.LightGray;
			this.TextBox6.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox6.Location = new System.Drawing.Point(135, 289);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.ReadOnly = true;
			this.TextBox6.Size = new System.Drawing.Size(170, 29);
			this.TextBox6.TabIndex = 122;
			this.TextBox6.Text = "0";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(20, 152);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(111, 21);
			this.Label2.TabIndex = 115;
			this.Label2.Text = "Last Payment";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(20, 292);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(101, 21);
			this.Label6.TabIndex = 121;
			this.Label6.Text = "Balance C/d";
			//
			//TextBox3
			//
			this.TextBox3.BackColor = System.Drawing.Color.LightGray;
			this.TextBox3.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox3.Location = new System.Drawing.Point(135, 149);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.ReadOnly = true;
			this.TextBox3.Size = new System.Drawing.Size(170, 29);
			this.TextBox3.TabIndex = 116;
			this.TextBox3.Text = "0";
			//
			//TextBox5
			//
			this.TextBox5.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox5.Location = new System.Drawing.Point(135, 241);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(170, 29);
			this.TextBox5.TabIndex = 120;
			this.TextBox5.Text = "0";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(31, 205);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(83, 21);
			this.Label3.TabIndex = 117;
			this.Label3.Text = "Total Due";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(71, 244);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(43, 21);
			this.Label4.TabIndex = 119;
			this.Label4.Text = "Paid";
			//
			//TextBox4
			//
			this.TextBox4.BackColor = System.Drawing.Color.LightGray;
			this.TextBox4.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox4.Location = new System.Drawing.Point(135, 197);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.ReadOnly = true;
			this.TextBox4.Size = new System.Drawing.Size(170, 29);
			this.TextBox4.TabIndex = 118;
			this.TextBox4.Text = "0";
			//
			//Button6
			//
			this.Button6.Location = new System.Drawing.Point(246, 20);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(91, 23);
			this.Button6.TabIndex = 130;
			this.Button6.Text = "Save ";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//collect_fees
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 514);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Name = "collect_fees";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "collect_fees";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel5.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Panel withEventsField_Panel1;
		internal System.Windows.Forms.Panel Panel1 {
			get { return withEventsField_Panel1; }
			set {
				if (withEventsField_Panel1 != null) {
					withEventsField_Panel1.Paint -= Panel1_Paint;
				}
				withEventsField_Panel1 = value;
				if (withEventsField_Panel1 != null) {
					withEventsField_Panel1.Paint += Panel1_Paint;
				}
			}
		}
		internal System.Windows.Forms.Panel Panel2;
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
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Panel Panel4;
		private System.Windows.Forms.RadioButton withEventsField_RadioButton4;
		internal System.Windows.Forms.RadioButton RadioButton4 {
			get { return withEventsField_RadioButton4; }
			set {
				if (withEventsField_RadioButton4 != null) {
					withEventsField_RadioButton4.CheckedChanged -= RadioButton4_CheckedChanged;
				}
				withEventsField_RadioButton4 = value;
				if (withEventsField_RadioButton4 != null) {
					withEventsField_RadioButton4.CheckedChanged += RadioButton4_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_RadioButton3;
		internal System.Windows.Forms.RadioButton RadioButton3 {
			get { return withEventsField_RadioButton3; }
			set {
				if (withEventsField_RadioButton3 != null) {
					withEventsField_RadioButton3.CheckedChanged -= RadioButton3_CheckedChanged;
				}
				withEventsField_RadioButton3 = value;
				if (withEventsField_RadioButton3 != null) {
					withEventsField_RadioButton3.CheckedChanged += RadioButton3_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton2 {
			get { return withEventsField_RadioButton2; }
			set {
				if (withEventsField_RadioButton2 != null) {
					withEventsField_RadioButton2.CheckedChanged -= RadioButton2_CheckedChanged;
				}
				withEventsField_RadioButton2 = value;
				if (withEventsField_RadioButton2 != null) {
					withEventsField_RadioButton2.CheckedChanged += RadioButton2_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_RadioButton1;
		internal System.Windows.Forms.RadioButton RadioButton1 {
			get { return withEventsField_RadioButton1; }
			set {
				if (withEventsField_RadioButton1 != null) {
					withEventsField_RadioButton1.CheckedChanged -= RadioButton1_CheckedChanged;
				}
				withEventsField_RadioButton1 = value;
				if (withEventsField_RadioButton1 != null) {
					withEventsField_RadioButton1.CheckedChanged += RadioButton1_CheckedChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TextBox withEventsField_TextBox2;
		internal System.Windows.Forms.TextBox TextBox2 {
			get { return withEventsField_TextBox2; }
			set {
				if (withEventsField_TextBox2 != null) {
					withEventsField_TextBox2.TextChanged -= TextBox2_TextChanged;
				}
				withEventsField_TextBox2 = value;
				if (withEventsField_TextBox2 != null) {
					withEventsField_TextBox2.TextChanged += TextBox2_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.Label Label6;
		private System.Windows.Forms.TextBox withEventsField_TextBox5;
		internal System.Windows.Forms.TextBox TextBox5 {
			get { return withEventsField_TextBox5; }
			set {
				if (withEventsField_TextBox5 != null) {
					withEventsField_TextBox5.KeyPress -= TextBox5_KeyPress;
					withEventsField_TextBox5.TextChanged -= TextBox5_TextChanged;
				}
				withEventsField_TextBox5 = value;
				if (withEventsField_TextBox5 != null) {
					withEventsField_TextBox5.KeyPress += TextBox5_KeyPress;
					withEventsField_TextBox5.TextChanged += TextBox5_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
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
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox TextBox7;
		private System.Windows.Forms.Button withEventsField_Button4;
		internal System.Windows.Forms.Button Button4 {
			get { return withEventsField_Button4; }
			set {
				if (withEventsField_Button4 != null) {
					withEventsField_Button4.Click -= Button4_Click;
				}
				withEventsField_Button4 = value;
				if (withEventsField_Button4 != null) {
					withEventsField_Button4.Click += Button4_Click;
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
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.TextBox TextBox14;
		internal System.Windows.Forms.Label Label15;
		private System.Windows.Forms.TextBox withEventsField_TextBox15;
		internal System.Windows.Forms.TextBox TextBox15 {
			get { return withEventsField_TextBox15; }
			set {
				if (withEventsField_TextBox15 != null) {
					withEventsField_TextBox15.TextChanged -= TextBox15_TextChanged;
				}
				withEventsField_TextBox15 = value;
				if (withEventsField_TextBox15 != null) {
					withEventsField_TextBox15.TextChanged += TextBox15_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label2;
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
		private System.Windows.Forms.Button withEventsField_Button3;
		internal System.Windows.Forms.Button Button3 {
			get { return withEventsField_Button3; }
			set {
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click -= Button3_Click_1;
				}
				withEventsField_Button3 = value;
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click += Button3_Click_1;
				}
			}
		}
		internal System.Windows.Forms.Panel Panel5;
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
		private System.Windows.Forms.Button withEventsField_Button6;
		internal System.Windows.Forms.Button Button6 {
			get { return withEventsField_Button6; }
			set {
				if (withEventsField_Button6 != null) {
					withEventsField_Button6.Click -= Button6_Click;
				}
				withEventsField_Button6 = value;
				if (withEventsField_Button6 != null) {
					withEventsField_Button6.Click += Button6_Click;
				}
			}
		}
	}
}
