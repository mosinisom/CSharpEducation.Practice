using System;

// наконец-то это последнее задание С:

class Program
{
    static void Main()
    {
        int day;
        Console.Write("Введите номер дня недели: ");
        if (int.TryParse(Console.ReadLine(), out day))
        {
            PrintDayOfWeek(day);
        }
        else
        {
            Console.WriteLine("Такого дня недели не существует");
        }
    }

    enum DaysOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void PrintDayOfWeek(int day)
    {
        if (Enum.IsDefined(typeof(DaysOfWeek), day))
        {
            Console.WriteLine((DaysOfWeek)day);
        }
        else
        {
            Console.WriteLine("Такого дня недели не существует");
        }
    }
}
