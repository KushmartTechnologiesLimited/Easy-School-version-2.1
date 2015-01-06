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
	public partial class resultsbox
	{
		int i = 0;
		private void resultsbox_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void resultsbox_Load(object sender, EventArgs e)
		{
			this.Top = 20;
			this.Left = 300;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			i = i + 1;
			this.Opacity = 100 - (i * 80 / 5);
			if (i > 5) {
				this.Close();
			}
		}
		public resultsbox()
		{
			Load += resultsbox_Load;
			Click += resultsbox_Click;
			InitializeComponent();
		}
	}
}
