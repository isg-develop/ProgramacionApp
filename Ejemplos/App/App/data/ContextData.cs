
using System;
using MySql.Data.MySqlClient;

namespace App.data
{
	/// <summary>
	/// Description of ContextData.
	/// </summary>
	public class ContextData
	{
		public ContextData()
		{
		}
		
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
	}
}
