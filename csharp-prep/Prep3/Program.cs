using System;

class Program
{
    static void Main(string[] args)
    {
        // The variable "response" is assigned "yes" to initially enter the loop.
        string response = "yes";

        while (response == "yes")
        {
            // Reference: https://www.w3schools.blog/c-random-number
            // These 2 lines below creates a number between 1 and 100. 
            // It can create the number "1" or "100", but not "101".
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);

            int guess;

            // The variable "n" is the number of guesses the user has made.
            int n = 0;    

            do 
            {
                Console.Write("What is your guess? ");
                string answer = Console.ReadLine();
                guess = int.Parse(answer);

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                // The variable "n" is the number of guesses the user has made.
                // n += 1 is the same as n =  n + 1.
                n += 1;
            } while (guess != magicNumber);
            Console.WriteLine($"It took you {n} guess(es).\n");

            Console.Write("Do you want to play again (yes or no)? ");
            response = Console.ReadLine();
        }
    }
}

// Reference: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html