using System;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString;

            Console.Write("Please enter your name and press enter: ");

            myString = Console.ReadLine();

            Console.WriteLine(myString.ToUpper().Trim());
            Console.WriteLine(myString.ToLower().Trim());

            Console.WriteLine(myString.Substring(2));



        }
    }
}
