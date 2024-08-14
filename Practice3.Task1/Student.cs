
namespace Practice3.Task1
{
    internal class Student
    {
        public string Name;
        public int Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
