using System;

class Program
{
    static void Main()
    {
        int firstNumber = 1;
        int secondNumber = 2;

        Console.WriteLine("Первое число: " + firstNumber);
        Console.WriteLine("Второе число: " + secondNumber);

        (firstNumber, secondNumber) = Swap(firstNumber, secondNumber);

        Console.WriteLine("Первое число после смены значений: " + firstNumber);
        Console.WriteLine("Второе число после смены значений: " + secondNumber);


    }

    static (int, int) Swap(int a, int b)
    {
        return (b, a);
    }
}