﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileInteration
{
    internal class Program
    {
        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1/ Option 1");
            Console.WriteLine("2/ Option 2");
            Console.WriteLine("3/ Exit");
            string result= Console.ReadLine();
          
                if (result == "1")
                {
                    PrintNumbers();
                }
                else if (result == "2")
                {
                    GuessingGame();
                }
                else if (result == "3")
                {
                Environment.Exit(0);
            }
            
           



        }
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");
            int result=int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game");

            Random myRandom= new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                guesses++;
                string result = Console.ReadLine();
                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            } while (incorrect);
            { 
            Console.WriteLine("Correct! It took you {0} guesses", guesses);
            }


            Console.ReadLine() ;
        }
        static void Main(string[] args)
        {
            bool displayMenu =true;
            while (displayMenu)
            {
                MainMenu();
            }
        }
    }
}
