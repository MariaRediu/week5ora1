using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
   public abstract class Animal :ISound
    {
        private string sex;
        public string  Name { get; set; }
        public int Age { get; set; }
        public string Sex
        {

            get { return this.sex; }

            set
            {
                if (value != "male" && value != "female")
                {
                    
                   
                    Console.WriteLine("Animal sex cannot be  different from male or female!");
                }
                else
                {
                    
                     this.sex = value;
                }
            }
        }
        
        public Animal(string name,int age,string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        public abstract void Sound();
        public static double CalculateAverange(Animal[] animals)
        {
            double sum = 0;

            foreach (var element in animals)
            {
                sum += element.Age;
            }

            double result = sum / animals.Length;

            return result;

        }

    }
}
