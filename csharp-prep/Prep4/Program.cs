using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
       List<int> numbers = new List<int>();

       Console.WriteLine("Enter a series of numbers. Enter 0 to stop.");

        int input;
        do
        {
            Console.Write("Number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        while (input != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (double)sum / numbers.Count;

        int maximum = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Maximum: " + maximum);


    }
}