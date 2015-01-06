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
	partial class Form5 : System.Windows.Forms.Form
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
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.ComboBox3 = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.ComboBox4 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(12, 43);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new System.Drawing.Size(1200, 530);
			this.DataGridView1.TabIndex = 0;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(866, 12);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(100, 25);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Export to excel";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Enabled = false;
			this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox1.Location = new System.Drawing.Point(520, 10);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(319, 24);
			this.TextBox1.TabIndex = 2;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(443, 11);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(47, 25);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "FIND";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//ComboBox1
			//
			this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(44, 6);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(61, 28);
			this.ComboBox1.TabIndex = 4;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(9, 10);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(38, 17);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Year";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(111, 13);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(41, 17);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Term";
			//
			//ComboBox2
			//
			this.ComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(158, 9);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(43, 28);
			this.ComboBox2.TabIndex = 6;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(304, 15);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(42, 17);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "Class";
			//
			//ComboBox3
			//
			this.ComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new System.Drawing.Point(365, 10);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new System.Drawing.Size(43, 28);
			this.ComboBox3.TabIndex = 8;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(207, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(42, 17);
			this.Label4.TabIndex = 11;
			this.Label4.Text = "Exam";
			//
			//ComboBox4
			//
			this.ComboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.ComboBox4.FormattingEnabled = true;
			this.ComboBox4.Location = new System.Drawing.Point(255, 8);
			this.ComboBox4.Name = "ComboBox4";
			this.ComboBox4.Size = new System.Drawing.Size(43, 28);
			this.ComboBox4.TabIndex = 10;
			//
			//Form5
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1224, 642);
			this.ControlBox = false;
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.ComboBox4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.ComboBox3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.ComboBox2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.DataGridView1);
			this.Name = "Form5";
			this.Text = "Form5";
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
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
		internal System.Windows.Forms.TextBox TextBox1;
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
		internal System.Windows.Forms.Label Label2;
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
		internal System.Windows.Forms.Label Label3;
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
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ComboBox ComboBox4;
	}
}
