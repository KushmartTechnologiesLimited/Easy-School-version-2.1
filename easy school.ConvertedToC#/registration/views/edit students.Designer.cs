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
	partial class edit_students : System.Windows.Forms.Form
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.ComboBox3 = new System.Windows.Forms.ComboBox();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label26 = new System.Windows.Forms.Label();
			this.Label25 = new System.Windows.Forms.Label();
			this.Button7 = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.ComboBox3);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.ComboBox2);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label26);
			this.GroupBox1.Controls.Add(this.Label25);
			this.GroupBox1.Controls.Add(this.Button7);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.TextBox4);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(1, -2);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(415, 316);
			this.GroupBox1.TabIndex = 5;
			this.GroupBox1.TabStop = false;
			//
			//ComboBox3
			//
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Items.AddRange(new object[] {
				"Female",
				"Male",
				"Others"
			});
			this.ComboBox3.Location = new System.Drawing.Point(102, 177);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new System.Drawing.Size(299, 21);
			this.ComboBox3.TabIndex = 60;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(102, 108);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(299, 20);
			this.DateTimePicker1.TabIndex = 59;
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(102, 244);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(299, 21);
			this.ComboBox2.TabIndex = 58;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(102, 208);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(299, 21);
			this.ComboBox1.TabIndex = 57;
			//
			//Label26
			//
			this.Label26.AutoSize = true;
			this.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label26.Location = new System.Drawing.Point(33, 250);
			this.Label26.Name = "Label26";
			this.Label26.Size = new System.Drawing.Size(54, 15);
			this.Label26.TabIndex = 56;
			this.Label26.Text = "STREAM";
			//
			//Label25
			//
			this.Label25.AutoSize = true;
			this.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label25.Location = new System.Drawing.Point(44, 214);
			this.Label25.Name = "Label25";
			this.Label25.Size = new System.Drawing.Size(43, 15);
			this.Label25.TabIndex = 55;
			this.Label25.Text = "CLASS";
			//
			//Button7
			//
			this.Button7.Location = new System.Drawing.Point(290, 280);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(100, 23);
			this.Button7.TabIndex = 9;
			this.Button7.Text = "&Save Changes";
			this.Button7.UseVisualStyleBackColor = true;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(41, 183);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(55, 15);
			this.Label5.TabIndex = 52;
			this.Label5.Text = "GENDER";
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(102, 148);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(299, 20);
			this.TextBox4.TabIndex = 9;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(4, 151);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(92, 13);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Birth certificate no";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(30, 110);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(66, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Date of Birth";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(102, 65);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(299, 20);
			this.TextBox2.TabIndex = 3;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(56, 68);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(40, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Names";
			//
			//TextBox1
			//
			this.TextBox1.Enabled = false;
			this.TextBox1.Location = new System.Drawing.Point(102, 29);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.Size = new System.Drawing.Size(299, 20);
			this.TextBox1.TabIndex = 1;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(47, 29);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(49, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Admn no";
			//
			//edit_students
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 315);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "edit_students";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);

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
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		private System.Windows.Forms.TextBox withEventsField_TextBox4;
		internal System.Windows.Forms.TextBox TextBox4 {
			get { return withEventsField_TextBox4; }
			set {
				if (withEventsField_TextBox4 != null) {
					withEventsField_TextBox4.KeyPress -= TextBox4_KeyPress;
					withEventsField_TextBox4.TextChanged -= TextBox4_TextChanged;
				}
				withEventsField_TextBox4 = value;
				if (withEventsField_TextBox4 != null) {
					withEventsField_TextBox4.KeyPress += TextBox4_KeyPress;
					withEventsField_TextBox4.TextChanged += TextBox4_TextChanged;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_ComboBox3;
		internal System.Windows.Forms.ComboBox ComboBox3 {
			get { return withEventsField_ComboBox3; }
			set {
				if (withEventsField_ComboBox3 != null) {
					withEventsField_ComboBox3.SelectedIndexChanged -= ComboBox3_SelectedIndexChanged;
				}
				withEventsField_ComboBox3 = value;
				if (withEventsField_ComboBox3 != null) {
					withEventsField_ComboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
				}
			}
		}
	}
}
