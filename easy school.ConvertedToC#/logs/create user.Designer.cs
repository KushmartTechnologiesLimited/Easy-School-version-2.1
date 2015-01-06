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
	partial class create_user : System.Windows.Forms.Form
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
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(415, 125);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "encode";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(520, 125);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "decode";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(406, 90);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(208, 20);
			this.TextBox1.TabIndex = 2;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(403, 74);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(52, 13);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "password";
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.Button4);
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.TextBox5);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.TextBox4);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.TextBox3);
			this.Panel1.Location = new System.Drawing.Point(2, 2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(290, 321);
			this.Panel1.TabIndex = 4;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(201, 267);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(75, 23);
			this.Button4.TabIndex = 149;
			this.Button4.Text = "&Cancel";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(64, 267);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 148;
			this.Button3.Text = "&Sign Up";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(51, 22);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(173, 16);
			this.Label2.TabIndex = 147;
			this.Label2.Text = "CREATE USER ACCOUNT";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(36, 176);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(116, 16);
			this.Label5.TabIndex = 146;
			this.Label5.Text = "Confirm Password";
			//
			//TextBox5
			//
			this.TextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox5.Location = new System.Drawing.Point(54, 195);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.PasswordChar = Strings.ChrW(42);
			this.TextBox5.Size = new System.Drawing.Size(222, 29);
			this.TextBox5.TabIndex = 145;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(29, 114);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(68, 16);
			this.Label4.TabIndex = 144;
			this.Label4.Text = "Password";
			//
			//TextBox4
			//
			this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox4.Location = new System.Drawing.Point(54, 133);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.PasswordChar = Strings.ChrW(42);
			this.TextBox4.Size = new System.Drawing.Size(222, 29);
			this.TextBox4.TabIndex = 143;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(29, 56);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(77, 16);
			this.Label3.TabIndex = 142;
			this.Label3.Text = "User Name";
			//
			//TextBox3
			//
			this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox3.Location = new System.Drawing.Point(54, 75);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(222, 29);
			this.TextBox3.TabIndex = 141;
			//
			//create_user
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 324);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "create_user";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Panel Panel1;
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.Label Label3;
		private System.Windows.Forms.TextBox withEventsField_TextBox3;
		internal System.Windows.Forms.TextBox TextBox3 {
			get { return withEventsField_TextBox3; }
			set {
				if (withEventsField_TextBox3 != null) {
					withEventsField_TextBox3.TextChanged -= TextBox3_TextChanged;
				}
				withEventsField_TextBox3 = value;
				if (withEventsField_TextBox3 != null) {
					withEventsField_TextBox3.TextChanged += TextBox3_TextChanged;
				}
			}
		}
	}
}
