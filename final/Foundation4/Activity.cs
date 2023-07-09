class Activity
{
    private string name;
    protected int minutes;

    public Activity(string name, int minutes)
    {
        this.name = name;
        this.minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Base class does not define distance calculation
    }

    public virtual double GetSpeed()
    {
        return 0; // Base class does not define speed calculation
    }

    public virtual double GetPace()
    {
        return 0; // Base class does not define pace calculation
    }

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"Activity: {name}\n" +
               $"Duration: {minutes} minutes\n" +
               $"Distance: {distance} miles\n" +
               $"Speed: {speed} mph\n" +
               $"Pace: {pace} min/mile\n";
    }
}