using System;
using Practice3Part2.Task1;

namespace Practice3Part2.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mh = new MathHelper();

            Console.WriteLine(mh.Add(1, 2));
            Console.WriteLine(mh.Subtract(1, 2));
            Console.WriteLine(mh.Multiply(1, 2));
            Console.WriteLine(mh.Divide(1, 2));
        }
    }
}