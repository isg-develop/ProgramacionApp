/*
 * Creado por SharpDevelop.
 * Usuario: elite
 * Fecha: 28/10/2016
 * Hora: 10:39 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.Singleton
{
	/// <summary>
	/// Description of BaseMDIForm1.
	/// </summary>
	public sealed partial class BaseMDIForm1 : Form
	{
		private static  BaseMDIForm1 instance = null;
        public static BaseMDIForm1 GetInstance()
        {
            //Regresa  una nueva instancia la primera vez
            if (instance == null || instance.IsDisposed)
            {
                instance = new BaseMDIForm1();
            }
			//En caso contrario regresa la instancia ya creada anteriormente
            return instance;
        }
        
		private BaseMDIForm1()
		{
			//Inicializa
			InitializeComponent();
		}
		
		//Item1
		void NormalToolStripMenuItemClick(object sender, EventArgs e)
		{
			NormalForm ventana = new NormalForm();
			ventana.MdiParent = this;
			ventana.Show();
		}
		//Item2
		void SingletonToolStripMenuItemClick(object sender, EventArgs e)
		{
			SingletonForm ventana = SingletonForm.GetInstance();
			ventana.MdiParent = this;
			//Lanza el formulario al frente
			ventana.BringToFront();
			ventana.Show();
		}
	}
}
