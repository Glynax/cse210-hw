using System;
using System.Collections.Generic;
using System.Threading;

// Listing Activity class
public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many items as you can in a certain area.")
    {
    }

    public override void Start()
    {
        Console.WriteLine("\n{0}\n\n{1}\n", name, description);
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Thread.Sleep(3000);

        Random random = new Random();
        int itemCounter = 0;

        while (duration > 0)
        {
            string prompt = prompts[random.Next(prompts.Count)];

            Console.WriteLine("\nPrompt: {0}", prompt);
            Thread.Sleep(2000);
            ShowSpinner(3);

            Console.Write("\nEnter items (one per line, empty line to finish): ");
            string input = Console.ReadLine();

            int itemCount = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Length;
            itemCounter += itemCount;
            duration -= 5;

            Console.WriteLine("\n{0} items entered.", itemCount);
            Thread.Sleep(2000);
            ShowSpinner(3);
        }

        Console.WriteLine("\nTotal items entered: {0}", itemCounter);

        End();
    }
}
