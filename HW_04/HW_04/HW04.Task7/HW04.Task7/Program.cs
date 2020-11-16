using System;
using System.ComponentModel;

namespace HW04.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("С помощью клавишь W,S,A,D выберите направление движения и доберитесь до цели");
            string[] myArray = {"w", "w", "s", "s", "d", "d", "a", "a"};
            for (int i = 0; i < myArray.Length; i++)
            {
                string word1 = Console.ReadLine();
                if (word1 == myArray[i])
                {
                    Console.WriteLine("верно");
                }
                else
                {
                    --i;
                    Console.WriteLine("неверно");
                }
            }
            Console.WriteLine("Вы дошли до цели");
        }
    }
}
