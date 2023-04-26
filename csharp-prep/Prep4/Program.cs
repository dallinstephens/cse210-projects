using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Reference for using int instead of float or int: 
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
        // "List<int> numbers" declares a variable to hold the list.
        // "numbers = new List<int>()" is needed to use the list.
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;

        do
        {
            Console.Write("Enter number: ");
            // "int.Parse()" is needed because Console.ReadLine is always a string.
            number = int.Parse(Console.ReadLine());

            // Adds the number the user entered to the list called numbers.
            // If the number entered by the user is 0, do not add it to the list.
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // COMPUTE THE SUM.
        // The variable sum is set to 0 initially
        int sum = 0;

        foreach (int num in numbers)
        {
            // sum = sum + num
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Reference: https://www.techiedelight.com/remove-last-element-from-a-list-in-csharp/
        // Remove "0" from the list called numbers which is the last number in the list.
        // RemoveAt(index) - removes the element at the specificied index.
        // The index of the last element in the list is "numbers.Count - 1" where numbers.Count
        // is the current number of elements in the list.
        // Line below is no longer needed because 0 is not addeded to the list (see above). 
        // numbers.RemoveAt(numbers.Count - 1);

        // COMPUTE THE AVERAGE.
        // (float)sum is needed so that a decimal will be computed.
        float avg = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        // FIND THE LARGEST NUMBER IN THE LIST.
        int largestNumber = numbers[0];

        foreach (int num in numbers)
        {
            if (largestNumber < num)
            {
                largestNumber = num;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");

        // FIND THE SMALLEST NUMBER IN THE LIST.
        int smallestPositiveNumber = numbers[0];

        foreach (int num in numbers)
        {
            if (num > 0 && smallestPositiveNumber > num)
            {
                smallestPositiveNumber = num;
            }
        }     

        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        // Reference: https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-sort-a-C-Sharp-list-items/
        // Sort the numbers in the list and display the new, sorted list.
        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

// Reference: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-4.html
// Solution Reference that helped me come up with this newer version: 
// https://github.com/byui-cse/cse210-student-sample-solutions/blob/main/csharp-prep/Prep4/Program.cs 