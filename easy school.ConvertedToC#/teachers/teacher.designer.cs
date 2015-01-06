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
	partial class teacher : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher));
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Button7 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.empdate = new System.Windows.Forms.DateTimePicker();
			this.Label15 = new System.Windows.Forms.Label();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.p_year = new System.Windows.Forms.DateTimePicker();
			this.Label9 = new System.Windows.Forms.Label();
			this.dob = new System.Windows.Forms.DateTimePicker();
			this.TextBox7 = new System.Windows.Forms.TextBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.MaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label23 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label22 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
			this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
			this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.Panel1.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Panel3);
			this.Panel1.Controls.Add(this.Panel4);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(834, 471);
			this.Panel1.TabIndex = 0;
			//
			//Panel3
			//
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.Button7);
			this.Panel3.Controls.Add(this.Button3);
			this.Panel3.Controls.Add(this.Button2);
			this.Panel3.Location = new System.Drawing.Point(3, 403);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(818, 50);
			this.Panel3.TabIndex = 107;
			//
			//Button7
			//
			this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button7.Location = new System.Drawing.Point(553, 9);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(94, 33);
			this.Button7.TabIndex = 5;
			this.Button7.Text = "Exit Esc";
			this.Button7.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Enabled = false;
			this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button3.Location = new System.Drawing.Point(391, 9);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(106, 33);
			this.Button3.TabIndex = 1;
			this.Button3.Text = "&Modify F3";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button2.Location = new System.Drawing.Point(217, 9);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(96, 33);
			this.Button2.TabIndex = 0;
			this.Button2.Text = "&Add  F2";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Panel4
			//
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.empdate);
			this.Panel4.Controls.Add(this.Label15);
			this.Panel4.Controls.Add(this.TextBox8);
			this.Panel4.Controls.Add(this.TextBox6);
			this.Panel4.Controls.Add(this.Label12);
			this.Panel4.Controls.Add(this.Label11);
			this.Panel4.Controls.Add(this.Label7);
			this.Panel4.Controls.Add(this.Label2);
			this.Panel4.Controls.Add(this.Label1);
			this.Panel4.Controls.Add(this.ComboBox2);
			this.Panel4.Controls.Add(this.LinkLabel1);
			this.Panel4.Controls.Add(this.TextBox3);
			this.Panel4.Controls.Add(this.p_year);
			this.Panel4.Controls.Add(this.Label9);
			this.Panel4.Controls.Add(this.dob);
			this.Panel4.Controls.Add(this.TextBox7);
			this.Panel4.Controls.Add(this.PictureBox1);
			this.Panel4.Controls.Add(this.Label5);
			this.Panel4.Controls.Add(this.TextBox5);
			this.Panel4.Controls.Add(this.TextBox4);
			this.Panel4.Controls.Add(this.MaskedTextBox1);
			this.Panel4.Controls.Add(this.ComboBox1);
			this.Panel4.Controls.Add(this.TextBox2);
			this.Panel4.Controls.Add(this.TextBox1);
			this.Panel4.Controls.Add(this.Label4);
			this.Panel4.Controls.Add(this.Label3);
			this.Panel4.Controls.Add(this.Label23);
			this.Panel4.Controls.Add(this.Label14);
			this.Panel4.Controls.Add(this.Label22);
			this.Panel4.Controls.Add(this.label10);
			this.Panel4.Controls.Add(this.Label13);
			this.Panel4.Controls.Add(this.Label19);
			this.Panel4.Controls.Add(this.Label6);
			this.Panel4.Controls.Add(this.Label8);
			this.Panel4.Location = new System.Drawing.Point(12, 3);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(809, 394);
			this.Panel4.TabIndex = 106;
			//
			//empdate
			//
			this.empdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.empdate.Location = new System.Drawing.Point(530, 350);
			this.empdate.Name = "empdate";
			this.empdate.Size = new System.Drawing.Size(173, 20);
			this.empdate.TabIndex = 146;
			this.empdate.Value = new System.DateTime(2014, 6, 20, 0, 0, 0, 0);
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label15.Location = new System.Drawing.Point(401, 354);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(118, 16);
			this.Label15.TabIndex = 145;
			this.Label15.Text = " Employment Date";
			//
			//TextBox8
			//
			this.TextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox8.Location = new System.Drawing.Point(524, 141);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.Size = new System.Drawing.Size(172, 22);
			this.TextBox8.TabIndex = 144;
			//
			//TextBox6
			//
			this.TextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox6.Location = new System.Drawing.Point(524, 83);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new System.Drawing.Size(172, 22);
			this.TextBox6.TabIndex = 143;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label12.Location = new System.Drawing.Point(522, 177);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(100, 25);
			this.Label12.TabIndex = 142;
			this.Label12.Text = "SCHOOL";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label11.Location = new System.Drawing.Point(525, 11);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(113, 25);
			this.Label11.TabIndex = 141;
			this.Label11.Text = "ADDRESS";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(85, 11);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(188, 25);
			this.Label7.TabIndex = 140;
			this.Label7.Text = "PERSONAL DATA";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(15, 264);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(52, 16);
			this.Label2.TabIndex = 139;
			this.Label2.Text = "Picture:";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(7, 82);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(74, 16);
			this.Label1.TabIndex = 138;
			this.Label1.Text = "National ID";
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Items.AddRange(new object[] {
				"none",
				"certificate",
				"diploma",
				"higher diploma",
				"bachelors degree",
				"master degree",
				"phD"
			});
			this.ComboBox2.Location = new System.Drawing.Point(527, 217);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(168, 21);
			this.ComboBox2.TabIndex = 137;
			//
			//LinkLabel1
			//
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Location = new System.Drawing.Point(15, 299);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new System.Drawing.Size(69, 13);
			this.LinkLabel1.TabIndex = 136;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "Insert Picture";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(529, 287);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(173, 20);
			this.TextBox3.TabIndex = 135;
			//
			//p_year
			//
			this.p_year.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.p_year.Location = new System.Drawing.Point(528, 249);
			this.p_year.Name = "p_year";
			this.p_year.Size = new System.Drawing.Size(173, 20);
			this.p_year.TabIndex = 134;
			this.p_year.Value = new System.DateTime(2014, 2, 20, 0, 0, 0, 0);
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(403, 288);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(116, 16);
			this.Label9.TabIndex = 133;
			this.Label9.Text = "University\\college";
			//
			//dob
			//
			this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dob.Location = new System.Drawing.Point(116, 113);
			this.dob.Name = "dob";
			this.dob.Size = new System.Drawing.Size(169, 20);
			this.dob.TabIndex = 128;
			this.dob.Value = new System.DateTime(2014, 2, 20, 0, 0, 0, 0);
			//
			//TextBox7
			//
			this.TextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox7.Location = new System.Drawing.Point(524, 115);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.Size = new System.Drawing.Size(172, 22);
			this.TextBox7.TabIndex = 127;
			//
			//PictureBox1
			//
			this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(122, 238);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(164, 132);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 81;
			this.PictureBox1.TabStop = false;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(403, 142);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(80, 16);
			this.Label5.TabIndex = 126;
			this.Label5.Text = "Postal code";
			//
			//TextBox5
			//
			this.TextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox5.Location = new System.Drawing.Point(522, 53);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(174, 22);
			this.TextBox5.TabIndex = 122;
			//
			//TextBox4
			//
			this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox4.Location = new System.Drawing.Point(116, 208);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(172, 22);
			this.TextBox4.TabIndex = 121;
			//
			//MaskedTextBox1
			//
			this.MaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.MaskedTextBox1.Location = new System.Drawing.Point(116, 176);
			this.MaskedTextBox1.Mask = "9900000000";
			this.MaskedTextBox1.Name = "MaskedTextBox1";
			this.MaskedTextBox1.Size = new System.Drawing.Size(172, 22);
			this.MaskedTextBox1.TabIndex = 120;
			//
			//ComboBox1
			//
			this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {
				"Male",
				"Female"
			});
			this.ComboBox1.Location = new System.Drawing.Point(115, 142);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(173, 24);
			this.ComboBox1.TabIndex = 118;
			//
			//TextBox2
			//
			this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox2.Location = new System.Drawing.Point(114, 82);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(173, 22);
			this.TextBox2.TabIndex = 116;
			//
			//TextBox1
			//
			this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox1.Location = new System.Drawing.Point(115, 50);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(172, 22);
			this.TextBox1.TabIndex = 115;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(397, 115);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(91, 16);
			this.Label4.TabIndex = 114;
			this.Label4.Text = "  State/Village";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(404, 85);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(30, 16);
			this.Label3.TabIndex = 113;
			this.Label3.Text = "City";
			//
			//Label23
			//
			this.Label23.AutoSize = true;
			this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label23.Location = new System.Drawing.Point(7, 144);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(56, 16);
			this.Label23.TabIndex = 111;
			this.Label23.Text = "Gender:";
			//
			//Label14
			//
			this.Label14.AllowDrop = true;
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label14.Location = new System.Drawing.Point(403, 224);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(84, 16);
			this.Label14.TabIndex = 110;
			this.Label14.Text = " Qualification";
			//
			//Label22
			//
			this.Label22.AutoSize = true;
			this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label22.Location = new System.Drawing.Point(403, 255);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(106, 16);
			this.Label22.TabIndex = 109;
			this.Label22.Text = " Year of Passing";
			//
			//label10
			//
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.label10.Location = new System.Drawing.Point(7, 114);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 16);
			this.label10.TabIndex = 101;
			this.label10.Text = "Date of Birth";
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(3, 50);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(102, 16);
			this.Label13.TabIndex = 102;
			this.Label13.Text = "Teacher Name:";
			//
			//Label19
			//
			this.Label19.AutoSize = true;
			this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label19.Location = new System.Drawing.Point(5, 208);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(49, 16);
			this.Label19.TabIndex = 107;
			this.Label19.Text = "E-Mail:";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(404, 53);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(66, 16);
			this.Label6.TabIndex = 106;
			this.Label6.Text = "P.O BOX :";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(7, 176);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(52, 16);
			this.Label8.TabIndex = 105;
			this.Label8.Text = "Mobile:";
			//
			//PrintDialog1
			//
			this.PrintDialog1.UseEXDialog = true;
			//
			//PrintPreviewDialog1
			//
			this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.PrintPreviewDialog1.Enabled = true;
			this.PrintPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("PrintPreviewDialog1.Icon");
			this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
			this.PrintPreviewDialog1.Visible = false;
			//
			//teacher
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 471);
			this.Controls.Add(this.Panel1);
			this.Name = "teacher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "teacher";
			this.Panel1.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel3;
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
		internal System.Windows.Forms.Panel Panel4;
		private System.Windows.Forms.LinkLabel withEventsField_LinkLabel1;
		internal System.Windows.Forms.LinkLabel LinkLabel1 {
			get { return withEventsField_LinkLabel1; }
			set {
				if (withEventsField_LinkLabel1 != null) {
					withEventsField_LinkLabel1.LinkClicked -= LinkLabel1_LinkClicked;
				}
				withEventsField_LinkLabel1 = value;
				if (withEventsField_LinkLabel1 != null) {
					withEventsField_LinkLabel1.LinkClicked += LinkLabel1_LinkClicked;
				}
			}
		}
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.DateTimePicker p_year;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.DateTimePicker dob;
		internal System.Windows.Forms.TextBox TextBox7;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.MaskedTextBox MaskedTextBox1;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label22;
		private System.Windows.Forms.Label label10;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.PageSetupDialog PageSetupDialog1;
		internal System.Windows.Forms.PrintDialog PrintDialog1;
		internal System.Drawing.Printing.PrintDocument PrintDocument1;
		internal System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.DateTimePicker empdate;
		internal System.Windows.Forms.Label Label15;
	}
}
