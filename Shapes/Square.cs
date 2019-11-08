using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
   public class Square :Shape
    {
        public Square(int l) : base(l,l)
        {
           
        }
        public override double CalculateSurface()
        {
            return this.height * this.width;
        }

    }
}
