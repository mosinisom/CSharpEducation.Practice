// прямоугольный треугольник звёздочками


// туда
int n = 0;
Console.Write("Введите количество строк: ");
n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadKey();


// сюда
for (int i = 0; i < n; i++)
{
    for(int j = 1; j < n - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadKey();

// задавать символ
char symbol = ' ';

Console.Write("Введите символ: ");
symbol = Convert.ToChar(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}

Console.ReadKey();