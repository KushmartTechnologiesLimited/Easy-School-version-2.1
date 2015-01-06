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
	partial class profile : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.TextBox16 = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.TextBox17 = new System.Windows.Forms.TextBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.TextBox14 = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.TextBox12 = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.TextBox13 = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.TextBox10 = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.TextBox11 = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.TextBox18 = new System.Windows.Forms.TextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.TextBox20 = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.TextBox19 = new System.Windows.Forms.TextBox();
			this.Button7 = new System.Windows.Forms.Button();
			this.Button5 = new System.Windows.Forms.Button();
			this.TextBox22 = new System.Windows.Forms.TextBox();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.Label28 = new System.Windows.Forms.Label();
			this.TextBox28 = new System.Windows.Forms.TextBox();
			this.TextBox27 = new System.Windows.Forms.TextBox();
			this.Label27 = new System.Windows.Forms.Label();
			this.TextBox8 = new System.Windows.Forms.TextBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label22 = new System.Windows.Forms.Label();
			this.TextBox23 = new System.Windows.Forms.TextBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.TextBox24 = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.TextBox25 = new System.Windows.Forms.TextBox();
			this.Label25 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.TextBox9 = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.TextBox7 = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.Label29 = new System.Windows.Forms.Label();
			this.TextBox26 = new System.Windows.Forms.TextBox();
			this.Button9 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.GroupBox3.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox3
			//
			resources.ApplyResources(this.GroupBox3, "GroupBox3");
			this.GroupBox3.Controls.Add(this.Button1);
			this.GroupBox3.Controls.Add(this.TextBox16);
			this.GroupBox3.Controls.Add(this.Label16);
			this.GroupBox3.Controls.Add(this.TextBox17);
			this.GroupBox3.Controls.Add(this.Label17);
			this.GroupBox3.Controls.Add(this.TextBox14);
			this.GroupBox3.Controls.Add(this.Label14);
			this.GroupBox3.Controls.Add(this.TextBox12);
			this.GroupBox3.Controls.Add(this.Label12);
			this.GroupBox3.Controls.Add(this.TextBox13);
			this.GroupBox3.Controls.Add(this.Label13);
			this.GroupBox3.Controls.Add(this.TextBox10);
			this.GroupBox3.Controls.Add(this.Label10);
			this.GroupBox3.Controls.Add(this.TextBox11);
			this.GroupBox3.Controls.Add(this.Label11);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.TabStop = false;
			//
			//Button1
			//
			resources.ApplyResources(this.Button1, "Button1");
			this.Button1.Name = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//TextBox16
			//
			resources.ApplyResources(this.TextBox16, "TextBox16");
			this.TextBox16.Name = "TextBox16";
			//
			//Label16
			//
			resources.ApplyResources(this.Label16, "Label16");
			this.Label16.Name = "Label16";
			//
			//TextBox17
			//
			resources.ApplyResources(this.TextBox17, "TextBox17");
			this.TextBox17.Name = "TextBox17";
			//
			//Label17
			//
			resources.ApplyResources(this.Label17, "Label17");
			this.Label17.Name = "Label17";
			//
			//TextBox14
			//
			resources.ApplyResources(this.TextBox14, "TextBox14");
			this.TextBox14.Name = "TextBox14";
			//
			//Label14
			//
			resources.ApplyResources(this.Label14, "Label14");
			this.Label14.Name = "Label14";
			//
			//TextBox12
			//
			resources.ApplyResources(this.TextBox12, "TextBox12");
			this.TextBox12.Name = "TextBox12";
			//
			//Label12
			//
			resources.ApplyResources(this.Label12, "Label12");
			this.Label12.Name = "Label12";
			//
			//TextBox13
			//
			resources.ApplyResources(this.TextBox13, "TextBox13");
			this.TextBox13.Name = "TextBox13";
			//
			//Label13
			//
			resources.ApplyResources(this.Label13, "Label13");
			this.Label13.Name = "Label13";
			//
			//TextBox10
			//
			resources.ApplyResources(this.TextBox10, "TextBox10");
			this.TextBox10.Name = "TextBox10";
			//
			//Label10
			//
			resources.ApplyResources(this.Label10, "Label10");
			this.Label10.Name = "Label10";
			//
			//TextBox11
			//
			resources.ApplyResources(this.TextBox11, "TextBox11");
			this.TextBox11.Name = "TextBox11";
			//
			//Label11
			//
			resources.ApplyResources(this.Label11, "Label11");
			this.Label11.Name = "Label11";
			//
			//TextBox18
			//
			resources.ApplyResources(this.TextBox18, "TextBox18");
			this.TextBox18.Name = "TextBox18";
			//
			//Label18
			//
			resources.ApplyResources(this.Label18, "Label18");
			this.Label18.Name = "Label18";
			//
			//Label19
			//
			resources.ApplyResources(this.Label19, "Label19");
			this.Label19.Name = "Label19";
			//
			//TextBox20
			//
			resources.ApplyResources(this.TextBox20, "TextBox20");
			this.TextBox20.Name = "TextBox20";
			//
			//Label20
			//
			resources.ApplyResources(this.Label20, "Label20");
			this.Label20.Name = "Label20";
			//
			//TextBox19
			//
			resources.ApplyResources(this.TextBox19, "TextBox19");
			this.TextBox19.Name = "TextBox19";
			//
			//Button7
			//
			resources.ApplyResources(this.Button7, "Button7");
			this.Button7.Name = "Button7";
			this.Button7.UseVisualStyleBackColor = true;
			//
			//Button5
			//
			resources.ApplyResources(this.Button5, "Button5");
			this.Button5.Name = "Button5";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//TextBox22
			//
			resources.ApplyResources(this.TextBox22, "TextBox22");
			this.TextBox22.Name = "TextBox22";
			//
			//GroupBox6
			//
			resources.ApplyResources(this.GroupBox6, "GroupBox6");
			this.GroupBox6.Controls.Add(this.Button7);
			this.GroupBox6.Controls.Add(this.Button5);
			this.GroupBox6.Name = "GroupBox6";
			this.GroupBox6.TabStop = false;
			//
			//Label28
			//
			resources.ApplyResources(this.Label28, "Label28");
			this.Label28.Name = "Label28";
			//
			//TextBox28
			//
			resources.ApplyResources(this.TextBox28, "TextBox28");
			this.TextBox28.Name = "TextBox28";
			this.TextBox28.ShortcutsEnabled = false;
			//
			//TextBox27
			//
			resources.ApplyResources(this.TextBox27, "TextBox27");
			this.TextBox27.ForeColor = System.Drawing.SystemColors.Window;
			this.TextBox27.Name = "TextBox27";
			//
			//Label27
			//
			resources.ApplyResources(this.Label27, "Label27");
			this.Label27.Name = "Label27";
			//
			//TextBox8
			//
			resources.ApplyResources(this.TextBox8, "TextBox8");
			this.TextBox8.Name = "TextBox8";
			//
			//GroupBox2
			//
			resources.ApplyResources(this.GroupBox2, "GroupBox2");
			this.GroupBox2.Controls.Add(this.GroupBox4);
			this.GroupBox2.Controls.Add(this.GroupBox3);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.TabStop = false;
			//
			//GroupBox4
			//
			resources.ApplyResources(this.GroupBox4, "GroupBox4");
			this.GroupBox4.Controls.Add(this.Button2);
			this.GroupBox4.Controls.Add(this.TextBox18);
			this.GroupBox4.Controls.Add(this.Label18);
			this.GroupBox4.Controls.Add(this.TextBox19);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.TextBox20);
			this.GroupBox4.Controls.Add(this.Label20);
			this.GroupBox4.Controls.Add(this.TextBox22);
			this.GroupBox4.Controls.Add(this.Label22);
			this.GroupBox4.Controls.Add(this.TextBox23);
			this.GroupBox4.Controls.Add(this.Label23);
			this.GroupBox4.Controls.Add(this.TextBox24);
			this.GroupBox4.Controls.Add(this.Label24);
			this.GroupBox4.Controls.Add(this.TextBox25);
			this.GroupBox4.Controls.Add(this.Label25);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.TabStop = false;
			//
			//Button2
			//
			resources.ApplyResources(this.Button2, "Button2");
			this.Button2.Name = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Label22
			//
			resources.ApplyResources(this.Label22, "Label22");
			this.Label22.Name = "Label22";
			//
			//TextBox23
			//
			resources.ApplyResources(this.TextBox23, "TextBox23");
			this.TextBox23.Name = "TextBox23";
			//
			//Label23
			//
			resources.ApplyResources(this.Label23, "Label23");
			this.Label23.Name = "Label23";
			//
			//TextBox24
			//
			resources.ApplyResources(this.TextBox24, "TextBox24");
			this.TextBox24.Name = "TextBox24";
			//
			//Label24
			//
			resources.ApplyResources(this.Label24, "Label24");
			this.Label24.Name = "Label24";
			//
			//TextBox25
			//
			resources.ApplyResources(this.TextBox25, "TextBox25");
			this.TextBox25.Name = "TextBox25";
			//
			//Label25
			//
			resources.ApplyResources(this.Label25, "Label25");
			this.Label25.Name = "Label25";
			//
			//Label8
			//
			resources.ApplyResources(this.Label8, "Label8");
			this.Label8.Name = "Label8";
			//
			//TextBox9
			//
			resources.ApplyResources(this.TextBox9, "TextBox9");
			this.TextBox9.Name = "TextBox9";
			//
			//Label9
			//
			resources.ApplyResources(this.Label9, "Label9");
			this.Label9.Name = "Label9";
			//
			//Label7
			//
			resources.ApplyResources(this.Label7, "Label7");
			this.Label7.Name = "Label7";
			//
			//TextBox7
			//
			resources.ApplyResources(this.TextBox7, "TextBox7");
			this.TextBox7.Name = "TextBox7";
			//
			//GroupBox1
			//
			resources.ApplyResources(this.GroupBox1, "GroupBox1");
			this.GroupBox1.Controls.Add(this.Label28);
			this.GroupBox1.Controls.Add(this.GroupBox6);
			this.GroupBox1.Controls.Add(this.TextBox28);
			this.GroupBox1.Controls.Add(this.TextBox27);
			this.GroupBox1.Controls.Add(this.Label27);
			this.GroupBox1.Controls.Add(this.TextBox8);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.TextBox9);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.TextBox7);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.TextBox4);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.TextBox3);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.TabStop = false;
			//
			//TextBox4
			//
			resources.ApplyResources(this.TextBox4, "TextBox4");
			this.TextBox4.Name = "TextBox4";
			//
			//Label4
			//
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			//
			//TextBox3
			//
			resources.ApplyResources(this.TextBox3, "TextBox3");
			this.TextBox3.Name = "TextBox3";
			//
			//Label3
			//
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			//
			//TextBox2
			//
			resources.ApplyResources(this.TextBox2, "TextBox2");
			this.TextBox2.Name = "TextBox2";
			//
			//Label2
			//
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			//
			//TextBox1
			//
			resources.ApplyResources(this.TextBox1, "TextBox1");
			this.TextBox1.Name = "TextBox1";
			//
			//Label1
			//
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			//
			//GroupBox5
			//
			resources.ApplyResources(this.GroupBox5, "GroupBox5");
			this.GroupBox5.Controls.Add(this.Label29);
			this.GroupBox5.Controls.Add(this.TextBox26);
			this.GroupBox5.Controls.Add(this.Button9);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.TabStop = false;
			//
			//Label29
			//
			resources.ApplyResources(this.Label29, "Label29");
			this.Label29.Name = "Label29";
			//
			//TextBox26
			//
			resources.ApplyResources(this.TextBox26, "TextBox26");
			this.TextBox26.Name = "TextBox26";
			//
			//Button9
			//
			resources.ApplyResources(this.Button9, "Button9");
			this.Button9.Name = "Button9";
			this.Button9.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			resources.ApplyResources(this.Button3, "Button3");
			this.Button3.Name = "Button3";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//profile
			//
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.GroupBox5);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "profile";
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.TextBox TextBox16;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.TextBox TextBox17;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.TextBox TextBox14;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox TextBox12;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox TextBox13;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox TextBox10;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox TextBox11;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox TextBox18;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.TextBox TextBox20;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox TextBox19;
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
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.TextBox TextBox22;
		internal System.Windows.Forms.GroupBox GroupBox6;
		internal System.Windows.Forms.Label Label28;
		internal System.Windows.Forms.TextBox TextBox28;
		internal System.Windows.Forms.TextBox TextBox27;
		internal System.Windows.Forms.Label Label27;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.TextBox TextBox23;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.TextBox TextBox24;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.TextBox TextBox25;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox TextBox7;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.GroupBox withEventsField_GroupBox5;
		internal System.Windows.Forms.GroupBox GroupBox5 {
			get { return withEventsField_GroupBox5; }
			set {
				if (withEventsField_GroupBox5 != null) {
					withEventsField_GroupBox5.Enter -= GroupBox5_Enter;
				}
				withEventsField_GroupBox5 = value;
				if (withEventsField_GroupBox5 != null) {
					withEventsField_GroupBox5.Enter += GroupBox5_Enter;
				}
			}
		}
		internal System.Windows.Forms.Label Label29;
		private System.Windows.Forms.TextBox withEventsField_TextBox26;
		internal System.Windows.Forms.TextBox TextBox26 {
			get { return withEventsField_TextBox26; }
			set {
				if (withEventsField_TextBox26 != null) {
					withEventsField_TextBox26.KeyPress -= TextBox26_KeyPress;
					withEventsField_TextBox26.TextChanged -= TextBox26_TextChanged;
				}
				withEventsField_TextBox26 = value;
				if (withEventsField_TextBox26 != null) {
					withEventsField_TextBox26.KeyPress += TextBox26_KeyPress;
					withEventsField_TextBox26.TextChanged += TextBox26_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button9;
		internal System.Windows.Forms.Button Button9 {
			get { return withEventsField_Button9; }
			set {
				if (withEventsField_Button9 != null) {
					withEventsField_Button9.Click -= Button9_Click;
				}
				withEventsField_Button9 = value;
				if (withEventsField_Button9 != null) {
					withEventsField_Button9.Click += Button9_Click;
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
		public profile()
		{
			Load += profile_Load;
			InitializeComponent();
		}
	}
}
