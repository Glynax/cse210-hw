public class NegativeGoal : Goal
{
    public NegativeGoal(string name, int value) : base(name, value) { }

    public override void RecordEvent()
    {
        // Perform necessary logic to record completion of the negative goal
        Console.WriteLine($"Negative goal '{Name}' completed! Lost {Value} points.");
    }
}