using System;

namespace Practice3.Task9
{
    internal class Student
    {
        public string Name { get; private set; }
        public int Age { get; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}
