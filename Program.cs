using System;

namespace Practice_5_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите ваше предложение: ");
            string inputText = Console.ReadLine();
            SplitText(inputText);
        }
        static string SplitText(string text)
        {
            string someText = text;
            string[] subs = someText.Split(' ');
            foreach (string sub in subs)
            {
                Console.WriteLine(sub);
            }
            return someText;
        }
    }
}