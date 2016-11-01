using System;

namespace App.AbstractFactory
{
	/// <summary>
	/// Description of FactoriaIngredientes.
	/// </summary>
	public class FactoriaIngredientes
	{
		public string harina {get; set;}
		public string ingrediente1 {get; set;}
		public string ingrediente2 {get; set;}
		public string ingrediente3 {get; set;}
		
		public FactoriaIngredientes()
		{
			harina = "100gr.";
		}
	}
}
