using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
   public class People : Comment
    {
        public People(string name)
        {
            this.Name = name;
        }
        public string  Name { get; set; }
    }
    
}
