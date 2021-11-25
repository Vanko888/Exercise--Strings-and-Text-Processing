using System;
using System.Linq;

namespace _2.__Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int lenght = 0;
            int sum = 0;
            int curSum = 0;
            string firstWord = input[0];
            string secondWord = input[1];
            if (input[0].Length >= input[1].Length)
            {
                lenght = input[1].Length;
                for (int i = 0; i < lenght; i++)
                {
                    char a = firstWord[i];
                    char b = secondWord[i];
                    curSum = a * b;
                    sum += curSum;

                }
                for (int j = lenght; j < input[0].Length; j++)
                {
                    char c = firstWord[j];
                    sum += c;
                }
            }
            else
            {
                lenght = input[0].Length;
                for (int i = 0; i < lenght; i++)
                {
                    char a = firstWord[i];
                    char b = secondWord[i];
                    curSum = a * b;
                    sum += curSum;

                }
                for (int j = lenght; j < input[1].Length; j++)
                {
                    char c = secondWord[j];
                    sum += c;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
