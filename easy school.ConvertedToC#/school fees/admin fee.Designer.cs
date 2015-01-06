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
	partial class admin_fee : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_fee));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.TextBox13 = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.TextBox6 = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.TextBox7 = new System.Windows.Forms.TextBox();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.TextBox5 = new System.Windows.Forms.TextBox();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button6 = new System.Windows.Forms.Button();
			this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
			this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
			this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.Panel1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(83, 14);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(356, 17);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "you need to pay the registration fee to complete registration";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(80, 54);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(44, 17);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Name";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(2, 91);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(122, 17);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Admnision Number";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(13, 128);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(106, 17);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Amount Payable";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(34, 172);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(85, 17);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Amount Paid";
			//
			//TextBox1
			//
			this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox1.Location = new System.Drawing.Point(130, 51);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.Size = new System.Drawing.Size(236, 25);
			this.TextBox1.TabIndex = 5;
			//
			//TextBox2
			//
			this.TextBox2.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox2.Location = new System.Drawing.Point(130, 87);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.ReadOnly = true;
			this.TextBox2.Size = new System.Drawing.Size(236, 25);
			this.TextBox2.TabIndex = 6;
			//
			//TextBox3
			//
			this.TextBox3.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox3.Location = new System.Drawing.Point(130, 125);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.ReadOnly = true;
			this.TextBox3.Size = new System.Drawing.Size(236, 25);
			this.TextBox3.TabIndex = 7;
			this.TextBox3.Text = "1000";
			//
			//TextBox4
			//
			this.TextBox4.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox4.Location = new System.Drawing.Point(130, 169);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.ReadOnly = true;
			this.TextBox4.Size = new System.Drawing.Size(236, 25);
			this.TextBox4.TabIndex = 8;
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.GroupBox4);
			this.Panel1.Controls.Add(this.Button4);
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.Button2);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Panel1.Location = new System.Drawing.Point(375, 45);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(326, 221);
			this.Panel1.TabIndex = 9;
			//
			//GroupBox4
			//
			this.GroupBox4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.GroupBox4.Controls.Add(this.Label15);
			this.GroupBox4.Controls.Add(this.TextBox13);
			this.GroupBox4.Controls.Add(this.Label8);
			this.GroupBox4.Controls.Add(this.TextBox6);
			this.GroupBox4.Controls.Add(this.Label9);
			this.GroupBox4.Controls.Add(this.TextBox7);
			this.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.GroupBox4.Location = new System.Drawing.Point(3, 31);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(307, 184);
			this.GroupBox4.TabIndex = 14;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "deposit slip  details";
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Location = new System.Drawing.Point(17, 126);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(55, 17);
			this.Label15.TabIndex = 7;
			this.Label15.Text = "Amount";
			//
			//TextBox13
			//
			this.TextBox13.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox13.Location = new System.Drawing.Point(17, 146);
			this.TextBox13.Name = "TextBox13";
			this.TextBox13.Size = new System.Drawing.Size(272, 25);
			this.TextBox13.TabIndex = 6;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(13, 78);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(120, 17);
			this.Label8.TabIndex = 3;
			this.Label8.Text = "transaction number";
			//
			//TextBox6
			//
			this.TextBox6.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox6.Location = new System.Drawing.Point(18, 98);
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Size = new System.Drawing.Size(264, 25);
			this.TextBox6.TabIndex = 2;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(17, 30);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(72, 17);
			this.Label9.TabIndex = 1;
			this.Label9.Text = "bank name";
			//
			//TextBox7
			//
			this.TextBox7.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox7.Location = new System.Drawing.Point(18, 50);
			this.TextBox7.Name = "TextBox7";
			this.TextBox7.Size = new System.Drawing.Size(264, 25);
			this.TextBox7.TabIndex = 0;
			//
			//Button4
			//
			this.Button4.Font = new System.Drawing.Font("Times New Roman", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.Location = new System.Drawing.Point(228, 3);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(82, 23);
			this.Button4.TabIndex = 3;
			this.Button4.Text = "BANK SLIP";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Font = new System.Drawing.Font("Times New Roman", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.Location = new System.Drawing.Point(140, 2);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(82, 23);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "CHEQUE";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Times New Roman", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(70, 4);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(66, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "M-PESA";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Times New Roman", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(3, 3);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(61, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "CASH";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(471, 29);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(53, 17);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "Method";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(63, 221);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(56, 17);
			this.Label7.TabIndex = 11;
			this.Label7.Text = "Balance";
			//
			//TextBox5
			//
			this.TextBox5.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TextBox5.Location = new System.Drawing.Point(130, 218);
			this.TextBox5.Name = "TextBox5";
			this.TextBox5.ReadOnly = true;
			this.TextBox5.Size = new System.Drawing.Size(236, 25);
			this.TextBox5.TabIndex = 12;
			//
			//Button5
			//
			this.Button5.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button5.Location = new System.Drawing.Point(588, 283);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(99, 30);
			this.Button5.TabIndex = 4;
			this.Button5.Text = "Save";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Button6
			//
			this.Button6.Font = new System.Drawing.Font("Times New Roman", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button6.Location = new System.Drawing.Point(459, 283);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(99, 30);
			this.Button6.TabIndex = 13;
			this.Button6.Text = "Cancel";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//PrintDialog1
			//
			this.PrintDialog1.UseEXDialog = true;
			//
			//PrintDocument1
			//
			//
			//PrintPreviewDialog1
			//
			this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.PrintPreviewDialog1.Enabled = true;
			this.PrintPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("PrintPreviewDialog1.Icon");
			this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
			this.PrintPreviewDialog1.Visible = false;
			//
			//admin_fee
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 325);
			this.ControlBox = false;
			this.Controls.Add(this.Button6);
			this.Controls.Add(this.TextBox5);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.TextBox4);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "admin_fee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "admin_fee";
			this.Panel1.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox3;
		private System.Windows.Forms.TextBox withEventsField_TextBox4;
		internal System.Windows.Forms.TextBox TextBox4 {
			get { return withEventsField_TextBox4; }
			set {
				if (withEventsField_TextBox4 != null) {
					withEventsField_TextBox4.TextChanged -= TextBox4_TextChanged;
				}
				withEventsField_TextBox4 = value;
				if (withEventsField_TextBox4 != null) {
					withEventsField_TextBox4.TextChanged += TextBox4_TextChanged;
				}
			}
		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Label Label15;
		private System.Windows.Forms.TextBox withEventsField_TextBox13;
		internal System.Windows.Forms.TextBox TextBox13 {
			get { return withEventsField_TextBox13; }
			set {
				if (withEventsField_TextBox13 != null) {
					withEventsField_TextBox13.TextChanged -= TextBox13_TextChanged;
				}
				withEventsField_TextBox13 = value;
				if (withEventsField_TextBox13 != null) {
					withEventsField_TextBox13.TextChanged += TextBox13_TextChanged;
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
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox TextBox7;
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
		internal System.Windows.Forms.PrintDialog PrintDialog1;
		internal System.Windows.Forms.PageSetupDialog PageSetupDialog1;
		private System.Drawing.Printing.PrintDocument withEventsField_PrintDocument1;
		internal System.Drawing.Printing.PrintDocument PrintDocument1 {
			get { return withEventsField_PrintDocument1; }
			set {
				if (withEventsField_PrintDocument1 != null) {
					withEventsField_PrintDocument1.PrintPage -= PrintDocument1_PrintPage;
				}
				withEventsField_PrintDocument1 = value;
				if (withEventsField_PrintDocument1 != null) {
					withEventsField_PrintDocument1.PrintPage += PrintDocument1_PrintPage;
				}
			}
		}
		private System.Windows.Forms.PrintPreviewDialog withEventsField_PrintPreviewDialog1;
		internal System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1 {
			get { return withEventsField_PrintPreviewDialog1; }
			set {
				if (withEventsField_PrintPreviewDialog1 != null) {
					withEventsField_PrintPreviewDialog1.Load -= PrintPreviewDialog1_Load;
				}
				withEventsField_PrintPreviewDialog1 = value;
				if (withEventsField_PrintPreviewDialog1 != null) {
					withEventsField_PrintPreviewDialog1.Load += PrintPreviewDialog1_Load;
				}
			}
		}
	}
}
