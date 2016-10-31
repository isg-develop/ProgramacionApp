/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 29/10/2016
 * Hora: 10:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WinFormEvent
{
	/// <summary>
	/// Description of KeyPressForm.
	/// </summary>
	public partial class TecladoPressForm : Form
	{
		//Variables globales
		int ejeX = 100;
		int ejeY = 100;
		Graphics  areatrabajo;
		//constructor
		public TecladoPressForm()
		{
			//Init form
			InitializeComponent();
			
			//Dibujamos un punto inicial
			areatrabajo = pictureBox1.CreateGraphics();
			Dibujar();
		}				
		
		void TecladoPressFormKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
			    	this.Close();
			    	return;
            }
			
			if (e.KeyChar == Convert.ToChar(Keys.Space)) { 
			    	areatrabajo.Clear(Color.White);
            }
			    
			string valor = Convert.ToString(e.KeyChar).ToLower();
			switch (valor) {
				case "a":					
                     ejeX -= 10; //atrás  - Izquierda
					break;
				case "d":					
                     ejeX += 10; //adelante  - Derecha
					break;
					
				case "w":					
                     ejeY -= 10; //up  - Arriba
					break;	
				case "s":
                     ejeY += 10; //down  - Abajo
					break;	
					
				default:					
					break;
			}
			
            //Dibujamos el cambio 
			Dibujar();
			this.Text = "(KeyPress) X:" + ejeX + " Y:" + ejeY;
		}
		
		
		void Dibujar(){
			//Limpiar
			Rectangle cuadro = new Rectangle(){X = ejeX, Y= ejeY, Width= 8, Height = 8};
			areatrabajo.FillEllipse(Brushes.Green, cuadro);				   	
		}
		
				
		void Timer1Tick(object sender, EventArgs e)
		{
			//Dibujamos un punto inicial
			Dibujar();
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			//Dibujamos un punto inicial
			Dibujar();
		}
	}
}
