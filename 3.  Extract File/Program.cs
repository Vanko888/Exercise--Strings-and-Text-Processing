using System;
using System.Text;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] text = Console.ReadLine().Split("\\");
            string[] newText = text[text.Length - 1].Split(".");
            string fileName = newText[newText.Length - 2];
            string extension = newText[newText.Length - 1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
