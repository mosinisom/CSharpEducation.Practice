using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public virtual double CalculateBonus()
        {
            return this.Salary * 0.1;
        }

        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
    }
}
