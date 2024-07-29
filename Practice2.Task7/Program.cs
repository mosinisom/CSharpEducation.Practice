string toUpper = "hello world";
Console.WriteLine(toUpper + " -> " + toUpper.ToUpper());

string toLower = "HELLO WORLD";
Console.WriteLine(toLower + " -> " + toLower.ToLower());

string firstLetterUpper = "hello world";
Console.WriteLine(firstLetterUpper + " -> " + char.ToUpper(firstLetterUpper[0]) + firstLetterUpper.Substring(1));

Console.ReadKey();

