using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {

            // Practice Q 1

            //int numVal = 7;

            //if (numVal >= 0)
            //    Console.WriteLine(numVal);
            //else
            //    Console.WriteLine(Math.Abs(numVal));

            //Console.ReadLine();

            // P Q 2

            //for (int number = 1; number < 100; number++)
            //{
            //    if (number % 3 == 0)
            //        Console.WriteLine(number + "Buzz!");
            //}
            //Console.ReadLine();


            // PQ 3

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(Math.Pow(2, i));
            //}
            //Console.ReadLine();

            //PQ4
            //int sum = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            // LAB

            int number = new Random().Next(1, 10);
            string inputExtractor;

            Console.Write("Enter a number between 1 and 9 to guess the value: ");
            inputExtractor = Console.ReadLine();
            int userGuess = int.Parse(inputExtractor);

            for (int i = 0; i < 5; i++)
            {
                if (userGuess == number)
                {
                    Console.WriteLine("You won! Way to go!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again.");
                    if (userGuess > number)
                        Console.WriteLine("Guess lower!");
                    else
                        Console.WriteLine("Guess higher!");
                    inputExtractor = Console.ReadLine();
                    userGuess = int.Parse(inputExtractor);
                }

            
            }

            Console.ReadLine();

        }
    }
}
