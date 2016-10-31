/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 22/10/2016
 * Hora: 05:42 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WinFormEvent
{
	/// <summary>
	/// Description of NubesForm.
	/// </summary>
	public partial class NubesForm : Form
	{
	   //Variables globales
		int ejeX = 100;
        int ejeY = 150;
        
		public NubesForm()
		{
			//Crea nubes mediate objetos
			InitializeComponent();
		}
		
		//Validación inicial - cambia por cada clic 
		void BtnDibujarClick(object sender, EventArgs e)
		{
			int velocidad = 50; //paso de 50px
			Graphics areatrabajo = CreateGraphics();
            areatrabajo.Clear(Color.CornflowerBlue);
            Pen lapiz = Pens.Red;
            lapiz = new Pen(Color.Red, 4.5f);
            Rectangle cuadro = new Rectangle();
            cuadro.Size = new Size(200, 100);
            cuadro.Location = new Point(ejeX, ejeY);
            //areatrabajo.DrawRectangle(lapiz, cuadro);
            Brush brocha = Brushes.Yellow;
            //areatrabajo.FillRectangle(brocha, cuadro);
            cuadro.X = ejeX + 100;
            cuadro.Y = ejeY  + 100;
            cuadro.Width = 200;
            brocha = Brushes.White;
            areatrabajo.FillEllipse(brocha, cuadro);
            
            cuadro.X = ejeX + 350;
            cuadro.Y = ejeY + 100;
            areatrabajo.FillEllipse(brocha, cuadro);
      
            //segunda elipse
            cuadro.X = ejeX + 200;
            cuadro.Height = 150;
            cuadro.Width = 280;
            cuadro.Y = ejeY + 80;
            areatrabajo.FillEllipse(brocha, cuadro);
         
            ejeX = ejeX + velocidad;
            if (ejeX > this.Width) //límite derecho del forms
            {
                ejeX = -500;
            }
		}
		
		#region	Automatico_Timer	
			//  Mediante el proceso de la POO
			//  Crear objetos aleatoriamente			
			//  Proceso de automatico
			void Timer1Tick(object sender, EventArgs e)
			{
				 DibujarNube(5);
			}
			
			private void DibujarNube(int velocidad) 
	        {
	           ObjetoNube nube = new ObjetoNube();
	            nube.DibujarNube(velocidad, ejeX, ejeY, this);                                 
	            //modificamos el eje x
	            ejeX = ejeX + velocidad;
	            if (ejeX > this.Width)
	            {
	                ejeX = -500;
	            }
	        }
			
			
			void NubesFormKeyPress(object sender, KeyPressEventArgs e)
			{
				//Al presionar la tecla espaciadora se detiene/abanza
				 if ((Keys)e.KeyChar == Keys.Space)
	            {
	                if (timer1.Enabled) {
	                    timer1.Stop();
	                }else{
	                   timer1.Start();
	                }
	            }
			}
			
			void NubesFormKeyDown(object sender, KeyEventArgs e)
			{
				//Letra A  Mayusculas
	            if (e.KeyCode == Keys.A)
	            {
	                ejeY = ejeY + 10;
	            }
	            if (e.KeyCode == Keys.S)
	            {
	                ejeY = ejeY - 10;
	            }
			}
			
			void BtnActivarTimerClick(object sender, EventArgs e)
			{
				if (timer1.Enabled) {
	                    timer1.Stop();
                }else{
                   timer1.Start();
                }
			}
			
		  //finaliza automitico			
		#endregion
		
							
	}
}
