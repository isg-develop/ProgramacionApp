using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.factory
{
    class FacturaIva:Factura
    {
    	//Heredar - Factory Method Modificando el original
        //Regresa el calculo de Importe + IVA (16%)
        public override double getImporteIva()
        {
            return Importe * 1.16;
        }
    }
}
