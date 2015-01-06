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
	partial class classes : System.Windows.Forms.Form
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
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Button6 = new System.Windows.Forms.Button();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.Button2 = new System.Windows.Forms.Button();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.DataGridView3 = new System.Windows.Forms.DataGridView();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button5 = new System.Windows.Forms.Button();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).BeginInit();
			this.TabPage2.SuspendLayout();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.TabPage3.SuspendLayout();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView3).BeginInit();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Location = new System.Drawing.Point(0, 5);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(401, 395);
			this.TabControl1.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.Button3);
			this.TabPage1.Controls.Add(this.Button6);
			this.TabPage1.Controls.Add(this.TextBox3);
			this.TabPage1.Controls.Add(this.TextBox4);
			this.TabPage1.Controls.Add(this.Label3);
			this.TabPage1.Controls.Add(this.Label4);
			this.TabPage1.Controls.Add(this.Panel2);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(393, 369);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Classes";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//Button6
			//
			this.Button6.Location = new System.Drawing.Point(312, 8);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(75, 23);
			this.Button6.TabIndex = 13;
			this.Button6.Text = "Add";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(93, 8);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(202, 20);
			this.TextBox3.TabIndex = 12;
			//
			//TextBox4
			//
			this.TextBox4.Location = new System.Drawing.Point(93, 41);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(202, 20);
			this.TextBox4.TabIndex = 11;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(21, 44);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(60, 13);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "Description";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(48, 8);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(33, 13);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Level";
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.DataGridView2);
			this.Panel2.Location = new System.Drawing.Point(5, 85);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(383, 247);
			this.Panel2.TabIndex = 8;
			//
			//DataGridView2
			//
			this.DataGridView2.AllowUserToAddRows = false;
			this.DataGridView2.AllowUserToDeleteRows = false;
			this.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridView2.Location = new System.Drawing.Point(0, 0);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.ReadOnly = true;
			this.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView2.Size = new System.Drawing.Size(383, 247);
			this.DataGridView2.TabIndex = 114;
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.Button4);
			this.TabPage2.Controls.Add(this.Button1);
			this.TabPage2.Controls.Add(this.TextBox2);
			this.TabPage2.Controls.Add(this.TextBox1);
			this.TabPage2.Controls.Add(this.Label2);
			this.TabPage2.Controls.Add(this.Label1);
			this.TabPage2.Controls.Add(this.Panel1);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(393, 369);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Streams";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(315, 43);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 5;
			this.Button1.Text = "Add";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(109, 43);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(202, 20);
			this.TextBox2.TabIndex = 4;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(109, 7);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.Size = new System.Drawing.Size(202, 20);
			this.TextBox1.TabIndex = 3;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(20, 46);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(35, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Name";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(47, 14);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(32, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Code";
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.DataGridView1);
			this.Panel1.Location = new System.Drawing.Point(4, 72);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(383, 260);
			this.Panel1.TabIndex = 0;
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
			this.DataGridView1.Size = new System.Drawing.Size(383, 260);
			this.DataGridView1.TabIndex = 114;
			//
			//TabPage3
			//
			this.TabPage3.Controls.Add(this.Button5);
			this.TabPage3.Controls.Add(this.Button2);
			this.TabPage3.Controls.Add(this.TextBox5);
			this.TabPage3.Controls.Add(this.TextBox6);
			this.TabPage3.Controls.Add(this.Label5);
			this.TabPage3.Controls.Add(this.Label6);
			this.TabPage3.Controls.Add(this.Panel3);
			this.TabPage3.Location = new System.Drawing.Point(4, 22);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage3.Size = new System.Drawing.Size(393, 369);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "Subject";
			this.TabPage3.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(312, 36);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 19;
			this.Button2.Text = "Add";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//TextBox5
			//
			this.TextBox5.Location = new System.Drawing.Point(93, 6);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.Size = new System.Drawing.Size(202, 20);
			this.TextBox5.TabIndex = 18;
			//
			//TextBox6
			//
			this.TextBox6.Location = new System.Drawing.Point(93, 39);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new System.Drawing.Size(202, 20);
			this.TextBox6.TabIndex = 17;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(21, 42);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(57, 13);
			this.Label5.TabIndex = 16;
			this.Label5.Text = "Unit Name";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(27, 9);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(54, 13);
			this.Label6.TabIndex = 15;
			this.Label6.Text = "Unit Code";
			//
			//Panel3
			//
			this.Panel3.Controls.Add(this.DataGridView3);
			this.Panel3.Location = new System.Drawing.Point(5, 83);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(383, 249);
			this.Panel3.TabIndex = 14;
			//
			//DataGridView3
			//
			this.DataGridView3.AllowUserToAddRows = false;
			this.DataGridView3.AllowUserToDeleteRows = false;
			this.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridView3.Location = new System.Drawing.Point(0, 0);
			this.DataGridView3.Name = "DataGridView3";
			this.DataGridView3.ReadOnly = true;
			this.DataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView3.Size = new System.Drawing.Size(383, 249);
			this.DataGridView3.TabIndex = 114;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(312, 338);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 14;
			this.Button3.Text = "&Delete";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(312, 338);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(75, 23);
			this.Button4.TabIndex = 15;
			this.Button4.Text = "&Delete";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(313, 338);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(75, 23);
			this.Button5.TabIndex = 20;
			this.Button5.Text = "&Delete";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//classes
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 400);
			this.Controls.Add(this.TabControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "classes";
			this.Text = "Classes and Streams";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).EndInit();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.Panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView3).EndInit();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
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
		private System.Windows.Forms.TextBox withEventsField_TextBox3;
		internal System.Windows.Forms.TextBox TextBox3 {
			get { return withEventsField_TextBox3; }
			set {
				if (withEventsField_TextBox3 != null) {
					withEventsField_TextBox3.KeyPress -= TextBox3_KeyPress;
				}
				withEventsField_TextBox3 = value;
				if (withEventsField_TextBox3 != null) {
					withEventsField_TextBox3.KeyPress += TextBox3_KeyPress;
				}
			}
		}
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
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.DataGridView DataGridView2;
		internal System.Windows.Forms.TabPage TabPage2;
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
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.TabPage TabPage3;
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
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.DataGridView DataGridView3;
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
	}
}
