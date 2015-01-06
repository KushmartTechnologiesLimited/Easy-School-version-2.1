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
	partial class prints : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prints));
			this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
			this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
			this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button7 = new System.Windows.Forms.Button();
			this.Button6 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Panel4.SuspendLayout();
			this.SuspendLayout();
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
			//Panel4
			//
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.Button3);
			this.Panel4.Controls.Add(this.Button1);
			this.Panel4.Controls.Add(this.Button7);
			this.Panel4.Controls.Add(this.Button6);
			this.Panel4.Controls.Add(this.Button2);
			this.Panel4.Location = new System.Drawing.Point(76, 159);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(689, 64);
			this.Panel4.TabIndex = 104;
			//
			//Button3
			//
			this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button3.Location = new System.Drawing.Point(571, 11);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 46);
			this.Button3.TabIndex = 7;
			this.Button3.Text = "Print";
			this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button1.Location = new System.Drawing.Point(438, 11);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(127, 46);
			this.Button1.TabIndex = 6;
			this.Button1.Text = " Print Priview";
			this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button7
			//
			this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button7.Location = new System.Drawing.Point(326, 11);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(94, 50);
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
			this.Button6.Location = new System.Drawing.Point(194, 7);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(117, 50);
			this.Button6.TabIndex = 4;
			this.Button6.Text = "office";
			this.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button6.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button2.Location = new System.Drawing.Point(61, 11);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(127, 46);
			this.Button2.TabIndex = 0;
			this.Button2.Text = "&Process  F2";
			this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Button2.UseVisualStyleBackColor = true;
			//
			//prints
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 262);
			this.Controls.Add(this.Panel4);
			this.Name = "prints";
			this.Text = "prints";
			this.Panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.PageSetupDialog PageSetupDialog1;
		internal System.Windows.Forms.PrintDialog PrintDialog1;
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
		internal System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
		internal System.Windows.Forms.Panel Panel4;
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
