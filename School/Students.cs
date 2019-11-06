using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
   public class Students : People
    {
        
        public Students(string name,int id) : base(name)
        {
            this.UniqueID = id;

        }
        public int UniqueID { get; set; }
    }
}
