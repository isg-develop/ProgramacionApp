
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.TorreLineas
{
	public partial class LineaTorreForm : Form
	{
		public LineaTorreForm()
		{
			//Init form
			InitializeComponent();
		}
		
		void BtnGraficarClick(object sender, EventArgs e)
		{
			Graphics canvas = pictureBox1.CreateGraphics();
			canvas.Clear(Color.CornflowerBlue);
			DibujarSol(canvas);
			int totalPasos = 10;
			int.TryParse(txtNumLineas.Text, out totalPasos);
			DibujarLinea(canvas,totalPasos);
		}
		
		void DibujarSol(Graphics canvas){
			canvas.FillEllipse(Brushes.WhiteSmoke, new Rectangle(){Location=new Point(pictureBox1.Size.Width-155,-68), Size=new Size(210, 210)});
			canvas.FillEllipse(Brushes.Yellow, new Rectangle(){Location=new Point(pictureBox1.Size.Width-150,-60), Size=new Size(200, 200)});
		}
		
		void DibujarLinea(Graphics canvas, int totalPasos){
			//		
			if (totalPasos == 0) return;
			int destinoY = pictureBox1.Height;
			int espacioSalto = (pictureBox1.Height)/totalPasos;
			
			for (int i = 0; i <= totalPasos; i++) {
				int initY = 2 + (i*espacioSalto);
				int endX  = 2 + (i*espacioSalto);
				CrearLinea(canvas, 0, initY, endX, destinoY);
			}
		}
				
		void CrearLinea(Graphics canvas, int iniX, int iniY, int endX, int endY){
			Point origen = new Point(iniX, iniY);
			Point destino = new Point(endX, endY);
			canvas.DrawLine(new Pen(Color.Green, 3.5f), origen, destino);
		}
	}
}
