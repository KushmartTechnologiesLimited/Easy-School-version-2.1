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
	partial class fees_rates : System.Windows.Forms.Form
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
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.Button6 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.SuspendLayout();
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
			this.DataGridView1.Size = new System.Drawing.Size(442, 188);
			this.DataGridView1.TabIndex = 120;
			//
			//Panel1
			//
			this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Location = new System.Drawing.Point(1, 200);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(441, 26);
			this.Panel1.TabIndex = 115;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(87, 5);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(43, 13);
			this.Label3.TabIndex = 1;
			this.Label3.Text = "Total = ";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(9, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(52, 20);
			this.Label4.TabIndex = 0;
			this.Label4.Text = " View";
			//
			//Button3
			//
			this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button3.Location = new System.Drawing.Point(120, 9);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(63, 27);
			this.Button3.TabIndex = 1;
			this.Button3.Text = "&Modify F3";
			this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button2.Location = new System.Drawing.Point(13, 9);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(53, 27);
			this.Button2.TabIndex = 0;
			this.Button2.Text = "&Add  F2";
			this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button2.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(124, 91);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(279, 20);
			this.TextBox1.TabIndex = 110;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(20, 98);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(53, 16);
			this.Label5.TabIndex = 109;
			this.Label5.Text = "Amount";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(20, 59);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(68, 16);
			this.Label1.TabIndex = 107;
			this.Label1.Text = "Fees type";
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(124, 51);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(279, 21);
			this.ComboBox2.TabIndex = 106;
			//
			//Button6
			//
			this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button6.Location = new System.Drawing.Point(325, 7);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(74, 31);
			this.Button6.TabIndex = 4;
			this.Button6.Text = "&Refresh F5";
			this.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button6.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button4.Location = new System.Drawing.Point(224, 9);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(57, 27);
			this.Button4.TabIndex = 2;
			this.Button4.Text = "&Delete F4";
			this.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button4.UseVisualStyleBackColor = true;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(124, 16);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(211, 21);
			this.ComboBox1.TabIndex = 105;
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.DataGridView1);
			this.Panel2.Location = new System.Drawing.Point(1, 232);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(442, 188);
			this.Panel2.TabIndex = 117;
			//
			//Panel3
			//
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.CheckBox1);
			this.Panel3.Controls.Add(this.TextBox1);
			this.Panel3.Controls.Add(this.Label5);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Controls.Add(this.ComboBox2);
			this.Panel3.Controls.Add(this.ComboBox1);
			this.Panel3.Controls.Add(this.Panel4);
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Location = new System.Drawing.Point(2, 4);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(440, 190);
			this.Panel3.TabIndex = 114;
			//
			//CheckBox1
			//
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.CheckBox1.Location = new System.Drawing.Point(341, 20);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(92, 20);
			this.CheckBox1.TabIndex = 112;
			this.CheckBox1.Text = "All classes";
			this.CheckBox1.UseVisualStyleBackColor = true;
			//
			//Panel4
			//
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.Button6);
			this.Panel4.Controls.Add(this.Button4);
			this.Panel4.Controls.Add(this.Button3);
			this.Panel4.Controls.Add(this.Button2);
			this.Panel4.Location = new System.Drawing.Point(3, 134);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(427, 43);
			this.Panel4.TabIndex = 103;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(20, 17);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(42, 16);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Class";
			//
			//fees_rates
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 423);
			this.ControlBox = false;
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel3);
			this.Name = "fees_rates";
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.Panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label4;
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
		private System.Windows.Forms.TextBox withEventsField_TextBox1;
		internal System.Windows.Forms.TextBox TextBox1 {
			get { return withEventsField_TextBox1; }
			set {
				if (withEventsField_TextBox1 != null) {
					withEventsField_TextBox1.KeyDown -= TextBox1_KeyDown;
					withEventsField_TextBox1.KeyPress -= TextBox1_KeyPress;
					withEventsField_TextBox1.TextChanged -= TextBox1_TextChanged;
				}
				withEventsField_TextBox1 = value;
				if (withEventsField_TextBox1 != null) {
					withEventsField_TextBox1.KeyDown += TextBox1_KeyDown;
					withEventsField_TextBox1.KeyPress += TextBox1_KeyPress;
					withEventsField_TextBox1.TextChanged += TextBox1_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label1;
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
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		private System.Windows.Forms.CheckBox withEventsField_CheckBox1;
		internal System.Windows.Forms.CheckBox CheckBox1 {
			get { return withEventsField_CheckBox1; }
			set {
				if (withEventsField_CheckBox1 != null) {
					withEventsField_CheckBox1.CheckedChanged -= CheckBox1_CheckedChanged;
				}
				withEventsField_CheckBox1 = value;
				if (withEventsField_CheckBox1 != null) {
					withEventsField_CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;
				}
			}
		}
	}
}
