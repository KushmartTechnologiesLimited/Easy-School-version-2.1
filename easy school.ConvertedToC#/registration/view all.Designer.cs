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
	partial class view_all : System.Windows.Forms.Form
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
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button6 = new System.Windows.Forms.Button();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Panel1.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel1.Controls.Add(this.Panel3);
			this.Panel1.Controls.Add(this.ComboBox2);
			this.Panel1.Controls.Add(this.ComboBox1);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.TextBox1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location = new System.Drawing.Point(1, 26);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1104, 75);
			this.Panel1.TabIndex = 0;
			//
			//Panel3
			//
			this.Panel3.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3.Controls.Add(this.Button1);
			this.Panel3.Controls.Add(this.Button4);
			this.Panel3.Controls.Add(this.Button3);
			this.Panel3.Controls.Add(this.Button6);
			this.Panel3.Location = new System.Drawing.Point(622, 13);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(470, 48);
			this.Panel3.TabIndex = 118;
			//
			//Button1
			//
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button1.Location = new System.Drawing.Point(3, 1);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(79, 38);
			this.Button1.TabIndex = 12;
			this.Button1.Text = "&Add New  ";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button4.Location = new System.Drawing.Point(169, 0);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(78, 37);
			this.Button4.TabIndex = 9;
			this.Button4.Text = "&Refresh";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button3.Location = new System.Drawing.Point(88, 1);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 36);
			this.Button3.TabIndex = 8;
			this.Button3.Text = "&Modify";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button6
			//
			this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button6.Location = new System.Drawing.Point(253, 1);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(103, 37);
			this.Button6.TabIndex = 10;
			this.Button6.Text = "&Fees Records";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//ComboBox2
			//
			this.ComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(468, 43);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(150, 28);
			this.ComboBox2.TabIndex = 16;
			//
			//ComboBox1
			//
			this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(468, 5);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(148, 28);
			this.ComboBox1.TabIndex = 15;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(405, 46);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(58, 20);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "stream";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(405, 13);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(48, 20);
			this.Label2.TabIndex = 13;
			this.Label2.Text = "Class";
			//
			//TextBox1
			//
			this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox1.Location = new System.Drawing.Point(173, 10);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(201, 31);
			this.TextBox1.TabIndex = 7;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(3, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(164, 25);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "Name /ADM NO";
			//
			//Panel2
			//
			this.Panel2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel2.Controls.Add(this.DataGridView1);
			this.Panel2.Location = new System.Drawing.Point(1, 107);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1104, 301);
			this.Panel2.TabIndex = 1;
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
			this.DataGridView1.Size = new System.Drawing.Size(1104, 301);
			this.DataGridView1.TabIndex = 117;
			//
			//view_all
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1105, 417);
			this.ControlBox = false;
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "view_all";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
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
		private System.Windows.Forms.DataGridView withEventsField_DataGridView1;
		internal System.Windows.Forms.DataGridView DataGridView1 {
			get { return withEventsField_DataGridView1; }
			set {
				if (withEventsField_DataGridView1 != null) {
					withEventsField_DataGridView1.CellContentClick -= DataGridView1_CellContentClick;
				}
				withEventsField_DataGridView1 = value;
				if (withEventsField_DataGridView1 != null) {
					withEventsField_DataGridView1.CellContentClick += DataGridView1_CellContentClick;
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
		private System.Windows.Forms.TextBox withEventsField_TextBox1;
		internal System.Windows.Forms.TextBox TextBox1 {
			get { return withEventsField_TextBox1; }
			set {
				if (withEventsField_TextBox1 != null) {
					withEventsField_TextBox1.KeyUp -= TextBox1_KeyUp;
					withEventsField_TextBox1.LostFocus -= TextBox1_LostFocus;
					withEventsField_TextBox1.TextChanged -= TextBox1_TextChanged;
				}
				withEventsField_TextBox1 = value;
				if (withEventsField_TextBox1 != null) {
					withEventsField_TextBox1.KeyUp += TextBox1_KeyUp;
					withEventsField_TextBox1.LostFocus += TextBox1_LostFocus;
					withEventsField_TextBox1.TextChanged += TextBox1_TextChanged;
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
		internal System.Windows.Forms.Label Label1;
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
		internal System.Windows.Forms.Panel Panel3;
	}
}
