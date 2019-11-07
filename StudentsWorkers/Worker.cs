using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    public  class Worker :Human
    {
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public Worker(string firstNane,string lastName,double weeksalary,double workHours) : base(firstNane, lastName)
        {
            this.WeekSalary = weeksalary;
            this.WeekSalary = workHours;
        }
        public double  MoneyPerHour()
        {
            return WeekSalary / WorkHoursPerDay * 5;
        }
    }
}
