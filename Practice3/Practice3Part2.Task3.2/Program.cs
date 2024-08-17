using Practice3Part2.Task3._1;

namespace Practice3Part2.Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPerson = new Person("Egor", 25);
            var secondPerson = new Person("Timur", 30);
            
            firstPerson.PrintPerson();
            secondPerson.PrintPerson();
        }
    }
}