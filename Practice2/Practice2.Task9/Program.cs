int[] getIntArray(int n)
    {
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите элемент под номером {0}: ", i);
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

var arr = getIntArray(5);
printArray(arr);
