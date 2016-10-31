using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Pong
{
    class Tabla:Base
    {
        public byte direccion_X;
        public byte velocidad;
        
         public int GetAncho(){
        	return base.Width;
        }
    }
}
