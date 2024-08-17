double[] arr = new double[3];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Ведите число {i + 1}: ");
    arr[i] = double.Parse(Console.ReadLine());
}

bool isAllUnique = true;
for(int i = 0; i < arr.Length; i++)
{
    for(int j = i + 1; j < arr.Length; j++)
    {
        if(arr[i] == arr[j])
        {
            isAllUnique = false;
            break;
        }
    }
}

if(isAllUnique)
{
    Console.WriteLine("Равных нет");
}
else
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] += 5;
    }
}

Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2]);