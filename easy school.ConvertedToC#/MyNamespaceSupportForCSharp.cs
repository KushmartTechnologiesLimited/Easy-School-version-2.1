using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

// This file was created by the VB to C# converter (SharpDevelop 4.4.1.9729).
// It contains classes for supporting the VB "My" namespace in C#.
// If the VB application does not use the "My" namespace, or if you removed the usage
// after the conversion to C#, you can delete this file.

namespace easy_school.My
{
	sealed partial class MyProject
	{
		[ThreadStatic] static MyApplication application;
		
		public static MyApplication Application {
			[DebuggerStepThrough]
			get {
				if (application == null)
					application = new MyApplication();
				return application;
			}
		}
		
		[ThreadStatic] static MyComputer computer;
		
		public static MyComputer Computer {
			[DebuggerStepThrough]
			get {
				if (computer == null)
					computer = new MyComputer();
				return computer;
			}
		}
		
		[ThreadStatic] static User user;
		
		public static User User {
			[DebuggerStepThrough]
			get {
				if (user == null)
					user = new User();
				return user;
			}
		}
		
		[ThreadStatic] static MyForms forms;
		
		public static MyForms Forms {
			[DebuggerStepThrough]
			get {
				if (forms == null)
					forms = new MyForms();
				return forms;
			}
		}
		
		internal sealed class MyForms
		{
			global::easy_school.new_student new_student_instance;
			bool new_student_isCreating;
			public global::easy_school.new_student new_student {
				[DebuggerStepThrough] get { return GetForm(ref new_student_instance, ref new_student_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref new_student_instance, value); }
			}
			
			global::easy_school.type type_instance;
			bool type_isCreating;
			public global::easy_school.type type {
				[DebuggerStepThrough] get { return GetForm(ref type_instance, ref type_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref type_instance, value); }
			}
			
			global::easy_school.profile profile_instance;
			bool profile_isCreating;
			public global::easy_school.profile profile {
				[DebuggerStepThrough] get { return GetForm(ref profile_instance, ref profile_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref profile_instance, value); }
			}
			
			global::easy_school.bill bill_instance;
			bool bill_isCreating;
			public global::easy_school.bill bill {
				[DebuggerStepThrough] get { return GetForm(ref bill_instance, ref bill_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref bill_instance, value); }
			}
			
			global::easy_school.create_user create_user_instance;
			bool create_user_isCreating;
			public global::easy_school.create_user create_user {
				[DebuggerStepThrough] get { return GetForm(ref create_user_instance, ref create_user_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref create_user_instance, value); }
			}
			
			global::easy_school.resultsbox resultsbox_instance;
			bool resultsbox_isCreating;
			public global::easy_school.resultsbox resultsbox {
				[DebuggerStepThrough] get { return GetForm(ref resultsbox_instance, ref resultsbox_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref resultsbox_instance, value); }
			}
			
			global::easy_school.billing billing_instance;
			bool billing_isCreating;
			public global::easy_school.billing billing {
				[DebuggerStepThrough] get { return GetForm(ref billing_instance, ref billing_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref billing_instance, value); }
			}
			
			global::easy_school.report_form report_form_instance;
			bool report_form_isCreating;
			public global::easy_school.report_form report_form {
				[DebuggerStepThrough] get { return GetForm(ref report_form_instance, ref report_form_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref report_form_instance, value); }
			}
			
			global::easy_school.login login_instance;
			bool login_isCreating;
			public global::easy_school.login login {
				[DebuggerStepThrough] get { return GetForm(ref login_instance, ref login_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref login_instance, value); }
			}
			
			global::easy_school.MDIParent1 MDIParent1_instance;
			bool MDIParent1_isCreating;
			public global::easy_school.MDIParent1 MDIParent1 {
				[DebuggerStepThrough] get { return GetForm(ref MDIParent1_instance, ref MDIParent1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref MDIParent1_instance, value); }
			}
			
			global::easy_school.collect_fees collect_fees_instance;
			bool collect_fees_isCreating;
			public global::easy_school.collect_fees collect_fees {
				[DebuggerStepThrough] get { return GetForm(ref collect_fees_instance, ref collect_fees_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref collect_fees_instance, value); }
			}
			
