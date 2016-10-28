using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.factory
{
    class FacturaIvaReducido:Factura
    {
    	//Heredar - Factory Method Modificando el original
        public override double getImporteIva()
        {
            return Importe * 1.05;
        }
    }
}
