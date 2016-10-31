/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 29/10/2016
 * Hora: 11:49 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WinFormEvent
{
	/// <summary>
	/// Description of DrawInterceptionForm.  Validamos un choque entre figuras
	/// </summary>
	public partial class DrawInterceptionForm : Form
	{
		//Variables globales
		Rectangle player1;
		Rectangle enemigo;
		Graphics  areatrabajo;
		bool saltaPlayer1;
		int volando=0; //Realiza un tiro circular
		int conteo = -2; //Conteo arriba-abajo del tiro cirular
		int gravedad;
		int nivel = 0;
		
		
		public DrawInterceptionForm()
		{
			//Init form
			InitializeComponent();
			
			//Dibujamos un punto inicial
			areatrabajo = pictureBox1.CreateGraphics();
			
			//Establecemos el tiempo de salto Player1
			saltaPlayer1 = false;
			
			int lineaJuego = pictureBox1.Height-160;
			player1 = new Rectangle(){X = 100, Y= lineaJuego+20, Width= 40, Height = 40};
			enemigo = new Rectangle(){X = pictureBox1.Width+100, Y= lineaJuego, Width= 50, Height = 60};					
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{		
			//coloreamos fondo
			areatrabajo.Clear(Color.CornflowerBlue);
			
			//Base
			Rectangle pisoBase = new Rectangle(){X = 0, Y= pictureBox1.Height-100, Width= pictureBox1.Width, Height = 100};
			areatrabajo.FillRectangle(Brushes.Green, pisoBase);	
			
			enemigo.X -= 20;			
			//Dibujamos el cambio 
			DibujarEnemigo();
			DibujarPlayer();
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
			//validar salto
			if (saltaPlayer1 == true){
				//Salto
				int MaxValue = 110; int puntos = 6;
				if (conteo < puntos){					
					if (volando+10  > MaxValue){
						if (gravedad > 2){
							gravedad = 0;
							volando = ( (int)( MaxValue/2 + Math.Sin( 2 * Math.PI * conteo/puntos ) * MaxValue/2 ) );
							conteo++;
						}
						gravedad++;
					}else{
						volando = ( (int)( MaxValue/2 + Math.Sin( 2 * Math.PI * conteo/puntos ) * MaxValue/2 ) );	
						conteo++;						
					}	
				}
				else
				{
				 saltaPlayer1 = false;
				 conteo = 0;
				}
			}
		}
		
		void DibujarEnemigo(){							
			if (enemigo.X < 10){
			   enemigo.X = pictureBox1.Size.Width;
			}
			
			//conteo de nivel
			if (nivel > 25){
			    nivel = 0;
			    if (timer1.Interval < 30){
			      if (timer1.Interval > 4){
				      timer1.Interval  -= 4;
				   }
			    }else
			       timer1.Interval  -= 10;
			}
			//Enemigo
			areatrabajo.FillRectangle(Brushes.Red, enemigo);
						
		}
		
		int result = 0;
		void DibujarPlayer(){
			
			//Jugador
			if (saltaPlayer1 == true){
				Rectangle salto = player1;
				//Salto
				salto.Y = salto.Y - volando;
			  	areatrabajo.FillEllipse(Brushes.Yellow, salto);	
			  	//Valida choque
				if (enemigo.IntersectsWith(salto)){
					Detener();
			  	}else{
			  	  nivel++;; result++;
			  	  this.Text = "Tiempo de vuelo    Seg/3:"+ nivel + " Acumulado: " + result; 
			  	}
			}
			else
			{
			   areatrabajo.FillEllipse(Brushes.Yellow, player1);	
			   //Valida choque
				if (enemigo.IntersectsWith(player1)){
					Detener();
				}
			}					
		}
		
		
		void Detener(){
			nivel = -1000;
			timer2.Stop();
			timer1.Stop();				
			MessageBox.Show("Perdiste.!!!");
		}
		
		void DrawInterceptionFormKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
			    	this.Close();
			    	return;
            }
			
			//Salta Player 1
			if (e.KeyChar == Convert.ToChar(Keys.Space)) {
				saltaPlayer1 = true;
            }
			
			if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
				enemigo.X = pictureBox1.Size.Width;
				nivel = 0;
				timer2.Start();
				timer1.Start();	
            }
			
		}
		
		
		
		
	}
}
