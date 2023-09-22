using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Nurse : Employee
    {
        public Nurse(string name, string employeeNumber) : base(name, employeeNumber) { }

        public override void SetSalary()
        {
            salary = 50000;
        }
        public override void SetBonus()
        {
            salary *= 1.5;
            //salary= salary + (salary*0.5)
        }
    }
}
