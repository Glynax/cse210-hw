using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity("Morning Run", 45, 5);
        activities.Add(running);

        SwimmingActivity swimming = new SwimmingActivity("Pool Workout", 60, 20);
        activities.Add(swimming);

        CyclingActivity cycling = new CyclingActivity("Afternoon Ride", 90, 15);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}