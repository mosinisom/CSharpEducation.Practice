class Program
{
    static void Main(string[] args)
    {
        int n;
        int number;
        void createAndPrintArray()
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Введите количество элементов массива: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                n = Convert.ToInt32(args[0]);
                number = Convert.ToInt32(args[1]);
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = number;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        createAndPrintArray();

    }
}