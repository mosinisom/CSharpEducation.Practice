using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    internal class Contractor : Employee
    {
        public double HourlyRate { get; set; }

        public new double CalculateBonus(int hoursWorked)
        {
            return this.HourlyRate * hoursWorked;
        }

        public Contractor(string name, double hourlyRate) : base(name, 0)
        {
            this.HourlyRate = hourlyRate;
        }
    }
}
