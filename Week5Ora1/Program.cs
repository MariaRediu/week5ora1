using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Ora1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Ana" ,"Ioana");
            var worker = new Worker("Ion", "Andrei",100,5 );
        }
    }

    public class Human
    {
       public Human(string name, string lastName)
        {
        Name=name;
        LastName= lastName;
        }
        public string LastName { get; set; }
        public string Name { get; set; }
       
    }
    public class Student :Human
    {
        public Student(string name,string lastName ) : base(name,lastName)
        {

        }

        public string Grade { get; set; } 
    }
    

    public class Worker:Human
    {
        public Worker(string name,string lastName,int weekSalary,int workHourPerDay): base(name,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHourPerDay;
        }

        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }
         public float MoneyPerHour()
        {
        
          return  WeekSalary / WorkHoursPerDay*5 ;
        }
    }

}
