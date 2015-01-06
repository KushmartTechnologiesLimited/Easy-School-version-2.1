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
	partial class report_form : System.Windows.Forms.Form
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
			this.Button1 = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.ComboBox3 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.Label7 = new System.Windows.Forms.Label();
			this.Button3 = new System.Windows.Forms.Button();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.Button4 = new System.Windows.Forms.Button();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(546, 382);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "PRINT";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.GroupBox3);
			this.GroupBox1.Controls.Add(this.GroupBox2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Location = new System.Drawing.Point(21, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(600, 355);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Print details";
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
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.DateTimePicker2);
			this.GroupBox3.Controls.Add(this.DateTimePicker1);
			this.GroupBox3.Location = new System.Drawing.Point(6, 193);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(247, 138);
			this.GroupBox3.TabIndex = 8;
			this.GroupBox3.TabStop = false;
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
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.ComboBox3);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.ComboBox2);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.ComboBox1);
			this.GroupBox2.Controls.Add(this.Label1);
			this.GroupBox2.Location = new System.Drawing.Point(6, 19);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(247, 157);
			this.GroupBox2.TabIndex = 7;
			this.GroupBox2.TabStop = false;
			//
			//ComboBox3
			//
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new System.Drawing.Point(90, 105);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new System.Drawing.Size(121, 21);
			this.ComboBox3.TabIndex = 12;
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
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(90, 70);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(121, 21);
			this.ComboBox2.TabIndex = 10;
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
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(90, 30);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(121, 21);
			this.ComboBox1.TabIndex = 8;
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
			//TextBox1
			//
			this.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.TextBox1.Location = new System.Drawing.Point(274, 51);
			this.TextBox1.MaxLength = 720;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(308, 280);
			this.TextBox1.TabIndex = 1;
			//
			//ProgressBar1
			//
			this.ProgressBar1.ForeColor = System.Drawing.Color.Lime;
			this.ProgressBar1.Location = new System.Drawing.Point(26, 382);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(514, 23);
			this.ProgressBar1.TabIndex = 3;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(211, 408);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(0, 13);
			this.Label7.TabIndex = 4;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(862, 62);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(59, 23);
			this.Button3.TabIndex = 5;
			this.Button3.Text = "backup";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(645, 21);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(127, 23);
			this.Button4.TabIndex = 6;
			this.Button4.Text = "browse location";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(627, 64);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(219, 20);
			this.TextBox2.TabIndex = 7;
			this.TextBox2.Text = "  ";
			//
			//report_form
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(933, 437);
			this.ControlBox = false;
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Button1);
			this.MaximizeBox = false;
			this.Name = "report_form";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.GroupBox withEventsField_GroupBox1;
		internal System.Windows.Forms.GroupBox GroupBox1 {
			get { return withEventsField_GroupBox1; }
			set {
				if (withEventsField_GroupBox1 != null) {
					withEventsField_GroupBox1.Enter -= GroupBox1_Enter;
				}
				withEventsField_GroupBox1 = value;
				if (withEventsField_GroupBox1 != null) {
					withEventsField_GroupBox1.Enter += GroupBox1_Enter;
				}
			}
		}
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.ComboBox ComboBox3;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.Label Label2;
		private System.Windows.Forms.ComboBox withEventsField_ComboBox1;
		internal System.Windows.Forms.ComboBox ComboBox1 {
			get { return withEventsField_ComboBox1; }
			set {
				if (withEventsField_ComboBox1 != null) {
					withEventsField_ComboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
				}
				withEventsField_ComboBox1 = value;
				if (withEventsField_ComboBox1 != null) {
					withEventsField_ComboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label1;
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
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		internal System.Windows.Forms.Label Label7;
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
		internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
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
		internal System.Windows.Forms.TextBox TextBox2;
	}
}
