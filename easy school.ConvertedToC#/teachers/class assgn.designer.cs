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
	partial class class_assgn : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(class_assgn));
			this.Label3 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Panel5 = new System.Windows.Forms.Panel();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.ComboBox3 = new System.Windows.Forms.ComboBox();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.Button6 = new System.Windows.Forms.Button();
			this.Panel6 = new System.Windows.Forms.Panel();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button7 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel4.SuspendLayout();
			this.Panel6.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(29, 14);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(52, 20);
			this.Label3.TabIndex = 0;
			this.Label3.Text = " View";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.BackColor = System.Drawing.Color.Transparent;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(70, 18);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(222, 20);
			this.Label7.TabIndex = 0;
			this.Label7.Text = "Teacher Class Assignment";
			//
			//Panel5
			//
			this.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel5.Controls.Add(this.Label7);
			this.Panel5.Location = new System.Drawing.Point(3, 1);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new System.Drawing.Size(717, 61);
			this.Panel5.TabIndex = 115;
			//
			//PictureBox1
			//
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(412, 3);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(140, 130);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 110;
			this.PictureBox1.TabStop = false;
			//
			//ComboBox3
			//
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new System.Drawing.Point(134, 95);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new System.Drawing.Size(142, 21);
			this.ComboBox3.TabIndex = 107;
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(134, 58);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(142, 21);
			this.ComboBox2.TabIndex = 106;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(23, 96);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(54, 16);
			this.Label4.TabIndex = 105;
			this.Label4.Text = "Stream:";
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(134, 25);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(142, 21);
			this.ComboBox1.TabIndex = 104;
			//
			//Panel4
			//
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.Button6);
			this.Panel4.Controls.Add(this.Panel6);
			this.Panel4.Controls.Add(this.Button7);
			this.Panel4.Controls.Add(this.Button2);
			this.Panel4.Location = new System.Drawing.Point(23, 145);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(689, 64);
			this.Panel4.TabIndex = 103;
			//
			//Button6
			//
			this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button6.Location = new System.Drawing.Point(456, 8);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(117, 50);
			this.Button6.TabIndex = 8;
			this.Button6.Text = "&Refresh F5";
			this.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button6.UseVisualStyleBackColor = true;
			//
			//Panel6
			//
			this.Panel6.Controls.Add(this.Button5);
			this.Panel6.Controls.Add(this.Button4);
			this.Panel6.Location = new System.Drawing.Point(112, 3);
			this.Panel6.Name = "Panel6";
			this.Panel6.Size = new System.Drawing.Size(304, 56);
			this.Panel6.TabIndex = 6;
			//
			//Button5
			//
			this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button5.Location = new System.Drawing.Point(147, 8);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(107, 46);
			this.Button5.TabIndex = 7;
			this.Button5.Text = "&View F6";
			this.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button4.Location = new System.Drawing.Point(16, 8);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(100, 46);
			this.Button4.TabIndex = 6;
			this.Button4.Text = "&Delete F4";
			this.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button7
			//
			this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button7.Location = new System.Drawing.Point(577, 7);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(94, 50);
			this.Button7.TabIndex = 5;
			this.Button7.Text = "Exit Esc";
			this.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button7.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button2.Location = new System.Drawing.Point(10, 11);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(96, 46);
			this.Button2.TabIndex = 0;
			this.Button2.Text = "&Add  F2";
			this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Panel1
			//
			this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Panel1.Location = new System.Drawing.Point(3, 315);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(717, 38);
			this.Panel1.TabIndex = 113;
			//
			//Panel3
			//
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.PictureBox1);
			this.Panel3.Controls.Add(this.Label5);
			this.Panel3.Controls.Add(this.ComboBox3);
			this.Panel3.Controls.Add(this.ComboBox2);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Controls.Add(this.ComboBox1);
			this.Panel3.Controls.Add(this.Panel4);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Location = new System.Drawing.Point(3, 68);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(717, 232);
			this.Panel3.TabIndex = 114;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(598, 11);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(39, 13);
			this.Label5.TabIndex = 108;
			this.Label5.Text = "Label5";
			this.Label5.Visible = false;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(23, 25);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(105, 16);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Teacher Name :";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(23, 58);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(51, 16);
			this.Label2.TabIndex = 1;
			this.Label2.Text = " Class :";
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
			this.DataGridView1.Size = new System.Drawing.Size(717, 166);
			this.DataGridView1.TabIndex = 112;
			//
			//Panel2
			//
			this.Panel2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel2.Controls.Add(this.DataGridView1);
			this.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Panel2.Location = new System.Drawing.Point(3, 359);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(717, 166);
			this.Panel2.TabIndex = 116;
			//
			//class_assgn
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 537);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel5);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "class_assgn";
			this.Panel5.ResumeLayout(false);
			this.Panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel4.ResumeLayout(false);
			this.Panel6.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label7;
		private System.Windows.Forms.Panel withEventsField_Panel5;
		internal System.Windows.Forms.Panel Panel5 {
			get { return withEventsField_Panel5; }
			set {
				if (withEventsField_Panel5 != null) {
					withEventsField_Panel5.Paint -= Panel5_Paint;
				}
				withEventsField_Panel5 = value;
				if (withEventsField_Panel5 != null) {
					withEventsField_Panel5.Paint += Panel5_Paint;
				}
			}
		}
		internal System.Windows.Forms.PictureBox PictureBox1;
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
		internal System.Windows.Forms.Label Label4;
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
		internal System.Windows.Forms.Panel Panel4;
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
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		private System.Windows.Forms.DataGridView withEventsField_DataGridView1;
		internal System.Windows.Forms.DataGridView DataGridView1 {
			get { return withEventsField_DataGridView1; }
			set {
				if (withEventsField_DataGridView1 != null) {
					withEventsField_DataGridView1.CellContentClick -= DataGridView1_CellContentClick;
					withEventsField_DataGridView1.SelectionChanged -= DataGridView1_SelectionChanged;
				}
				withEventsField_DataGridView1 = value;
				if (withEventsField_DataGridView1 != null) {
					withEventsField_DataGridView1.CellContentClick += DataGridView1_CellContentClick;
					withEventsField_DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Panel Panel6;
		private System.Windows.Forms.Button withEventsField_Button6;
		internal System.Windows.Forms.Button Button6 {
			get { return withEventsField_Button6; }
			set {
				if (withEventsField_Button6 != null) {
					withEventsField_Button6.Click -= Button6_Click_1;
				}
				withEventsField_Button6 = value;
				if (withEventsField_Button6 != null) {
					withEventsField_Button6.Click += Button6_Click_1;
				}
			}
		}
		internal System.Windows.Forms.Button Button5;
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
	}
}
