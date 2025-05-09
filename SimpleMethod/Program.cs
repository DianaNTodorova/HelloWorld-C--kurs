using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    internal class Program
    {
        private static string ReverseMethod(string message )
        {
            char[] charMessage=message.ToCharArray();
            Array.Reverse(charMessage);
            return String.Concat(charMessage);
        }
        private static void DisplayReverse(string reversedFirstMethod, string reversedLastName, string reversedCity)
        {
            Console.Write("Result is: ");
            Console.WriteLine($"Result is: {reversedFirstMethod} {reversedLastName} {reversedCity}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName=Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName=Console.ReadLine();
            Console.WriteLine("What is your city name?");
            string city=Console.ReadLine();
            DisplayReverse(ReverseMethod(firstName), ReverseMethod(lastName),ReverseMethod(city));  
            Console.ReadLine();
        }
    }
}
