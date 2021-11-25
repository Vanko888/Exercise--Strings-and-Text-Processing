using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.__Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(", ").ToList();
            List<string> newText = new List<string>(text);
            foreach (var word in text)
            {
                if (word.Length <= 3)
                {
                    newText.Remove(word);
                }
                else if (word.Length >= 16)
                {
                    newText.Remove(word);
                }
                for (int i = 0; i < word.Length; i++)
                {
                    if (!char.IsLetterOrDigit(word[i]))
                    {
                        if (!word.Contains("-"))
                        {
                            if (!word.Contains("_"))
                            {
                                newText.Remove(word);
                                break;
                            }

                        }
                    }
                }
            }

            foreach (var word in newText)
            {
                Console.WriteLine(word);
            }
        }
    }
}
