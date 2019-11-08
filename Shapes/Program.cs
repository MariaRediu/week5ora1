using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape t = new Triangle(1, 3);
            Console.WriteLine(t.CalculateSurface());

            Shape d = new Rectangle(3, 4);
            Console.WriteLine(d.CalculateSurface());

            Shape s = new Square(5);
            Console.WriteLine(s.CalculateSurface());
            List<Shape> shapes=new List<Shape>();
            shapes.Add(t);
            shapes.Add(d);
            shapes.Add(s);

        }
    }
}
