int a;
int b;

Console.WriteLine("Сравнение двух чисел");
Console.Write("Введите a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b: ");
b = Convert.ToInt32(Console.ReadLine());

if(a > b)
    {
    Console.WriteLine($"a больше b на {a - b}");
}
else if(a < b)
{
    Console.WriteLine($"b больше a на {b - a}");
}
else
{
    Console.WriteLine("a и b равны");
}