using System;
using System.Collections.Generic;
using System.Threading;

// Breathing Activity class
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing.")
    {
    }

    public override void Start()
    {
        Console.WriteLine("\n{0}\n\n{1}\n", name, description);
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Thread.Sleep(3000);

        Console.WriteLine("\nStart breathing in and out...\n");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000);
        }

        End();
    }
}
