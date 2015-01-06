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
	public partial class bill_student
	{
		database data = new database();
		List<string> cls = new List<string>();
		string yr;
		string term;
		private void Button2_Click(object sender, EventArgs e)
		{
			dynamic sql1 = null;
			dynamic sql2 = null;
			dynamic sql3 = null;
			string lev = null;
			string admn = null;
			int charge = 0;
			DataTable allstudents = null;
			int sd = 0;


			//sql2 = "SELECT  sum( amount)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" & lev & "'"
			//sql3 = "SELECT  sum( amount)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" & lev & "'"
			if ((Interaction.MsgBox("Bill Students is Not Revesible" + Constants.vbCrLf + "Do you want to Continue ?", Constants.vbYesNo, "confirmation")) == Constants.vbYes) {
				allstudents = data.executeSQL("SELECT admno,` names`,class_code FROM `students` WHERE admno not in (SELECT  `admno` FROM `bill` WHERE `status`=0) and `status`=1 ");
				//reads throug list of names
				foreach (DataRow row in allstudents.Rows) {
					admn = row[0].ToString();
					lev = row[2].ToString();
					DataTable amout = null;
					if (term == "term 1") {
						sql1 = "SELECT  ifnull(sum( amount),0)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly' or `category`='yearly' ) and `L_id`='" + lev + "'";

					} else {
						sql1 = "SELECT  ifnull(sum( amount),0)'Amount'  FROM rates WHERE T_id in(SELECT ID FROM type WHERE category='termly') and `L_id`='" + lev + "'";

					}
					amout = data.executeSQL(sql1);
					// reads fees
					foreach (DataRow dro in amout.Rows) {
						charge = dro[0];
						data.add1("INSERT INTO `schoolfees`.`bill` (`id`, `year`, `term`,`class_Id`, `admno`, `amount`, `status`, `date`) VALUES (NULL, '" + yr + "', '" + term + "','" + lev + "', '" + admn + "', '" + charge + "', '0', CURRENT_TIMESTAMP);");
					}
					sd = sd + 1;
				}
				int sd1 = 0;
				string admn1 = null;
				string cash = null;
				string bill_id = null;
				string sql11 = null;
				DataTable std = null;
				DataTable tras = null;
				int charge1 = 0;
				std = data.executeSQL("SELECT  admno ,  amount ,  id FROM  bill WHERE  status =0");
				//reads throug list of names
				foreach (DataRow row in std.Rows) {
					admn1 = row[0].ToString();
					cash = row[1].ToString();
					bill_id = row[2].ToString();
					sql11 = "SELECT `Balance`  FROM `fees accounting` WHERE `Status`=0 and `admno`='" + admn1 + "'";
					tras = data.executeSQL(sql11);
					// reads fees
					foreach (DataRow dro in tras.Rows) {
						charge1 = dro[0];
					}
					string nn = null;
					nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" + admn1 + "', 'Students billing', 'bill tranfers', 'bills', '', '" + bill_id + "', '" + cash + "', '" + charge1 + "', '" + (cash + charge1) + "', '0', CURRENT_TIMESTAMP);";
					data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" + admn1 + "'");
					data.add1(nn);
					data.add1("UPDATE `bill` SET `status`=1 WHERE `admno`='" + admn1 + "'");
					sd1 = sd1 + 1;
				}
				Interaction.MsgBox("success" + Constants.vbCrLf + sd + " students billed");
			}


		}
		public void transfer()
		{
			int sd1 = 0;
			string admn1 = null;
			string cash = null;
			string bill_id = null;
			string sql11 = null;
			DataTable std = null;
			DataTable tras = null;
			int charge1 = 0;
			std = data.executeSQL("SELECT  admno ,  amount ,  id FROM  bill WHERE  status =0");
			//reads throug list of names
			foreach (DataRow row in std.Rows) {
				admn1 = row[0].ToString();
				cash = row[1].ToString();
				bill_id = row[2].ToString();
				sql11 = "SELECT `Balance`  FROM `fees accounting` WHERE `Status`=0 and `admno`='" + admn1 + "'";
				tras = data.executeSQL(sql11);
				// reads fees
				foreach (DataRow dro in tras.Rows) {
					charge1 = dro[0];
					data.add1("INSERT INTO schoolfees.fees accounting ( admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ( '" + admn1 + "', '', 'bill tranfers', 'bills', '', '" + bill_id + "', '" + cash + "', '" + charge1 + "', '" + (cash + charge1) + "', '0', CURRENT_TIMESTAMP);");
					data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" + admn1 + "'");
					data.add1("UPDATE `bill` SET `status`=1 WHERE `admno`='" + admn1 + "'");
				}

				sd1 = sd1 + 1;
			}
		}
		private void bill_student_Load(object sender, EventArgs e)
		{
			//collect_fees.Show()
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			DataTable red = null;
			red = data.executeSQL("SELECT admno,` names`,class_code FROM `students` WHERE `status`=1 ");
			DataGridView1.DataSource = red;
			DataGridView1.Columns[2].Visible = false;
		}

		private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			string dat = null;
			dat = (DateTimePicker1.Value.Month);
			yr = (DateTimePicker1.Value.Year);
			if (dat >= 1 & dat <= 4) {
				term = "term 1";
			} else if (dat >= 5 & dat <= 8) {
				term = "term 2";
			} else if (dat >= 9 & dat <= 12) {
				term = "term 3";
			}


		}

		private void Button3_Click(object sender, EventArgs e)
		{
			int sd1 = 0;
			string admn1 = null;
			string cash = null;
			string bill_id = null;
			string sql11 = null;
			DataTable std = null;
			DataTable tras = null;
			int charge1 = 0;
			std = data.executeSQL("SELECT  admno ,  amount ,  id FROM  bill WHERE  status =0");
			//reads throug list of names
			foreach (DataRow row in std.Rows) {
				admn1 = row[0].ToString();
				cash = row[1].ToString();
				bill_id = row[2].ToString();
				sql11 = "SELECT `Balance`  FROM `fees accounting` WHERE `Status`=0 and `admno`='" + admn1 + "'";
				tras = data.executeSQL(sql11);
				// reads fees
				foreach (DataRow dro in tras.Rows) {
					charge1 = dro[0];
				}
				string nn = null;
				nn = "INSERT INTO schoolfees.`fees accounting` (admno, Details, method, acc_Name, acc_No, Tran_No, Amount, payable, Balance, Status, Datestamp) VALUES ('" + admn1 + "', '', 'bill tranfers', 'bills', '', '" + bill_id + "', '" + cash + "', '" + charge1 + "', '" + (cash + charge1) + "', '0', CURRENT_TIMESTAMP);";
				data.add1("UPDATE `fees accounting` SET `Status`=1 WHERE `admno`='" + admn1 + "'");
				data.add1(nn);
				data.add1("UPDATE `bill` SET `status`=1 WHERE `admno`='" + admn1 + "'");
				sd1 = sd1 + 1;
			}
			Interaction.MsgBox("success" + Constants.vbCrLf + sd1 + " students billed");
		}
		public bill_student()
		{
			Load += bill_student_Load;
			InitializeComponent();
		}
	}
}
