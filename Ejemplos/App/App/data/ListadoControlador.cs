
using System;
using System.Collections;
using System.Data;

namespace App.data
{
	/// <summary>
	/// Description of ListadoControlador.
	/// </summary>
	public interface  ListadoControlador
	{
		 void CrearObjeto();
		 bool ActualizaObjeto();
		 bool BorrarObjeto();
		 object GetObjeto(int ID);
		 DataTable   GetTodos();
	}
}
