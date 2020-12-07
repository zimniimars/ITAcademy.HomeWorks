using System;
using static System.Net.Mime.MediaTypeNames;

namespace HW_07_T_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text :");
            string text = Console.ReadLine();
            Console.WriteLine("\n Array");
            string[] text1 = MyArray(text);
            for (int i = 0; i < text1.Length; i++)
            {
                Console.WriteLine(text1[i]);
            }
            Console.WriteLine("\n Delete");
            string[] text2 = MaxLengthWord(text);
            for (int i = 0; i < text2.Length; i++)
            {
                Console.Write(text2[i] + " ");
            }
            Console.WriteLine("\n Swap");
            string[] text3 = Swap(text);
            for (int i = 0; i < text3.Length; i++)
            {
                Console.Write(text3[i] + " ");
            }
            Console.WriteLine("\n Quantity");
            int quant = Quantity(text);
            Console.WriteLine(quant);
        }

        public static string[] MaxLengthWord(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxlen)
                {
                    maxlen = words[i].Length;
                    index = i;
                }
            }
            string[] newWords = new string[words.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newWords[i] = words[i];
            }
            for (int i = index + 1; i < words.Length; i++)
            {
                newWords[i - 1] = words[i];
            }
            words = newWords;
            return words;
        }

        public static string[] Swap(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0, minlen = 0, index1 = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxlen)
                {
                    maxlen = words[i].Length;
                    index = i;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= minlen)
                {
                    minlen = words[i].Length;
                    index1 = i;
                }
            }
            string[] words1 = new string[words.Length];
            for (int i = 0; i < index; i++)
            {
                words1[i] = words[i];
            }
            for (int i = index + 1; i < words.Length; i++)
            {
                words1[i - 1] = words[i];
            }
            words1 = words;
            return words1;
        }
        
        public static int Quantity(string text)
        {
            var result = text.Length;
            return result;
        }

        public static string[] MyArray(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words, (x1, x2) => x1.Length.CompareTo(x2.Length));
            return words;
        }
    }
}
