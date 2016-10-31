
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WinFormEvent
{
	
	public partial class LimitesForms : Form
	{
		 //Variable globales
        int ejeX = 0;
        int ejeY = 0;
        //Colores RGB - Rojo - Verde - Azul
        int colorRojo = 255;
        int colorVerde = 255;
        int colorAzul = 255;
        const int LimiteRGB = 255;
        
		public LimitesForms()
		{
			//Init
			InitializeComponent();
			
			//iniciamos el timer para dibujar
			timer1.Start();
		}
		
		private void ValidarUbicacion() {
            if (ejeX > this.Width) 
            {
                ejeX = 0;
            }
            if (ejeY > this.Height)
            {
                ejeY = 0;
            }
        }
		
		private int NumAleatorio(int min, int maxi){
			//regresa un numero entre 1 a 255
			Random rnd = new Random();
			double randomValue = rnd.NextDouble();
            double opr = randomValue * (maxi - min + 1);
            var resultado = Math.Floor(opr);
            return int.Parse(resultado+"");
		}
		
		private int ValorRGB(){
			return NumAleatorio(1, 255);
		}
		
		private Color GetColorRGB(){
			//Cambiamos los colores
			colorAzul =  NumAleatorio(150, 200);  //Disminuimos en uno
		    colorRojo =  NumAleatorio(100, 255);
		    colorVerde = NumAleatorio(100, 200);
		   //Construimos el color
		    return Color.FromArgb(colorRojo, colorVerde, colorAzul);
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			 Graphics area = CreateGraphics();
            //area.Clear(Color.Black);
            
            //construimos una brocha con un color diferente
            Brush brocha = new SolidBrush(GetColorRGB());
            
            //Creamos el objeto
            Rectangle punto = new Rectangle()
            {
                Location = new Point(ejeX, ejeY),
                Size = new Size(30, 30)
            };
            area.FillEllipse(brocha, punto);
            
            //Validamos una nueva ubicación
            ejeX += 5;
            ejeY += 50;
            ValidarUbicacion();
		}
		
		
		
		void LimitesFormsKeyPress(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Space) {
                if (timer1.Enabled)
                {
                    timer1.Stop();
                }
                else {
                    timer1.Start();
                }
            }
		}
	}
}
