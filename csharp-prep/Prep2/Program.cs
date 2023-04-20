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

        if (gradePercentageInteger >= 0 && gradePercentageInteger <= 120)
        {
            Console.Write($"Letter Grade: {letter}");
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