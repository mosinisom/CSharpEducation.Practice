using System;

class Program
{
    static void Main()
    {
        int year = 2024;
        bool isLeap = IsLeapYear(year);
        Console.WriteLine($"Является ли {year} високосным годом? : {(isLeap ? "Да" : "Нет")}");
    }

    static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
        return false;
    }
}
