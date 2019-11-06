using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline
    {
       
        public Discipline(string name,int numberLecture,int numberExercies) 
        {
            this.DisciplineName = name;
            this.NumberOfLeacture = numberLecture;
            this.NumberOfExercies = numberExercies;

        }
        public int NumberOfLeacture { get; set; }
        public int NumberOfExercies { get; set; }
        public string DisciplineName { get; set; }


    }
}
