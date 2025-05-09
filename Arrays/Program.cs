using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 3, 5, 4, 15, };
            string names = "SIRAP";

            for (int i = 0; i < numbers.Length; i++) 
            { 
            Console.WriteLine(numbers[i]);
            }

            char[] charName=names.ToCharArray();
            Array.Reverse(charName);

            foreach (char c in charName)
            { 
                Console.Write(c);
            }
            Console.ReadLine();
        }
    }
}
