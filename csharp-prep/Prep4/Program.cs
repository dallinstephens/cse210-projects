using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // "List<int> numbers" declares a variable to hold the list.
        // "numbers = new List<int>()" is needed to use the list.
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;

        // The variable sum is set to 0 initially.
        int sum = 0;

        do
        {
            Console.Write("Enter number: ");
            // "int.Parse()" is needed because Console.ReadLine is always a string.
            number = int.Parse(Console.ReadLine());

            // Adds the number the user entered to the list called numbers.
            numbers.Add(number);
            // sum = sum + number
            sum += number;
        } while (number != 0);

        Console.Write($"The sum is: {sum}");
    }
}

// Reference: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-4.html