using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5ora2
{
 public abstract class Employee
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public DateTime BirthData { get; set; }
            public decimal  BaseSalary { get; set; }
            public int CalculateAge()
            {
                return DateTime.Now.Year - this.BirthData.Year;
            }

            public virtual decimal CalculateSalary()   ///cand punem virtual lasam posibilitatea de a suprascrie metoda
            {
                return this.BaseSalary * (decimal)0.80;
            }
        }
        public class Director : Employee
        {

        }
        public class Developer : Employee   ///aici refolosim metoda dar cu alt corp
        {
            public override decimal CalculateSalary()
            {
                return this.BaseSalary * (decimal)0.90;
            }

        }
    }  
 