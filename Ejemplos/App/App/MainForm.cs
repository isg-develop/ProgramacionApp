/*
 * Created by SharpDevelop.
 * User: elite
 * Date: 28/10/2016
 * Time: 10:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using App.factory;
using App.prototype;
using App.Singleton;

namespace App
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//Inicializa el formulario
			InitializeComponent();
		}
		
		void BtnSingletonClick(object sender, EventArgs e)
		{
			//Instancia singleton
			BaseMDIForm1 ventana = BaseMDIForm1.GetInstance();
			ventana.StartPosition = FormStartPosition.CenterScreen;		
			ventana.Show();
		}
		
		void BtnFactoryMethodClick(object sender, EventArgs e)
		{
			//Ver formulario
			FacturaForm ventana = new FacturaForm();
			ventana.StartPosition = FormStartPosition.CenterScreen;		
			ventana.Show();
		}
		
		void BtnPrototypeClick(object sender, EventArgs e)
		{
			// Ver formulario
			PrototypeForm ventana = new PrototypeForm();
			ventana.StartPosition = FormStartPosition.CenterScreen;		
			ventana.Show();	
		}
	}
}
