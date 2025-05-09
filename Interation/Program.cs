using System;

namespace Interation
{
    internal static class Program
    {


        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("I found 7");
                    break;
                }
            }
            for (int myValue=0; myValue<12; myValue++)
            {
                Console.WriteLine(myValue);
            }
        }
    }
}
