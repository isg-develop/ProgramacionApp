﻿using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace App.data
{
    class TestConnection_MySQL
    {
        public static void TestConnection()
        {
            Console.WriteLine("Iniciando...");
            MySqlConnection conexion = null;
            //declaramos las variables         
            DataSet dataSet = null;
            MySqlDataAdapter dataAdapter = null;
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

                MySqlCommand cmd = new MySqlCommand();
                string consulta = "SELECT * From pelicula";
                dataAdapter = new MySqlDataAdapter(consulta, conexion); //traemos los datos en Adapter
                dataSet = new DataSet(); // creamos la consulta del objeto DataSet
                dataAdapter.Fill(dataSet, "tabla1");//llenamos el dataset
                conexion.Close();//cerramos la conexion
                Console.WriteLine("Conectado.");
            }
            catch (Exception ex)
            {
                //txtResult.Text += "  Error:. " + ex.Message;
                Console.WriteLine("Error en la conexión: " + ex.Message);
            }
            finally
            {
                if (conexion != null) conexion.Close();
            }
        }
        
        
        public static DataSet GetListado()
        {
            Console.WriteLine("Iniciando...");
            MySqlConnection conexion = null;
            //declaramos las variables         
            DataSet dataSet = null;
            MySqlDataAdapter dataAdapter = null;
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

                MySqlCommand cmd = new MySqlCommand();
                string consulta = "SELECT * From pelicula";
                dataAdapter = new MySqlDataAdapter(consulta, conexion); //traemos los datos en Adapter
                dataSet = new DataSet(); // creamos la consulta del objeto DataSet
                dataAdapter.Fill(dataSet, "pelicula");//llenamos el dataset
                conexion.Close();//cerramos la conexion
                Console.WriteLine("Conectado.");
            }
            catch (Exception ex)
            {
                //txtResult.Text += "  Error:. " + ex.Message;
                Console.WriteLine("Error en la conexión: " + ex.Message);
            }
            finally
            {
                if (conexion != null) conexion.Close();
            }
            
            return dataSet;
        }
    }
}