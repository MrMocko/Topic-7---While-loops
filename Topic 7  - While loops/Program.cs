using System.Reflection.Emit;
using System;

namespace Topic_7____While_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int pin = 12345;
            int entry, randNum, guess, dice1, dice2;
            randNum = generator.Next(10);
            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            Console.Write("ENTER YOUR PIN: ");
            int.TryParse(Console.ReadLine(), out entry);
            Console.WriteLine();
            while (entry != pin)
            {
                Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
                Console.Write("ENTER YOUR PIN: ");
                int.TryParse(Console.ReadLine(), out entry);
                Console.WriteLine();
            }
            Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");
            // if the correct conditon is true then the code runs if not then it doesn't 
            // it will infinitely run the code until the correct condition is met.
            // it makes the code run non-stop if the answer givin was incorrect, because now their is nowhere to enter the entry, so its wrong over and over and over again.
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            randNum = generator.Next(1, 11);
            Console.WriteLine("Hey man lets play a guessing game.");
            Console.WriteLine("The number i have picked is between 1 - 10.");
            Console.WriteLine("Good luck");
            Console.Write("Enter your answer here: ");
            Int32.TryParse(Console.ReadLine(), out guess);
            Console.WriteLine();
            while (guess != randNum)
            {
                Console.WriteLine("INCORRECT TRY AGAIN!");
                if (guess < randNum)
                    Console.WriteLine("Its a little higher");
                else
                {
                    Console.WriteLine("Its a little lower");
                }
                Console.Write("Enter your answer here: ");
                Int32.TryParse(Console.ReadLine(), out guess);
                Console.WriteLine();
            }
            Console.WriteLine("NO WAY GOOD JOB IT WAS " + randNum);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            dice1 = generator.Next(1, 7);
            dice2 = generator.Next(1, 7);
            Console.WriteLine("Ok i am going to roll 2 die untill they are the same and tell you what they were aswell as adding them together.");
            Console.WriteLine("Time to roll the die");
            Thread.Sleep(1000);
            Console.Write("Here is what you rolled: ");
            Console.Write(dice1 + " " + dice2 + " ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("Now i'm going to add them together: ");
            Thread.Sleep(1000);
            Console.WriteLine(dice1 + dice2);
            Console.ReadLine();
        }
    }
}
