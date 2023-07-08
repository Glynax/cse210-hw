public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent()
    {
        // Perform necessary logic to record progress of the goal
        Console.WriteLine($"Progress made on eternal goal '{Name}'! Earned {Value} points.");
    }
}
