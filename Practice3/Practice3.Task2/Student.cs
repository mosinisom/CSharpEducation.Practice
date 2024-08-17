namespace Practice3.Task2
{
    internal class Student
    {
        public string Name;
        public int Age;

        public double AverageMark 
        {
            get { return AverageMark; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    AverageMark = value;
                }
                else
                {
                    throw new ArgumentException("Средний балл имеет значения от 0 до 5");
                }
            }
        }

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
