// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //string input = "yes";

            //while (input == "yes")
            //{
                //Console.Write("Do you want to continue? ");
                //input = Console.ReadLine();
            //}

            //string inputTwo;

            //do
            //{
                //Console.Write("Do you want to continue? ");
                //inputTwo = Console.ReadLine();
            //} while (inputTwo == "yes");

            //for (int i = 0; i < 10; i++){Console.WriteLine(i);}

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,11);
            Console.Write(number);
            
            int guess = -1;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            

            

        }
    }
}