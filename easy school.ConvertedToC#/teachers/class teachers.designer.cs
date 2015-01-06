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
	partial class class_teachers : System.Windows.Forms.Form
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
			this.ListBox1 = new System.Windows.Forms.ListBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.Button1 = new System.Windows.Forms.Button();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.Panel5 = new System.Windows.Forms.Panel();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).BeginInit();
			this.GroupBox2.SuspendLayout();
			this.Panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
			this.Panel1.Controls.Add(this.ListBox1);
			this.Panel1.Location = new System.Drawing.Point(0, 73);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(216, 303);
			this.Panel1.TabIndex = 0;
			//
			//ListBox1
			//
			this.ListBox1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.Location = new System.Drawing.Point(0, 2);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new System.Drawing.Size(213, 303);
			this.ListBox1.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(37, 6);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(156, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Name/Nationa  Id No";
			//
			//TextBox1
			//
			this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox1.Location = new System.Drawing.Point(5, 29);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(216, 26);
			this.TextBox1.TabIndex = 2;
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.Panel1);
			this.Panel2.Controls.Add(this.TextBox1);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Location = new System.Drawing.Point(13, 58);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(222, 379);
			this.Panel2.TabIndex = 3;
			//
			//Panel3
			//
			this.Panel3.Controls.Add(this.TextBox3);
			this.Panel3.Controls.Add(this.Label13);
			this.Panel3.Controls.Add(this.Label9);
			this.Panel3.Controls.Add(this.TextBox8);
			this.Panel3.Controls.Add(this.TextBox4);
			this.Panel3.Controls.Add(this.Label14);
			this.Panel3.Location = new System.Drawing.Point(15, 12);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(1081, 40);
			this.Panel3.TabIndex = 4;
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(913, 7);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.ReadOnly = true;
			this.TextBox3.Size = new System.Drawing.Size(158, 20);
			this.TextBox3.TabIndex = 145;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(8, 6);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(102, 16);
			this.Label13.TabIndex = 136;
			this.Label13.Text = "Teacher Name:";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(791, 9);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(116, 16);
			this.Label9.TabIndex = 144;
			this.Label9.Text = "University\\college";
			//
			//TextBox8
			//
			this.TextBox8.Location = new System.Drawing.Point(624, 7);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.ReadOnly = true;
			this.TextBox8.Size = new System.Drawing.Size(161, 20);
			this.TextBox8.TabIndex = 143;
			//
			//TextBox4
			//
			this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox4.Location = new System.Drawing.Point(116, 7);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.ReadOnly = true;
			this.TextBox4.Size = new System.Drawing.Size(385, 22);
			this.TextBox4.TabIndex = 140;
			//
			//Label14
			//
			this.Label14.AllowDrop = true;
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label14.Location = new System.Drawing.Point(507, 9);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(84, 16);
			this.Label14.TabIndex = 139;
			this.Label14.Text = " Qualification";
			//
			//Panel4
			//
			this.Panel4.Controls.Add(this.Button2);
			this.Panel4.Controls.Add(this.Button1);
			this.Panel4.Controls.Add(this.GroupBox3);
			this.Panel4.Controls.Add(this.GroupBox2);
			this.Panel4.Controls.Add(this.GroupBox1);
			this.Panel4.Location = new System.Drawing.Point(241, 58);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(855, 401);
			this.Panel4.TabIndex = 5;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(754, 372);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "Delete" + Strings.ChrW(13) + Strings.ChrW(10);
			this.Button1.UseVisualStyleBackColor = true;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.DataGridView2);
			this.GroupBox3.Location = new System.Drawing.Point(319, 77);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(533, 287);
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			//
			//DataGridView2
			//
			this.DataGridView2.AllowUserToAddRows = false;
			this.DataGridView2.AllowUserToDeleteRows = false;
			this.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridView2.Location = new System.Drawing.Point(3, 16);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.ReadOnly = true;
			this.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView2.Size = new System.Drawing.Size(527, 268);
			this.DataGridView2.TabIndex = 113;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.Panel5);
			this.GroupBox2.Location = new System.Drawing.Point(8, 77);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(199, 318);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "SUBJECT DETAILS";
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(213, 154);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(84, 23);
			this.Button2.TabIndex = 148;
			this.Button2.Text = "ASSIGN >>";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Panel5
			//
			this.Panel5.Controls.Add(this.DataGridView1);
			this.Panel5.Location = new System.Drawing.Point(9, 20);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new System.Drawing.Size(179, 267);
			this.Panel5.TabIndex = 0;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new System.Drawing.Point(0, 0);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(179, 267);
			this.DataGridView1.TabIndex = 113;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.ComboBox2);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Location = new System.Drawing.Point(8, 17);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(844, 54);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "CLASS TEACHER";
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(277, 14);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(121, 21);
			this.ComboBox2.TabIndex = 4;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(78, 19);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(121, 21);
			this.ComboBox1.TabIndex = 3;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(205, 22);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(52, 13);
			this.Label3.TabIndex = 1;
			this.Label3.Text = "STREAM";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(6, 27);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(41, 13);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "CLASS";
			//
			//class_teachers
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1108, 470);
			this.Controls.Add(this.Panel4);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "class_teachers";
			this.Text = "Subject Designation";
			this.Panel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.Panel4.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.Panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Panel Panel1;
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
		internal System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.ListBox withEventsField_ListBox1;
		internal System.Windows.Forms.ListBox ListBox1 {
			get { return withEventsField_ListBox1; }
			set {
				if (withEventsField_ListBox1 != null) {
					withEventsField_ListBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
				}
				withEventsField_ListBox1 = value;
				if (withEventsField_ListBox1 != null) {
					withEventsField_ListBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Panel Panel4;
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
		internal System.Windows.Forms.Panel Panel5;
		internal System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.ComboBox withEventsField_ComboBox2;
		internal System.Windows.Forms.ComboBox ComboBox2 {
			get { return withEventsField_ComboBox2; }
			set {
				if (withEventsField_ComboBox2 != null) {
					withEventsField_ComboBox2.SelectedIndexChanged -= ComboBox2_SelectedIndexChanged;
				}
				withEventsField_ComboBox2 = value;
				if (withEventsField_ComboBox2 != null) {
					withEventsField_ComboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
				}
			}
		}
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
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.DataGridView DataGridView2;
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
	}
}
