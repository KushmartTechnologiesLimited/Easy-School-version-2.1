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
	partial class fee_statement : System.Windows.Forms.Form
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
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Panel6 = new System.Windows.Forms.Panel();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel5 = new System.Windows.Forms.Panel();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Panel3.SuspendLayout();
			this.Panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel4.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Location = new System.Drawing.Point(1, 1);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(752, 49);
			this.Panel1.TabIndex = 0;
			//
			//Panel2
			//
			this.Panel2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Location = new System.Drawing.Point(1, 56);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(88, 458);
			this.Panel2.TabIndex = 1;
			//
			//Panel3
			//
			this.Panel3.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Panel3.Controls.Add(this.Panel6);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Controls.Add(this.Panel5);
			this.Panel3.Location = new System.Drawing.Point(95, 56);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(658, 421);
			this.Panel3.TabIndex = 2;
			//
			//Panel6
			//
			this.Panel6.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.Panel6.BackColor = System.Drawing.Color.Maroon;
			this.Panel6.Location = new System.Drawing.Point(8, 349);
			this.Panel6.Name = "Panel6";
			this.Panel6.Size = new System.Drawing.Size(647, 69);
			this.Panel6.TabIndex = 3;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(187, 10);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(50, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "INVOICE";
			//
			//Panel5
			//
			this.Panel5.Controls.Add(this.DataGridView1);
			this.Panel5.Location = new System.Drawing.Point(8, 26);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new System.Drawing.Size(647, 317);
			this.Panel5.TabIndex = 1;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
				this.Column1,
				this.Column2,
				this.Column3
			});
			this.DataGridView1.Location = new System.Drawing.Point(2, 3);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(637, 317);
			this.DataGridView1.TabIndex = 117;
			//
			//Column1
			//
			this.Column1.FillWeight = 30f;
			this.Column1.HeaderText = "ITEM";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			//
			//Column2
			//
			this.Column2.FillWeight = 7.614212f;
			this.Column2.HeaderText = "DATE";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			//
			//Column3
			//
			this.Column3.FillWeight = 7.614212f;
			this.Column3.HeaderText = "AMOUNT";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			//
			//Panel4
			//
			this.Panel4.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Panel4.Controls.Add(this.Button1);
			this.Panel4.Controls.Add(this.Button2);
			this.Panel4.Controls.Add(this.Button4);
			this.Panel4.Controls.Add(this.Button3);
			this.Panel4.Location = new System.Drawing.Point(89, 483);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(664, 31);
			this.Panel4.TabIndex = 3;
			//
			//Button1
			//
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Location = new System.Drawing.Point(73, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(103, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "export to word";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button2.Location = new System.Drawing.Point(526, 3);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(103, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "close";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button4.Location = new System.Drawing.Point(228, 5);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(103, 23);
			this.Button4.TabIndex = 3;
			this.Button4.Text = "print preview";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button3.Location = new System.Drawing.Point(361, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(103, 23);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "print document";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//fee_statement
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 516);
			this.Controls.Add(this.Panel4);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Name = "fee_statement";
			this.Text = "fee_statement";
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.Panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Panel Panel5;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		internal System.Windows.Forms.Panel Panel6;
		internal System.Windows.Forms.Label Label1;
	}
}
