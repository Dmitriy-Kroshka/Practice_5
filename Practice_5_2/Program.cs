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

        static string[] SplitText(string text)
        {
            string someText = text;
            string[] subs = someText.Split(' ');
            return subs;
        }
        static string ReverseString(string inputText)           //я не понял как использовать какой-то встроенный метод reverse
        {
            string[] stringParts = SplitText(inputText);        //создаём массив строк, присвоив ему значение разделённой строки
            string resultString = "";                           //создаём пустую строку
            for (int i = stringParts.Length - 1; i >= 0; i--)   //перебираем массив с конца
            {
                resultString += stringParts[i] + " ";           //в пустую строку добавляем элементы массива, начиная с последнего
            }
            return resultString;                                //возвращаем перевёрнутую строку
        }
    }
}
