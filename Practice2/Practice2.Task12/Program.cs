int n;

Console.WriteLine("Введите количество элементов массива: ");
n = Convert.ToInt32(Console.ReadLine());

string[] strings = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку под номером {0}: ", i);
    strings[i] = Console.ReadLine();
}

for (int i = 0; i < strings.Length; i++)
{
    Console.Write(strings[i] + " ");
}