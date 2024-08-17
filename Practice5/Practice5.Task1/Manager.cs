using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    internal class Manager : Employee
    {
        public int TeamSize { get; set; }

        public override double CalculateBonus()
        {
            var bonus = this.Salary * 0.2;

            if (this.TeamSize > 5)
            {
                bonus *= 1.05;
            }

            return bonus;
        }

        public Manager(string name, double salary, int teamSize) : base(name, salary)
        {
            this.TeamSize = teamSize;
        }


    }
}
