using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Pong
{
    class Pelota:Tabla
    {
        public byte direccion_Y;
        //public byte direccion_X;
        
        public int GetDiametro(){
        	return base.Width;
        }
    }
}
