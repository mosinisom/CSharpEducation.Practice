class Program
{
    static void Main(string[] args)
    {
        int n;
        void createAndPrintArray()
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Введите количество элементов массива: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                n = Convert.ToInt32(args[0]);
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент под номером {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        createAndPrintArray();

    }
}