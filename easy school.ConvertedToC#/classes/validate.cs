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
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace easy_school
{

	public class validate
	{
		public object digits(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			sender.MaxLength = 8;
			try {
				if (System.Char.IsDigit(e.KeyChar) == false & e.KeyChar != Strings.Chr(8) & e.KeyChar != Strings.Chr(46) | (Strings.InStr(sender.text, ".") > 0 & e.KeyChar == Strings.Chr(46))) {
					e.Handled = true;
				}
			} catch (Exception ex) {
				Interaction.MsgBox(ex.Message);
			}
			return Constants.vbNull;
		}
		public object digits_phone(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			sender.MaxLength = 10;
			try {
				if (System.Char.IsDigit(e.KeyChar) == false & e.KeyChar != Strings.Chr(8) & e.KeyChar != Strings.Chr(46) | (Strings.InStr(sender.text, ".") > 0 | (Strings.InStr(sender.text, "+") > 0 & e.KeyChar == Strings.Chr(43)))) {
					e.Handled = true;
				}
			} catch (Exception ex) {
				Interaction.MsgBox(ex.Message);
			}
			return Constants.vbNull;
		}
		public object alphasnumerical(string texts)
		{
			if (!Regex.Match(texts, "^[a-zA-Z0-9]*$", RegexOptions.IgnoreCase).Success) {
				Interaction.MsgBox("Please enter alpha text only.");
				return false;
			}
			return true;
		}
		public object alphas(string texts)
		{
			if (!Regex.Match(texts, "^[a-z]*$", RegexOptions.IgnoreCase).Success) {
				Interaction.MsgBox("Please enter alpha text only.");
				return false;
			}
			return true;
		}
		public object emails(object sender)
		{
			System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex("^[a-zA-Z][\\w\\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\\w\\.-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z\\.]*[a-zA-Z]$");
			if (sender.Text.Length > 0) {
				if (!rEMail.IsMatch(sender.Text)) {
					MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					//' Timer1.Enabled = True
					sender.SelectAll();
				}
			}
		}


	}
}
