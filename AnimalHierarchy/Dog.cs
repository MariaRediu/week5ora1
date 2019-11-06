using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
   public   class Dog :Animal
    {
        public string DogBreed { get; set; }

        public Dog(string name,int age,string sex,string dog) : base(name, age, sex)
        {
            this.DogBreed = dog;
        }
        public override void Sound()
        {
            Console.WriteLine($"Dog {this.Name} :Ham ham!!");
        }
    }
}
