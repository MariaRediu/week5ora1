using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
   public class Tomcat :Dog
    {
        public Tomcat(string name,int age,string sex,string gender) : base(name, age, "male", gender)
        {

        }
        public override void Sound()
        {
            Console.WriteLine($"Tomcat {this.Name} :ham ham ham ham ");
        }
    }
}
