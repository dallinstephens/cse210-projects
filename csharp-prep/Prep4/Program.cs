using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Reference for using decimal instead of float or int: 
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
        // "List<decimal> numbers" declares a variable to hold the list.
        // "numbers = new List<decimal>()" is needed to use the list.
        List<decimal> numbers = new List<decimal>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        decimal number;

        // The variable sum is set to 0 initially.
        decimal sum = 0;

        // The variable largestNumber is set to 0 initially.
        decimal largestNumber = 0;

        // The variable smallestPositiveNumber is set to a very large number initially;
        decimal smallestPositiveNumber = 10000000000000000;

        do
        {
            Console.Write("Enter number: ");
            // "decimal.Parse()" is needed because Console.ReadLine is always a string.
            number = decimal.Parse(Console.ReadLine());

            // Adds the number the user entered to the list called numbers.
            numbers.Add(number);

            // sum = sum + number
            sum += number;

            // Find the largest number in the list.
            if (largestNumber < number)
            {
                largestNumber = number;
            }

            // Find the smallest positive number in the list.
            if (number > 0 && smallestPositiveNumber > number)
            {
                smallestPositiveNumber = number;
            }
        } while (number != 0);

        Console.WriteLine($"The sum is: {sum}");

        // Reference: https://www.techiedelight.com/remove-last-element-from-a-list-in-csharp/
        // Remove "0" from the list called numbers which is the last number in the list.
        // RemoveAt(index) - removes the element at the specificied index.
        // The index of the last element in the list is "numbers.Count - 1" where numbers.Count
        // is the current number of elements in the list. 
        numbers.RemoveAt(numbers.Count - 1);

        decimal avg = sum / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        Console.WriteLine($"The largest number is: {largestNumber}");

        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        // Reference: https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-sort-a-C-Sharp-list-items/
        // Sort the numbers in the list and display the new, sorted list.
        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (decimal num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

// Reference: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-4.html