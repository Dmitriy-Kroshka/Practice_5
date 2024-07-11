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
        
        static void SplitText(string text) //void, так как мы производим преобразование введённого текста
        {
            string someText = text; //создаём переменную внутри метода с переданным текстом
            string[] subs = someText.Split(' '); //создаём массив строк из введённого текста с разделителем в виде пробела
            for (int i = 0; i < subs.Length; i++) //перебираем массив строк
            {
                Console.WriteLine(subs[i]);  //выводим каждый элемент массива в отдельной строке
            }
            //return someText; return не нужен, так как метод
                                //производит манипуляции с переданными данными
        }
    }
}