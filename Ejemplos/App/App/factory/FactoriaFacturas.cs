using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.factory
{
    public enum TipoIVA { IVAActual, IVAReducido }

    public static class FactoriaFacturas
    {
        public static Factura getFactura(TipoIVA tipo)
        {
          if (tipo == TipoIVA.IVAActual)
             return new FacturaIva();
          else
             return new FacturaIvaReducido();
        }

    }
}
