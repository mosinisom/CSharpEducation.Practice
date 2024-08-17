using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    internal class Parrot : Animal, IFlyable
    {
        public Parrot(string name, int age) : base(name, age)
        {
            Console.WriteLine("Попугай создан, страшно?");
        }

        public new void MakeSound()
        {
            Console.WriteLine("Parrot is talking");
        }

        public void MakeSound(string words)
        {
            Console.WriteLine($"Parrot is saying \"{words}\"");
        }

        public void Fly()
        {
            Console.WriteLine("Parrot is flying");
        }
    }
}
