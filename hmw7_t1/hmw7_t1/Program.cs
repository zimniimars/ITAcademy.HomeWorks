using System;

namespace hmw7_t1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separators = {";"};
            string numberO = "O";
            string numberA = "A";
            string numbero = "o";
            string numbera = "a";
            Console.WriteLine("Введите стих, разделяя строки точкой с запятой: ");
            string value = Console.ReadLine();
            value = value.Replace(numberO, numberA);
            value = value.Replace(numbero, numbera);
            string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Ваш стих:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
