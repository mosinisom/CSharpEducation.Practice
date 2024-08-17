using System;


class Program
{
    static void Main()
    {
        int[] nums = new int[17];
        FillArray(nums);
        Console.WriteLine(GetMinMaxDifference(nums));
    }

    static void FillArray(int[] nums)
    {
        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next(1, 100);
        }
    }

    static int GetMinMaxDifference(int[] nums)
    {
        int min = nums[0];
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        return max - min;
    }
}