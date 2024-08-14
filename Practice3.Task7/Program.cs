using System;

class Program
{
    static void Main()
    {

    }

    static int GetDaysInMonth(Months month)
    {
        switch (month)
        {
            case Months.January:
            case Months.March:
            case Months.May:
            case Months.July:
            case Months.August:
            case Months.October:
            case Months.December:
                return 31;
            case Months.April:
            case Months.June:
            case Months.September:
            case Months.November:
                return 30;
            case Months.February:
                return 28;
            default:
                Console.WriteLine("Нет такого месяца");
                return 0;
        }
    }
}

enum Months
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}
