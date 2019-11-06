using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{                       /// <summary>

/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] cats = new Cat[]
            {
                new Cat("Tom",4,"male","Black Toad"),
                new Cat ("Aris",7,"male","White Cat"),
                new Cat("Maya",3,"female","Black Cat")
            };

            Dog[] dogs = new Dog[]
            {
                new Dog("Rexy",7,"male","Labrador"),
                new Dog("Bella",6,"female","Cannis"),
                new Dog("Ira",9,"female","Saint Bernard")
            };

            Frog[] frogs = new Frog[]
            {
                new Frog("Frogy",23,"male","Frog1"),
                new Frog("Little",2,"female","Frog2")
            };

            Kitten kitty = new Kitten("Pisi", 1, "female", "Black kitty");
            Tomcat tom = new Tomcat("Tomy", 2, "male", "White tomcat");

            Console.WriteLine(" Cats average age are :" + Cat.CalculateAverange(cats));
            cats[0].Sound();
            cats[1].Sound();
            cats[2].Sound();

            Console.WriteLine(); 

            tom.Sound();
            kitty.Sound();

            Console.WriteLine();

            Console.WriteLine(" Dogs average age are: " + Dog.CalculateAverange(dogs));
            dogs[0].Sound();
            dogs[1].Sound();
            dogs[2].Sound();

            Console.WriteLine();

            Console.WriteLine("Frogs average age are: " + Frog.CalculateAverange(dogs));
            frogs[0].Sound();
            frogs[1].Sound();

            

            Console.ReadLine();
            
        }
    }
}
