using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.factory
{
    public abstract class Factura
    {
        //Propiedades
        public int Id { get; set; }
        public double Importe { get; set; }
       
        //Metodo Abstracto - Factory Method Original
        public abstract double getImporteIva();
    }
}
