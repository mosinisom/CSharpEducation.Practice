using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
            Console.WriteLine("Кот создан");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }


    }
}
