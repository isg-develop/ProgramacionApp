using System;

namespace App.AbstractFactory
{
	/// <summary>
	/// Description of Pizza.
	/// </summary>
	public class Pizza
	{
		private FactoriaIngredientes ingrediente;
			
		public Pizza(FactoriaIngredientes fi)
		{
			ingrediente = fi;
		}
		
		public void cortar()
		{
			//Cortar
		}
		
		public void empaquetar()
		{
			//Empaquetar
		}
		
		public string entregar()
		{
			//Entregar
			return "  - Llega en 30 minutos o es gratis. !!!";
			
		}
	}
}
