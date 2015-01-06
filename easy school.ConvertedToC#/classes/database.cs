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

using System.Data.SqlClient;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace easy_school
{
	public class database
	{
		public string connstring = "Server=127.0.0.1;Database=schoolfees;Uid=school;Pwd=incorrect;";
		MySqlConnection conn = new MySqlConnection(connstring);
		MySqlDataAdapter da = new MySqlDataAdapter();
		DataSet ds = new DataSet();
		public string report(string message)
		{
			resultsbox ff = new resultsbox();
			ff.Label1.Text = message;
			ff.Show();
		}
		public object @add(ref string ssql)
		{
			string sReturn = "";
			//Dim sr As SqlDataReader = Nothing
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter();
			conn = new MySqlConnection();
			try {
				conn.ConnectionString = connstring;
				conn.Open();
				MySqlCommand sComm = new MySqlCommand();
				sComm.CommandText = ssql;
				sComm.Connection = conn;
				da.SelectCommand = sComm;
				da.Fill(dt);
				conn.Close();
				//sResult = "SUCCESS"
				//  MsgBox("Success! ", MsgBoxStyle.Information, "success")
				report("succes");
			} catch (Exception ex) {
				//sResult = "SERROR" & ": " & ex.Message
				Interaction.MsgBox("error ! " + ex.Message + "  :  " + ex.Source, MsgBoxStyle.Information, "failed");
				if ((conn.State == System.Data.ConnectionState.Open)) {
					conn.Close();
				}
			}
			conn = null;
			return dt;
		}
		public object dd(ref string ssql, ref string ss)
		{
			string sReturn = "";
			//Dim sr As SqlDataReader = Nothing
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter();
			conn = new MySqlConnection();
			try {
				conn.ConnectionString = connstring;
				conn.Open();
				MySqlCommand sComm = new MySqlCommand();
				sComm.CommandText = ssql;
				sComm.Connection = conn;
				da.SelectCommand = sComm;
				da.Fill(dt);
				conn.Close();
				//sResult = "SUCCESS"
				//MsgBox("Success! ", MsgBoxStyle.Information, "success")
				report("succes !");
			} catch (Exception ex) {
				//Dim sr As SqlDataReader = Nothing
				DataTable dt1 = new DataTable();
				MySqlDataAdapter da1 = new MySqlDataAdapter();
				conn = new MySqlConnection();
				try {
					conn.ConnectionString = connstring;
					conn.Open();
					MySqlCommand sComm = new MySqlCommand();
					sComm.CommandText = ssql;
					sComm.Connection = conn;
					da1.SelectCommand = sComm;
					da1.Fill(dt1);
					conn.Close();
					//sResult = "SUCCESS"
					//MsgBox("Success! ", MsgBoxStyle.Information, "success")
					report("Succes !");
				} catch (Exception ex1) {
					//sResult = "SERROR" & ": " & ex.Message
					Interaction.MsgBox("error ! " + ex1.Message + "  :  " + ex1.Source, MsgBoxStyle.Information, "failed");
					if ((conn.State == System.Data.ConnectionState.Open)) {
						conn.Close();
					}
				}
			}
			conn = null;
			return dt;
		}
		public object add1(string ssql)
		{
			string sReturn = "";
			//Dim sr As SqlDataReader = Nothing
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter();
			conn = new MySqlConnection();
			try {
				conn.ConnectionString = connstring;
				conn.Open();
				MySqlCommand sComm = new MySqlCommand();
				sComm.CommandText = ssql;
				sComm.Connection = conn;
				da.SelectCommand = sComm;
				da.Fill(dt);
				conn.Close();
				//sResult = "SUCCESS"
				// MsgBox("Success! ", MsgBoxStyle.Information, "success")
				report("Succes!");
			} catch (Exception ex) {
				//sResult = "SERROR" & ": " & ex.Message
				Interaction.MsgBox("error ! " + ex.Message + "  :  " + ex.Source, MsgBoxStyle.Information, "failed");
				if ((conn.State == System.Data.ConnectionState.Open)) {
					conn.Close();
				}
			}
			conn = null;
			return dt;
		}

		public void populateDDList(ref ComboBox combo, string sSql)
		{
			string res = "";
			DataTable red = null;
			//SqlDataReader = Nothing
			DataRow drow = null;
			red = executeSQL(sSql);
			combo.Items.Clear();
			//'  combo.Items.Add(New ListItem("Select", "Select"))
			//  If res = "SUCCESS" Then
			foreach (DataRow drow_loopVariable in red.Rows) {
				drow = drow_loopVariable;
				combo.Items.Add(drow[0].ToString().ToUpper());
			}
			//  Else
			// End If
		}
		public void poplist(ref ListBox list, string sSql)
		{
			string res = "";
			DataTable red = null;
			//SqlDataReader = Nothing
			DataRow drow = null;
			red = executeSQL(sSql);
			list.Items.Clear();
			//'   combo.Items.Add(New ListItem("Select", "Select"))
			// If res = "SUCCESS" Then
			foreach (DataRow drow_loopVariable in red.Rows) {
				drow = drow_loopVariable;
				list.Items.Add(drow[0].ToString().ToUpper());
			}
			// Else
			//  End If
		}
		public object select_dgview(string sql, DataGridView datagrid)
		{
			ds.Clear();
			da.Dispose();
			da.SelectCommand = new MySqlCommand(sql, conn);
			try {
				if (conn.State == ConnectionState.Closed)
					conn.Open();
				da.Fill(ds, "test");
				datagrid.DataSource = ds.Tables["test"];
				conn.Close();
			} catch (Exception ex) {
				Interaction.MsgBox(ex.Message);
			}
		}
		public object delete(string sql)
		{
			string sReturn = "";
			//Dim sr As SqlDataReader = Nothing
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter();
			conn = new MySqlConnection();
			try {
				conn.ConnectionString = connstring;
				conn.Open();
				MySqlCommand sComm = new MySqlCommand();
				sComm.CommandText = sql;
				sComm.Connection = conn;
				da.SelectCommand = sComm;
				da.Fill(dt);
				conn.Close();
				//sResult = "SUCCESS"
				report("Success!  " + Constants.vbCrLf + "Deleted ");
				//MsgBox("Success!  " + vbCrLf + "Deleted ", MsgBoxStyle.Information, "success")
			} catch (Exception ex) {
				//sResult = "SERROR" & ": " & ex.Message
				Interaction.MsgBox("error ! " + ex.Message + "  :  " + ex.Source, MsgBoxStyle.Information, "failed");
				if ((conn.State == System.Data.ConnectionState.Open)) {
					conn.Close();
				}
			}
			conn = null;
			return dt;
		}
		public object update(string sql)
		{
			try {
				if (conn.State == ConnectionState.Closed)
					conn.Open();
				MySqlCommand da = new MySqlCommand(sql, conn);
				MySqlDataReader reader = da.ExecuteReader();
				conn.Close();
			} catch (Exception ex) {
				Interaction.MsgBox(ex.Message);
			}
		}
		public Data.DataTable executeSQL(string sSql)
		{
			//, ByRef sResult As String
			string sReturn = "";
			//Dim sr As SqlDataReader = Nothing
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter();
			conn = new MySqlConnection();
			try {
				conn.ConnectionString = connstring;
				//conn.Open()
				MySqlCommand sComm = new MySqlCommand();
				sComm.CommandText = sSql;
				sComm.Connection = conn;
				da.SelectCommand = sComm;
				da.Fill(dt);
				conn.Close();
				//sResult = "SUCCESS"
			} catch (Exception ex) {
				Interaction.MsgBox("SERROR" + ": " + ex.Message);
				if ((conn.State == System.Data.ConnectionState.Open)) {
					conn.Close();
				}
			}
			conn = null;
			return dt;
		}



	}
}
