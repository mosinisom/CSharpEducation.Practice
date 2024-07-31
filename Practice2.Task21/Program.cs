using System;

class Program
{
    static void Main()
    {
        GuessTheNumber();
    }

    static void GuessTheNumber()
    {
        Random rand = new Random();
        int number = rand.Next(1, 100);
        int attempts = 0;
        Console.WriteLine("Угадай число от 1 до 100.");
        while (true)
        {
            Console.Write("Введи число: ");
            int guess = int.Parse(Console.ReadLine());
            attempts++;
            if (guess == number)
            {
                Console.WriteLine($"Поздравляю! Ты угадал число за {attempts} попыток.");
                break;
            }
            else if (guess < number)
            {
                Console.WriteLine("Число больше.");
            }
            else
            {
                Console.WriteLine("Число меньше.");
            }
        }
    }

}