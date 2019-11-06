using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog:Animal
    {
        public string FrogBreed { get; set; }
        public Frog(string name,int age,string sex,string frog) : base(name, age, sex)
        {
            this.FrogBreed = frog;
        }
        public override void Sound()
        {
            Console.WriteLine($"Frog {this.Name} :OAC OAC");
        }
    }
}
