public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent()
    {
        // Perform necessary logic to record completion of the goal
        Console.WriteLine($"Goal '{Name}' completed! Earned {Value} points.");
    }
}