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
	partial class teachers_attendance : System.Windows.Forms.Form
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
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Button5 = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Button4 = new System.Windows.Forms.Button();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Button3 = new System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel1.Controls.Add(this.DataGridView1);
			this.Panel1.Location = new System.Drawing.Point(-4, 43);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(873, 489);
			this.Panel1.TabIndex = 0;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new System.Drawing.Point(0, 0);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(873, 489);
			this.DataGridView1.TabIndex = 0;
			//
			//Panel2
			//
			this.Panel2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Button5);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.Button4);
			this.Panel2.Controls.Add(this.DateTimePicker1);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.Button2);
			this.Panel2.Controls.Add(this.Button1);
			this.Panel2.Location = new System.Drawing.Point(-3, 4);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(873, 36);
			this.Panel2.TabIndex = 1;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(201, 6);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(75, 23);
			this.Button5.TabIndex = 6;
			this.Button5.Text = "Previous";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(440, 4);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(215, 23);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "llll";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(298, 6);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(75, 23);
			this.Button4.TabIndex = 4;
			this.Button4.Text = "Next";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(69, 6);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(106, 20);
			this.DateTimePicker1.TabIndex = 3;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(14, 12);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(49, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Set Date";
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(782, 3);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Deselect all";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(682, 6);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "select all";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Panel3
			//
			this.Panel3.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.Button3);
			this.Panel3.Location = new System.Drawing.Point(-4, 534);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(875, 29);
			this.Panel3.TabIndex = 2;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(762, 1);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(108, 23);
			this.Button3.TabIndex = 0;
			this.Button3.Text = "Record Register";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//teachers_attendance
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 566);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Name = "teachers_attendance";
			this.Text = "teachers_attendance";
			this.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.Panel Panel2;
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
		private System.Windows.Forms.DateTimePicker withEventsField_DateTimePicker1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1 {
			get { return withEventsField_DateTimePicker1; }
			set {
				if (withEventsField_DateTimePicker1 != null) {
					withEventsField_DateTimePicker1.ValueChanged -= DateTimePicker1_ValueChanged;
				}
				withEventsField_DateTimePicker1 = value;
				if (withEventsField_DateTimePicker1 != null) {
					withEventsField_DateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label1;
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
		internal System.Windows.Forms.Panel Panel3;
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
		internal System.Windows.Forms.Label Label2;
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
		public teachers_attendance()
		{
			Load += teachers_attendance_Load;
			InitializeComponent();
		}
	}
}
