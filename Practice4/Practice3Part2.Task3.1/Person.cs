namespace Practice3Part2.Task3._1
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public new string ToString()
        {
            return $"Человеку с именем: {this.Name}  столько лет: {this.Age} !!!";
        }

        public void PrintPerson()
        {
            System.Console.WriteLine(ToString());
        }

    }
}
