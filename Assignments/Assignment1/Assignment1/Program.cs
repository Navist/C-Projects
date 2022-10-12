using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float myFloat = float.Parse(stringForFloat);
            int myInt = int.Parse(stringForInt);

            Console.WriteLine($"Float {myFloat}\nInt {myInt}");
        }
    }
}
