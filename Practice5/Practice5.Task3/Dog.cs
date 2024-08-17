using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    internal class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            Console.WriteLine("Собака создана, как мощны её лапищи!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
