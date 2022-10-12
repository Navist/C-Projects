using System;

namespace Experimental_Code
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1, num2;

            num1 = 13;
            num2 = 15;


            int sum = num1 + num2;

            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " equals: " + sum);

            double pi = 3.1415;
            double pl = 5.1;

            double dDiv = pi / pl;

            Console.WriteLine(dDiv);


            float f1 = 3.1415f;
            float f2 = 5.1f;

            float fDiv = f1 / f2;

            Console.WriteLine(fDiv);

            Console.Read();
            
            
        }
    }
}
