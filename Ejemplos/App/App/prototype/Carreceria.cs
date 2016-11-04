
using System;

namespace App.prototype
{	
	//Propiedad de la clase principal - subclase
	public class Carroceria : ICloneable
	{
	    public string Material { get; set; }
	    public string TipoCarroceria { get; set; }
		
		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
		
	
}
