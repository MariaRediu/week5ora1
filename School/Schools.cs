using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Schools
    {
        private string schoolName;
        private List<Classes> classes;
        public string SchoolName { get; set; }
        public List<Classes> Classes  { get; set; }

        public Schools(List<Classes> classes ,string schoolName)
        {
            this.SchoolName = schoolName;
            this.Classes = classes;
        }

        public void PrintSchool()
        {
            Console.WriteLine("Name of school:" + SchoolName);            
        }
    }
}
