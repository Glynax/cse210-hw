using System;

class Program
{
    static void Main(string[] args)
    {
        
         List<Goal> goals = new List<Goal>();

        // Create and add simple goals
        SimpleGoal marathonGoal = new SimpleGoal("Run a marathon", 1000);
        goals.Add(marathonGoal);

        // Create and add eternal goals
        EternalGoal scripturesGoal = new EternalGoal("Read scriptures", 100);
        goals.Add(scripturesGoal);

        // Create and add checklist goals
        ChecklistGoal templeGoal = new ChecklistGoal("Attend the temple", 50, 10);
        goals.Add(templeGoal);

        // Create and add large goals
        LargeGoal largeGoal = new LargeGoal("Large goal", 500, 100, 5);
        goals.Add(largeGoal);

        // Create and add negative goals
        NegativeGoal badHabitGoal = new NegativeGoal("Stop bad habit", -200);
        goals.Add(badHabitGoal);

        // Record events for the goals
        foreach (Goal goal in goals)
        {
            goal.RecordEvent();
        }

        // Display goal details
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"Goal: {goal.Name}");
            Console.WriteLine($"Completed: {goal.GetStatus()}");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"Completion count: {checklistGoal.CompletionCount}/{checklistGoal.TargetCount}");
            }
            else if (goal is LargeGoal lGoal)
            {
                Console.WriteLine($"Progress: {lGoal.Progress}/{lGoal.Target}");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}