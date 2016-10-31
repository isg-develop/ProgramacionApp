using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.Pong
{
	
	public partial class PongForms : Form
	{
		 Graphics grafico;
        Tabla mytabla;
        Pelota pelota;
        // Color de Pantala y Goma deben iguales
        Color fondo_pantalla = Color.White;
        Brush goma = Brushes.White;
        
		public PongForms()
		{
			//Init form
			InitializeComponent();
			
			//config
			grafico = pictureBox1.CreateGraphics();
			
			//Inicializamos nuestro juego:
			 mytabla = new Tabla() { eje_X = 100, eje_Y = 300, tamaño = new Size(60, 8), direccion_X=1, velocidad=10 };
        	 pelota = new Pelota() { eje_X = 200, eje_Y = 200, tamaño = new Size(20, 20), direccion_X=1, direccion_Y = 1, velocidad = 10 };
			
            //Fondo DEL FORMULARIO (Borra linea)
            pictureBox1.BackColor = fondo_pantalla;
            
            //Ponemos un fondo de pantalla
            //BackgroundImage = App.Properties.Resource.pong;
        	//BackgroundImageLayout = ImageLayout.Stretch;
        	
        	//Iniciamos el juego
        	timer1.Interval = 20; // 500 = 0.5seg
        	timer1.Enabled = true;
		}
				
		
		void Timer1Tick(object sender, EventArgs e)
		{
			//Borra linea
            grafico.FillRectangle(goma, mytabla.GetFigura);
            //validamos paredes o limites
            limiteParedTabla();
            //Ejecutamos movimiento
            Movimiento_tabla();
            //Volvemos a pinta nueva posición
            grafico.FillRectangle(Brushes.Black, mytabla.GetFigura);
                    
            //Borra pelota
            grafico.FillEllipse(goma, pelota.GetFigura);          
            //validamos rebote
            rebotePelota();
            //validamos paredes o limites
            limiteParedPelota();
            //Ejecutamos movimiento de pelota
            MovimientoPelota();
            //Volvemos a pinta nueva posición
            grafico.FillEllipse(Brushes.Brown, pelota.GetFigura);
		}
		
		#region Raqueta
		
			//Validar movimiento de la Raqueta
			void PongFormsKeyDown(object sender, KeyEventArgs e)
			{
				 //digimos a la derecha para la raqueta
	            if (e.KeyCode == Keys.Right) {
	                mytabla.direccion_X = 1;
	            }
	
	            //digimos a la izquierda  para la raqueta
	            if (e.KeyCode == Keys.Left)
	            {
	                mytabla.direccion_X = 0;
	            }
			}
			
			private void Movimiento_tabla() {
	            //Movimiento a la derecha
	            if (mytabla.direccion_X == 1)
	                mytabla.eje_X += mytabla.velocidad;
	            //Movimiento a la izquierda
	            if (mytabla.direccion_X == 0)
	                mytabla.eje_X -= mytabla.velocidad;
	        }
			
			private void limiteParedTabla()
	        {
	            //limite izquierda
	            if (mytabla.eje_X <= 0)
	                mytabla.direccion_X = 1;
	            //limite derecha
	            if (mytabla.eje_X >= (pictureBox1.Width - mytabla.GetAncho()))
	                mytabla.direccion_X = 0;           
        	}
			
		#endregion
		
		#region dibujapelota
		//Validar movimientos
		
	        private void MovimientoPelota()
	        {
	            //Movimiento a la derecha
	            if (pelota.direccion_X == 1)
	                pelota.eje_X += pelota.velocidad;
	            //Movimiento a la izquierda
	            if (pelota.direccion_X == 0)
	                pelota.eje_X -= pelota.velocidad;
	
	            //Movimiento a la arriba
	            if (pelota.direccion_Y == 1)
	                pelota.eje_Y += pelota.velocidad;
	            //Movimiento a la abajo
	            if (pelota.direccion_Y == 0)
	                pelota.eje_Y -= pelota.velocidad;
	        }
	
	        private void limiteParedPelota () {
	            //limite izquierda
	            if (pelota.eje_X <= 0)
	                pelota.direccion_X = 1;
	            
	            //limite derecha
	            if (pelota.eje_X >= (pictureBox1.Width - pelota.GetDiametro()))
	                pelota.direccion_X = 0;
	            
	            //limite arriba
	            if (pelota.eje_Y <= 0)
	                pelota.direccion_Y = 1;
	            
	            //limite abajo
	            if (pelota.eje_Y >= pictureBox1.Height - pelota.GetDiametro())
	                pelota.direccion_Y = 0;
	        }
	
	        private void rebotePelota()
	        {
	        	//Valida una posible intersepción
	            if (pelota.GetFigura.IntersectsWith(mytabla.GetFigura))
	            {
	                // si pelota colisiona con barra - cambia dirección
	                if (pelota.direccion_Y == 0)
	                {
	                    pelota.direccion_Y = 1;
	                }
	                else if (pelota.direccion_Y == 1)
	                {
	                    pelota.direccion_Y = 0;
	                }
	                
	            }
	        }
		
		#endregion
		
	}
}