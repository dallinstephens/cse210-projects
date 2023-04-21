using System;

class Program
{

    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string gradePercentageString = Console.ReadLine();

        int gradePercentageInteger = int.Parse(gradePercentageString);

        // "The variable letter is initially assigned to keep the program from crashing.
        string letter = "";

        if (gradePercentageInteger >= 90)
        {
            letter = "A";
        }
        else if (gradePercentageInteger >= 80)
        {
            letter = "B";
        }
        else if (gradePercentageInteger >= 70)
        {
            letter = "C";
        }
        else if (gradePercentageInteger >= 60)
        {
            letter = "D";
        }
        else if (gradePercentageInteger >= 0 && gradePercentageInteger < 60)
        {
            letter = "F";
        }
        else 
        {
            Console.Write("The percentage you entered is invalid. Please try again.");
        }
        // Reference on operator modulus "%" to find the remainder: https://www.w3schools.com/cs/cs_operators.php
        // The variable lastDigit is the remainder to figure out if the sign if the letter grade is +, -, or nothing.
        int lastDigit = gradePercentageInteger % 10;

        // The variable sign is assigned initially to prevent program crash.
        string sign = "";

        // This if statement is so that there is no "A+" grade, just "A" and that there is no "F+" or "F-", just "F".
        if (gradePercentageInteger >= 97 || gradePercentageInteger < 60)
        {
            sign = "";
        } 
        else if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (gradePercentageInteger >= 0 && gradePercentageInteger <= 120)
        {
            Console.Write($"Letter Grade: {letter}{sign}");
        }
        else
        {
        }

        if (gradePercentageInteger >= 70)
        {
            Console.Write("\nCongratulations! You passed the course.");
        }
        else if (gradePercentageInteger < 70)
        {
            Console.Write("\nSorry, you did not pass the course. Keep trying though and you'll get it!");
        }
        else
        {         
        }
    }
}