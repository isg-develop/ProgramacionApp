
using System;
using System.Data;

namespace App.data
{
	/// <summary>
	/// Description of Intefaz AlumnoControl.
	/// </summary>
	public interface  IAlumnoControl
	{
		//CRUD - Create/Read/Update/Delete
		bool CrearDato(object mydato);
		DataTable ObtenerListado();
		DataTable ObtenerListadoByID(int Id);
		bool ActualizarDato(object dato);
		bool BorrarDato(int Id);
	}
}
