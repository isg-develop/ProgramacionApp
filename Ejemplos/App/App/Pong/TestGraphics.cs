using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Pong
{
    public partial class TestGraphics : Form
    {
        Graphics grafico;
        int direccion_X = 1;
        int velocidad = 10;
        Rectangle cuadro1 = new Rectangle();
        public TestGraphics()
        {
            InitializeComponent();
            //Valores iniciales
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 600);
            this.BackColor = Color.White;
            //Creamos un grafico en todo el formulario
            grafico = CreateGraphics();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            cuadro1.Height = 100;
            cuadro1.Width = 100;
            cuadro1.X = 0;
            cuadro1.Y = 0;
            grafico.FillRectangle(Brushes.Beige, cuadro1);
            timer1.Start();
        }
        private void Dibujar() {
            grafico.TranslateClip(600, 600);
            //grafico.FillRectangle(Brushes.Beige, cuadro1);
        }
        private void TestGraphics_KeyDown(object sender, KeyEventArgs e)
        {
            //digimos a la derecha
            if (e.KeyCode == Keys.Right)
            {
                direccion_X = 1;
            }

            //digimos a la izquierda
            if (e.KeyCode == Keys.Left)
            {
                direccion_X = 0;
            }
        }

        private void Movimiento_tabla()
        {
            //Movimiento a la derecha
            if (direccion_X == 1)
                cuadro1.X += velocidad;
            //Movimiento a la izquierda
            if (direccion_X == 0)
                cuadro1.X -= velocidad;
            //Dibujar
            Dibujar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Movimiento_tabla();
        }

        private void TestGraphics_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
