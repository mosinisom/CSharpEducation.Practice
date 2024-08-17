using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    internal class Animal
    {
        public string Name { get; }
        public int Age { get; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal is making sound");
        }


    }
}
