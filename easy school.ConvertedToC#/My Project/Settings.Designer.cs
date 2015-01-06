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
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace easy_school.My
{

	[System.Runtime.CompilerServices.CompilerGeneratedAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"), System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : global::System.Configuration.ApplicationSettingsBase
	{

		private static MySettings defaultInstance = (MySettings)global::System.Configuration.ApplicationSettingsBase.Synchronized(new MySettings());

		#region "My.Settings Auto-Save Functionality"

		private static bool addedHandler;

		private static object addedHandlerLockObject = new object();
		[System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(global::System.Object sender, global::System.EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit) {
				easy_school.My.Settings.Save();
			}
		}
		#endregion

		public static MySettings Default {
			get {

				if (!addedHandler) {
					lock (addedHandlerLockObject) {
						if (!addedHandler) {
							MyProject.Application.Shutdown += AutoSaveSettings;
							addedHandler = true;
						}
					}
				}
				return defaultInstance;
			}
		}

		[System.Configuration.ApplicationScopedSettingAttribute(), System.Diagnostics.DebuggerNonUserCodeAttribute(), System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString), System.Configuration.DefaultSettingValueAttribute("Server=127.0.0.1;Database=schoolfees;Uid=school;Pwd=incorrect;")]
		public string schoolConnectionString {
			get { return Convert.ToString(this["schoolConnectionString"]); }
		}

		[System.Configuration.ApplicationScopedSettingAttribute(), System.Diagnostics.DebuggerNonUserCodeAttribute(), System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString), System.Configuration.DefaultSettingValueAttribute("Dsn=skull")]
		public string ConnectionString {
			get { return Convert.ToString(this["ConnectionString"]); }
		}
	}
}

namespace easy_school.My
{

	[Microsoft.VisualBasic.HideModuleNameAttribute(), System.Diagnostics.DebuggerNonUserCodeAttribute(), System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	static internal class MySettingsProperty
	{

		[System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")]
		static internal global::easy_school.My.MySettings Settings {
			get { return global::easy_school.My.MySettings.Default; }
		}
	}
}