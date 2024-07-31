using System;

class Program
{
    static void Main()
    {
        int rows = 5;
        int cols = 4; 

        int[,] array = CreateArray(rows, cols);
        FillArrayWithRandomNumbers(array);
        PrintArray(array);
    }

    static int[,] CreateArray(int rows, int cols)
    {
        return new int[rows, cols];
    }

    static void FillArrayWithRandomNumbers(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, 100);
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
