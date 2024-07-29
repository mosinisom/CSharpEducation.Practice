// a
for(int i = 1; i <= 50; i++)
{
    Console.WriteLine(i);
}

Console.ReadKey();

// b
int j = 1;
while(j <= 60)
{
    Console.WriteLine(j);
    j++;
}

Console.ReadKey();

// c
int k = 1;
do
{
    Console.WriteLine(k);
    k++;
} while(k <= 70);

Console.ReadKey();

// d
string sentence = String.Empty;
for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Введи слово:");
    sentence += Console.ReadLine() + " ";
}
Console.WriteLine(sentence);

Console.ReadKey();

// e
j = 0;
sentence = String.Empty;
while(j < 5)
{
    Console.WriteLine("Введи слово:");
    sentence += Console.ReadLine() + " ";
    j++;
}
Console.WriteLine(sentence);

Console.ReadKey();

// f
k = 0;
sentence = String.Empty;
do
{
    Console.WriteLine("Введи слово:");
    sentence += Console.ReadLine() + " ";
    k++;
} while(k < 5);

Console.WriteLine(sentence);

