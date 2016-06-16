/*
 * Created by SharpDevelop.
 * User: dimon
 * Date: 06.06.2016
 * Time: 21:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace winApp1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	  
	public partial class MainForm : Form
	{
		
		String dir = "";
		String net_pach = "";
		String cur_date ="";
		String ver = "";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}
		
		void add_log(String text)
		{
			log.Text += text + "\r\n";
		}
		
		void set_var() {
			net_pach = @"\\serversoft\РКК-Энергия\РелизыОбщепит";
			cur_date = DateTime.Now.ToString("dd.MM.yyyy");
			ver = textVer.Text.Trim(' ');
			dir = net_pach + @"\4У_" + ver + "_от_" + cur_date;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			if (!log.Text.Equals(""))
				add_log("-------------------------------------");
			
			if (textVer.Text.Trim(' ').Equals("")) {
				add_log("ОШИБКА: Не указан номер релиза");
				return;
			}
			
			set_var();
			
			DirectoryInfo new_ver = new DirectoryInfo(dir);
			if (!new_ver.Exists) {
				new_ver.Create();
				add_log("СОЗДАНА ПАПКА: " + dir);
			} else {
				add_log("ОШИБКА: Релиз с таким номером уже был, так как существует папка " + dir);
				return;
			}
			
			try {
				String f1 = net_pach + @"\шаблон\ОписаниеРелиза_4У_030_14.03.2016.xls";
				String f2 = dir + @"\ОписаниеРелиза_4У_" + ver + "_" + cur_date + ".xls";
				File.Copy(f1, f2);
				add_log("СКОПИРОВАН ФАЙЛ: " + f2);
			} catch (Exception e1) {
				add_log("ОШИБКА " + e1);
				return;
			}
			
				
			String f = dir + @"\1Cv8_Общепит_4У_" + ver + "_" + cur_date + ".cf";
			File.Create(f);
			add_log("СОЗДАН ФАЙЛ: " + f);
			
			add_log("ВСЕ ГОТОВО");
			
						
		}
		void Button2Click(object sender, EventArgs e)
		{
			set_var();
			DirectoryInfo dir_rel = new DirectoryInfo(dir);
			if (dir_rel.Exists) {
				Process.Start(dir);
			} else {
				Process.Start(net_pach);
			}
						
		}
		

	}
}
