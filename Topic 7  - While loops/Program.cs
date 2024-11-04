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
            int entry, randNum, guess;
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
            if (guess == randNum)
            {
                Console.WriteLine("Yea man good job you got it, it was: " + randNum);

            }
            else
            {
                Console.WriteLine("No you're wrong the answer was: " + randNum);
            }
        }
    }
}
