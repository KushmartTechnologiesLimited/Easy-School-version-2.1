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
	partial class type : System.Windows.Forms.Form
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
			this.Label3 = new System.Windows.Forms.Label();
			this.Button6 = new System.Windows.Forms.Button();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Panel4.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(3, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(52, 20);
			this.Label3.TabIndex = 0;
			this.Label3.Text = " View";
			//
			//Button6
			//
			this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button6.Location = new System.Drawing.Point(280, 7);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(83, 28);
			this.Button6.TabIndex = 4;
			this.Button6.Text = "&Refresh F5";
			this.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button6.UseVisualStyleBackColor = true;
			//
			//TextBox2
			//
			this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox2.Location = new System.Drawing.Point(110, 52);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(238, 20);
			this.TextBox2.TabIndex = 18;
			//
			//TextBox1
			//
			this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.Location = new System.Drawing.Point(110, 15);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.Size = new System.Drawing.Size(238, 20);
			this.TextBox1.TabIndex = 16;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(32, 19);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(28, 16);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Id  :";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(21, 52);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(79, 16);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Fees Name";
			//
			//Button4
			//
			this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button4.Location = new System.Drawing.Point(183, 7);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(78, 28);
			this.Button4.TabIndex = 2;
			this.Button4.Text = "&Delete F4";
			this.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button3.Location = new System.Drawing.Point(87, 7);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(81, 28);
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
			this.Button2.Location = new System.Drawing.Point(12, 7);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(62, 28);
			this.Button2.TabIndex = 0;
			this.Button2.Text = "&Add  F2";
			this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Panel4
			//
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.Button6);
			this.Panel4.Controls.Add(this.Button4);
			this.Panel4.Controls.Add(this.Button3);
			this.Panel4.Controls.Add(this.Button2);
			this.Panel4.Location = new System.Drawing.Point(6, 109);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(379, 40);
			this.Panel4.TabIndex = 103;
			//
			//Panel1
			//
			this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Location = new System.Drawing.Point(1, 163);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(390, 27);
			this.Panel1.TabIndex = 113;
			//
			//Panel3
			//
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.ComboBox1);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Controls.Add(this.Panel4);
			this.Panel3.Controls.Add(this.TextBox2);
			this.Panel3.Controls.Add(this.TextBox1);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Location = new System.Drawing.Point(1, 4);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(390, 154);
			this.Panel3.TabIndex = 114;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {
				"registration",
				"Yearly",
				"Termly"
			});
			this.ComboBox1.Location = new System.Drawing.Point(110, 82);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(238, 21);
			this.ComboBox1.TabIndex = 105;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(3, 82);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(97, 16);
			this.Label4.TabIndex = 104;
			this.Label4.Text = "Fees Category";
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.DataGridView1);
			this.Panel2.Location = new System.Drawing.Point(1, 196);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(390, 165);
			this.Panel2.TabIndex = 116;
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
			this.DataGridView1.Size = new System.Drawing.Size(390, 165);
			this.DataGridView1.TabIndex = 120;
			//
			//type
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 366);
			this.ControlBox = false;
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "type";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Panel4.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Label Label3;
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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label1;
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
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.DataGridView DataGridView1;
		private System.Windows.Forms.ComboBox withEventsField_ComboBox1;
		internal System.Windows.Forms.ComboBox ComboBox1 {
			get { return withEventsField_ComboBox1; }
			set {
				if (withEventsField_ComboBox1 != null) {
					withEventsField_ComboBox1.KeyDown -= ComboBox1_KeyDown;
					withEventsField_ComboBox1.KeyPress -= ComboBox1_KeyPress;
					withEventsField_ComboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
				}
				withEventsField_ComboBox1 = value;
				if (withEventsField_ComboBox1 != null) {
					withEventsField_ComboBox1.KeyDown += ComboBox1_KeyDown;
					withEventsField_ComboBox1.KeyPress += ComboBox1_KeyPress;
					withEventsField_ComboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label4;
		public type()
		{
			Load += type_Load;
			InitializeComponent();
		}
	}
}
