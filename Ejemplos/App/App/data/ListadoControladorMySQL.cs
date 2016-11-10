
using System;
using System.Collections;
using System.Data;

using MySql.Data.MySqlClient;

namespace App.data
{
	/// <summary>
	/// Description of ListadoControladorMySQL.
	/// </summary>
	public class ListadoControladorMySQL: ListadoControlador
	{
		public MySqlConnection GetConexion(){
		  MySqlConnection conexion = null;
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.Port = 3306;
                builder.UserID = "root";
                builder.Password = "";
                builder.Database = "cine";
               
                //Asigna y abre la conexión
                conexion = new MySqlConnection(builder.ToString());
                conexion.Open();
			}
            catch (Exception ex)
            {
                Console.WriteLine("Error en la conexión: " + ex.Message);
            }
            return conexion;
		}
		
		
		
		public ListadoControladorMySQL()
		{
		}
		
		public void CrearObjeto()
		{
			MySqlConnection conexion = GetConexion();
			string consulta = @"INSERT INTO `pelicula`
							( `Nombre`, `Sinopsis`, `Genero`, `myurl`, `video`)
					 VALUES ('Un nombre','Una sinopsis','Un genero','', ''); 	";
			
            MySqlCommand miComando = new MySqlCommand(consulta, conexion);  
            var resp = miComando.ExecuteReader();     // Here our query will be executed and data saved into the database.  
          	
		}
		
		public bool ActualizaObjeto()
		{
			MySqlConnection conexion = GetConexion();
			return true;
		}
		
		public bool BorrarObjeto()
		{
			MySqlConnection conexion = GetConexion();
			return true;
		}
		
		public object GetObjeto(int ID)
		{
			MySqlConnection conexion = GetConexion();
			MySqlCommand cmd = new MySqlCommand();
            string consulta = "SELECT * From pelicula Where Id = " + ID;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(consulta, conexion); //traemos los datos en Adapter
            //DataSet dataSet = new DataSet(); // creamos la consulta del objeto DataSet
            //dataAdapter.Fill(dataSet, "pelicula");//llenamos el dataset
            DataTable dTable = new DataTable(); 
            dataAdapter.Fill(dTable);
            return dTable;
		}
		
		public DataTable  GetTodos()
		{
			MySqlConnection conexion = GetConexion();
			MySqlCommand cmd = new MySqlCommand();
            string consulta = "SELECT * From pelicula";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(consulta, conexion); //traemos los datos en Adapter
            //DataSet dataSet = new DataSet(); // creamos la consulta del objeto DataSet
            //dataAdapter.Fill(dataSet, "pelicula");//llenamos el dataset
            DataTable dTable = new DataTable(); 
            dataAdapter.Fill(dTable);
            return dTable;
		}
	}
}
