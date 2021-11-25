using System;
using System.Text;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int reserv = 0;
            if (input == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int num = int.Parse(input[i].ToString());
                int result = num * multiplier + reserv;
                int currResult = result % 10;
                reserv = result / 10;
                sb.Insert(0, currResult);
            }

            if (reserv > 0)
            {
                sb.Insert(0, reserv);
            }

            Console.WriteLine(sb);
        }
    }
}
