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
            Console.WriteLine("Сумма чисел = " + num3 );
        }
    }
}
