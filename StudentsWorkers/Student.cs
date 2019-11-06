using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    public class Student :Human
    {
        public int Grade { get; set; }
         public Student(string firstName,string lastName,int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
