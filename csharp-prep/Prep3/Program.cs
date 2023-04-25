using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference: https://www.w3schools.blog/c-random-number
        // These 2 lines below creates a number between 1 and 100. 
        // It can create the number "1" or "100", but not "101".
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess;

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
                Console.Write("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}

// Reference: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html