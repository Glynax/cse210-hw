public abstract class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool Completed { get; protected set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        Completed = false;
    }

    public abstract void RecordEvent();

    public virtual string GetStatus()
    {
        return Completed ? "Completed" : "Not completed";
    }
}
