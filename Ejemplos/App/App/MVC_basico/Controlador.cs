/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 29/10/2016
 * Hora: 06:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace App.MVC_basico
{
	/// <summary>
	/// Un controlador puede ser de dos tipo: Aislado o dependiente
	/// Este ejemplo es un controlador Aislado
	/// Un controlador dependiente debe tener el mismo nombre del formulario
	/// </summary>
	public static class Controlador
 {
        //Listado de modelos -- alternativa: a cada modelo
        // implementar un singleton para la persistencia de datos
        private static Modelo tModelo;
        public static int numeroMuestras = 50;
        public static int limiteValido = 100;
        private static int tamañoCuadro = 5; //5px


        public static void LoadData()
        {
            //Crear un nuevo modelo
            Modelo objeto = new Modelo();            
            //Inicializar con datos - NOTA: sustituir con Base de datos
            objeto.Initialize(numeroMuestras, limiteValido);
            //Lo asignamos al controlador
            Controlador.tModelo = objeto;
        }


        public static IList GetDataList() {
            return Controlador.tModelo.pointsList;
        }


        public static int GetValorY(int puntoX)
        {
            int puntoY=0;
            foreach (Muestra punto in tModelo.pointsList) {
                if (punto.X == puntoX) {
                    puntoY = punto.Y;
                    break;
                }
            }
            return puntoY;
        }


        //Regresa un punto seleccionado
        public static Point GetValorXY(int puntoX)
        {
            Point puntoXY = new Point(0,0);
            foreach (Muestra punto in tModelo.pointsList)
            {
                if (punto.X == puntoX)
                {
                    puntoXY = new Point(punto.X, punto.Y);
                    break;
                }
            }
            return puntoXY;
        }
        
		//Dibuja los valores en un gráfico
        public static void GetGrafico(PictureBox img, PaintEventArgs evento)
        {
            int totalRegistro = Controlador.GetDataList().Count;
            double xstep = (double)img.ClientRectangle.Width / totalRegistro;
            double ystep = (double)img.ClientRectangle.Height / Controlador.limiteValido;
            List<Rectangle> muestras = new List<Rectangle>();
            Pen lapiz = new Pen(Color.Red, 2);
            for (int puntoX = 0; puntoX < totalRegistro - 1; puntoX++)
            {
                //Creamos puntos
                int puntoY = Controlador.GetValorY(puntoX);
              muestras.Add(new Rectangle((int)(puntoX * xstep), (int)(puntoY * ystep), tamañoCuadro, tamañoCuadro));


                //alternativa - dibujar línea para unir punto
                using (Pen pn = new Pen(Color.Blue, 1))
                {
                    int puntoYFinal = Controlador.GetValorY(puntoX+1);
                    evento.Graphics.DrawLine(pn,
                        new PointF((int)(puntoX * xstep), (int)(puntoY * ystep)),
                        new PointF((int)((puntoX + 1) * xstep), (int)(puntoYFinal * ystep)));
                }
            }


            //Dibujamos los punto resultantes
            evento.Graphics.DrawRectangles(lapiz, muestras.ToArray());
           
        }


        //Actualiza un punto
        public static void SetPuntoModificado(Point nuevoValor)
        {
            foreach (Muestra puntoActual in tModelo.pointsList)
            {
                if (puntoActual.X == nuevoValor.X)
                {
                    tModelo.UpdatePoint(nuevoValor.X, nuevoValor.Y, puntoActual);
                    break;
                }
            }
        }






	//Final del controlador
	}
}
