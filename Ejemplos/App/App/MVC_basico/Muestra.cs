/*
 * Created by SharpDevelop.
 * User: lite
 * Date: 29/10/2016
 * Time: 04:57 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace App.MVC_basico
{
	/// <summary>
	/// Muestra es un objeto sin controles (Funciona como contenedor).
	/// </summary>
	public class Muestra
	{
		//propiedades
        public int X { get; set; }
        public int Y { get; set; }
        
        //constructor del objeto
        public Muestra(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
	}
}
