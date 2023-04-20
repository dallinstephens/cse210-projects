using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string gradePercentageString = Console.ReadLine();

        int gradePercentageInteger = int.Parse(gradePercentageString);
        
        if (gradePercentageInteger >= 90)
        {
            Console.Write("Letter Grade: A");
        }
        else if (gradePercentageInteger >= 80)
        {
            Console.Write("Letter Grade: B");
        }
        else if (gradePercentageInteger >= 70)
        {
            Console.Write("Letter Grade: C");
        }
        else if (gradePercentageInteger >= 60)
        {
            Console.Write("Letter Grade: D");
        }
        else if (gradePercentageInteger >= 0 && gradePercentageInteger < 60)
        {
            Console.Write("Letter Grade: F");
        }
        else 
        {
            Console.Write("The percentage you entered is invalid. Please try again.");
        }                               
    }
}