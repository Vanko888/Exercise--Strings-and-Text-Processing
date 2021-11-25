using System;
using System.Text;

namespace _4.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char tempChar = input[i];
                int sum = tempChar + 3;
                char newChar = Convert.ToChar(sum);
                temp.Append(newChar);
            }

            Console.WriteLine(temp);
        }
    }
}
