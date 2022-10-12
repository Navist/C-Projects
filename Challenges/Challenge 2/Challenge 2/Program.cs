using System;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string myString;

            // Get string from user
            Console.WriteLine("Enter a string here: ");
            myString = Console.ReadLine();

            Console.WriteLine($"You entered {myString}.");

            // Ask them for a character to search for
            Console.WriteLine("Enter the character to search: ");
            char searchInput = Console.ReadLine()[0];

            int searchIndex = myString.IndexOf(searchInput);

            // Print the result of their input
            Console.WriteLine($"Character index of {searchInput} in {myString} is {searchIndex}.");


            string firstName;
            string lastName;

            // Concatenation challenge
            Console.WriteLine("What is your first name?: ");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?: ");
            lastName = Console.ReadLine();

            // Mutliple ways of concatenation

            string fullName = string.Concat(firstName + " " + lastName);

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine($"{firstName} {lastName}");
            Console.WriteLine("{0} {1}", firstName, lastName);
            Console.WriteLine("{0}", fullName);

            Console.ReadLine();
        }
    }
}
