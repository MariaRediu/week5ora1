using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace School
{
    class Teachers : People
    {
         public Teachers(string name,List<Discipline> disciplines) : base(name)
        {
            this.Disciplines = disciplines;
        }
        public List<Discipline> Disciplines { get; set; }