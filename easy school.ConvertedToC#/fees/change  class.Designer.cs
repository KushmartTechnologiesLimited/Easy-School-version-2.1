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
	partial class bill : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bill));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Button5 = new System.Windows.Forms.Button();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.GroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.ComboBox2);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(12, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(461, 79);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "School Scope";
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(385, 33);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(65, 23);
			this.Button2.TabIndex = 5;
			this.Button2.Text = "Set";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(258, 33);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(121, 21);
			this.ComboBox2.TabIndex = 3;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(64, 33);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(121, 21);
			this.ComboBox1.TabIndex = 2;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(197, 36);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Last Class";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(4, 36);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(54, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "First Class";
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Panel2);
			this.Panel1.Controls.Add(this.Button5);
			this.Panel1.Controls.Add(this.RadioButton2);
			this.Panel1.Controls.Add(this.RadioButton1);
			this.Panel1.Enabled = false;
			this.Panel1.Location = new System.Drawing.Point(12, 97);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(461, 286);
			this.Panel1.TabIndex = 1;
			//
			//Panel2
			//
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Button1);
			this.Panel2.Controls.Add(this.Button4);
			this.Panel2.Controls.Add(this.Button3);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.TextBox4);
			this.Panel2.Controls.Add(this.Panel3);
			this.Panel2.Location = new System.Drawing.Point(20, 42);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(420, 212);
			this.Panel2.TabIndex = 3;
			//
			//Button1
			//
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Location = new System.Drawing.Point(241, 170);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(126, 27);
			this.Button1.TabIndex = 10;
			this.Button1.Text = "Proceed";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button4.Location = new System.Drawing.Point(88, 170);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(126, 27);
			this.Button4.TabIndex = 9;
			this.Button4.Text = "Repeat";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button3.Location = new System.Drawing.Point(301, 17);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 4;
			this.Button3.Text = "&Search";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(39, 21);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(73, 13);
			this.Label6.TabIndex = 8;
			this.Label6.Text = "Enter Adm No";
			//
			//TextBox4
			//
			this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox4.Location = new System.Drawing.Point(134, 14);
			this.TextBox4.MaxLength = 8;
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(147, 26);
			this.TextBox4.TabIndex = 7;
			//
			//Panel3
			//
			this.Panel3.Controls.Add(this.TextBox3);
			this.Panel3.Controls.Add(this.TextBox2);
			this.Panel3.Controls.Add(this.TextBox1);
			this.Panel3.Controls.Add(this.Label5);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Controls.Add(this.Label3);
			this.Panel3.Enabled = false;
			this.Panel3.Location = new System.Drawing.Point(10, 45);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(379, 119);
			this.Panel3.TabIndex = 6;
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(78, 87);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(279, 20);
			this.TextBox3.TabIndex = 5;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(78, 49);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(279, 20);
			this.TextBox2.TabIndex = 4;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(78, 11);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(279, 20);
			this.TextBox1.TabIndex = 3;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(27, 56);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(45, 13);
			this.Label5.TabIndex = 2;
			this.Label5.Text = "Adm No";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(3, 90);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(69, 13);
			this.Label4.TabIndex = 1;
			this.Label4.Text = "Current Class";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(37, 18);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(35, 13);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "Name";
			//
			//Button5
			//
			this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button5.Location = new System.Drawing.Point(155, 59);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(126, 27);
			this.Button5.TabIndex = 10;
			this.Button5.Text = "Change All Students";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//RadioButton2
			//
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new System.Drawing.Point(224, 19);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(81, 17);
			this.RadioButton2.TabIndex = 5;
			this.RadioButton2.Text = "All Students";
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//RadioButton1
			//
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Checked = true;
			this.RadioButton1.Location = new System.Drawing.Point(42, 19);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(85, 17);
			this.RadioButton1.TabIndex = 4;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "One Student";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//bill
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 397);
			this.ControlBox = false;
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "bill";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
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
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel2;
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
		internal System.Windows.Forms.Label Label6;
		private System.Windows.Forms.TextBox withEventsField_TextBox4;
		internal System.Windows.Forms.TextBox TextBox4 {
			get { return withEventsField_TextBox4; }
			set {
				if (withEventsField_TextBox4 != null) {
					withEventsField_TextBox4.KeyPress -= TextBox4_KeyPress;
				}
				withEventsField_TextBox4 = value;
				if (withEventsField_TextBox4 != null) {
					withEventsField_TextBox4.KeyPress += TextBox4_KeyPress;
				}
			}
		}
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.RadioButton RadioButton2;
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
		public bill()
		{
			Load += bill_Load;
			InitializeComponent();
		}
	}
}
