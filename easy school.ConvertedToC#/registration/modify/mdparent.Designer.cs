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
	partial class mdparent : System.Windows.Forms.Form
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
			this.TextBox13 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.TextBox21 = new System.Windows.Forms.TextBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.TextBox12 = new System.Windows.Forms.TextBox();
			this.TextBox11 = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TextBox9 = new System.Windows.Forms.TextBox();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.TextBox7 = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//TextBox13
			//
			this.TextBox13.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox13.Location = new System.Drawing.Point(127, 47);
			this.TextBox13.Name = "TextBox13";
			this.TextBox13.ReadOnly = true;
			this.TextBox13.Size = new System.Drawing.Size(281, 26);
			this.TextBox13.TabIndex = 52;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(343, 335);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(93, 26);
			this.Button1.TabIndex = 57;
			this.Button1.Text = "CANCEL";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(172, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(0, 23);
			this.Label1.TabIndex = 56;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label14.Location = new System.Drawing.Point(54, 51);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(50, 22);
			this.Label14.TabIndex = 65;
			this.Label14.Text = "ID NO";
			//
			//TextBox21
			//
			this.TextBox21.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox21.Location = new System.Drawing.Point(129, 157);
			this.TextBox21.Name = "TextBox21";
			this.TextBox21.Size = new System.Drawing.Size(281, 26);
			this.TextBox21.TabIndex = 54;
			//
			//Label23
			//
			this.Label23.AutoSize = true;
			this.Label23.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label23.Location = new System.Drawing.Point(54, 161);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(51, 22);
			this.Label23.TabIndex = 64;
			this.Label23.Text = "EMAIL";
			//
			//TextBox12
			//
			this.TextBox12.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox12.Location = new System.Drawing.Point(129, 270);
			this.TextBox12.Name = "TextBox12";
			this.TextBox12.Size = new System.Drawing.Size(279, 26);
			this.TextBox12.TabIndex = 57;
			//
			//TextBox11
			//
			this.TextBox11.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox11.Location = new System.Drawing.Point(128, 120);
			this.TextBox11.Name = "TextBox11";
			this.TextBox11.Size = new System.Drawing.Size(281, 26);
			this.TextBox11.TabIndex = 53;
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.TextBox13);
			this.Panel1.Controls.Add(this.Label14);
			this.Panel1.Controls.Add(this.TextBox21);
			this.Panel1.Controls.Add(this.Label23);
			this.Panel1.Controls.Add(this.TextBox12);
			this.Panel1.Controls.Add(this.TextBox11);
			this.Panel1.Controls.Add(this.TextBox9);
			this.Panel1.Controls.Add(this.TextBox8);
			this.Panel1.Controls.Add(this.TextBox7);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label12);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Location = new System.Drawing.Point(3, 5);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(442, 319);
			this.Panel1.TabIndex = 55;
			//
			//TextBox9
			//
			this.TextBox9.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox9.Location = new System.Drawing.Point(128, 232);
			this.TextBox9.Name = "TextBox9";
			this.TextBox9.Size = new System.Drawing.Size(281, 26);
			this.TextBox9.TabIndex = 56;
			//
			//TextBox8
			//
			this.TextBox8.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox8.Location = new System.Drawing.Point(129, 195);
			this.TextBox8.Name = "TextBox8";
			this.TextBox8.Size = new System.Drawing.Size(279, 26);
			this.TextBox8.TabIndex = 55;
			//
			//TextBox7
			//
			this.TextBox7.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox7.Location = new System.Drawing.Point(129, 83);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.Size = new System.Drawing.Size(281, 26);
			this.TextBox7.TabIndex = 50;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(26, 274);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(88, 22);
			this.Label13.TabIndex = 63;
			this.Label13.Text = "RESIDENCE";
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label12.Location = new System.Drawing.Point(20, 124);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(94, 22);
			this.Label12.TabIndex = 62;
			this.Label12.Text = "TELEPHONE";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label10.Location = new System.Drawing.Point(20, 236);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(85, 22);
			this.Label10.TabIndex = 60;
			this.Label10.Text = "EMPLOYER";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(20, 199);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(103, 22);
			this.Label9.TabIndex = 59;
			this.Label9.Text = "OCCUPATION";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Trebuchet MS", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(48, 83);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(57, 22);
			this.Label8.TabIndex = 58;
			this.Label8.Text = "NAMES";
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(231, 335);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(93, 26);
			this.Button2.TabIndex = 54;
			this.Button2.Text = "EDIT";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//mdparent
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 373);
			this.ControlBox = false;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Button2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "mdparent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.TextBox TextBox13;
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
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label14;
		private System.Windows.Forms.TextBox withEventsField_TextBox21;
		internal System.Windows.Forms.TextBox TextBox21 {
			get { return withEventsField_TextBox21; }
			set {
				if (withEventsField_TextBox21 != null) {
					withEventsField_TextBox21.TextChanged -= TextBox21_TextChanged;
					withEventsField_TextBox21.Validated -= TextBox21_Validated;
					withEventsField_TextBox21.Validating -= TextBox21_Validating;
				}
				withEventsField_TextBox21 = value;
				if (withEventsField_TextBox21 != null) {
					withEventsField_TextBox21.TextChanged += TextBox21_TextChanged;
					withEventsField_TextBox21.Validated += TextBox21_Validated;
					withEventsField_TextBox21.Validating += TextBox21_Validating;
				}
			}
		}
		internal System.Windows.Forms.Label Label23;
		private System.Windows.Forms.TextBox withEventsField_TextBox12;
		internal System.Windows.Forms.TextBox TextBox12 {
			get { return withEventsField_TextBox12; }
			set {
				if (withEventsField_TextBox12 != null) {
					withEventsField_TextBox12.TextChanged -= TextBox12_TextChanged;
				}
				withEventsField_TextBox12 = value;
				if (withEventsField_TextBox12 != null) {
					withEventsField_TextBox12.TextChanged += TextBox12_TextChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox11;
		internal System.Windows.Forms.TextBox TextBox11 {
			get { return withEventsField_TextBox11; }
			set {
				if (withEventsField_TextBox11 != null) {
					withEventsField_TextBox11.KeyPress -= TextBox11_KeyPress;
					withEventsField_TextBox11.TextChanged -= TextBox11_TextChanged;
				}
				withEventsField_TextBox11 = value;
				if (withEventsField_TextBox11 != null) {
					withEventsField_TextBox11.KeyPress += TextBox11_KeyPress;
					withEventsField_TextBox11.TextChanged += TextBox11_TextChanged;
				}
			}
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
		private System.Windows.Forms.TextBox withEventsField_TextBox9;
		internal System.Windows.Forms.TextBox TextBox9 {
			get { return withEventsField_TextBox9; }
			set {
				if (withEventsField_TextBox9 != null) {
					withEventsField_TextBox9.TextChanged -= TextBox9_TextChanged;
				}
				withEventsField_TextBox9 = value;
				if (withEventsField_TextBox9 != null) {
					withEventsField_TextBox9.TextChanged += TextBox9_TextChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox8;
		internal System.Windows.Forms.TextBox TextBox8 {
			get { return withEventsField_TextBox8; }
			set {
				if (withEventsField_TextBox8 != null) {
					withEventsField_TextBox8.TextChanged -= TextBox8_TextChanged;
				}
				withEventsField_TextBox8 = value;
				if (withEventsField_TextBox8 != null) {
					withEventsField_TextBox8.TextChanged += TextBox8_TextChanged;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_TextBox7;
		internal System.Windows.Forms.TextBox TextBox7 {
			get { return withEventsField_TextBox7; }
			set {
				if (withEventsField_TextBox7 != null) {
					withEventsField_TextBox7.TextChanged -= TextBox7_TextChanged;
				}
				withEventsField_TextBox7 = value;
				if (withEventsField_TextBox7 != null) {
					withEventsField_TextBox7.TextChanged += TextBox7_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label8;
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
	}
}
