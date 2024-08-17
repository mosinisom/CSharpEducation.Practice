using Practice5.Task1;
using System;

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Саша", 1000);
        Manager manager = new Manager("Ариша", 2000, 10);
        Contractor contractor = new Contractor("Егор", 55);

        List<Employee> employees = new List<Employee> { employee, manager, contractor };

        foreach (var emp in employees)
        {
            switch(emp)
            {
                case Manager m:
                    Console.WriteLine($"Manager {m.Name} с бонусом {m.CalculateBonus()}");
                    break;
                case Contractor c:
                    Console.WriteLine($"Contractor {c.Name} с бонусом {c.CalculateBonus(10)}");
                    break;
                default:
                    Console.WriteLine($"Employee {emp.Name} с бонусом {emp.CalculateBonus()}");
                    break;
            }
        }
    }
}
