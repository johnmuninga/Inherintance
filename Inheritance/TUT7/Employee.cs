using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT7
{
    class Employee
    {
        private string name;
        private string surname;
        private string departName;
        private double sales;

        public Employee()
        {
            name = null;
            surname = null;
            departName = null;
            sales = 0.00; 
        }

        public void SetName(string name)
        {
            this.name = name.Substring(0, 1).ToUpper() + name.Substring(1);
           
        }
        public void SetSurname (string surname)
        {
            this.surname = surname.ToUpper();
        }

        public void SetDepartment (char depart)
        {
            if (depart.ToString().ToUpper() == "E")
            {
                departName = "Electronics";
            }
            else if (depart.ToString().ToUpper() == "H")
            {
                departName = "Hardware";
            }
            else if (depart.ToString().ToUpper() == "S")
            {
                departName = "Sportswear";
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }

        public void SetSales (double sales)
        {
            if (sales < 2000)
            {
                this.sales = 2000;
            }
            else
            {
                this.sales = sales;
            }
        }

        public double CalcSalary()
        {
            double salary = 3000;

            if (departName == "Hardware")
            {
                salary += sales * 0.02;
            }
            else if (departName == "Electronics")
            {
                salary += sales * 0.035;
            }
            else if (departName == "Sportswear")
            {
                salary += sales * 0.045;
            }

            return salary;
        }

        public string GetName ()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }
        public string GetDepartment()
        {
            return departName;
        }
    }
}
