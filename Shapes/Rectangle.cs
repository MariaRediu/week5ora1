using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle :Shape
    {
        public Rectangle(int lat, int lon) : base(lat, lon)
        {

        }
        public  override  double CalculateSurface()
        {
            return height * width;
        }
    }
}
