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
	partial class teacher_view : System.Windows.Forms.Form
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
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Button7 = new System.Windows.Forms.Button();
			this.Button6 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(0, 0);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(852, 395);
			this.DataGridView1.TabIndex = 1;
			//
			//Panel1
			//
			this.Panel1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel1.Controls.Add(this.DataGridView1);
			this.Panel1.Location = new System.Drawing.Point(12, 64);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(852, 395);
			this.Panel1.TabIndex = 2;
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.TextBox2);
			this.Panel2.Controls.Add(this.Button7);
			this.Panel2.Controls.Add(this.Button6);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.Button3);
			this.Panel2.Controls.Add(this.Button4);
			this.Panel2.Location = new System.Drawing.Point(12, 1);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(852, 57);
			this.Panel2.TabIndex = 3;
			//
			//Button7
			//
			this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button7.Location = new System.Drawing.Point(758, 5);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(81, 37);
			this.Button7.TabIndex = 5;
			this.Button7.Text = "Exit Esc";
			this.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button7.UseVisualStyleBackColor = true;
			//
			//Button6
			//
			this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button6.Location = new System.Drawing.Point(660, 5);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(92, 37);
			this.Button6.TabIndex = 4;
			this.Button6.Text = "&Refresh F5";
			this.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button6.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(18, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(185, 25);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Name /National ID";
			//
			//Button3
			//
			this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button3.Location = new System.Drawing.Point(495, 6);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 36);
			this.Button3.TabIndex = 1;
			this.Button3.Text = "&Modify F3";
			this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button4.Location = new System.Drawing.Point(576, 5);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(78, 37);
			this.Button4.TabIndex = 2;
			this.Button4.Text = "&Delete F4";
			this.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button4.UseVisualStyleBackColor = true;
			//
			//TextBox2
			//
			this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox2.Location = new System.Drawing.Point(248, 13);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(216, 26);
			this.TextBox2.TabIndex = 2;
			//
			//teacher_view
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 471);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "teacher_view";
			this.Text = "teacher_view";
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Panel withEventsField_Panel2;
		internal System.Windows.Forms.Panel Panel2 {
			get { return withEventsField_Panel2; }
			set {
				if (withEventsField_Panel2 != null) {
					withEventsField_Panel2.Paint -= Panel2_Paint;
				}
				withEventsField_Panel2 = value;
				if (withEventsField_Panel2 != null) {
					withEventsField_Panel2.Paint += Panel2_Paint;
				}
			}
		}
		internal System.Windows.Forms.Label Label1;
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
		private System.Windows.Forms.Button withEventsField_Button3;
		internal System.Windows.Forms.Button Button3 {
			get { return withEventsField_Button3; }
			set {
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click -= Button3_Click_1;
				}
				withEventsField_Button3 = value;
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click += Button3_Click_1;
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
	}
}
