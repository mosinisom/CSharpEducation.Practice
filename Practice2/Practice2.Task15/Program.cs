using System;

class Program
{
    static void Main()
    {
        int[] firstArray = { 1, 2};
        int[] reversedArray = ReverseArray(firstArray);

        PrintArray(firstArray);
        Console.WriteLine();    
        PrintArray(reversedArray);


    }

    static int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - 1 - i];
        }
        return reversedArray;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}