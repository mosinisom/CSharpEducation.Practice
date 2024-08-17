// (a + b - f/a) + f * a * a - (a + b)

int a = 0;
int b = 0;
int f = 0;

Console.WriteLine("(a + b - f/a) + f * a * a - (a + b)");
Console.Write("введите a: ");
do
{

    a = Convert.ToInt32(Console.ReadLine());
    if (a == 0)
    {
        Console.Write("a не может быть равно 0, введите другое значение: ");
    }
} while (a == 0);

Console.Write("введите b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("введите f: ");
f = Convert.ToInt32(Console.ReadLine());

double result = (a + b - f / a) + f * a * a - (a + b);
Console.WriteLine($"Результат выражения: {result}");

Console.ReadKey();
