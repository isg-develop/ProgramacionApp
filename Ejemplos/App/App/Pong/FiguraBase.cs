using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace App.Pong
{
    class Base
    {
        private Rectangle rec = new Rectangle();

        public Rectangle GetFigura { get { return rec;  } }
        public int eje_X {
            get { return rec.X; }
            set { rec.X = value; }
        }
        public int eje_Y {
            get { return rec.Y; }
            set { rec.Y = value; }
        }
        public Size tamaño
        {
            set { rec.Size = value; }
        }
        protected int Width{
        	get{  return rec.Size.Width; }
        }
    }
}
