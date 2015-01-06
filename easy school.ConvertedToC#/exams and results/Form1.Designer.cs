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
	partial class Form1 : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Button1 = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.SchoolDataSet = new easy_school.schoolDataSet();
			this.SchoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DataSet1 = new easy_school.DataSet1();
			this.DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Panel2 = new System.Windows.Forms.Panel();
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this.Button5 = new System.Windows.Forms.Button();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.DataGridView3 = new System.Windows.Forms.DataGridView();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button6 = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.ComboBox3 = new System.Windows.Forms.ComboBox();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Button7 = new System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SchoolDataSet).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SchoolDataSetBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.DataSet1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.DataSet1BindingSource).BeginInit();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).BeginInit();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DataGridView3).BeginInit();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(637, 6);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.DataGridView1);
			this.Panel1.Location = new System.Drawing.Point(2, 136);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(388, 288);
			this.Panel1.TabIndex = 1;
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
			this.DataGridView1.Size = new System.Drawing.Size(388, 288);
			this.DataGridView1.TabIndex = 115;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(839, 6);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 23);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(738, 6);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 23);
			this.Button3.TabIndex = 116;
			this.Button3.Text = "Button3";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(217, 76);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(173, 23);
			this.Button4.TabIndex = 117;
			this.Button4.Text = "select students";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(71, 8);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(89, 21);
			this.ComboBox1.TabIndex = 118;
			this.ComboBox1.Text = "6";
			//
			//SchoolDataSet
			//
			this.SchoolDataSet.DataSetName = "schoolDataSet";
			this.SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//SchoolDataSetBindingSource
			//
			this.SchoolDataSetBindingSource.DataSource = this.SchoolDataSet;
			this.SchoolDataSetBindingSource.Position = 0;
			//
			//DataSet1
			//
			this.DataSet1.DataSetName = "DataSet1";
			this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//DataSet1BindingSource
			//
			this.DataSet1BindingSource.DataSource = this.DataSet1;
			this.DataSet1BindingSource.Position = 0;
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.DataGridView2);
			this.Panel2.Location = new System.Drawing.Point(413, 136);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(175, 288);
			this.Panel2.TabIndex = 119;
			//
			//DataGridView2
			//
			this.DataGridView2.AllowUserToAddRows = false;
			this.DataGridView2.AllowUserToDeleteRows = false;
			this.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridView2.Location = new System.Drawing.Point(0, 0);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.ReadOnly = true;
			this.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView2.Size = new System.Drawing.Size(175, 288);
			this.DataGridView2.TabIndex = 115;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(670, 82);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(173, 23);
			this.Button5.TabIndex = 120;
			this.Button5.Text = "View Results" + Strings.ChrW(13) + Strings.ChrW(10);
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Panel3
			//
			this.Panel3.Controls.Add(this.DataGridView3);
			this.Panel3.Location = new System.Drawing.Point(615, 136);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(277, 288);
			this.Panel3.TabIndex = 121;
			//
			//DataGridView3
			//
			this.DataGridView3.AllowUserToAddRows = false;
			this.DataGridView3.AllowUserToDeleteRows = false;
			this.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridView3.Location = new System.Drawing.Point(0, 0);
			this.DataGridView3.Name = "DataGridView3";
			this.DataGridView3.ReadOnly = true;
			this.DataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView3.Size = new System.Drawing.Size(277, 288);
			this.DataGridView3.TabIndex = 115;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(89, 120);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(681, 13);
			this.Label1.TabIndex = 122;
			this.Label1.Text = resources.GetString("Label1.Text");
			//
			//Button6
			//
			this.Button6.Location = new System.Drawing.Point(413, 78);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(173, 23);
			this.Button6.TabIndex = 123;
			this.Button6.Text = "View Units" + Strings.ChrW(13) + Strings.ChrW(10) + Strings.ChrW(13) + Strings.ChrW(10);
			this.Button6.UseVisualStyleBackColor = true;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(12, 9);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(37, 13);
			this.Label2.TabIndex = 124;
			this.Label2.Text = "Classs";
			//
			//ComboBox3
			//
			this.ComboBox3.FormattingEnabled = true;
			this.ComboBox3.Location = new System.Drawing.Point(70, 79);
			this.ComboBox3.Name = "ComboBox3";
			this.ComboBox3.Size = new System.Drawing.Size(92, 21);
			this.ComboBox3.TabIndex = 128;
			this.ComboBox3.Text = "1";
			//
			//ComboBox2
			//
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Location = new System.Drawing.Point(70, 44);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(92, 21);
			this.ComboBox2.TabIndex = 127;
			this.ComboBox2.Text = "2010";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(12, 82);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(38, 13);
			this.Label3.TabIndex = 126;
			this.Label3.Text = "TERM";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(12, 47);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(36, 13);
			this.Label4.TabIndex = 125;
			this.Label4.Text = "YEAR";
			//
			//Button7
			//
			this.Button7.Location = new System.Drawing.Point(327, 24);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(75, 23);
			this.Button7.TabIndex = 129;
			this.Button7.Text = "Button7";
			this.Button7.UseVisualStyleBackColor = true;
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 457);
			this.Controls.Add(this.Button7);
			this.Controls.Add(this.ComboBox3);
			this.Controls.Add(this.ComboBox2);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Button6);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SchoolDataSet).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SchoolDataSetBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)this.DataSet1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.DataSet1BindingSource).EndInit();
			this.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView2).EndInit();
			this.Panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DataGridView3).EndInit();
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
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.DataGridView DataGridView1;
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
		internal System.Windows.Forms.Button Button3;
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
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.BindingSource DataSet1BindingSource;
		internal easy_school.DataSet1 DataSet1;
		internal easy_school.schoolDataSet SchoolDataSet;
		internal System.Windows.Forms.BindingSource SchoolDataSetBindingSource;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.DataGridView DataGridView2;
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
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.DataGridView DataGridView3;
		internal System.Windows.Forms.Label Label1;
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox ComboBox3;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
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
	}
}
