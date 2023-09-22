using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //it is a class that you can't
    //create objects from 
    //or instantiate
    abstract class Employee
    {
        protected double salary;
        protected string name;
        protected string employeeNumber;

        public Employee(string name, string employeeNumber) {
            this.name = name;
            this.employeeNumber = employeeNumber;
        }
        abstract public void SetSalary(); //method without a body
        abstract public void SetBonus();
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

       public double GetSalary()
        {
            return salary;
        }



    }
}
