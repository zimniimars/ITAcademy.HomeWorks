using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "1a!2.3!!.. 4.!.?6 7! ..?";
            string str2 = Task1(str1);
            Console.WriteLine("Task1: " + str2);
            Console.WriteLine("Enter text: ");
            string myStr = Console.ReadLine();
            int str3 = Task2(myStr);
            Console.WriteLine(str3);
        }
        public static string Task1(string str1)
        {
            StringBuilder sb = new StringBuilder(str1);
            int index = sb.ToString().IndexOf('?');
            int index1 = sb.ToString().IndexOf('!');
            int len = sb.Length;
            sb.Replace('!',' ',index1,index);
            sb.Replace(' ', '_', index,len - index);
            string str2;
            str2 = sb.ToString(0, sb.Length);
            return str2;
        }
        public static int Task2(string myStr)
        {
            char[] myStr1;
            myStr1 = myStr.ToCharArray();
            int myChar = 0;
            int myChar1 = 0;
            int myChar2 = 0;
            int myChar3 = 0;
            int myCharM = 0;
            for (int i = 0; i < myStr1.Length; i++)
            {
                switch (myStr1[i])
                {
                    case '+':
                        myChar = myStr1[i];
                        char myCharN = (char)myChar;
                        String[] words = myStr.Split(new char[] { myCharN });
                        string[] wordsPL = new string[words.Length];
                        for (int j = 0; j < wordsPL.Length; j++)
                        {
                            wordsPL[j] = Regex.Replace(words[j], "[a-z]", "", RegexOptions.IgnoreCase);
                        }
                        int[] words2 = wordsPL.Select(int.Parse).ToArray();
                        myCharM = words2[0] + words2[1];
                        break;
                    case '-':
                        myChar1 = myStr1[i];
                        char myChar4 = (char)myChar1;
                        String[] words5 = myStr.Split(new char[] { myChar4 });
                        string[] wordsMin = new string[words5.Length];
                        for (int j = 0; j < wordsMin.Length; j++)
                        {
                            wordsMin[j] = Regex.Replace(words5[j], "[a-z]", "", RegexOptions.IgnoreCase);
                        }
                        int[] words3 = wordsMin.Select(int.Parse).ToArray();
                        myCharM = words3[0] - words3[1];
                        break;
                    case '*':
                        myChar2 = myStr1[i];
                        char myChar5 = (char)myChar2;
                        String[] words6 = myStr.Split(new char[] { myChar5 });
                        string[] wordsMul = new string[words6.Length];
                        for (int j = 0; j < wordsMul.Length; j++)
                        {
                            wordsMul[j] = Regex.Replace(words6[j], "[a-z]", "", RegexOptions.IgnoreCase);
                        }
                        int[] words4 = wordsMul.Select(int.Parse).ToArray();
                        myCharM = words4[0] * words4[1];
                        break;
                    case '/':
                        myChar3 = myStr1[i];
                        char myChar6 = (char)myChar3;
                        String[] words7 = myStr.Split(new char[] { myChar6 });
                        string[] wordsDiv = new string[words7.Length];
                        for (int j = 0; j < wordsDiv.Length; j++)
                        {
                            wordsDiv[j] = Regex.Replace(words7[j], "[a-z]", "", RegexOptions.IgnoreCase);
                        }
                        int[] words8 = wordsDiv.Select(int.Parse).ToArray();
                        myCharM = words8[0] / words8[1];
                        break;
                }
            }
            return myCharM;
        }
    }
}
