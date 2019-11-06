using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Square  aria = new Square();
            Console.WriteLine("Aria patrat:"+ aria.calculateArea(3));
            Console.ReadLine();
        }
    }

    interface IShape
    {
     double calculateArea();
    }

    public class Square :IShape
    {
        public int Latura { get; set; }
        public Square( int l)
        {
           this.Latura = l;
        }

        public double calculateArea(int l)
        {
            return l * l;
        }
    }

    public class Rectangle :IShape
    {
        public int Lungime { get; set; }
        public int Latime { get; set; }

        public Rectangle (int L,int l)
        {
            this.Lungime = L;
            this.Latime = l;
        }

        public double calculateArea(int L,int l)
        {
            return L * l;
        }
    }

    public class Cercle:IShape
    {
        public int Raze { get; set; }
        public Cercle(int raza)
        {
            this.Raze = raza;
        }

        public double calculateArea(int raza)
        {
            return  Math.PI*raza * raza;
        }
    }
}
