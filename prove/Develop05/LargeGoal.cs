public class LargeGoal : Goal
{
    public int Progress { get; private set; }
    public int Target { get; set; }
    public int ProgressValue { get; set; }

    public LargeGoal(string name, int value, int target, int progressValue) : base(name, value)
    {
        Progress = 0;
        Target = target;
        ProgressValue = progressValue;
    }

    public override void RecordEvent()
    {
        if (Progress < Target)
        {
            Progress += ProgressValue;
            if (Progress >= Target)
            {
                // Perform necessary logic to record completion of the large goal
                Console.WriteLine($"Large goal '{Name}' completed! Earned {Value} points.");
            }
            else
            {
                // Perform necessary logic to record progress of the large goal
                Console.WriteLine($"Progress made on large goal '{Name}'! Earned {ProgressValue} points.");
            }
        }
        else
        {
            Console.WriteLine($"Large goal '{Name}' already completed! No additional points earned.");
        }
    }
}