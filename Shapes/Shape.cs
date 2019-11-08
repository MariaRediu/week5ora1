using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
   public abstract class Shape
    {
        //field
        protected int width;
        protected int height;

        //constructor
        protected Shape(int w, int h)
        {
            
            this.height = h;
            this.width = w;


        }

        public abstract double CalculateSurface();
        {
           
        }
    }
}
