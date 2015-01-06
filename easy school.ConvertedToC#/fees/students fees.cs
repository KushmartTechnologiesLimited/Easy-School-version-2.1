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
	public partial class students_fees
	{
		database data = new database();
		public string ad;

		private void Button4_Click(object sender, EventArgs e)
		{
		}

		private void students_fees_Load(object sender, EventArgs e)
		{
			DataTable RED = null;
			RED = data.executeSQL("SELECT  `Details`, `method`, `acc_Name`, `acc_No`, `Amount`, `payable`, `Balance`, DATE_FORMAT(  `Datestamp` ,  '%d-%M-%Y' )'Date Paid'  FROM `fees accounting` WHERE  `admno`=" + ad + " ORDER BY  `fees accounting`.`Datestamp` DESC");
			DataGridView1.DataSource = RED;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			DataTable RED = null;
			string gg = null;
			gg = "SELECT  `Details`, `method`, `acc_Name`, `acc_No`, `Amount`, `payable`, `Balance`, DATE_FORMAT(  `Datestamp` ,  '%d-%M-%Y' )'Date Paid'  FROM `fees accounting` WHERE  `admno`=" + ad + " and `Datestamp` between '" + DateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00' and '" + DateTimePicker2.Value.ToString("yyyy-MM-dd") + " 23:59:59' ORDER BY  `fees accounting`.`Datestamp` DESC";
			RED = data.executeSQL(gg);
			DataGridView1.DataSource = RED;
		}
		public students_fees()
		{
			Load += students_fees_Load;
			InitializeComponent();
		}
	}
}
