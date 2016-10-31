/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 29/10/2016
 * Hora: 07:44 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WinFormEvent
{
	/// <summary>
	/// Permite crear objetos y despues agregarlos a un gráfico
	/// </summary>
	public partial class DrawingForm : Form
	{
		//Variables globales
		int ejeX = 10;
		int ejeY = 10;
		int ancho = 100;
		int alto = 100;
		Point ubicacion; //= new Point(ejeX, ejeY);
		Size tamaño; 	 //= new Size(ancho, alto);
		//Creamos un gráfico y lo asignamos a un PictureBox		
		Graphics areatrabajo; 
			
		public DrawingForm()
		{
			//Inicial Form
			InitializeComponent();
			
			//Iniciamos los puntos de referencia
			 ubicacion = new Point(ejeX, ejeY);
			 tamaño = new Size(ancho, alto);
		
			//Asignamos el area de dibujo:
			areatrabajo = pictureBox1.CreateGraphics();
			
			//Ajustamos el pictureBox al tamaño de la ventana
            pictureBox1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));

		}
					
		void BtnDibujarClick(object sender, EventArgs e)
		{
			Color color = GetColor();
			DibujarFigura(color);
			//Ajustamos la ubicaciones 
			ValidarUbicacion();
		}
		
		private void Punto(Color color){
			Point destino= new Point(ubicacion.X + ancho/2, ubicacion.Y + alto/2);
		    Rectangle cuadro = new Rectangle(){Location = destino, Width = 5, Height = 5};
			Brush brocha = new SolidBrush(color); // = Brushes.Black;
			areatrabajo.FillRectangle(brocha, cuadro);
		}
		
		private void Linea(Color color){
			Point origen = ubicacion;
			Point destino= new Point(ubicacion.X+ ancho, ubicacion.Y);
		   Rectangle cuadro = new Rectangle(){Location = ubicacion, Width = 5, Height = 5};
			Pen pluma = new Pen(color, 2.5f); // = Brushes.Black;
			areatrabajo.DrawLine(pluma,origen,destino);
		}
		
		private void Cuadro(Color color){
			Rectangle cuadro = new Rectangle(){Location = ubicacion, Size= tamaño};
			Brush brocha = new SolidBrush(color); // = Brushes.Black;
			areatrabajo.FillRectangle(brocha, cuadro);
		}
		
		private void Rectangulo(Color color){
			Size myTamaño = new Size(tamaño.Width, tamaño.Height/2);
			Rectangle cuadro = new Rectangle(){Location = ubicacion, Size= myTamaño};
			Brush brocha = new SolidBrush(color); // = Brushes.Black;
			areatrabajo.FillRectangle(brocha, cuadro);
		}
		
		private void Elipse(Color color){
			Size myTamaño = new Size(tamaño.Width, tamaño.Height/2);
			Rectangle cuadro = new Rectangle(){Location = ubicacion, Size= myTamaño};
			Brush brocha = new SolidBrush(color); // = Brushes.Black;
			areatrabajo.FillEllipse(brocha, cuadro);
		}
		
		private void Circunferencia(Color color){
			Rectangle cuadro = new Rectangle(){Location = ubicacion, Size= tamaño};
			Brush brocha = new SolidBrush(color); // = Brushes.Black;
			areatrabajo.FillEllipse(brocha, cuadro);
		}
		
		private void Triangulo(Color color){
			Point A = new Point(ubicacion.X, ubicacion.Y + alto);;
			Point B= new Point(ubicacion.X + ancho/2, ubicacion.Y);
			Point C= new Point(ubicacion.X + ancho, ubicacion.Y + alto);
		   Rectangle cuadro = new Rectangle(){Location = ubicacion, Width = 5, Height = 5};
			Pen pluma = new Pen(color, 2.5f); // = Brushes.Black;
			areatrabajo.DrawLine(pluma, A , B);
			areatrabajo.DrawLine(pluma, B , C);
			areatrabajo.DrawLine(pluma, A , C);
		}
		
		private void ValidarUbicacion(){
			//Incremento la ubicaciones en X
			ubicacion.X = ubicacion.X + (ancho + 10);
			
			//Validamos el límite derecho (Max ejeX)
			if (ubicacion.X  > pictureBox1.Width){
				ubicacion.Y = ubicacion.Y + (alto + 10);
				ubicacion.X = ejeX;
			}
			
			//Validamos el límite inferior (Max ejeY)
			if (ubicacion.Y > pictureBox1.Height){
				//Reset grafico
				areatrabajo.Clear(Color.White);
				ubicacion.Y = ejeY;
				ubicacion.X = ejeX;
			}
		}
		
		private Color GetColor(){		
			string colorString = (string) cboColor.SelectedItem;
			Color color = Color.Brown;
			
			switch (colorString) {
				case  "Rojo" :
				  color = Color.Red;
				break;
				case  "Negro" :
					color = Color.Black;
				break;
				case  "Blanco" :
					color = Color.White;
				break;
				case  "Azul" :
					color = Color.CornflowerBlue;
				break;
				case  "Naranja" :
				    color = Color.Orange;
				break;
				default:
					//Ponemos un color RGB - Rojo/Verde/Azul
				    color = Color.FromArgb(146,100,35);
				break;
			}
			//Regresamos con el color
			return color;
		}
		
		private void DibujarFigura(Color color){
			string figuraString = (string) cboFigura.SelectedItem;			
			switch (figuraString) {
				case  "Punto" :
					//Dibujamos un punto
					Punto(color);
				break;
				case  "Línea" :
					//Dibujamos una Linea
					Linea(color);
				break;
				case  "Cuadro" :
					//Dibujamos un Cuadro
					Cuadro(color);
				break;
				case  "Rectangulo" :
					//Dibujamos un Rectangulo
					Rectangulo(color);
				break;
				case  "Elipse" :
					//Dibujamos una Elipse
					 Elipse(color);
				break;
				case  "Circunferencia" :
					//Dibujamos una Circunferencia
					Circunferencia(color);
				break;
				case  "Triangulo" :
					//Dibujamos un Triangulo
					Triangulo(color);
				break;
				default:
					Rectangulo(Color.Green);
				break;
			}
		}
		//finaliza seleccionar figura
		
		
	}
	//Finaliza el windows forms
	
	
}
