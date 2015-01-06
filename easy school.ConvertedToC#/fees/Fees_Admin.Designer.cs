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
	partial class Fees_Admin : System.Windows.Forms.Form
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
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.AddNewFeesItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CreateOrModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BilllsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ProjectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.YearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.Font = new System.Drawing.Font("Times New Roman", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.AddNewFeesItemToolStripMenuItem,
				this.CreateOrModifyToolStripMenuItem,
				this.BillToolStripMenuItem,
				this.BilllsToolStripMenuItem,
				this.ToolStripMenuItem1,
				this.ProjectionsToolStripMenuItem
			});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(897, 39);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//AddNewFeesItemToolStripMenuItem
			//
			this.AddNewFeesItemToolStripMenuItem.Name = "AddNewFeesItemToolStripMenuItem";
			this.AddNewFeesItemToolStripMenuItem.Size = new System.Drawing.Size(187, 35);
			this.AddNewFeesItemToolStripMenuItem.Text = "New Fees Item";
			//
			//CreateOrModifyToolStripMenuItem
			//
			this.CreateOrModifyToolStripMenuItem.Name = "CreateOrModifyToolStripMenuItem";
			this.CreateOrModifyToolStripMenuItem.Size = new System.Drawing.Size(86, 35);
			this.CreateOrModifyToolStripMenuItem.Text = "Rates";
			//
			//BillToolStripMenuItem
			//
			this.BillToolStripMenuItem.Name = "BillToolStripMenuItem";
			this.BillToolStripMenuItem.Size = new System.Drawing.Size(185, 35);
			this.BillToolStripMenuItem.Text = "Fees Strucures";
			//
			//BilllsToolStripMenuItem
			//
			this.BilllsToolStripMenuItem.Name = "BilllsToolStripMenuItem";
			this.BilllsToolStripMenuItem.Size = new System.Drawing.Size(77, 35);
			this.BilllsToolStripMenuItem.Text = "Bills";
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(202, 35);
			this.ToolStripMenuItem1.Text = "Change Classes ";
			//
			//ProjectionsToolStripMenuItem
			//
			this.ProjectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.YearToolStripMenuItem });
			this.ProjectionsToolStripMenuItem.Name = "ProjectionsToolStripMenuItem";
			this.ProjectionsToolStripMenuItem.Size = new System.Drawing.Size(111, 35);
			this.ProjectionsToolStripMenuItem.Text = "Reports";
			//
			//YearToolStripMenuItem
			//
			this.YearToolStripMenuItem.Name = "YearToolStripMenuItem";
			this.YearToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
			this.YearToolStripMenuItem.Text = "Fees Report";
			//
			//Panel1
			//
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Panel1.Location = new System.Drawing.Point(0, 39);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(897, 477);
			this.Panel1.TabIndex = 1;
			//
			//Fees_Admin
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 516);
			this.ControlBox = false;
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.MenuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.MenuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Fees_Admin";
			this.Text = " ";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_AddNewFeesItemToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddNewFeesItemToolStripMenuItem {
			get { return withEventsField_AddNewFeesItemToolStripMenuItem; }
			set {
				if (withEventsField_AddNewFeesItemToolStripMenuItem != null) {
					withEventsField_AddNewFeesItemToolStripMenuItem.Click -= AddNewFeesItemToolStripMenuItem_Click;
				}
				withEventsField_AddNewFeesItemToolStripMenuItem = value;
				if (withEventsField_AddNewFeesItemToolStripMenuItem != null) {
					withEventsField_AddNewFeesItemToolStripMenuItem.Click += AddNewFeesItemToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_CreateOrModifyToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CreateOrModifyToolStripMenuItem {
			get { return withEventsField_CreateOrModifyToolStripMenuItem; }
			set {
				if (withEventsField_CreateOrModifyToolStripMenuItem != null) {
					withEventsField_CreateOrModifyToolStripMenuItem.Click -= CreateOrModifyToolStripMenuItem_Click;
				}
				withEventsField_CreateOrModifyToolStripMenuItem = value;
				if (withEventsField_CreateOrModifyToolStripMenuItem != null) {
					withEventsField_CreateOrModifyToolStripMenuItem.Click += CreateOrModifyToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_BillToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem BillToolStripMenuItem {
			get { return withEventsField_BillToolStripMenuItem; }
			set {
				if (withEventsField_BillToolStripMenuItem != null) {
					withEventsField_BillToolStripMenuItem.Click -= BillToolStripMenuItem_Click;
				}
				withEventsField_BillToolStripMenuItem = value;
				if (withEventsField_BillToolStripMenuItem != null) {
					withEventsField_BillToolStripMenuItem.Click += BillToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_BilllsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem BilllsToolStripMenuItem {
			get { return withEventsField_BilllsToolStripMenuItem; }
			set {
				if (withEventsField_BilllsToolStripMenuItem != null) {
					withEventsField_BilllsToolStripMenuItem.Click -= BilllsToolStripMenuItem_Click;
				}
				withEventsField_BilllsToolStripMenuItem = value;
				if (withEventsField_BilllsToolStripMenuItem != null) {
					withEventsField_BilllsToolStripMenuItem.Click += BilllsToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ProjectionsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ProjectionsToolStripMenuItem {
			get { return withEventsField_ProjectionsToolStripMenuItem; }
			set {
				if (withEventsField_ProjectionsToolStripMenuItem != null) {
					withEventsField_ProjectionsToolStripMenuItem.Click -= ProjectionsToolStripMenuItem_Click;
				}
				withEventsField_ProjectionsToolStripMenuItem = value;
				if (withEventsField_ProjectionsToolStripMenuItem != null) {
					withEventsField_ProjectionsToolStripMenuItem.Click += ProjectionsToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_YearToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem YearToolStripMenuItem {
			get { return withEventsField_YearToolStripMenuItem; }
			set {
				if (withEventsField_YearToolStripMenuItem != null) {
					withEventsField_YearToolStripMenuItem.Click -= YearToolStripMenuItem_Click;
				}
				withEventsField_YearToolStripMenuItem = value;
				if (withEventsField_YearToolStripMenuItem != null) {
					withEventsField_YearToolStripMenuItem.Click += YearToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1 {
			get { return withEventsField_ToolStripMenuItem1; }
			set {
				if (withEventsField_ToolStripMenuItem1 != null) {
					withEventsField_ToolStripMenuItem1.Click -= ToolStripMenuItem1_Click;
				}
				withEventsField_ToolStripMenuItem1 = value;
				if (withEventsField_ToolStripMenuItem1 != null) {
					withEventsField_ToolStripMenuItem1.Click += ToolStripMenuItem1_Click;
				}
			}
		}
	}
}
