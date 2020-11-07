using System;
using System.Dynamic;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Введите первое число");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = double.Parse(Console.ReadLine());
            double num3 = num1 + num2;
            Console.WriteLine("Введите сумму чисел");
            double sum1 = double.Parse(Console.ReadLine());

            if (sum1 == num3)
            {
                Console.WriteLine("Правильно");
            }
            else if (sum1 < num3)
            {
                Console.WriteLine("Неправильно. Ожидалось большее число");
            }
            else if (sum1 > num3)
            {
                Console.WriteLine("Неправильно. Ожидалось меньшее число");
            }

        }
     
    }
}
