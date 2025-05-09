using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            /*int x=3;
            int y=x+3;
          
            Console.WriteLine(y);*/

            /* Console.WriteLine("What is your first name");
             Console.Write("Write your first name: ");
             string yourFirstName=Console.ReadLine();
             Console.WriteLine($"Your first name is {yourFirstName}");*/

            while (true)
            {

                Console.WriteLine("Make a choice: 1,2 or 3");
                Console.Write("Your choice is: ");
                string userInput = Console.ReadLine();
                string message="";
                if (userInput == "1")
                {
                     message = "you won a car!";
                }
                else if (userInput == "2")
                {
                     message = "You won a boat";
                }
                else if (userInput == "3")
                {
                     message = "You won a cat";
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
                Console.WriteLine($"You choose {userInput}, therefore {message}");
                Console.WriteLine("Would you like to continue: yes/no");
                
                string choice= Console.ReadLine().ToLower();
                if (choice == "no")
                {
                    break;
                }
             
            }



        }
    }
}
