using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
   public class Classes :People
    {
        public Classes(string name,string Id):base(name)
        {
            this.UniqueID = Id;
        }  
        public string UniqueID { get; set; }
        
    }
   



}
