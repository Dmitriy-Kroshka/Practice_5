using System;
namespace Practice_5_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите своё предложение: ");
            string inputText = Console.ReadLine();
            Console.WriteLine(ReverseString(inputText));
        }

        static string ReverseString(string inputText)
        {
            string[] stringParts =  SplitText(inputText) ;
            string resultString = "";

            for (int i = stringParts.Length -1; i >= 0; i--)
            {
                resultString += stringParts[i] + " ";
            }
            return resultString;
        }
        static string[] SplitText(string text)
        {
            string someText = text;
            string[] subs = someText.Split(' ');
            for (int i = 0; i < subs.Length; i++)
            {
                return subs;
            }
            return subs;
        }
    }
}
