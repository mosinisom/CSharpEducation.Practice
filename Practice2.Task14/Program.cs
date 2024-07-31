using System;

class Program
{
    static void Main()
    {
        int n = 5;

        int[] array = CreateArray(n);
        FillArray(array);
        PrintArray(array);
    }
    static int[] CreateArray(int n)
    {
        return new int[n];
    }

    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
