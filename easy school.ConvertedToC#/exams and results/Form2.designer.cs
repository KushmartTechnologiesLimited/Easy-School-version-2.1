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
	partial class Form2 : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.TextBox21 = new System.Windows.Forms.TextBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.ComboBox3 = new System.Windows.Forms.ComboBox();
			this.ComboBox4 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Button3 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Button6 = new System.Windows.Forms.Button();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Button4 = new System.Windows.Forms.Button();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.TextBox19 = new System.Windows.Forms.TextBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.TextBox18 = new System.Windows.Forms.TextBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.GroupBox8 = new System.Windows.Forms.GroupBox();
			this.TextBox14 = new System.Windows.Forms.TextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.TextBox15 = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.TextBox16 = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.TextBox17 = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.GroupBox7 = new System.Windows.Forms.GroupBox();
			this.TextBox13 = new System.Windows.Forms.TextBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.TextBox12 = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.TextBox11 = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.TextBox10 = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.TextBox7 = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.TextBox9 = new System.Windows.Forms.TextBox();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox20 = new System.Windows.Forms.TextBox();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button7 = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.GroupBox9.SuspendLayout();
			this.GroupBox8.SuspendLayout();
			this.GroupBox7.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.ComboBox2);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(43, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(308, 126);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "CLASS DETAILS";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(243, 85);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(54, 20);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(173, 51);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(98, 21);
			this.ComboBox2.TabIndex = 3;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(13, 52);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(92, 21);
			this.ComboBox1.TabIndex = 2;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(198, 21);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(52, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "STREAM";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(20, 20);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(41, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "CLASS";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.TextBox21);
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Controls.Add(this.RadioButton3);
			this.GroupBox2.Controls.Add(this.RadioButton2);
			this.GroupBox2.Controls.Add(this.RadioButton1);
			this.GroupBox2.Controls.Add(this.ComboBox3);
			this.GroupBox2.Controls.Add(this.ComboBox4);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Location = new System.Drawing.Point(31, 154);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(320, 126);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "EXAM DETAILS";
			//
			//TextBox21
			//
			this.TextBox21.Enabled = false;
			this.TextBox21.Location = new System.Drawing.Point(10, 87);
			this.TextBox21.Name = "TextBox21";
			this.TextBox21.Size = new System.Drawing.Size(191, 20);
			this.TextBox21.TabIndex = 8;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(260, 85);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(54, 20);
			this.Button2.TabIndex = 7;
			this.Button2.Text = "OK";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//RadioButton3
			//
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Location = new System.Drawing.Point(207, 63);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new System.Drawing.Size(85, 17);
			this.RadioButton3.TabIndex = 6;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "END TERM ";
			this.RadioButton3.UseVisualStyleBackColor = true;
			//
			//RadioButton2
			//
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new System.Drawing.Point(205, 40);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(82, 17);
			this.RadioButton2.TabIndex = 5;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "MID TERM ";
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//RadioButton1
			//
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new System.Drawing.Point(205, 17);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(87, 17);
			this.RadioButton1.TabIndex = 4;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "STARRT UP";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//ComboBox3
			//
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new System.Drawing.Point(64, 51);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new System.Drawing.Size(92, 21);
			this.ComboBox3.TabIndex = 3;
			//
			//ComboBox4
			//
			this.ComboBox4.FormattingEnabled = true;
			this.ComboBox4.Location = new System.Drawing.Point(64, 16);
			this.ComboBox4.Name = "ComboBox4";
			this.ComboBox4.Size = new System.Drawing.Size(92, 21);
			this.ComboBox4.TabIndex = 2;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(6, 54);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(38, 13);
			this.Label3.TabIndex = 1;
			this.Label3.Text = "TERM";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(6, 19);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(36, 13);
			this.Label4.TabIndex = 0;
			this.Label4.Text = "YEAR";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(12, 353);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(106, 13);
			this.Label5.TabIndex = 2;
			this.Label5.Text = "ENTER ADMNO NO";
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(254, 346);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(91, 27);
			this.Button3.TabIndex = 3;
			this.Button3.Text = "FIND";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(135, 350);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(97, 20);
			this.TextBox1.TabIndex = 4;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Button6);
			this.GroupBox3.Controls.Add(this.DataGridView1);
			this.GroupBox3.Controls.Add(this.Button4);
			this.GroupBox3.Controls.Add(this.GroupBox9);
			this.GroupBox3.Controls.Add(this.GroupBox8);
			this.GroupBox3.Controls.Add(this.GroupBox7);
			this.GroupBox3.Controls.Add(this.GroupBox4);
			this.GroupBox3.Enabled = false;
			this.GroupBox3.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox3.Location = new System.Drawing.Point(370, 55);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(811, 457);
			this.GroupBox3.TabIndex = 5;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "MARKS";
			//
			//Button6
			//
			this.Button6.Font = new System.Drawing.Font("Times New Roman", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button6.Location = new System.Drawing.Point(727, 256);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(67, 25);
			this.Button6.TabIndex = 5;
			this.Button6.Text = "CANCEL";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(-20, 330);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.RowHeadersWidth = 30;
			this.DataGridView1.Size = new System.Drawing.Size(825, 109);
			this.DataGridView1.TabIndex = 3;
			//
			//Button4
			//
			this.Button4.Font = new System.Drawing.Font("Times New Roman", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.Location = new System.Drawing.Point(729, 294);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(63, 29);
			this.Button4.TabIndex = 4;
			this.Button4.Text = "SUBMIT";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//GroupBox9
			//
			this.GroupBox9.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.GroupBox9.Controls.Add(this.TextBox19);
			this.GroupBox9.Controls.Add(this.Label23);
			this.GroupBox9.Controls.Add(this.TextBox18);
			this.GroupBox9.Controls.Add(this.Label22);
			this.GroupBox9.Location = new System.Drawing.Point(338, 218);
			this.GroupBox9.Name = "GroupBox9";
			this.GroupBox9.Size = new System.Drawing.Size(381, 93);
			this.GroupBox9.TabIndex = 3;
			this.GroupBox9.TabStop = false;
			this.GroupBox9.Text = "TOTAL";
			//
			//TextBox19
			//
			this.TextBox19.Location = new System.Drawing.Point(243, 50);
			this.TextBox19.Name = "TextBox19";
			this.TextBox19.Size = new System.Drawing.Size(105, 26);
			this.TextBox19.TabIndex = 3;
			//
			//Label23
			//
			this.Label23.AutoSize = true;
			this.Label23.Location = new System.Drawing.Point(247, 28);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(93, 19);
			this.Label23.TabIndex = 2;
			this.Label23.Text = "ACTIVITIES";
			//
			//TextBox18
			//
			this.TextBox18.Location = new System.Drawing.Point(20, 49);
			this.TextBox18.Name = "TextBox18";
			this.TextBox18.Size = new System.Drawing.Size(106, 26);
			this.TextBox18.TabIndex = 1;
			//
			//Label22
			//
			this.Label22.AutoSize = true;
			this.Label22.Location = new System.Drawing.Point(26, 26);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(92, 19);
			this.Label22.TabIndex = 0;
			this.Label22.Text = "ACADEMIC";
			//
			//GroupBox8
			//
			this.GroupBox8.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.GroupBox8.Controls.Add(this.TextBox14);
			this.GroupBox8.Controls.Add(this.Label18);
			this.GroupBox8.Controls.Add(this.TextBox15);
			this.GroupBox8.Controls.Add(this.Label19);
			this.GroupBox8.Controls.Add(this.TextBox16);
			this.GroupBox8.Controls.Add(this.Label20);
			this.GroupBox8.Controls.Add(this.TextBox17);
			this.GroupBox8.Controls.Add(this.Label21);
			this.GroupBox8.Location = new System.Drawing.Point(475, 25);
			this.GroupBox8.Name = "GroupBox8";
			this.GroupBox8.Size = new System.Drawing.Size(244, 181);
			this.GroupBox8.TabIndex = 2;
			this.GroupBox8.TabStop = false;
			this.GroupBox8.Text = "activities";
			//
			//TextBox14
			//
			this.TextBox14.Location = new System.Drawing.Point(147, 121);
			this.TextBox14.Name = "TextBox14";
			this.TextBox14.Size = new System.Drawing.Size(64, 26);
			this.TextBox14.TabIndex = 15;
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.Location = new System.Drawing.Point(59, 124);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(29, 19);
			this.Label18.TabIndex = 14;
			this.Label18.Text = "P.E";
			//
			//TextBox15
			//
			this.TextBox15.Location = new System.Drawing.Point(147, 83);
			this.TextBox15.Name = "TextBox15";
			this.TextBox15.Size = new System.Drawing.Size(64, 26);
			this.TextBox15.TabIndex = 13;
			this.TextBox15.Text = ".................................................";
			//
			//Label19
			//
			this.Label19.AutoSize = true;
			this.Label19.Location = new System.Drawing.Point(65, 91);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(68, 19);
			this.Label19.TabIndex = 12;
			this.Label19.Text = "swimming";
			//
			//TextBox16
			//
			this.TextBox16.Location = new System.Drawing.Point(147, 51);
			this.TextBox16.Name = "TextBox16";
			this.TextBox16.Size = new System.Drawing.Size(64, 26);
			this.TextBox16.TabIndex = 11;
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.Location = new System.Drawing.Point(6, 58);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(135, 19);
			this.Label20.TabIndex = 10;
			this.Label20.Text = "music and movement";
			//
			//TextBox17
			//
			this.TextBox17.Location = new System.Drawing.Point(147, 21);
			this.TextBox17.Name = "TextBox17";
			this.TextBox17.Size = new System.Drawing.Size(64, 26);
			this.TextBox17.TabIndex = 9;
			//
			//Label21
			//
			this.Label21.AutoSize = true;
			this.Label21.Location = new System.Drawing.Point(68, 24);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(66, 19);
			this.Label21.TabIndex = 8;
			this.Label21.Text = "computer";
			//
			//GroupBox7
			//
			this.GroupBox7.BackColor = System.Drawing.SystemColors.ControlDark;
			this.GroupBox7.Controls.Add(this.TextBox13);
			this.GroupBox7.Controls.Add(this.Label17);
			this.GroupBox7.Controls.Add(this.TextBox12);
			this.GroupBox7.Controls.Add(this.Label16);
			this.GroupBox7.Controls.Add(this.TextBox11);
			this.GroupBox7.Controls.Add(this.Label15);
			this.GroupBox7.Controls.Add(this.TextBox10);
			this.GroupBox7.Controls.Add(this.Label14);
			this.GroupBox7.Location = new System.Drawing.Point(269, 25);
			this.GroupBox7.Name = "GroupBox7";
			this.GroupBox7.Size = new System.Drawing.Size(178, 181);
			this.GroupBox7.TabIndex = 1;
			this.GroupBox7.TabStop = false;
			this.GroupBox7.Text = "others";
			//
			//TextBox13
			//
			this.TextBox13.Location = new System.Drawing.Point(98, 127);
			this.TextBox13.Name = "TextBox13";
			this.TextBox13.Size = new System.Drawing.Size(64, 26);
			this.TextBox13.TabIndex = 7;
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.Location = new System.Drawing.Point(7, 130);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(63, 19);
			this.Label17.TabIndex = 6;
			this.Label17.Text = "C . R . E";
			//
			//TextBox12
			//
			this.TextBox12.Location = new System.Drawing.Point(97, 89);
			this.TextBox12.Name = "TextBox12";
			this.TextBox12.Size = new System.Drawing.Size(64, 26);
			this.TextBox12.TabIndex = 5;
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.Location = new System.Drawing.Point(6, 92);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(84, 19);
			this.Label16.TabIndex = 4;
			this.Label16.Text = "social sudies";
			//
			//TextBox11
			//
			this.TextBox11.Location = new System.Drawing.Point(97, 56);
			this.TextBox11.Name = "TextBox11";
			this.TextBox11.Size = new System.Drawing.Size(64, 26);
			this.TextBox11.TabIndex = 3;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Location = new System.Drawing.Point(6, 59);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(53, 19);
			this.Label15.TabIndex = 2;
			this.Label15.Text = "science";
			//
			//TextBox10
			//
			this.TextBox10.Location = new System.Drawing.Point(98, 22);
			this.TextBox10.Name = "TextBox10";
			this.TextBox10.Size = new System.Drawing.Size(64, 26);
			this.TextBox10.TabIndex = 1;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(7, 25);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(83, 19);
			this.Label14.TabIndex = 0;
			this.Label14.Text = "mathematics";
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.GroupBox6);
			this.GroupBox4.Controls.Add(this.GroupBox5);
			this.GroupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox4.Location = new System.Drawing.Point(21, 16);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(219, 335);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "languages";
			//
			//GroupBox6
			//
			this.GroupBox6.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.GroupBox6.Controls.Add(this.Label10);
			this.GroupBox6.Controls.Add(this.TextBox6);
			this.GroupBox6.Controls.Add(this.Label11);
			this.GroupBox6.Controls.Add(this.TextBox7);
			this.GroupBox6.Controls.Add(this.Label12);
			this.GroupBox6.Controls.Add(this.TextBox8);
			this.GroupBox6.Controls.Add(this.Label13);
			this.GroupBox6.Controls.Add(this.TextBox9);
			this.GroupBox6.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox6.Location = new System.Drawing.Point(18, 171);
			this.GroupBox6.Name = "GroupBox6";
			this.GroupBox6.Size = new System.Drawing.Size(179, 136);
			this.GroupBox6.TabIndex = 1;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "kiswahili";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label10.Location = new System.Drawing.Point(22, 105);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(34, 15);
			this.Label10.TabIndex = 7;
			this.Label10.Text = "Total";
			//
			//TextBox6
			//
			this.TextBox6.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox6.Location = new System.Drawing.Point(92, 102);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new System.Drawing.Size(70, 22);
			this.TextBox6.TabIndex = 6;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label11.Location = new System.Drawing.Point(21, 57);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(36, 15);
			this.Label11.TabIndex = 5;
			this.Label11.Text = "insha";
			//
			//TextBox7
			//
			this.TextBox7.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox7.Location = new System.Drawing.Point(92, 76);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.Size = new System.Drawing.Size(70, 22);
			this.TextBox7.TabIndex = 4;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label12.Location = new System.Drawing.Point(11, 79);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(48, 15);
			this.Label12.TabIndex = 3;
			this.Label12.Text = "kusoma";
			//
			//TextBox8
			//
			this.TextBox8.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox8.Location = new System.Drawing.Point(92, 50);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.Size = new System.Drawing.Size(70, 22);
			this.TextBox8.TabIndex = 2;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(22, 19);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(37, 15);
			this.Label13.TabIndex = 1;
			this.Label13.Text = "lugha";
			//
			//TextBox9
			//
			this.TextBox9.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox9.Location = new System.Drawing.Point(92, 16);
			this.TextBox9.Name = "TextBox9";
			this.TextBox9.Size = new System.Drawing.Size(70, 22);
			this.TextBox9.TabIndex = 0;
			//
			//GroupBox5
			//
			this.GroupBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.GroupBox5.Controls.Add(this.Label9);
			this.GroupBox5.Controls.Add(this.TextBox5);
			this.GroupBox5.Controls.Add(this.Label8);
			this.GroupBox5.Controls.Add(this.TextBox4);
			this.GroupBox5.Controls.Add(this.Label7);
			this.GroupBox5.Controls.Add(this.TextBox3);
			this.GroupBox5.Controls.Add(this.Label6);
			this.GroupBox5.Controls.Add(this.TextBox2);
			this.GroupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.GroupBox5.Location = new System.Drawing.Point(18, 19);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new System.Drawing.Size(179, 136);
			this.GroupBox5.TabIndex = 0;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "english";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(22, 105);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(34, 15);
			this.Label9.TabIndex = 7;
			this.Label9.Text = "Total";
			//
			//TextBox5
			//
			this.TextBox5.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox5.Location = new System.Drawing.Point(92, 102);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(70, 22);
			this.TextBox5.TabIndex = 6;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(6, 57);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(73, 15);
			this.Label8.TabIndex = 5;
			this.Label8.Text = "composition";
			//
			//TextBox4
			//
			this.TextBox4.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox4.Location = new System.Drawing.Point(92, 76);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(70, 22);
			this.TextBox4.TabIndex = 4;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(22, 83);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(47, 15);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "reading";
			//
			//TextBox3
			//
			this.TextBox3.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox3.Location = new System.Drawing.Point(92, 50);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(70, 22);
			this.TextBox3.TabIndex = 2;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(22, 19);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(52, 15);
			this.Label6.TabIndex = 1;
			this.Label6.Text = "grammer";
			//
			//TextBox2
			//
			this.TextBox2.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox2.Location = new System.Drawing.Point(92, 16);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(70, 22);
			this.TextBox2.TabIndex = 0;
			//
			//TextBox20
			//
			this.TextBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox20.Location = new System.Drawing.Point(465, 22);
			this.TextBox20.Name = "TextBox20";
			this.TextBox20.Size = new System.Drawing.Size(538, 29);
			this.TextBox20.TabIndex = 6;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(1063, 17);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(101, 28);
			this.Button5.TabIndex = 7;
			this.Button5.Text = "VIEW SUMMARY";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Button7
			//
			this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button7.Location = new System.Drawing.Point(260, 286);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(91, 27);
			this.Button7.TabIndex = 8;
			this.Button7.Text = "RESET";
			this.Button7.UseVisualStyleBackColor = true;
			//
			//Form2
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1206, 634);
			this.ControlBox = false;
			this.Controls.Add(this.Button7);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.TextBox20);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "....";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.GroupBox9.ResumeLayout(false);
			this.GroupBox9.PerformLayout();
			this.GroupBox8.ResumeLayout(false);
			this.GroupBox8.PerformLayout();
			this.GroupBox7.ResumeLayout(false);
			this.GroupBox7.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
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
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox2;
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
		internal System.Windows.Forms.RadioButton RadioButton3;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.ComboBox ComboBox3;
		internal System.Windows.Forms.ComboBox ComboBox4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Button withEventsField_Button3;
		internal System.Windows.Forms.Button Button3 {
			get { return withEventsField_Button3; }
			set {
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click -= Button3_Click;
				}
				withEventsField_Button3 = value;
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click += Button3_Click;
				}
			}
		}
		internal System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.GroupBox withEventsField_GroupBox3;
		internal System.Windows.Forms.GroupBox GroupBox3 {
			get { return withEventsField_GroupBox3; }
			set {
				if (withEventsField_GroupBox3 != null) {
					withEventsField_GroupBox3.Enter -= GroupBox3_Enter;
				}
				withEventsField_GroupBox3 = value;
				if (withEventsField_GroupBox3 != null) {
					withEventsField_GroupBox3.Enter += GroupBox3_Enter;
				}
			}
		}
		private System.Windows.Forms.GroupBox withEventsField_GroupBox4;
		internal System.Windows.Forms.GroupBox GroupBox4 {
			get { return withEventsField_GroupBox4; }
			set {
				if (withEventsField_GroupBox4 != null) {
					withEventsField_GroupBox4.Enter -= GroupBox4_Enter;
				}
				withEventsField_GroupBox4 = value;
				if (withEventsField_GroupBox4 != null) {
					withEventsField_GroupBox4.Enter += GroupBox4_Enter;
				}
			}
		}
		private System.Windows.Forms.GroupBox withEventsField_GroupBox6;
		internal System.Windows.Forms.GroupBox GroupBox6 {
			get { return withEventsField_GroupBox6; }
			set {
				if (withEventsField_GroupBox6 != null) {
					withEventsField_GroupBox6.Enter -= GroupBox6_Enter;
				}
				withEventsField_GroupBox6 = value;
				if (withEventsField_GroupBox6 != null) {
					withEventsField_GroupBox6.Enter += GroupBox6_Enter;
				}
			}
		}
		private System.Windows.Forms.Label withEventsField_Label10;
		internal System.Windows.Forms.Label Label10 {
			get { return withEventsField_Label10; }
			set {
				if (withEventsField_Label10 != null) {
					withEventsField_Label10.Click -= Label10_Click;
				}
				withEventsField_Label10 = value;
				if (withEventsField_Label10 != null) {
					withEventsField_Label10.Click += Label10_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox6;
		internal System.Windows.Forms.TextBox TextBox6 {
			get { return withEventsField_TextBox6; }
			set {
				if (withEventsField_TextBox6 != null) {
					withEventsField_TextBox6.TextChanged -= TextBox6_TextChanged;
				}
				withEventsField_TextBox6 = value;
				if (withEventsField_TextBox6 != null) {
					withEventsField_TextBox6.TextChanged += TextBox6_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label withEventsField_Label11;
		internal System.Windows.Forms.Label Label11 {
			get { return withEventsField_Label11; }
			set {
				if (withEventsField_Label11 != null) {
					withEventsField_Label11.Click -= Label11_Click;
				}
				withEventsField_Label11 = value;
				if (withEventsField_Label11 != null) {
					withEventsField_Label11.Click += Label11_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox7;
		internal System.Windows.Forms.TextBox TextBox7 {
			get { return withEventsField_TextBox7; }
			set {
				if (withEventsField_TextBox7 != null) {
					withEventsField_TextBox7.TextChanged -= TextBox7_TextChanged;
				}
				withEventsField_TextBox7 = value;
				if (withEventsField_TextBox7 != null) {
					withEventsField_TextBox7.TextChanged += TextBox7_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label withEventsField_Label12;
		internal System.Windows.Forms.Label Label12 {
			get { return withEventsField_Label12; }
			set {
				if (withEventsField_Label12 != null) {
					withEventsField_Label12.Click -= Label12_Click;
				}
				withEventsField_Label12 = value;
				if (withEventsField_Label12 != null) {
					withEventsField_Label12.Click += Label12_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox8;
		internal System.Windows.Forms.TextBox TextBox8 {
			get { return withEventsField_TextBox8; }
			set {
				if (withEventsField_TextBox8 != null) {
					withEventsField_TextBox8.TextChanged -= TextBox8_TextChanged;
				}
				withEventsField_TextBox8 = value;
				if (withEventsField_TextBox8 != null) {
					withEventsField_TextBox8.TextChanged += TextBox8_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label withEventsField_Label13;
		internal System.Windows.Forms.Label Label13 {
			get { return withEventsField_Label13; }
			set {
				if (withEventsField_Label13 != null) {
					withEventsField_Label13.Click -= Label13_Click;
				}
				withEventsField_Label13 = value;
				if (withEventsField_Label13 != null) {
					withEventsField_Label13.Click += Label13_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox9;
		internal System.Windows.Forms.TextBox TextBox9 {
			get { return withEventsField_TextBox9; }
			set {
				if (withEventsField_TextBox9 != null) {
					withEventsField_TextBox9.TextChanged -= TextBox9_TextChanged;
				}
				withEventsField_TextBox9 = value;
				if (withEventsField_TextBox9 != null) {
					withEventsField_TextBox9.TextChanged += TextBox9_TextChanged;
				}
			}
		}
		private System.Windows.Forms.GroupBox withEventsField_GroupBox5;
		internal System.Windows.Forms.GroupBox GroupBox5 {
			get { return withEventsField_GroupBox5; }
			set {
				if (withEventsField_GroupBox5 != null) {
					withEventsField_GroupBox5.Enter -= GroupBox5_Enter;
				}
				withEventsField_GroupBox5 = value;
				if (withEventsField_GroupBox5 != null) {
					withEventsField_GroupBox5.Enter += GroupBox5_Enter;
				}
			}
		}
		private System.Windows.Forms.Label withEventsField_Label9;
		internal System.Windows.Forms.Label Label9 {
			get { return withEventsField_Label9; }
			set {
				if (withEventsField_Label9 != null) {
					withEventsField_Label9.Click -= Label9_Click;
				}
				withEventsField_Label9 = value;
				if (withEventsField_Label9 != null) {
					withEventsField_Label9.Click += Label9_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox5;
		internal System.Windows.Forms.TextBox TextBox5 {
			get { return withEventsField_TextBox5; }
			set {
				if (withEventsField_TextBox5 != null) {
					withEventsField_TextBox5.TextChanged -= TextBox5_TextChanged;
				}
				withEventsField_TextBox5 = value;
				if (withEventsField_TextBox5 != null) {
					withEventsField_TextBox5.TextChanged += TextBox5_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Label withEventsField_Label8;
		internal System.Windows.Forms.Label Label8 {
			get { return withEventsField_Label8; }
			set {
				if (withEventsField_Label8 != null) {
					withEventsField_Label8.Click -= Label8_Click;
				}
				withEventsField_Label8 = value;
				if (withEventsField_Label8 != null) {
					withEventsField_Label8.Click += Label8_Click;
				}
			}
		}
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
		private System.Windows.Forms.Label withEventsField_Label7;
		internal System.Windows.Forms.Label Label7 {
			get { return withEventsField_Label7; }
			set {
				if (withEventsField_Label7 != null) {
					withEventsField_Label7.Click -= Label7_Click;
				}
				withEventsField_Label7 = value;
				if (withEventsField_Label7 != null) {
					withEventsField_Label7.Click += Label7_Click;
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
		private System.Windows.Forms.Label withEventsField_Label6;
		internal System.Windows.Forms.Label Label6 {
			get { return withEventsField_Label6; }
			set {
				if (withEventsField_Label6 != null) {
					withEventsField_Label6.Click -= Label6_Click;
				}
				withEventsField_Label6 = value;
				if (withEventsField_Label6 != null) {
					withEventsField_Label6.Click += Label6_Click;
				}
			}
		}
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
		internal System.Windows.Forms.GroupBox GroupBox9;
		internal System.Windows.Forms.TextBox TextBox19;
		internal System.Windows.Forms.Label Label23;
		private System.Windows.Forms.TextBox withEventsField_TextBox18;
		internal System.Windows.Forms.TextBox TextBox18 {
			get { return withEventsField_TextBox18; }
			set {
				if (withEventsField_TextBox18 != null) {
					withEventsField_TextBox18.TextChanged -= TextBox18_TextChanged;
				}
				withEventsField_TextBox18 = value;
				if (withEventsField_TextBox18 != null) {
					withEventsField_TextBox18.TextChanged += TextBox18_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.GroupBox GroupBox8;
		internal System.Windows.Forms.TextBox TextBox14;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.TextBox TextBox15;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.TextBox TextBox16;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox TextBox17;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.GroupBox GroupBox7;
		private System.Windows.Forms.TextBox withEventsField_TextBox13;
		internal System.Windows.Forms.TextBox TextBox13 {
			get { return withEventsField_TextBox13; }
			set {
				if (withEventsField_TextBox13 != null) {
					withEventsField_TextBox13.TextChanged -= TextBox13_TextChanged;
				}
				withEventsField_TextBox13 = value;
				if (withEventsField_TextBox13 != null) {
					withEventsField_TextBox13.TextChanged += TextBox13_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label17;
		private System.Windows.Forms.TextBox withEventsField_TextBox12;
		internal System.Windows.Forms.TextBox TextBox12 {
			get { return withEventsField_TextBox12; }
			set {
				if (withEventsField_TextBox12 != null) {
					withEventsField_TextBox12.TextChanged -= TextBox12_TextChanged;
				}
				withEventsField_TextBox12 = value;
				if (withEventsField_TextBox12 != null) {
					withEventsField_TextBox12.TextChanged += TextBox12_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label16;
		private System.Windows.Forms.TextBox withEventsField_TextBox11;
		internal System.Windows.Forms.TextBox TextBox11 {
			get { return withEventsField_TextBox11; }
			set {
				if (withEventsField_TextBox11 != null) {
					withEventsField_TextBox11.TextChanged -= TextBox11_TextChanged;
				}
				withEventsField_TextBox11 = value;
				if (withEventsField_TextBox11 != null) {
					withEventsField_TextBox11.TextChanged += TextBox11_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label15;
		private System.Windows.Forms.TextBox withEventsField_TextBox10;
		internal System.Windows.Forms.TextBox TextBox10 {
			get { return withEventsField_TextBox10; }
			set {
				if (withEventsField_TextBox10 != null) {
					withEventsField_TextBox10.TextChanged -= TextBox10_TextChanged;
				}
				withEventsField_TextBox10 = value;
				if (withEventsField_TextBox10 != null) {
					withEventsField_TextBox10.TextChanged += TextBox10_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox TextBox20;
		internal System.Windows.Forms.TextBox TextBox21;
		private System.Windows.Forms.Button withEventsField_Button5;
		internal System.Windows.Forms.Button Button5 {
			get { return withEventsField_Button5; }
			set {
				if (withEventsField_Button5 != null) {
					withEventsField_Button5.Click -= Button5_Click_2;
				}
				withEventsField_Button5 = value;
				if (withEventsField_Button5 != null) {
					withEventsField_Button5.Click += Button5_Click_2;
				}
			}
		}
		internal System.Windows.Forms.DataGridView DataGridView1;
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
		private System.Windows.Forms.Button withEventsField_Button7;
		internal System.Windows.Forms.Button Button7 {
			get { return withEventsField_Button7; }
			set {
				if (withEventsField_Button7 != null) {
					withEventsField_Button7.Click -= Button7_Click;
				}
				withEventsField_Button7 = value;
				if (withEventsField_Button7 != null) {
					withEventsField_Button7.Click += Button7_Click;
				}
			}
		}
	}
}