			global::easy_school.exam_reports exam_reports_instance;
			bool exam_reports_isCreating;
			public global::easy_school.exam_reports exam_reports {
				[DebuggerStepThrough] get { return GetForm(ref exam_reports_instance, ref exam_reports_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref exam_reports_instance, value); }
			}
			
			global::easy_school.prints prints_instance;
			bool prints_isCreating;
			public global::easy_school.prints prints {
				[DebuggerStepThrough] get { return GetForm(ref prints_instance, ref prints_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref prints_instance, value); }
			}
			
			global::easy_school.fees_rates fees_rates_instance;
			bool fees_rates_isCreating;
			public global::easy_school.fees_rates fees_rates {
				[DebuggerStepThrough] get { return GetForm(ref fees_rates_instance, ref fees_rates_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref fees_rates_instance, value); }
			}
			
			global::easy_school.Form1 Form1_instance;
			bool Form1_isCreating;
			public global::easy_school.Form1 Form1 {
				[DebuggerStepThrough] get { return GetForm(ref Form1_instance, ref Form1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref Form1_instance, value); }
			}
			
			global::easy_school.mdyfrmparents mdyfrmparents_instance;
			bool mdyfrmparents_isCreating;
			public global::easy_school.mdyfrmparents mdyfrmparents {
				[DebuggerStepThrough] get { return GetForm(ref mdyfrmparents_instance, ref mdyfrmparents_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref mdyfrmparents_instance, value); }
			}
			
			global::easy_school.Fees_Admin Fees_Admin_instance;
			bool Fees_Admin_isCreating;
			public global::easy_school.Fees_Admin Fees_Admin {
				[DebuggerStepThrough] get { return GetForm(ref Fees_Admin_instance, ref Fees_Admin_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref Fees_Admin_instance, value); }
			}
			
			global::easy_school.mdparent mdparent_instance;
			bool mdparent_isCreating;
			public global::easy_school.mdparent mdparent {
				[DebuggerStepThrough] get { return GetForm(ref mdparent_instance, ref mdparent_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref mdparent_instance, value); }
			}
			
			global::easy_school.fee_statement fee_statement_instance;
			bool fee_statement_isCreating;
			public global::easy_school.fee_statement fee_statement {
				[DebuggerStepThrough] get { return GetForm(ref fee_statement_instance, ref fee_statement_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref fee_statement_instance, value); }
			}
			
			global::easy_school.view_all view_all_instance;
			bool view_all_isCreating;
			public global::easy_school.view_all view_all {
				[DebuggerStepThrough] get { return GetForm(ref view_all_instance, ref view_all_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref view_all_instance, value); }
			}
			
			global::easy_school.report report_instance;
			bool report_isCreating;
			public global::easy_school.report report {
				[DebuggerStepThrough] get { return GetForm(ref report_instance, ref report_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref report_instance, value); }
			}
			
			global::easy_school.Form2 Form2_instance;
			bool Form2_isCreating;
			public global::easy_school.Form2 Form2 {
				[DebuggerStepThrough] get { return GetForm(ref Form2_instance, ref Form2_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref Form2_instance, value); }
			}
			
			global::easy_school.edit_students edit_students_instance;
			bool edit_students_isCreating;
			public global::easy_school.edit_students edit_students {
				[DebuggerStepThrough] get { return GetForm(ref edit_students_instance, ref edit_students_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref edit_students_instance, value); }
			}
			
			global::easy_school.students_fees students_fees_instance;
			bool students_fees_isCreating;
			public global::easy_school.students_fees students_fees {
				[DebuggerStepThrough] get { return GetForm(ref students_fees_instance, ref students_fees_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref students_fees_instance, value); }
			}
			
			global::easy_school.Form5 Form5_instance;
			bool Form5_isCreating;
			public global::easy_school.Form5 Form5 {
				[DebuggerStepThrough] get { return GetForm(ref Form5_instance, ref Form5_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref Form5_instance, value); }
			}
			
