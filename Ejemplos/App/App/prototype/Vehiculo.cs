using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App.prototype
{
    //Clase principal
    class Vehiculo : ICloneable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Rueda TipoRueda { get; set; }
        public Carroceria TipoCarroceria { get; set; }
         public bool isClonado { get; set; }
		
        public Vehiculo(){
        	TipoRueda = new Rueda();
        	TipoCarroceria = new Carroceria();
        }
        
        public string VehiculoInfo()
        {
            StringBuilder sb = new StringBuilder();
            //Aqui se imprime el contenido que puede se clonado 
            sb.Append("Marca: ").Append(Marca).Append(Environment.NewLine);
            sb.Append("Modelo: ").Append(Modelo).Append(Environment.NewLine);
            sb.Append("Color: ").Append(Color).Append(Environment.NewLine);

            //Aqui se imprime el contenido de la subclase sin clonación  
            sb.Append("Ruedas: ").Append(TipoRueda.Llanta).Append(" ");
            sb.Append(TipoRueda.Diametro).Append(" ").Append(Environment.NewLine);

            //Aqui se imprime el contenido de la subclase sin clonación  
            sb.Append(TipoCarroceria.TipoCarroceria).Append(" ");
            sb.Append(TipoCarroceria.Material).Append(Environment.NewLine);

            return sb.ToString();
        }

        #region ICloneable Members
        //Dentro de la región o bloque de código
        public  object Clone()
        {
            // Obtenermos una copia superficial del objeto actual
            object copia = this.MemberwiseClone();

            // Recorremos las propiedades del objeto buscando elementos clonables.
            // En caso de encontrar un objeto clonable, realizamos una copia de dicho elemento
            var propiedadesClonables = this.GetType().GetProperties().Where(p => p.PropertyType.GetInterfaces().Contains(typeof(ICloneable)));
            foreach (var propiedad in propiedadesClonables)
            {
                // Obtenemos el nombre de la propiedad (p.e. "TipoRueda")
                var nombrePropiedad = propiedad.Name;

                // Localizamos el método Clone() de la propiedad (TipoRueda.Clone()) y lo
                // invocamos mediante reflection, almacenando el objeto resultante en una variable
                MethodInfo metodoClone = propiedad.PropertyType.GetMethod("Clone");
                var objetoCopia = metodoClone.Invoke(propiedad.GetValue(copia,null), null);

                // Obtenemos una referencia a la propiedad del objeto clonado (Vehiculo2.TipoRueda)
                PropertyInfo referenciaCopia = this.GetType().GetProperty(nombrePropiedad, BindingFlags.Public | BindingFlags.Instance);

                // Asignamos el valor del objeto clonado a la referencia (Vehiculo2.TipoRueda = Rueda2)
                referenciaCopia.SetValue(copia, objetoCopia, null);
            }

            return copia;
        }

        #endregion
    }

    //Propiedad de la clase principal - subclase
     class Rueda : ICloneable
    {
        public int Diametro { get; set; }
        public string Llanta { get; set; }
     	
		public object Clone()
		{
			return this.MemberwiseClone();
		}
    }

    
}
