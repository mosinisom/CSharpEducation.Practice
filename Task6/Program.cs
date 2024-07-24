double firstCathetus = 0;
double secondCathetus = 0;
double hypotenuse = 0;
string answer = "";


string[] yesAnswers = { "y", "yes", "да", "д" , "н", "Н", "Y"};

Console.WriteLine("Известны оба катета и надо найти гипотенузу? (y/n)");

answer = Console.ReadLine();

if(yesAnswers.Contains(answer))
{
    Console.WriteLine("Известны оба катета и надо найти гипотенузу");
    Console.Write("Введите длину первого катета: ");
    firstCathetus = double.Parse(Console.ReadLine());
    Console.Write("Введите длину второго катета: ");
    secondCathetus = double.Parse(Console.ReadLine());
    hypotenuse = Math.Sqrt(firstCathetus * firstCathetus + secondCathetus * secondCathetus);
    Console.WriteLine($"Гипотенуза равна {hypotenuse}");
}
else
{
    Console.WriteLine("Известен один катет и гипотенуза, надо найти второй катет");
    Console.Write("Введите длину известного катета: ");
    firstCathetus = double.Parse(Console.ReadLine());
    Console.Write("Введите длину гипотенузы: ");
    hypotenuse = double.Parse(Console.ReadLine());
    secondCathetus = Math.Sqrt(hypotenuse * hypotenuse - firstCathetus * firstCathetus);
    Console.WriteLine($"Второй катет равен {secondCathetus}");
}


