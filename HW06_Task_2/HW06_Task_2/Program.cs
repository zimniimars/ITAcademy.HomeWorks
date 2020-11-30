using System;

namespace HW06_Task_2
{
    class Program
    {
        static void Insert(ref int[] myArray, int value, int index)
        {
            int[] newArray = new int[myArray.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = myArray[i];
            }
            for (int i = index; i < myArray.Length; i++)
            {
                newArray[i + 1] = myArray[i];
            }
            myArray = newArray;
        }
        static void Main(string[] args)
        {
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива {i}:\t ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Первый массив {i}:\t ");
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Выберите индекс массива: ");
            int index2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элемент массива: ");
            int number = int.Parse(Console.ReadLine());
            Insert(ref array, number, index2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Новый массив {i}:\t ");
                Console.WriteLine(array[i]);
            }
        }
    }
}
