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
	partial class billing : System.Windows.Forms.Form
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
			this.Label10 = new System.Windows.Forms.Label();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.DataGridView3 = new System.Windows.Forms.DataGridView();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Label3 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView3).BeginInit();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).BeginInit();
			this.Panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label10.Location = new System.Drawing.Point(6, 325);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(63, 21);
			this.Label10.TabIndex = 126;
			this.Label10.Text = "Term 1";
			//
			//TextBox8
			//
			this.TextBox8.BackColor = System.Drawing.Color.LightGray;
			this.TextBox8.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox8.Location = new System.Drawing.Point(83, 323);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.ReadOnly = true;
			this.TextBox8.Size = new System.Drawing.Size(170, 29);
			this.TextBox8.TabIndex = 127;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(289, 323);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(63, 21);
			this.Label1.TabIndex = 128;
			this.Label1.Text = "Term 2";
			//
			//TextBox1
			//
			this.TextBox1.BackColor = System.Drawing.Color.LightGray;
			this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox1.Location = new System.Drawing.Point(358, 322);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.Size = new System.Drawing.Size(170, 29);
			this.TextBox1.TabIndex = 129;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(551, 325);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(63, 21);
			this.Label2.TabIndex = 130;
			this.Label2.Text = "Term 3";
			//
			//TextBox2
			//
			this.TextBox2.BackColor = System.Drawing.Color.LightGray;
			this.TextBox2.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox2.Location = new System.Drawing.Point(628, 322);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.ReadOnly = true;
			this.TextBox2.Size = new System.Drawing.Size(170, 29);
			this.TextBox2.TabIndex = 131;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(284, 7);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 134;
			this.Button1.Text = "Find";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(3, 9);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(51, 21);
			this.Label4.TabIndex = 135;
			this.Label4.Text = "Class";
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(92, 9);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(177, 21);
			this.ComboBox1.TabIndex = 136;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(471, 366);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(144, 21);
			this.Label5.TabIndex = 137;
			this.Label5.Text = "Total Annual Fees";
			//
			//TextBox4
			//
			this.TextBox4.BackColor = System.Drawing.Color.LightGray;
			this.TextBox4.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox4.Location = new System.Drawing.Point(627, 363);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.ReadOnly = true;
			this.TextBox4.Size = new System.Drawing.Size(170, 29);
			this.TextBox4.TabIndex = 138;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(354, 410);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(244, 21);
			this.Label6.TabIndex = 139;
			this.Label6.Text = "Payable By New Students Only";
			//
			//TextBox5
			//
			this.TextBox5.BackColor = System.Drawing.Color.LightGray;
			this.TextBox5.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox5.Location = new System.Drawing.Point(624, 407);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.ReadOnly = true;
			this.TextBox5.Size = new System.Drawing.Size(170, 29);
			this.TextBox5.TabIndex = 140;
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.Panel3);
			this.Panel1.Controls.Add(this.Panel2);
			this.Panel1.Controls.Add(this.Panel4);
			this.Panel1.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Panel1.Location = new System.Drawing.Point(7, 33);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(801, 285);
			this.Panel1.TabIndex = 141;
			//
			//Panel3
			//
			this.Panel3.Controls.Add(this.DataGridView3);
			this.Panel3.Location = new System.Drawing.Point(545, 7);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(254, 271);
			this.Panel3.TabIndex = 128;
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
			this.DataGridView3.Size = new System.Drawing.Size(254, 271);
			this.DataGridView3.TabIndex = 122;
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.DataGridView2);
			this.Panel2.Location = new System.Drawing.Point(277, 7);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(254, 271);
			this.Panel2.TabIndex = 127;
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
			this.DataGridView2.Size = new System.Drawing.Size(254, 271);
			this.DataGridView2.TabIndex = 122;
			//
			//Panel4
			//
			this.Panel4.Controls.Add(this.DataGridView1);
			this.Panel4.Location = new System.Drawing.Point(2, 7);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(254, 271);
			this.Panel4.TabIndex = 126;
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
			this.DataGridView1.Size = new System.Drawing.Size(254, 271);
			this.DataGridView1.TabIndex = 122;
			//
			//Label3
			//
			this.Label3.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(378, 7);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(373, 21);
			this.Label3.TabIndex = 142;
			this.Label3.Text = "Fees Strucure for ";
			//
			//billing
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 459);
			this.ControlBox = false;
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.TextBox5);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.TextBox4);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.TextBox8);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "billing";
			this.Panel1.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView3).EndInit();
			this.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).EndInit();
			this.Panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBox1;
		private System.Windows.Forms.Label withEventsField_Label2;
		internal System.Windows.Forms.Label Label2 {
			get { return withEventsField_Label2; }
			set {
				if (withEventsField_Label2 != null) {
					withEventsField_Label2.Click -= Label2_Click;
				}
				withEventsField_Label2 = value;
				if (withEventsField_Label2 != null) {
					withEventsField_Label2.Click += Label2_Click;
				}
			}
		}
		internal System.Windows.Forms.TextBox TextBox2;
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
		internal System.Windows.Forms.Label Label4;
		private System.Windows.Forms.ComboBox withEventsField_ComboBox1;
		internal System.Windows.Forms.ComboBox ComboBox1 {
			get { return withEventsField_ComboBox1; }
			set {
				if (withEventsField_ComboBox1 != null) {
					withEventsField_ComboBox1.KeyDown -= ComboBox1_KeyDown;
					withEventsField_ComboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
				}
				withEventsField_ComboBox1 = value;
				if (withEventsField_ComboBox1 != null) {
					withEventsField_ComboBox1.KeyDown += ComboBox1_KeyDown;
					withEventsField_ComboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.DataGridView DataGridView3;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.DataGridView DataGridView2;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.Label Label3;
	}
}