			global::easy_school.classes classes_instance;
			bool classes_isCreating;
			public global::easy_school.classes classes {
				[DebuggerStepThrough] get { return GetForm(ref classes_instance, ref classes_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref classes_instance, value); }
			}
			
			global::easy_school.login1 login1_instance;
			bool login1_isCreating;
			public global::easy_school.login1 login1 {
				[DebuggerStepThrough] get { return GetForm(ref login1_instance, ref login1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref login1_instance, value); }
			}
			
			global::easy_school.bill_student bill_student_instance;
			bool bill_student_isCreating;
			public global::easy_school.bill_student bill_student {
				[DebuggerStepThrough] get { return GetForm(ref bill_student_instance, ref bill_student_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref bill_student_instance, value); }
			}
			
			global::easy_school.teachers_attendance teachers_attendance_instance;
			bool teachers_attendance_isCreating;
			public global::easy_school.teachers_attendance teachers_attendance {
				[DebuggerStepThrough] get { return GetForm(ref teachers_attendance_instance, ref teachers_attendance_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref teachers_attendance_instance, value); }
			}
			
			global::easy_school.teachers_main teachers_main_instance;
			bool teachers_main_isCreating;
			public global::easy_school.teachers_main teachers_main {
				[DebuggerStepThrough] get { return GetForm(ref teachers_main_instance, ref teachers_main_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref teachers_main_instance, value); }
			}
			
			global::easy_school.admin_fee admin_fee_instance;
			bool admin_fee_isCreating;
			public global::easy_school.admin_fee admin_fee {
				[DebuggerStepThrough] get { return GetForm(ref admin_fee_instance, ref admin_fee_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref admin_fee_instance, value); }
			}
			
			global::easy_school.class_assgn class_assgn_instance;
			bool class_assgn_isCreating;
			public global::easy_school.class_assgn class_assgn {
				[DebuggerStepThrough] get { return GetForm(ref class_assgn_instance, ref class_assgn_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref class_assgn_instance, value); }
			}
			
			global::easy_school.class_teachers class_teachers_instance;
			bool class_teachers_isCreating;
			public global::easy_school.class_teachers class_teachers {
				[DebuggerStepThrough] get { return GetForm(ref class_teachers_instance, ref class_teachers_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref class_teachers_instance, value); }
			}
			
			global::easy_school.teacher_view teacher_view_instance;
			bool teacher_view_isCreating;
			public global::easy_school.teacher_view teacher_view {
				[DebuggerStepThrough] get { return GetForm(ref teacher_view_instance, ref teacher_view_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref teacher_view_instance, value); }
			}
			
			global::easy_school.teacher teacher_instance;
			bool teacher_isCreating;
			public global::easy_school.teacher teacher {
				[DebuggerStepThrough] get { return GetForm(ref teacher_instance, ref teacher_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref teacher_instance, value); }
			}
			
			global::easy_school.teachers_attendance_report teachers_attendance_report_instance;
			bool teachers_attendance_report_isCreating;
			public global::easy_school.teachers_attendance_report teachers_attendance_report {
				[DebuggerStepThrough] get { return GetForm(ref teachers_attendance_report_instance, ref teachers_attendance_report_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref teachers_attendance_report_instance, value); }
			}
			
			[DebuggerStepThrough]
			static T GetForm<T>(ref T instance, ref bool isCreating) where T : Form, new()
			{
				if (instance == null || instance.IsDisposed) {
					if (isCreating) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					isCreating = true;
					try {
						instance = new T();
					} catch (System.Reflection.TargetInvocationException ex) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message }), ex.InnerException);
					} finally {
						isCreating = false;
					}
				}
				return instance;
			}
			
			[DebuggerStepThrough]
			static void SetForm<T>(ref T instance, T value) where T : Form
			{
				if (instance != value) {
					if (value == null) {
						instance.Dispose();
						instance = null;
					} else {
						throw new ArgumentException("Property can only be set to null");
					}
				}
			}
		}
	}
	
	partial class MyApplication : WindowsFormsApplicationBase
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
			MyProject.Application.Run(args);
		}
	}
	
	partial class MyComputer : Computer
	{
	}
}
