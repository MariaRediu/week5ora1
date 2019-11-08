using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle :Shape
    {
        public Triangle(int w,int h):base(w,h)
            {

             }
        public override double CalculateSurface()
        {
            return this.height * width / 2;
        }
    }
}
