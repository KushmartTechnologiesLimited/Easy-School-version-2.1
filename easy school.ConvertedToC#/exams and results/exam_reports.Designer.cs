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
	partial class exam_reports : System.Windows.Forms.Form
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
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.Button3 = new System.Windows.Forms.Button();
			this.Label7 = new System.Windows.Forms.Label();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Button4 = new System.Windows.Forms.Button();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.ComboBox3 = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label8 = new System.Windows.Forms.Label();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.GroupBox3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(203, 434);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(319, 20);
			this.TextBox2.TabIndex = 14;
			this.TextBox2.Text = "  Libraries\\Documents";
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(560, 428);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(97, 30);
			this.Button3.TabIndex = 12;
			this.Button3.Text = "backup";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(209, 471);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(0, 13);
			this.Label7.TabIndex = 11;
			//
			//ProgressBar1
			//
			this.ProgressBar1.ForeColor = System.Drawing.Color.Lime;
			this.ProgressBar1.Location = new System.Drawing.Point(18, 428);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(536, 30);
			this.ProgressBar1.TabIndex = 10;
			//
			//TextBox1
			//
			this.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.TextBox1.Location = new System.Drawing.Point(288, 49);
			this.TextBox1.MaxLength = 720;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(308, 280);
			this.TextBox1.TabIndex = 1;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(37, 428);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(149, 30);
			this.Button4.TabIndex = 13;
			this.Button4.Text = "browse location";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(90, 105);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(121, 21);
			this.ComboBox1.TabIndex = 12;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(36, 108);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(41, 13);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "CLASS";
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker2.Location = new System.Drawing.Point(112, 80);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new System.Drawing.Size(99, 20);
			this.DateTimePicker2.TabIndex = 1;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(112, 30);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(99, 20);
			this.DateTimePicker1.TabIndex = 0;
			//
			//ComboBox3
			//
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new System.Drawing.Point(90, 70);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new System.Drawing.Size(121, 21);
			this.ComboBox3.TabIndex = 10;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(36, 73);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(38, 13);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "TERM";
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(90, 30);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(121, 21);
			this.ComboBox2.TabIndex = 8;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(36, 33);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(36, 13);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "YEAR";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(6, 80);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(96, 13);
			this.Label5.TabIndex = 3;
			this.Label5.Text = "OPENNING DATE";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(6, 30);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(93, 13);
			this.Label4.TabIndex = 2;
			this.Label4.Text = "CLOSSING DATE";
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.DateTimePicker2);
			this.GroupBox3.Controls.Add(this.DateTimePicker1);
			this.GroupBox3.Location = new System.Drawing.Point(6, 289);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(247, 115);
			this.GroupBox3.TabIndex = 8;
			this.GroupBox3.TabStop = false;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.GroupBox4);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.GroupBox3);
			this.GroupBox1.Controls.Add(this.GroupBox2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Location = new System.Drawing.Point(12, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(622, 410);
			this.GroupBox1.TabIndex = 9;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Print details";
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.RadioButton2);
			this.GroupBox4.Controls.Add(this.RadioButton1);
			this.GroupBox4.Controls.Add(this.Panel1);
			this.GroupBox4.Location = new System.Drawing.Point(6, 163);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(247, 120);
			this.GroupBox4.TabIndex = 15;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "print Options";
			//
			//RadioButton2
			//
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new System.Drawing.Point(155, 19);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(45, 17);
			this.RadioButton2.TabIndex = 20;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "One";
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//RadioButton1
			//
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			this.RadioButton1.Location = new System.Drawing.Point(37, 19);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(35, 17);
			this.RadioButton1.TabIndex = 19;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "all";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.Button2);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.TextBox3);
			this.Panel1.Location = new System.Drawing.Point(19, 42);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(204, 62);
			this.Panel1.TabIndex = 18;
			this.Panel1.Visible = false;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(145, 35);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(46, 23);
			this.Button2.TabIndex = 16;
			this.Button2.Text = "ok";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(3, 16);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(73, 13);
			this.Label8.TabIndex = 16;
			this.Label8.Text = "Enter Adm No";
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(91, 13);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(100, 20);
			this.TextBox3.TabIndex = 16;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(324, 28);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(186, 20);
			this.Label6.TabIndex = 9;
			this.Label6.Text = "GENERAL COMMENTS ";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.ComboBox1);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.ComboBox3);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.ComboBox2);
			this.GroupBox2.Controls.Add(this.Label1);
			this.GroupBox2.Location = new System.Drawing.Point(6, 19);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(247, 138);
			this.GroupBox2.TabIndex = 7;
			this.GroupBox2.TabStop = false;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(560, 428);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(97, 30);
			this.Button1.TabIndex = 8;
			this.Button1.Text = "PRINT";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//exam_reports
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 488);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.Button3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "exam_reports";
			this.ShowInTaskbar = false;
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
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
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		private System.Windows.Forms.TextBox withEventsField_TextBox1;
		internal System.Windows.Forms.TextBox TextBox1 {
			get { return withEventsField_TextBox1; }
			set {
				if (withEventsField_TextBox1 != null) {
					withEventsField_TextBox1.TextChanged -= TextBox1_TextChanged;
				}
				withEventsField_TextBox1 = value;
				if (withEventsField_TextBox1 != null) {
					withEventsField_TextBox1.TextChanged += TextBox1_TextChanged;
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
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.ComboBox ComboBox3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.GroupBox GroupBox2;
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
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Button withEventsField_Button2;
		internal System.Windows.Forms.Button Button2 {
			get { return withEventsField_Button2; }
			set {
				if (withEventsField_Button2 != null) {
					withEventsField_Button2.Click -= Button2_Click_1;
				}
				withEventsField_Button2 = value;
				if (withEventsField_Button2 != null) {
					withEventsField_Button2.Click += Button2_Click_1;
				}
			}
		}
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox TextBox3;
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
	}
}
