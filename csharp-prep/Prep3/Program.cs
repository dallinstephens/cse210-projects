using System;

class Program
{
    static void Main(string[] args)
    {
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1,11);
        Console.Write("What is the magic number? ");
        string answer1 = Console.ReadLine();
        int magicNumber = int.Parse(answer1);

        Console.Write("What is your guess? ");
        string answer2 = Console.ReadLine();
        int guess = int.Parse(answer2);

        if (guess < magicNumber)
        {
            Console.Write("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.Write("Lower");
        }
        else
        {
            Console.Write("You guessed it!");
        }
    }
}

// Reference: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html