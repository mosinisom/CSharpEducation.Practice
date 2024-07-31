using System;

class Program
{
    static void Main()
    {
        int[,] nums = new int[20, 20];
        FillArray(nums);
        int[] differences = GetMinMaxDifferenceInEachRow(nums);
        foreach (var diff in differences)
        {
            Console.WriteLine(diff);
        }
    }

    static void FillArray(int[,] nums)
    {
        Random rand = new Random();
        int rows = nums.GetLength(0);
        int cols = nums.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                nums[i, j] = rand.Next(1, 100);
            }
        }
    }

    static int[] GetMinMaxDifferenceInEachRow(int[,] nums)
    {
        int rows = nums.GetLength(0);
        int cols = nums.GetLength(1);
        int[] difference = new int[rows];
        for (int i = 0; i < rows; i++)
        {
            int min = nums[i, 0];
            int max = nums[i, 0];
            for (int j = 0; j < cols; j++)
            {
                if (nums[i, j] < min)
                {
                    min = nums[i, j];
                }
                if (nums[i, j] > max)
                {
                    max = nums[i, j];
                }
            }
            difference[i] = max - min;
        }
        return difference;
    }
}