public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Подсчёт символа в предложении");
        Console.Write("Вводить предложение и символ вручную? (да/нет) ");

        string answer = Console.ReadLine();

        if (answer == "да")
        {
            string sentence = String.Empty;

            Console.Write("Введите предложение: ");
            sentence = Console.ReadLine();

            char ch = ' ';

            Console.Write("Введите символ: ");
            ch = Convert.ToChar(Console.ReadLine());

            charInSentence(sentence, ch);
        }
        else
        {
            answer = String.Empty;
            Console.Write("Использовать аргументы командной строки? (да/нет) ");
            answer = Console.ReadLine();

            if (answer == "да")
            {
                if (args.Length == 2)
                {
                    charInSentence(args[0], Convert.ToChar(args[1]));
                }
                else
                {
                    Console.WriteLine("Неверное количество аргументов");
                }
            }
            else
            {
                charInSentence("Hello, World!", 'o');
            }
        }


        static void charInSentence(string sentence, char ch)
        {
            Dictionary<char, int> charAndNumber = new Dictionary<char, int>();
            foreach (char c in sentence)
            {
                if (charAndNumber.ContainsKey(c))
                {
                    charAndNumber[c]++;
                }
                else
                {
                    charAndNumber.Add(c, 1);
                }
            }
            double percent = (double)charAndNumber[ch] / sentence.Length * 100;
            Console.WriteLine($"Строка '{sentence}' состоит из символа {ch} на {percent} %");
        }
    }
}
