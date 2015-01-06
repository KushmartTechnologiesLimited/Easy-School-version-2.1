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
	public partial class login1
	{
		public bool pod = 0;
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			pod = 1;
			this.Close();
		}


		private void login_Load(object sender, EventArgs e)
		{
		}
		public login1()
		{
			Load += login_Load;
			InitializeComponent();
		}
	}
}
