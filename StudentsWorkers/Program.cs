using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
              new Student("Ana","Popescu",4),
              new Student("Ioana","Vasilescu",5),
              new Student("Bianca","Ionescu",1),
              new Student("Ales","Albulescu",6),
              new Student("Victor","Xluescu",8),
              new Student("George","Lucescu",3),
              new Student("Iarina","Lizescum",2),
              new Student("Ianis","Zuzescu",7),
              new Student("Luca","Zamfirescu",9),
              new Student("Ilinca","Dediu",10)

            };

            Worker[] workers = new Worker[]
            {
                new Worker("Adrian","Worker1",200,12),
                new Worker("Vasile","Worker2",350,15),
                new Worker("ion","Worker3",600,20),
                new Worker("Adisor","Worker4",312,8),
                new Worker("Georgica","Worker5",210,6),
                new Worker("Laur","Worker6",500,25),
                new Worker("Ianis","Workers7",634,28),
                new Worker("Mihai","Worker8",336,30),
                new Worker("Alex","Worker9",336,20)

            };
            //VARIANTA I
            /*  IEnumerable<Student> query = students.OrderBy(student => student.Grade);

              Console.WriteLine("List of students order by grade:");
                  foreach (Student student in query)
              {
                  Console.WriteLine($" {student.Grade} --{student.FirstName}  {student.LastName}");
              }*/
            Console.WriteLine("STUDENTS");
            Console.WriteLine("List of students order by grade:");
            var result = from stud in students orderby stud.Grade, stud.FirstName, stud.LastName select stud;
            foreach (var item in result)
            {
                Console.WriteLine("{0} {1} {2}", item.Grade, item.FirstName, item.LastName);
            }

            Console.ReadLine();

            List<Worker> workersList = new List<Worker>();

            var sortedWorker = workersList.OrderByDescending(x => x.MoneyPerHour());

                Console.WriteLine("WORKERS");
                foreach (var element in sortedWorker)
                {
                    Console.WriteLine("Full name: {0}", element.FirstName + " " + element.LastName);
                    Console.WriteLine("Week salary: " + element.WeekSalary);
                    Console.WriteLine("Work hours per day: " + element.WorkHoursPerDay);
                    Console.WriteLine("Money per hours: " + element.MoneyPerHour());
                    Console.WriteLine();
                }
            

             List<Human> mergedList = new List<Human>();
           
                var sortedList =from merge in mergedList orderby merge.FirstName, merge.LastName select merge;

           
                Console.WriteLine(" MERGED LIST");
                foreach (var element in sortedList)
                { 
                    Console.WriteLine($"First name: {element.FirstName} - Last name: {element.LastName}" );
                }

            Console.ReadLine();

        }
    }
}
