using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public  class Kitten:Cat
    {
        public Kitten(string name, int age, string sex, string gender) : base(name, age, "female", gender)
        {

        }
        public override void Sound()
        {
            Console.WriteLine($"Kitten {this.Name} : miaaauuuuuu");
        }
    }
    
}
