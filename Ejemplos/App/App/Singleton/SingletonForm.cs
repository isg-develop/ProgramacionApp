/*
 * Creado por SharpDevelop.
 * Usuario: elite
 * Fecha: 28/10/2016
 * Hora: 11:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.Singleton
{
	/// <summary>
	/// Description of SingletonForm.  Solo permite crea un solo formulario (instancia) a la vez
	/// </summary>
	public sealed partial class SingletonForm : Form
	{
		private static  SingletonForm instance = null;
        public static SingletonForm GetInstance()
        {
            //Regresa  una nueva instancia la primera vez
            if (instance == null  || instance.IsDisposed)
            {
                instance = new SingletonForm();
            }
			//En caso contrario regresa la instancia ya creada anteriormente
            return instance;
        }
        
		private SingletonForm()
		{
			//Inicializa el formulario
			InitializeComponent();
		}
		
		void BtnValidarClick(object sender, EventArgs e)
		{
			var nombre = txtNombre.Text;
			MessageBox.Show(nombre);
		}
	}
}
