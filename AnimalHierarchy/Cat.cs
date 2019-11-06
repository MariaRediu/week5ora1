using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public  class Cat:Animal
    {
        public  string CatBreed { get; set; }

        public Cat(string name,int age,string sex,string cat):base(name,age,sex)
        {
            this.CatBreed = cat;
        }
        public override void Sound()
        {
            Console.WriteLine( $"Cat {this.Name}: Miauuu" );
        }
    }
}
