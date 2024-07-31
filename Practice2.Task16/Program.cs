using System;

class Program
{
    static void Main()
    {
        int number = 5;
        Console.WriteLine("Число до изменения знака: " + number);
        ChangeSign(ref number);
        Console.WriteLine("Число после изменения знака: " + number);

    }

    static void ChangeSign(ref int number)
    {
        number *= -1;
    }
   

}