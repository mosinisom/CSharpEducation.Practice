using System;

class Program
{
    static void Main()
    {
        int[] nums = {1, -2, 3, -4, 5, -6, 7, -8, 9, -10};
        int countDeleted;
        int[] result = DeleteNegative(nums, out countDeleted);

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        Console.WriteLine("Удалено отрицательных чисел: " + countDeleted);

    }

    static int[] DeleteNegative(int [] nums, out int countDeleted)
    {
       int count = 0;
       for (int i = 0; i < nums.Length; i++)
       {
           if (nums[i] < 0)
           {
               count++;
           }
       }

       int[] result = new int[nums.Length - count];
       int index = 0;
       for (int i = 0; i < nums.Length; i++)
       {
           if (nums[i] >= 0)
           {
               result[index] = nums[i];
               index++;
           }
       }

       countDeleted = count;
       return result;
    }
}