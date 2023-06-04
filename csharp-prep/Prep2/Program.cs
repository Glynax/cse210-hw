using System;

class Program
{
    static void Main(string[] args)
    {
       
       Console.WriteLine("Enter your grade percentage:");
        int gradePercentage = Convert.ToInt32(Console.ReadLine());

        string letter;

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course.");
        }
        else
        {
            Console.WriteLine("You have failed the course.");
        }



    }
}