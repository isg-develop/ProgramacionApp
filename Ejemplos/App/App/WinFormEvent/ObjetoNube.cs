using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WinFormEvent
{	
	public class ObjetoNube
	{
		 //Dibujo
		 Graphics areatrabajo;
		 Pen lapiz;
		 Brush brochaAmarilla;
		 Brush brochaBlanca;
		 
		 public ObjetoNube(){
		  	lapiz = new Pen(Color.Red, 4.5f);
		  	brochaAmarilla = Brushes.Yellow;
		  	brochaBlanca = Brushes.White;
		 }
		  
		public void DibujarNube(int velocidad, int ejeX, int ejeY, Form formulario)
		{
			areatrabajo = formulario.CreateGraphics();
            areatrabajo.Clear(Color.CornflowerBlue);
            
            //Dibujo de sol
            int ubiSol = formulario.Width-300;
            Rectangle sol = new Rectangle(){ 
            	Size = new Size(200, 200), Location = new Point(ubiSol, 100)
            };
            areatrabajo.FillEllipse(brochaAmarilla, sol);
            
            
            //Base para nubes
            Rectangle cuadro = new Rectangle();
            cuadro.Size = new Size(200, 100);
            cuadro.Location = new Point(100, 100);
           
            //primer circunferencia -nube
            cuadro.X = ejeX + 100;
            cuadro.Y = ejeY  + 100;
            cuadro.Width = 200;
            areatrabajo.FillEllipse(brochaBlanca, cuadro);
            
            //tercera circunferencia -nube
            cuadro.X = ejeX + 350;
            cuadro.Y = ejeY + 100;
            areatrabajo.FillEllipse(brochaBlanca, cuadro);
           
            
            //segunda circunferencia -nube
            cuadro.X = ejeX + 200;
            cuadro.Height = 150;
            cuadro.Width = 280;
            cuadro.Y = ejeY + 80;
            areatrabajo.FillEllipse(brochaBlanca, cuadro);
            
		}
	}
	
	
}
