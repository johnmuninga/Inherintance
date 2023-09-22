using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Doctor:Employee
    {
        public Doctor(string name, string employeeNumber) : base(name, employeeNumber) { }

        public override void SetSalary()
        {
            salary = 100000;
        }
        public override void SetBonus()
        {
            salary *= 1.15;
            //salary= salary + (salary*0.15)
        }
    }
}
