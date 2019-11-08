using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5ora2
{
   public class Program
    { 
        static void Main(string[] args)
        {

            /// var angajat = new Employee();  nu pot creea un ob de tip Employee din cauza ca am scris public abstract class Employee
           
            Employee director = new Director
            {
                Id = "1",
                Name = "Popescu",
                BirthData = new DateTime(1957, 3, 1)
            };

            var developer = new Developer
            {
                Id = "2",
                Name = "Ionescu",
                BirthData = new DateTime(1998, 5, 23)
            };


        }
    }
}
