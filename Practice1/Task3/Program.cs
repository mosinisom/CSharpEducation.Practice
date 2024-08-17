string greeting = "Доброго времени суток";
string name;

Console.Write("Введите ваше имя: ");
name = Console.ReadLine();

while (string.IsNullOrEmpty(name))
{
    Console.WriteLine("Имя не может быть пустым.");
    Console.Write("Введите ваше имя: ");
    name = Console.ReadLine();
}

Console.WriteLine($"{greeting}, {name}!");
