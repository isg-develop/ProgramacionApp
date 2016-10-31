/*
 * Created by SharpDevelop.
 * User: elite
 * Date: 28/10/2016
 * Time: 10:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using App.factory;
using App.Galería;
using App.Juegos;
using App.prototype;
using App.Singleton;
using App.MVC_basico;
using App.WinFormEvent;
using App.Pong;

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
		
		//Procedimiento generico
		private void VerFormulario(Form ventana){
			ventana.StartPosition = FormStartPosition.CenterScreen;		
			ventana.Show();			
		}
		
		#region Patron de diseño
		//Todo el siguiente contenido solo se agrupan en una region 
		//No afecta en nada al proceso.
		
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
			
			void BtnAbstractFactoryClick(object sender, EventArgs e)
			{
				//Apartir de aqui estoy utilizando un metodo generico
				VerFormulario(new FacturaForm());
		
			}
			
			void BtnPrototypeClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new PrototypeForm());
			}
			
			void BtnMVCClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new VistaForm());
			}
		
		#endregion
		
		
		#region Eventos Windows Forms
		
			void BtnDrawClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new DrawingForm());
			}
			void BtnLimiteClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new LimitesForms());
			}
			void BtnTimerClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new NubesForm());
			}
			void BtnKeyPressClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new TecladoPressForm());
			}
			void BtnInterceptClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new DrawInterceptionForm());
			}
		
		#endregion
		
		
		#region MiniApps
		
			void BtnPictureClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new LoadPicture());
			}
			void BtnLineasClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new DrawingForm());
			}
			void BtnPongClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new PongForms());
			}
			void BtnSnakeClick(object sender, EventArgs e)
			{
				// Ver formulario
				VerFormulario(new SnakeForm());
			}
		
		#endregion
	}
}
