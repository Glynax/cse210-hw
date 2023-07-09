class CyclingActivity : Activity
{
    private double miles;

    public CyclingActivity(string name, int minutes, double miles) : base(name, minutes)
    {
        this.miles = miles;
    }

    public override double GetDistance()
    {
        return miles;
    }

    public override double GetSpeed()
    {
        return miles / (minutes / 60.0);
    }

    public override double GetPace()
    {
        return minutes / miles;
    }
}