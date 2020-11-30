using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Aray1 = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < Aray1.Length; i++)
            {
                Aray1[i] = rnd.Next(1, 99); 
            }
            int[] Aray2 = new int[5];
            for (int i = 0; i < Aray1.Length; i++)
            {
                Console.WriteLine($"Первый массив случайных чисел {i}:\t ");
                Console.WriteLine(Aray1[i]);
            }

            for (int i = 0; i < Aray2.Length; i++)
            {
                Console.WriteLine($"Введите элемент второго массива {i}:\t ");
                Aray2[i] = int.Parse(Console.ReadLine());
            }
            int[] Aray3 = new int[5];
            for (int i = 0; i < Aray3.Length; i++)
            {
                Aray3[i] = Aray2[i] + Aray1[i];
            }
            for (int i = 0; i < Aray3.Length; i++)
            {
                Console.WriteLine($"Результат cложения элементов массивов {i}:\t ");
                Console.WriteLine(Aray3[i]);
            }
        }
    }
}
