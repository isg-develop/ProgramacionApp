/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 29/10/2016
 * Hora: 06:06 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.MVC_basico
{
	/// <summary>
	/// Description of VistaForm.
	/// </summary>
	public partial class VistaForm : Form
	{
		public VistaForm()
		{
			//Inicialiador
			InitializeComponent();
			//Tamaño mínimo del formulario
            this.MinimumSize = new Size(600, 500);

		}
		
		
		void VistaFormLoad(object sender, EventArgs e)
		{
			//Inicializamos la vista con datos
            LoaData();

		}
		
		private void LoaData() {
            //Buscamos datos
            Controlador.LoadData();
            //Asignamos los datos a un bindingDataSource
            bindingSource1.DataSource = Controlador.GetDataList();


            //Asignamos el binding a un dataGridView para ver los datos
            dataGridView1.DataSource = bindingSource1;
            //Ajustamos el contenido a la ventana
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //Ajustamos el pictureBox al tamaño de la ventana
            pictureBox1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));


        }            

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            //Dibujamos mediante el controlador
            Controlador.GetGrafico(img, e);
        }


        private void btnGraficar_Click(object sender, EventArgs e)
        {
            //Actualizamos el dibujo mediante el evento Paint
            pictureBox1.Refresh();
        }


        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            //Actualizamos el dibujo mediante el evento Paint
            pictureBox1.Refresh();
        }

        //#región Mouse_Move - Punto de un gráfico
        //Inicia movimiento de un punto en el gráfico
        Point PuntoModificadoY; //= new Point(-10,-10);
        int LastY;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            //obtenemos X y se guarda temporalmente
            int pointX = e.X * Controlador.numeroMuestras /  img.Width;
            //validacion de puntos
            if (pointX >= 0 && pointX < Controlador.numeroMuestras)
            {
                //Establecemos el nuevo punto
                PuntoModificadoY = Controlador.GetValorXY(pointX);
                LastY = e.Y;
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            if (PuntoModificadoY != null)
            {
                PuntoModificadoY.Y += (int)((e.Y - LastY) / ((double)img.Height / Controlador.limiteValido));
                LastY = e.Y;
                //Actualizamos el punto modificado
                Controlador.SetPuntoModificado(PuntoModificadoY);
                //Dibujamos nuevamente el grafico
                pictureBox1.Refresh();
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        	PuntoModificadoY = new Point(-10,-10);
        }
        //Finaliza movimiento de un punto
        //#endregion


	//Finaliza el windows forms
	}
}
