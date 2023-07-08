public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletionCount { get; private set; }

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        CompletionCount = 0;
    }

    public override void RecordEvent()
    {
        CompletionCount++;
        if (CompletionCount >= TargetCount)
        {
            // Perform necessary logic to record completion of the checklist goal
            Console.WriteLine($"Checklist goal '{Name}' completed! Earned {Value + 500} points.");
        }
        else
        {
            // Perform necessary logic to record progress of the checklist goal
            Console.WriteLine($"Progress made on checklist goal '{Name}'! Earned {Value} points.");
        }
    }
}