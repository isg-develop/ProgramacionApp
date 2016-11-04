/*
 * Created by SharpDevelop.
 * User: elite
 * Date: 29/10/2016
 * Time: 04:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace App.MVC_basico
{
	/// <summary>
	/// Modelo es un Objeto o Listado de objetos.
	/// </summary>
	public class Modelo
	{		
		//Listado de objetos
	    public List<Muestra> pointsList { get; set; }
	
	
	    //agregar un nuevo objeto
	    public void AddPoint( int y )
	    {
	       //   --Agrega una muestra en (x,y)
	       pointsList.Add(new Muestra(pointsList.Count, y));
	    }
	
	
	    //modificar un objeto
	    public void UpdatePoint(int valorX, int valorY, Muestra lastPoint)
	    {
	       int index = pointsList.FindIndex(a => a.X == lastPoint.X);
	       //   --Eliminamos el valor
	       pointsList.Remove(lastPoint);
	       //   --Agrega una muestra en el mismo index (x,y)
	       pointsList.Insert(index, new Muestra(valorX, valorY));           
	    }
	
	
        //constructor inicializa nuestro listado
       
 		public Modelo()
        {
         pointsList = new List<Muestra>();
        }

        public void Initialize( int Points, int MaxValue )
        {
	        //Genera automáticamente un TEST de validación
	        for ( int p = 0; p < Points; p++ )
	        AddPoint( (int)( MaxValue/2 + Math.Sin( 2 * Math.PI * p/Points ) * MaxValue/2 ) );
        }

	}
}
