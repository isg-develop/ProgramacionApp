
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace App.data
{
	
	public class AlumnoControl : IAlumnoControl
	{
		ContextData db = new ContextData();
		public AlumnoControl()
		{
		}
		
		public bool CrearDato(object mydato)
		{
			//INSERT INTO `alumnos` (`Id`, `nombre`, `matricula`) VALUES (NULL, 'Ismael', 'db0db0');
			return true;
		}
				
		public DataTable ObtenerListado()
		{
			MySqlConnection conexion = db.GetConexion();
			MySqlCommand cmd = new MySqlCommand();
            string consulta = "SELECT * From alumnos";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(consulta, conexion); //traemos los datos en Adapter
            //DataSet dataSet = new DataSet(); // creamos la consulta del objeto DataSet
            //dataAdapter.Fill(dataSet, "pelicula");//llenamos el dataset
            DataTable dTable = new DataTable(); 
            dataAdapter.Fill(dTable);
            return dTable;
		}
		
		public DataTable ObtenerListadoByID(int Id)
		{
			MySqlConnection conexion = db.GetConexion();
			MySqlCommand cmd = new MySqlCommand();
            string consulta = "SELECT * From pelicula";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(consulta, conexion); //traemos los datos en Adapter
            //DataSet dataSet = new DataSet(); // creamos la consulta del objeto DataSet
            //dataAdapter.Fill(dataSet, "pelicula");//llenamos el dataset
            DataTable dTable = new DataTable(); 
            dataAdapter.Fill(dTable);
            return dTable;
		}
		
		public bool ActualizarDato(object dato)
		{
			return true;
		}
		
		public bool BorrarDato(int Id)
		{
			return true;
		}
	}
}
