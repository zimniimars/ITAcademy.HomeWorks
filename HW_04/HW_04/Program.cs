using System;

namespace HW_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("Введите месяц рождения");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год рождения");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите текущий месяц");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите текущий год");
            num4 = int.Parse(Console.ReadLine());
            int num5 = num4 - num2;
          
            if (num1 >= num3)
            {
                 Console.WriteLine("Возраст = " + (++num5));
            }
            else 
            {
                 Console.WriteLine("Возраст = " + (num5));
            }
           
        }
    }
}
