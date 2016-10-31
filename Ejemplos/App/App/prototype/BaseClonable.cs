using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.prototype
{
    class BaseClonable : ICloneable
    {
        public object Clone()
        {            
            return this.MemberwiseClone();
        }
    }
}
