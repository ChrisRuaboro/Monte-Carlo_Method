using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String sendIt = "this is a test for the longest word";
            Console.WriteLine(reverseString(sendIt));
        }
        static string reverseString(string input)
        {
            string[] arr = input.Split(' ');
            string longest = "";
            foreach (var element in arr)
            {
                if (longest.Length < element.Length)
                {
                    longest = element;
                }
            }
            return longest;

        }
    }
}
